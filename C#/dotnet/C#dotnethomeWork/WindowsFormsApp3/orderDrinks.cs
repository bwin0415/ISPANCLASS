using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class orderDrinks
    {
        #region 品項內容
        public string ItemName;
        public int Itemprice;
        public string sugarLevel;
        public string Icelevel;
        public string othername = "";
        public int addprice = 0;
        public int otherprice = 0;
        public int otherCount = 0;

        public int toTalPay { get; }
        public int count { get; } = 0;
        public List<OtherList> Others = new List<OtherList>();
        public string str配料資訊 = "";
        #endregion
        public orderDrinks(string name, int price,int _count,string sugar,string ice,List<OtherList> others)
        {
            ItemName = name;
            Itemprice = price;
            count = _count;
            sugarLevel = sugar;
            Icelevel = ice;
            Others = others;
            foreach (OtherList Ol in Others)
            {
              
              othername =  Ol.othername;
              otherprice=  Ol.otherPrice;
              otherCount= Ol.count;
              int a = Ol.toTal;
              addprice = addprice + a;
              str配料資訊+= string.Format("加{0} {1}元 共{2}份 ", othername, otherprice, otherCount);
            }
           
            toTalPay = (price+addprice) * _count;
        }
        public orderDrinks()
        {

        }

        public  override string ToString()
        { string a = "";
            for (int i = 0; i < Others.Count; i++)
            {
                a += string.Format("{0} {1} {2}",
                Others[i].othername, Others[i].otherPrice, Others[i].count);
            }
            return "\n ItemName: " + ItemName +
                   "\n Itemprice: " + Itemprice +
                "\n sugarLevel: " + sugarLevel +
                "\nIcelevel: " + Icelevel +
                "\n"+a+
                "\ncount: " + count+
                "\ntoTalPay  " + toTalPay;
        }
    }
}
