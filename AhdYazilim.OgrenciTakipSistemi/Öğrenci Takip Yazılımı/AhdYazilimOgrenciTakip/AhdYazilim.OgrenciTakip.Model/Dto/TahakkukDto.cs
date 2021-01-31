using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class TahakkukS : Tahakkuk
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string SinifAdi { get; set; }
        public string GeldigiOkulAdi { get; set; }
        public string KontenjanAdi { get; set; }
        public string YabanciDilAdi { get; set; }
        public string RehberAdi { get; set; }
        public string TesvikAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }
    }

    public class TahakkukL : BaseEntity
    {
        public long OgrenciId { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string OkulNo { get; set; }
        public DateTime KayitTarihi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurum { get; set; }
        public string SinifAdi { get; set; }
        public string GeldigiOkulAdi { get; set; }
        public string KontenjanAdi { get; set; }
        public string YabanciDilAdi { get; set; }
        public string RehberAdi { get; set; }
        public string TesvikAdi { get; set; }
        public SonrakiDonemKayitDurumu SonrakiDonemKayitDurumu { get; set; }
        public string SonrakiDonemKayitDurumuAciklama { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }
        public string SubeAdi { get; set; }
        public bool Durum { get; set; }
    }
}