using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Views.CustomComponents
{
    public class SM_NoDishDisplay : Panel
    {
        public SM_NoDishDisplay()
        {
            InitializePanelComponents();
        }

        private async void InitializePanelComponents()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.Transparent;

            Label label = new Label()
            {
                Text = $"You don't have any items yet.\r\nProceed to \"Product Management\" to add some.\r\n",
                Location = new Point(70, 100),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Poppins", 11, FontStyle.Regular),
            };
            Controls.Add(label);

            PictureBox pictureBox = new PictureBox()
            {
                Size = new Size(260, 205),
                Location = new Point(480, 15),
                Image = Image.FromFile("C:\\Users\\LAYUG\\Desktop\\Programming\\RestaurantSystem\\RestaurantSystem\\Resources\\BG.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(pictureBox);
        }
    }
}
