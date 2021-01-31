using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Functions;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.OdemeTuruForms
{
    public partial class OdemeTuruEditForm : BaseEditForm
    {
        public OdemeTuruEditForm()
        {
            InitializeComponent();

            Bll = new OdemeTuruBll(myDataLayoutControl);
            DataLayoutControl = myDataLayoutControl;
            KartTuru = KartTuru.OdemeTuru;
            EventsLoad();

            txtOdemeTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<OdemeTipi>());
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new OdemeTuru() : ((OdemeTuruBll)Bll).Single(FilterFunctions.Filter<OdemeTuru>(Id));
            NesneyiKontrollereBagla();
            if (IslemTuru != IslemTuru.EntityInsert) return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((OdemeTuruBll)Bll).YeniKodVer();
            txtOdemeTuruAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OdemeTuru)OldEntity;

            txtKod.Text = entity.Kod;
            txtOdemeTuruAdi.Text = entity.OdemeTuruAdi;
            txtOdemeTipi.SelectedItem = entity.OdemeTipi.ToName();
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new OdemeTuru
            {
                Id = Id,
                Kod = txtKod.Text,
                OdemeTuruAdi = txtOdemeTuruAdi.Text,
                OdemeTipi = txtOdemeTipi.Text.GetEnum<OdemeTipi>(),
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn,
            };

            ButonEnabledDurumu();
        }
    }
}