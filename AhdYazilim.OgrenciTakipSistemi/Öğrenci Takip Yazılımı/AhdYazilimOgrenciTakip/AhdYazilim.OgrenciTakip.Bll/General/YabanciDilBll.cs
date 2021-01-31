using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Bll.General
{
    public class YabanciDilBll : BaseGenelBll<YabanciDil>, IBaseCommonBll, IBaseGenelBll
    {
        public YabanciDilBll() : base(KartTuru.YabanciDil) { }

        public YabanciDilBll(Control ctrl) : base(ctrl, KartTuru.YabanciDil) { }
    }
}