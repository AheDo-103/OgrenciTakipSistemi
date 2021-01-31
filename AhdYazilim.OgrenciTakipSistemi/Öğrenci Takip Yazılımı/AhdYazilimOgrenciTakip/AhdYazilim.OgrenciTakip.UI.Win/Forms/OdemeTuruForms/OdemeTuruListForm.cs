using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.OdemeTuruForms
{
    public partial class OdemeTuruListForm : BaseKartlarForm
    {
        public OdemeTuruListForm()
        {
            InitializeComponent();

            Bll = new OdemeTuruBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            FormShow = new ShowEditForms<OdemeTuruEditForm>();
            Navigator = longNavigator.Navigator;
            KartTuru = KartTuru.OdemeTuru;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OdemeTuruBll)Bll).List(FilterFunctions.Filter<OdemeTuru>(AktifKartlariGoster));
        }
    }
}