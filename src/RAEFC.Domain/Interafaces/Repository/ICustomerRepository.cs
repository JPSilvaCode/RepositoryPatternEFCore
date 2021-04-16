﻿using RAEFC.Domain.Core.Data;
using RAEFC.Domain.Models;
using System.Threading.Tasks;

namespace RAEFC.Domain.Interafaces.Repository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<Customer> GetByEmail(string email);
    }
}