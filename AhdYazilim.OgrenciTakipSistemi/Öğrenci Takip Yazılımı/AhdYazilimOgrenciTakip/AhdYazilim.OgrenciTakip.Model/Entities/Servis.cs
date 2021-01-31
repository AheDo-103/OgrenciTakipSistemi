using AhdYazilim.OgrenciTakip.Model.Attributes;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Entities
{
    public class Servis : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Servis Yeri Adı", "txtServisYeri")]
        public string ServisYeriAdi { get; set; }

        [Column(TypeName = "money"), Required, ZorunluAlan("Ücret", "txtUcret")]
        public decimal Ucret { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }


        public long SubeId { get; set; }
        public long DonemId { get; set; }

        // Relations
        public Sube Sube { get; set; }
        public Donem Donem { get; set; }
    }
}