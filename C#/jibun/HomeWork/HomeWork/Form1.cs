using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        int[] Game_Fstzone = new int[38];
        int[] Game_Seczone = new int[8];
        int[] Anss = new int[7];
       
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ans();
            SetValue();
            SetCheckBox();
            lblwinnmsort.Text = "";
            lblwinnum.Text = "";

        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Ans()
        {
            bool IsEqual = Anss[0] == Anss[1] || Anss[0] == Anss[2]|| Anss[0] == Anss[3]|| Anss[0] == Anss[4]|| Anss[0] == Anss[5]
                           || Anss[1] == Anss[2] || Anss[1] == Anss[3] || Anss[1] == Anss[4] || Anss[1] == Anss[5] 
                           || Anss[2] == Anss[3] || Anss[2] == Anss[4] || Anss[2] == Anss[5]
                           || Anss[3] == Anss[4] || Anss[3] == Anss[5] 
                           || Anss[4] == Anss[5];
            do
            {
                for (int i = 0; i < 6; i++)
                {
                    Anss[i] = rnd.Next(1, 39);
                }
            } while (!IsEqual);
            Anss[6] = rnd.Next(1, 8);
            
        }
        void SetValue() 
        {
            for (int i = 0; i < Game_Fstzone.Length; i++)
            {
                Game_Fstzone[i] = i+1;
            }
            for (int i = 0; i < Game_Seczone.Length; i++)
            {
                Game_Seczone[i] = i+1;
            }
        }
        void SetCheckBox()
        {
            CHKBL_1.MultiColumn = true;//水平顯示
            CHKBL_1.ColumnWidth = 45;//水平寬度
            CHKBL_2.MultiColumn = true;//水平顯示
            CHKBL_2.ColumnWidth = 45;//水平寬度
            for (int i = 0; i < Game_Fstzone.Length; i++)
            {
                CHKBL_1.Items.Add(Game_Fstzone[i].ToString());
            }
            for (int i = 0; i < Game_Seczone.Length; i++)
            {
                CHKBL_2.Items.Add(Game_Seczone[i].ToString());
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            lblwinnmsort.Text = "";
            lblwinnum.Text = "";
            int fstCount = 0, secCount = 0;
            for (int i = 0; i < CHKBL_1.Items.Count; i++)
            {
                if (CHKBL_1.GetItemChecked(i))
                {
                    fstCount++;
                }
            }
            for (int i = 0; i < CHKBL_2.Items.Count; i++)
            {
                if (CHKBL_2.GetItemChecked(i))
                {
                    secCount++;
                }
            }
            if (fstCount != 6 && secCount != 1)
            {

                MessageBox.Show("第一區請選擇六個號碼\n第二區請選擇一個號碼");
                return;
            }
            else if (fstCount!=6) 
            {
                MessageBox.Show("第一區請選擇六個號碼");
                return;
            }
            else if (secCount!=1)
            {
                MessageBox.Show("第二區請選擇一個號碼");
                return;
            }

            string ss="";
            int[] Wonlot = Anss;
            int[] Wonlot_Sort = Anss;
            List<int> Sortlist = new List<int>(Wonlot_Sort);
            Sortlist.RemoveAt(6);
            Wonlot_Sort = Sortlist.ToArray();
            Array.Sort(Wonlot_Sort);
            
            ss = string.Format("依照順序開出的第一區號碼{0},{1},{2},{3},{4},{5},第二區號碼為{6}", Wonlot[0], Wonlot[1], Wonlot[2], Wonlot[3], Wonlot[4], Wonlot[5], Wonlot[6]);
            lblwinnum.Text += ss;
            ss = string.Format("由小到大開出的第一區號碼{0},{1},{2},{3},{4},{5},第二區號碼為{6}", Wonlot_Sort[0], Wonlot_Sort[1], Wonlot_Sort[2], Wonlot_Sort[3], Wonlot_Sort[4], Wonlot_Sort[5], Wonlot[6]);
            lblwinnmsort.Text += ss;

            int[] playernum = new int[7];
            int count=0;
            string[] s =new string[7];
            string sss = "";
            for (int i = 0; i < CHKBL_1.Items.Count; i++)
                {
                    if (CHKBL_1.GetItemChecked(i))
                    {
                       
                        sss += $"{CHKBL_1.Items[i]},";
                    }
                }
            for (int i = 0; i < CHKBL_2.Items.Count; i++)
                {
                    if (CHKBL_2.GetItemChecked(i))
                    {
                       
                        sss += $"{CHKBL_2.Items[i]}";
                    }
                }
            s = sss.Split(',');

            for (int i = 0; i <7; i++)
            {
                playernum[i] = Convert.ToInt32(s[i]);
            }
            for (int i = 0; i < s.Length; i++)
            {
                //監測是否有放入數字
                Console.WriteLine(playernum[i]);
            }
            for (int i = 0; i < 6; i++)
            {
                
                for (int j = 0; j < 6; j++)
                {
                    if (Wonlot_Sort[i] == playernum[j])
                    {
                        count++;
                    }
                }
            }
            
            Console.WriteLine(count);
            bool Issame = playernum[6] == Wonlot[6];
 
            if (count==6 && Issame)
            {
                MessageBox.Show("恭喜你中了頭獎，財富自由了");
            }
            else if (count==6)
            {
                MessageBox.Show("恭喜你中了貳獎，頭期款有著落了");
            }
            else if (count==5 && Issame)
            {
                MessageBox.Show("恭喜你中了三獎，與大獎插身而過");
            }
            else if (count==5 )
            {
                MessageBox.Show("恭喜你中了四獎，能暫時休息");
            }
            else if (count==4 && Issame)
            {
                MessageBox.Show("恭喜你中了五獎，不多也不少");
            }
            else if (count==4)
            {
                MessageBox.Show("恭喜你中了六獎，全部再ALL IN 下去");
            }
            else if (count==3 && Issame)
            {
                MessageBox.Show("恭喜你中了七獎，可以了別買了");
            }
            else if (count==2&& Issame)
            {
                MessageBox.Show("恭喜你中了八獎，買點吃的犒賞自己吧");
            }
            else if (count==3)
            {
                MessageBox.Show("恭喜你中了九獎，買點吃的犒賞自己吧");
            }
            else if (count==1 && Issame)
            {
                MessageBox.Show("恭喜你中了普獎，至少你有中");
            }
            else
            {
                MessageBox.Show("繼續打拼啦");
            }

        }
        private void btn_Autochoose_Click(object sender, EventArgs e)
        {
  
            int count=0 ,a=0,b=0;
            int[] autoPlayerNum = new int[6];
            int autoPlayerNumsec = 0;
            bool IsEqual =true ;
           // int[] autoPlayerNumCH =new int[] ;
            
            /*bool IsEqual = 
                autoPlayerNum[0] == autoPlayerNum[1] || autoPlayerNum[0] == autoPlayerNum[2] || autoPlayerNum[0] == autoPlayerNum[3] || autoPlayerNum[0] == autoPlayerNum[4] || autoPlayerNum[0] == autoPlayerNum[5]
               || autoPlayerNum[1] == autoPlayerNum[2] || autoPlayerNum[1] == autoPlayerNum[3] || autoPlayerNum[1] == autoPlayerNum[4] || autoPlayerNum[1] == autoPlayerNum[5]
               || autoPlayerNum[2] == autoPlayerNum[3] || autoPlayerNum[2] == autoPlayerNum[4] || autoPlayerNum[2] == autoPlayerNum[5]
               || autoPlayerNum[3] == autoPlayerNum[4] || autoPlayerNum[3] == autoPlayerNum[5]
               || autoPlayerNum[4] == autoPlayerNum[5];*/
           
           // autoPlayerNumCH = autoPlayerNum.Distinct().ToArray();
            Clear();
            do
            {
                count = 0;

                for (int i = 0; i < 5; i++)
                {
                    a = autoPlayerNum[i];
                    for (int j = i + 1; j < 6; j++)
                    {
                        b = autoPlayerNum[j];
                        if (a == b)
                        {
                            IsEqual = true;
                            break;
                        }
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    autoPlayerNum[i] = rnd.Next(1, 38);
                    count++;

                }

            } while (!IsEqual);
            


            autoPlayerNumsec = rnd.Next(1,8);
            for (int i = 0; i < count; i++)
            {
                CHKBL_1.SetItemChecked(autoPlayerNum[i]-1, true);
            }
                CHKBL_2.SetItemChecked(autoPlayerNumsec, true);
            
        }
        void Clear()
        {
            for (int i = 0; i < CHKBL_1.Items.Count; i++)
            {
                CHKBL_1.SetItemChecked(i, false);
            }
            for (int i = 0; i < CHKBL_2.Items.Count; i++)
            {
                CHKBL_2.SetItemChecked(i, false);
            }
            
        }

       
    }
}
