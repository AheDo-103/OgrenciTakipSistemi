using AhdYazilim.Dal.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Functions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AhdYazilim.Dal.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        #region Variables

        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        #endregion

        public Repository(DbContext context)
        {
            if (context == null) return;
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Insert(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Insert(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
                _context.Entry(entity).State = EntityState.Added;
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
                _context.Entry(entity).State = EntityState.Modified;
        }

        public void Update(TEntity entity, IEnumerable<string> fields)
        {
            _dbSet.Attach(entity);
            var entry = _context.Entry(entity);
            foreach (var field in fields)
                entry.Property(field).IsModified = true;
        }

        public void Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
                _context.Entry(entity).State = EntityState.Deleted;
        }

        public TResult Find<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector).FirstOrDefault() : _dbSet.Where(filter).Select(selector).FirstOrDefault();
        }

        public IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector) : _dbSet.Where(filter).Select(selector);
        }
            
        public int Count(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _dbSet.Count() : _dbSet.Count(filter);
        }

        public string YeniKodVer(KartTuru kartTuru, Expression<Func<TEntity, string>> filter, Expression<Func<TEntity, bool>> where = null)
        {
            string Kod()
            {
                string kod = null;
                var kodDizi = kartTuru.ToName().Split(' ');

                for (int i = 0; i < kodDizi.Length - 1; i++)
                {
                    kod += kodDizi[i];
                    if (i + 1 < kodDizi.Length - 1)
                        kod += " ";
                }

                return kod += "-0001";
            }

            string YeniKodVer(string kod)
            {
                var sayisalDegerler = "";

                foreach (var karakter in kod)
                {
                    if (char.IsDigit(karakter))
                        sayisalDegerler += karakter;
                    else
                        sayisalDegerler = "";
                }

                var artisSonrasiDeger = (int.Parse(sayisalDegerler) + 1).ToString();
                var fark = kod.Length - artisSonrasiDeger.Length;
                if (fark < 0)
                    fark = 0;

                var yeniDeger = kod.Substring(0, fark);
                yeniDeger += artisSonrasiDeger;

                return yeniDeger;
            }

            var maxKod = where == null ? _dbSet.Max(filter) : _dbSet.Where(where).Max(filter);
            return maxKod == null ? Kod() : YeniKodVer(maxKod);
        }

        #region Dispose

        private bool _disposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}