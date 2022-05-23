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
    class drinkItem
    {
     #region 品項內容
     public string ItemName ;
     public int Itemprice ;
     #endregion
        public drinkItem(string name,int price) 
        {
            ItemName = name;
            Itemprice = price;
        }


    }

}
