using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Model.ClassProperties
{
    public class PurchaseOrderModel
    {
        public string OrderNumber { get; set; }
        public int DishId { get; set; }
        public int Quantity { get; set; }
        public string OrderRequest { get; set; }
        public string ServiceOption { get; set; }
        public decimal TotalPayment { get; set; }
        public decimal Cash { get; set; }
        public decimal Change { get; set; }
        public decimal Discount { get; set; }
        public string Status { get; set; }
    }
}
