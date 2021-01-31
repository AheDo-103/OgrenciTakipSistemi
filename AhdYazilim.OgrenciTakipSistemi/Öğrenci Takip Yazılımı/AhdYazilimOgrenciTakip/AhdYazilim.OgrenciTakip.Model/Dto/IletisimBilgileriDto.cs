using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using DevExpress.DataAccess.ObjectBinding;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhdYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class IletisimBilgileriL : IletisimBilgileri, IBaseHareketEntity
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        
        public string EvTel { get; set; }
        
        public string IsTel1 { get; set; }
        public string IsTel2 { get; set; }
        
        public string CepTel1 { get; set; }
        public string CepTel2 { get; set; }
        
        public string EvAdresi { get; set; }
        public string EvAdresiIlAdi { get; set; }
        public string EvAdresIlceAdi { get; set; }

        public string IsAdresi { get; set; }
        public string IsAdresiIlAdi { get; set; }
        public string IsAdresiIlceAdi { get; set; }

        public string YakinlikAdi { get; set; }
        public string MeslekAdi { get; set; }
        public string IsyeriAdi { get; set; }
        public string GorevAdi { get; set; }


        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }


    [HighlightedClass]
    public class IletisimBilgileriR
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string AdiSoyadi { get; set; }
        public string EvTel { get; set; }
        public string IsTel1 { get; set; }
        public string IsTel2 { get; set; }
        public string CepTel1 { get; set; }
        public string CepTel2 { get; set; }
        public string EvAdresi { get; set; }
        public string EvAdresiIlAdi { get; set; }
        public string EvAdresIlceAdi { get; set; }
        public string EvAdresTam { get; set; }
        public string IsAdresi { get; set; }
        public string IsAdresiIlAdi { get; set; }
        public string IsAdresiIlceAdi { get; set; }
        public string IsAdresTam { get; set; }
        public string YakinlikAdi { get; set; }
        public string MeslekAdi { get; set; }
        public string IsyeriAdi { get; set; }
        public string GorevAdi { get; set; }
    }
}