using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Functions;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class BelgeSecimListForm : BaseKartlarForm
    {
        #region Variables

        private readonly Expression<Func<OdemeBilgileri, bool>> _filter;
        private readonly MakbuzTuru _makbuzTuru;
        private readonly MakbuzHesapTuru _hesapTuru;
        private readonly long _hesapId;

        #endregion

        public BelgeSecimListForm(params object[] prm)
        {
            InitializeComponent();

            _makbuzTuru = (MakbuzTuru)prm[0];
            _hesapTuru = (MakbuzHesapTuru)prm[1];
            _hesapId = prm[2] != null ? (long)prm[2] : 0;

            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Tahakkuk.DonemId == AnaForm.DonemId;

            ShowItems = new BarItem[] { btnBelgeHareketleri };
            HideItems = new BarItem[] { btnYeni, btnSil, btnDuzelt, barInsert, barInsertAciklama, barDelete, barDeleteAciklama, barDuzelt, barDuzeltAciklama };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.BelgeSecim; // ehe
            Navigator = longNavigator.Navigator;
            Text = $"{Text} - {_makbuzTuru.ToName()} - ( {_hesapTuru.ToName()} )";
        }

        protected override void Listele()
        {
            using (var bll = new BelgeSecimBll())
            {
                var list = bll.List(_filter, _makbuzTuru, _hesapTuru, _hesapTuru.ToName().GetEnum<OdemeTipi>(), _hesapId, AnaForm.SubeId);
                Tablo.GridControl.DataSource = list;

                if (!MultiSelect) return;
                if (list.Any())
                    EklenebilecekEntityVar = true;
                else
                    Messages.KartBulunamadiMesaj("Belge");
            }
        }

        protected override void BelgeHareketleri()
        {
            var entity = tablo.GetRow<BelgeSecimL>();
            if (entity == null) return;
            ShowListForms<BelgeHareketleriListForm>.ShowDialogListForm(KartTuru.BelgeSecim, -1, entity.OdemeBilgileriId);
        }

        protected override void ColumnShowHide()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<BelgeSecimL>();
            if (entity == null) return;

            bndBelgeDetayBilgiler.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
            colTakipNo.Visible = entity.OdemeTipi == OdemeTipi.Pos;
            colBankaHesapAdi.Visible = entity.OdemeTipi == OdemeTipi.Epos || entity.OdemeTipi == OdemeTipi.Pos || entity.OdemeTipi == OdemeTipi.Ots;
            colBankaAdi.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colBankaSubeAdi.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colHesapNo.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colBelgeNo.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colAsilBorclu.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
            colCiranta.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
        }
    }
}