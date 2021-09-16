using akbkoleso.Models;
using akbkoleso.Models.Admin;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace akbkoleso.SortFilterPanViewModel
{
    public class FilterViewModel
    {
        public FilterViewModel(List<Product> products, string category, string NameA, string NameB, string NameC, string NameD, string NameF, string NameG)
        {
            products.Insert(0, new Product { Name = "Все"});
            Products = new SelectList(products, "Id", "Category");
            SelectedCategory = category;
            SelectedNameA = NameA;
            SelectedNameB = NameB;
            SelectedNameC = NameC;
            SelectedNameD = NameD;
            SelectedNameF = NameF;
            SelectedNameG = NameG;
        }
        public SelectList Products { get; private set; }
        public string SelectedCategory { get; private set; }
        public string SelectedNameA { get; private set; }// введенное имя
        public string SelectedNameB { get; private set; }// введенное имя1
        public string SelectedNameC { get; private set; }// введенное имя2
        public string SelectedNameD { get; private set; }// введенное имя3  
        public string SelectedNameF { get; private set; }// введенное имя4 
        public string SelectedNameG { get; private set; }// введенное имя5 
    }
}
