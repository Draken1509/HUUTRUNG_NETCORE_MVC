using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.Models
{
    public  class ApplicationUser : IdentityUser
    {
              
        [Required]
        public string Name { get; set; }    
        
        [Display(Name = "State/Province")]
        public string? Province { get; set; }

        [NotMapped]
        public string? District { get; set; }

        [Display(Name = "Street Address")]
        public string? StreetAddress { get; set; }
        
        public string? Postal { get; set; }

        public string ? City { get; set; }

        //add foreign key - Region
        //[Display(Name = "Region/Country")]
        //public int? RegionId { get; set; }
        //[ForeignKey("RegionId")]
        //[ValidateNever]
        //public Region? Region { get; set; }


        [Display(Name = "Company")]
        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        [ValidateNever]
        public Company? Company { get; set; }


		//chuc nang quan li user
		[NotMapped]
		public string Role { get; set; }


	}
}
