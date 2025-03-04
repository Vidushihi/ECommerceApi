using ECommerceApi.Models;

namespace ECommerceApi.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomers();
    }
}
