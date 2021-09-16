using akbkoleso.Models.Admin.Catalog;
using akbkoleso.Pages;
using akbkoleso.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace akbkoleso.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CatalogAkbController : Controller
    {
        private IRepositoryAkb repository;

        public CatalogAkbController(IRepositoryAkb repo)
        {
            repository = repo;
        }

        public IActionResult Index(QueryOptions options)
        {
            return View(repository.GetAllPodbor_akbs(options));
        }

        public IActionResult Create()
        {
            ViewBag.CreateMode = true;
            return View("Editor", new Podbor_akb());
        }

        [HttpPost]
        public IActionResult Create(Podbor_akb newPodbor_akb)
        {
            repository.CreatePodbor_akb(newPodbor_akb);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Generate(long id)
        {
            ViewBag.Podbor_akbs = repository.GetAllPodbor_akbs();
            return View("Generate", repository.GetPodbor_akb(id));
        }

        [HttpPost]
        public IActionResult Generate(Podbor_akb newPodbor_akb)
        {
            repository.GeneratePodbor_akb(newPodbor_akb);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(long id)
        {
            ViewBag.Podbor_akbs = repository.GetAllPodbor_akbs();
            ViewBag.CreateMode = false;
            return View("Editor", repository.GetPodbor_akb(id));
        }

        [HttpPost]
        public IActionResult Edit(Podbor_akb Podbor_akb, Podbor_akb original)
        {
            repository.UpdatePodbor_akb(Podbor_akb, original);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(long Id)
        {
            repository.DeletePodbor_akb(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}