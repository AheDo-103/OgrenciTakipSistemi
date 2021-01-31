using AhdYazilim.OgrenciTakip.Bll.Functions;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.IletisimForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.YakinlikForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Linq;

namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class IletisimBilgiTable : BaseTablo
    {
        public IletisimBilgiTable()
        {
            InitializeComponent();

            Bll = new IletisimBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] { btnKartDuzenle };
            repositoryAdres.Items.AddEnum<AdresTuru>();

        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IletisimBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<IletisimBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayilar = source.Cast<IletisimBilgileriL>().Where(x => !x.Delete).Select(x => x.IletisimId).ToList();

            var entities = ShowListForms<IletisimListForm>.ShowDialogListForm(KartTuru.Iletisim, ListeDisiTutulacakKayilar, true, false).EntityListConvert<IletisimL>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new IletisimBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    IletisimId = entity.Id,
                    TcKimlikNo = entity.TcKimlikNo,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    EvTel = entity.EvTelefonu,
                    IsTel1 = entity.IsTelefonu1,
                    IsTel2 = entity.IsTelefonu2,
                    CepTel1 = entity.CepTelefonu1,
                    CepTel2 = entity.CepTelefonu2,
                    EvAdresi = entity.EvAdresi,
                    EvAdresiIlAdi = entity.EvAdresIlAdi,
                    EvAdresIlceAdi = entity.EvAdresIlceAdi,
                    IsAdresi = entity.IsAdres,
                    IsAdresiIlAdi = entity.IsAdresIlAdi,
                    IsAdresiIlceAdi = entity.IsAdresIlceAdi,
                    MeslekAdi = entity.MeslekAdi,
                    IsyeriAdi = entity.IsyeriAdi,
                    GorevAdi = entity.GorevAdi,
                    Insert = true,
                };

                if (source.Count == 0)
                {
                    row.Veli = true;
                    row.AdresTuru = AdresTuru.EvAdresi;
                }

                var yakinlik = (Yakinlik)ShowListForms<YakinlikListForm>.ShowDialogListForm(KartTuru.Yakinlik, -1);
                if (yakinlik == null) return;
                row.YakinlikId = yakinlik.Id;
                row.YakinlikAdi = yakinlik.YakinlikAdi;

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colVeli;

            ButonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<IletisimBilgileriL>(i);
                if (entity.YakinlikAdi == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colYakinlikAdi;
                    tablo.SetColumnError(colYakinlikAdi, "Yakınlık Adı Alanına Geçerli Bir Değer Giriniz.");
                }

                if (!tablo.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<IletisimBilgileriL>();
            if (entity == null) return;
            ShowEditForms<IletisimEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.IletisimId, null);
        }

        protected override void ImageComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var source = tablo.DataController.ListSource.Cast<IletisimBilgileriL>().ToList();
            if (source.Count == 0) return;

            var rowHandle = tablo.FocusedRowHandle;
            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                if (i == rowHandle) continue;

                if (source[i].AdresTuru == null) continue;
                source[i].AdresTuru = null;

                if (!source[i].Insert)
                    source[i].Update = true;
            }

            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
        }

        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var source = tablo.DataController.ListSource.Cast<IletisimBilgileriL>().ToList();
            if (source.Count == 0) return;

            var rowHandle = tablo.FocusedRowHandle;
            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                if (i == rowHandle) continue;
                if (!source[i].Veli) continue;
                source[i].Veli = false;

                if (!source[i].Insert)
                    source[i].Update = true;
            }

            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colYakinlikAdi)
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryYakinlik, colYakinlikId);
            // Ekleme Yapılıcak.
        }
    }
}