using DevExpress.XtraPrinting;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms
{
    public partial class RaporOnIzleme : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RaporOnIzleme(params object[] prm)
        {
            InitializeComponent();

            RaporGosterici.PrintingSystem = (PrintingSystemBase)prm[0];
            Text = $"{Text} ( {prm[1]} )";
        }
    }
}