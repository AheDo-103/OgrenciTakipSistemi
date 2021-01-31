using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.CariForms
{
    public partial class CariListForm : BaseKartlarForm
    {
        public CariListForm()
        {
            InitializeComponent();

            Bll = new CariBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            FormShow = new ShowEditForms<CariEditForm>();
            KartTuru = KartTuru.Cari;
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((CariBll)Bll).List(FilterFunctions.Filter<Cari>(AktifKartlariGoster));
        }
    }
}