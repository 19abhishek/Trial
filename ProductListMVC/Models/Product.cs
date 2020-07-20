using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductListMVC.Models
{
    public class Product
    {
        [Key]

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string QualityParameter { get; set; }

        [Required]
        public string ProcessParameter { get; set; }

        [Required]
        public string Equipment { get; set; }


    }
}
