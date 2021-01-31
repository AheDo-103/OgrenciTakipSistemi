﻿using System.ComponentModel;

namespace AhdYazilim.OgrenciTakip.Common.Enums
{
    public enum GeriOdemeHesapTuru : byte
    {
        [Description("Banka")]
        Banka = 1,
        [Description("Kasa")]
        Kasa = 2,
    }
}
