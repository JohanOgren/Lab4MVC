using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public class LinkTable
    {
        [Key]
        public int LinkTableId { get; set; }
        public int CustomerId { get; set; }
        public int BookId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Required]
        public bool Returned { get; set; }


        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [ForeignKey("BookId")]
        public Books Books { get; set; }
    }
}
