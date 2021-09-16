
using Microsoft.AspNetCore.Mvc;
using akbkoleso.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace akbkoleso.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService productService;

        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index(Guid id)
        {
            var product = productService.GetProduct(id);
            return View(product);
        }

        
    }
}
