using akbkoleso.Models;
using akbkoleso.SortFilterPanViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace akbkoleso.SortFilterPanViewModel
{
    public class IndexViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public SortViewModel SortViewModel { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        public SearchFilter SearchFilter { get; set; }
    }
}
