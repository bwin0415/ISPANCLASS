﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        List<Person> 員工資料集合 = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person.aboutInfo();//靜態方法 不需配置記憶體也能直接使用
           // GlobalVar.目前使用者 = "人資經理-黃小貓";
            lblLoginName.Text ="目前使用者：" +GlobalVar.目前使用者;
        }

        private void btn_memberCreate1_Click(object sender, EventArgs e)
        {
            Person 員工1 = new Person();
            員工1.姓名 = "王大衛";
            員工1.身高 = 170.0f;
            員工1.體重 = 70.0;
            員工1.到職日 = Convert.ToDateTime("2022-4-28");
            員工1.薪資 = 24000.0;
            員工1.部門代號 = (int)MyEnums.Dep.行政處;//(int)<===型態轉換提示 --語法糖
            員工1.Email.data = "DavidWang@test.com";
            員工1.年齡.data = 30;
            員工1.地址 = new AddressInfo("高雄市","前金區","中正路8888號");//結構是valueType

            員工資料集合.Add(員工1);

            員工1.顯示基本資料功能();
        }

        private void btn_memberCreate2_Click(object sender, EventArgs e)
        {
            Person 員工2 = new Person("李瑪莉");
            員工2.身高 = 160.0f;
            員工2.體重 = 50.0;
            員工2.到職日 = new DateTime(2018,7,2,0,0,0);
            員工2.薪資 = 32000.0;
            員工2.部門代號 = (int)MyEnums.Dep.資訊處;
            員工2.Email.data = "MaryLee@test.com";
            員工2.年齡.data = 35;
            員工2.地址.縣市="台南市";
            員工2.地址.行政區="東區";
            員工2.地址.街道門牌="中華路1000號";
            員工資料集合.Add(員工2);

            員工2.顯示基本資料功能();
        }

        private void btn_AllStuff_Click(object sender, EventArgs e)
        {
            string strInfo = "";
            for (int i = 0; i < 員工資料集合.Count; i++)
            {
                Person myPerson = 員工資料集合[i];
                strInfo+= string.Format("{0} {1:F}公分 {2:F} {3:C} {4:d} 年資：{5:F}年 獎金：{6:F}\n",myPerson.姓名,myPerson.身高,myPerson.體重,myPerson.薪資,myPerson.到職日,myPerson.計算年資(),myPerson.依年資計算獎金(1000.0));
            }
            MessageBox.Show(strInfo);
        }


        private void btn_ManagerCreater_Click(object sender, EventArgs e)
        {
            Manager 管理者1 = new Manager();
            管理者1.姓名 = "陳經理";
            管理者1.身高 = 175.0f;
            管理者1.體重 = 65.0;
            管理者1.薪資 = 60000.0;
            管理者1.到職日 = new DateTime(2010, 2, 21, 0, 0, 0);
            管理者1.部門代號 = (int)MyEnums.Dep.業務部;
            管理者1.職稱代號 = (int)MyEnums.Man.經理;
            管理者1.Email.SaveData("ManagerChen@test.com")  ;
            管理者1.年齡.SaveData(45);
            管理者1.地址.縣市 = "台南市";
            管理者1.地址.行政區 = "北區";
            管理者1.地址.街道門牌 = "成功路23號";
            管理者1.顯示基本資料功能();
        }
    }
}