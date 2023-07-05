using RestaurantSystem.Model.ClassProperties;
using RestaurantSystem.Model.ListObjects;
using RestaurantSystem.Views.CustomComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Views.AdditionalForms
{
    public partial class OrderForm : Form
    {
        private DisplayDishPanel dishPanel;
        private DishesModels dish;
        OrderObjectModel orderObject = new OrderObjectModel();

        public OrderForm(DishesModels dish)
        {
            this.dish = dish;
            InitializeComponent();
        }

        public bool NoRadioButtonSelected(GroupBox groupBox)
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

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            if (TBQuantity.Text != string.Empty)
            {
                orderObject.DishId = dish.DishId;
                orderObject.DishName = dish.DishName;
                orderObject.OrderNote = TBOrderRequest.Text;
                orderObject.Price = dish.DishPrice;
                orderObject.TotalPrice = dish.DishPrice * int.Parse(TBQuantity.Text);
                orderObject.Quantity = int.Parse(TBQuantity.Text);

                ListOfOrders.InsertOrder(orderObject);
                Close();
            }
            else
            {
                MessageBox.Show("Please provide necessary information in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TBQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
