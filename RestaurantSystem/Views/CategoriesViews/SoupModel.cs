using RestaurantSystem.Controller.HandlesAllDishesDisplays;
using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystem.Views.CustomComponents;
using RestaurantSystem.Model.ListObjects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace RestaurantSystem.Models.CategoriesModels
{
    public partial class SoupModel : UserControl
    {
        private string connectionString = @"Data Source=.;Initial Catalog=JRestaurantSystem;Integrated Security=True";
        private FlowLayoutPanel layoutPanel;
        private DisplayDishToSoupModel dishDisplays;
        private DishDbContext dbContext;
        private DishesModels dish;
        private LG_NoDishDisplay noDishPanel;


        public SoupModel()
        {
            InitializeComponent();
            InitializeFlowLayoutPanelComponents();
            InitializeFlowLayoutPanelAttributes();

        }




        private async void InitializeFlowLayoutPanelAttributes()
        {
            layoutPanel = new FlowLayoutPanel()
            {
                BackColor = Color.White,
                AutoScroll = true,
                WrapContents = true,
                Dock = DockStyle.Fill,
                Padding = new Padding(15, 15, 0, 30),
            };
            Controls.Add(layoutPanel);
        }

        private async void InitializeFlowLayoutPanelComponents()
        {
            dbContext = new DishDbContext(connectionString);
            dish = new DishesModels();
            List<DishesModels> dishDishes = await dbContext.RetrieveListSoupDish(dish);
            if (dishDishes.Count < 1 )
            {
                noDishPanel = new LG_NoDishDisplay();
                panel.Controls.Add(noDishPanel);
            }
            else
            {
                dishDisplays = new DisplayDishToSoupModel(layoutPanel, dish, dbContext, connectionString, panel);
                await dishDisplays.RefreshAllDish();
            }
        }

    }
}
