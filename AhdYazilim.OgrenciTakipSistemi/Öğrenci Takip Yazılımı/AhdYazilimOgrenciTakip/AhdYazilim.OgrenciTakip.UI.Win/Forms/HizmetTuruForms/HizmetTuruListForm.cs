using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.HizmetTuruForms
{
    public partial class HizmetTuruListForm : BaseKartlarForm
    {
        public HizmetTuruListForm()
        {
            InitializeComponent();

            Bll = new HizmetTuruBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<HizmetTuruEditForm>();
            KartTuru = KartTuru.HizmetTuru;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((HizmetTuruBll)Bll).List(FilterFunctions.Filter<HizmetTuru>(AktifKartlariGoster));
        }
    }
}