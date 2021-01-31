using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.RaporForms
{
    public partial class RaporListForm : BaseKartlarForm
    {
        #region Variables

        private readonly KartTuru _raporTuru;
        private readonly RaporBolumTuru _raporBolumTuru;
        private readonly byte[] _dosya;

        #endregion

        public RaporListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new RaporBll();
            _raporTuru = (KartTuru)prm[0];
            _raporBolumTuru = (RaporBolumTuru)prm[1];
            _dosya = (byte[])prm[2];
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.Rapor;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<RaporEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((RaporBll)Bll).List(FilterFunctions.Filter<Rapor>(AktifKartlariGoster));
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<RaporEditForm>.ShowDialogEditForm(KartTuru.Rapor, id, _raporTuru, _raporBolumTuru, _dosya);
            ShowEditFormDefault(result);
        }
    }
}