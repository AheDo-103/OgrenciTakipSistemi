using AhdYazilim.OgrenciTakip.Model.Entities.Base;

namespace AhdYazilim.OgrenciTakip.Model.Entities
{
    public class PromosyonBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public long PromosyonId { get; set; }

        // Relations 
        public Promosyon Promosyon { get; set; }
    }
}