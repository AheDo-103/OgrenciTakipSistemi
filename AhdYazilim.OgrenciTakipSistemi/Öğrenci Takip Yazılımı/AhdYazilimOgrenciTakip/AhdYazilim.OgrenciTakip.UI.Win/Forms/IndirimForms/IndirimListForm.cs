using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.IndirimForms
{
    public partial class IndirimListForm : BaseKartlarForm
    {
        public IndirimListForm()
        {
            InitializeComponent();

            Bll = new IndirimBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator1.Navigator;
            KartTuru = KartTuru.Indirim;
            FormShow = new ShowEditForms<IndirimEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IndirimBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}