﻿using AhdYazilim.OgrenciTakip.Model.Attributes;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Entities
{
    public class Sube : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Şube Adı", "txtSubeAdi")]
        public string SubeAdi { get; set; }

        [StringLength(17)]
        public string Telefon { get; set; }

        [StringLength(17)]
        public string Fax { get; set; }

        [StringLength(32)]
        public string IbanNo { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }

        [StringLength(35)]
        public string GrupAdi { get; set; }

        public int? SiraNo { get; set; }

        [StringLength(255)]
        public string Adres { get; set; }

        [ZorunluAlan("Adres İl Adı", "txtAdresIl")]
        public long AdresIlId { get; set; }

        [ZorunluAlan("Adres İlçe Adı", "txtAdresIlce")]
        public long AdresIlceId { get; set; }


        // Relations
        public Il AdresIl { get; set; }
        public Ilce AdresIlce { get; set; }
        //public BankaHesap SubeBankaHesap { get; set; }
    }
}