using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Views.CustomComponents.Interfaces
{
    public interface ILabels
    {
        void InitiallizeComponents();
        void SetContentAlignment(ContentAlignment alignment);
        void SetFont(Font font);
        void SetLocation(Point location);
        void SetText(string text);
        void SetSize(Size size);
    }
}
