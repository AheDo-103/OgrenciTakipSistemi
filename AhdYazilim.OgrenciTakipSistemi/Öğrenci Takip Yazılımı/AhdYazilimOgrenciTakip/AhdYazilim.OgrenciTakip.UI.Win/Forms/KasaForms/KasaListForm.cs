using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.KasaForms
{
    public partial class KasaListForm : BaseKartlarForm
    {
        public KasaListForm()
        {
            InitializeComponent();

            Bll = new KasaBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            KartTuru = KartTuru.Kasa;
            FormShow = new ShowEditForms<KasaEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KasaBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}