using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Common.Message
{
    public class Messages
    {
        public static void HataMesaji(string hataMesaji)
        {
            XtraMessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void UyariMesaji(string uyariMesaji)
        {
            XtraMessageBox.Show(uyariMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult EvetSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult SilMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} Silinicektir. Onaylıyor musunuz?", "Silme Onayı");
        }

        public static DialogResult KapanisMesaj()
        {
            return EvetSeciliEvetHayirIptal("Yapılan Değişiklikler Kayıt Edilsin mi?", "Çıkış Onay");
        }

        public static DialogResult KayitMesaj()
        {
            return EvetSeciliEvetHayir("Yapılan Değişiklikler Kayıt Edilsin mi?", "Kayıt Onay");
        }

        public static void KartSecmemeUyariMesaji()
        {
            UyariMesaji("Lütfen Bir Kart Seçiniz.");
        }

        public static void MukerrerKayitHataMesaji(string alanAdi)
        {
            HataMesaji($"Girmiş Olduğunuz {alanAdi} Daha Önce Kullanılmıştır.");
        }

        public static void HataliVeriMesaji(string alanAdi)
        {
            HataMesaji($"{alanAdi} Alanına Geçerli Bir Değer Girmelisiniz.");
        }

        public static DialogResult TabloExportMesaj(string dosyaFormati)
        {
            return EvetSeciliEvetHayir($"İlgili Tablo, {dosyaFormati} Olarak Dışarı Aktarılacaktır. Onaylıyor musunuz?", "Aktarım Onay");
        }

        public static void KartBulunamadiMesaj(string kartTuru)
        {
            UyariMesaji($"İşlem Yapılabilecek {kartTuru} Bulunamadı.");
        }

        public static void TabloEksikBilgiMesaji(string tabloAdi)
        {
            UyariMesaji($"{tabloAdi}nda Eksik Bilgi Girişi Var. Lütfen Kontrol Ediniz.");
        }

        public static void IptalHareketSilinemezMesaji()
        {
            HataMesaji("İptal Edilen Hareketler Silinemez.");
        }

        public static DialogResult IptalMesaji(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} İptal Edilecektir. Onaylıyor Musunuz?", "İptal Onay");
        }

        public static DialogResult IptalGeriAlMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} Kartına Uygulanan İptal İşlemi Geri Alınacaktır. Onaylıyor Musunuz?", "İptal Geri Al Onay");
        }

        public static void SecimHataMesaji(string alanAdi)
        {
            HataMesaji($"{alanAdi} Seçimi Yapmalısınız.");
        }

        public static void OdemeBilgisiSilinemezMesaj(bool dahaSonra)
        {
            UyariMesaji(dahaSonra 
                ? "Ödeme Belgesinin Daha Sonra İşlem Görmüş Hareketleri Var. Ödeme Belgesi Silinemez." 
                : "Ödeme Belgesinin İşlem Görmüş Hareketleri Var. Ödeme Belgesi Silinemez.");
        }

        public static DialogResult RaporuTasarimaGonder()
        {
            return HayirSeciliEvetHayir("Rapor Tasarım Görünümünde Açılacaktır. Onaylıyor Musunuz?", "Onay");
        }
    }
}