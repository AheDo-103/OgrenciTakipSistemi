using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Entities
{
    public class BilgiNotlari : BaseHareketEntity
    {
        public long TahakkukId { get; set; }


        public DateTime Tarih{ get; set; }
        
        [Required, StringLength(1000)]
        public string BilgiNotu { get; set; }
    }
}