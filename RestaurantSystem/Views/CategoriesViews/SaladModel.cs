using RestaurantSystem.Controller;
using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Model;
using RestaurantSystem.Views.CustomComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystem.Controller.HandlesAllDishesDisplays;

namespace RestaurantSystem.Models.CategoriesModels
{
    public partial class SaladModel : UserControl
    {
        string connectionString = @"Data Source=.;Initial Catalog=JRestaurantSystem;Integrated Security=True";
        FlowLayoutPanel layoutPanel;
        DisplayDishToSaladModel dishDisplays;
        DishDbContext dbContext;
        DishesModels dish;
        LG_NoDishDisplay noDishPanel;

        public SaladModel()
        {
            InitializeComponent();
            InitializePanelComponents();
        }

        private async void InitializePanelComponents()
        {
            dbContext = new DishDbContext(connectionString);
            dish = new DishesModels();
            List<DishesModels> dishDishes = await dbContext.RetrieveListSaladDish(dish);
            if (dishDishes.Count < 1)
            {
                noDishPanel = new LG_NoDishDisplay();
                panel.Controls.Add(noDishPanel);
            }
            else
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
                dishDisplays = new DisplayDishToSaladModel(layoutPanel, dish, dbContext, connectionString, panel);
                await dishDisplays.RefreshAllDish();
            }
        }
        
    }
}
