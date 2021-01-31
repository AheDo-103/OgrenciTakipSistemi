using System.ComponentModel;

namespace AhdYazilim.OgrenciTakip.Common.Enums
{
    public enum IptalDurum : byte
    {
        [Description("İptal Edildi")]
        IptalEdildi = 1,
        [Description("Devam Ediyor")]
        DevamEdiyor = 2,
    }
}