using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace akbkoleso.Models.Admin.Catalog
{
    public class Catalog_tires_wheels
    {
        public long Id { get; set; }
        public string Vendor { get; set; }
        public string Car { get; set; }
        public string Year { get; set; }
        public string Modification { get; set; }
        public string Pcd { get; set; }
        public string Diametr { get; set; }
        public string Gaika { get; set; }
        public string Zavod_shini { get; set; }
        public string Zamen_shini { get; set; }
        public string Tuning_shini { get; set; }
        public string Zavod_diskov { get; set; }
        public string Zamen_diskov { get; set; }
        public string Tuning_diski { get; set; }

        internal static Catalog_tires_wheels FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

    }
}
