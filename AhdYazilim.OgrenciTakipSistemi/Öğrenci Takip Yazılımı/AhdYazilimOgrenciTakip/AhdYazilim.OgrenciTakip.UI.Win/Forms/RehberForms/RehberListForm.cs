using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.RehberForms
{
    public partial class RehberListForm : BaseKartlarForm
    {
        public RehberListForm()
        {
            InitializeComponent();

            Bll = new RehberBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.Rehber;
            FormShow = new ShowEditForms<RehberEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((RehberBll)Bll).List(FilterFunctions.Filter<Rehber>(AktifKartlariGoster));
        }
    }
}