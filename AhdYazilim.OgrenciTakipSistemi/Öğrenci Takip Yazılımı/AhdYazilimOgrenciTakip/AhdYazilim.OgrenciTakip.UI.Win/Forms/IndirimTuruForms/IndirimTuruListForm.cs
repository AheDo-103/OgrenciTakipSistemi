using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.Model.Entities;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.IndirimTuruForms
{
    public partial class IndirimTuruListForm : BaseKartlarForm
    {
        public IndirimTuruListForm()
        {
            InitializeComponent();

            Bll = new IndirimTuruBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.IndirimTuru;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<IndirimTuruEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IndirimTuruBll)Bll).List(FilterFunctions.Filter<IndirimTuru>(AktifKartlariGoster));
        }
    }
}