using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantSystem.Controller.HandlesButtonsEffect
{
    public class RadioButtonEffect
    {
        private List<RadioButton> _listRadioButtons;
        Color _checkedBackColor;
        Color _transparentColor;

        public RadioButtonEffect(List<RadioButton> listRadioButtons, Color checkedBackColor, Color transparentColor)
        {
            this._listRadioButtons = listRadioButtons;
            this._checkedBackColor = checkedBackColor;
            this._transparentColor = transparentColor;
            RBDefaultColor();
        }

        private void RBDefaultColor()
        {
            foreach (RadioButton rb in _listRadioButtons)
            {
                rb.FlatAppearance.CheckedBackColor = _checkedBackColor;
                rb.MouseEnter += (s, e) => { rb.FlatAppearance.CheckedBackColor = _checkedBackColor; };
                rb.MouseLeave += (s, e) => { rb.FlatAppearance.CheckedBackColor = _transparentColor; };
            }
        }

        public void RBSelectedColor(RadioButton radioButton)
        {
            foreach (RadioButton rb in _listRadioButtons)
            {
                if (rb == radioButton)
                {
                    radioButton.FlatAppearance.CheckedBackColor = _checkedBackColor;
                    radioButton.MouseEnter += (s, e) => { radioButton.FlatAppearance.CheckedBackColor = _checkedBackColor; };
                    radioButton.MouseLeave += (s, e) => { radioButton.FlatAppearance.CheckedBackColor = _checkedBackColor; };
                }
                else
                {
                    rb.FlatAppearance.CheckedBackColor = _transparentColor;
                    rb.MouseEnter += (s, e) => { rb.FlatAppearance.CheckedBackColor = _checkedBackColor; };
                    rb.MouseLeave += (s, e) => { rb.FlatAppearance.CheckedBackColor = _transparentColor; };
                }
            }
        }

  
    }
}
