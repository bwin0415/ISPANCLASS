using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class GlobalVar
    {
        public static string userInfo="";
        public static List<ArrayList> listOrderItem = new List<ArrayList>();
        //作業規格： 品項資訊要由ArrayList改成自訂類別CLASS
        public static Form1 formMenu;
        public static Form2 formChecklist;
    }
}
