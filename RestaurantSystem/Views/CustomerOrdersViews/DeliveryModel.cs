using RestaurantSystem.Controller.CustomEvents;
using RestaurantSystem.Model;
using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Views.CustomComponents.OrderComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Views.CustomerOrdersViews
{
    public partial class DeliveryModel : UserControl
    {

        private string connectionString = @"Data Source=.;Initial Catalog=JRestaurantSystem;Integrated Security=True";
        private PurchaseOrderDbContext dbContext;
                private DishDbContext dishDbContext;
        private FlowLayoutPanel flowLayoutPanel;
        private PendingOrderPanel pendingOrderPanel;
        public DeliveryModel()
        {
            InitializeComponent();
            InitializeFlowLayoutPanel();

            ListOrderPanelClick.OrderPanelNotClick += ListOrderPanelClick_OrderPanelNotClick;
        }

        private async void ListOrderPanelClick_OrderPanelNotClick(object sender, OrderPanelClickedEventArgs e)
        {
            LoadsAllOrders();
        }

        private async void InitializeFlowLayoutPanel()
        {
            flowLayoutPanel = new FlowLayoutPanel()
            {
                Padding = new Padding(0, 0, 0, 0),
                AutoSize = false,
                Size = new Size(911, 698),
                BackColor = Color.WhiteSmoke,
                AutoScroll = true,
                WrapContents = true,
                Location = new Point(0, 0),
            };
            LoadsAllOrders();
        }

        private async Task LoadsAllOrders()
        {
            flowLayoutPanel.Controls.Clear();
            dbContext = new PurchaseOrderDbContext(connectionString);
            string dateToday = DateTime.Now.ToString("yyyyMMdd");
            string status = "ON_PROCESS";

            List<PurchaseOrderModel> ListOrderNumber = await dbContext.RetrieveOrderNumberAsync("DELIVERY", dateToday, status);

            if (ListOrderNumber.Count > 0)
            {
                Controls.Remove(panelNoOrderBase);
                foreach (PurchaseOrderModel order in ListOrderNumber)
                {
                    dbContext = new PurchaseOrderDbContext(connectionString);
                    List<PurchaseOrderModel> ListPurchaseOrders = await dbContext.RetrieveOrderDataAsync(order.OrderNumber);

                    List<int> ListDishId = new List<int>();

                    foreach (PurchaseOrderModel model in ListPurchaseOrders)
                    {
                        ListDishId.Add(model.DishId);
                    }

                    if (ListOrderNumber.IndexOf(order) % 2 == 0)
                    {
                        pendingOrderPanel = new PendingOrderPanel(order, ListDishId.Count());
                        flowLayoutPanel.Controls.Add(pendingOrderPanel);
                    }
                    else
                    {
                        pendingOrderPanel = new PendingOrderPanel(order, ListDishId.Count());
                        pendingOrderPanel.BackColor = Color.WhiteSmoke;
                        flowLayoutPanel.Controls.Add(pendingOrderPanel);
                    }

                }
                Controls.Add(flowLayoutPanel);
            }
            else
            {
                Controls.Remove(flowLayoutPanel);
                Controls.Add(panelNoOrderBase);
            }
        }

        private int GetOrderNumberValue(string orderNumber)
        {
            // Extract the numeric part of the order number
            string numericPart = orderNumber.Substring(orderNumber.IndexOf('-') + 1);
            int orderNumberValue;

            // Try parsing the numeric part to an integer
            if (int.TryParse(numericPart, out orderNumberValue))
            {
                return orderNumberValue;
            }

            // Return a default value if parsing fails
            return 0;
        }

    }
}
