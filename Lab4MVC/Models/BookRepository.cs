using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<LinkTable> GetAllBooksForCustomer(int id)
        {
            var resultat = _dbContext.LinkTables.Include(l => l.Books)
                    .Where(b => b.CustomerId == id);
            return resultat;
        }
    }
} 