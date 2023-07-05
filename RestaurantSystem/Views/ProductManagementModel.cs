using RestaurantSystem.Controller.HandlesButtonsEffect;
using RestaurantSystem.Models.AdditionalForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using RestaurantSystem.Views.CustomComponents;
using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Model;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Drawing.Imaging;
using RestaurantSystem.Controller;
using System.ComponentModel.Design.Data;

namespace RestaurantSystem.Models
{
    public partial class ProductManagementModel : UserControl
    {
        // For Retrievement of the objects
        string connectionString = @"Data Source=.;Initial Catalog=JRestaurantSystem;Integrated Security=True";
        DishesModels dish = new DishesModels();
        CreateDishesPanel dishPanel;
        DishDbContext dbContext;
        List<DishesModels> listDishesModels;
        List<CreateDishesPanel> listDishPanels;

        AddNewDishForm addNewDishForm = new AddNewDishForm();

        // Edit Button of Dish Items
        List<Button> EditbuttonList;
        List<Image> buttonDefImages;
        List<Image> buttonNewImages;
        ListButtonEffect listButtonEffect;
        Color foreColor = Color.FromArgb(123, 122, 122);
        Color backColor = Color.Black;
        Color newForeColor = Color.White;
        Color newBackColor = Color.FromArgb(25, 25, 25);


        // Add New Dish Properties
        private Button addButton;
        Image addNewDishCurImg = Image.FromFile("C:\\Users\\LAYUG\\Desktop\\Programming\\RestaurantSystem\\RestaurantSystem\\Resources\\plusDark.png");
        Image addNewDishNewImg = Image.FromFile("C:\\Users\\LAYUG\\Desktop\\Programming\\RestaurantSystem\\RestaurantSystem\\Resources\\plusWhite.png");

        public FlowLayoutPanel flowLayoutPanel;

        ButtonEffect addNewDishButtonDesign;

        public ProductManagementModel()
        {
            InitializeComponent();
            InitializeFlowlayoutPanel();
        }

        public async void InitializeFlowlayoutPanel()
        {
            flowLayoutPanel = new FlowLayoutPanel()
            {
                Size = new Size(1181, 745),
                Location = new Point(19, 125),
                BackColor = SystemColors.Control,
                AutoScroll = true,
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = false,
                Padding = new Padding(25, 0, 0, 0),
            };
            Controls.Add(flowLayoutPanel);

            LoadsItemsFromDatabase();
        }

        private void InitializeAddNewButton()
        {
            Color defaultBackColor = Color.FromArgb(240, 240, 240);
            Color defaultForeColor = Color.Black;

            Color selectedBackColor = Color.Black;
            Color selectedForeColor = Color.White;
            addButton = new Button()
            {
                Text = "\nADD NEW DISH",
                Size = new Size(216, 339),
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                ImageAlign = ContentAlignment.BottomCenter,
                TextImageRelation = TextImageRelation.ImageAboveText,
                Margin = new Padding(0, 20, 10, 20),
                Font = new Font("Poppins", 11, FontStyle.Bold | FontStyle.Regular),
                Image = addNewDishCurImg,
        };
            addNewDishButtonDesign = new ButtonEffect(addButton, defaultForeColor, defaultBackColor, selectedForeColor, selectedBackColor, addNewDishCurImg, addNewDishNewImg);

            addButton.Click += (s, e) =>
            {
                addNewDishButtonDesign.SetNewStyle(addButton);
                addNewDishForm = new AddNewDishForm();
                addNewDishForm.ItemAdded += AddItemForm_ItemAdded;
                addNewDishForm.ShowDialog();
            };
            flowLayoutPanel.Controls.Add(addButton);
        }


        public async void LoadsItemsFromDatabase()
        {
            dbContext = new DishDbContext(connectionString);
            dish = new DishesModels();
            flowLayoutPanel.Controls.Clear();
            InitializeAddNewButton();

            listDishesModels = await dbContext.RetrieveListDataAsync(dish); // Retrieving the list of data
            listDishPanels = new List<CreateDishesPanel>(); // creating a list of panels for the data
            
            // creating the edit button for each dish panels
            EditbuttonList = new List<Button>();
            buttonDefImages = new List<Image>();
            buttonNewImages = new List<Image>();
            Image newImage = Image.FromFile("C:\\Users\\LAYUG\\Desktop\\Programming\\RestaurantSystem\\RestaurantSystem\\Resources\\penWhite.png");
            Image defImage = Image.FromFile("C:\\Users\\LAYUG\\Desktop\\Programming\\RestaurantSystem\\RestaurantSystem\\Resources\\pencil.png");
           
            foreach (DishesModels dishes in listDishesModels)
            {
                dishPanel = new CreateDishesPanel(dishes); // Initializing all the panels for all dishes
                listDishPanels.Add(dishPanel); // insert all the panels to a list
                
                flowLayoutPanel.Controls.Add(dishPanel); // displaying all the panels from a list
                
                EditbuttonList.Add(dishPanel.btnEdit);  // Adding the edit button to each panels
                buttonDefImages.Add(defImage);
                buttonNewImages.Add(newImage);
                listButtonEffect = new ListButtonEffect(buttonNewImages, buttonDefImages, EditbuttonList, foreColor, backColor, newForeColor, newBackColor);

                foreach(CreateDishesPanel panel in listDishPanels)
                {
                    foreach (Button button in EditbuttonList)
                    {
                        button.Click += (s, e) =>
                        {
                            listButtonEffect.BTNSelectedColor(button);
                        };
                    }
                }

                dishPanel.RemoveDishEvent += Panel_RemoveDishEvent;

                dishPanel.btnEdit.Click += async (s, e) =>
                {
                    addNewDishForm = new AddNewDishForm();
                    addNewDishForm.Load += (se, EventArgs) =>
                    {

                        if (dishes.DishCategory == addNewDishForm.Soups.Name)
                            addNewDishForm.Soups.Checked = true;
                        else if (dishes.DishCategory == addNewDishForm.Salads.Name)
                            addNewDishForm.Salads.Checked = true;
                        else if (dishes.DishCategory == addNewDishForm.Pasta.Name)
                            addNewDishForm.Pasta.Checked = true;
                        else if (dishes.DishCategory == addNewDishForm.BakeryProducts.Name)
                            addNewDishForm.BakeryProducts.Checked = true;
                        else
                            addNewDishForm.Drinks.Checked = true;

                    };

                    addNewDishForm.textBoxName.Text = dishes.DishName;
                    using (MemoryStream stream = new MemoryStream(dishes.DishImage))
                    {
                        Image dishImage = Image.FromStream(stream);
                        addNewDishForm.pictureBoxDishPhoto.Image = dishImage;
                        addNewDishForm.pictureBoxDishPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    addNewDishForm.textBoxPrice.Text = dishes.DishPrice.ToString("0");
                    addNewDishForm.textBoxDescription.Text = dishes.DishDescription;
                    addNewDishForm.buttonAddDish.Text = "Update";

                    addNewDishForm.Show();

                    await Task.Delay(500);

                    addNewDishForm.buttonAddDish.Click -= addNewDishForm.buttonAddDish_Click;

                    addNewDishForm.buttonAddDish.Click += async (se, EventArgs) =>
                    {
                        int id = dishes.DishId;
                        string name = addNewDishForm.textBoxName.Text;
                        decimal price = decimal.Parse(addNewDishForm.textBoxPrice.Text);
                        string Description = addNewDishForm.textBoxDescription.Text;
                        string category;
                        byte[] imageData;
                        if (addNewDishForm.Soups.Checked == true)
                            category = addNewDishForm.Soups.Name;
                        else if(addNewDishForm.Salads.Checked == true)
                            category = addNewDishForm.Salads.Name;
                        else if (addNewDishForm.Pasta.Checked == true)
                            category = addNewDishForm.Pasta.Name;
                        else if (addNewDishForm.BakeryProducts.Checked == true)
                            category = addNewDishForm.BakeryProducts.Name;
                        else
                            category = addNewDishForm.Drinks.Name;

                        using (MemoryStream stream = new MemoryStream())
                        {
                            addNewDishForm.pictureBoxDishPhoto.Image.Save(stream, ImageFormat.Png);
                            imageData = stream.ToArray();

                            dish = new DishesModels()
                            {
                                DishId = id,
                                DishCategory = category,
                                DishName = name,
                                DishImage = imageData,
                                DishPrice = price,
                                DishDescription = Description
                            };

                            dbContext = new DishDbContext(connectionString);
                            await dbContext.UpdateDishDataAsync(dish);
                            LoadsItemsFromDatabase();
                        }
                        addNewDishForm.Close();

                    };
                       
                };
            }
        }

        private async void Panel_RemoveDishEvent(object sender, EventArgs e)
        {
            LoadsItemsFromDatabase();
        }

        private async void AddItemForm_ItemAdded(object sender, EventArgs e)
        {
            // Refresh the FlowLayoutPanel after the item is added
            LoadsItemsFromDatabase();
        }
    }
}
