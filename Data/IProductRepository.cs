using akbkoleso.Models;
using System;
using System.Collections.Generic;

namespace akbkoleso.Data
{
    public interface IProductRepository
    {
        Product GetProduct(Guid id);
        List<Product> GetProducts();

        IEnumerable<Product> GetingProducts();
        void Create(Product product);

        void UpdateProduct(Product changedProduct, Product originalProduct = null);

        void DeleteProduct(Guid id);
        List<Product> GetAll();
        Product Get(Guid id);
        
    }
}