﻿using System.ComponentModel;

namespace AhdYazilim.OgrenciTakip.Common.Enums
{
    public enum Cinsiyet : byte
    {
        [Description("Erkek")]
        Erkek = 1,
        [Description("Kız")]
        Kiz = 2,
    }
}