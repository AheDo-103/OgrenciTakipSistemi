using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Bll.General
{
    public class YakinlikBll : BaseGenelBll<Yakinlik>, IBaseCommonBll, IBaseGenelBll
    {
        public YakinlikBll() : base(KartTuru.Yakinlik) { }

        public YakinlikBll(Control ctrl) : base(ctrl, KartTuru.Yakinlik) { }
    }
}
