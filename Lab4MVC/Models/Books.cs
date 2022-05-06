using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]

        public string ISBN { get; set; }
        [Required]

        public string Author { get; set; }

        public ICollection<LinkTable> LinkTables { get; set; }
    }
}
