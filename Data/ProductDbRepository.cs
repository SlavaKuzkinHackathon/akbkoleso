using Microsoft.EntityFrameworkCore;
using akbkoleso.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace akbkoleso.Data
{
    public class ProductDbRepository : IProductRepository
    {
        private readonly akbkolesoContext akbkolesoContext;
        public ProductDbRepository(akbkolesoContext akbkolesoContext)
        {
            this.akbkolesoContext = akbkolesoContext;
        }
        public Product GetProduct(Guid id)
        {
            return akbkolesoContext.Products.Find(id);
        }
        // получение списка продуктов
        public List<Product> GetProducts()
        {
            return akbkolesoContext.Products.AsNoTracking().ToList();
        }
        public void Create(Product product)
        {
            akbkolesoContext.Products.Add(product);
            akbkolesoContext.SaveChanges();
        }

        public IEnumerable<Product> GetingProducts()
        {
            return akbkolesoContext.Products;
        }

        public void UpdateProduct(Product changedProduct, Product originalProduct = null)
        {
            if (originalProduct == null)
            {
                originalProduct = akbkolesoContext.Products.Find(changedProduct.Id);
            }
            else
            {
                akbkolesoContext.Products.Attach(originalProduct);
            }

            originalProduct.Category = changedProduct.Category;
            originalProduct.Name = changedProduct.Name;
            originalProduct.Price = changedProduct.Price;
            originalProduct.RetailPrice = changedProduct.RetailPrice;
            originalProduct.InQuantity = changedProduct.InQuantity;
            originalProduct.ImagePath = changedProduct.ImagePath;

            akbkolesoContext.SaveChanges();
        }

        public void DeleteProduct(Guid id)
        {
            akbkolesoContext.Products.Remove(new Product { Id = id });
            akbkolesoContext.SaveChanges();
        }
        public Product Get(Guid id)
        {
            var allProducts = GetAll();
            return allProducts.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetAll()
        {
            return akbkolesoContext.Products.AsNoTracking().ToList();
        }

        
    }
}