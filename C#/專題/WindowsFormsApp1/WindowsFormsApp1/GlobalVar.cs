using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class GlobalVar
    {
        public static string User = "";
        public static int UserId = 0;
        public static int UserPoint = 0;
        public static 會員註冊 memberRigister;
        public static txtOrdercount productManagement;
        public static 結帳 cashier;
        public static 購物單 Cart;
        public static 會員登入 memberLogin;
        public static ListView.ListViewItemCollection lvItemCollection;
        public static void CloseAllForm ()
        {

            if (productManagement!=null)
            {
                productManagement.Close();
            }
            if (cashier != null)
            { 
                cashier.Close(); 
            }
            if (Cart!=null)
            {
                Cart.Close();
            }
            
            
        }

    }
}
