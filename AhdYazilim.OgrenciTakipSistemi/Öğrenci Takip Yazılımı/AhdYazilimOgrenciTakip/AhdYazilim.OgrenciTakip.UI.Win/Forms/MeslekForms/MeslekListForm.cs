using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.MeslekForms
{
    public partial class MeslekListForm : BaseKartlarForm
    {
        public MeslekListForm()
        {
            InitializeComponent();

            Bll = new MeslekBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.Meslek;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<MeslekEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MeslekBll)Bll).List(FilterFunctions.Filter<Meslek>(AktifKartlariGoster));
        }
    }
}