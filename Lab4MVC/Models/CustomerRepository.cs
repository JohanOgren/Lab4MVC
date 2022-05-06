using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppLibContext _dbContext;

        public CustomerRepository(AppLibContext dataLibraryDb)
        {
            _dbContext = dataLibraryDb;
        }
        public IEnumerable<Customer> GetAllCustomers
        {
            get {
                return _dbContext.Customers;
                } 
        }

        public Customer DeleteCustomerById(int CustomerId)
        {
            var delelete = _dbContext.Customers.FirstOrDefault(c => c.CustomerId == CustomerId);
            _dbContext.Customers.Remove(delelete);
            _dbContext.SaveChanges();
            return delelete;
        }

        public Customer GetCustomerById(int CustomerId)
        {
            return _dbContext.Customers.Where(c => c.CustomerId == CustomerId).FirstOrDefault();
        }

        public Customer CreateNewCustomer(Customer customer)
        {
            _dbContext.Add(customer);
            _dbContext.SaveChanges();
            return customer;
        }

    }
}
