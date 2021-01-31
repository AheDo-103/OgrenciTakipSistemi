using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.IsyeriForms
{
    public partial class IsyeriListForm : BaseKartlarForm
    {
        public IsyeriListForm()
        {
            InitializeComponent();

            Bll = new IsyeriBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator1.Navigator;
            KartTuru = KartTuru.Isyeri;
            FormShow = new ShowEditForms<IsyeriEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IsyeriBll)Bll).List(FilterFunctions.Filter<Isyeri>(AktifKartlariGoster));
        }
    }
}