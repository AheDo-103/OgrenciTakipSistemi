﻿using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Functions;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.Tahakkuk_Forms
{
    public partial class TopluOdemePlaniEditForm : BaseEditForm
    {
        #region Variables

        private readonly IList _source;
        private byte _blokeGunSayisi;

        private readonly long _tahakkukId;
        private readonly decimal _bakiye;
        private readonly DateTime _kayitTarihi;
        private readonly int _dahaOnceGirilenTaksitSayisi;
        private OdemeTipi _odemeTipi;

        #endregion

        public TopluOdemePlaniEditForm(params object[] prm)//IList source, long tahakkukId, decimal bakiye, DateTime kayitTarihi, int dahaOnceGirilenTaksitSayisi)
        {
            InitializeComponent();

            _source = (IList)prm[0];
            _tahakkukId = (long)prm[1];
            _bakiye = (decimal)prm[2];
            _kayitTarihi = (DateTime)prm[3];
            _dahaOnceGirilenTaksitSayisi = (int)prm[4];

            DataLayoutControl = myDataLayoutControl;
            ShowItems = new BarItem[] { btnTaksitOlustur };
            HideItems = new BarItem[] { btnYeni, btnKaydet, btnFarkliKaydet, btnGeriAl, btnSil };
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            ControlEnabledChange(OdemeTipi.Acik);
            txtIlkTaksitTarihi.DateTime = _kayitTarihi;
            txtIlkTaksitTarihi.Properties.MinValue = _kayitTarihi;
            txtIlkTaksitTarihi.Properties.MaxValue = AnaForm.MaksimumTaksitTarihi;
            txtSabitTaksit.Value = 0;
            txtBakiye.Value = _bakiye;
            txtTaksitSayisi.Properties.MinValue = 1;
            txtTaksitSayisi.Properties.MaxValue = AnaForm.MaksimumTaksitSayisi - _dahaOnceGirilenTaksitSayisi;

            if (AnaForm.MaksimumTaksitSayisi - _dahaOnceGirilenTaksitSayisi > 0)
                ShowDialog();
            else
                Messages.HataMesaji("Maksimum Taksit Sayısı Aşılıyor.");
        }

        private void ControlEnabledChange(OdemeTipi odemeTipi)
        {
            txtBankaHesap.Enabled = odemeTipi == OdemeTipi.Epos || odemeTipi == OdemeTipi.Ots || odemeTipi == OdemeTipi.Pos;
            txtAsilBorclu.Enabled = odemeTipi == OdemeTipi.Cek || odemeTipi == OdemeTipi.Senet;
            txtCiranta.Enabled = odemeTipi == OdemeTipi.Cek || odemeTipi == OdemeTipi.Senet;
            txtBanka.Enabled = odemeTipi == OdemeTipi.Cek;
            txtBankaSube.Enabled = odemeTipi == OdemeTipi.Cek;
            txtHesapNo.Enabled = odemeTipi == OdemeTipi.Cek;
            txtIlkBelgeNo.Enabled = odemeTipi == OdemeTipi.Cek;
            if (odemeTipi == OdemeTipi.Cek)
            {
                txtBanka.ControlEnabledChanged(txtBankaSube);
            }
        }

        private bool HataliGiris()
        {
            if (txtIlkTaksitTarihi.DateTime.Date.AddMonths((int)txtTaksitSayisi.Value - 1) > AnaForm.MaksimumTaksitTarihi)
            {
                Messages.HataMesaji("Maksimum Taksit Tarihine Aşılıyor.");
                return true;
            }

            if (txtOdemeTuru.Id == null)
            {
                Messages.HataMesaji("Ödeme Türü Seçimi Yapmalısınız.");
                txtOdemeTuru.Focus();
                return true;
            }

            if ((_odemeTipi == OdemeTipi.Epos || _odemeTipi == OdemeTipi.Ots || _odemeTipi == OdemeTipi.Pos) && txtBankaHesap.Id == null)
            {
                Messages.SecimHataMesaji("Banka Hesap");
                txtBankaHesap.Focus();
                return true;
            }

            if (txtSabitTaksit.Value == 0 && txtBakiye.Value == 0 || txtSabitTaksit.Value > 0 && txtBakiye.Value > 0)
            {
                Messages.HataMesaji("Sabit Taksit Veya Bakiye Alanlarından Sadece Birisinin Değeri Sıfıra(0) Eşit Veya Sıfırdan(0) Büyük Olmalıdır.");
                txtSabitTaksit.Focus();
                return true;
            }

            if ((_odemeTipi == OdemeTipi.Senet || _odemeTipi == OdemeTipi.Cek) && string.IsNullOrEmpty(txtAsilBorclu.Text))
            {
                Messages.HataliVeriMesaji("Asıl Borçlu");
                txtAsilBorclu.Focus();
                return true;
            }

            switch (_odemeTipi)
            {
                case OdemeTipi.Cek when txtBanka.Id == null:
                    Messages.SecimHataMesaji("Banka");
                    txtBanka.Focus();
                    return true;

                case OdemeTipi.Cek when txtBankaSube.Id == null:
                    Messages.SecimHataMesaji("Banka Şube");
                    txtBankaSube.Focus();
                    return true;

                case OdemeTipi.Cek when txtIlkBelgeNo.Value == 0:
                    Messages.HataliVeriMesaji("İlk Belge No");
                    txtIlkBelgeNo.Focus();
                    return true;
            }

            return false;
        }

        protected override void TaksitOlustur()
        {
            if (HataliGiris()) return;
            txtOdemeTuru.Focus();

            var tutar = txtSabitTaksit.Value != 0 ? txtSabitTaksit.Value : Math.Round(txtBakiye.Value / txtTaksitSayisi.Value, AnaForm.OdemePlaniKurusKullan ? 2 : 0);
            decimal toplamGirilenTutar = 0;

            for (int i = 0; i < txtTaksitSayisi.Value; i++)
            {
                var taksit = new OdemeBilgileriL()
                {
                    Id = 0,
                    TahakkukId = _tahakkukId,
                    OdemeTipi = _odemeTipi,
                    OdemeTuruId = (long)txtOdemeTuru.Id,
                    OdemeTuruAdi = txtOdemeTuru.Text,
                    GirisTarihi = DateTime.Now.Date,
                    Vade = txtIlkTaksitTarihi.DateTime.Date.AddMonths(i),
                    HesabaGecisTarihi = txtIlkTaksitTarihi.DateTime.Date.AddMonths(i),
                    Tutar = i == txtTaksitSayisi.Value - 1 && txtSabitTaksit.Value == 0 ? txtBakiye.Value - toplamGirilenTutar : tutar,
                    BelgeDurumu = BelgeDurumu.Portfoyde,
                    Insert = true,
                };

                taksit.TutarYazi = taksit.Tutar.YaziIleTutar();
                taksit.VadeYazi = taksit.Vade.YaziIleVade();
                taksit.Kalan = tutar;
                toplamGirilenTutar += taksit.Tutar;

                switch (_odemeTipi)
                {
                    case OdemeTipi.Epos:
                    case OdemeTipi.Ots:
                    case OdemeTipi.Pos:
                        taksit.BankaHesapId = txtBankaHesap.Id;
                        taksit.BankaHesapAdi = txtBankaHesap.Text;
                        taksit.BlokeGunSayisi = _blokeGunSayisi;
                        taksit.HesabaGecisTarihi = taksit.Vade.Date.AddDays(_blokeGunSayisi);
                        break;

                    case OdemeTipi.Senet:
                        taksit.AsilBorclu = txtAsilBorclu.Text;
                        taksit.Ciranta = txtCiranta.Text;
                        break;

                    case OdemeTipi.Cek:
                        taksit.AsilBorclu = txtAsilBorclu.Text;
                        taksit.Ciranta = txtCiranta.Text;
                        taksit.BankaId = txtBanka.Id;
                        taksit.BankaAdi = txtBanka.Text;
                        taksit.BankaSubeId = txtBankaSube.Id;
                        taksit.BankaSubeAdi = txtBankaSube.Text;
                        taksit.HesapNo = txtHesapNo.Text;
                        taksit.BelgeNo = ((int)txtIlkBelgeNo.Value + i).ToString();
                        break;
                }

                _source.Add(taksit);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtOdemeTuru)
                    sec.Sec(txtOdemeTuru);

                else if (sender == txtBankaHesap)
                    sec.Sec(txtBankaHesap, _odemeTipi);

                else if (sender == txtBanka)
                    sec.Sec(txtBanka);

                else if (sender == txtBankaSube)
                    sec.Sec(txtBankaSube, txtBanka);
            }
        }

        protected override void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (sender == txtOdemeTuru)
            {
                _odemeTipi = txtOdemeTuru.Id == null ? OdemeTipi.Acik : txtOdemeTuru.Tag.ToString().GetEnum<OdemeTipi>();
                ControlEnabledChange(_odemeTipi);
                txtBankaHesap.Id = null;
                txtBankaHesap.Text = null;
            }

            else if (sender == txtBankaHesap)
                _blokeGunSayisi = Convert.ToByte(txtBankaHesap.Tag);

            else if (sender == txtBanka)
            {
                txtBankaSube.Id = null;
                txtBankaSube.Text = null;
            }
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtBanka) return;
            txtBanka.ControlEnabledChanged(txtBankaSube);
        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
            if (DialogResult != DialogResult.Cancel) return;

            if (Messages.HayirSeciliEvetHayir("Taksit Oluşturma Ekranı Kapatılıcaktır. Onaylıyor Musunuz?", "Kapatma Onayı") == DialogResult.No)
                e.Cancel = true;
        }
    }
}