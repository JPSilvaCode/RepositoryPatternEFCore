using RAEFC.Domain.Core.Data;
using RAEFC.Infrastructure.Repository.Context;
using System.Threading.Tasks;

namespace RAEFC.Infrastructure.Repository.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RAEFCContext _context;

        public UnitOfWork(RAEFCContext context)
        {
            _context = context;
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Dispose() => _context.Dispose();
    }
}
