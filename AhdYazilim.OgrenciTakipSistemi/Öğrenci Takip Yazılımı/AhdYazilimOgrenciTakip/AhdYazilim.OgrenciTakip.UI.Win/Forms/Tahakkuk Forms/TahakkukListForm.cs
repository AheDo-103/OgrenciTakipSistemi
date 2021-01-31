using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.Bll.General;
using DevExpress.XtraBars;
using System;
using System.Linq.Expressions;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using System.Linq;
using AhdYazilim.OgrenciTakip.Common.Message;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.Tahakkuk_Forms
{
    public partial class TahakkukListForm : BaseKartlarForm
    {
        #region Variables
        
        private readonly Expression<Func<Tahakkuk, bool>> _filter; 

        #endregion

        public TahakkukListForm()
        {
            InitializeComponent();

            Bll = new TahakkukBll();
            HideItems = new BarItem[] { btnYeni, barInsert, barInsertAciklama };

            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }

        public TahakkukListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            FormShow = new ShowEditForms<TahakkukEditForm>();
            Navigator = longNavigator.Navigator;
            KartTuru = KartTuru.Tahakkuk;
        }

        protected override void Listele()
        {
            var list = ((TahakkukBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaj("Kart");
        }
    }
}