using AhdYazilim.OgrenciTakip.Model.Attributes;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Entities
{
    public class Il : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required, StringLength(50), ZorunluAlan("İl Adi", "txtIlAdi")]
        public string IlAdi { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }

        [InverseProperty("Il")]
        public ICollection<Ilce> Ilce { get; set; }
    }
}
