using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Model.ClassProperties
{
    public class OrderObjectModel
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public string OrderNote { get; set; }
    }
}
