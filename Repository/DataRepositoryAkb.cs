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
    public class DataRepositoryAkb : IRepositoryAkb
    {
        private akbkolesoCatalogContext context;
        public DataRepositoryAkb(akbkolesoCatalogContext ctx)
        {
            context = ctx;
        }

        public Podbor_akb GetPodbor_akb(long id)
        {
            return context.Podbor_akbs.Find(id);
        }

        public IEnumerable<Podbor_akb> GetAllPodbor_akbs()
        {
            return context.Podbor_akbs;
        }

        public IEnumerable<Podbor_akb> GetFilteredPodbor_akbs(string vendor = null, string car = null, string modification = null)
        {
            IQueryable<Podbor_akb> data = context.Podbor_akbs;

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
            if (modification != null)
            {
                data = data.Where(p => p.Modification == modification);
            }
            return data;
        }

        public PagedList<Podbor_akb> GetAllPodbor_akbs(QueryOptions options)
        {
            return new PagedList<Podbor_akb>(context.Podbor_akbs, options);
        }

        public void CreatePodbor_akb(Podbor_akb newPodbor_akb)
        {
            newPodbor_akb.Id = 0;
            context.Podbor_akbs.Add(newPodbor_akb);
            context.SaveChanges();
        }

        public void GeneratePodbor_akb(Podbor_akb newPodbor_akb)
        {
            newPodbor_akb.Id = 0;
            context.Podbor_akbs.Add(newPodbor_akb);
            context.SaveChanges();
        }

        public void UpdatePodbor_akb(Podbor_akb changedPodbor_akb, Podbor_akb originalPodbor_akb = null)
        {
            if (originalPodbor_akb == null)
            {
                originalPodbor_akb = context.Podbor_akbs.Find(changedPodbor_akb.Id);
            }
            else
            {
                context.Podbor_akbs.Attach(originalPodbor_akb);
            }
            originalPodbor_akb.Vendor = changedPodbor_akb.Vendor;
            originalPodbor_akb.Car = changedPodbor_akb.Car;
            originalPodbor_akb.Modification = changedPodbor_akb.Modification;
            originalPodbor_akb.Date_start = changedPodbor_akb.Date_start;
            originalPodbor_akb.Date_end = changedPodbor_akb.Date_end;
            originalPodbor_akb.Mochnost = changedPodbor_akb.Mochnost;
            originalPodbor_akb.Emkost_ot = changedPodbor_akb.Emkost_ot;
            originalPodbor_akb.Emkost_do = changedPodbor_akb.Emkost_do;
            originalPodbor_akb.Polarnost = changedPodbor_akb.Polarnost;
            originalPodbor_akb.Dlina = changedPodbor_akb.Dlina;
            originalPodbor_akb.Shirina = changedPodbor_akb.Shirina;
            originalPodbor_akb.Visota = changedPodbor_akb.Visota;
            originalPodbor_akb.Diametr_klem = changedPodbor_akb.Diametr_klem;
            originalPodbor_akb.Tok_xol_prok = changedPodbor_akb.Tok_xol_prok;

            context.SaveChanges();
        }

        public void DeletePodbor_akb(long id)
        {
            context.Podbor_akbs.Remove(new Podbor_akb { Id = id });
            context.SaveChanges();
        }
    }
}
