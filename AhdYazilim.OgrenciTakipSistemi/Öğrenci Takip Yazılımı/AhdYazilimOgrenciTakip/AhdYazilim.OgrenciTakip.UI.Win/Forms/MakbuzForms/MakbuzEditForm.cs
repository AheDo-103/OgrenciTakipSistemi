using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Functions;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class MakbuzEditForm : BaseEditForm
    {
        #region Variables

        protected internal MakbuzTuru MakbuzTuru;
        private MakbuzHesapTuru _hesapTuru;

        #endregion

        public MakbuzEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MakbuzBll(myDataLayoutControl);
            KartTuru = KartTuru.Makbuz;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni };
            ShowItems = new BarItem[] { btnYazdir };


            KayitSonrasiFormuKapat = false;
        }

        public MakbuzEditForm(params object[] prm) : this()
        {
            MakbuzTuru = (MakbuzTuru)prm[0];
            _hesapTuru = (MakbuzHesapTuru)prm[1];
            FarkliSubeIslemi = prm.Length > 2 && prm[2].GetType() == typeof(bool) ? (bool)prm[2] : false;
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new MakbuzS() : ((MakbuzBll)Bll).Single(FilterFunctions.Filter<Makbuz>(Id));
            AlanIslemler();
            NesneyiKontrollereBagla();
            TabloYukle();
            MakbuzTuruEnabled();

            if (IslemTuru != IslemTuru.EntityInsert) return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtMakbuzNo.Text = ((MakbuzBll)Bll).YeniKodVer(x => x.DonemId == AnaForm.DonemId && x.SubeId == AnaForm.SubeId);
            txtTarih.DateTime = DateTime.Now.Date;
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MakbuzS)OldEntity;

            txtMakbuzNo.Text = entity.Kod;
            txtTarih.DateTime = entity.Tarih;
            txtHesapTuru.SelectedItem = _hesapTuru.ToName();
            if (IslemTuru == IslemTuru.EntityInsert)
            {
                switch (_hesapTuru)
                {
                    case MakbuzHesapTuru.Kasa when AnaForm.DefaultKasaHesapId != null:
                        txtHesap.Id = AnaForm.DefaultKasaHesapId;
                        txtHesap.Text = AnaForm.DefaultKasaHesapAdi;
                        break;

                    case MakbuzHesapTuru.Banka when AnaForm.DefaultBankaHesapId != null:
                        txtHesap.Id = AnaForm.DefaultBankaHesapId;
                        txtHesap.Text = AnaForm.DefaultBankaHesapAdi;
                        break;

                    case MakbuzHesapTuru.Avukat when AnaForm.DefaultAvukatHesapId != null:
                        txtHesap.Id = AnaForm.DefaultAvukatHesapId;
                        txtHesap.Text = AnaForm.DefaultAvukatHesapAdi;
                        break;

                    case MakbuzHesapTuru.Transfer when MakbuzTuru == MakbuzTuru.GelenBelgeyiOnaylama:
                        txtHesap.Enabled = false;
                        txtHesap.Id = AnaForm.SubeId;
                        txtHesap.Text = AnaForm.SubeAdi;
                        break;
                }
            }
            else
            {
                txtHesap.Id = entity.AvukatHesapId ?? entity.BankaHesapId ?? entity.CariHesapId ?? entity.KasaHesapId ?? entity.SubeHesapId;
                txtHesap.Text = entity.HesapAdi;
            }
            //txtHesap.Text = entity.HesapAdi;
        }

        protected override void GuncelNesneOlustur()
        {
            var hesapTuru = txtHesapTuru.Text.GetEnum<MakbuzHesapTuru>();

            CurrentEntity = new Makbuz
            {
                Id = Id,
                Kod = txtMakbuzNo.Text,
                Tarih = txtTarih.DateTime.Date,
                MakbuzTuru = MakbuzTuru,
                HesapTuru = hesapTuru,
                AvukatHesapId = hesapTuru == MakbuzHesapTuru.Avukat ? txtHesap.Id : null,
                BankaHesapId = hesapTuru == MakbuzHesapTuru.Banka || hesapTuru == MakbuzHesapTuru.Epos || hesapTuru == MakbuzHesapTuru.Ots || hesapTuru == MakbuzHesapTuru.Pos ? txtHesap.Id : null,
                CariHesapId = hesapTuru == MakbuzHesapTuru.Cari || hesapTuru == MakbuzHesapTuru.Mahsup ? txtHesap.Id : null,
                KasaHesapId = hesapTuru == MakbuzHesapTuru.Kasa ? txtHesap.Id : null,
                SubeHesapId = hesapTuru == MakbuzHesapTuru.Transfer ? txtHesap.Id : null,
                HareketSayisi = makbuzHareketleriTable.Tablo.DataRowCount,
                //MakbuzToplami = makbuzHareketleriTable.Tablo.DataController.ListSource.Cast<MakbuzHareketleriL>().Sum(x => x.IslemTutari),
                MakbuzToplami = Convert.ToDecimal(makbuzHareketleriTable.colIslemTutari.SummaryText),
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            GuncelNesneOlustur();

            if (HataliGiris()) return false;
            if (makbuzHareketleriTable.HataliGiris()) return false;

            /*br*/
            var result = ((MakbuzBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && makbuzHareketleriTable.Kaydet();
            //if (result && !KayitSonrasiFormuKapat)
            //    makbuzHareketleriTable.Kaydet();

            return result;
        }

        protected override bool EntityUpdate()
        {
            GuncelNesneOlustur();

            if (HataliGiris()) return false;
            if (makbuzHareketleriTable.HataliGiris()) return false;

            var result = ((MakbuzBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && makbuzHareketleriTable.Kaydet();
            //if (result && !KayitSonrasiFormuKapat)
            //    makbuzHareketleriTable.Kaydet();

            return result;
        }

        protected override void EntityDelete()
        {
            if (!makbuzHareketleriTable.TopluHareketSil()) return;
            if (!((IBaseCommonBll)Bll).Delete(OldEntity)) return;
            RefreshYapilacak = true;
            Close();
        }

        private void AlanIslemler()
        {
            Text = $"{Text} - {MakbuzTuru.ToName()}";
            txtTarih.Properties.MinValue = AnaForm.GunTarihininOncesineMakbuzTarihiGirilebilir ? AnaForm.DonemBaslamaTarihi : DateTime.Now.Date;
            txtTarih.Properties.MaxValue = AnaForm.GunTarihininSonrasinaMakbuzTarihiGirilebilir ? AnaForm.DonemBitisTarihi : DateTime.Now.Date;

            switch (MakbuzTuru)
            {
                case MakbuzTuru.BlokeyeAlma:
                case MakbuzTuru.BlokeCozumu:
                    txtHesapTuru.Properties.Items.AddRange(Enum.GetValues(typeof(MakbuzHesapTuru))
                        .Cast<MakbuzHesapTuru>()
                        .Where(x => x == MakbuzHesapTuru.Epos || x == MakbuzHesapTuru.Ots || x == MakbuzHesapTuru.Pos)
                        .Select(x => x.ToName()).ToList());
                    break;

                case MakbuzTuru.PortfoyeGeriIade:
                case MakbuzTuru.PortfoyeKarsiliksizIade:
                    txtHesapTuru.Properties.Items.AddRange(Enum.GetValues(typeof(MakbuzHesapTuru))
                        .Cast<MakbuzHesapTuru>()
                        .Where(x => x == MakbuzHesapTuru.Avukat || x == MakbuzHesapTuru.Banka || x == MakbuzHesapTuru.Cari)
                        .Select(x => x.ToName()).ToList());
                    break;

                case MakbuzTuru.OdenmisOlarakIsaretleme:
                case MakbuzTuru.KarsiliksizOlarakIsaretleme:
                case MakbuzTuru.MusteriyeGeriIade:
                case MakbuzTuru.TahsiliImkansizHaleGelme:
                    txtHesapTuru.Properties.Items.Add(_hesapTuru.ToName());
                    layoutHesap.Visibility = LayoutVisibility.Never;
                    break;

                default:
                    txtHesapTuru.Properties.Items.Add(_hesapTuru.ToName());
                    break;
            }
        }

        protected internal void MakbuzTuruEnabled()
        {
            switch (MakbuzTuru)
            {
                case MakbuzTuru.BlokeyeAlma:
                case MakbuzTuru.BlokeCozumu:
                case MakbuzTuru.PortfoyeGeriIade:
                case MakbuzTuru.PortfoyeKarsiliksizIade:
                case MakbuzTuru.AvukataGonderme:
                case MakbuzTuru.AvukatYoluylaTahsilEtme:
                case MakbuzTuru.BankayaTahsileGonderme:
                case MakbuzTuru.BankaYoluylaTahsilEtme:
                case MakbuzTuru.CiroEtme:
                case MakbuzTuru.BaskaSubeyeGonderme:
                    txtHesap.Enabled = makbuzHareketleriTable.Tablo.DataRowCount == 0;
                    txtHesapTuru.Enabled = makbuzHareketleriTable.Tablo.DataRowCount == 0;
                    break;


                case MakbuzTuru.GelenBelgeyiOnaylama:
                    txtHesapTuru.Enabled = false;
                    txtHesap.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                switch (txtHesapTuru.Text.GetEnum<MakbuzHesapTuru>())
                {
                    case MakbuzHesapTuru.Avukat:
                        sec.Sec(txtHesap, KartTuru.Avukat);
                        break;

                    case MakbuzHesapTuru.Banka:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.VadesizMevduatHesabi);
                        break;

                    case MakbuzHesapTuru.Cari:
                    case MakbuzHesapTuru.Mahsup:
                        sec.Sec(txtHesap, KartTuru.Cari);
                        break;

                    case MakbuzHesapTuru.Epos:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.EposBlokeHesabi);
                        break;

                    case MakbuzHesapTuru.Ots:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.OtsBlokeHesabi);
                        break;

                    case MakbuzHesapTuru.Pos:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.PosBlokeHesabi);
                        break;

                    case MakbuzHesapTuru.Kasa:
                        sec.Sec(txtHesap, KartTuru.Kasa);
                        break;

                    case MakbuzHesapTuru.Transfer:
                        //sec.Sec(txtHesap, KartTuru.Sube); Sonradan açıcaz.
                        break;
                }
            }
        }

        protected override void Yazdir()
        {
            var source = new List<MakbuzHareketleriR>();
            for (int i = 0; i < makbuzHareketleriTable.Tablo.DataRowCount; i++)
            {
                var entity = makbuzHareketleriTable.Tablo.GetRow<MakbuzHareketleriL>(i);
                if (entity == null) return;
                var row = new MakbuzHareketleriR
                {
                    PortfoyNo = entity.OdemeBilgileriId,
                    OgrenciNo = entity.OgrenciNo,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    SinifAdi = entity.SinifAdi,
                    SubeAdi = entity.OgrenciSubeAdi,
                    OdemeTuruAdi = entity.OdemeTuruAdi,
                    Vade = entity.Vade,
                    AsilBorclu = entity.AsilBorclu,
                    Ciranta = entity.Ciranta,
                    BankaVeSubeAdi = entity.BankaAdi + " / " + entity.BankaSubeAdi,
                    BelgeNo = entity.BelgeNo,
                    HesapNo = entity.HesapNo,
                    Tutar = entity.Tutar,
                    IslemTutari = entity.IslemTutari,
                    IslemOncesiTutar = entity.IslemOncesiTutar,
                    Tarih = txtTarih.DateTime.Date,
                    MakbuzNo = txtMakbuzNo.Text,
                    MakbuzTuru = MakbuzTuru.ToName(),
                    HesapTuru = _hesapTuru.ToName(),
                    HesapAdi = txtHesap.Text,
                    BelgeDurumu = entity.BelgeDurumu.ToName(),
                };

                source.Add(row);
            }

            ShowListForms<RaporSecim>.ShowDialogListForm(KartTuru.Rapor, false, RaporBolumTuru.MakbuzRaporlari, source);
        }

        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            if (FarkliSubeIslemi)
                GeneralFunctions.ButonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil);
            else
                GeneralFunctions.ButonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity, makbuzHareketleriTable.TableValueChanged);
        }

        protected internal bool HataliGiris()
        {
            if (!txtHesap.Visible || txtHesap.Id != null) return false;
            Messages.SecimHataMesaji("Hesap");
            txtHesap.Focus();
            return true;
        }

        protected override void TabloYukle()
        {
            makbuzHareketleriTable.OwnerForm = this;
            makbuzHareketleriTable.Yukle();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtHesapTuru) return;
            txtHesap.Id = null;
            txtHesap.Text = null;
            txtHesap.Focus();
        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            if (layoutHesap.Visible && txtHesap.Id == null)
                txtHesap.Focus();
            else
                makbuzHareketleriTable.Tablo.GridControl.Focus();
        }
    }
}