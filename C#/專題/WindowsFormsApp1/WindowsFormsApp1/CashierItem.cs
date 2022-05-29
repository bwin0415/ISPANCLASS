using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CashierItem
    {
       public string name = "";
       public int price =0;
       public string itemClass = "";
       public int itemId = 0;
        public CashierItem(string selectedName,int selectedId,string selectedClass ,int selectedPrice)
        {
            name = selectedName;
            price = selectedPrice;
            itemClass = selectedClass;
            itemId = selectedId;

        }


    }
}
