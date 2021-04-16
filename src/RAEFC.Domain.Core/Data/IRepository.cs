using RAEFC.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RAEFC.Domain.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();

        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}