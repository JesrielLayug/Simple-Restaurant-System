using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Controller.HandlesButtonsEffect
{
    public class UserControlNavigation
    {
        List<UserControl> userControlList = new List<UserControl>();
        Panel bodyPanel;

        public UserControlNavigation(List<UserControl> userControlList, Panel bodyPanel)
        {
            this.userControlList = userControlList;
            this.bodyPanel = bodyPanel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i < userControlList.Count; i++)
            {
                userControlList[i].Dock = DockStyle.Fill;
                bodyPanel.Controls.Add(userControlList[i]);

            }
        }

        public void Display(int index)
        {
            if (index < userControlList.Count)
            {
                userControlList[index].BringToFront();
            }
        }
    }
}
