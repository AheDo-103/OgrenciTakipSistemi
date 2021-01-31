using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BankaForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using DevExpress.XtraGrid.Views.Base;
using System.Linq;

namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class EposBilgileriTable : BaseTablo
    {
        public EposBilgileriTable()
        {
            InitializeComponent();

            Bll = new EposBilgileriBll();
            Tablo = tablo;
            repositoryKartTuru.AddEnum<EposKartTuru>();
            EventsLoad();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((EposBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<EposBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;

            var row = new EposBilgileriL
            {
                TahakkukId = OwnerForm.Id,
                Insert = true,
            };

            source.Add(row);

            tablo.GridControl.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colAdi;

            ButonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<EposBilgileriL>(i);
                if (string.IsNullOrEmpty(entity.Adi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colAdi;
                    tablo.SetColumnError(colAdi, "Adı Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.Soyadi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colSoyadi;
                    tablo.SetColumnError(colSoyadi, "Soyadı Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.BankaAdi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colBankaAdi;
                    tablo.SetColumnError(colBankaAdi, "Banka Adı Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.KartNo))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colKartNo;
                    tablo.SetColumnError(colKartNo, "Kart Numarası Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.SonKullanmaTarihi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colSonKullanmaTarihi;
                    tablo.SetColumnError(colSonKullanmaTarihi, "Son Kullanma Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.GuvenlikKodu))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colGuvenlikKodu;
                    tablo.SetColumnError(colGuvenlikKodu, "Güvenlik Kodu Alanına Geçerli Bir Değer Giriniz.");
                }

                if (!tablo.HasColumnErrors) continue;
                Messages.HataliVeriMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colBankaAdi)
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryBanka, colBankaId);
        }
    }
}