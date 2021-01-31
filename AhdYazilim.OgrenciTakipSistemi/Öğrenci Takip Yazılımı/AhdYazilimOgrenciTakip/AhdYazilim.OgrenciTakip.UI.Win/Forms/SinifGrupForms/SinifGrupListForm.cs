using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.SinifGrupForms
{
    public partial class SinifGrupListForm : BaseKartlarForm
    {
        public SinifGrupListForm()
        {
            InitializeComponent();

            Bll = new SinifGrupBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.SinifGrup;
            FormShow = new ShowEditForms<SinifGrupEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SinifGrupBll)Bll).List(FilterFunctions.Filter<SinifGrup>(AktifKartlariGoster));
        }
    }
}