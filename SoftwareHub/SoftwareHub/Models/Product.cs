using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareHub.Models
{
    public class Product
    {
        private int productId;
        private string productName;
        private string description;
        private float basicPrice;
        private float standardPrice;
        private float enterprisePrice;
        private string category;
        private string pocName;
        private string pocEmail;
        private int pocPhone;

        [Display(Name = "Product Id")]
        public int ProductId { get => productId; set => productId = value; }

        [Required(ErrorMessage = "Enter ProductName")]
        [Display(Name = "Product Name")]
        public string ProductName { get => productName; set => productName = value; }

        [Required(ErrorMessage = "Enter Description")]
        [Display(Name = "Description")]
        public string Description { get => description; set => description = value; }

        [Required(ErrorMessage = "Enter Basic Price")]
        [Display(Name = "Basic Price")]
        public float BasicPrice { get => basicPrice; set => basicPrice = value; }

        [Required(ErrorMessage = "Enter Standard Price")]
        [Display(Name = "Standard Price")]
        public float StandardPrice { get => standardPrice; set => standardPrice = value; }

        [Required(ErrorMessage = "Enter Enterprise Price")]
        [Display(Name = "Enterprise Price")]
        public float EnterprisePrice { get => enterprisePrice; set => enterprisePrice = value; }

        [Required(ErrorMessage = "Enter Product Category")]
        [Display(Name = "Product Category")]
        public string Category { get => category; set => category = value; }

        [Required(ErrorMessage = "Enter POC Name")]
        [Display(Name = "POC Name")]
        public string PocName { get => pocName; set => pocName = value; }

        [Required(ErrorMessage = "Enter POC Email")]
        [Display(Name = "POC Email")]
        public string PocEmail { get => pocEmail; set => pocEmail = value; }

        [Required(ErrorMessage = "Enter POC Phone")]
        [Display(Name = "POC Phone")]
        public int PocPhone { get => pocPhone; set => pocPhone = value; }
    }
}