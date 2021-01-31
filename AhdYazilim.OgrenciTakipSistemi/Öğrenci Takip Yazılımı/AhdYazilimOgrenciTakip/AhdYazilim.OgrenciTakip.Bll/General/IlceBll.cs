using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Bll.General
{
    public class IlceBll : BaseGenelBll<Ilce>, IBaseCommonBll
    {
        public IlceBll() : base(KartTuru.Ilce) { }

        public IlceBll(Control ctrl) : base(ctrl, KartTuru.Ilce) { }
    }
}