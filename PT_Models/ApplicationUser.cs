using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PT_Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        [NotMapped]
        [Required]
        public string StreetAddress { get; set; }

        [NotMapped]
        [Required]
        public string City { get; set; }

        [NotMapped]
        [Required]
        public string State { get; set; }

        [NotMapped]
        [Required]
        public string PostalCode { get; set; }
    }
}
