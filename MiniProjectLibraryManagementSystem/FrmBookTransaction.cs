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
    public partial class FrmBookTransaction : Form
    {
        public FrmBookTransaction()
        {
            InitializeComponent();
        }

        private void btSearchAll_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            string strSql;
            // เรียกข้อมูลหนังสือทั้งหมด
            SqlConnection conn = new SqlConnection(ShareData.conStr);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();



            if (cdNotReturnYet.Checked == true)
            {
                strSql = "SELECT borrowId, iSbn, userId, borrowDate, returnSchedule, returnDate, borrowStatus, borrowTransactionmakerId, returnTransactionmakerId FROM book_borrow_history_tb WHERE returnTransactionmakerId IS NULL";
            }
            else
            {
                strSql = "SELECT borrowId, iSbn, userId, borrowDate, returnSchedule, returnDate, borrowStatus, borrowTransactionmakerId, returnTransactionmakerId FROM book_borrow_history_tb";
            }

            SqlTransaction sqlTransaction = conn.BeginTransaction();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = strSql;
            sqlCommand.Transaction = sqlTransaction;

            // ดึงข้อมูลจากฐานข้อมูลและแสดงใน ListView
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                conn.Close();

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                lsBook.Items.Clear();

                int orderIndex = 1;
                foreach (DataRow row in dt.Rows)
                {
                    // สร้าง ListViewItem สำหรับแต่ละแถว
                    ListViewItem item = new ListViewItem(orderIndex.ToString());
                    item.SubItems.Add(row["borrowId"].ToString());
                    item.SubItems.Add(row["userId"].ToString());
                    item.SubItems.Add(row["iSbn"].ToString());
                    item.SubItems.Add(row["borrowStatus"].ToString());

                    // เพิ่ม item ลงใน ListView
                    lsBook.Items.Add(item);

                    orderIndex++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string strSql = "";
            // ค้นหาการยืมจากหมายเลขสมาชิก
            if (rdiSbn.Checked)
            {
                if (tbSearch.Text == "")
                {
                    ShareData.showWarningMSG("กรุณากรอกหมายเลข ISBN หนังสือ");
                    return;
                }
                else if (tbSearch.Text.Trim().Length < 13)
                {
                    ShareData.showWarningMSG("กรุณาป้อนหมายเลข ISBN ให้ครบ 13 หลัก");
                    return;
                }

                if (cdNotReturnYet.Checked == true)
                {
                    strSql = strSql = "SELECT borrowId, iSbn, userId, borrowDate, returnSchedule, returnDate, borrowStatus, borrowTransactionmakerId, returnTransactionmakerId FROM book_borrow_history_tb WHERE returnTransactionmakerId IS NULL AND iSbn = @search";
                }
                else
                {
                    strSql = "SELECT borrowId, iSbn, userId, borrowDate, returnSchedule, returnDate, borrowStatus, borrowTransactionmakerId, returnTransactionmakerId FROM book_borrow_history_tb WHERE iSbn = @search";
                }
            }
            else if (rdUserId.Checked)
            {
                if (tbSearch.Text == "")
                {
                    ShareData.showWarningMSG("กรุณากรอก UserID สมาชิก");
                    return;
                }

                if (cdNotReturnYet.Checked == true)
                {
                    strSql = strSql = "SELECT borrowId, iSbn, userId, borrowDate, returnSchedule, returnDate, borrowStatus, borrowTransactionmakerId, returnTransactionmakerId FROM book_borrow_history_tb WHERE returnTransactionmakerId IS NULL AND userId = @search";
                }
                else
                {
                    strSql = "SELECT borrowId, iSbn, userId, borrowDate, returnSchedule, returnDate, borrowStatus, borrowTransactionmakerId, returnTransactionmakerId FROM book_borrow_history_tb WHERE userId = @search";
                }
            }
            else if (rdborrowId.Checked)
            {
                if (tbSearch.Text == "")
                {
                    ShareData.showWarningMSG("กรุณากรอกรหัสการยืม");
                    return;
                }

                if (cdNotReturnYet.Checked == true)
                {
                    strSql = strSql = "SELECT borrowId, iSbn, userId, borrowDate, returnSchedule, returnDate, borrowStatus, borrowTransactionmakerId, returnTransactionmakerId FROM book_borrow_history_tb WHERE returnTransactionmakerId IS NULL AND borrowId = @search";
                }
                else
                {
                    strSql = "SELECT borrowId, iSbn, userId, borrowDate, returnSchedule, returnDate, borrowStatus, borrowTransactionmakerId, returnTransactionmakerId FROM book_borrow_history_tb WHERE borrowId = @search";
                }
            }
            SqlConnection conn = new SqlConnection(ShareData.conStr);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            string searchText = tbSearch.Text.Trim();




            SqlTransaction sqlTransaction = conn.BeginTransaction();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = strSql;
            sqlCommand.Transaction = sqlTransaction;
            sqlCommand.Parameters.AddWithValue("@search", searchText);

            // ดึงข้อมูลจากฐานข้อมูลและแสดงใน ListView
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                conn.Close();

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                lsBook.Items.Clear();

                int orderIndex = 1;
                foreach (DataRow row in dt.Rows)
                {
                    // สร้าง ListViewItem สำหรับแต่ละแถว
                    ListViewItem item = new ListViewItem(orderIndex.ToString());
                    item.SubItems.Add(row["borrowId"].ToString());
                    item.SubItems.Add(row["userId"].ToString());
                    item.SubItems.Add(row["iSbn"].ToString());
                    item.SubItems.Add(row["borrowStatus"].ToString());

                    // เพิ่ม item ลงใน ListView
                    lsBook.Items.Add(item);

                    orderIndex++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdUserId.Checked)
            {
                tbiSbn.Enabled = true;
                tbiSbn.Text = "";
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rdiSbn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdiSbn.Checked)
            {
                tbSearch.MaxLength = 13;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbuserId.Enabled = false;
            tbiSbn.Enabled = false;
            dtpBorrowDate.Enabled = false;
            dtpReturnDate.Enabled = false;
            cbReturn.Enabled = false;
            btEdit.Enabled = false;
            btSaveAddEdit.Enabled = false;
            btCancel.Enabled = false;
            btAdd.Enabled = true;
            tbborrowStatus.Enabled = false;
            tbuserId.Text = "";
            tbiSbn.Text = "";
            tbborrowStatus.Text = "";
            lbBorrowId.Text = "";
            dtpBorrowDate.Value = DateTime.Now;
            dtpReturnDate.Value = DateTime.Now;
        }

        private void FrmBookTransaction_Load(object sender, EventArgs e)
        {
            btCancel_Click(sender, e);
            if (ShareData.userType == "Admin") { 
                btSearchAll.Enabled = true;
                btSearchAll_Click(sender, e);
            }
            else
            {
                btSearchAll.Enabled = false;
            }
            tbiSbn.MaxLength = 13;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            btAdd.Enabled = false;
            btCancel.Enabled = true;
            tbuserId.Enabled = true;
            tbiSbn.Enabled = true;
            dtpBorrowDate.Enabled = true;
            btSaveAddEdit.Enabled = true;
            btCancel.Enabled = true;
            tbborrowStatus.Enabled = true;
            tbborrowStatus.Text = "ยืม";

            string strSql;
            // เรียกข้อมูลหนังสือทั้งหมด
            SqlConnection conn = new SqlConnection(ShareData.conStr);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            strSql = "SELECT MAX(borrowId) FROM book_borrow_history_tb";

            SqlTransaction sqlTransaction = conn.BeginTransaction();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = strSql;
            sqlCommand.Transaction = sqlTransaction;

            object result = sqlCommand.ExecuteScalar();

            // ดึงข้อมูลจากฐานข้อมูลและแสดงใน ListView
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                conn.Close();

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                lbBorrowId.Text = ((int)result + 1).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            btSearchAll_Click(sender, e);
        }

        private void lsBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsBook.SelectedItems.Count > 0)
            {
                btCancel_Click(sender, e);
                btEdit.Enabled = true;
                btAdd.Enabled = false;
                btCancel.Enabled = true;

                // ดึง item ที่เลือก
                ListViewItem selectedItem = lsBook.SelectedItems[0];

                // ดึง movieId และ movieName จาก ListView
                string borrowId = selectedItem.SubItems[1].Text;
                string iSbn = selectedItem.SubItems[3].Text;
                string userId = selectedItem.SubItems[2].Text;
                // แสดง movieId และ movieName ใน Label และ TextBox
                lbBorrowId.Text = borrowId;
                tbuserId.Text = userId;
                tbiSbn.Text = iSbn;

                // เชื่อมต่อฐานข้อมูลและดึงข้อมูลภาพยนตร์
                using (SqlConnection conn = new SqlConnection(ShareData.conStr))
                {
                    try
                    {
                        conn.Open();

                        string strSql = "SELECT borrowId, iSbn, userId, borrowDate, returnSchedule, returnDate, borrowStatus, borrowTransactionmakerId, returnTransactionmakerId " +
                                        "FROM book_borrow_history_tb WHERE borrowId = @borrowId";

                        using (SqlCommand cmd = new SqlCommand(strSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@borrowId", borrowId);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // แสดงข้อมูลในฟอร์ม
                                    lbBorrowId.Text = reader["borrowId"].ToString();
                                    tbuserId.Text = reader["userId"].ToString();
                                    tbiSbn.Text = reader["iSbn"].ToString();
                                    dtpBorrowDate.Value = (DateTime)reader["borrowDate"];
                                    if (reader["returnDate"] != DBNull.Value)
                                    {
                                        dtpReturnDate.Value = (DateTime)reader["returnDate"];
                                        cbReturn.Checked = true;
                                    }
                                    else
                                    {
                                        dtpReturnDate.Value = DateTime.Now;
                                        cbReturn.Checked = false;
                                    }
                                    tbborrowStatus.Text = reader["borrowStatus"].ToString();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void cbReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReturn.Checked)
            {
                dtpReturnDate.Enabled = true;
                tbborrowStatus.Text = "คืนแล้ว";
            }
            else
            {
                dtpReturnDate.Enabled = false;
                dtpReturnDate.Value = DateTime.Now;
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            btEdit.Enabled = false;
            btAdd.Enabled = false;
            btCancel.Enabled = true;
            tbuserId.Enabled = true;
            tbiSbn.Enabled = true;
            dtpBorrowDate.Enabled = true;
            cbReturn.Enabled = true;
            btSaveAddEdit.Enabled = true;
            tbborrowStatus.Enabled = true;
        }

        private void btSaveAddEdit_Click(object sender, EventArgs e)
        {
            if (tbuserId.Text == "")
            {
                ShareData.showWarningMSG("กรุณากรอก UserID สมาชิก");
                return;
            }
            else if (tbiSbn.Text == "")
            {
                ShareData.showWarningMSG("กรุณากรอกหมายเลข ISBN หนังสือ");
                return;
            }
            else if (tbiSbn.Text.Trim().Length < 13)
            {
                ShareData.showWarningMSG("กรุณาป้อนหมายเลข ISBN ให้ครบ 13 หลัก");
                return;
            }
            else if (tbborrowStatus.Text == "")
            {
                ShareData.showWarningMSG("กรุณากรอกสถานะการยืม");
                return;
            }
            else if (dtpReturnDate.Value < dtpBorrowDate.Value)
            {
                ShareData.showWarningMSG("วันที่คืนต้องมากกว่าหรือเท่ากับวันที่ยืม");
                return;
            }
            else {

                string iSbn = tbiSbn.Text.Replace("-", "");
                string userId = tbuserId.Text.Trim();
                string borrowStatus = tbborrowStatus.Text.Trim();
                string borrowId = lbBorrowId.Text.Trim();
                DateTime borrowDate = dtpBorrowDate.Value;
                DateTime returnDate = dtpReturnDate.Value;

                SqlConnection conn = new SqlConnection(ShareData.conStr);

                string strSql = "SELECT * FROM book_borrow_history_tb WHERE borrowId = @borrowId";

                SqlCommand sqlCommand = new SqlCommand(strSql, conn);
                sqlCommand.Parameters.AddWithValue("@borrowId", lbBorrowId.Text.Trim());

                try
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.Read()) // ถ้ามี borrowId อยู่แล้ว -> ทำการอัปเดต
                    {
                        iSbn = string.IsNullOrWhiteSpace(tbiSbn.Text) ? reader["iSbn"].ToString() : tbiSbn.Text.Replace("-", "");
                        userId = string.IsNullOrWhiteSpace(tbuserId.Text) ? reader["userId"].ToString() : tbuserId.Text.Trim();
                        borrowStatus = string.IsNullOrWhiteSpace(tbborrowStatus.Text) ? reader["borrowStatus"].ToString() : tbborrowStatus.Text.Trim();
                        borrowDate = dtpBorrowDate.Checked ? dtpBorrowDate.Value : Convert.ToDateTime(reader["borrowDate"]);
                        returnDate = dtpReturnDate.Checked ? dtpReturnDate.Value : Convert.ToDateTime(reader["returnDate"]);

                        // ตรวจสอบ cbReturn.Checked เพื่อกำหนดค่า returnTransactionmakerId
                        int? returnTransactionmakerId = cbReturn.Checked ? ShareData.userId : (int?)null;
                        int borrowTransactionmakerId = (int)reader["borrowTransactionmakerId"];

                        reader.Close();
                        // คำสั่งอัปเดตการคืนหนังสือ
                        string updateSql = "UPDATE book_borrow_history_tb SET " +
                                           "iSbn = @iSbn, userId = @userId, borrowStatus = @borrowStatus, " +
                                           "borrowDate = @borrowDate, returnDate = @returnDate, " +
                                           "borrowTransactionmakerId = @borrowTransactionmakerId, " +
                                           "returnTransactionmakerId = @returnTransactionmakerId " +
                                           "WHERE borrowId = @borrowId";
                        // คำสั่งอัปเดต bookAvailable เมื่อมีการคืนหนังสือ
                        string updateBookSql = "UPDATE book_tb SET bookAvailable = bookAvailable + 1 WHERE iSbn = @iSbn";
                        using (SqlTransaction transaction = conn.BeginTransaction()) // ใช้ Transaction เพื่อป้องกันข้อผิดพลาด
                        {
                            try
                            {
                                using (SqlCommand updateCommand = new SqlCommand(updateSql, conn, transaction))
                                {
                                    updateCommand.Parameters.AddWithValue("@iSbn", iSbn);
                                    updateCommand.Parameters.AddWithValue("@userId", userId);
                                    updateCommand.Parameters.AddWithValue("@borrowStatus", borrowStatus);
                                    updateCommand.Parameters.AddWithValue("@borrowDate", borrowDate);
                                    updateCommand.Parameters.AddWithValue("@returnDate", returnDate);
                                    updateCommand.Parameters.AddWithValue("@borrowTransactionmakerId", borrowTransactionmakerId);
                                    updateCommand.Parameters.AddWithValue("@returnTransactionmakerId", returnTransactionmakerId ?? (object)DBNull.Value);
                                    updateCommand.Parameters.AddWithValue("@borrowId", lbBorrowId.Text.Trim());
                                    updateCommand.ExecuteNonQuery();
                                }

                                // ถ้า `cbReturn` ถูกติ๊ก เพิ่ม `bookAvailable` ขึ้น 1 หน่วย
                                if (cbReturn.Checked)
                                {
                                    using (SqlCommand updateBookCommand = new SqlCommand(updateBookSql, conn, transaction))
                                    {
                                        updateBookCommand.Parameters.AddWithValue("@iSbn", iSbn);
                                        updateBookCommand.ExecuteNonQuery();
                                    }
                                }

                                transaction.Commit(); // บันทึกการเปลี่ยนแปลงทั้งหมด
                                MessageBox.Show("อัปเดตข้อมูลสำเร็จ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback(); // ยกเลิกการเปลี่ยนแปลงหากเกิดข้อผิดพลาด
                                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                        btSearchAll_Click(sender, e);
                        btCancel_Click(sender, e);
                    }

                    else // ถ้าไม่มี borrowId -> ให้เพิ่มข้อมูลใหม่ (INSERT)
                    {
                        reader.Close();
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }

                        string insertSql = "INSERT INTO book_borrow_history_tb " +
                                           "(iSbn, userId, borrowStatus, borrowDate, returnDate, borrowTransactionmakerId, returnTransactionmakerId) " +
                                           "VALUES (@iSbn, @userId, @borrowStatus, @borrowDate, @returnDate, @borrowTransactionmakerId, @returnTransactionmakerId)";

                        string updateSql = "UPDATE book_tb SET bookAvailable = bookAvailable - 1 WHERE iSbn = @iSbn AND bookAvailable > 0";

                        using (SqlCommand insertCommand = new SqlCommand(insertSql, conn))
                        {
                            insertCommand.Parameters.AddWithValue("@iSbn", tbiSbn.Text.Replace("-", ""));
                            insertCommand.Parameters.AddWithValue("@userId", tbuserId.Text.Trim());
                            insertCommand.Parameters.AddWithValue("@borrowStatus", tbborrowStatus.Text.Trim());
                            insertCommand.Parameters.AddWithValue("@borrowDate", dtpBorrowDate.Value);
                            insertCommand.Parameters.AddWithValue("@returnDate", dtpReturnDate.Value);
                            insertCommand.Parameters.AddWithValue("@borrowTransactionmakerId", ShareData.userId);
                            insertCommand.Parameters.AddWithValue("@returnTransactionmakerId", cbReturn.Checked ? ShareData.userId : (object)DBNull.Value);

                            if (conn.State == ConnectionState.Open)
                            {
                                conn.Close();
                            }
                            conn.Open();

                            using (SqlTransaction transaction = conn.BeginTransaction()) // เริ่ม Transaction
                            {
                                try
                                {
                                    insertCommand.Transaction = transaction;
                                    insertCommand.ExecuteNonQuery(); // บันทึกการยืมหนังสือ

                                    using (SqlCommand updateCommand = new SqlCommand(updateSql, conn, transaction))
                                    {
                                        updateCommand.Parameters.AddWithValue("@iSbn", tbiSbn.Text.Replace("-", ""));
                                        int rowsAffected = updateCommand.ExecuteNonQuery(); // ลดค่า bookAvailable

                                        if (rowsAffected == 0)
                                        {
                                            throw new Exception("หนังสือหมด ไม่สามารถยืมได้");
                                        }
                                    }

                                    transaction.Commit(); // ยืนยันการเปลี่ยนแปลง
                                    MessageBox.Show("ยืมสำเร็จ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback(); // ยกเลิกการเปลี่ยนแปลงหากผิดพลาด
                                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            conn.Close();

                            btSearchAll_Click(sender, e);
                            btCancel_Click(sender, e);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void tbiSbn_Click(object sender, EventArgs e)
        {
            tbiSbn.Select(0, 0);
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            this.Hide();
        }
    }
}
