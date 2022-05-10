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

        public ViewResult AllCustomers()
        {
            return View(_customerRepository.GetAllCustomers);
        }

        public ViewResult CustomerById(int id)
        {
            return View(_customerRepository.GetCustomerById(id));
        }

        public IActionResult DeleteId(int id)
        {
            _customerRepository.DeleteCustomerById(id);
            var tillbaka = RedirectToAction("AllCustomers");
            return tillbaka;
        }

        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerRepository.CreateNewCustomer(customer);
                return RedirectToAction("AllCustomers");
            }
            return View(customer);
        }

        public IActionResult Update(int id)
        {

            return View(_customerRepository.Update(id));
        }

        //PostUpdate
        [HttpPost]
        public IActionResult Update(Customer cust)
        {
            

            if (ModelState.IsValid)
            {
                _customerRepository.Update(cust);
                return RedirectToAction("AllCustomers");
            }
            return View(cust);

        }

    }
}
