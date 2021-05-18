using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftwareHub.Models
{
    public class NewUserClass
    {

       [Key]
        public int userId { get; set; }

        [Required(ErrorMessage = "Enter User Name")]
        [Display(Name = "User Name")]
        public string username { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }


       

        [NotMapped]
        [Compare("password")]
        [DataType(DataType.Password)]
        public string confirmpassword { get; set; }

        [Required(ErrorMessage = "Enter Organisation Name")]
        [Display(Name = "Organisation Name")]
        public string organisation { get; set; }

        [Required(ErrorMessage = "Enter Personal Email")]
        [Display(Name = "Personal email")]
        [DataType(DataType.EmailAddress)]
        public string userEmail { get; set; }

        [Required(ErrorMessage = "Enter Organisation Email")]
        [Display(Name = "Organisation email")]
        [DataType(DataType.EmailAddress)]
        public string orgEmail { get; set; }

        [Required(ErrorMessage = "Enter Personal PhoneNumber")]
        [Display(Name = "Personal PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        public string userPhone { get; set; }

        [Required(ErrorMessage = "Enter Organisation PhoneNumber")]
        [Display(Name = "Organisation PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        public string orgPhone { get; set; }

        [Required(ErrorMessage = "Enter Designation")]
        [Display(Name = "Designation")]
        public string designation { get; set; }

        [Required(ErrorMessage = "Enter Address")]
        [Display(Name = "Address")]
        public string orgAddress { get; set; }

    }
}
