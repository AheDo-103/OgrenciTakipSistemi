using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Attributes;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Entities
{
    public class Ogrenci : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }


        // Kişisel Bilgiler
        [Required, StringLength(35), ZorunluAlan("Adı", "txtAdi")]
        public string Adi { get; set; }

        [Required, StringLength(35), ZorunluAlan("Soyadı", "txtSoyadi")]
        public string Soyadi { get; set; }


        public string Yeey { get; set; }
        /* Ellemeyin! */
        
        
        [Required, StringLength(35), ZorunluAlan("Baba Adı", "txtBabaAdi")]
        public string BabaAdi { get; set; }

        [Required, StringLength(35), ZorunluAlan("Anne Adı", "txtAnaAdi")]
        public string AnaAdi { get; set; }
        public Cinsiyet Cinsiyet { get; set; } = Cinsiyet.Erkek;

        [StringLength(17)]
        public string Telefon1 { get; set; }

        [StringLength(35)]
        public string DogumYeri { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }

        [Column(TypeName = "image")]
        public byte[] Resim { get; set; }


        // Kimlik Bilgileri
        [StringLength(14)]
        public string TcKimlikNo { get; set; }

        [StringLength(3)]
        public string KanGrubu { get; set; }

        [StringLength(10)]
        public string KimlikSeri { get; set; }

        [StringLength(20)]
        public string KimlikSiraNo { get; set; }
        public long? KimlikIlId { get; set; }
        public long? KimlikIlceId { get; set; }

        [StringLength(35)]
        public string KimlikMahalleKoy { get; set; }

        [StringLength(20)]
        public string KimlikCiltNo { get; set; }

        [StringLength(20)]
        public string KimlikAileSiraNo { get; set; }

        [StringLength(20)]
        public string KimlikBireySiraNo { get; set; }

        [StringLength(35)]
        public string KimlikVerildigiYer { get; set; }

        [StringLength(30)]
        public string KimlikVerilisNedeni { get; set; }

        [StringLength(20)]
        public string KimlikKayitNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KimlikVerilisTarihi { get; set; }



        // Özel Kodlar

        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        public long? OzelKod3Id { get; set; }
        public long? OzelKod4Id { get; set; }
        public long? OzelKod5Id { get; set; }


        // Relations
        public Il KimlikIl { get; set; }
        public Ilce KimlikIlce { get; set; }

        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
        public OzelKod OzelKod3 { get; set; }
        public OzelKod OzelKod4 { get; set; }
        public OzelKod OzelKod5 { get; set; }
    }
}