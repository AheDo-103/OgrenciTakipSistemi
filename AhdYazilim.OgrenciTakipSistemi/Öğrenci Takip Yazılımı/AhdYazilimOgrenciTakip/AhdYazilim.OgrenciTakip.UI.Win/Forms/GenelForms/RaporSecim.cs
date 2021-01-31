using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Functions;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.RaporForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Reports.XtraReports.Makbuz;
using AhdYazilim.OgrenciTakip.UI.Win.Reports.XtraReports.Tahakkuk;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms
{
    public partial class RaporSecim : BaseKartlarForm
    {
        #region Variables

        private readonly RaporBolumTuru _raporBolumTuru;
        private readonly OgrenciR _ogrenciBilgileri;
        private readonly IEnumerable<IletisimBilgileriR> _iletisimBilgileri;
        private readonly IEnumerable<HizmetBilgileriR> _hizmetBilgileri;
        private readonly IEnumerable<IndirimBilgileriR> _indirimBilgileri;
        private readonly IEnumerable<OdemeBilgileriR> _odemeBilgileri;
        private readonly IEnumerable<GeriOdemeBilgileriR> _geriOdemeBilgileri;
        private readonly IEnumerable<EposBilgileriR> _eposBilgileri;
        private readonly IEnumerable<MakbuzHareketleriR> _makbuzBilgileri;

        #endregion

        public RaporSecim(params object[] prm)
        {
            InitializeComponent();

            Bll = new RaporBll();

            ShowItems = new BarItem[] { btnYeniRapor, btnBaskiOnizleme };
            HideItems = new BarItem[] { btnYeni, btnSec, btnFiltrele, btnKolonlar, /*barInsert, barInsertAciklama,*/ barEnter, barEnterAciklama, barFiltrele, barFiltreleAciklama, barKolonlar, barKolonlarAciklama };

            btnDuzelt.CreateDropDownMenu(new BarItem[] { btnTasarimDegistir });
            btnYazdir.CreateDropDownMenu(new BarItem[] { btnTabloYazdir });

            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());
            txtYaziciAdi.EditValue = GeneralFunctions.DefaultYazici();
            txtYazdirmaSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YazdirmaSekli>());
            txtYazdirmaSekli.SelectedItem = YazdirmaSekli.TekTekYazdir.ToName();

            _raporBolumTuru = (RaporBolumTuru)prm[0];

            if ((RaporBolumTuru)prm[0] == RaporBolumTuru.TahakkukRaporlari)
            {
                _ogrenciBilgileri = (OgrenciR)prm[1];
                _iletisimBilgileri = (IEnumerable<IletisimBilgileriR>)prm[2];
                _hizmetBilgileri = (IEnumerable<HizmetBilgileriR>)prm[3];
                _indirimBilgileri = (IEnumerable<IndirimBilgileriR>)prm[4];
                _odemeBilgileri = (IEnumerable<OdemeBilgileriR>)prm[5];
                _geriOdemeBilgileri = (IEnumerable<GeriOdemeBilgileriR>)prm[6];
                _eposBilgileri = (IEnumerable<EposBilgileriR>)prm[7];
            }
            else if ((RaporBolumTuru)prm[0] == RaporBolumTuru.MakbuzRaporlari)
            {
                _makbuzBilgileri = (List<MakbuzHareketleriR>)prm[1];
            }
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = smallNavigator.Navigator;
            KartTuru = KartTuru.Rapor;

            if (_raporBolumTuru == RaporBolumTuru.FaturaDonemRaporlari || _raporBolumTuru == RaporBolumTuru.FaturaGenelRaporlar || _raporBolumTuru == RaporBolumTuru.MakbuzRaporlari)
            {
                switch (_raporBolumTuru)
                {
                    case RaporBolumTuru.MakbuzRaporlari:
                        {
                            var showItem = new BarItem[] { btnGenelMakbuz, btnTahsilatMakbuzu, btnTeslimatMakbuzu, btnGeriIadeMakbuzu };
                            ShowItems = ShowItems.Concat(showItem).ToArray();
                        }

                        break;
                }

                var hideItems = new BarItem[]
                {
                    btnBosRapor, btnOgrenciKarti, btnOdemeSenedi, btnBankaOdemePlani, btnIndirimTalepDilekcesi, btnMebKayitSozlesmesi,
                    btnKayitSozlesmesi, btnKrediKartliOdemeTalimati
                };

                HideItems = HideItems.Concat(hideItems).ToArray();
            }
        }

        protected override void Listele()
        {
            RowSelect?.ClearSelection();
            Tablo.GridControl.DataSource = ((RaporBll)Bll).List(x => x.RaporBolumTuru == _raporBolumTuru && x.Durum == AktifKartlariGoster);
        }

        protected override void Duzelt()
        {
            if (Messages.RaporuTasarimaGonder() != DialogResult.Yes) return;

            Cursor.Current = Cursors.WaitCursor;

            var row = tablo.GetRow<RaporL>();
            if (row == null) return;

            var entity = (Rapor)((RaporBll)Bll).Single(x => x.Id == row.Id);
            var result = ShowRibbonForms<RaporTasarim>.ShowDialogForm(KartTuru.RaporTasarim, entity);
            ShowEditFormDefault(result);

            Cursor.Current = DefaultCursor;
        }

        protected override void ShowEditForm(long id)
        {
            var row = tablo.GetRow<RaporL>();
            if (row == null) return;

            var entity = (Rapor)((RaporBll)Bll).Single(x => x.Id == row.Id);

            var result = ShowEditForms<RaporEditForm>.ShowDialogEditForm(KartTuru.Rapor, id, entity.RaporTuru, entity.RaporBolumTuru, entity.Dosya);
            ShowEditFormDefault(result);
        }

        private IList<MyXtraReport> RaporHazirla()
        {
            var raporlar = new List<MyXtraReport>();

            var topluRapor = new MyXtraReport();
            topluRapor.CreateDocument();
            topluRapor.Baslik = "Toplu Rapor";
            topluRapor.PrintingSystem.ContinuousPageNumbering = false;

            foreach (var row in RowSelect.GetSelectedRows())
            {
                var entity = (Rapor)((RaporBll)Bll).Single(x => x.Id == row.Id);
                var rapor = entity.Dosya.ByteToStream().StreamToReport();
                ReportDataSource(rapor);
                rapor.CreateDocument();
                switch (txtYazdirmaSekli.Text.GetEnum<YazdirmaSekli>())
                {
                    case YazdirmaSekli.TekTekYazdir:
                        raporlar.Add(rapor);
                        break;

                    case YazdirmaSekli.TopluYazdir:
                        topluRapor.Pages.AddRange(rapor.Pages);
                        break;
                }
            }

            if (topluRapor.Pages.Count == 0) return raporlar;

            raporlar.Add(topluRapor);
            return raporlar;
        }

        private void ReportDataSource(IReport report)
        {
            switch (report)
            {
                case OgrenciKartiRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    rpr.Iletisim_Bilgileri.DataSource = _iletisimBilgileri;
                    rpr.Hizmet_Bilgileri.DataSource = _hizmetBilgileri;
                    rpr.Indirim_Bilgileri.DataSource = _indirimBilgileri.GroupBy(x => new { x.IndirimAdi, x.IptalTarihi, x.IslemTarihi })
                        .Select(x => new
                        {
                            x.Key.IndirimAdi,
                            x.Key.IptalTarihi,
                            x.Key.IslemTarihi,
                            BrutIndirim = x.Sum(y => y.BrutIndirim),
                            KistDonemDusulenIndirim = x.Sum(y => y.KistDonemDusulenIndirim),
                            NetIndirim = x.Sum(y => y.NetIndirim),
                        });
                    rpr.Odeme_Bilgileri.DataSource = _odemeBilgileri;
                    rpr.Geri_Odeme_Bilgileri.DataSource = _geriOdemeBilgileri;
                    break;

                case BankaOdemePlaniRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    var secilenOdemeler = _odemeBilgileri.Where(x => x.OdemeTipi == OdemeTipi.Ots);
                    rpr.Odeme_Bilgileri.DataSource = secilenOdemeler;
                    rpr.toplamTutarYazi.Text = secilenOdemeler.Sum(x => x.Tutar).YaziIleTutar();
                    break;

                case MebKayitSozlesmesiRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    break;

                case IndirimDilekcesiRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    rpr.Indirim_Bilgileri.DataSource = _indirimBilgileri.GroupBy(x => new { x.IndirimAdi })
                        .Select(x => new
                        {
                            x.Key.IndirimAdi,
                            NetIndirim = x.Sum(y => y.NetIndirim),
                            BrutIndirim = x.Sum(y => y.BrutIndirim),
                            KistDonemDusulenIndirim = x.Sum(y => y.KistDonemDusulenIndirim),
                        });
                    break;

                case KayitSozlesmesiRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    break;

                case KrediKartliOdemeTalimatiRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    rpr.Odeme_Bilgileri.DataSource = _odemeBilgileri.Where(x => x.OdemeTipi == OdemeTipi.Epos).OrderBy(x => x.Vade);
                    rpr.Epos_Bilgileri.DataSource = _eposBilgileri;
                    break;

                case OdemeSenediRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    rpr.Odeme_Bilgileri.DataSource = _odemeBilgileri.Where(x => x.OdemeTipi == OdemeTipi.Senet).OrderBy(x => x.Vade);
                    break;

                case KullaniciTanimliRapor rpr:
                    rpr.Epos_Bilgileri.DataSource = _eposBilgileri;
                    rpr.Geri_Odeme_Bilgileri.DataSource = _geriOdemeBilgileri;
                    rpr.Hizmet_Bilgileri.DataSource = _hizmetBilgileri;
                    rpr.Iletisim_Bilgileri.DataSource = _iletisimBilgileri;
                    rpr.Indirim_Bilgileri.DataSource = _indirimBilgileri.GroupBy(x => new { x.IndirimAdi, x.IptalTarihi, x.IslemTarihi })
                        .Select(x => new
                        {
                            x.Key.IndirimAdi,
                            x.Key.IptalTarihi,
                            x.Key.IslemTarihi,
                            NetIndirim = x.Sum(y => y.NetIndirim),
                            KistDonemDusulenIndirim = x.Sum(y => y.KistDonemDusulenIndirim),
                            BrutIndirim = x.Sum(y => y.BrutIndirim),
                        });
                    rpr.Odeme_Bilgileri.DataSource = _odemeBilgileri;
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    break;

                case TahsilatMakbuzuRaporu rpr:
                    rpr.Makbuz_Bilgileri.DataSource = _makbuzBilgileri;
                    break;

                case TeslimatMakbuzu rpr:
                    rpr.Makbuz_Bilgileri.DataSource = _makbuzBilgileri;
                    break;

                case GeriIadeMakbuzuRaporu rpr:
                    rpr.Makbuz_Bilgileri.DataSource = _makbuzBilgileri;
                    break;

                case GenelMakbuzRaporu rpr:
                    rpr.Makbuz_Bilgileri.DataSource = _makbuzBilgileri;
                    break;
            }
        }

        protected override void Yazdir()
        {
            if (Messages.EvetSeciliEvetHayir("Rapor Yazdırılmak Üzere Seçtiğiniz Yazıcıya Gönderelecektir. Onaylıyor Musunuz?", "Onay") != DialogResult.Yes) return;

            var raporlar = RaporHazirla();
            for (int i = 0; i < txtYazdirilacakAdet.Value; i++)
                raporlar.ForEach(x => x.Print(txtYaziciAdi.Text));
        }

        protected override void BaskiOnizleme()
        {
            var raporlar = RaporHazirla();
            raporlar.ForEach(x => ShowRibbonForms<RaporOnIzleme>.ShowForm(false, x.PrintingSystem, x.Baslik));
        }

        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.Button_ItemClick(sender, e);

            void RaporOlustur(KartTuru raporTuru, RaporBolumTuru raporBolumTuru, XtraReport report)
            {
                if (Messages.RaporuTasarimaGonder() != DialogResult.Yes) return;

                Cursor.Current = Cursors.WaitCursor;

                var entity = new Rapor
                {
                    Kod = ((RaporBll)Bll).YeniKodVer(x => x.RaporTuru == raporTuru),
                    RaporTuru = raporTuru,
                    RaporBolumTuru = raporBolumTuru,
                    RaporAdi = raporTuru.ToName(),
                    Dosya = report.ReportToStream().GetBuffer(),
                    Durum = true,
                };

                var result = ShowRibbonForms<RaporTasarim>.ShowDialogForm(KartTuru.RaporTasarim, entity);
                ShowEditFormDefault(result);

                Cursor.Current = DefaultCursor;
            }

            if (e.Item == btnYeniRapor)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }

            else if (e.Item == btnOgrenciKarti)
                RaporOlustur(KartTuru.OgrenciKartiRaporu, RaporBolumTuru.TahakkukRaporlari, new OgrenciKartiRaporu());

            else if (e.Item == btnBankaOdemePlani)
                RaporOlustur(KartTuru.BankaOdemePlaniRaporu, RaporBolumTuru.TahakkukRaporlari, new BankaOdemePlaniRaporu());

            else if (e.Item == btnMebKayitSozlesmesi)
                RaporOlustur(KartTuru.MebKayitSozlesmesiRaporu, RaporBolumTuru.TahakkukRaporlari, new MebKayitSozlesmesiRaporu());

            else if (e.Item == btnIndirimTalepDilekcesi)
                RaporOlustur(KartTuru.IndirimTalepDilekcesiRaporu, RaporBolumTuru.TahakkukRaporlari, new IndirimDilekcesiRaporu());

            else if (e.Item == btnKayitSozlesmesi)
                RaporOlustur(KartTuru.KayitSozlesmesiRaporu, RaporBolumTuru.TahakkukRaporlari, new KayitSozlesmesiRaporu());

            else if (e.Item == btnKrediKartliOdemeTalimati)
                RaporOlustur(KartTuru.KrediKartliOdemeTalimatiRaporu, RaporBolumTuru.TahakkukRaporlari, new KrediKartliOdemeTalimatiRaporu());

            else if (e.Item == btnOdemeSenedi)
                RaporOlustur(KartTuru.OdemeSenediRaporu, RaporBolumTuru.TahakkukRaporlari, new OdemeSenediRaporu());

            else if (e.Item == btnBosRapor)
                RaporOlustur(KartTuru.KullaniciTanimliRapor, RaporBolumTuru.TahakkukRaporlari, new KullaniciTanimliRapor());

            else if (e.Item == btnTahsilatMakbuzu)
                RaporOlustur(KartTuru.TahsilatMakbuzuRaporu, RaporBolumTuru.MakbuzRaporlari, new TahsilatMakbuzuRaporu());

            else if (e.Item == btnTeslimatMakbuzu)
                RaporOlustur(KartTuru.TeslimatMakbuzuRaporu, RaporBolumTuru.MakbuzRaporlari, new TeslimatMakbuzu());

            else if (e.Item == btnGeriIadeMakbuzu)
                RaporOlustur(KartTuru.GeriIadeMakbuzuRaporu, RaporBolumTuru.MakbuzRaporlari, new GeriIadeMakbuzuRaporu());

            else if (e.Item == btnGenelMakbuz)
                RaporOlustur(KartTuru.GenelMakbuzRaporu, RaporBolumTuru.MakbuzRaporlari, new GenelMakbuzRaporu());
        }
    }
}