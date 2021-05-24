using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentWithPayPalRestAPI.Models
{
    public class ProductModel
    {
        public List<Product> FindAll()
        {
            return new List<Product>
            {
                new Product
                {
                    Id="p01",
                    Name="Name 1",
                    Photo="profile-image-1.jpg",
                    Price=4.5,
                    Quantity=2
                },
                 new Product
                {
                    Id="p02",
                    Name="Name 2",
                    Photo="profile-image-2.jpg",
                    Price=7.6,
                    Quantity=4
                },
                  new Product
                {
                    Id="p03",
                    Name="Name 3",
                    Photo="profile-image-3.jpg",
                    Price=10,
                    Quantity=5
                }
            };
        }
    }
}
