using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectLibraryManagementSystem
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            if (ShareData.userType == "User") {
                btBookManage.Enabled = false;
                btBookTranBt.Enabled = false;
            }

            // โหลดข้อมูลจาก ShareData ที่ได้จาก FrmLogin
            try
            {
                // Display user information from ShareData
                lbIDcard.Text = ShareData.userId.ToString();
                lbName.Text = ShareData.userFullName;
                lbUserType.Text = ShareData.userType;

                // Load profile image if it exists
                if (ShareData.userImage != null && ShareData.userImage.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(ShareData.userImage))
                    {
                        pbProfile.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูล: " + ex.Message);
            }
        }

        private void btBookManage_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่าเป็นผู้ดูแลระบบ (admin) หรือไม่
            if (ShareData.userType.ToLower() == "admin")
            {
                FrmBookManage frmBookManage = new FrmBookManage(); // ถ้ามีฟอร์มนี้
                frmBookManage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("คุณไม่มีสิทธิ์เข้าถึงหน้านี้ (สำหรับผู้ดูแลระบบเท่านั้น)");
            }
        }

        private void btBookTranBt_Click(object sender, EventArgs e)
        {
            FrmBookTransaction frmBookTransaction = new FrmBookTransaction(); // ถ้ามีฟอร์มนี้
            frmBookTransaction.Show();
            this.Hide();
        }

        private void btBookListBt_Click(object sender, EventArgs e)
        {
            FrmBookList frmBookList = new FrmBookList(); // ถ้ามีฟอร์มนี้
            frmBookList.Show();
            this.Hide();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            FrmEditProfile frmEditProfile = new FrmEditProfile(); // ถ้ามีฟอร์มนี้
            frmEditProfile.Show();
            this.Hide();
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close(); // ปิด FrmMainMenu
        }

        private void btBookBorrowHistories_Click(object sender, EventArgs e)
        {
            FrmBookBorrowHistories frmBookBorrowHistories = new FrmBookBorrowHistories(); // ถ้ามีฟอร์มนี้
            frmBookBorrowHistories.Show();
            this.Hide();
        }
    }
}