using akbkoleso.ViewModels;
using System.Collections.Generic;

namespace akbkoleso.ViewModels
{
    public class UserOrdersViewModel
    {
        public List<OrderViewModel> Orders { get; set; }
        public UserViewModel User { get; set; }
    }
}
