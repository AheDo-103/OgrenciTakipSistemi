using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.OkulForms
{
    public partial class OkulListForm : BaseKartlarForm
    {
        public OkulListForm()
        {
            InitializeComponent();

            Bll = new OkulBll();
        }

        protected override void DegiskenleriDoldur()
        {
            FormShow = new ShowEditForms<OkulEditForm>();
            Tablo = tablo;
            KartTuru = KartTuru.Okul;
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OkulBll)Bll).List(FilterFunctions.Filter<Okul>(AktifKartlariGoster));
        }
    }
}