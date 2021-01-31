using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.BankaSubeForms
{
    public partial class BankaSubeListForm : BaseKartlarForm
    {
        #region Variables

        private readonly long _bankaId;
        private readonly string _bankaAdi;

        #endregion

        public BankaSubeListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new BankaSubeBll();

            _bankaId = (long)prm[0];
            _bankaAdi = prm[1].ToString();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            KartTuru = KartTuru.BankaSube;
            Text = $"{Text} - ( {_bankaAdi} )";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaSubeBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.BankaId == _bankaId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<BankaSubeEditForm>.ShowDialogEditForm(KartTuru.BankaSube, id, _bankaId, _bankaAdi);
            ShowEditFormDefault(result);  
        }
    }
}