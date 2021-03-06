using Lab4MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC
{
    public class AppLibContext : DbContext
    {
        public AppLibContext(DbContextOptions <AppLibContext> options): base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<LinkTable> LinkTables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                 .HasData(
                    new  { CustomerId = 1, FirstName = "Tony", LastName= "Stark", PhoneNumber = "0701231233",Gender ="Male"},
                    new  { CustomerId = 2, FirstName = "Natalia", LastName = "Romanoff", PhoneNumber = "0703332222",Gender ="Female"},
                    new  { CustomerId = 3, FirstName = "Bruce", LastName = "Banner",PhoneNumber = "07044422233",Gender ="Male"},
                    new  { CustomerId = 4, FirstName = "Wanda", LastName = "Maximoff",PhoneNumber = "0701113332",Gender ="Female"},
                    new  { CustomerId = 5, FirstName = "Thor", LastName = "Odinson", PhoneNumber = "0701337133",Gender ="Male"}
                );

            modelBuilder.Entity<Books>()
                .HasData(
                new  { BookId = 1, BookName ="Hobbit", ISBN = "9789113084893", Author ="J.R.R.Tolkien"},
                new  { BookId = 2, BookName ="The Two Towers", ISBN = "9780261102361", Author ="J.R.R.Tolkien"},
                new  { BookId = 3, BookName ="The Return of the King", ISBN = "9780261102378", Author ="J.R.R.Tolkien"},
                new  { BookId = 4, BookName ="The Fall of Gondolin", ISBN = "9780008302757", Author ="J.R.R.Tolkien"},
                new  { BookId = 5, BookName = "Harry Potter and the Philosopher's Stone", ISBN = "9781408855652", Author ="J.K.Rowling"},
                new  { BookId = 6, BookName = "Harry Potter and the Chamber of Secrets", ISBN = "9781408855669", Author = "J.K.Rowling" },
                new  { BookId = 7, BookName = "Harry Potter and the Chamber of Secrets", ISBN = "9781408855669", Author = "J.K.Rowling" },
                new  { BookId = 8, BookName = "Harry Potter and the Half-Blood Prince", ISBN = "9781408855706", Author = "J. K. Rowling" }
                );
            modelBuilder.Entity<LinkTable>()
                .HasData(
                new { LinkTableId = 1, CustomerId = 1, BookId = 1, StartDate = new DateTime(2022 , 01 , 01), EndDate = new DateTime(2022 , 02 , 01), Returned = true},
                new { LinkTableId = 2, CustomerId = 1, BookId = 8, StartDate = new DateTime(2022 , 02 , 02), EndDate = new DateTime(2022 , 03 , 14), Returned = true },
                new { LinkTableId = 3, CustomerId = 2, BookId = 7, StartDate = new DateTime(2021 , 03 , 03), EndDate = new DateTime(2022 , 06 , 12), Returned = true},
                new { LinkTableId = 4, CustomerId = 2, BookId = 6, StartDate = new DateTime(2021 , 04 , 05), EndDate = new DateTime(2021 , 07 , 24), Returned = false},
                new { LinkTableId = 5, CustomerId = 3, BookId = 5, StartDate = new DateTime(2020 , 06 , 22), EndDate = new DateTime(2020 , 06 , 25), Returned = true},
                new { LinkTableId = 6, CustomerId = 3, BookId = 4, StartDate = new DateTime(2021 , 03 , 24), EndDate = new DateTime(2021 , 12 , 24), Returned = false},
                new { LinkTableId = 7, CustomerId = 4, BookId = 3, StartDate = new DateTime(2021 , 07 , 11), EndDate = new DateTime(2021 , 08 , 15), Returned = true},
                new { LinkTableId = 8, CustomerId = 5, BookId = 1, StartDate = new DateTime(2021 , 09 , 02), EndDate = new DateTime(2021 , 11 , 01), Returned = true},
                new { LinkTableId = 9, CustomerId = 5, BookId = 2, StartDate = new DateTime(2021 , 05 , 15), EndDate = new DateTime(2021 , 08 , 11), Returned = false},

                new { LinkTableId = 10, CustomerId = 5, BookId = 3, StartDate = new DateTime(2021 , 05 , 15), EndDate = new DateTime(2021 , 08 , 11), Returned = true},
                new { LinkTableId = 11, CustomerId = 5, BookId = 4, StartDate = new DateTime(2022 , 05 , 15), EndDate = new DateTime(2022 , 07 , 16), Returned = false},
                new { LinkTableId = 12, CustomerId = 5, BookId = 5, StartDate = new DateTime(2021 , 01 , 15), EndDate = new DateTime(2022 , 08 , 11), Returned = false},
                new { LinkTableId = 13, CustomerId = 5, BookId = 6, StartDate = new DateTime(2022 , 06 , 05), EndDate = new DateTime(2022 , 07 , 28), Returned = true},
                new { LinkTableId = 14, CustomerId = 5, BookId = 7, StartDate = new DateTime(2012 , 02 , 11), EndDate = new DateTime(2015 , 01 , 11), Returned = true},
                new { LinkTableId = 15, CustomerId = 5, BookId = 8, StartDate = new DateTime(2014 , 05 , 15), EndDate = new DateTime(2027 , 02 , 18), Returned = true}

                );
        }

    }
}
