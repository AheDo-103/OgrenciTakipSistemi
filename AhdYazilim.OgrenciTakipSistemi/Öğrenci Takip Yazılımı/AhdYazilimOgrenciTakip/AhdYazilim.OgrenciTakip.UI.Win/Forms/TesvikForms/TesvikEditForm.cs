using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.TesvikForms
{
    public partial class TesvikEditForm : BaseEditForm
    {
        public TesvikEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl1;
            Bll = new TevsikBll(myDataLayoutControl1);
            KartTuru = KartTuru.Tesvik;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new Tesvik() : ((TevsikBll)Bll).Single(FilterFunctions.Filter<Tesvik>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert)
                return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((TevsikBll)Bll).YeniKodVer();
            txtTesvikAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Tesvik)OldEntity;
            txtKod.Text = entity.Kod;
            txtTesvikAdi.Text = entity.TesvikAdi;
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Tesvik
            {
                Id = Id,
                Kod = txtKod.Text,
                TesvikAdi = txtTesvikAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn,
            };

            ButonEnabledDurumu();
        }
    }
}