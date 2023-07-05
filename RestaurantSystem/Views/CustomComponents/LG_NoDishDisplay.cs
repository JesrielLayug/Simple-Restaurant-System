using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RestaurantSystem.Views.CustomComponents
{
    public class LG_NoDishDisplay : Panel
    {
        public LG_NoDishDisplay()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.White;

            InitializePanelComponents();
        }
        private void InitializePanelComponents()
        {
            PictureBox pictureBox = new PictureBox()
            {
                Location = new Point(182, 38),
                Size = new Size(527, 432),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image.FromFile("C:\\Users\\LAYUG\\Desktop\\Programming\\RestaurantSystem\\RestaurantSystem\\Resources\\BG.png"),
                BackColor = Color.Transparent
            };
            Controls.Add(pictureBox);

            Label label = new Label()
            {
                Text = "You don't have any items yet. \r\nProceed to \"Product Management\" to add some.",
                Location = new Point(182, 486),
                Size = new Size(527, 89),
                Font = new Font("Poppins", 15, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            Controls.Add(label);
        }
    }
}
