using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.YakinlikForms
{
    public partial class YakinlikListForm : BaseKartlarForm
    {
        public YakinlikListForm()
        {
            InitializeComponent();

            Bll = new YakinlikBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            KartTuru = KartTuru.Yakinlik;
            FormShow = new ShowEditForms<YakinlikEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((YakinlikBll)Bll).List(FilterFunctions.Filter<Yakinlik>(AktifKartlariGoster));
        }
    }
}