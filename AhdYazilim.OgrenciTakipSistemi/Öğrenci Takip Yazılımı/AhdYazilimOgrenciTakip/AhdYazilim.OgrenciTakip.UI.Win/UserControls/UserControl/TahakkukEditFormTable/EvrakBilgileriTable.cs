using AhdYazilim.OgrenciTakip.Bll.Functions;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.EvrakForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class EvrakBilgileriTable : BaseTablo
    {
        public EvrakBilgileriTable()
        {
            InitializeComponent();

            Bll = new EvrakBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((EvrakBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<EvrakBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayilar = source.Cast<EvrakBilgileriL>().Where(x => !x.Delete).Select(x => x.EvrakId).ToList();

            var entities = ShowListForms<EvrakListForm>.ShowDialogListForm(KartTuru.Evrak, ListeDisiTutulacakKayilar, true, false).EntityListConvert<Evrak>();
            if (entities == null) return;
            
            foreach (var entity in entities)
            {
                var row = new EvrakBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    EvrakId = entity.Id,
                    Kod = entity.Kod,
                    EvrakAdi = entity.EvrakAdi,
                    Insert = true,
                };

                source.Add(row);
            }

            tablo.GridControl.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colKod;

            ButonEnabledDurumu(true);
        }
    }
}