using RestaurantSystem.Controller.HandlesAllDishesDisplays;
using RestaurantSystem.Model;
using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Views.CustomComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Models.CategoriesModels
{
    public partial class AllModel : UserControl
    {
        public event EventHandler DishClicked;
        string connectionString = @"Data Source=.;Initial Catalog=JRestaurantSystem;Integrated Security=True";
        DishDbContext dbContext;

        // Models
        DishesModels dish;

        FlowLayoutPanel soupLayoutPanel;
        FlowLayoutPanel saladLayoutPanel;
        FlowLayoutPanel pastaLayoutPanel;
        FlowLayoutPanel bakeryLayoutPanel;
        FlowLayoutPanel drinksLayoutPanel;

        SM_NoDishDisplay noDishPanel;

        // Dishes Objects
        private DisplayDishPanel soupDishPanel;
        private DisplayDishPanel saladDishPanel;
        private DisplayDishPanel pastaDishPanel;
        private DisplayDishPanel bakeryDishPanel;
        private DisplayDishPanel drinksDishPanel;

        public AllModel()
        {
            InitializeComponent();
            InitializeAllFlowLayoutPanels();
            InitializeSoupPanels();
            InitializeSaladPanel();
            InitializePastaPanel();
            InitializeBakeryPanel();
            InitializeDrinksPanel();
        }

        private void InitializeAllFlowLayoutPanels()
        {
            soupLayoutPanel = new FlowLayoutPanel()
            {
                Size = new Size(833, 236),
                AutoScroll = true,
                WrapContents = false,
                Location = new Point(22, 5),
                Padding = new Padding(0, 29, 20, 15),
                BackColor = Color.Transparent,
                Margin = new Padding(10, 5, 3, 3),
                AutoSize = false,
            };

            saladLayoutPanel = new FlowLayoutPanel()
            {
                Size = new Size(833, 236),
                AutoScroll = true,
                WrapContents = false,
                Location = new Point(22, 5),
                Padding = new Padding(0, 29, 20, 15),
                BackColor = Color.Transparent,
                Margin = new Padding(10, 5, 3, 3),
                AutoSize = false,
            };

            bakeryLayoutPanel = new FlowLayoutPanel()
            {
                Size = new Size(833, 236),
                AutoScroll = true,
                WrapContents = false,
                Location = new Point(22, 5),
                Padding = new Padding(0, 29, 20, 15),
                BackColor = Color.Transparent,
                Margin = new Padding(10, 5, 3, 3),
                AutoSize = false,
            };
            pastaLayoutPanel = new FlowLayoutPanel()
            {
                Size = new Size(833, 236),
                AutoScroll = true,
                WrapContents = false,
                Location = new Point(22, 5),
                Padding = new Padding(0, 29, 20, 15),
                BackColor = Color.Transparent,
                Margin = new Padding(10, 5, 3, 3),
                AutoSize = false,
            };

            drinksLayoutPanel = new FlowLayoutPanel()
            {
                Size = new Size(833, 236),
                AutoScroll = true,
                WrapContents = false,
                Location = new Point(22, 5),
                Padding = new Padding(0, 29, 20, 15),
                BackColor = Color.Transparent,
                Margin = new Padding(10, 5, 3, 3),
                AutoSize = false,
            };
        }

        private async void InitializeSoupPanels()
        {
            dbContext = new DishDbContext(connectionString);
            dish = new DishesModels();
            List<DishesModels> soupDishes = await dbContext.RetrieveListSoupDish(dish);
            List<DishesModels> displaySoup = soupDishes.Take(5).ToList();

            if (soupDishes.Count < 1)
            {
                noDishPanel = new SM_NoDishDisplay();
                panelSoup.Controls.Add(noDishPanel);
            }
            else
            {
                soupLayoutPanel.Controls.Clear();

                foreach (DishesModels displayDish in displaySoup)
                {
                    soupDishPanel = new DisplayDishPanel(displayDish);
                    soupLayoutPanel.Controls.Add(soupDishPanel);
                }
                panelSoup.Controls.Add(soupLayoutPanel);
            }
        }

        private async void InitializeSaladPanel()
        {
            dbContext = new DishDbContext(connectionString);
            dish = new DishesModels();
            List<DishesModels> saladDishes = await dbContext.RetrieveListSaladDish(dish);
            List<DishesModels> displaySalad = saladDishes.Take(5).ToList();

            if ( saladDishes.Count < 1 )
            {
                noDishPanel = new SM_NoDishDisplay();
                panelSalad.Controls.Add(noDishPanel);
            }
            else
            {
                saladLayoutPanel.Controls.Clear();
                foreach (DishesModels dish in displaySalad)
                {
                    saladDishPanel = new DisplayDishPanel(dish);
                    saladLayoutPanel.Controls.Add(saladDishPanel);
                }
                panelSalad.Controls.Add(saladLayoutPanel);
            }
        }

        private async void InitializePastaPanel()
        {
            dbContext = new DishDbContext(connectionString);
            dish = new DishesModels();
            List<DishesModels> listDishes = await dbContext.RetrieveListPastaDish(dish);
            List<DishesModels> displayPasta = listDishes.Take(5).ToList();
            if (displayPasta.Count < 1)
            {
                noDishPanel = new SM_NoDishDisplay();
                panelPasta.Controls.Add(noDishPanel);
            }
            else
            {
                pastaLayoutPanel.Controls.Clear();
                foreach (DishesModels dish in displayPasta)
                {
                    pastaDishPanel = new DisplayDishPanel(dish);
                    pastaLayoutPanel.Controls.Add(pastaDishPanel);
                }
                panelPasta.Controls.Add(pastaLayoutPanel);
            }
        }

        private async void InitializeBakeryPanel()
        {
            dbContext = new DishDbContext(connectionString);
            dish = new DishesModels();
            List<DishesModels> listDishes = await dbContext.RetrieveListBakeryDish(dish);
            List<DishesModels> displayBakery = listDishes.Take(5).ToList();
            if (displayBakery.Count < 1)
            {
                noDishPanel = new SM_NoDishDisplay();
                panelBakery.Controls.Add(noDishPanel);
            }
            else
            {
                bakeryLayoutPanel.Controls.Clear();
                foreach (DishesModels dish in displayBakery)
                {
                    bakeryDishPanel = new DisplayDishPanel(dish);
                    bakeryLayoutPanel.Controls.Add(bakeryDishPanel);
                }
                panelBakery.Controls.Add(bakeryLayoutPanel);
            }
        }

        private async void InitializeDrinksPanel()
        {
            dbContext = new DishDbContext(connectionString);
            dish = new DishesModels();
            List<DishesModels> listDishes = await dbContext.RetrieveListDrinksDish(dish);
            List<DishesModels> displayDrinks = listDishes.Take(5).ToList();
            if (displayDrinks.Count < 1)
            {
                noDishPanel = new SM_NoDishDisplay();
                panelDrinks.Controls.Add(noDishPanel);
            }
            else
            {
                drinksLayoutPanel.Controls.Clear();
                foreach (DishesModels dish in displayDrinks)
                {
                    drinksDishPanel = new DisplayDishPanel(dish);
                    drinksLayoutPanel.Controls.Add(drinksDishPanel);
                }
                panelDrinks.Controls.Add(drinksLayoutPanel);
            }
        }

    }
}
