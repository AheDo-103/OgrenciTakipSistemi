﻿using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using DevExpress.DataAccess.ObjectBinding;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class EposBilgileriL : EposBilgileri, IBaseHareketEntity
    {
        public string BankaAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class EposBilgileriR
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string BankaAdi { get; set; }
        public EposKartTuru KartTuru { get; set; }
        public string KartNo { get; set; }
        public string SonKullanmaTarihi { get; set; }
        public string GuvenlikKodu { get; set; }
    }
}