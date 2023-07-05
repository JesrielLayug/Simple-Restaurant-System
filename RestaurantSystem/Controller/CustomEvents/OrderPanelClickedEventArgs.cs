using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Model.ListObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Controller.CustomEvents
{
    public class OrderPanelClickedEventArgs : EventArgs
    {
        public PurchaseOrderModel PurchaseNumber {  get; }
        public OrderPanelClickedEventArgs(PurchaseOrderModel purchaseNumber)
        {
            PurchaseNumber = purchaseNumber;
        }
    }

    public static class ListOrderPanelClick
    {
        private static List<PurchaseOrderModel> ListOrderNumbers = new List<PurchaseOrderModel>();
        public static event EventHandler<OrderPanelClickedEventArgs> OrderPanelClick;
        public static event EventHandler<OrderPanelClickedEventArgs> OrderPanelNotClick;
        private static PurchaseOrderModel existingPurchase;

        public static void PanelClick(PurchaseOrderModel purchase)
        {
            bool orderExist = ListOrderNumbers.Any(PO => PO.OrderNumber == purchase.OrderNumber);
            if (orderExist)
            {
                // Remove the previous item from the list
                ListOrderNumbers.Remove(existingPurchase);
            }

            // Add the new item to the list
            ListOrderNumbers.Add(purchase);

            // Update the existingPurchase reference
            existingPurchase = purchase;

            OrderPanelAdded(purchase);
        }


        public static List<PurchaseOrderModel> GetOrder()
        {
            return ListOrderNumbers;
        }

        public static void OrderPanelAdded(PurchaseOrderModel purchase)
        {
            OrderPanelClick?.Invoke(null, new OrderPanelClickedEventArgs(purchase));
        }

        public static void RemoveOrder(PurchaseOrderModel purchase)
        {
            ListOrderNumbers.Remove(purchase);
            OnOrderRemove(purchase);
        }

        public static void OnOrderRemove(PurchaseOrderModel purchase)
        {
            OrderPanelNotClick?.Invoke(null, new OrderPanelClickedEventArgs(purchase));
        }
    }
}
