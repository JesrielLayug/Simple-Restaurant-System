using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using RestaurantSystem.Models.CategoriesModels;
using RestaurantSystem.Model;
using RestaurantSystem.Model.ClassProperties;

namespace RestaurantSystem.Views.CustomComponents.OrderComponent
{
    public class DishSpecificationPanel : Panel
    {
        private OrderObjectModel order;
        private Label OrderName;
        private Panel splitter1;
        private Label Qty;
        private Label OrderNote;

        public DishSpecificationPanel(OrderObjectModel order)
        {
            this.order = order;
            InitializePanelAttributes();
            InitializeAllComponents();
        }

        private async void InitializePanelAttributes()
        {
            Size = new Size(243, 73);
            Location = new Point(5, 5);
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.None;
            Margin = new Padding(0);
        }

        private async void InitializeAllComponents()
        {
            OrderName = new Label()
            {
                Text = order.DishName,
                Size = new Size(198, 19),
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 10, FontStyle.Bold),
                Location = new Point(8, 2),
                TextAlign = ContentAlignment.TopLeft,
                ForeColor = Color.White,
                AutoSize = false,
                Margin = new Padding(6, 0, 6, 0)
            };
            Controls.Add(OrderName);

            Qty = new Label()
            {
                Text = order.Quantity.ToString(),
                Size = new Size(24, 19),
                Location = new Point(213, 2),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Font = new Font("Poppins", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = false,
            };
            Controls.Add(Qty);

            OrderNote = new Label()
            {
                Text = "* " + order.OrderNote,
                Size = new Size(215, 47),
                Location = new Point(19, 23),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Font = new Font("Poppins", 8, FontStyle.Regular),
                TextAlign = ContentAlignment.TopLeft,
                AutoSize = false,
            };
            if (order.OrderNote == string.Empty)
            {
                OrderNote.Text = "* No order request received *";
            }
            Controls.Add(OrderNote);
        }

    }
}
