using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Controller.HandlesButtonsEffect
{
    public class ButtonEffect
    {
        private Button button;
        private Color defForeColor;
        private Color defBackColor;
        private Color newForeColor;
        private Color newBackColor;
        private Image defImage;
        private Image newImage;

        public ButtonEffect(Button button, Color defForeColor, Color defBackColor, Color newForeColor, Color newBackColor, Image defImage, Image newImage)
        {
            this.button = button;
            this.defForeColor = defForeColor;
            this.defBackColor = defBackColor;
            this.newForeColor = newForeColor;
            this.newBackColor = newBackColor;
            this.defImage = defImage;
            this.newImage = newImage;

            SetDefaultStyle();
        }

        private void SetDefaultStyle()
        {
            button.BackColor = defBackColor;
            button.ForeColor = defForeColor;
            if (button.Image != null)
                button.Image = defImage;
            else
                button.Image = null;
            button.MouseEnter += (s, e) =>
            {
                button.ForeColor = newForeColor;
                button.BackColor = newBackColor;
                if (button.Image != null)
                {
                    button.Image = newImage;
                }
                else
                {
                    button.Image = null;
                }
            };
            button.MouseLeave += (s, e) => {
                button.ForeColor = defForeColor;
                button.BackColor = defBackColor;
                if (button.Image != null)
                {
                    button.Image = defImage;
                }
                else
                {
                    button.Image = null;
                }
            };
        }

        public void SetNewStyle(Button selectedButton)
        {
            if (button == selectedButton)
            {
                selectedButton.ForeColor = newForeColor;
                selectedButton.BackColor = newBackColor;
                if (selectedButton.Image != null)
                {
                    selectedButton.Image = newImage;
                    selectedButton.MouseLeave += (s, e) => { selectedButton.Image = newImage;  };
                    selectedButton.MouseEnter += (s, e) => { selectedButton.Image = newImage; };
                }
                else
                    selectedButton.Image = null;

                selectedButton.MouseEnter += (s, e) => 
                { 
                    selectedButton.ForeColor = newForeColor; 
                    selectedButton.BackColor = newBackColor;
                };

                selectedButton.MouseLeave += (s, e) => 
                { 
                    selectedButton.ForeColor = newForeColor; 
                    selectedButton.BackColor = newBackColor;
                };
            }
            else
            {
                button.BackColor = defBackColor;
                button.ForeColor = defForeColor;
                if (button.Image != null)
                {
                    button.Image = defImage;
                    button.MouseEnter += (s, e) => { button.Image = newImage; };
                    button.MouseLeave += (s, e) => { button.Image = defImage; };
                }
                else
                    button.Image = null;

                button.MouseEnter += (s, e) => 
                {
                    button.ForeColor = newForeColor;
                    button.BackColor = newBackColor;
                };

                button.MouseLeave += (s, e) => 
                {
                    button.ForeColor = defForeColor;
                    button.BackColor = defBackColor;
                };
            }
        }
    }
}
