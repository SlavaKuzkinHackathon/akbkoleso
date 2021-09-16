using akbkoleso.Models;
using System.Collections.Generic;

namespace akbkoleso.Data
{
    public class SampleData
    {
        public static List<Product> GetDefaultProducts()
        {
            var products = new List<Product>();
            for (int i = 1; i < 100; i++)
            {
                products.Add(new Product
                {
                    Category = "Category" + " " + i,
                    Name = "Product" + " " + i,
                    Price = i * 10000,
                    RetailPrice = i * 10000,
                    InQuantity = i * 100,
                    ImagePath = "/images/products/400x300.png"
                });
            }
            return products;
        }
    }
}
/* using akbkoleso.Models;
using System.Collections.Generic;

namespace akbkoleso.Data
{
    public class SampleData
    {
        public static List<Product> GetDefaultProducts()
        {
            var products = new List<Product>();
            for (int i = 1; i < 100; i++)
            {
                products.Add(new Product
                {
                    Category = "Category" + " " + i,
                    Name = "Product" + " " + i,
                    Price = i * 10000,
                    RetailPrice = i * 10000,
                    InQuantity = i * 100,
                    ImagePath = "/images/products/400x300.png"
                });
            }
            return products;
        }
    }
} */