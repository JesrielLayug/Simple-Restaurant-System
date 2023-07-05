using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Model.ClassProperties
{
    public class DishesModels
    {
        public int DishId { get; set; }
        public string DishCategory { get; set; }
        public string DishName { get; set; }
        public byte[] DishImage { get; set; }
        public decimal DishPrice { get; set; }
        public string DishDescription { get; set; }
    }
}
