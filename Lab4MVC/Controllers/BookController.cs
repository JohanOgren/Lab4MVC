using Lab4MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Controllers
{
    public class BookController : Controller
    {

        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepo)
        {
            _bookRepository = bookRepo;
        }
        public ViewResult BookByCustomer(int id)
        {
            return View(_bookRepository.GetAllBooksForCustomer(id));
        }
    }
}
