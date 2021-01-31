using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.YabanciDilForms
{
    public partial class YabanciDilListForm : BaseKartlarForm
    {
        public YabanciDilListForm()
        {
            InitializeComponent();

            Bll = new YabanciDilBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.YabanciDil;
            FormShow = new ShowEditForms<YabanciDilEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((YabanciDilBll)Bll).List(FilterFunctions.Filter<YabanciDil>(AktifKartlariGoster));
        }
    }
}