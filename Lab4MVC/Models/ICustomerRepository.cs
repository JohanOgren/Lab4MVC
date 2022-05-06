using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers { get; }

        Customer GetCustomerById(int CustomerId);

        Customer DeleteCustomerById(int CustomerId);

        Customer CreateNewCustomer(Customer customer);
    }
}
