using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.ServisForms
{
    public partial class ServisListForm : BaseKartlarForm
    {
        public ServisListForm()
        {
            InitializeComponent();

            Bll = new ServisBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<ServisEditForm>();
            KartTuru = KartTuru.Servis;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((ServisBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}