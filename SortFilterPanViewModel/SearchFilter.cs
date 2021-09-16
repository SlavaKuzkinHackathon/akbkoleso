using akbkoleso.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace akbkoleso.SortFilterPanViewModel
{
    public class SearchFilter
    {
        public SearchFilter(List<Product> products, string category, string SearchName) {
            products.Insert(0, new Product { Name = "Все",  });
            Products = new SelectList(products, "Id", "Category");
            SelectedCategory = category;
            SelectedNameS = SearchName;
        }
        public SelectList Products { get; private set; }
        public string SelectedCategory { get; private set; }
        public string SelectedNameS { get; private set; }// введенное имя
    }
}
