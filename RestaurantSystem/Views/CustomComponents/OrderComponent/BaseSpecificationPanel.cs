using RestaurantSystem.Controller.CustomEvents;
using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Views.CustomComponents.OrderComponent
{
    public class BaseSpecificationPanel: Panel
    {
        private string connectionString = @"Data Source=.;Initial Catalog=JRestaurantSystem;Integrated Security=True";
        PurchaseOrderDbContext dbContext;
        private string OrderNumber;
        private Label OrderName;
        private Panel splitter1;
        private Label LB_OrderNum;
        private Label LB_Orders;
        private Label LB_QTY;

        private Panel basePanel;
        public FlowLayoutPanel baseLayoutPanel;

        public Button buttonCancel;
        public Button buttonComplete;

        public BaseSpecificationPanel(string orderNumber)
        {
            OrderNumber = orderNumber;
            InitializePanelAttributes();
            InitializeAllComponents();
        }
        private async void InitializePanelAttributes()
        {
            Name = OrderNumber;
            Size = new Size(278, 670);
            Location = new Point(10, 12);
            BackColor = Color.FromArgb(28,28,28);
            BorderStyle = BorderStyle.FixedSingle;
            Margin = new Padding(0);
        }

        private async void InitializeAllComponents()
        {
            OrderName = new Label()
            {
                Text = $"#{OrderNumber}",
                Size = new Size(257, 24),
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 12, FontStyle.Bold),
                Location = new Point(13, 19),
                TextAlign = ContentAlignment.TopCenter,
                ForeColor = Color.White,
                AutoSize = false,
                Margin = new Padding(6, 0, 6, 0)
            };
            Controls.Add(OrderName);

            splitter1 = new Panel()
            {
                Size = new Size(148, 2),
                BackColor = Color.FromArgb(50,50,50),
                Location = new Point(69, 45),
                BorderStyle = BorderStyle.None,
            };
            Controls.Add(splitter1);

            LB_OrderNum = new Label()
            {
                Text = "Order Number",
                Size = new Size(199, 24),
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 10, FontStyle.Bold),
                Location = new Point(43, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                AutoSize = false,
                Margin = new Padding(6, 0, 6, 0)
            };
            Controls.Add(LB_OrderNum);

            LB_Orders = new Label()
            {
                Text = "Orders",
                Size = new Size(98, 19),
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 10, FontStyle.Bold),
                Location = new Point(21, 97),
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                AutoSize = false,
                Margin = new Padding(6, 0, 6, 0)
            };
            Controls.Add(LB_Orders);

            LB_QTY = new Label()
            {
                Text = "QTY",
                Size = new Size(45, 19),
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 10, FontStyle.Bold),
                Location = new Point(225, 98),
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                AutoSize = false,
                Margin = new Padding(6, 0, 6, 0)
            };
            Controls.Add(LB_QTY);

            basePanel = new Panel()
            {
                Size = new Size(248, 427),
                Location = new Point(13, 120),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                Margin = new Padding(0),
            };
            Controls.Add(basePanel);

            baseLayoutPanel = new FlowLayoutPanel()
            {
                Size = new Size(282, 424),
                Location = new Point(3, 3),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                Margin = new Padding(0),
                AutoScroll = true,
                Padding = new Padding(5, 5, 5, 5),
            };
            basePanel.Controls.Add(baseLayoutPanel);

            buttonComplete = new Button()
            {
                Text = "Order Complete",
                Size = new Size(276, 50),
                Dock = DockStyle.Bottom,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(50, 50, 50),
                Font = new Font("Poppins", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            buttonComplete.FlatAppearance.BorderSize = 0;
            Controls.Add(buttonComplete);


            buttonCancel = new Button()
            {
                Text = "Cancel",
                Size = new Size(273, 50),
                Dock = DockStyle.Bottom,
                ForeColor = Color.White,
                BackColor = Color.Black,
                Font = new Font("Poppins", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            buttonCancel.FlatAppearance.BorderSize = 0;
            Controls.Add(buttonCancel);
        }

    }
}
