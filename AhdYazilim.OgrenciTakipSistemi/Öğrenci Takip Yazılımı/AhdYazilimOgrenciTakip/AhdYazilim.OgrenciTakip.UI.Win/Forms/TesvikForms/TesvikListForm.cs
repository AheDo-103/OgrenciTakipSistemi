using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.TesvikForms
{
    public partial class TesvikListForm : BaseKartlarForm
    {
        public TesvikListForm()
        {
            InitializeComponent();

            Bll = new TevsikBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.Tesvik;
            Navigator = longNavigator1.Navigator;
            FormShow = new ShowEditForms<TesvikEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((TevsikBll)Bll).List(FilterFunctions.Filter<Tesvik>(AktifKartlariGoster));
        }
    }
}