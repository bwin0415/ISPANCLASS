using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    class MyLabelButton :Label
    {
        public Button myDButton;

        public MyLabelButton()
        {
            myDButton = new Button();
            myDButton.BackColor = Color.LightYellow;
            myDButton.ForeColor = Color.Purple;
            myDButton.Size = new Size(120, 40);
            myDButton.Font = new Font("標楷體", 14,FontStyle.Bold);
            myDButton.Name = "btnDbutton";
            myDButton.Text = "標籤內按鈕";
            myDButton.Location = new Point(90,10);
            Controls.Add(myDButton);
            
        }
    }
}
