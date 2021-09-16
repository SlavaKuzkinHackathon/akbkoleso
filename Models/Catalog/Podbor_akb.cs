using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace akbkoleso.Models.Admin.Catalog
{
    public class Podbor_akb
    {
        public long Id { get; set; }
        public string Vendor { get; set; }
        public string Car { get; set; }
        public string Modification { get; set; }
        public string Date_start { get; set; }
        public string Date_end { get; set; }
        public string Mochnost { get; set; }
        public string Emkost_ot { get; set; }
        public string Emkost_do { get; set; }
        public string Polarnost { get; set; }
        public string Dlina { get; set; }
        public string Shirina { get; set; }
        public string Visota { get; set; }
        public string Diametr_klem { get; set; }
        public string Tok_xol_prok { get; set; }

        internal static Podbor_akb FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
