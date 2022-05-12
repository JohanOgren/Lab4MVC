using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please enter first name.")]
        [MinLength(5)]
        [MaxLength(15)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name.")]
        [MinLength(5)]
        [MaxLength(15)]
        public string LastName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter Gender.")]
        [MinLength(4)]
        [MaxLength(17)]
        public string Gender { get; set; }

        public ICollection<LinkTable> LinkTables { get; set; }
    }
}
