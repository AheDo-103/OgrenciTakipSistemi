using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Bll.General
{
    public class IsyeriBll : BaseGenelBll<Isyeri>, IBaseGenelBll, IBaseCommonBll
    {
        public IsyeriBll() : base(KartTuru.Isyeri) { }

        public IsyeriBll(Control ctrl) : base(ctrl, KartTuru.Isyeri) { }
    }
}