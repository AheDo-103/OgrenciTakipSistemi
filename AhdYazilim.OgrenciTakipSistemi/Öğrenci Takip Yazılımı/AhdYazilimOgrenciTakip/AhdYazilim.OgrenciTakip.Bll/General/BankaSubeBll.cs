using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Bll.General
{
    public class BankaSubeBll : BaseGenelBll<BankaSube>, IBaseCommonBll
    {
        public BankaSubeBll() : base(KartTuru.BankaSube) { }

        public BankaSubeBll(Control ctrl) : base(ctrl, KartTuru.BankaSube) { }
    }
}