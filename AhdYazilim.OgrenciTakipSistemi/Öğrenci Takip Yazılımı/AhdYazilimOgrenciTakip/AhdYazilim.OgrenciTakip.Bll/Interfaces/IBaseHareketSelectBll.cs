using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AhdYazilim.OgrenciTakip.Bll.Interfaces
{
    public interface IBaseHareketSelectBll<TEntity>
    {
        IEnumerable<BaseHareketEntity> List(Expression<Func<TEntity, bool>> filter);
    }
}