﻿using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Attributes;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Entities
{
    public class OdemeTuru : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Ödeme Türü Adı", "txtOdemeTuruAdi")]
        public string OdemeTuruAdi { get; set; }

        public OdemeTipi OdemeTipi { get; set; } = OdemeTipi.Elden;

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
