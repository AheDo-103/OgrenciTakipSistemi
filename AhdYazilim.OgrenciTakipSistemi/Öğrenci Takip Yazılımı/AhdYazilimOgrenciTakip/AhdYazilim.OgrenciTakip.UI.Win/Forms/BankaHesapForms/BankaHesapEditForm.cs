using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Functions;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;
using System;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.BankaHesapForms
{
    public partial class BankaHesapEditForm : BaseEditForm
    {
        public BankaHesapEditForm()
        {
            InitializeComponent();

            txtHesapTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<BankaHesapTuru>());

            Bll = new BankaHesapBll(myDataLayoutControl);
            DataLayoutControl = myDataLayoutControl;
            KartTuru = KartTuru.BankaHesap;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new BankaHesapS() : ((BankaHesapBll)Bll).Single(FilterFunctions.Filter<BankaHesap>(Id));
            NesneyiKontrollereBagla();
            if (IslemTuru != IslemTuru.EntityInsert) return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BankaHesapBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId);
            txtHesapAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (BankaHesapS)OldEntity;

            txtKod.Text = entity.Kod;
            txtHesapAdi.Text = entity.HesapAdi;
            txtHesapTuru.SelectedItem = entity.HesapTuru.ToName();
            txtBlokeGunSayisi.Value = entity.BlokeGunSayisi;
            txtIsyeriNo.Text = entity.IsYeriNo;
            txtTerminalNo.Text = entity.TerminalNo;
            txtBanka.Id = entity.BankaId;
            txtBanka.Text = entity.BankaAdi;
            txtBankaSube.Id = entity.BankaSubeId;
            txtBankaSube.Text = entity.BankaSubeAdi;
            txtHesapAcilisTarihi.DateTime = entity.HesapAcilisTarihi.Date;
            txtHesapNo.Text = entity.HesapNo;
            txtIbanNo.Text = entity.IbanNo;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new BankaHesap
            {
                Id = Id,
                Kod = txtKod.Text,
                HesapAdi = txtHesapAdi.Text,
                HesapTuru = txtHesapTuru.Text.GetEnum<BankaHesapTuru>(),
                BlokeGunSayisi = (byte)txtBlokeGunSayisi.Value,
                IsYeriNo = txtIsyeriNo.Text,
                TerminalNo = txtTerminalNo.Text,
                BankaId = Convert.ToInt64(txtBanka.Id),
                BankaSubeId = Convert.ToInt64(txtBankaSube.Id),
                HesapAcilisTarihi = txtHesapAcilisTarihi.DateTime,
                HesapNo = txtHesapNo.Text,
                IbanNo = txtIbanNo.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn,
                SubeId = AnaForm.SubeId,
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((BankaHesapBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override bool EntityUpdate()
        {
            return ((BankaHesapBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtBanka)
                    sec.Sec(txtBanka);
                else if (sender == txtBankaSube)
                    sec.Sec(txtBankaSube, txtBanka);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.BankaHesap);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.BankaHesap);
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtBanka) return;
            txtBanka.ControlEnabledChanged(txtBankaSube);
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edt)) return;

            var hesapTuru = edt.Text.GetEnum<BankaHesapTuru>();

            if (hesapTuru == BankaHesapTuru.EposBlokeHesabi || hesapTuru == BankaHesapTuru.OtsBlokeHesabi || hesapTuru == BankaHesapTuru.PosBlokeHesabi)
            {
                txtBlokeGunSayisi.Enabled = true;
                txtIsyeriNo.Enabled = true;
                txtTerminalNo.Enabled = true;
            }
            else
            {
                txtBlokeGunSayisi.Enabled = false;
                txtIsyeriNo.Enabled = false;
                txtTerminalNo.Enabled = false;

                txtBlokeGunSayisi.Value = 0;
                txtIsyeriNo.Text = null;
                txtTerminalNo.Text = null;
            }
        }
    }
}