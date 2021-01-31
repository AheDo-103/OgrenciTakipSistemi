using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.Model.Entities;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.KontenjanForms
{
    public partial class KontenjanListForm : BaseKartlarForm
    {
        public KontenjanListForm()
        {
            InitializeComponent();

            Bll = new KontenjanBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            FormShow = new ShowEditForms<KontenjanEditForm>();
            Navigator = longNavigator.Navigator;
            KartTuru = KartTuru.Kontenjan;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KontenjanBll)Bll).List(FilterFunctions.Filter<Kontenjan>(AktifKartlariGoster));
        }
    }
}