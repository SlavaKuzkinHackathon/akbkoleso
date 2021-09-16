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
    public class PodborAkbController : Controller
    {
        private akbkolesoCatalogContext context;
        public IRepositoryAkb akb_Repository;

        public PodborAkbController(IRepositoryAkb repo, akbkolesoCatalogContext ctx)
        {
            context = ctx;
            akb_Repository = repo;
        }
        public IActionResult Index(string Name, string vendor = null, string car = null, string modification = null)
        {
            var PodborAkums = akb_Repository.GetFilteredPodbor_akbs(vendor, car, modification);

            var vvendor = context.Podbor_akbs
                .Select(v => new SelectListItem
                {
                    Value = v.Vendor,
                    Text = v.Vendor
                })
                .Distinct()
                .OrderBy(p => p.Text);
            ViewBag.vendor = vvendor;

            return View(PodborAkums);
        }

        public ActionResult GetItemsCarsAkb(string id)
        {
            var car = context.Podbor_akbs
                .Where(p => p.Vendor == id)
                .AsEnumerable()
                .GroupBy(x => x.Car)
                .Select(x => x.First()).ToList();

            return PartialView(car);
        }

        public ActionResult GetItemsModificationsAkb(string id)
        {
            var modification = context.Podbor_akbs
                .Where(p => p.Car == id)
                .AsEnumerable()
                .GroupBy(x => x.Modification)
                .Select(x => x.First()).ToList();

            return PartialView(modification);
        }
    }
}
