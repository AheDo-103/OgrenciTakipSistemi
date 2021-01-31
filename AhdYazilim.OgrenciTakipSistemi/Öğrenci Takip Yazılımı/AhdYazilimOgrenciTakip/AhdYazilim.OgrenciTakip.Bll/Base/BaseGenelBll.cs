using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Data.Contexts;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Bll.Base
{
    public class BaseGenelBll<TEntity> : BaseBll<TEntity, OgrenciTakipContext> where TEntity : BaseEntity
    {
        #region Variables

        private readonly KartTuru _kartTuru;

        #endregion

        public BaseGenelBll(KartTuru kartTuru) { _kartTuru = kartTuru; }
        public BaseGenelBll(Control ctrl, KartTuru kartTuru) : base(ctrl) { _kartTuru = kartTuru; }

        public virtual BaseEntity Single(Expression<Func<TEntity, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public virtual IEnumerable<BaseEntity> List(Expression<Func<TEntity, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        
        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }

        // Override Insert
        public bool Insert(BaseEntity entity, Expression<Func<TEntity, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }


        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
        }

        // Override Update
        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<TEntity, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);
        }


        public virtual bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, _kartTuru);
        }


        public string YeniKodVer()
        {
            return BaseYeniKodVer(_kartTuru, x => x.Kod);
        }
        // Override YeniKodVer
        public string YeniKodVer(Expression<Func<TEntity, bool>> whereFilter)
        {
            return BaseYeniKodVer(_kartTuru, x => x.Kod, whereFilter);
        }
    }
}