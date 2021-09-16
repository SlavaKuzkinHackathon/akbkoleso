using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using akbkoleso.Data;
using akbkoleso.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace akbkoleso.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SeedController : Controller
    {
        private akbkolesoContext context;

        public SeedController(akbkolesoContext ctx) => context = ctx;

        public IActionResult Index()
        {
            ViewBag.Count = context.Products.Count();
            return View(context.Products.OrderBy(p => p.Id));
        }



        [HttpPost]
        public IActionResult ClearData()
        {
            context.Database.SetCommandTimeout(System.TimeSpan.FromMinutes(10));
            context.Database.BeginTransaction();
            context.Database.ExecuteSqlRaw("DELETE FROM Products");
            context.Database.CommitTransaction();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult CreateProductionData()
        {
            ClearData();

            context.Products.AddRange(new Product[] {
                          new Product{
                            Category ="Автошины", Name = " 175/70R14 MAXXIS NP-5 84T шип",
                            Price = 2970, RetailPrice = 3200, InQuantity = 4, ImagePath = "/Files/WP_20201016_023.jpg"
                        },
                        new Product {
                            Category ="Автошины", Name = " 195/65R15 Gislaved Nord Frost 200 ID 95T  шип",
                            Price = 3830, RetailPrice = 4200, InQuantity = 4, ImagePath = "/Files/WP_20201016_023.jpg"
                        },
                        new Product {
                            Category ="Автошины", Name = " 215/70R16 Nitto Therma Spike 100T шип зимняя",
                            Price = 6840, RetailPrice = 7200, InQuantity = 4, ImagePath = "/Files/Nexen ru1.jpg"
                        },
                        new Product {
                            Category ="Автошины", Name = " 215/55R19 Hankook  шип",
                            Price = 7050, RetailPrice = 8270, InQuantity = 4, ImagePath = "/Files/WP_20201016_023.jpg"
                        },
                        new Product {
                            Category ="Автошины", Name = " 205/55R16 Hankook  W429  91T  XL  шип",
                            Price = 7450, RetailPrice = 8200, InQuantity = 17, ImagePath = "/Files/WP_20201016_023.jpg"
                        },
                        new Product {
                            Category ="Автошины", Name = " 205/55R16 Hankook  W429  91T  XL  шип",
                            Price = 7450, RetailPrice = 8200, InQuantity = 17, ImagePath = "/Files/WP_20201016_023.jpg"
                        },
                         new Product {
                            Category ="Автошины", Name = " 215/60R16 95Q Nexen Win-Ice всесезонная",
                            Price = 4570, RetailPrice = 5200, InQuantity = 4, ImagePath = "/Files/WP_20201016_023.jpg"
                        },
                        new Product {
                            Category ="Автошины", Name = "Автошина 215/65R16 95Q Nexen Win777 всесезонная",
                            Price = 4670, RetailPrice = 5280, InQuantity = 4, ImagePath = "/Files/WP_20201016_023.jpg"
                        },
                        new Product {
                            Category ="Автошины", Name = " 205/65R15 Yokohama ES32  99H  летняя",
                            Price = 3680, RetailPrice = 4300, InQuantity = 4, ImagePath = "/Files/WP_20201016_023.jpg"
                        },
                        new Product {
                            Category ="Автошины", Name = " 175/70R13 Кама-205 Б/К НК летняя",
                            Price = 1800, RetailPrice = 2300, InQuantity = 3, ImagePath = "/Files/WP_20201016_023.jpg"
                        },
                        new Product {
                            Category ="Автошины", Name = " 215/70R16 100H Classe Premiere CP671 Nexen  всесезонная",
                            Price = 4930, RetailPrice = 5300, InQuantity = 4, ImagePath = "/Files/WP_20201016_023.jpg"
                         },
                        new Product {
                            Category = "Диски", Name = " 15 K&K  KC861 Solaris2  6.0*15 4*100 ET46 D54.1 силвер",
                            Price = 4150, RetailPrice = 5150, InQuantity = 4, ImagePath ="/Files/b012.jpg"
                        },
                        new Product {
                            Category = "Диски", Name = " 15 Trebl X40923 6.0*15 4*100 ET46 54.1 BK",
                            Price = 1900, RetailPrice = 2400, InQuantity = 4, ImagePath ="/Files/b012.jpg"
                        },
                        new Product {
                            Category = "Диски", Name = " 16 K&K  Борелли-оригинал KC613 6.5*16 5*114.3 ET46 D67.1 дарк платинум",
                            Price = 5350, RetailPrice = 6100,  InQuantity = 4, ImagePath ="/Files/b012.jpg"
                        },
                        new Product {
                            Category = "Диски", Name = " 15 Cross Street  Y737  6.0*15 5*100 ET38  57.1 S",
                            Price = 3370, RetailPrice = 4700,  InQuantity = 4, ImagePath ="/Files/b012.jpg"
                        },
                        new Product {
                            Category = "Диски", Name = " 14 Trebl 53A49A P 5.5*14 4*100 ET49 56.6 BK",
                            Price = 1370, RetailPrice = 2150, InQuantity = 4, ImagePath ="/Files/b012.jpg"
                        },
                        new Product {
                            Category = "Аккумуляторы", Name = "Аккумулятор AKOM-Евро 6CT-75-EFB о.п.  увелич. мощность",
                            Price = 6100, RetailPrice = 7000, InQuantity = 1, ImagePath = "/Files/catalog_179.jpg"
                        },
                        new Product {
                            Category = "Аккумуляторы", Name = "Аккумулятор MAXXIS IES  65R-620   56514 пр",
                            Price = 5421, RetailPrice = 6000, InQuantity = 4, ImagePath = "/Files/catalog_179.jpg"
                        },
                        new Product {
                            Category = "Аккумуляторы", Name = "Аккумулятор FB SUPER NOVA 65 75D23R",
                            Price = 7570, RetailPrice = 8000,InQuantity = 1, ImagePath = "/Files/catalog_179.jpg"
                        },
                        new Product {
                            Category = "Аккумуляторы", Name = "Аккумулятор G&YU 90D26R",
                            Price = 7550, RetailPrice = 8500, InQuantity = 2, ImagePath = "/Files/catalog_179.jpg"
                        },
                        new Product {
                            Category = "Аккумуляторы", Name = "Аккумулятор MAXXIS JIS  45 (60B24LS)-430 обр",
                            Price = 3250, RetailPrice = 4310, InQuantity = 21, ImagePath = "/Files/catalog_179.jpg"
                        },
                        new Product {
                            Category = "Аккумуляторы", Name = "Аккумулятор MAXXIS JIS  45 (60B24R)-430 узк пр",
                            Price = 3250, RetailPrice = 4050,InQuantity = 11, ImagePath = "/Files/catalog_179.jpg"
                        },
                         new Product {
                            Category = "Аккумуляторы", Name = "Аккумулятор MAXXIS sss  45 (60B24R)-430 узк пр",
                            Price = 3100, RetailPrice = 4100,InQuantity = 3, ImagePath = "/Files/catalog_179.jpg"
                        },
                          new Product {
                            Category = "Аккумуляторы", Name = "Аккумулятор MAXXIS rrrr  45 (60B24R)-430 узк пр",
                            Price = 3200, RetailPrice = 4200,InQuantity = 1, ImagePath = "/Files/catalog_179.jpg"
                        },
                        new Product{
                            Category ="Автошины", Name =" 225/65r17 Nitto летняя",
                            Price = 6500, RetailPrice = 7800, InQuantity = 13, ImagePath="/Files/Nexen ru1.jpg"
                        }

            });
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
