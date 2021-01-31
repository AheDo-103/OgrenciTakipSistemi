using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.IletisimForms
{
    public partial class IletisimListForm : BaseKartlarForm
    {
        #region Variables

        private readonly Expression<Func<Iletisim, bool>> _filter;

        #endregion

        public IletisimListForm()
        {
            InitializeComponent();

            Bll = new IletisimBll();
            _filter = FilterFunctions.Filter<Iletisim>(AktifKartlariGoster);
        }

        public IletisimListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<IletisimEditForm>();
            KartTuru = KartTuru.Iletisim;
        }

        protected override void Listele()
        {
            var list = ((IletisimBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaj("Kart");
        }
    }
}