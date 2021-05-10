using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareHub.Models
{
    public class Register
    {
        private int id;
        private string username;
        private string password;
        private string organization;
        private string userEmail;
        private int userPhone;
        private string designation;
        private string orgAddress;
        private string orgEmail;
        private int orgPhone;

        public int Id { get => id; set => id = value; }

        [Required(ErrorMessage = "Enter User Name")]
        [Display(Name = "User Name")]
        public string Username { get => username; set => username = value; }

        [Required(ErrorMessage = "Enter Password")]
        [Display(Name = "Password")]
        public string Password { get => password; set => password = value; }

        [Required(ErrorMessage = "Enter Organization")]
        [Display(Name = "Organization")]
        public string Organization { get => organization; set => organization = value; }

        [Required(ErrorMessage = "Enter User Email")]
        [Display(Name = "User Email")]
        public string UserEmail { get => userEmail; set => userEmail = value; }

        [Required(ErrorMessage = "Enter User Phone")]
        [Display(Name = "User Phone")]
        public int UserPhone { get => userPhone; set => userPhone = value; }

        [Required(ErrorMessage = "Enter User Designation")]
        [Display(Name = "User Designation")]
        public string Designation { get => designation; set => designation = value; }

        [Required(ErrorMessage = "Enter Organization Address")]
        [Display(Name = "Organization Address")]
        public string OrgAddress { get => orgAddress; set => orgAddress = value; }

        [Required(ErrorMessage = "Enter Organization Email")]
        [Display(Name = "User Email")]
        public string OrgEmail { get => orgEmail; set => orgEmail = value; }

        [Required(ErrorMessage = "Enter Organization Phone")]
        [Display(Name = "Organization Phone")]
        public int OrgPhone { get => orgPhone; set => orgPhone = value; }
    }
}
