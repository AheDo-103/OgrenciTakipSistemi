using DevExpress.XtraBars;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.OkulForms;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.IlForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.AileBilgiForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.YabanciDilForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.TesvikForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.KontenjanForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.RehberForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.SinifGrupForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.MeslekForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.YakinlikForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.IsyeriForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GorevKartlari;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.IndirimTuruForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.EvrakForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.PromosyonForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.ServisForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.SinifForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.HizmetTuruForms;
using System;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.HizmetForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.KasaForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BankaForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.AvukatForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.CariForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.OdemeTuruForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BankaHesapForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.IletisimForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.OgrenciForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.IndirimForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.Tahakkuk_Forms;
using DevExpress.XtraBars.Ribbon;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.MakbuzForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.SubeForms;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms
{
    public partial class AnaForm : RibbonForm
    {
        public static long DonemId = 1;
        public static string DonemAdi = "Dönem Bilgisi Bekleniyor...";

        public static long SubeId = 1;
        public static string SubeAdi = "Şube Adı Bilgisi Bekleniyor...";

        public static DateTime EgitimBaslamaTarihi = new DateTime(2020, 09, 14);
        public static DateTime DonemBaslamaTarihi = new DateTime(2020, 07, 15);
        public static DateTime DonemBitisTarihi = new DateTime(2021, 06, 30);
        public static DateTime MaksimumTaksitTarihi = new DateTime(2021, 06, 30);

        public static bool GunTarihininOncesineHizmetBaslamaTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir = true;
        public static bool GunTarihininOncesineMakbuzTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaMakbuzTarihiGirilebilir = true;

        public static bool GunTarihininOncesineIptalTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaIptalTarihiGirilebilir = true;

        public static bool HizmetTahakkukKurusKullan;
        public static bool IndirimTahakkukKurusKullan;
        public static bool OdemePlaniKurusKullan;

        public static bool GittigiOkulZorunlu = true;

        public static byte MaksimumTaksitSayisi = 12;

        public static long? DefaultKasaHesapId;
        public static long? DefaultBankaHesapId;
        public static long? DefaultAvukatHesapId;

        public static string DefaultKasaHesapAdi;
        public static string DefaultBankaHesapAdi;
        public static string DefaultAvukatHesapAdi;

        public static long KullaniciId = 1;

        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        private void EventsLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;
                }
            }
        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnOkulKartlari)
                ShowListForms<OkulListForm>.ShowListForm(KartTuru.Okul);
            else if (e.Item == btnIlKartlari)
                ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);
            else if (e.Item == btnAileBilgiKartlari)
                ShowListForms<AileBilgiListForm>.ShowListForm(KartTuru.AileBilgi);
            else if (e.Item == btnIptalNedeni)
                ShowListForms<IptalNedeniListForm>.ShowListForm(KartTuru.IptalNedeni);
            else if (e.Item == btnYabanciDil)
                ShowListForms<YabanciDilListForm>.ShowListForm(KartTuru.YabanciDil);
            else if (e.Item == btnTesvikKartlari)
                ShowListForms<TesvikListForm>.ShowListForm(KartTuru.Tesvik);
            else if (e.Item == btnKontenjanKartlari)
                ShowListForms<KontenjanListForm>.ShowListForm(KartTuru.Kontenjan);
            else if (e.Item == btnRehberKartlari)
                ShowListForms<RehberListForm>.ShowListForm(KartTuru.Rehber);
            else if (e.Item == btnSinifGrupKartlari)
                ShowListForms<SinifGrupListForm>.ShowListForm(KartTuru.SinifGrup);
            else if (e.Item == btnMeslekKartlari)
                ShowListForms<MeslekListForm>.ShowListForm(KartTuru.Meslek);
            else if (e.Item == btnYakinlikKartlari)
                ShowListForms<YakinlikListForm>.ShowListForm(KartTuru.Yakinlik);
            else if (e.Item == btnIsyeriKartlari)
                ShowListForms<IsyeriListForm>.ShowListForm(KartTuru.Isyeri);
            else if (e.Item == btnGorevKartlari)
                ShowListForms<GorevListForm>.ShowListForm(KartTuru.Gorev);
            else if (e.Item == btnIndirimTuruKartlari)
                ShowListForms<IndirimTuruListForm>.ShowListForm(KartTuru.IndirimTuru);
            else if (e.Item == btnEvrakKartlari)
                ShowListForms<EvrakListForm>.ShowListForm(KartTuru.Evrak);
            else if (e.Item == btnPromosyonKartlari)
                ShowListForms<PromosyonListForm>.ShowListForm(KartTuru.Promosyon);
            else if (e.Item == btnServisKartlari)
                ShowListForms<ServisListForm>.ShowListForm(KartTuru.Servis);
            else if (e.Item == btnSinifKartlari)
                ShowListForms<SinifListForm>.ShowListForm(KartTuru.Sinif);
            else if (e.Item == btnHizmetTuruKartlari)
                ShowListForms<HizmetTuruListForm>.ShowListForm(KartTuru.HizmetTuru);
            else if (e.Item == btnHizmetKartlari)
                ShowListForms<HizmetListForm>.ShowListForm(KartTuru.Hizmet);
            else if (e.Item == btnKasaKartlari)
                ShowListForms<KasaListForm>.ShowListForm(KartTuru.Kasa);
            else if (e.Item == btnBankaKartlari)
                ShowListForms<BankaListForm>.ShowListForm(KartTuru.Banka);
            else if (e.Item == btnAvukatKartlari)
                ShowListForms<AvukatListForm>.ShowListForm(KartTuru.Avukat);
            else if (e.Item == btnCariKartlari)
                ShowListForms<CariListForm>.ShowListForm(KartTuru.Cari);
            else if (e.Item == btnOdemeTuruKarti)
                ShowListForms<OdemeTuruListForm>.ShowListForm(KartTuru.OdemeTuru);
            else if (e.Item == btnBankaHesapKartlari)
                ShowListForms<BankaHesapListForm>.ShowListForm(KartTuru.BankaHesap);
            else if (e.Item == btnIletisimKartlari)
                ShowListForms<IletisimListForm>.ShowListForm(KartTuru.Iletisim);
            else if (e.Item == btnOgrenciKartlari)
                ShowListForms<OgrenciListForm>.ShowListForm(KartTuru.Ogrenci);
            else if (e.Item == btnIndirimKartlari)
                ShowListForms<IndirimListForm>.ShowListForm(KartTuru.Indirim);
            else if (e.Item == btnTahakkukKartlari)
                ShowListForms<TahakkukListForm>.ShowListForm(KartTuru.Tahakkuk);
            else if (e.Item == btnMakbuzKartlari)
                ShowListForms<MakbuzListForm>.ShowListForm(KartTuru.Makbuz);
            else if (e.Item == btnSubeKartlari)
                ShowListForms<SubeListForm>.ShowListForm(KartTuru.Sube);
        }
    }
}