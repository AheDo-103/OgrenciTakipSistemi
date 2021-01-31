using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.AvukatForms
{
    public partial class AvukatListForm : BaseKartlarForm
    {
        public AvukatListForm()
        {
            InitializeComponent();

            Bll = new AvukatBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            FormShow = new ShowEditForms<AvukatEditForm>();
            Navigator = longNavigator.Navigator;
            KartTuru = KartTuru.Avukat;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((AvukatBll)Bll).List(FilterFunctions.Filter<Avukat>(AktifKartlariGoster));
        }
    }
}