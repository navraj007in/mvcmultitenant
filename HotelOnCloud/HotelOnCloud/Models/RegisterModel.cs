using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelOnCloud.Models
{
    public class SubscribeModel
    {
        [Required]
        [Display(Name = "Name")]

        public string Name { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Owner Name")]
        public string OwnerName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "City")]
        public String City { get; set; }

        [Required]
        [Display(Name = "State")]
        public String State { get; set; }

        [Required]
        [Display(Name = "Country")]
        public String Country { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public String ZipCode { get; set; }

        [Required]
        [Display(Name = "Property Name")]
        public String PropertyName { get; set; }

        [Required]
        [Display(Name = "Manager Name")]
        public String ContactPerson{ get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "User Name for this property(Enter Email)")]
        public String PropertyUser { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string PropertyPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("PropertyPassword", ErrorMessage = "The password and confirmation password do not match.")]

        public string PropertyConfirmPassword { get; set; }
        [Required]
        [DataType(DataType.Text )]
        [Display(Name = "Address")]
        public String PropertyAddress { get; set; }

        [Required]
        [DataType(DataType.Text)]

        [Display(Name = "City")]
        public String PropertyCity { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "State")]
        public String PropertyState { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Country")]
        public String PropertyCountry { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Contact Number")]
        public String ContactNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        [Display(Name = "Email")]
        public String PropertyEmail { get; set; }


        [Display(Name = "Fax")]
        [DataType(DataType.PhoneNumber )]
        public String Fax { get; set; }

        [DataType(DataType.Url )]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]

        [Display(Name = "Website")]
        public String PropertyWebsite { get; set; }

    }
}