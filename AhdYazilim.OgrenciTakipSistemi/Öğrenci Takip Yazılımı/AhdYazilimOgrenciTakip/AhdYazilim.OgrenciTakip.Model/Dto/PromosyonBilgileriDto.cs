using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhdYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class PromosyonBilgileriL : PromosyonBilgileri, IBaseHareketEntity
    {
        public string Kod { get; set; }
        public string PromosyonAdi { get; set; }


        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
