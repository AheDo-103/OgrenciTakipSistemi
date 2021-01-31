using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class RaporL : BaseEntity
    {
        public string RaporAdi { get; set; }
        public string Acikalama { get; set; }
    }
}
