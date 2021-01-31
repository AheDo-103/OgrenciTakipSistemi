using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Bll.General
{
    public class EvrakBll : BaseGenelBll<Evrak>, IBaseCommonBll
    {
        public EvrakBll() : base(KartTuru.Evrak) { }

        public EvrakBll(Control ctrl) : base(ctrl, KartTuru.Evrak) { }
    }
}
