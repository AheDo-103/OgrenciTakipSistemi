using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Bll.General
{
    public class IndirimTuruBll : BaseGenelBll<IndirimTuru>, IBaseGenelBll, IBaseCommonBll
    {
        public IndirimTuruBll() : base(KartTuru.IndirimTuru) { }

        public IndirimTuruBll(Control ctrl) : base(ctrl, KartTuru.IndirimTuru) { }
    }
}