using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.CodeParser;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.SubeForms
{
    public partial class SubeListForm : BaseKartlarForm
    {
        #region Variables

        private Expression<Func<Sube, bool>> _filter;

        #endregion

        public SubeListForm()
        {
            InitializeComponent();

            Bll = new SubeBll();
            _filter = x => x.Durum == AktifKartlariGoster;
        }

        public SubeListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = Common.Enums.KartTuru.Sube;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<SubeEditForm>();
        }

        protected override void Listele()
        {
            var list = ((SubeBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaj("Kart");
        }
    }
}