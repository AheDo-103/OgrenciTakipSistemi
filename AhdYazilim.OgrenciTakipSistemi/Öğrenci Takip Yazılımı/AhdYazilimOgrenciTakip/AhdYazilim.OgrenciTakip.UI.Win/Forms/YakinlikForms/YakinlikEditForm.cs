using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.YakinlikForms
{
    public partial class YakinlikEditForm : BaseEditForm
    {
        public YakinlikEditForm()
        {
            InitializeComponent();

            Bll = new YakinlikBll(myDataLayoutControl);
            DataLayoutControl = myDataLayoutControl;
            KartTuru = KartTuru.Yakinlik;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new Yakinlik() : ((YakinlikBll)Bll).Single(FilterFunctions.Filter<Yakinlik>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert)
                return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((YakinlikBll)Bll).YeniKodVer();
            txtYakinlikAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Yakinlik)OldEntity;

            txtKod.Text = entity.Kod;
            txtYakinlikAdi.Text = entity.YakinlikAdi;
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Yakinlik
            {
                Id = Id,
                Kod = txtKod.Text,
                YakinlikAdi = txtYakinlikAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}