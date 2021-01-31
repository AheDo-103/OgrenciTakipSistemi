using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.AileBilgiForms
{
    public partial class AileBilgiEditForm : BaseEditForm
    {
        public AileBilgiEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new AileBilgiBll(myDataLayoutControl);
            KartTuru = KartTuru.AileBilgi;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new AileBilgi() : ((AileBilgiBll)Bll).Single(FilterFunctions.Filter<AileBilgi>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert)
                return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AileBilgiBll)Bll).YeniKodVer();
            txtBilgiAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AileBilgi)OldEntity;
            txtKod.Text = entity.Kod;
            txtBilgiAdi.Text = entity.BilgiAdi;
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new AileBilgi
            {
                Id = Id,
                Kod = txtKod.Text,
                BilgiAdi = txtBilgiAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn,
            };

            ButonEnabledDurumu();
        }
    }
}