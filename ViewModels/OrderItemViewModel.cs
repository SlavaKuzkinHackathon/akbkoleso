using System;

namespace akbkoleso.ViewModels
{
    public class OrderItemViewModel
    {
        public Guid Id { get; set; }
        public ProductViewModel Product { get; set; }

        public int Amount { get; set; }

        public decimal RetailPrice => Amount * Product.RetailPrice;

    }
}
