using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectLibraryManagementSystem
{
    public partial class FrmRegister : Form
    {
        byte[] userImg;
        public FrmRegister()
        {
            InitializeComponent();
        }

        private bool IsEmailExists(string email)
        {
            using (SqlConnection conn = new SqlConnection(ShareData.conStr))
            {
                conn.Open();

                string strSql = "SELECT COUNT(*) FROM user_tb WHERE userEmail = @userEmail";

                SqlCommand sqlCommand = new SqlCommand(strSql, conn);
                sqlCommand.Parameters.AddWithValue("@userEmail", email);

                int count = (int)sqlCommand.ExecuteScalar();

                return count > 0;
            }
        }

        private bool IsPhoneExists(string phone)
        {
            using (SqlConnection conn = new SqlConnection(ShareData.conStr))
            {
                conn.Open();

                string strSql = "SELECT COUNT(*) FROM user_tb WHERE userPhone = @userPhone";

                SqlCommand sqlCommand = new SqlCommand(strSql, conn);
                sqlCommand.Parameters.AddWithValue("@userPhone", phone);

                int count = (int)sqlCommand.ExecuteScalar();

                return count > 0;
            }
        }

        private void lbBacktoLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Hide();
        }

        private void tbPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนตัวอักษรที่ไม่ใช่ตัวเลข
            }

        }

        private void btSelectImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbUserImg.Image = Image.FromFile(ofd.FileName);

                string extFile = Path.GetExtension(ofd.FileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    if (extFile == ".jpg" || extFile == ".jpeg")
                    {
                        pbUserImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else
                    {
                        pbUserImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    userImg = ms.ToArray();
                }
            }

        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (tbFullName.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนชื่อด้วย");
            }
            else if (tbEmail.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนอีเมล์ด้วย");
            }
            else if (!tbEmail.Text.Trim().Contains("@"))
            {
                ShareData.showWarningMSG("ป้อนอีเมล์ให้ถูกต้องด้วย");
            }
            else if (tbPassword.Text.Trim().Length < 6)
            {
                ShareData.showWarningMSG("รหัสผ่านต้องมากกว่า 6 ตัวอักษร");
            }
            else if (tbConfirmPassword.Text.Trim() != tbPassword.Text.Trim())
            {
                ShareData.showWarningMSG("รหัสผ่านต้องตรงกัน");
            }
            else if (userImg == null)
            {
                ShareData.showWarningMSG("เลือกรูปด้วย");
            }
            else if (tbPhoneNum.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนเบอร์โทรด้วย");
            }
            else if (!tbEmail.Text.Trim().EndsWith("@sau.ac.th") && cbbUserType.SelectedIndex == 1)
            {
                ShareData.showWarningMSG("คุณไม่มีสิทธิ์เลือกผู้ดูแลระบบ");
                return; // หยุดการทำงาน ไม่ให้บันทึกข้อมูล
            }
            else if (IsEmailExists(tbEmail.Text.Trim()))
            {
                ShareData.showWarningMSG("อีเมลนี้มีผู้ใช้แล้ว");
                return;
            }

            else if (IsPhoneExists(tbPhoneNum.Text.Trim()))
            {
                ShareData.showWarningMSG("เบอร์โทรศัพท์นี้มีผู้ใช้แล้ว");
                return;
            }

            else
            {
                //ส่งข้อมูลไปบันทึก
                //ติดต่อ DB
                SqlConnection conn = new SqlConnection(ShareData.conStr);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                //คำสั่ง SQL
                string strSql = "INSERT INTO user_tb " +
                    "(userFullName, userEmail, userPassword, userImage, userType, userPhone) " +
                    "VALUES " +
                    "(@userFullName, @userEmail, @userPassword, @userImage, @userType, @userPhone)";
                //สร้าง command
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = strSql;
                sqlCommand.Transaction = sqlTransaction;

                //กำหนดค่า parameter
                sqlCommand.Parameters.AddWithValue("@userFullName", tbFullName.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@userEmail", tbEmail.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@userPassword", tbPassword.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@userImage", userImg);
                sqlCommand.Parameters.AddWithValue("@userType", cbbUserType.SelectedIndex == 0 ? "User" : "Admin");
                sqlCommand.Parameters.AddWithValue("@userPhone", tbPhoneNum.Text.Trim());


                //เริ่มบันทึก

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    sqlTransaction.Commit();
                    conn.Close();
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.Show();
                    Hide();
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();
                    conn.Close();
                    ShareData.showWarningMSG("ไม่สามารถบันทึกข้อมูลได้ ( " + ex.Message + " )");
                }
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            btCancel.PerformClick();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbFullName.Text = "";
            tbEmail.Text = "";
            tbPhoneNum.Text = "";
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
            pbUserImg.Image = null;
            cbbUserType.SelectedIndex = 0;

        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {

            TextBox tb = (TextBox)sender;
            int showToolTipTime = 3000;

            ToolTip tt = new ToolTip();
            tt.Show("รหัสผ่านต้อง 6 ตัวขึ้นไป", tb, 20, 20, showToolTipTime);
        }

        private void tbConfirmPassword_Enter(object sender, EventArgs e)
        {

            TextBox tb = (TextBox)sender;
            int showToolTipTime = 3000;

            ToolTip tt = new ToolTip();
            tt.Show("รหัสผ่านต้อง 6 ตัวขึ้นไป", tb, 20, 20, showToolTipTime);
        }

        
    }
}
