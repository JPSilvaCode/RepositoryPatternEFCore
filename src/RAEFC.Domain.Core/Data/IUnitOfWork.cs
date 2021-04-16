using System;
using System.Threading.Tasks;

namespace RAEFC.Domain.Core.Data
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}