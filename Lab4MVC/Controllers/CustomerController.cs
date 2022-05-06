using Lab4MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepo)
        {
            _customerRepository = customerRepo;
        }

        public ViewResult List()
        {
            return View(_customerRepository.GetAllCustomers);
        }

        public ViewResult ListId(int id)
        {
            return View(_customerRepository.GetCustomerById(id));
        }

        public IActionResult DeleteId(int id)
        {
            _customerRepository.DeleteCustomerById(id);
            var tillbaka = RedirectToAction("List");
            return tillbaka;
        }

        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                return View(_customerRepository.CreateNewCustomer(customer));
            }
            return View(customer);
        }

    }
}
