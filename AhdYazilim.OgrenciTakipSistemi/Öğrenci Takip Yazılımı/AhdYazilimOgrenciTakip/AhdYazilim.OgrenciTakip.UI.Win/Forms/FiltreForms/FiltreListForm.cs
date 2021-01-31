using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.FiltreForms
{
    public partial class FiltreListForm : BaseKartlarForm
    {
        #region Variables

        private readonly KartTuru _filtreKartTuru;
        private readonly GridControl _filtreGrid; 

        #endregion

        public FiltreListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new FiltreBll();

            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            HideItems = new BarItem[] { btnFiltrele, btnKolonlar, btnYazdir, btnGonder, barFiltrele, barFiltreleAciklama, barGonder, barGonderAciklama, barKolonlar, barKolonlarAciklama, barYazdir, barYazdirAciklama };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.Filtre;
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((FiltreBll)Bll).List(x => x.KartTuru == _filtreKartTuru);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<FiltreEditForm>.ShowDialogEditForm(KartTuru.Filtre, id, _filtreKartTuru, _filtreGrid);
            ShowEditFormDefault(result);
        }
    }
}