using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Project_1030.Models
{
   public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        public string Author { get; set; }
        [Required]
        [Range(1,10000)]
        public double ListPrice { get; set; }      //590
        [Required]
        [Range(1,10000)]
        public double Price50 { get; set; }     //460
        [Required]
        [Range(1,10000)]
        public double Price100 { get; set; }      //430
        [Required]
        [Range(1, 10000)]
        public double Price { get; set; }      //500
        [Display(Name ="Category")]
        public int CategoryId { get; set; }
        public Category category { get; set; }
        [Display(Name ="CoverType")]
        public int CoverTypeId { get; set; }
        public CoverType coverType { get; set; }
        [Display(Name ="ImageUrl")]
        public string ImageUrl { get; set; }

    }
}
