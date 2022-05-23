using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class OtherList
    {
        public string othername = "";
        public int otherPrice = 0;
        public int count = 0;
        public int toTal = 0;
        public OtherList(string name, int price,int _count)
        {
            othername = name;
            otherPrice = price;
            count = _count;
            toTal = price * _count;
        }
    }
}
