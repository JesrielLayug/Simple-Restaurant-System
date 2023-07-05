using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RestaurantSystem.Controller.HandlesButtonsEffect
{
    public class ListButtonEffect
    {
        private List<Button> listsButton = new List<Button>();
        private List<Image> listNewImages = new List<Image>();
        private List<Image> listDefaultImages = new List<Image>();
        // Default Fore Color and Back Color of the button
        private Color DefForeColor;
        private Color DefBackColor;
        // Selected Fore Color and Back Color of the button
        private Color NewForeColor;
        private Color NewBackColor;

        public ListButtonEffect(List<Image> listNewImages, List<Image> listDefaultImages, List<Button> listsButton, Color DefForeColor, Color DefBackColor, Color NewForeColor, Color NewBackColor)
        {
            this.listNewImages = listNewImages;
            this.listDefaultImages = listDefaultImages;
            this.listsButton = listsButton;
            this.DefForeColor = DefForeColor;
            this.DefBackColor = DefBackColor;
            this.NewForeColor = NewForeColor;
            this.NewBackColor = NewBackColor;

            BTNSetDefColor();
        }

        private void BTNSetDefColor()
        {
            foreach (Button button in listsButton)
            {
                button.BackColor = DefBackColor;
                button.ForeColor = DefForeColor;
                if (button.Image != null)
                {
                    button.Image = listDefaultImages[listsButton.IndexOf(button)];
                    button.MouseEnter += (s, e) => { button.Image = listNewImages[listsButton.IndexOf(button)]; };
                    button.MouseLeave += (s, e) => { button.Image = listDefaultImages[listsButton.IndexOf(button)]; };
                }
                else
                {
                    button.Image = null;
                }
                button.MouseEnter += (s, e) => {
                    button.ForeColor = NewForeColor;
                    button.BackColor = NewBackColor;
                };
                button.MouseLeave += (s, e) => {
                    button.ForeColor = DefForeColor;
                    button.BackColor = DefBackColor;
                };

            }
        }

        public void BTNSelectedColor(Button _button)
        {
            foreach (Button button in listsButton)
            {
                int index = listsButton.IndexOf(button);

                if (button == _button)
                {
                    _button.BackColor = NewBackColor;
                    _button.ForeColor = NewForeColor;
                    if (button.Image != null)
                    {
                        _button.Image = listNewImages[index];
                        _button.MouseEnter += (s, e) => { _button.Image = listNewImages[index]; };
                        _button.MouseLeave += (s, e) => { _button.Image = listNewImages[index]; };
                    }
                    else
                    {
                        _button.Image = null;
                    }

                    _button.MouseEnter += (s, e) => 
                    { 
                        _button.ForeColor = NewForeColor;
                        _button.BackColor = NewBackColor;
                    };
                    _button.MouseLeave += (s, e) => 
                    { 
                        _button.ForeColor = NewForeColor;
                        _button.BackColor = NewBackColor;
                    };
                    


                }
                else
                {
                    button.BackColor = DefBackColor;
                    button.ForeColor = DefForeColor;
                    if (button.Image != null)
                    {
                        button.Image = listDefaultImages[index];
                        button.MouseEnter += (s, e) => { button.Image = listNewImages[index]; };
                        button.MouseLeave += (s, e) => { button.Image = listDefaultImages[index]; };
                    }
                    else
                    {
                        button.Image = null;
                    }

                    button.MouseEnter += (s, e) => {
                        button.ForeColor = NewForeColor;
                        button.BackColor = NewBackColor;
                    };
                    button.MouseLeave += (s, e) => {
                        button.ForeColor = DefForeColor;
                        button.BackColor = DefBackColor;
                        
                    };
                }
            }
        }
    }
}
