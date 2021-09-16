using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace akbkoleso.SortFilterPanViewModel
{
    public enum SortState
    {
        RetailPriceAsc,    // по розничной стоимости по возрастанию
        RetailPriceDesc,   // по розничной стоимости по убыванию
        InQuantityAsc, // по количеству по возрастанию
        InQuantityDesc,    // по количеству по убыванию
    }
}
