
using RestaurantSystem.Controller.HandlesButtonsEffect;
using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Models;
using RestaurantSystem.Models.AdditionalForms;
using RestaurantSystem.Models.CategoriesModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RestaurantSystem
{
    public partial class MainForm : Form
    {

        UserControlNavigation navigationController;
        public List<DishesModels> listDishes = new List<DishesModels> ();
        ListButtonEffect navigationButtons;

        public MainForm()
        {
            
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();

        }

        private void InitializeNavigationButtons()
        {
            Color btnDefBackColor = Color.Transparent;
            Color btnNewBackColor = Color.FromArgb(36, 35, 35);
            Color btnDefForeColor = Color.FromArgb(123, 122, 122);
            Color btnNewForeColor = Color.White;

            List<Button> listButtons = new List<Button>() {  BTNFoodsAndDrinks, BTNCustomersOrders, BTNProdManagement };
            List<Image> defImages = new List<Image>() { null };
            List<Image> newImages = new List<Image> { null };

            navigationButtons = new ListButtonEffect(newImages, defImages, listButtons, btnDefForeColor, btnDefBackColor, btnNewForeColor, btnNewBackColor);

            foreach (Button myButton in listButtons)
            {
                
                navigationButtons.BTNSelectedColor(BTNFoodsAndDrinks);
                myButton.FlatStyle = FlatStyle.Flat;
                myButton.BackColor = Color.Black;
                myButton.FlatAppearance.BorderColor = Color.Black;
                myButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 35, 35);
                myButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(123, 122, 122);
                myButton.FlatAppearance.BorderSize = 1;
            }
        }

        // Initialize sidebar navigations
        private void InitializeNavigationControl()
        {
            // List of all userControls
            List<UserControl> userControlsList = new List<UserControl>()
            {
                 new FoodAndDrinksModel(), new CustomerOrdersModel(),  new ProductManagementModel() 
            };

            navigationController = new UserControlNavigation(userControlsList, Panel_Body);
            navigationController.Display(0);

        }


        private async void RefreshCustomerOrdersPanel()
        {
            await Task.Delay(100);
            List<UserControl> userControlsList = new List<UserControl>()
            {
                 new FoodAndDrinksModel(), new CustomerOrdersModel(), new ProductManagementModel()
            };

            navigationController = new UserControlNavigation(userControlsList, Panel_Body);
            navigationController.Display(1);
        }

        private async void RefreshFoodPanel()
        {
            await Task.Delay(100);
            List<UserControl> userControlsList = new List<UserControl>()
            {
                 new FoodAndDrinksModel(), new CustomerOrdersModel(),  new ProductManagementModel()
            };

            navigationController = new UserControlNavigation(userControlsList, Panel_Body);
            navigationController.Display(0);
        }

        private void BTNFoodsAndDrinks_Click(object sender, EventArgs e)
        {
            Panel_Body.Controls.Clear();
            RefreshFoodPanel();
            navigationController.Display(0);
            navigationButtons.BTNSelectedColor(BTNFoodsAndDrinks);
        }

        private void BTNCustomersOrders_Click(object sender, EventArgs e)
        {
            Panel_Body.Controls.Clear();
            RefreshCustomerOrdersPanel();
            navigationController.Display(1);
            navigationButtons.BTNSelectedColor(BTNCustomersOrders);
        }


        public void BTNSettings_Click(object sender, EventArgs e)
        {
            navigationController.Display(2);
            navigationButtons.BTNSelectedColor(BTNProdManagement);
 
        }

    }
}
