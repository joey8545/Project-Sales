using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace 專案練習2
{
    public class GlobalVar
    {
        public static List<ArrayList> list訂購品項集合= new List<ArrayList>();
        public static string strDBConnectionString = "";
        public static bool is登入成功=false;
        public static string 使用者名稱 = "";
        public static string 使用者電話 = "";
        public static int 使用者id = 0;
        public static string 使用者權限 = "";
        public static int 訂單編號 = 0;
        public static string image_dir = @"C:\Users\joey4\Desktop\joey\C#\Pic";
        public static int 模式 = 0;
        public static int 客服ID = 0;
    }
}
