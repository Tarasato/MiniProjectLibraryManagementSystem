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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniProjectLibraryManagementSystem
{
    public partial class FrmBookBorrowHistories : Form
    {
        public FrmBookBorrowHistories()
        {
            InitializeComponent();
        }
        //++++++++++++++++++++++++++++++++ Method And Variable +++++++++++++++++++++++++++++++++++++++++++++++++

        private void LoadData()
        {
            // เชื่อมต่อฐานข้อมูล
            using (SqlConnection connection = new SqlConnection(ShareData.conStr))
            {
                try
                {
                    connection.Open();

                    // สร้าง SQL Query โดยใช้ JOIN และกรองข้อมูลตาม userId ของผู้ที่ล็อกอิน
                    string query = @"
                SELECT 
                    bbh.borrowId AS 'รหัสยืม',
                    b.bookName AS 'ชื่อหนังสือ',
                    u1.userFullName AS 'ผู้ยืม',
                    CONVERT(VARCHAR, bbh.borrowDate, 103) AS 'วันที่ยืม',
                    CONVERT(VARCHAR, bbh.returnDate, 103) AS 'วันที่คืน',  
                    u2.userFullName AS 'ผู้ทำเรื่องยืม',
                    u3.userFullName AS 'ผู้ทำเรื่องคืน'
                FROM book_borrow_history_tb bbh
                JOIN book_tb b ON bbh.iSbn = b.iSbn
                JOIN user_tb u1 ON bbh.userId = u1.userId
                JOIN user_tb u2 ON bbh.borrowTransactionmakerId = u2.userId
                LEFT JOIN user_tb u3 ON bbh.returnTransactionmakerId = u3.userId
                WHERE bbh.userId = @LoggedInUserId"; // กรองข้อมูลตาม userId ของผู้ที่ล็อกอิน

                    SqlCommand command = new SqlCommand(query, connection);
                    // เพิ่ม parameter สำหรับ userId ของผู้ที่ล็อกอิน
                    command.Parameters.AddWithValue("@LoggedInUserId", ShareData.userId);

                    // สร้าง SqlDataAdapter และ DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // เติมข้อมูลลงใน DataTable
                    adapter.Fill(dataTable);

                    // แสดงข้อมูลใน ListView
                    lsBookBorrow.Columns.Clear();
                    lsBookBorrow.Items.Clear();

                    // เพิ่มคอลัมน์
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        lsBookBorrow.Columns.Add(column.ColumnName);
                    }
                    int listViewWidth = lsBookBorrow.ClientSize.Width;

                    // ตั้งค่า ColumnWidth
                    lsBookBorrow.Columns[0].Width = (int)(0.10 * listViewWidth); // 10%
                    lsBookBorrow.Columns[1].Width = (int)(0.20 * listViewWidth); // 20%
                    lsBookBorrow.Columns[2].Width = (int)(0.15 * listViewWidth); // 15%
                    lsBookBorrow.Columns[3].Width = (int)(0.14 * listViewWidth); // 12%
                    lsBookBorrow.Columns[4].Width = (int)(0.14 * listViewWidth); // 12%
                    lsBookBorrow.Columns[5].Width = (int)(0.14 * listViewWidth); // 15%
                    lsBookBorrow.Columns[6].Width = (int)(0.14 * listViewWidth); // 16%

                    // เพิ่มรายการ
                    foreach (DataRow row in dataTable.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        for (int i = 1; i < dataTable.Columns.Count; i++)
                        {
                            item.SubItems.Add(row[i].ToString());
                        }
                        lsBookBorrow.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
            }
        }


        //+++++++++++++++++++++++++++++++ End of Method And Variable +++++++++++++++++++++++++++++++++++++++++++

        //FormLoad
        private void FrmBookBorrowHistories_Load(object sender, EventArgs e)
        {
            btCancel.PerformClick();
            cbUserId.Enabled = true;
            if (ShareData.userType == "User") {
                tbUserId.Enabled = false;
                tbUserId.Text = ShareData.userId.ToString();
            }
        }

        //+++++++++++++++++++++++++++++++++++++++ BUTTON FUNC +++++++++++++++++++++++++++++++++++++++++++++++++++


        // btSearch_Click =======================================
        void btSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ShareData.conStr))
            {
                if (cbUserId.Checked == false && cbdtpBorrow.Checked == false)
                {
                    ShareData.showWarningMSG("เลือกรูปแบบการค้นหาด้วย");
                }
                else
                {
                    try
                    {
                        connection.Open();

                        string query = @"
                    SELECT
                        bbh.borrowId AS 'หมายเลขการยืม',
                        b.bookName AS 'ชื่อหนังสือ',
                        u1.userFullName AS 'ผู้ยืม',
                        FORMAT(bbh.borrowDate, 'dd/MM/yyyy', 'th-TH') AS 'วันที่ยืม',
                        FORMAT(bbh.returnDate, 'dd/MM/yyyy', 'th-TH') AS 'วันที่คืน',
                        u2.userFullName AS 'ผู้ทำเรื่องยืม',
                        u3.userFullName AS 'ผู้ทำเรื่องคืน'
                    FROM book_borrow_history_tb bbh
                    JOIN book_tb b ON bbh.iSbn = b.iSbn
                    JOIN user_tb u1 ON bbh.userId = u1.userId
                    JOIN user_tb u2 ON bbh.borrowTransactionmakerId = u2.userId
                    LEFT JOIN user_tb u3 ON bbh.returnTransactionmakerId = u3.userId
                    WHERE 1=1";

                        // เงื่อนไขค้นหาตามไอดีผู้ยืม
                        if (cbUserId.Checked)
                        {
                            if (string.IsNullOrEmpty(tbUserId.Text))
                            {
                                ShareData.showWarningMSG("กรุณาป้อนไอดีผู้ยืม");
                                return;
                            }
                            else
                            {
                                query += " AND u1.userId = @BorrowerId";
                            }
                        }
                        else
                        {
                            // ถ้าไม่ได้เลือกค้นหาด้วยไอดีผู้ยืม, ให้ค้นหาตาม userId ของผู้ที่ล็อกอินอยู่
                            query += " AND bbh.userId = @LoggedInUserId";
                        }

                        // เงื่อนไขค้นหาตามเดือนและปี
                        if (cbdtpBorrow.Checked)
                        {
                            query += " AND MONTH(bbh.borrowDate) = @Month AND YEAR(bbh.borrowDate) = @Year";
                        }

                        SqlCommand command = new SqlCommand(query, connection);

                        // เพิ่ม parameters สำหรับไอดีผู้ยืม (ถ้ามีการค้นหาด้วย userId)
                        if (cbUserId.Checked && !string.IsNullOrEmpty(tbUserId.Text))
                        {
                            // ตรวจสอบว่า tbUserId เป็นตัวเลขหรือไม่
                            if (int.TryParse(tbUserId.Text, out int userId))
                            {
                                command.Parameters.AddWithValue("@BorrowerId", userId);
                            }
                            else
                            {
                                ShareData.showWarningMSG("ไอดีผู้ยืมต้องเป็นตัวเลข");
                                return;
                            }
                        }

                        // เพิ่ม parameter สำหรับ userId ของผู้ที่ล็อกอินอยู่
                        if (!cbUserId.Checked)
                        {
                            command.Parameters.AddWithValue("@LoggedInUserId", ShareData.userId); // ผู้ใช้งานที่ล็อกอิน
                        }

                        // เพิ่ม parameters สำหรับเดือนและปี
                        if (cbdtpBorrow.Checked)
                        {
                            command.Parameters.AddWithValue("@Month", dtpBorrow.Value.Month);
                            command.Parameters.AddWithValue("@Year", dtpBorrow.Value.Year);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // ตรวจสอบผลลัพธ์ว่ามีข้อมูลหรือไม่
                        if (dataTable.Rows.Count == 0)
                        {
                            ShareData.showWarningMSG("ไม่พบข้อมูล");
                        }
                        else
                        {
                            // แสดงข้อมูลใน ListView
                            lsBookBorrow.Columns.Clear();
                            lsBookBorrow.Items.Clear();

                            // เพิ่มคอลัมน์
                            foreach (DataColumn column in dataTable.Columns)
                            {
                                lsBookBorrow.Columns.Add(column.ColumnName);
                            }

                            int listViewWidth = lsBookBorrow.ClientSize.Width;

                            // ตั้งค่า ColumnWidth
                            lsBookBorrow.Columns[0].Width = (int)(0.10 * listViewWidth); // 10%
                            lsBookBorrow.Columns[1].Width = (int)(0.20 * listViewWidth); // 20%
                            lsBookBorrow.Columns[2].Width = (int)(0.15 * listViewWidth); // 15%
                            lsBookBorrow.Columns[3].Width = (int)(0.14 * listViewWidth); // 12%
                            lsBookBorrow.Columns[4].Width = (int)(0.14 * listViewWidth); // 12%
                            lsBookBorrow.Columns[5].Width = (int)(0.14 * listViewWidth); // 15%
                            lsBookBorrow.Columns[6].Width = (int)(0.14 * listViewWidth); // 16%

                            // เพิ่มรายการ
                            foreach (DataRow row in dataTable.Rows)
                            {
                                ListViewItem item = new ListViewItem(row[0].ToString());
                                for (int i = 1; i < dataTable.Columns.Count; i++)
                                {
                                    item.SubItems.Add(row[i].ToString());
                                }
                                lsBookBorrow.Items.Add(item);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                    }
                }
            }
        }




        // btCancel_Click =======================================
        private void btCancel_Click(object sender, EventArgs e)
        {
            cbdtpBorrow.Checked = false;
            cbUserId.Checked = false;

            tbUserId.Clear();
            tbUserId.Enabled = false;

            dtpBorrow.Value = DateTime.Now;
            dtpBorrow.Enabled = false;

            if (ShareData.userType =="Admin")
            {
                cbUserId.Enabled = true;
            }
            else
            {
                cbUserId.Enabled = false;
            }

            LoadData();
        } 
        // btMainMenu_Click ======================================
        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            this.Hide();
        }


        //++++++++++++++++++++++++++++++++++++++++ CHECKBOX +++++++++++++++++++++++++++++++++++++++++++++++++++++

        //cbUserId_Click======================================
        private void cbUserId_Click(object sender, EventArgs e)
        {
            if (cbUserId.Checked) {
                if (ShareData.userType == "Admin")
                {
                    tbUserId.Enabled = true;
                }
                else {
                    tbUserId.Enabled = false;
                }
            }
            else
            {
                if (ShareData.userType == "User") {
                    return;
                }
                tbUserId.Clear();
                tbUserId.Enabled = false;
            }
        }
        //cbdtpBorrow_Click======================================
        private void cbdtpBorrow_Click(object sender, EventArgs e)
        {
            if (cbdtpBorrow.Checked)
            {
                dtpBorrow.Enabled = true;
            }
            else
            {
                dtpBorrow.Enabled = false;
                dtpBorrow.Value = DateTime.Now;
            }
        }

        //+++++++++++++++++++++++++++++++++++++++ KEY PRESS +++++++++++++++++++++++++++++++++++++++++++++++++++++

        //tbUserId_KeyPress===============================================
        private void tbUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block the keypress
            }
        }

        private void tbUserId_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // หากไม่ใช่ตัวเลขหรือปุ่ม Backspace จะไม่ให้พิมพ์
                e.Handled = true;
            }
        }
    }
}
