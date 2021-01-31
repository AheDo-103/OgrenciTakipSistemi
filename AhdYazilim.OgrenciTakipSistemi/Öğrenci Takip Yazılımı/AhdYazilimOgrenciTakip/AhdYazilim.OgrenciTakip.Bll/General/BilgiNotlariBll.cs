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
    public class BilgiNotlariBll : BaseHareketBll<BilgiNotlari, OgrenciTakipContext>, IBaseHareketSelectBll<BilgiNotlari>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<BilgiNotlari, bool>> filter)
        {
            return List(filter, x => new BilgiNotlariL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Tarih = x.Tarih,
                BilgiNotu = x.BilgiNotu,
            }).ToList();
        }
    }
}