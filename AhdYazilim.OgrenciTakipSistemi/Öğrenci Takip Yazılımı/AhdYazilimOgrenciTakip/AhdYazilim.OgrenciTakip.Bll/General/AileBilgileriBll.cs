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
    public class AileBilgileriBll : BaseHareketBll<AileBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<AileBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<AileBilgileri, bool>> filter)
        {
            return List(filter, x => new AileBilgilerL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                AileBilgiId = x.AileBilgiId,
                BilgiAdi = x.AileBilgi.BilgiAdi,
                Aciklama = x.AileBilgi.Aciklama,
            }).ToList();
        }
    }
}