using RestaurantSystem.Model.ClassProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using RestaurantSystem.Controller.HandlesButtonsEffect;
using RestaurantSystem.Model.ListObjects;

namespace RestaurantSystem.Views.CustomComponents.OrderComponent
{
    public class DisplayOrderPanel : Panel
    {
        ButtonEffect buttonStyle;
        private readonly OrderObjectModel order;

        public Label ServiceOption;
        public Label DishName;
        public Label DishPrice;
        public Label DishQuantity;
        public Label OrderNote;

        public Button DishRemove;
        Color defBackColor = Color.FromArgb(50, 50, 50);
        Color defForeColor = Color.FromArgb(159, 159, 159);
        Color newBackColor = Color.FromArgb(50, 50, 50);
        Color newForeColor = Color.White;

        public DisplayOrderPanel(OrderObjectModel order)
        {
            this.order = order;
            InitializePanelAttribute();
            InititalizeComponents();
            InitializeRemoveButton();

            buttonStyle = new ButtonEffect(DishRemove, defForeColor, defBackColor, newForeColor, newBackColor, null, null);
        }

        private async void InitializePanelAttribute()
        {
            Name = order.DishId.ToString();
            Size = new Size(273, 107);
            BackColor = Color.FromArgb(50,50, 50);
            BorderStyle = BorderStyle.FixedSingle;
            Margin = new Padding(3, 3, 3, 8);
            AutoSize = false;
        }

        private async void InitializeRemoveButton()
        {
            DishRemove = new Button()
            {
                Text = "x",
                Size = new Size(23, 23),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(250, -2),
                Font = new Font("Poppins", 9, FontStyle.Bold),
            };
            DishRemove.FlatAppearance.BorderSize = 0;
            Controls.Add(DishRemove);

            DishRemove.Click += DishRemove_Click;
        }

        private void DishRemove_Click(object sender, EventArgs e)
        {
            buttonStyle.SetNewStyle(DishRemove);
            ListOfOrders.RemoveOrder(this.order);
        }

        private async void InititalizeComponents()
        {

            DishName = new Label()
            {
                Text = order.DishName,
                Font = new Font("Poppins", 11, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(25, 16),
                AutoSize = false,
                Size = new Size(226, 19),
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.Transparent,
            };
            int nameMaxLength = 20;
            LimitLabelLength(DishName, nameMaxLength);
            Controls.Add(DishName);

            DishPrice = new Label()
            {
                Text = "₱ " + order.TotalPrice.ToString("0.00"),
                AutoSize = false,
                Location = new Point(28, 41),
                Size = new Size(200, 19),
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Poppins", 10, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
            };
            Controls.Add(DishPrice);

            DishQuantity = new Label()
            {
                Text = $"x" + order.Quantity.ToString(),
                Size = new Size(40, 19),
                Location = new Point(230, 70),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Font = new Font("Poppins", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = false,
            };
            Controls.Add(DishQuantity);


            OrderNote = new Label()
            {
                Text = "* " + order.OrderNote,
                Size = new Size(188, 26),
                Location = new Point(29, 69),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(159, 159, 159),
                Font = new Font("Poppins", 9, FontStyle.Regular),
                TextAlign = ContentAlignment.TopLeft,
                AutoSize = false,
            };
            int maxLength = 26;
            LimitLabelLength(OrderNote, maxLength);

            if(order.OrderNote == string.Empty)
            {
                OrderNote.Text = "* No order request received *";
            }

            Controls.Add(OrderNote);

        }

        public void LimitLabelLength(Label label, int maxLength)
        {
            if (label.Text.Length > maxLength)
            {
                label.Text = label.Text.Substring(0, maxLength) + "...";
            }
        }
    }
}
