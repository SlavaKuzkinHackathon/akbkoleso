using akbkoleso.Data;
using akbkoleso.Models.Admin.Catalog;
using akbkoleso.Pages;
using akbkoleso.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;



namespace akbkoleso.Controllers
{
    [Authorize(Roles = "Admin")]
    public class Catalog_t_wController : Controller
    {
        private IRepository_t_w repository;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public Catalog_t_wController(IRepository_t_w repo, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            repository = repo;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IActionResult Index(QueryOptions options)
        {
            return View(repository.GetAllCatalog_tires_wheelss(options));
        }
        
        public IActionResult Create()
        {
            ViewBag.CreateMode = true;
            return View("Editor", new Catalog_tires_wheels());
        }

        [HttpPost]
        public IActionResult Create(Catalog_tires_wheels newCatalog_tires_wheels)
        {
            repository.CreateCatalog_tires_wheels(newCatalog_tires_wheels);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Generate(long id)
        {
            ViewBag.Catalog_tires_wheelss = repository.GetAllCatalog_tires_wheelss(); 
            return View("Generate", repository.GetCatalog_tires_wheels(id));
        }

        [HttpPost]
        public IActionResult Generate(Catalog_tires_wheels newCatalog_tires_wheels)
        {
            repository.GenerateCatalog_tires_wheels(newCatalog_tires_wheels);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(long id)
        {
            ViewBag.Catalog_tires_wheelss = repository.GetAllCatalog_tires_wheelss();
            ViewBag.CreateMode = false;
            return View("Editor", repository.GetCatalog_tires_wheels(id));
        }

        [HttpPost]
        public IActionResult Edit(Catalog_tires_wheels Catalog_tires_wheels, Catalog_tires_wheels original)
        {
            repository.UpdateCatalog_tires_wheels(Catalog_tires_wheels, original);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(long Id)
        {
            repository.DeleteCatalog_tires_wheels(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}