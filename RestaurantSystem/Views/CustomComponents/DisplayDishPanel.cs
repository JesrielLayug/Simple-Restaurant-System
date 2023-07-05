using RestaurantSystem.Model.ClassProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.ComIntegration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using RestaurantSystem.Models;
using RestaurantSystem.Models.AdditionalForms;
using RestaurantSystem.Model;
using RestaurantSystem.Model.ListObjects;
using RestaurantSystem.Views.AdditionalForms;

namespace RestaurantSystem.Views.CustomComponents
{

    public class DisplayDishPanel : Panel
    {
        DishesModels dishes;
        OrderForm orderForm;

        public PictureBox pictureBox;
        public Label DishName;
        public Label DishPrice;
        public Label DishDescription;
        public Label DishCategory;
        public DisplayDishPanel(DishesModels dish)
        {
            this.dishes = dish;
            IntializePanelAttributes();
            InitializeComponents();

            Click += DisplayDishPanel_Click;
        }

        private void DisplayDishPanel_Click(object sender, EventArgs e)
        {
            DisplayDishPanel displayDishPanel = new DisplayDishPanel(dishes);
            orderForm = new OrderForm(dishes);
            orderForm.panelDish.Controls.Add(displayDishPanel);

            orderForm.ShowDialog();
        }

        private async void IntializePanelAttributes()
        {
            Name = dishes.DishId.ToString();
            Size = new Size(266, 150);
            BackColor = Color.FromArgb(240, 240, 240);
            BorderStyle = BorderStyle.FixedSingle;
            Margin = new Padding(3, 3, 15, 20);
            AutoSize = false;
        }

        private async void InitializeComponents()
        {
            await Task.Delay(300);

            DishCategory = new Label()
            {
                Visible = false,
                Text = dishes.DishCategory,
            };
            Controls.Add(DishCategory);

            pictureBox = new PictureBox()
            {
                Size = new Size(105, 97),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(10, 24),
                BorderStyle = BorderStyle.None,
            };
            using (MemoryStream stream = new MemoryStream(dishes.DishImage))
            {
                Image dishImage = Image.FromStream(stream);
                pictureBox.Image = dishImage;
            }
            Controls.Add(pictureBox);

            DishName = new Label()
            {
                Text = dishes.DishName,
                Font = new Font("Poppins", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point (108, 26),
                AutoSize = false,
                Size = new Size(160, 22),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
            };
            int nameMaxLength = 13;
            LimitLabelLength(DishName, nameMaxLength);
            DishName.Click += DishName_Click;
            Controls.Add(DishName);

            DishPrice = new Label()
            {
                Text = $"₱ " + dishes.DishPrice.ToString("0.00"),
                AutoSize =false,
                Location = new Point(121, 48),
                Size = new Size(131, 20),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Poppins", 10, FontStyle.Bold),
                ForeColor = SystemColors.ControlDarkDark,
                BackColor= Color.Transparent,
            };
            Controls.Add(DishPrice);

            DishDescription = new Label()
            {
                Text = dishes.DishDescription,
                AutoSize = false,
                Location = new Point(121, 70),
                Size = new Size(132, 51),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Poppins", 8, FontStyle.Regular),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
            };
            int descriptionMaxLength = 50;
            LimitLabelLength(DishDescription, descriptionMaxLength);
            Controls.Add(DishDescription);

            DishDescription.Click += DishDescription_MouseEnter;
        }

        private void DishName_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dishes.DishName, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DishDescription_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show(dishes.DishDescription, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
