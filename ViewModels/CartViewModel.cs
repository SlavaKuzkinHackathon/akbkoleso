using System;
using System.Collections.Generic;
using System.Linq;

namespace akbkoleso.ViewModels
{
    public class CartViewModel
    {
        public Guid Id { get; set; }
        public List<CartItemViewModel> Items { get; set; } = new List<CartItemViewModel>();

        public decimal FullPrice => Items.Sum(x => x.RetailPrice);
        public int AllAmount => Items.Sum(x => x.Amount);

    }
}
