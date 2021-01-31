using AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.Model.Dto;
using System.Linq;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.Tahakkuk_Forms;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Bll.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using DevExpress.XtraBars;

namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class KardesBilgileriTable : BaseTablo
    {
        public KardesBilgileriTable()
        {
            InitializeComponent();

            Bll = new KardesBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] { btnKartDuzenle };
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KardesBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<KardesBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayilar = source.Cast<KardesBilgileriL>().Where(x => !x.Delete).Select(x => x.KardesTahakkukId).ToList();
            ListeDisiTutulacakKayilar.Add(OwnerForm.Id);

            var entities = ShowListForms<TahakkukListForm>.ShowDialogListForm(KartTuru.Tahakkuk, ListeDisiTutulacakKayilar, true, false).EntityListConvert<TahakkukL>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new KardesBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    KardesTahakkukId = entity.Id,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyad,
                    SinifAdi = entity.SinifAdi,
                    KayitSekli = entity.KayitSekli,
                    KayitDurumu = entity.KayitDurum,
                    IptalDurumu = entity.Durum ? IptalDurum.DevamEdiyor : IptalDurum.IptalEdildi,
                    SubeAdi = entity.SubeAdi,
                    Insert = true,
                };

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colAdi;

            ButonEnabledDurumu(true);
        }

        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<KardesBilgileriL>();
            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.KardesTahakkukId, entity.SubeId == AnaForm.SubeId);
        }
    }
}