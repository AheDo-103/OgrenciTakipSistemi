using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhdYazilim.OgrenciTakip.UI.Win.Interfaces
{
    public interface IStatusBarKisaYol : IStatusBarAciklama
    {
        string StatusBarKisaYol { get; set; }
        string StatusBarKisaYolAciklama { get; set; }
    }
}
