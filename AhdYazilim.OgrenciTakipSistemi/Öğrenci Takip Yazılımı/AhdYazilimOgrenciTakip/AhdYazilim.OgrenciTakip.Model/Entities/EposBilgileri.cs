using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace AhdYazilim.OgrenciTakip.Model.Entities
{
    public class EposBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }

        [Required, StringLength(30)]
        public string Adi { get; set; }

        [Required, StringLength(30)]
        public string Soyadi { get; set; }

        public long BankaId { get; set; }
        public EposKartTuru KartTuru { get; set; } = EposKartTuru.Visa;


        [Required, StringLength(100)]
        public string KartNo { get; set; }

        [Required, StringLength(100)]
        public string SonKullanmaTarihi { get; set; }

        [Required, StringLength(100)]
        public string GuvenlikKodu { get; set; }


        // Relations
        public Banka Banka { get; set; }
    }
}