using RestaurantSystem.Model;
using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Models;
using RestaurantSystem.Models.AdditionalForms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Views.CustomComponents
{
    public class CreateDishesPanel : Panel
    {
        public event EventHandler RemoveDishEvent;
        DishesModels dishes;
        DishDbContext dbContext;
        string connectionString = @"Data Source=.;Initial Catalog=JRestaurantSystem;Integrated Security=True";

        public Button btnEdit = new Button();
        public Button btnRemove = new Button();
        PictureBox pictureBox;
        CustomLabel dishNameLabel;
        CustomLabel pesoSignLabel;
        CustomLabel priceLabel;
        CustomLabel descriptionLabel;

        public CreateDishesPanel(DishesModels dishes)
        {
            this.dishes = dishes;
            InitializeComponents().Wait();
            InitializePanelComponents();
        }


        private async Task InitializeComponents()
        {
            Name = dishes.DishId.ToString();
            Size = new Size(216, 339);
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            TabIndex = 5;
            Margin = new Padding(0, 20, 10, 20);
        }


        private async Task InitializePanelComponents()
        {
            await Task.Delay(300);

            pictureBox = new PictureBox();
            pictureBox.Size = new Size(116, 113);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new Point(45, 20);
            pictureBox.BorderStyle = BorderStyle.None;
            using (MemoryStream stream = new MemoryStream(dishes.DishImage))
            {
                Image dishImage = Image.FromStream(stream);
                pictureBox.Image = dishImage;
            }
            Controls.Add(pictureBox);

            Label Name = new Label();
            dishNameLabel = new CustomLabel(Name);
            dishNameLabel.SetFont(new Font("Poppins", 11, FontStyle.Bold | FontStyle.Regular));
            dishNameLabel.SetLocation(new Point(-1, 136));
            dishNameLabel.SetContentAlignment(ContentAlignment.TopCenter);
            dishNameLabel.SetSize(new Size(217, 24));
            dishNameLabel.SetText(dishes.DishName);
            dishNameLabel.Click += DishNameLabel_Click;
            int maxLength = 20;
            LimitLabelLength(dishNameLabel, maxLength);
            Controls.Add(dishNameLabel);

            Label price = new Label();
            priceLabel = new CustomLabel(price);
            priceLabel.SetFont(new Font("Poppins", 11, FontStyle.Bold | FontStyle.Regular));
            priceLabel.SetText($"₱ " + dishes.DishPrice.ToString("0.00"));
            priceLabel.SetContentAlignment(ContentAlignment.TopCenter);
            priceLabel.SetLocation(new Point(-6, 164));
            priceLabel.SetSize(new Size(223, 22));
            Controls.Add(priceLabel);

            Label description = new Label();
            descriptionLabel = new CustomLabel(description);
            descriptionLabel.SetFont(new Font("Poppins", 9, FontStyle.Regular));
            descriptionLabel.SetText(dishes.DishDescription);
            descriptionLabel.SetContentAlignment(ContentAlignment.MiddleCenter);
            descriptionLabel.SetLocation(new Point(3, 196));
            descriptionLabel.SetSize(new Size(210, 73));
            descriptionLabel.Click += Description_Click;
            int desMaxLength = 85;
            LimitLabelLength(descriptionLabel, desMaxLength);
            Controls.Add(descriptionLabel);


            btnEdit.Size = new Size(214, 61);
            btnEdit.Dock = DockStyle.Bottom;
            btnEdit.Text = " Edit dish";
            btnEdit.TextAlign = ContentAlignment.MiddleCenter;
            btnEdit.ImageAlign = ContentAlignment.MiddleRight;
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10, FontStyle.Regular | FontStyle.Bold);
            btnEdit.Image = Image.FromFile("C:\\Users\\LAYUG\\Desktop\\Programming\\RestaurantSystem\\RestaurantSystem\\Resources\\pencil.png");
            btnEdit.ForeColor = Color.FromArgb(123, 122, 122);
            btnEdit.BackColor = Color.Black;
            Controls.Add(btnEdit);

            btnRemove = new Button();
            btnRemove.Size = new Size(31, 29);
            btnRemove.Text = "x";
            btnRemove.Font = new Font("Poppins", 11, FontStyle.Regular | FontStyle.Bold);
            btnRemove.BackColor = Color.Transparent;
            btnRemove.ForeColor = Color.Black;
            btnRemove.Location = new Point(183, -1);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.TextAlign = ContentAlignment.MiddleCenter;
            btnRemove.Click += BtnRemove_Click1;
            Controls.Add(btnRemove);
        }

        public void LimitLabelLength(Label label, int maxLength)
        {
            if (label.Text.Length > maxLength)
            {
                label.Text = label.Text.Substring(0, maxLength) + "...";
            }
        }

        private void DishNameLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dishes.DishName, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Description_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dishes.DishDescription, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void BtnRemove_Click1(object sender, System.EventArgs e)
        {
            dbContext = new DishDbContext(connectionString);
            await dbContext.RemoveDishDataAsync(dishes);
            RemoveDishEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
