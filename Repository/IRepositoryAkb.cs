using akbkoleso.Models.Admin.Catalog;
using akbkoleso.Pages;
using System.Collections.Generic;

namespace akbkoleso.Repository
{
    public interface IRepositoryAkb
    {
        Podbor_akb GetPodbor_akb(long id);

        IEnumerable<Podbor_akb> GetAllPodbor_akbs();

        IEnumerable<Podbor_akb> GetFilteredPodbor_akbs(string vendor = null, string car = null, string modification = null);

        PagedList<Podbor_akb> GetAllPodbor_akbs(QueryOptions options);

        void CreatePodbor_akb(Podbor_akb newPodbor_akb);

        void GeneratePodbor_akb(Podbor_akb newPodbor_akb);

        void UpdatePodbor_akb(Podbor_akb changedPodbor_akb, Podbor_akb originalPodbor_akb = null);

        void DeletePodbor_akb(long id);
    }
}
