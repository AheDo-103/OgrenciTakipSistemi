using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Functions;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraBars;
using System;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms
{
    public partial class TabloDokumParametreleri : BaseEditForm
    {
        #region Variables

        private DokumSekli _dokumSekli;
        private readonly string _raporBaslik;

        #endregion

        public TabloDokumParametreleri(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl2;
            HideItems = new BarItem[] { btnYeni, btnKaydet, btnGeriAl, btnSil };
            ShowItems = new BarItem[] { btnYazdir, btnBaskiOnizleme };
            EventsLoad();

            _raporBaslik = (string)prm[0];
        }

        protected internal override void Yukle()
        {
            txtRaporBaslik.Text = _raporBaslik;

            txtBaslikEkle.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtRaporuKagidaSigdir.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<RaporuKagidaSigdirmaTuru>());
            txtYazdirmaYonu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YazdirmaYonu>());
            txtYatayCizgileriGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtDikeyCizgileriGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtSutunBasliklariniGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());

            txtBaslikEkle.SelectedItem = EvetHayir.Evet.ToName();
            txtRaporuKagidaSigdir.SelectedItem = RaporuKagidaSigdirmaTuru.YaziBoyutunuKuculterekSigdir.ToName();
            txtYazdirmaYonu.SelectedItem = YazdirmaYonu.Otomatik.ToName();
            txtYatayCizgileriGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtDikeyCizgileriGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtSutunBasliklariniGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtYaziciAdi.EditValue = GeneralFunctions.DefaultYazici();
        }

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new DokumParametreleri
            {
                RaporBaslik = txtRaporBaslik.Text,
                BaslikEkle = txtBaslikEkle.Text.GetEnum<EvetHayir>(),
                RaporuKagidaSigdir = txtRaporuKagidaSigdir.Text.GetEnum<RaporuKagidaSigdirmaTuru>(),
                YazdirmaYonu = txtYazdirmaYonu.Text.GetEnum<YazdirmaYonu>(),
                YatayCizgileriGoster = txtYatayCizgileriGoster.Text.GetEnum<EvetHayir>(),
                DikeyCizgileriGoster = txtDikeyCizgileriGoster.Text.GetEnum<EvetHayir>(),
                SutunBasliklariniGoster = txtSutunBasliklariniGoster.Text.GetEnum<EvetHayir>(),
                YaziciAdi = txtYaziciAdi.Text,
                YazdirilacakAdet = (int)txtYazdirilicakAdet.Value,
                DokumSekli = _dokumSekli
            };
            return entity;
        }

        protected override void Yazdir()
        {
            _dokumSekli = DokumSekli.TabloYazdir;
            Close();
        }

        protected override void BaskiOnIzleme()
        {
            _dokumSekli = DokumSekli.TabloBaskiOnizleme;
            Close();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtBaslikEkle) return;
            txtRaporBaslik.Enabled = txtBaslikEkle.Text.GetEnum<EvetHayir>() == EvetHayir.Evet;
        }
    }
}