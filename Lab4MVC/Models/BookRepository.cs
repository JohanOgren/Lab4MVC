using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppLibContext _dbContext;

        public BookRepository(AppLibContext dataLibraryDb)
        {
            _dbContext = dataLibraryDb;
        }

        public IEnumerable<Books> GetAllBooksForCustomer
        {
            get
            {
                return _dbContext.Books;
            }
        }

    }
}