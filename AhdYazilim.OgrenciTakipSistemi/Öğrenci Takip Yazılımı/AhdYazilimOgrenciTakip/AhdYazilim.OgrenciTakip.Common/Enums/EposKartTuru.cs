using System.ComponentModel;

namespace AhdYazilim.OgrenciTakip.Common.Enums
{
    public enum EposKartTuru : byte
    {
        [Description("Visa")]
        Visa = 1,
        [Description("Master")]
        Master,
        [Description("American Express")]
        AmericanExpress = 3,
    }
}