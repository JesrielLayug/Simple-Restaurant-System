using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using RestaurantSystem.Model;
using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Controller.CustomEvents;

namespace RestaurantSystem.Views.CustomComponents.OrderComponent
{
    public class PendingOrderPanel : Panel
    {
        public static event EventHandler<OrderPanelClickedEventArgs> OrderPanelClicked;


        private PurchaseOrderModel purchaseOrder;
        private int dishNum;
        string orderNumbers;

        private Label LB_OrderNumber;
        private Label LB_Orders;

        private Panel splitter1;
        private Panel splitter2;
        private LinkLabel seeOrderDetails;

        public PendingOrderPanel(PurchaseOrderModel purchaseOrder, int dishNum)
        {
            this.purchaseOrder = purchaseOrder;
            this.dishNum = dishNum;
            InitializePanelAttributes();
            HeaderPanel();

            Click += PendingOrderPanel_Click;
        }

        private void PendingOrderPanel_Click(object sender, EventArgs e)
        {
            ListOrderPanelClick.PanelClick(purchaseOrder);
        }

        private async void InitializePanelAttributes()
        {
            Name = orderNumbers;
            Size = new Size(887, 70);
            BackColor = Color.White;
            BorderStyle = BorderStyle.None;
            Margin = new Padding(0, 0, 0, 0);
        }

        private async void HeaderPanel()
        {
            LB_OrderNumber = new Label()
            {
                Text = $"#{purchaseOrder.OrderNumber}",
                Size = new Size(250, 24),
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 12, FontStyle.Bold),
                Location = new Point(11, 23),
                TextAlign = ContentAlignment.TopCenter,
                ForeColor = Color.Black,
                AutoSize = false,
            };
            Controls.Add(LB_OrderNumber);

            splitter1 = new Panel()
            {
                Size = new Size(2, 40),
                BackColor = SystemColors.ControlLight,
                Location = new Point(291, 17),
                BorderStyle = BorderStyle.None,
            };
            Controls.Add(splitter1);

            LB_Orders = new Label()
            {
                Text = $"ORDERS: {dishNum}",
                Size = new Size(288, 24),
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 11, FontStyle.Bold),
                Location = new Point(302, 23),
                TextAlign = ContentAlignment.TopCenter,
                ForeColor = Color.Black,
                AutoSize = false,
            };
            Controls.Add(LB_Orders);

            splitter2 = new Panel()
            {
                Size = new Size(2, 40),
                BackColor = SystemColors.ControlLight,
                Location = new Point(593, 17),
                BorderStyle = BorderStyle.None,
            };
            Controls.Add(splitter2);

            seeOrderDetails = new LinkLabel()
            {
                Text = $"SEE ORDER DETAILS",
                Size = new Size(230, 24),
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 11, FontStyle.Bold),
                Location = new Point(630, 25),
                TextAlign = ContentAlignment.TopCenter,
                LinkColor = Color.Black,
                AutoSize = false,
                VisitedLinkColor = Color.FromArgb(28, 28, 28),
                LinkBehavior = LinkBehavior.HoverUnderline,
                DisabledLinkColor = Color.FromArgb(28, 28, 28),
                ActiveLinkColor = Color.Black
            };
            seeOrderDetails.Click += SeeOrderDetails_Click;
            Controls.Add (seeOrderDetails);
        }

        private void SeeOrderDetails_Click(object sender, EventArgs e)
        {
            ListOrderPanelClick.PanelClick(purchaseOrder);
        }
    }
}
