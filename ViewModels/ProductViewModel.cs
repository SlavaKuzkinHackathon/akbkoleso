using Microsoft.AspNetCore.Http;
using akbkoleso.Models;
using System;
using System.Collections.Generic;
using akbkoleso.SortFilterPanViewModel;
using akbkoleso.Pages;
using System.Linq;
using System.Threading.Tasks;
namespace akbkoleso.ViewModels
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int RetailPrice { get; set; }
        public int InQuantity { get; set; }
        public string ImagePath { get; set; }
        public IFormFile File { set; get; }

    }
}