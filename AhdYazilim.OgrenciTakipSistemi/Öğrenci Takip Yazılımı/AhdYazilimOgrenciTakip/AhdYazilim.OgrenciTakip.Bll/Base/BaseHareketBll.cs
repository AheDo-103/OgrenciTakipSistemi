﻿using AhdYazilim.Dal.Interfaces;
using AhdYazilim.OgrenciTakip.Bll.Functions;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AhdYazilim.OgrenciTakip.Bll.Base
{
    public class BaseHareketBll<TEntity, TContext> : IBaseBll, IBaseHareketGenelBll where TEntity : BaseHareketEntity where TContext : DbContext
    {
        #region Variables

        private IUnitOfWork<TEntity> _uow;

        #endregion


        protected IQueryable<TResult> List<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _uow);
            return _uow.Rep.Select(filter, selector);
        }

        public virtual bool Insert(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _uow);
            _uow.Rep.Insert(entities.EntityListConvert<TEntity>());
            return _uow.Save();
        }

        public virtual bool Update(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _uow);
            _uow.Rep.Update(entities.EntityListConvert<TEntity>());
            return _uow.Save();
        }

        public bool Delete(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _uow);

            _uow.Rep.Delete(entities.EntityListConvert<TEntity>());
            return _uow.Save();
        }

        #region Dispose

        public void Dispose()
        {
            _uow?.Dispose();
        }

        #endregion
    }
}