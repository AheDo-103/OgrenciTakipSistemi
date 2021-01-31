using AhdYazilim.OgrenciTakip.Model.Attributes;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Entities
{
    public class IptalNedeni : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [StringLength(50), Required, ZorunluAlan("İptal Nedeni Adı", "txtIptalNedeniAdi")]
        public string IptalNedeniAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
