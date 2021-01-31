using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Entities
{
    public class GeriOdemeBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }
        public GeriOdemeHesapTuru GeriOdemeHesapTuru { get; set; } = GeriOdemeHesapTuru.Kasa;
        public long? BankaHesapId { get; set; }
        public long? KasaId { get; set; }

        [Column(TypeName = "money")]
        public decimal Tutar { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }


        // Relations
        public Tahakkuk Tahakkuk { get; set; }
        public BankaHesap BankaHesap { get; set; }
        public Kasa Kasa { get; set; }
    }
}