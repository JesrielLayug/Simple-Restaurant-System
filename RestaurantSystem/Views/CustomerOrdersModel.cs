using RestaurantSystem.Controller;
using RestaurantSystem.Controller.CustomEvents;
using RestaurantSystem.Controller.HandlesButtonsEffect;
using RestaurantSystem.Model;
using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Views.CustomComponents.OrderComponent;
using RestaurantSystem.Views.CustomerOrdersViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace RestaurantSystem.Models
{
    public partial class CustomerOrdersModel : UserControl
    {
        private string connectionString = @"Data Source=.;Initial Catalog=JRestaurantSystem;Integrated Security=True";
        private PurchaseOrderDbContext purchaseOrderDbContext;
        private string status;
        private string date;

        private BaseSpecificationPanel basePanel;
        private DishSpecificationPanel dishSpecificationPanel;
        private UserControlNavigation ServiceOptionController;
        private ListButtonEffect ServiceOptionButton;

        public CustomerOrdersModel()
        {
            InitializeComponent();
            InitializeServiceOptionControl();
            InitializeServiceOptionButtons();

            ListOrderPanelClick.OrderPanelClick += ListOrderPanelClick_OrderPanelClick;
            ListOrderPanelClick.OrderPanelNotClick += ListOrderPanelClick_OrderPanelNotClick;
        }

        private void ListOrderPanelClick_OrderPanelNotClick(object sender, OrderPanelClickedEventArgs e)
        {
            LoadsOrderClick();
        }

        private void ListOrderPanelClick_OrderPanelClick(object sender, OrderPanelClickedEventArgs e)
        {
            LoadsOrderClick();
        }

        private async Task LoadsOrderClick()
        {
            panelBaseOfBase.Controls.Clear();

            purchaseOrderDbContext = new PurchaseOrderDbContext(connectionString);

            List<PurchaseOrderModel> ListPurchaseOrder = ListOrderPanelClick.GetOrder();
            if(ListPurchaseOrder.Count > 0)
            {
                panelBaseOfBase.Controls.Remove(panelNoOrder);
                foreach (PurchaseOrderModel purchase in ListPurchaseOrder)
                {
                    basePanel = new BaseSpecificationPanel(purchase.OrderNumber);
                    List<OrderObjectModel> listOfOrder = await purchaseOrderDbContext.RetrieveOrderModelAsync(purchase.OrderNumber);
                    foreach (OrderObjectModel item in listOfOrder)
                    {
                        dishSpecificationPanel = new DishSpecificationPanel(item);
                        basePanel.baseLayoutPanel.Controls.Add(dishSpecificationPanel);
                    }
                    basePanel.buttonCancel.Click += async (s, e) =>
                    {
                        string status = "CANCEL";
                        purchaseOrderDbContext = new PurchaseOrderDbContext(connectionString);
                        await purchaseOrderDbContext.UpdateOrderStatus(status, purchase.OrderNumber);
                        ListOrderPanelClick.RemoveOrder(purchase);
                        LoadsOrderClick();
                    };

                    basePanel.buttonComplete.Click += async (se, ev) =>
                    {
                        string status = "COMPLETE";
                        purchaseOrderDbContext = new PurchaseOrderDbContext(connectionString);
                        await purchaseOrderDbContext.UpdateOrderStatus(status, purchase.OrderNumber);
                        ListOrderPanelClick.RemoveOrder(purchase);
                        LoadsOrderClick();
                    };
                }
                panelBaseOfBase.Controls.Add(basePanel);
            }
            else
            {
                panelBaseOfBase.Controls.Add(panelNoOrder);
            }

        }



        private void InitializeServiceOptionButtons()
        {
            // Set the default color of the button
            Color defaultBackColor = Color.White;
            Color defaultForeColor = Color.Black;

            // Set the selected color of the button
            Color selectedBackColor = Color.Black;
            Color selectedForeColor = Color.White;

            List<Button> serviceOptionButton = new List<Button>()
            {
                buttonDineIn, buttonTakeOut, buttonDelivery
            };

            ServiceOptionButton = new ListButtonEffect(null, null, serviceOptionButton, defaultForeColor, defaultBackColor, selectedForeColor, selectedBackColor);
            ServiceOptionButton.BTNSelectedColor(buttonDineIn);

        }

        private void InitializeServiceOptionControl()
        {
            List<UserControl> serviceOptionControl = new List<UserControl>()
            {
                new DineInModel(), new TakeOutModel(), new DeliveryModel(),
            };
            ServiceOptionController = new UserControlNavigation(serviceOptionControl, panelBaseForOrder);
            ServiceOptionController.Display(0);
        }

        private void buttonDineIn_Click(object sender, EventArgs e)
        {
            ServiceOptionController.Display(0);
            ServiceOptionButton.BTNSelectedColor(buttonDineIn);
        }


        private void buttonTakeOut_Click(object sender, EventArgs e)
        {
            ServiceOptionController.Display(1);
            ServiceOptionButton.BTNSelectedColor(buttonTakeOut);
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            ServiceOptionController.Display(2);
            ServiceOptionButton.BTNSelectedColor(buttonDelivery);
        }
    }
}
