using AhdYazilim.OgrenciTakip.Bll.Functions;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.HizmetForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.IndirimEditFormTable
{
    public partial class IndiriminUygHizTable : BaseTablo
    {
        public IndiriminUygHizTable()
        {
            InitializeComponent();

            Bll = new IndiriminUygulanacagiHizmetBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IndiriminUygulanacagiHizmetBilgileriBll)Bll).List(x => x.IndirimId == OwnerForm.Id).ToBindingList<IndiriminUygulanacagiHizmetBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayilar = source.Cast<IndiriminUygulanacagiHizmetBilgileriL>().Where(x => !x.Delete).Select(x => x.HizmetId).ToList();

            var entities = ShowListForms<HizmetListForm>.ShowDialogListForm(KartTuru.Hizmet, ListeDisiTutulacakKayilar, true, true).EntityListConvert<HizmetL>();
            if (entities == null) return;
            foreach (var entity in entities)
            {
                var row = new IndiriminUygulanacagiHizmetBilgileriL()
                {
                    IndirimId = OwnerForm.Id,
                    HizmetId = entity.Id,
                    HizmetAdi = entity.HizmetAdi,
                    IndirimTutari = 0,
                    IndirimOrani = 0,
                    SubeId = AnaForm.SubeId,
                    DonemId = AnaForm.DonemId,
                    Insert = true,
                };

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colIndirimTutari;

            ButonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<IndiriminUygulanacagiHizmetBilgileriL>(i);
                if (entity.IndirimTutari == 0 || entity.IndirimOrani == 0) continue;
                tablo.Focus();
                tablo.FocusedRowHandle = i;
                Messages.HataMesaji("İndirim Tutarı Veya İndirim Oranı Alanlarından Sadece Birinin Değeri Sıfırdan (0) Büyük Olmalıdır.");
                return true;
            }

            return false;
        }
    }
}