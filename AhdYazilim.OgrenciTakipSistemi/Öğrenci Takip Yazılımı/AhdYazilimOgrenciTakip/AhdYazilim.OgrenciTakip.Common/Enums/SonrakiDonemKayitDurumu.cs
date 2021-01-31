using System.ComponentModel;

namespace AhdYazilim.OgrenciTakip.Common.Enums
{
    public enum SonrakiDonemKayitDurumu : byte
    {
        [Description("Kayıt Yenilenecek")]
        KayitYenileyecek =  1,
        [Description("Şartlı Kayıt Yenilenecek")]
        SartliKayitYenileyecek = 2,
        [Description("Kayıt Yenilemeyecek")]
        KayitYenilemeyecek = 3,
        [Description("Kurum Tarafindan Kayıt Yenilenmeyecek")]
        KurumTarafindanKaydiYenilenmeyecek = 4,
    }
}