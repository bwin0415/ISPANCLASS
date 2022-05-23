using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        //類別變數,本類別可視
        string[] arrayStudentName;//學生姓名陣列
        string[] arrayTempStudentName;//學生姓名暫存陣列
        int[] arrayStudentScore;//學生成績陣列
        int[] arrayTempStudentScore;//學生成績暫存陣列


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 姓名-成績 key-value 索引值 ,鍵值對應

            arrayStudentName = new string[]
            {
             "王小明",
             "陳大貓",
             "林阿霈",
             "張大書",
             "黃忠孝",
            };

            arrayStudentScore = new int[]
            {
                76,
                68,
                54,
                92,
                86
            };

            #endregion       
            
            arrayTempStudentName = new string[5];
            
            arrayTempStudentScore = new int[5];

            lbl_sumoutput.Text = TotalScore(arrayStudentScore).ToString();
            lbl_AvergeOutput.Text = string.Format("{0:F2}", Average(arrayStudentScore));
        }

        private void btn_NameSort_Click(object sender, EventArgs e)
        {
            System.Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
            Name_Sort(arrayTempStudentName);
        }

        private void btn_GradeSort_Click(object sender, EventArgs e)
        {
            Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length); 
            Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.Length);
            Score_Sort(arrayTempStudentName, arrayTempStudentScore);
        }

        private void btn_AllStudentSort_Click(object sender, EventArgs e)
        {
            AllStudentName();
        }

        private void btn_FindAStudent_Click(object sender, EventArgs e)
        {
            if (Txt_NameInput.Text.Length>0)
            {
                int index, num = 0;
                string strMsg = "搜尋結果\n------------------------------\n";
                string strSearchName =Txt_NameInput.Text;
                Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
                Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.Length);
                Score_Sort(arrayTempStudentName, arrayTempStudentScore);
                index = Array.IndexOf(arrayTempStudentName,strSearchName);//搜尋陣列索引值然後回傳，找不到會回傳-1
                if (index==-1)
                {//找不到會回傳-1
                    strMsg += "查無此人";
                }
                else
                {//找到了
                    num =arrayTempStudentScore.Length - index;//求名次
                    strMsg += string.Format($"{arrayTempStudentName[index]}{arrayTempStudentScore[index]}分\n第{num}名");
                }
                lbl_output.Text = strMsg;
            }
            else
            {
                MessageBox.Show("請輸入學生姓名");
            }
        }
        void AllStudentName() 
        {
            string strMsg = "";

            for (int idx = 0; idx  < arrayStudentName.Length ; idx+=1)
            {
                strMsg += string.Format("索引值：{0} 姓名：{1} 成績：{2}\n", idx, arrayStudentName[idx], arrayStudentScore[idx]);
            }

            lbl_output.Text = strMsg;
        }
        void Name_Sort(string[] myArray_StdName) 
        {
            System.Array.Sort(myArray_StdName);//姓名排序-資料結構 看ASCII大小來排序 中文依照筆畫大小

            string strMsg = "";

            for (int idx = 0; idx < myArray_StdName.Length; idx += 1)
            {
                strMsg += string.Format(" 姓名：{0}\n", myArray_StdName[idx]);
            }

            lbl_output.Text = strMsg;
        }

        void Score_Sort(string[] myArray_StdName, int[] myArray_Score)
        {
            Array.Sort(myArray_Score, myArray_StdName);//keys-value sort

            string strMsg = "";
            for (int idx = myArray_StdName.GetUpperBound(0); idx >=0; idx-=1)
            {
                strMsg += string.Format("姓名: {0} 成績: {1}\n", myArray_StdName[idx], myArray_Score[idx]);
            }
            lbl_output.Text = strMsg;
        }

        int TotalScore(int[]MyArrayScore) 
        {
            int total = 0;
            foreach (int myScore in MyArrayScore)
            {
                total += myScore;
            }
            return total;
        }
        double Average(int[] myArrayScore) 
        {
            double avg = 0.0;
            avg = Convert.ToDouble(TotalScore(myArrayScore)) / myArrayScore.Length;
            return avg;
        }


    
    }

    
}
