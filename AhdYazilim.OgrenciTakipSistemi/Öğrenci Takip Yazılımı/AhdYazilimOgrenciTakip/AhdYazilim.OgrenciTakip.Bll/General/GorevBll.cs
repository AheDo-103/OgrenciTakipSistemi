using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Bll.General
{
    public class GorevBll : BaseGenelBll<Gorev>, IBaseCommonBll, IBaseGenelBll
    {
        public GorevBll() : base(KartTuru.Gorev) { }

        public GorevBll(Control ctrl) : base(ctrl, KartTuru.Gorev) { }
    }
}
