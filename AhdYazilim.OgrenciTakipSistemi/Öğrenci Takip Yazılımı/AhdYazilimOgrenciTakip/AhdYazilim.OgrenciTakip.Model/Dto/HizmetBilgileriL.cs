﻿using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using DevExpress.DataAccess.ObjectBinding;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class HizmetBilgileriL : HizmetBilgileri, IBaseHareketEntity
    {
        public string HizmetAdi { get; set; }
        public HizmetTipi HizmetTipi { get; set; }
        public string ServisYeriAdi { get; set; }
        public string IptalNedeniAdi { get; set; }
        public string GittigiOkulAdi { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }


    [HighlightedClass]
    public class HizmetBilgileriR
    {
        public string HizmetAdi { get; set; }
        public string ServisYeriAdi { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public decimal BrutUcret { get; set; }
        public decimal KistDonemDusulenUcret { get; set; }
        public decimal NetUcret { get; set; }
        public int EgitimGunSayisi { get; set; }
        public int AlinanHizmetGunSayisi { get; set; }
        public decimal GunlukUcret { get; set; }
        public DateTime? IptalTarihi { get; set; }
        public string IptalNedeniAdi { get; set; }
        public string IptalAciklama { get; set; }
        public string GittigiOkulAdi { get; set; }
    }
}