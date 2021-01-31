using AhdYazilim.OgrenciTakip.Model.Entities.Base;

namespace AhdYazilim.OgrenciTakip.Model.Entities
{
    public class EvrakBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public long EvrakId { get; set; }

        // Relation 
        public Evrak Evrak { get; set; }

    }
}
