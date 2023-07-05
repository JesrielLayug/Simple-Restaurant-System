using RestaurantSystem.Model.ClassProperties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Model.ListObjects
{

    public class OrderEventArgs : EventArgs
    {
        public OrderObjectModel OrderObject { get; }

        public OrderEventArgs(OrderObjectModel orderObject)
        {
            OrderObject = orderObject;
        }
    }

    public static class ListOfOrders
    {
        private static List<OrderObjectModel> ListOrderObjectModels = new List<OrderObjectModel>();
        public static event EventHandler<OrderEventArgs> OrderAdded;
        public static event EventHandler<OrderEventArgs> OrderRemove;

        public static void InsertOrder(OrderObjectModel orderObject)
        {
            bool orderExists = ListOrderObjectModels.Any(o => o.DishId == orderObject.DishId);

            if (orderExists)
            {
                MessageBox.Show("The item is already ordered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ListOrderObjectModels.Add(orderObject);
                OnOrderAdded(orderObject);
            }

        }

        public static void RemoveOrder(OrderObjectModel orderObject)
        {
            ListOrderObjectModels.Remove(orderObject);
            OnOrderRemove(orderObject);
        }

        public static List<OrderObjectModel> GetOrder()
        {
            return ListOrderObjectModels;
        }

        public static void OnOrderAdded(OrderObjectModel orderObject)
        {
            OrderAdded?.Invoke(null, new OrderEventArgs(orderObject));
        }

        public static void OnOrderRemove(OrderObjectModel orderObject)
        {
            OrderRemove?.Invoke(null, new OrderEventArgs(orderObject));
        }

        public static void ClearListOrder()
        {
            ListOrderObjectModels.Clear();
        }
    }
}
