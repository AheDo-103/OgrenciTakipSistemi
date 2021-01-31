using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Data.Contexts;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AhdYazilim.OgrenciTakip.Bll.General
{
    public class EvrakBilgileriBll : BaseHareketBll<EvrakBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<EvrakBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<EvrakBilgileri, bool>> filter)
        {
            return List(filter, x => new EvrakBilgileriL
            {
                TahakkukId = x.TahakkukId,
                Id = x.Id,
                EvrakId = x.EvrakId,
                Kod = x.Evrak.Kod,
                EvrakAdi = x.Evrak.EvrakAdi
            }).ToList();
        }
    }
}