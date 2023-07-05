
using RestaurantSystem.Controller;
using RestaurantSystem.Controller.HandlesButtonsEffect;
using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Model;
using RestaurantSystem.Models.AdditionalForms;
using RestaurantSystem.Models.CategoriesModels;
using RestaurantSystem.Views.CustomComponents;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Channels;
using RestaurantSystem.Model.ListObjects;
using RestaurantSystem.Views.CustomComponents.OrderComponent;
using System.Runtime.CompilerServices;
using System.Linq;
using RestaurantSystem.Views.AdditionalForms;
using RestaurantSystem.Controller.PurchaseController;
using System.DirectoryServices;
using RestaurantSystem.Controller.CustomEvents;

namespace RestaurantSystem.Models
{

    public partial class FoodAndDrinksModel : UserControl
    {
        private PurchaseOrderModel _purchaseOrder = new PurchaseOrderModel();
        private PaymentForm paymentForm = new PaymentForm();
        private PurchaseOrderDbContext PO_dbContext;
        private DishesModels dish;

        private List<OrderObjectModel> ListOrders;
        private decimal totalPrice;
        private decimal shippingFee = 0;
        decimal discount;
        decimal discountInPercent;

        private string connectionString = @"Data Source=.;Initial Catalog=JRestaurantSystem;Integrated Security=True";
        private DishDbContext dbContext;
        private DisplayOrderPanel orderPanel;

        private ListButtonEffect categoryButton;
        private BorderStyleButtonDesign serviceOptionButton;
        private UserControlNavigation CategoryNavigation;
        public FlowLayoutPanel orderLayoutPanel;

        private FlowLayoutPanel SearchlayoutPanel;

        private List<string> ListOfDish = new List<string>();

        public FoodAndDrinksModel()
        {
            InitializeComponent();
            InitializeCategoriesControl();
            InitializeCategoriesButton();
            InitializeOrderFlowLayoutPanel();
            InitializeServiceOptionButton();

           // LoadsOrdersInList();

            TBDiscountValue.KeyPress += TBDiscountValue_KeyPress;

            ListOfOrders.OrderAdded += ListOfOrders_OrderAdded;
            ListOfOrders.OrderRemove += ListOfOrders_OrderRemove;
        }


        private void ListOfOrders_OrderRemove(object sender, OrderEventArgs e)
        {
            LoadsOrdersInList();
        }

        private async void ListOfOrders_OrderAdded(object sender, OrderEventArgs e)
        {
            LoadsOrdersInList();
        }

        private async void LoadsOrdersInList()
        {
            ListOrders = ListOfOrders.GetOrder();

            if (ListOrders.Count == 0)
            {
                panelBaseOrder.Controls.Remove(orderLayoutPanel);
                panelBaseOrder.Controls.Add(panelNoOrder);
            }
            else
            {
                orderLayoutPanel.Controls.Clear();
                SubTotalComputaion(shippingFee, discountInPercent);

                foreach (OrderObjectModel item in ListOrders)
                {
                    orderPanel = new DisplayOrderPanel(item);
                    orderPanel.DishRemove.Click += DishRemove_Click;

                    orderLayoutPanel.Controls.Add(orderPanel);
                }
                panelBaseOrder.Controls.Remove(panelNoOrder);
                panelBaseOrder.Controls.Add(orderLayoutPanel);
            }
            


        }

        private void DishRemove_Click(object sender, EventArgs e)
        {
            SubTotalComputaion(shippingFee, discountInPercent);
        }

        private async void InitializeOrderFlowLayoutPanel()
        {
            orderLayoutPanel = new FlowLayoutPanel()
            {
                Padding = new Padding(0, 5, 0, 10),
                AutoSize = false,
                Size = new Size(319, 440),
                BackColor = Color.Transparent,
                AutoScroll = true,
                WrapContents = true,
                Location = new Point(9, 10),
            };
        }


        private void InitializeCategoriesButton()
        {
            // Set the default color of the button
            Color defaultBackColor = Color.FromArgb(240, 240, 240);
            Color defaultForeColor = Color.Black;

            // Set the selected color of the button
            Color selectedBackColor = Color.Black;
            Color selectedForeColor = Color.White;

            // categories button's new images
            Image All = null;
            Image newSoupImage = Image.FromFile(@"C:\\Users\\LAYUG\\Desktop\\Programming\\RestaurantSystem\\RestaurantSystem\\Resources\\soupWhite.png");
            Image newSaladImage = Image.FromFile(@"C:\Users\LAYUG\Desktop\Programming\RestaurantSystem\RestaurantSystem\Resources\saladwhite.png");
            Image newPastaImage = Image.FromFile(@"C:\Users\LAYUG\Desktop\Programming\RestaurantSystem\RestaurantSystem\Resources\pastawhite.png");
            Image newBakeryProductImage = Image.FromFile(@"C:\Users\LAYUG\Desktop\Programming\RestaurantSystem\RestaurantSystem\Resources\breadwhite.png");
            Image newDrinksImage = Image.FromFile(@"C:\Users\LAYUG\Desktop\Programming\RestaurantSystem\RestaurantSystem\Resources\drinkwhite.png");

            // categories button's current images
            Image currentAll = null;
            Image currentSoupImage = Image.FromFile("C:\\Users\\LAYUG\\Desktop\\Programming\\RestaurantSystem\\RestaurantSystem\\Resources\\Soup.png");
            Image currentSaladImage = Image.FromFile("C:\\Users\\LAYUG\\Desktop\\Programming\\RestaurantSystem\\RestaurantSystem\\Resources\\salads.png");
            Image currentPastaImage = Image.FromFile("C:\\Users\\LAYUG\\Desktop\\Programming\\RestaurantSystem\\RestaurantSystem\\Resources\\Pasta.png");
            Image currentBakeryProductImage = Image.FromFile("C:\\Users\\LAYUG\\Desktop\\Programming\\RestaurantSystem\\RestaurantSystem\\Resources\\bread.png");
            Image currentDrinkImage = Image.FromFile("C:\\Users\\LAYUG\\Desktop\\Programming\\RestaurantSystem\\RestaurantSystem\\Resources\\Drink1.png");

            //  the list of new images of button
            List<Image> listNewImagesButton = new List<Image>()
            {
                All, newSoupImage, newSaladImage, newPastaImage, newBakeryProductImage, newDrinksImage,
            };

            // The list of current Images
            List<Image> listCurrentImagesButton = new List<Image>() 
            { 
                currentAll, currentSoupImage, currentSaladImage, currentPastaImage, currentBakeryProductImage, currentDrinkImage
            };

            List<Button> catButtons = new List<Button>()
            {
                buttonAll, buttonSoup, buttonSalad, buttonPasta, buttonBakeryProducts, buttonDrinks
            };
            categoryButton = new ListButtonEffect(listNewImagesButton, listCurrentImagesButton ,catButtons, defaultForeColor, defaultBackColor, selectedForeColor, selectedBackColor);
            categoryButton.BTNSelectedColor(buttonAll);

        }

        private void InitializeServiceOptionButton()
        {
            Color DefForeColor = Color.FromArgb(159, 159, 159);
            Color DefBorderColor = Color.Black;
            Color NewForeColor = Color.White;
            Color NewBorderColor = Color.White;
            Color NewBackColor = Color.Black;

            List<Button> buttonList = new List<Button>()
            {
                buttonDineIn, buttonTakeOut, buttonDelivery
            };
            
            serviceOptionButton = new BorderStyleButtonDesign(null, null, buttonList, DefForeColor, DefBorderColor, NewForeColor, NewBorderColor, NewBackColor);
        }

        public void InitializeCategoriesControl()
        {
            List<UserControl> categoryUserControl = new List<UserControl>()
            {
                new AllModel(), new SoupModel(), new SaladModel(), new PastaModel(), new BakeryProductModel(), new DrinksModel()
            };

            CategoryNavigation = new UserControlNavigation(categoryUserControl, panelBaseCategoryBody);
            CategoryNavigation.Display(0);
        }

        public async void buttonAll_Click(object sender, EventArgs e)
        {
            CategoryNavigation.Display(0);
            categoryButton.BTNSelectedColor(buttonAll);

        }

        protected void buttonSoup_Click(object sender, EventArgs e)
        {
            CategoryNavigation.Display(1);
            categoryButton.BTNSelectedColor(buttonSoup);
        }

        public void buttonSalad_Click(object sender, EventArgs e)
        {
            CategoryNavigation.Display(2);
            categoryButton.BTNSelectedColor(buttonSalad);
        }

        public void buttonPasta_Click(object sender, EventArgs e)
        {
            CategoryNavigation.Display(3);
            categoryButton.BTNSelectedColor(buttonPasta);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            CategoryNavigation.Display(4);
            categoryButton.BTNSelectedColor(buttonBakeryProducts);
        }

        public void button2_Click(object sender, EventArgs e)
        {
            CategoryNavigation.Display(5);
            categoryButton.BTNSelectedColor(buttonDrinks);
        }


        private void TBDiscountValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void SubTotalComputaion(decimal shippingFee, decimal discount)
        {
            labelTotalVal.Text = "";
            ListOrders = ListOfOrders.GetOrder();

            totalPrice = ListOrders.Sum(o => o.Price * o.Quantity)  + shippingFee - discount;
            labelTotalVal.Text = totalPrice.ToString("00.00");
        }

        private void TBDiscountValue_TextChanged(object sender, EventArgs e)
        {
            if (TBDiscountValue.Text == string.Empty)
            {
                discount = 0;
                SubTotalComputaion(shippingFee, discountInPercent);
            }
            else
            {
                discount = decimal.Parse(TBDiscountValue.Text) / 100;
                discountInPercent = totalPrice * discount;

                labelDiscountVal.Text = $"- " + discountInPercent.ToString("00.00");

                decimal totalPriceWithDiscount = totalPrice - discountInPercent;
                labelTotalVal.Text = totalPriceWithDiscount.ToString("00.00");
            }
        }

        private void buttonDineIn_Click(object sender, EventArgs e)
        {
            serviceOptionButton.BTNSelectedColor(buttonDineIn);
            shippingFee = 0;
            SubTotalComputaion(shippingFee, discountInPercent);
            labelFee.Text = $" " + shippingFee.ToString("00.00");

            buttonDineIn.Name = "DINE_IN";
            _purchaseOrder.ServiceOption = buttonDineIn.Name;
        }

        private void buttonTakeOut_Click(object sender, EventArgs e)
        {
            serviceOptionButton.BTNSelectedColor(buttonTakeOut);
            shippingFee = 0;
            SubTotalComputaion(shippingFee, discountInPercent) ;
            labelFee.Text = $" " + shippingFee.ToString("00.00");

            buttonTakeOut.Name = "TAKE_OUT";
            _purchaseOrder.ServiceOption= buttonTakeOut.Name;
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            serviceOptionButton.BTNSelectedColor(buttonDelivery);
            shippingFee = 50;
            SubTotalComputaion(shippingFee, discountInPercent) ;
            labelFee.Text = $"+ " + shippingFee.ToString("00.00");

            buttonDelivery.Name = "DELIVERY";
            _purchaseOrder.ServiceOption = buttonDelivery.Name;
        }

        private async void BTNPaynow_Click(object sender, EventArgs e)
        {
            ListOrders = ListOfOrders.GetOrder();
            if(ListOrders.Count == 0)
            {
                MessageBox.Show("You don't have any orders yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _purchaseOrder.TotalPayment = totalPrice;
                _purchaseOrder.Discount = discountInPercent;

                paymentForm.labelTotalVal.Text = labelTotalVal.Text;

                paymentForm.buttonConfirm.Click += async (s, ee) =>
                {
                    decimal change = decimal.Parse(paymentForm.TBCash.Text) - decimal.Parse(paymentForm.labelTotalVal.Text);
                    if (MessageBox.Show($"Change: {change.ToString("00.00")}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        
                        _purchaseOrder.Cash = decimal.Parse(paymentForm.TBCash.Text);
                        _purchaseOrder.Change = change;
                        _purchaseOrder.OrderNumber = await PO_NumberGenerator.GeneratePurchaseNumber();

                        ListOrders = ListOfOrders.GetOrder();
                        foreach(OrderObjectModel item in ListOrders)
                        {
                            _purchaseOrder.DishId = item.DishId;
                            _purchaseOrder.Quantity = item.Quantity;
                            _purchaseOrder.OrderRequest = item.OrderNote;
                            _purchaseOrder.Status = "ON_PROCESS";

                            PO_dbContext = new PurchaseOrderDbContext(connectionString);
                            await PO_dbContext.InsertPurchaseOrderAsync(_purchaseOrder);
                        }

                        ResetForms();
                        paymentForm.TBCash.Clear();

                        paymentForm.Close();
                    }
                };

                paymentForm.ShowDialog();
            }
        }

        private async void ResetForms()
        {
            ListOfOrders.ClearListOrder();
            LoadsOrdersInList();
            TBDiscountValue.Clear();
            discountInPercent = 0;
        }
    }
}
