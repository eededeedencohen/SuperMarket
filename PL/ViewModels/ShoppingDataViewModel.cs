using DAL;
using System.Collections.Generic;
using System.Linq;

namespace PL.ViewModels
{
    public class ShoppingDataViewModel : ViewModel
    {
        public List<Order> orders { get; set; }

        public ShoppingDataViewModel()
        {
            orders = new List<Order>();
            SuperMarketEntities db = new SuperMarketEntities();
            orders = db.Orders.ToList();
        }

    }
}
