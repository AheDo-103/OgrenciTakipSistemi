using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.CariForms
{
    public partial class CariEditForm : BaseEditForm
    {
        public CariEditForm()
        {
            InitializeComponent();

            Bll = new CariBll(myDataLayoutControl);
            DataLayoutControl = myDataLayoutControl;
            KartTuru = KartTuru.Cari;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new CariS() : ((CariBll)Bll).Single(FilterFunctions.Filter<Cari>(Id));
            NesneyiKontrollereBagla();
            if (IslemTuru != IslemTuru.EntityInsert)
                return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((CariBll)Bll).YeniKodVer();
            txtCariAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (CariS)OldEntity;

            txtKod.Text = entity.Kod;
            txtCariAdi.Text = entity.CariAdi;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtTelefon1.Text = entity.Telefon1;
            txtTelefon2.Text = entity.Telefon2;
            txtTelefon3.Text = entity.Telefon3;
            txtTelefon4.Text = entity.Telefon4;
            txtFaks.Text = entity.Faks;
            txtWebAdresi.Text = entity.Web;
            txtEmailAdresi.Text = entity.Email;
            txtVergiAdresi.Text = entity.VergiDairesi;
            txtVergiNo.Text = entity.VergiNo;
            txtAdres.Text = entity.Adres;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Cari
            {
                Id = Id,
                Kod = txtKod.Text,
                CariAdi = txtCariAdi.Text,
                TcKimlikNo = txtTcKimlikNo.Text,
                Telefon1 = txtTelefon1.Text,
                Telefon2 = txtTelefon2.Text,
                Telefon3 = txtTelefon3.Text,
                Telefon4 = txtTelefon4.Text,
                Faks = txtFaks.Text,
                Web = txtWebAdresi.Text,
                Email = txtEmailAdresi.Text,
                VergiDairesi = txtVergiAdresi.Text,
                VergiNo = txtVergiNo.Text,
                Adres = txtAdres.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn,
            };

            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Cari);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Cari);
        }
    }
}