using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PT_Models
{
    public class Category
    {   
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Required]
        [Range(1, 500, ErrorMessage ="Must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}
