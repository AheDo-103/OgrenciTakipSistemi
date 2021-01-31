using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Bll.General
{
    public class PromosyonBll : BaseGenelBll<Promosyon>, IBaseCommonBll
    {
        public PromosyonBll() : base(KartTuru.Promosyon) { }

        public PromosyonBll(Control ctrl) : base(ctrl, KartTuru.Promosyon) { }
    }
}