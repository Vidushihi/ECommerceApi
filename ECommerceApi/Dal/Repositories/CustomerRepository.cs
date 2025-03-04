using ECommerceApi.Interfaces;
using ECommerceApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApi.Dal.Repositories
{ 
   public class CustomerRepository : ICustomerRepository
    {
        private readonly ECommerceDbContext _context;

        public CustomerRepository(ECommerceDbContext context)
        {
            _context = context;
        }
        public async Task<List<Customer>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }
    }


}
