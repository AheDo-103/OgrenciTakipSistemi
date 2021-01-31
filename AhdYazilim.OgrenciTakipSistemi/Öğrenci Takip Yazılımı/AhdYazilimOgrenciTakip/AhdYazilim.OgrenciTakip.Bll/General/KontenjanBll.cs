using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Bll.General
{
    public class KontenjanBll : BaseGenelBll<Kontenjan>, IBaseGenelBll, IBaseCommonBll
    {
        public KontenjanBll() : base(KartTuru.Kontenjan) { }

        public KontenjanBll(Control ctrl) : base(ctrl, KartTuru.Kontenjan) { }
    }
}
