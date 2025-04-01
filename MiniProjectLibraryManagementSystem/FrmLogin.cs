using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectLibraryManagementSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("คุณต้องการออกจากโปรแกรมใช่หรือไม่?", "ปิดโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void lbBacktoLogin_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            Hide();
        }



        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนอีเมล์ด้วย");
            }
            else if (tbPassword.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนรหัสผ่านด้วย");
            }
            else
            {


                //ติดต่อ DB
                SqlConnection conn = new SqlConnection(ShareData.conStr);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                string strSql = "SELECT * FROM user_tb WHERE " +
                                "userEmail = @userEmail AND " +
                                "userPassword = @userPassword";

                //สร้าง command
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = strSql;
                sqlCommand.Transaction = sqlTransaction;

                //กำหนดค่า parameter
                sqlCommand.Parameters.AddWithValue("@userEmail", tbEmail.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@userPassword", tbPassword.Text.Trim());

                //สั่งให้ command ทำงาน (Select)
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                conn.Close();

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    ShareData.userId = Convert.ToInt32(dt.Rows[0]["userId"]);
                    ShareData.userFullName = dt.Rows[0]["userFullName"].ToString();
                    ShareData.userEmail = dt.Rows[0]["userEmail"].ToString();
                    ShareData.userPassword = dt.Rows[0]["userPassword"].ToString();
                    ShareData.userImage = (byte[])dt.Rows[0]["userImage"];
                    ShareData.userPhone = dt.Rows[0]["userPhone"].ToString();
                    ShareData.userType = dt.Rows[0]["userType"].ToString();

                    //เปิดหน้าหลัก
                    //ShareData.showWarningMSG("เข้าสู่ระบบสำเร็จ");
                    FrmMainMenu frmMainMenu = new FrmMainMenu();
                    frmMainMenu.Show();
                    this.Hide();
                }
                else
                {
                    ShareData.showWarningMSG("อีเมล์หรือรหัสผ่านไม่ถูกต้อง");
                }
            }


        }
    }
    }

