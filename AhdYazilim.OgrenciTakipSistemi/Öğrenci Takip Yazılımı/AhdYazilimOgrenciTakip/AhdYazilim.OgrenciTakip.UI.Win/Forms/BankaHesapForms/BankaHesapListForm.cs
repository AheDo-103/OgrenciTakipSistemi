using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using System;
using System.Linq.Expressions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.BankaHesapForms
{
    public partial class BankaHesapListForm : BaseKartlarForm
    {
        #region Variables

        private readonly Expression<Func<BankaHesap, bool>> _filter;
        private readonly BankaHesapTuru _hesapTuru = BankaHesapTuru.VadesizMevduatHesabi;

        #endregion

        public BankaHesapListForm()
        {
            InitializeComponent();

            Bll = new BankaHesapBll();
            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId;
        }

        public BankaHesapListForm(params object[] prm) : this()
        {
            if (prm[0].GetType() == typeof(BankaHesapTuru))
                _hesapTuru = (BankaHesapTuru)prm[0];

            else if (prm[0].GetType() == typeof(OdemeTipi))
            {
                var odemeTipi = (OdemeTipi)prm[0];

                switch (odemeTipi)
                {
                    case OdemeTipi.Epos:
                        _hesapTuru = BankaHesapTuru.EposBlokeHesabi;
                        break;

                    case OdemeTipi.Ots:
                        _hesapTuru = BankaHesapTuru.OtsBlokeHesabi;
                        break;

                    case OdemeTipi.Pos:
                        _hesapTuru = BankaHesapTuru.PosBlokeHesabi;
                        break;
                }
            }
            _filter = x => x.Durum == AktifKartlariGoster && x.HesapTuru == _hesapTuru && x.SubeId == AnaForm.SubeId;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            KartTuru = KartTuru.BankaHesap;
            FormShow = new ShowEditForms<BankaHesapEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaHesapBll)Bll).List(_filter);
        }
    }
}