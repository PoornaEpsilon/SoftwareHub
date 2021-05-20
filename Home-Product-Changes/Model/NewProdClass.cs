using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DatabaseLink.Models
{
    public class NewProdClass
    {
        [Key]

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string productname { get; set; }

        public int basicPrice { get; set; }

        public int standardPrice { get; set; }

        public int enterprisePrice { get; set; }

        public string category { get; set; }

        public string details { get; set; }

        public string pocName { get; set; }

        public string pocEmail { get; set; }

        public int pocPhone { get; set; }

  
    }
}
