using AhdYazilim.Dal.Interfaces;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using AhdYazilim.OgrenciTakip.Common.Message;

namespace AhdYazilim.Dal.Base
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        #region Variables

        private readonly DbContext _context;

        #endregion

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public IRepository<T> Rep => new Repository<T>(_context);

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException exp)
            {
                var sqlExp = (SqlException)exp.InnerException?.InnerException;
                if (sqlExp == null)
                {
                    Messages.HataMesaji(exp.Message);
                    return false;
                }

                switch (sqlExp.Number)
                {
                    case 208:
                        Messages.HataMesaji("İşlem Yapmak İstediğiniz Tablo Veritabanında Bulunamadı.");
                        break;
                    case 547:
                        Messages.HataMesaji("Seçilen Kartın İşlem Görmüş Hareketleri Var Kart Silinemez.");
                        break;
                    case 2601:
                    case 2627:
                        Messages.HataMesaji("Girmiş Olduğunuz Id Daha Önce Kullanılmıştır.");
                        break;
                    case 4060:
                        Messages.HataMesaji("İşlem Yapmak İstediğiniz Veritabanı Sunucuda Bulunamadı.");
                        break;
                    case 18456:
                        Messages.HataMesaji("Server'a Bağlanılmak İstenilen Kullanıcı Adı ve Şifre Hatalıdır.");
                        break;
                    default:
                        Messages.HataMesaji(sqlExp.Message);
                        break;
                }

                return false;
            }
            catch (Exception exp)
            {
                Messages.HataMesaji(exp.Message);
                return false;
            }

            return true;
        }


        #region Dispose
        private bool _disposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                    _context.Dispose();

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