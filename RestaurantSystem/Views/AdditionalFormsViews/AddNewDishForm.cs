using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Controller.HandlesButtonsEffect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystem.Model;
using RestaurantSystem.Views.CustomComponents;
using RestaurantSystem.Models.CategoriesModels;
using System.Management;

namespace RestaurantSystem.Models.AdditionalForms
{
    public partial class AddNewDishForm : Form
    {
        string connectionString = @"Data Source=.;Initial Catalog=JRestaurantSystem;Integrated Security=True";
        public event EventHandler ItemAdded;

        DishesModels dish = new DishesModels();
        DishDbContext dbContext;

        public byte[] dishImage;

        ListButtonEffect addNewDishButtons;
        RadioButtonEffect radioButtons;

        Color rbSelColor = Color.Black;
        Color rbDefColor = Color.Transparent;

        Color defaultBackColor = Color.FromArgb(240, 240, 240);
        Color defaultForeColor = Color.Black;

        //Set the selected color of the button
        Color selectedBackColor = Color.Black;
        Color selectedForeColor = Color.White;

        

            List<Image> listCurrentImages = new List<Image>()
            {
                null, null, null
            };
            List<Image> listNewImages = new List<Image>()
            {
                null, null, null
            };


        public AddNewDishForm()
        {
            InitializeComponent();
            List<Button> listButtons = new List<Button>()
            {
                buttonSelectPhoto, buttonCancel, buttonAddDish
            };

            List<RadioButton> listRadioButtons = new List<RadioButton>()
            {
                Soups, Salads, Pasta, BakeryProducts, Drinks
            };

            addNewDishButtons = new ListButtonEffect(listNewImages, listCurrentImages, listButtons, defaultForeColor, defaultBackColor, selectedForeColor, selectedBackColor);
            radioButtons = new RadioButtonEffect(listRadioButtons, rbSelColor, rbDefColor);
        }

        private void buttonSelectPhoto_Click(object sender, EventArgs e)
        {
            addNewDishButtons.BTNSelectedColor(buttonSelectPhoto);

            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter for image file types
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            // Show the dialog and wait for the user to select a file
            DialogResult result = openFileDialog.ShowDialog();

            // If the user selects a file, load the image into the picture box and remove the label
            if (result == DialogResult.OK)
            {
                // Create a new Bitmap object from the selected image file
                Bitmap image = new Bitmap(openFileDialog.FileName);

                // Set the picture box to display the loaded image
                pictureBoxDishPhoto.Image = image;

                // Set the picture box size mode to center the image
                pictureBoxDishPhoto.SizeMode = PictureBoxSizeMode.StretchImage;

                string imagePath = openFileDialog.FileName;

                byte[] imageBytes = File.ReadAllBytes(imagePath);

                dish.DishImage = imageBytes;
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            addNewDishButtons.BTNSelectedColor(buttonCancel);
            this.Close();
        }

        public async void buttonAddDish_Click(object sender, EventArgs e)
        {
            addNewDishButtons.BTNSelectedColor(buttonAddDish);
            bool noRadioButtonIsSelected = NoRadioButtonSelected(GBRadioButtons);
            if (textBoxName.Text != String.Empty && textBoxPrice.Text != String.Empty && textBoxDescription.Text != String.Empty && pictureBoxDishPhoto.Image != null && !noRadioButtonIsSelected)
            {
                dish.DishName = textBoxName.Text;
                dish.DishPrice = decimal.Parse(textBoxPrice.Text);
                dish.DishDescription = textBoxDescription.Text;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string sqlQuery = "SELECT * FROM Dishes WHERE Name = @name";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("name", dish.DishName);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                reader.Close();
                                MessageBox.Show("The item already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                reader.Close();
                                using (MemoryStream stream = new MemoryStream())
                                {
                                    pictureBoxDishPhoto.Image.Save(stream, ImageFormat.Png);
                                    dish.DishImage = stream.ToArray();


                                    dbContext = new DishDbContext(connectionString);
                                    await dbContext.InsertDishData(dish);
                                }
                                ItemAdded?.Invoke(this, EventArgs.Empty);
                                this.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please provide necessary information in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool NoRadioButtonSelected(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // At least one radio button is selected
                    return false;
                }
            }

            // No radio button is selected
            return true;
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radioButtonSoup_CheckedChanged(object sender, EventArgs e)
        {
            radioButtons.RBSelectedColor(Soups);
            Soups.Name = "Soups";
            if (Soups.Checked)
            {
                dish.DishCategory = Soups.Name;
            } 
        }

        private void radioButtonSalads_CheckedChanged(object sender, EventArgs e)
        {
            radioButtons.RBSelectedColor(Salads);
            Salads.Name = "Salads";
            if (Salads.Checked)
            {
                dish.DishCategory = Salads.Name;
            }
        }

        private void radioButtonPasta_CheckedChanged(object sender, EventArgs e)
        {
            radioButtons.RBSelectedColor(Pasta);
            Pasta.Name = "Pasta";
            if (Pasta.Checked)
            {
                dish.DishCategory = Pasta.Name;
            }
        }

        private void radioButtonBakery_CheckedChanged(object sender, EventArgs e)
        {
            radioButtons.RBSelectedColor(BakeryProducts);
            BakeryProducts.Name = "BakeryProducts";
            if (BakeryProducts.Checked)
            {
                dish.DishCategory = BakeryProducts.Name;
            }
        }

        private void radioButtonDrinks_CheckedChanged(object sender, EventArgs e)
        {
            radioButtons.RBSelectedColor(Drinks);
            Drinks.Name = "Drinks";
            if (Drinks.Checked)
            {
                dish.DishCategory = Drinks.Name;
            }
        }
    }
}
