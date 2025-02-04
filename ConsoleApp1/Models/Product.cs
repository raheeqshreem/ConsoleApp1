using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Product
    {

      
        [Key]

        public int Id { get; set; }

        [Required]

        [StringLength(30, MinimumLength = 20)]

        public string Name { get; set; }

        [Required]

        [Range(1000, 50000)]

        public decimal Price { get; set; }

    }
}
