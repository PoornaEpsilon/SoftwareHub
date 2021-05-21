using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareHub.Models
{
    public class AdminLogin
    {
        private int uid;
        private string username;
        private string password;

        [Key]
        public int Uid { get => uid; set => uid = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
