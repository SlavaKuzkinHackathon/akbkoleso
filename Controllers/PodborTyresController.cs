using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using akbkoleso.Data;
using akbkoleso.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace akbkoleso.Controllers
{
    public class PodborTyresController : Controller
    {
        private akbkolesoCatalogContext context;
        public IRepository_t_w t_w_Repository;

        public PodborTyresController(IRepository_t_w repo, akbkolesoCatalogContext ctx)
        {
            context = ctx;
            t_w_Repository = repo;
        }
        public IActionResult Index(string Name, string vendor = null, string car = null, string year = null, string modification = null)
        {
            var Catalog_tires_wheelss = t_w_Repository.GetFilteredCatalog_tires_wheelss(vendor, car, year, modification);

            var vvendor = context.Catalog_tires_wheelss
                .Select(v => new SelectListItem
                {
                    Value = v.Vendor,
                    Text = v.Vendor
                })
                .Distinct()
                .OrderBy(p => p.Text);
            ViewBag.vendor = vvendor;

            return View(Catalog_tires_wheelss);
        }

        public ActionResult GetItemsCars(string id)
        {
            var car = context.Catalog_tires_wheelss
                .Where(p => p.Vendor == id)
                .AsEnumerable()
                .GroupBy(x => x.Car)
                .Select(x => x.First()).ToList();

            return PartialView(car);
        }

        public ActionResult GetItemsYears(string id)
        {
            var year = context.Catalog_tires_wheelss
                .Where(p => p.Car == id)
                .AsEnumerable()
                .GroupBy(x => x.Year)
                .Select(x => x.First()).ToList();

            return PartialView(year);
        }

    }
}
