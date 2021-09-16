using akbkoleso.Data;
using akbkoleso.Models.Admin.Catalog;
using akbkoleso.Pages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace akbkoleso.Repository
{
    public class DataRepository_t_w : IRepository_t_w
    {
        private akbkolesoCatalogContext context;
        public DataRepository_t_w(akbkolesoCatalogContext ctx)
        {
            context = ctx;
        }

        public Catalog_tires_wheels GetCatalog_tires_wheels(long id)
        {
            return context.Catalog_tires_wheelss.Find(id);
        }

        public IEnumerable<Catalog_tires_wheels> GetAllCatalog_tires_wheelss()
        {
            return context.Catalog_tires_wheelss;
        }

        public IEnumerable<Catalog_tires_wheels> GetFilteredCatalog_tires_wheelss(string vendor = null, string car = null, string year = null, string modification = null)
        {
            IQueryable<Catalog_tires_wheels> data = context.Catalog_tires_wheelss;

            if (vendor == null)
            {
                data = data.Where(p => p.Vendor == null);
            }

            if (vendor != null)
               {
                data = data.Where(p => p.Vendor == vendor);
                }
            if (car != null)
                {
                data = data.Where(p => p.Car == car);
            }
            if (year != null)
            {
                data = data.Where(p => p.Year == year);
            }
            if (modification != null)
            {
                data = data.Where(p => p.Modification == modification);
            }
            return data;
        }
        
        public PagedList<Catalog_tires_wheels> GetAllCatalog_tires_wheelss(QueryOptions options)
        {
            return new PagedList<Catalog_tires_wheels>(context.Catalog_tires_wheelss, options);
        }

        public void CreateCatalog_tires_wheels(Catalog_tires_wheels newCatalog_tires_wheels)
        {
            newCatalog_tires_wheels.Id = 0;
            context.Catalog_tires_wheelss.Add(newCatalog_tires_wheels);
            context.SaveChanges();
        }

        public void GenerateCatalog_tires_wheels(Catalog_tires_wheels newCatalog_tires_wheels)
        {
            newCatalog_tires_wheels.Id = 0;
            context.Catalog_tires_wheelss.Add(newCatalog_tires_wheels);
            context.SaveChanges();
        }

        public void UpdateCatalog_tires_wheels(Catalog_tires_wheels changedCatalog_tires_wheels, Catalog_tires_wheels originalCatalog_tires_wheels = null)
        {
            if (originalCatalog_tires_wheels == null)
            {
                originalCatalog_tires_wheels = context.Catalog_tires_wheelss.Find(changedCatalog_tires_wheels.Id);
            }
            else
            {
                context.Catalog_tires_wheelss.Attach(originalCatalog_tires_wheels);
            }
            originalCatalog_tires_wheels.Vendor = changedCatalog_tires_wheels.Vendor;
            originalCatalog_tires_wheels.Car = changedCatalog_tires_wheels.Car;
            originalCatalog_tires_wheels.Year = changedCatalog_tires_wheels.Year;
            originalCatalog_tires_wheels.Modification = changedCatalog_tires_wheels.Modification;
            originalCatalog_tires_wheels.Pcd = changedCatalog_tires_wheels.Pcd;
            originalCatalog_tires_wheels.Diametr = changedCatalog_tires_wheels.Diametr;
            originalCatalog_tires_wheels.Gaika = changedCatalog_tires_wheels.Gaika;
            originalCatalog_tires_wheels.Zavod_shini = changedCatalog_tires_wheels.Zavod_shini;
            originalCatalog_tires_wheels.Zavod_diskov = changedCatalog_tires_wheels.Zavod_diskov;
            originalCatalog_tires_wheels.Tuning_shini = changedCatalog_tires_wheels.Tuning_shini;
            originalCatalog_tires_wheels.Zavod_diskov = changedCatalog_tires_wheels.Zavod_diskov;
            originalCatalog_tires_wheels.Zamen_diskov = changedCatalog_tires_wheels.Zamen_diskov;
            originalCatalog_tires_wheels.Tuning_diski = changedCatalog_tires_wheels.Tuning_diski;

            context.SaveChanges();
        }

        public void DeleteCatalog_tires_wheels(long id)
        {
            context.Catalog_tires_wheelss.Remove(new Catalog_tires_wheels { Id = id });
            context.SaveChanges();
        }
    }
}
