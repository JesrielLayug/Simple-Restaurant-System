using RestaurantSystem.Views.CustomComponents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Label = System.Windows.Forms.Label;
using System.Windows.Forms;

namespace RestaurantSystem.Views.CustomComponents
{
    public class CustomLabel : Label, ILabels
    {
        Label label;
        public CustomLabel(Label label)
        {
            this.label = label;
            InitiallizeComponents();
        }

        public void InitiallizeComponents()
        {
            ForeColor = Color.Black;
            BackColor = Color.Transparent;
            AutoSize = false;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            TabIndex = 1;
        }

        public void SetContentAlignment(ContentAlignment alignment)
        {
            TextAlign = alignment;
        }

        public void SetFont(Font font)
        {
            Font = font;
        }

        public void SetLocation(Point location)
        {
            Location = location;
        }

        public void SetText(string text)
        {
            Text = text;
        }

        public void SetSize(Size size)
        {
            Size = size;
        }
    }
}
