using AhdYazilim.OgrenciTakip.Bll.Functions;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.PromosyonForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class PromosyonBilgiTable : BaseTablo
    {
        public PromosyonBilgiTable()
        {
            InitializeComponent();

            Bll = new PromosyonBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((PromosyonBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<PromosyonBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayilar = source.Cast<PromosyonBilgileriL>().Where(x => !x.Delete).Select(x => x.PromosyonId).ToList();

            var entities = ShowListForms<PromosyonListForm>.ShowDialogListForm(KartTuru.Promosyon, ListeDisiTutulacakKayilar, true, false).EntityListConvert<Promosyon>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new PromosyonBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    PromosyonId = entity.Id,
                    Kod = entity.Kod,
                    PromosyonAdi = entity.PromosyonAdi,
                    Insert = true,
                };

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colKod;

            ButonEnabledDurumu(true);
        }
    }
}