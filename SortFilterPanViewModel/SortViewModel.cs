using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace akbkoleso.SortFilterPanViewModel
{
    public class SortViewModel
    {
        public SortState RetailPriceSort { get; set; } // значение для сортировки по стоимости
        public SortState InQuantitySort { get; set; }    // значение для сортировки по количеству
        public SortState Current { get; set; }     // значение свойства, выбранного для сортировки
       // public bool Up { get; set; }  // Сортировка по возрастанию или убыванию

        public SortViewModel(SortState sortOrder)
        {
            RetailPriceSort = sortOrder == SortState.RetailPriceAsc ? SortState.RetailPriceDesc : SortState.RetailPriceAsc;
            InQuantitySort = sortOrder == SortState.InQuantityAsc ? SortState.RetailPriceDesc : SortState.InQuantityAsc;
            Current = sortOrder;
        }
        
    }
}
