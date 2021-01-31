using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class MakbuzS : Makbuz
    {
        public string HesapAdi { get; set; }
    }

    public class MakbuzL : BaseEntity
    {
        public DateTime Tarih { get; set; }
        public MakbuzTuru MakbuzTuru { get; set; }
        public MakbuzHesapTuru HesapTuru { get; set; }
        public decimal MakbuzToplami { get; set; }
        public int HareketSayisi { get; set; }
        public string HesapAdi { get; set; }
    }
}