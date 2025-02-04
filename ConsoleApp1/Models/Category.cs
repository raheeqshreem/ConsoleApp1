using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Category
    {
  

        [Key]

        public int Cat_Id { get; set; }

        [Required]

        [StringLength(20, MinimumLength = 3)]

        public string CategoryName { get; set; }





    }
}
