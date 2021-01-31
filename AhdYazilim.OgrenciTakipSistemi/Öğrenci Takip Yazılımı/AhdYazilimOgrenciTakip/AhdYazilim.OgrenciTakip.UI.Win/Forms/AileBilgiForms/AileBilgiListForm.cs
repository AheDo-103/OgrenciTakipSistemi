using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.Model.Entities;
using System.Linq.Expressions;
using System;
using System.Linq;
using AhdYazilim.OgrenciTakip.Common.Message;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.AileBilgiForms
{
    public partial class AileBilgiListForm : BaseKartlarForm
    {
        private readonly Expression<Func<AileBilgi, bool>> _filter;

        public AileBilgiListForm()
        {
            InitializeComponent();

            Bll = new AileBilgiBll();
            _filter = FilterFunctions.Filter<AileBilgi>(AktifKartlariGoster);
        }

        public AileBilgiListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.AileBilgi;
            FormShow = new ShowEditForms<AileBilgiEditForm>();
            Navigator = longNavigator1.Navigator;
        }

        protected override void Listele()
        {
            var list = ((AileBilgiBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaj("Kart");
        }
    }
}