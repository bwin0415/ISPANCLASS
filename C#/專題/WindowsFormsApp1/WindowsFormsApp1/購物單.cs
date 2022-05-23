using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class 購物單 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string myDBConnctionString = "";
        public 購物單()
        {
            InitializeComponent();
        }

        private void 購物單_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Homework";
            scsb.IntegratedSecurity = true;
            myDBConnctionString = scsb.ToString();
            lblName.Text = "哈囉，" + GlobalVar.User;
        }
    }
}
