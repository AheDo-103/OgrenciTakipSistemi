using AhdYazilim.OgrenciTakip.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AhdYazilim.Dal.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Insert(TEntity entity);
        void Insert(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void Update(TEntity entity, IEnumerable<string> fields);
        void Update(IEnumerable<TEntity> entities);

        void Delete(TEntity entity);
        void Delete(IEnumerable<TEntity> entities);

        TResult Find<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector);
        IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector);

        int Count(Expression<Func<TEntity, bool>> filter = null);

        string YeniKodVer(KartTuru kartTuru, Expression<Func<TEntity, string>> filter, Expression<Func<TEntity, bool>> where = null);
    }
}
