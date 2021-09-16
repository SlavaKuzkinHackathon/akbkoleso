using akbkoleso.Models.Admin.Catalog;
using akbkoleso.Pages;
using System.Collections.Generic;

namespace akbkoleso.Repository
{
    public interface IRepository_t_w
    {
        Catalog_tires_wheels GetCatalog_tires_wheels(long id);

        IEnumerable<Catalog_tires_wheels> GetAllCatalog_tires_wheelss();

        IEnumerable<Catalog_tires_wheels> GetFilteredCatalog_tires_wheelss(string vendor = null, string car = null, string year = null, string modification = null);
        
        PagedList<Catalog_tires_wheels> GetAllCatalog_tires_wheelss(QueryOptions options);

        void CreateCatalog_tires_wheels(Catalog_tires_wheels newCatalog_tires_wheels);

        void GenerateCatalog_tires_wheels(Catalog_tires_wheels newCatalog_tires_wheels);

        void UpdateCatalog_tires_wheels(Catalog_tires_wheels changedCatalog_tires_wheels, Catalog_tires_wheels originalCatalog_tires_wheels = null);

        void DeleteCatalog_tires_wheels(long id);

    }
}
