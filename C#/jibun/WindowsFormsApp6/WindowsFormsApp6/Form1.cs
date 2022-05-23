using System;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        //類別變數-有可能是屬性有可能是欄位 //<>角括號
        List<ArrayList> 員工資料集合 = new List<ArrayList>();
        List<Hashtable> 員工資料集合2 = new List<Hashtable>();
        //除了array以外其他集合沒有多維度功能，可以透過集合包集合的方式製造多維度
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_L_Click(object sender, EventArgs e)
        {//listdemo
            List<int> myIntList = new List<int> { 1, 2, 3, 4, 5, 6 };//LIST不允許語法堂的寫法。
            List<string> myList = new List<string>();
            //還沒配置記憶體位置，
            myList.Add("red");
            myList.Add("yellow");
            myList.Add("blue");
            myList.Add("purple");
            myList.Add("green");
            Console.WriteLine("List Demo");
            Console.WriteLine("=================列出所有元素==================");
            foreach (string colorStirng in myList)
            {
                Console.WriteLine(colorStirng);
            }

            Console.WriteLine("===================================");

            myList[0] = "darkred";
            myList[2] = "deepblue";
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine("===============加入另一個集合(List,Array)=============");
            string[] arrayString = new string[] {"pink","gray","brown" };
            myList.AddRange(arrayString);
            foreach  (string color in myList)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("================Insert 插入元素===========");
            myList.Insert(2,"skyblue");
            foreach (string color in myList)
            {
                Console.WriteLine(color);
            }
                Console.WriteLine("===============Insert Range插入集合==============");
            myList.InsertRange(3,arrayString);
            foreach (string color in myList)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("================Remove 移元素================");
            myList.Remove("gray");
            myList.RemoveAt(3);
            myList.RemoveRange(4,2);//移除index: 4 和 5 的元素
            foreach (string color in myList)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("==================Sort 排序================");
            myList.Sort();
            foreach (string color in myList)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("==================reverse 反向排列================");//記憶體用量大
            myList.Reverse();
            foreach (string color in myList)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("================元素搜尋IndexOf=========");
            int idx = myList.IndexOf("darkred");
            Console.WriteLine("darkred index:" + idx);
            Console.WriteLine("=============List 轉換成Array============");
            string[] myTempArray = myList.ToArray();
            foreach (string color in myTempArray)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("==========Array 轉換成  List =============");
            List<string> myListNew = new List<string>(myTempArray);
            foreach (string color in myListNew)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("============= Clear 清除==========");
            myList.Clear();
            foreach (string color in myList)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("==============================================");
        }

        private void btn_AL_Click(object sender, EventArgs e)
        {
            Console.WriteLine("===================ArrayList Demo =====================");
            /*ArrayList myPersonInfo = new ArrayList() { 1,2,3,4,5,6,7,"john"};
            foreach (int i in myPersonInfo)
            {
                Console.WriteLine(i);
            } <==錯誤示範 */
            ArrayList myPersonInfo = new ArrayList();
            myPersonInfo.Add("王小名");//index：0
            myPersonInfo.Add(32000.0);//index：1
            myPersonInfo.Add(DateTime.Now);//index：2
            myPersonInfo.Add("0912-345-678");//index：3
            myPersonInfo.Add("高雄市前金區中正路");//index：4
            myPersonInfo.Add(26);//index：5
            
            ArrayList myPersonInfo2 = new ArrayList();
            myPersonInfo2.Add("張大書");//index：0
            myPersonInfo2.Add(45000.0);//index：1
            myPersonInfo2.Add(DateTime.Now);//index：2
            myPersonInfo2.Add("0911-222-333");//index：3
            myPersonInfo2.Add("台南市東區中華路");//index：4
            myPersonInfo2.Add(40);//index：5

            員工資料集合.Add(myPersonInfo);
            員工資料集合.Add(myPersonInfo2);
            foreach  (ArrayList perinfo in 員工資料集合)
            {
                string name = Convert.ToString(perinfo[0]);
               double wage = Convert.ToDouble(perinfo[1]);
               DateTime date = Convert.ToDateTime(perinfo[2]);
               string phone = Convert.ToString(perinfo[3]);
               string address = Convert.ToString(perinfo[4]);
               int sai = Convert.ToInt32(perinfo[5]);

                string strMsg = string.Format("{0} {1} {2:d} {3} {4} {5}歲",name,wage,date,phone,address,sai);
                Console.WriteLine(strMsg);
                
            }//搜尋員工資料
        }

        private void btn_D_Click(object sender, EventArgs e)
        {//key-value 集合物件=>必須明確定義資料型態=>key-value不能重複 有順序性可以用索引直
            Console.WriteLine("==========================Dictionary Demo");
            Dictionary<string, int> dictScore = new Dictionary<string, int>();
            dictScore.Add("王小明", 84);
            dictScore.Add("陳大貓", 72);
            dictScore.Add("李瑪莉", 69);
            dictScore["陳大貓"] = 76;//存在的key覆蓋
            dictScore["張大書"] = 77;//不存在的新增

            Console.WriteLine("李瑪莉分數：{0}",dictScore["李瑪莉"]);
            dictScore.Remove("王小明");

            foreach (KeyValuePair<string,int> myDict  in dictScore)
            {
                Console.WriteLine("key:{0}, value:{1}",myDict.Key,myDict.Value);
            }

            if (dictScore.ContainsKey("王小明"))
            {
                Console.WriteLine("陳大貓:{0}", dictScore["陳大貓"]);
            }
            else
            {
                Console.WriteLine("查無此人");
            }
            Console.WriteLine("======================================");
            Dictionary<string, string> stockCode = new Dictionary<string, string>() 
            { 
                { "AAPL", "蘋果" }, 
                {"AMZN","亞馬遜" },
                {"TSLA","特斯拉" },
            };

            for (int i = 0; i < stockCode.Count; i++)
            {
                Console.WriteLine("key:{0}, Value:{1}",stockCode.ElementAt(i).Key,stockCode.ElementAt(i).Value);
            }
            Console.WriteLine("======================================");
            dictScore.Clear();
            Console.WriteLine("DictScore count:{0}", dictScore.Count);
            Console.WriteLine("=====================================");
        }

        private void btn_Ht_Click(object sender, EventArgs e)
        {//key-value 集合物件 =不需要明確定義資料型態  沒有順序性所以不能用索引值
            Hashtable memberInfo = new Hashtable();
            memberInfo.Add("姓名", "王大衛");
            memberInfo.Add("年齡", 30);
            memberInfo.Add("身高", 170.5);
            memberInfo.Add("電話", "0912-555-888");
            memberInfo.Add("體重", 88.88);
            memberInfo.Add("Email", "testWang@test.com");
            memberInfo["電話"] ="0988-999-111";
            memberInfo["地址"] ="台南市中西區成功路";
            memberInfo.Remove("身高");
            foreach (DictionaryEntry element  in memberInfo)
            {
                Console.WriteLine("key:{0},value{1}", element.Key, element.Value);
            }
            if (memberInfo.ContainsKey("電話"))
            {
                Console.WriteLine("電話：{0}", memberInfo["電話"]);
            }
            else
            {
                Console.WriteLine("無此欄位");
            }
            string name = Convert.ToString(memberInfo["姓名"]);
            string email = Convert.ToString(memberInfo["Email"]);
            int age = Convert.ToInt32(memberInfo["年齡"]);
            Console.WriteLine($"姓名:{name} 年齡:{age} Email:{email}");

            員工資料集合2.Add(memberInfo);
            foreach (Hashtable item in 員工資料集合2)
            {
                string Name = Convert.ToString(memberInfo["姓名"]);
                string Email = Convert.ToString(memberInfo["Email"]);
                int Age = Convert.ToInt32(memberInfo["年齡"]);
                Console.WriteLine($"姓名:{Name} 年齡:{Age} Email:{Email}");
            }

            Hashtable stockCode2= new Hashtable()
            {
                { "AAPL", "蘋果" },
                {"AMZN","亞馬遜" },
                {"TSLA","特斯拉" },
            };
            stockCode2.Clear();
        }

        private void btn_string_Click(object sender, EventArgs e)
        {
            Console.WriteLine("======================= string 字串的進階操作=======================");
            String strA = "string on \n string one";//String == string 即是基本資料型態也是物件，擁有兩面性
            string strB = @"c:\windos\notes\test.txt";// @就是忽略特殊符號字元
            Console.WriteLine(strA);
            Console.WriteLine(strB);
            string strOne = "Hello World!! C# String World.";
            Console.WriteLine("字串長度:{0}", strOne.Length);
            int index = strOne.IndexOf("World");
            Console.WriteLine("World第一個起始字元intdex:{0}", index);
            String strTwo = strOne.Insert(6, "Hi ");
            Console.WriteLine(strTwo);
            string strThree = strOne.Remove(6);//刪除索引值6以後的所有字元
            Console.WriteLine(strThree);
            string strFour = strOne.Remove(12,3);//刪除索引值12以後3個字元 12 13 14
            Console.WriteLine(strFour);
            string strFive = strOne.Replace("World","Earth");//取代
            Console.WriteLine(strFive);
            string strSix = strOne.Substring(15,2);//截取字串
            Console.WriteLine(strSix);
            //test@domain.com如何擷取後面;
            string strSeven = strOne.ToLower();//轉小寫 ToUpper()轉大寫
            Console.WriteLine(strSeven);
            bool isContain = strSeven.Contains("c#");
            Console.WriteLine("是否有C#字串:{0}", isContain);
            Console.WriteLine("第三個字元:{0}",strOne[2]);

            string strCollection = "珍珠|波霸|QQ|椰果|芋園";
            string[] arrayWords= strCollection.Split('|');
            foreach (string item in arrayWords)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=============================================="); 
        }
    }
}
