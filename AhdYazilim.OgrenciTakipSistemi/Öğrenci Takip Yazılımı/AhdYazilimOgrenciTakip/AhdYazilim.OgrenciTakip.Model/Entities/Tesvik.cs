using AhdYazilim.OgrenciTakip.Model.Attributes;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Entities
{
    public class Tesvik : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [StringLength(50), Required, ZorunluAlan("Teşvik Adı", "txtTesvikAdi")]
        public string TesvikAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
