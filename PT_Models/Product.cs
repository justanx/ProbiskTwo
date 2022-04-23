using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PT_Models
{
    public class Product
    {
        public Product()
        {
            TempSqft = 1;
        }

        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        [Range(1, 500)]
        public int Price { get; set; }

        public string Image { get; set; }


    
        [Display(Name="Category Type")]
        public int CategoryId { get; set; } // navigation entity
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } // FK


        [Display(Name="Application Type")]
        public int ApplicationTypeId { get; set; }


        [ForeignKey("ApplicationTypeId")]
        public virtual ApplicationType ApplicationType { get; set; }

        [NotMapped] // NotMapped if you update the database or add new migration TempSqft will not be pushed to the database
        [Range(1, 10000, ErrorMessage = "Sqft must be greater than 0")]
        public int TempSqft { get; set; }

    }
}
