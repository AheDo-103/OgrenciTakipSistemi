﻿using AhdYazilim.OgrenciTakip.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhdYazilim.OgrenciTakip.UI.Win.Show.Interfaces
{
    public interface IBaseFormShow
    {
        long ShowDialogEditForm(KartTuru kartTuru, long id);
    }
}
