using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareHub.Models
{
    public class Cart
    {
        private int cartId;
        private int userId;
        private int productId;
        private string productName;
        private float price;

        [Key]
        public int CartId { get => cartId; set => cartId = value; }
        public int UserId { get => userId; set => userId = value; }

        [Display(Name = "Product Id")]
        public int ProductId { get => productId; set => productId = value; }

        [Display(Name = "Product Name")]
        public string ProductName { get => productName; set => productName = value; }

        [Display(Name = "Product Price")]
        public float Price { get => price; set => price = value; }
    }
}
