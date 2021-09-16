using akbkoleso.Data;
using akbkoleso.Models;
using akbkoleso.SortFilterPanViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace akbkoleso.Controllers
{
    public class TyresController : Controller
    {

        private const int pageSize = 12;
        private const int maxPages = 5;

        private akbkolesoContext context;
        public IProductRepository productRepository;

        public TyresController(IProductRepository repo, akbkolesoContext ctx)
        {
            context = ctx;
            productRepository = repo;
        }

        public async Task<IActionResult> Index(string SearchName, string NameA, string NameB, string NameC, string NameD, string NameF, string NameG,
    string category = "Автошины", int page = 1, SortState sortOrder = SortState.RetailPriceAsc)
        {
            int pageSize = 12; //количество элементов на страницу
            //фильтрация
            IQueryable<Product> products = context.Products;

            if (!String.IsNullOrEmpty(category))
            {
                products = products.Where(p => p.Category.Contains(category));
            }
            //фильтр по модели
            if (!String.IsNullOrEmpty(SearchName))
            {
                products = products
                    .Where(p => p.Name.Contains(SearchName));
            }

            if (!String.IsNullOrEmpty(NameA) | !String.IsNullOrEmpty(NameB) | !String.IsNullOrEmpty(NameC) | !String.IsNullOrEmpty(NameD) | !String.IsNullOrEmpty(NameF) | !String.IsNullOrEmpty(NameG))
            {
                products = products
                    .Where(p => p.Name.Contains(NameA))
                    .Where(p => p.Name.Contains(NameB))
                    .Where(p => p.Name.Contains(NameC))
                    .Where(p => p.Name.Contains(NameD))
                    .Where(p => p.Name.Contains(NameF))
                    .Where(p => p.Name.Contains(NameG));
            }
            switch (sortOrder)
            {
                case SortState.RetailPriceDesc:
                    products = products.OrderByDescending(s => s.RetailPrice);
                    break;
                case SortState.InQuantityAsc:
                    products = products.OrderBy(s => s.InQuantity);
                    break;
                case SortState.InQuantityDesc:
                    products = products.OrderByDescending(s => s.InQuantity);
                    break;
                default:
                    products = products.OrderBy(s => s.RetailPrice);
                    break;
            }

            // пагинация
            var count = await products.CountAsync();
            var items = await products.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            // формируем модель представления
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(context.Products.ToList(), category, NameA, NameB, NameC, NameD, NameF, NameG),
                SearchFilter = new SearchFilter(context.Products.ToList(), category, SearchName),
                Products = items
            };
            return View(viewModel);
        }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}