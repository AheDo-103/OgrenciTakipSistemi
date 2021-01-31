using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Show;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.IlceForms
{
    public partial class IlceListForm : BaseKartlarForm
    {
        #region Variables

        private readonly long _ilId;
        private readonly string _ilAdi;

        #endregion

        public IlceListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new IlceBll();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.Ilce;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_ilAdi} )";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlceBll)Bll).List(x => x.IlId == _ilId && x.Durum == AktifKartlariGoster);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<IlceEditForm>.ShowDialogEditForm(KartTuru.Ilce, id, _ilId, _ilAdi);
            ShowEditFormDefault(result);
        }
    }
}