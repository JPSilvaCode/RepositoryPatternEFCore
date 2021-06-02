using RAEFC.Domain.Interafaces.Repository;
using RAEFC.Domain.Models;
using RAEFC.Infrastructure.Repository.Context;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RAEFC.Infrastructure.Repository.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(RAEFCContext context) : base(context)
        { }

        #region Read
        public async Task<Customer> GetByEmail(string email)
        {
            return await _context.Set<Customer>().SingleOrDefaultAsync(x => x.Email == email);
        }
        #endregion
    }
}