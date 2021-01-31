using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.SinifForms
{
    public partial class SinifListForm : BaseKartlarForm
    {
        public SinifListForm()
        {
            InitializeComponent();

            Bll = new SinifBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator1.Navigator;
            FormShow = new ShowEditForms<SinifEditForms>();
            KartTuru = KartTuru.Sinif;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SinifBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId);
        }
    }
}