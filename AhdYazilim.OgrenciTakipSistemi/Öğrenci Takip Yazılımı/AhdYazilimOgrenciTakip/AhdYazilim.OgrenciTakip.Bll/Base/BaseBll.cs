using AhdYazilim.Dal.Interfaces;
using AhdYazilim.OgrenciTakip.Bll.Functions;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Functions;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Attributes;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Bll.Base
{
    public class BaseBll<TEntity, TContext> : IBaseBll where TEntity : BaseEntity where TContext : DbContext
    {
        #region Variables

        private readonly Control _control;
        private IUnitOfWork<TEntity> _uow;

        #endregion

        private bool Validation(IslemTuru islemTuru, BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<TEntity, bool>> filter)
        {
            var errorControl = GetValidationErrorControl();
            if (errorControl == null) return true;

            _control.Controls[errorControl].Focus();
            return false;

            string GetValidationErrorControl()
            {
                string MukerrerKod()
                {
                    foreach (var property in typeof(TEntity).GetPropertyAttributesFromType<Kod>())
                    {
                        if (property.Attribute == null)
                            continue;

                        if ((islemTuru == IslemTuru.EntityInsert || oldEntity.Kod == currentEntity.Kod) && islemTuru == IslemTuru.EntityUpdate)
                            continue;

                        if (_uow.Rep.Count(filter) < 1)
                            continue;

                        Messages.MukerrerKayitHataMesaji(property.Attribute.Description);
                        return property.Attribute.ControlName;
                    }

                    return null;
                }

                string HataliGiris()
                {
                    foreach (var property in typeof(TEntity).GetPropertyAttributesFromType<ZorunluAlan>())
                    {
                        if (property.Attribute == null)
                            continue;

                        var value = property.Property.GetValue(currentEntity);

                        if (property.Property.PropertyType == typeof(long))
                            if ((long)value == 0)
                                value = null;

                        if (!string.IsNullOrEmpty(value?.ToString())) continue;

                        Messages.HataliVeriMesaji(property.Attribute.Description);
                        return property.Attribute.ControlName;
                    }

                    return null;
                }

                return HataliGiris() ?? MukerrerKod();
            }
        }

        protected BaseBll() { }

        protected BaseBll(Control control)
        {
            _control = control;
        }

        protected TResult BaseSingle<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _uow);
            return _uow.Rep.Find(filter, selector);
        }

        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _uow);
            return _uow.Rep.Select(filter, selector);
        }

        protected bool BaseInsert(BaseEntity entity, Expression<Func<TEntity, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _uow);

            if (!Validation(IslemTuru.EntityInsert, null, entity, filter)) return false;

            _uow.Rep.Insert(entity.EntityConvert<TEntity>());
            return _uow.Save();
        }

        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<TEntity, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _uow);

            if (!Validation(IslemTuru.EntityUpdate, oldEntity, currentEntity, filter)) return false;

            var degisenAlanlar = oldEntity.DegisenAlanlariGetir(currentEntity);
            if (degisenAlanlar.Count == 0) return true;

            _uow.Rep.Update(currentEntity.EntityConvert<TEntity>(), degisenAlanlar);
            return _uow.Save();
        }

        protected bool BaseDelete(BaseEntity entity, KartTuru kartTuru, bool mesajVer = true)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _uow);

            if (mesajVer)
                if (Messages.SilMesaj(kartTuru.ToName()) != DialogResult.Yes) return false;

            _uow.Rep.Delete(entity.EntityConvert<TEntity>());
            return _uow.Save();
        }

        protected string BaseYeniKodVer(KartTuru kartTuru, Expression<Func<TEntity, string>> filter, Expression<Func<TEntity, bool>> where = null)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _uow);
            return _uow.Rep.YeniKodVer(kartTuru, filter, where);
        }

        #region Dispose

        public void Dispose()
        {
            _control?.Dispose();
            _uow?.Dispose();
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
