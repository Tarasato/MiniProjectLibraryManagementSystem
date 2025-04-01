using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectLibraryManagementSystem
{
    internal class ShareData
    {
        public static String conStr = "Server=tarasato.thddns.net,1433;Database=library_management_db;User Id=LMS;Password=Sql1433;";

        public static int userId;
        public static string userType = "", userFullName, userEmail, userPhone, userPassword;
        public static byte[] userImage;
        public static void showWarningMSG(string msg)
        {
            MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static List<string> bookTypeNames = new List<string>
        {
            "การศึกษา",            // bookTypeId = 1
            "บันเทิง",             // bookTypeId = 2
            "วรรณกรรมและนวนิยาย",  // bookTypeId = 3
            "ประวัติศาสตร์และวัฒนธรรม",  // bookTypeId = 4
            "ธุรกิจและการเงิน",    // bookTypeId = 5
            "จิตวิทยาและพัฒนาตนเอง", // bookTypeId = 6
            "สุขภาพและโภชนาการ",   // bookTypeId = 7
            "เทคโนโลยีและวิทยาศาสตร์", // bookTypeId = 8
            "ศาสนาและปรัชญา",     // bookTypeId = 9
            "บ้านและสวน",          // bookTypeId = 10
            "แม่และเด็ก",           // bookTypeId = 11
            "ท่องเที่ยวและไลฟ์สไตล์" // bookTypeId = 12
        };

    }
}
