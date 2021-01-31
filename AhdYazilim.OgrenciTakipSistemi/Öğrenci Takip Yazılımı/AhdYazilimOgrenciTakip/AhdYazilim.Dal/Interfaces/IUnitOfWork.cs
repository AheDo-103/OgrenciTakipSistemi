using System;

namespace AhdYazilim.Dal.Interfaces
{
    public interface IUnitOfWork<TEntity> : IDisposable where TEntity : class
    {
        IRepository<TEntity> Rep { get; }

        bool Save();
    }
}