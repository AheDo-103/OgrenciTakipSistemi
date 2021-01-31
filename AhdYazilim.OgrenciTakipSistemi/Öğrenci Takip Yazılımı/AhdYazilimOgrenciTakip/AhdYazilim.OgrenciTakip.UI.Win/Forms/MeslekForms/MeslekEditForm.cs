using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.MeslekForms
{
    public partial class MeslekEditForm : BaseEditForm
    {
        public MeslekEditForm()
        {
            InitializeComponent();

            Bll = new MeslekBll(myDataLayoutControl1);
            DataLayoutControl = myDataLayoutControl1;
            KartTuru = KartTuru.Meslek;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new Meslek() : ((MeslekBll)Bll).Single(FilterFunctions.Filter<Meslek>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert)
                return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MeslekBll)Bll).YeniKodVer();
            txtMeslekAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Meslek)OldEntity;

            txtKod.Text = entity.Kod;
            txtMeslekAdi.Text = entity.MeslekAdi;
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Meslek
            {
                Id = Id,
                Kod = txtKod.Text,
                MeslekAdi = txtMeslekAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn,
            };

            ButonEnabledDurumu();
        }
    }
}