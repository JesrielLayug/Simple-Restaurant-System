using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Model;
using RestaurantSystem.Views.CustomComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Controller.HandlesAllDishesDisplays
{
    public class DisplayDishToSoupModel
    {
        private FlowLayoutPanel flowLayoutPanel;
        private DishesModels dish;
        private DishDbContext dbContext;
        private string connString;
        private Panel panel;

        public DisplayDishToSoupModel(FlowLayoutPanel layoutPanel, DishesModels dishes, DishDbContext dbContext, string connString, Panel panel)
        {
            this.flowLayoutPanel = layoutPanel;
            this.dish = dishes;
            this.dbContext = dbContext;
            this.connString = connString;
            this.panel = panel;
        }

        public async Task RefreshAllDish()
        {
            await Task.Delay(500);
            flowLayoutPanel.Controls.Clear();
            dbContext = new DishDbContext(connString);
            dish = new DishesModels();

            List<DishesModels> listDishes = await dbContext.RetrieveListSoupDish(dish);
            foreach (var dish in listDishes)
            {
                DisplayDishPanel dishPanel = new DisplayDishPanel(dish);
                flowLayoutPanel.Controls.Add(dishPanel);
            }
            panel.Controls.Add(flowLayoutPanel);
        }
    }
}
