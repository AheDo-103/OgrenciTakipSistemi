using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;

namespace AhdYazilim.OgrenciTakip.Model.Entities
{
    public class IletisimBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public long IletisimId { get; set; }
        public long YakinlikId { get; set; }
        public bool Veli { get; set; }
        public AdresTuru? AdresTuru { get; set; }


        // Relations
        public Iletisim Iletisim { get; set; }
        public Yakinlik Yakinlik { get; set; }
    }
}