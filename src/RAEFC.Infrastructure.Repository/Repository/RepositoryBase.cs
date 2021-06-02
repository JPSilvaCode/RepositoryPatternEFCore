using Microsoft.EntityFrameworkCore;
using RAEFC.Domain.Core.Data;
using RAEFC.Domain.Core.Models;
using RAEFC.Infrastructure.Repository.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RAEFC.Infrastructure.Repository.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, IAggregateRoot
    {
        protected readonly RAEFCContext _context;

        public RepositoryBase(RAEFCContext context)
        {
            _context = context;
        }

        #region read
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        #endregion

        #region write
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        #endregion

        public void Dispose() => _context.Dispose();
    }
}