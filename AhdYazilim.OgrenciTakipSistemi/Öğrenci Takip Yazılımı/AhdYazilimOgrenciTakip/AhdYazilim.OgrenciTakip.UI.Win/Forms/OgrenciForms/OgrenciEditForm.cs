using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Functions;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.OgrenciForms
{
    public partial class OgrenciEditForm : BaseEditForm
    {
        public OgrenciEditForm()
        {
            InitializeComponent();

            txtKanGrubu.Properties.Items.AddRange(new string[] { "Boş", "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" });
            txtCinsiyet.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<Cinsiyet>());

            Bll = new OgrenciBll(myDataLayoutControl);
            DataLayoutControl = myDataLayoutControl;
            KartTuru = KartTuru.Ogrenci;
            EventsLoad();
            btnResimBuyut.ItemClick += BtnResimBuyut_ItemClick;
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new OgrenciS() : ((OgrenciBll)Bll).Single(FilterFunctions.Filter<Ogrenci>(Id));
            NesneyiKontrollereBagla();
            if (IslemTuru != IslemTuru.EntityInsert) return;
            txtKanGrubu.SelectedIndex = 0;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((OgrenciBll)Bll).YeniKodVer();
            txtTcKimlikNumarasi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OgrenciS)OldEntity;

            txtKod.Text = entity.Kod;
            txtTcKimlikNumarasi.Text = entity.TcKimlikNo;
            txtAdi.Text = entity.Adi;
            txtSoyadi.Text = entity.Soyadi;
            txtCinsiyet.SelectedItem = entity.Cinsiyet.ToName();
            txtTelefon.Text = entity.Telefon1;
            txtKanGrubu.SelectedItem = entity.KanGrubu;
            txtBabaAdi.Text = entity.BabaAdi;
            txtAnaAdi.Text = entity.AnaAdi;
            txtDogumYeri.Text = entity.DogumYeri;
            txtDogumTarihi.EditValue = entity.DogumTarihi;
            txtSeriNo.Text = entity.KimlikSeri;
            txtSiraNo.Text = entity.KimlikSiraNo;
            txtNufusIl.Id = entity.KimlikIlId;
            txtNufusIl.Text = entity.KimlikIlAdi;
            txtNufusIlce.Id = entity.KimlikIlceId;
            txtNufusIlce.Text = entity.KimlikIlceAdi;
            txtMahalleKoy.Text = entity.KimlikMahalleKoy;
            txtCiltNo.Text = entity.KimlikCiltNo;
            txtAileSiraNo.Text = entity.KimlikAileSiraNo;
            txtBireySiraNo.Text = entity.KimlikBireySiraNo;
            txtVerildigiYer.Text = entity.KimlikVerildigiYer;
            txtVerilisNedeni.Text = entity.KimlikVerilisNedeni;
            txtKayitNo.Text = entity.KimlikKayitNo;
            txtVerilisTarihi.EditValue = entity.KimlikVerilisTarihi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtOzelKod3.Id = entity.OzelKod3Id;
            txtOzelKod3.Text = entity.OzelKod3Adi;
            txtOzelKod4.Id = entity.OzelKod4Id;
            txtOzelKod4.Text = entity.OzelKod4Adi;
            txtOzelKod5.Id = entity.OzelKod5Id;
            txtOzelKod5.Text = entity.OzelKod5Adi;
            imgResim.EditValue = entity.Resim;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Ogrenci
            {
                Id = Id,
                Kod = txtKod.Text,
                TcKimlikNo = txtTcKimlikNumarasi.Text,
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                Cinsiyet = txtCinsiyet.Text.GetEnum<Cinsiyet>(),
                Telefon1 = txtTelefon.Text,
                KanGrubu = txtKanGrubu.Text,
                BabaAdi = txtBabaAdi.Text,
                AnaAdi = txtAnaAdi.Text,
                DogumYeri = txtDogumYeri.Text,
                DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,
                KimlikSeri = txtSeriNo.Text,
                KimlikSiraNo = txtSiraNo.Text,
                KimlikIlId = txtNufusIl.Id,
                KimlikIlceId = txtNufusIlce.Id,
                KimlikMahalleKoy = txtMahalleKoy.Text,
                KimlikCiltNo = txtCiltNo.Text,
                KimlikAileSiraNo = txtAileSiraNo.Text,
                KimlikBireySiraNo = txtBireySiraNo.Text,
                KimlikVerildigiYer = txtVerildigiYer.Text,
                KimlikVerilisNedeni = txtVerilisNedeni.Text,
                KimlikKayitNo = txtKayitNo.Text,
                KimlikVerilisTarihi = (DateTime?)txtVerilisTarihi.EditValue,
                Resim = (byte[])imgResim.EditValue,
                OzelKod1Id = Convert.ToInt64(txtOzelKod1.Id),
                OzelKod2Id = Convert.ToInt64(txtOzelKod2.Id),
                OzelKod3Id = Convert.ToInt64(txtOzelKod3.Id),
                OzelKod4Id = Convert.ToInt64(txtOzelKod4.Id),
                OzelKod5Id = Convert.ToInt64(txtOzelKod5.Id),
                Durum = tgwDurum.IsOn,
            };

            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtNufusIl)
                    sec.Sec(txtNufusIl);
                else if (sender == txtNufusIlce)
                    sec.Sec(txtNufusIlce, txtNufusIl);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Ogrenci);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Ogrenci);
                else if (sender == txtOzelKod3)
                    sec.Sec(txtOzelKod3, KartTuru.Ogrenci);
                else if (sender == txtOzelKod4)
                    sec.Sec(txtOzelKod4, KartTuru.Ogrenci);
                else if (sender == txtOzelKod5)
                    sec.Sec(txtOzelKod5, KartTuru.Ogrenci);
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtNufusIl) return;

            txtNufusIl.ControlEnabledChanged(txtNufusIlce);
        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(ResimMenu);
        }

        private void BtnResimBuyut_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (imgResim.EditValue == null) return;
            var ogrenciAdi = ((OgrenciS)OldEntity).Adi + " " + ((OgrenciS)OldEntity).Soyadi;
            imgResim.ResimBuyut(ogrenciAdi);
        }
    }
}