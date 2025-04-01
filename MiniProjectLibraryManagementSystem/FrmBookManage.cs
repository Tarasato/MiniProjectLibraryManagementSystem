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
    public partial class FrmBookManage : Form
    {
        byte[] bookImage;
        public FrmBookManage()
        {
            InitializeComponent();
        }

        private void FrmBookManage_Load(object sender, EventArgs e)
        {
            btCancel_Click(sender, e);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            btCancel.Enabled = false;
            btSaveAddEdit.Enabled = false;
            btEdit.Enabled = false;
            tbiSbn.Enabled = false;
            tbBookName.Enabled = false;
            tbBookQuantity.Enabled = false;
            cbbMovieType.Enabled = false;
            btSelectBookImg.Enabled = false;
            rdiSbn.Checked = true;
            tbSearch.MaxLength = 13;
            btAdd.Enabled = true;
            tbSearch.Text = "";
            tbiSbn.Text = "";
            tbBookName.Text = "";
            tbBookQuantity.Text = "";
            pbBookImg.Image = null;
            cbbMovieType.SelectedIndex = -1;
            bookImage = null;
            btSearchAll_Click(sender, e);
        }

        private void btSearchAll_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";

            // เรียกข้อมูลหนังสือทั้งหมด
            SqlConnection conn = new SqlConnection(ShareData.conStr);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            string strSql = "SELECT iSbn, bookName, bookImage, bookTypeId, bookQuantity FROM book_tb";

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
                    item.SubItems.Add(row["iSbn"].ToString());
                    item.SubItems.Add(row["bookName"].ToString());

                    // แปลง bookTypeId เป็นชื่อหมวดหมู่จาก List
                    int bookTypeId = Convert.ToInt32(row["bookTypeId"]);
                    string bookTypeName = ShareData.bookTypeNames[bookTypeId - 1];  // เนื่องจาก list เริ่มต้นที่ 0, เลยต้องใช้ bookTypeId - 1

                    item.SubItems.Add(bookTypeName);  // เพิ่มชื่อหมวดหมู่หนังสือ
                    item.SubItems.Add(row["bookQuantity"].ToString());

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

        private void btAdd_Click(object sender, EventArgs e)
        {
            btAdd.Enabled = false;
            btCancel.Enabled = true;
            btSaveAddEdit.Enabled = true;
            tbiSbn.Enabled = true;
            tbBookName.Enabled = true;
            tbBookQuantity.Enabled = true;
            cbbMovieType.Enabled = true;
            btSelectBookImg.Enabled = true;
            cbbMovieType.SelectedIndex = 0;
        }

        private void btSaveAddEdit_Click(object sender, EventArgs e)
        {

            if (tbiSbn.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณาป้อนรหัส ISBN ของหนังสือ");
            }
            else if (tbiSbn.Text.Trim().Length < 13)
            {
                ShareData.showWarningMSG("รหัส ISBN ของหนังสือต้องมีจำนวน 13 หลัก");
            }
            else if (tbBookName.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณาป้อนชื่อหนังสือ");
            }else if(tbBookQuantity.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณาป้อนจำนวนหนังสือ");
            }else if (bookImage == null)
            {
                ShareData.showWarningMSG("กรุณาเลือกรูปภาพหนังสือ");
            }
            else
            {
                //ถามว่าต้องการบันทึกหรือไม่
                DialogResult result = MessageBox.Show("คุณต้องการบันทึกมูลหนังสือหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(ShareData.conStr);
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Open();

                    // ตรวจสอบว่า iSbn มีในฐานข้อมูลหรือยัง
                    string checkSql = "SELECT COUNT(*) FROM book_tb WHERE iSbn = @iSbn";
                    SqlCommand checkCommand = new SqlCommand(checkSql, conn);
                    checkCommand.Parameters.AddWithValue("@iSbn", tbiSbn.Text.Replace("-", ""));

                    int existingCount = (int)checkCommand.ExecuteScalar();

                    SqlTransaction sqlTransaction = conn.BeginTransaction();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = conn;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Transaction = sqlTransaction;

                    string iSbn = tbiSbn.Text.Replace("-", "");
                    sqlCommand.Parameters.AddWithValue("@iSbn", iSbn);
                    sqlCommand.Parameters.AddWithValue("@bookName", tbBookName.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@bookImage", bookImage);
                    sqlCommand.Parameters.AddWithValue("@bookTypeId", cbbMovieType.SelectedIndex + 1);
                    sqlCommand.Parameters.AddWithValue("@bookQuantity", tbBookQuantity.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@bookAvailable", tbBookQuantity.Text.Trim());

                    try
                    {
                        if (existingCount > 0) // ถ้ามี iSbn อยู่แล้ว ให้ทำการอัพเดตข้อมูล
                        {
                            string updateSql = "UPDATE book_tb SET " +
                                                "bookName = @bookName, " +
                                                "bookImage = @bookImage, " +
                                                "bookTypeId = @bookTypeId, " +
                                                "bookQuantity = @bookQuantity, " +
                                                "bookAvailable = @bookAvailable " +
                                                "WHERE iSbn = @iSbn";

                            sqlCommand.CommandText = updateSql; // ใช้คำสั่ง UPDATE
                        }
                        else // ถ้ายังไม่มี iSbn ก็ทำการเพิ่มข้อมูลใหม่
                        {
                            string insertSql = "INSERT INTO book_tb" +
                                                "(iSbn, bookName, bookImage, bookTypeId, bookQuantity, bookAvailable)" +
                                                "VALUES " +
                                                "(@iSbn, @bookName, @bookImage, @bookTypeId, @bookQuantity, @bookAvailable)";

                            sqlCommand.CommandText = insertSql; // ใช้คำสั่ง INSERT
                        }

                        sqlCommand.ExecuteNonQuery(); // ดำเนินการคำสั่ง SQL
                        sqlTransaction.Commit(); // คอมมิทการทำงาน
                        conn.Close();

                        btCancel_Click(sender, e);
                        MessageBox.Show(existingCount > 0 ? "อัพเดตข้อมูลหนังสือสำเร็จ" : "เพิ่มข้อมูลหนังสือสำเร็จ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback(); // ยกเลิกการทำงานถ้ามีข้อผิดพลาด
                        conn.Close();

                        ShareData.showWarningMSG("เกิดข้อผิดพลาด: " + ex.Message);
                    }

                }
            }
        }

        private void tbiSbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rdiSbn.Checked)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void rdiSbn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdiSbn.Checked)
            {
                tbSearch.Text = "";
                tbSearch.MaxLength = 13;
            }
        }

        private void rdBookName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBookName.Checked)
            {
                tbSearch.Text = "";
                tbSearch.MaxLength = 0;
            }
        }

        private void tbiSbn_Click(object sender, EventArgs e)
        {
            tbiSbn.Select(0, 0);
        }

        private void btSelectBookImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //เอารูปที่เลือกมาแสดงใน PictureBox
                pbBookImg.Image = Image.FromFile(ofd.FileName);

                //แปลงรูปที่เลือกมาเป็น byte[] เก็บใน travellerImage
                //สร้างตัวแปรเก็บประเภทไฟล์
                string extFile = Path.GetExtension(ofd.FileName);
                //แปลงรูปเป็น byte[]
                using (MemoryStream ms = new MemoryStream())
                {
                    if (extFile == ".jpg" || extFile == ".jpeg")
                    {
                        pbBookImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else
                    {
                        pbBookImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    bookImage = ms.ToArray();
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            // เรียกข้อมูลหนังสือทั้งหมด
            SqlConnection conn = new SqlConnection(ShareData.conStr);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            // ตรวจสอบว่าผู้ใช้กรอกคำค้นหาหรือไม่
            string searchText = tbSearch.Text.Trim(); // กำจัดช่องว่างที่ไม่จำเป็น
            string strSql = "SELECT iSbn, bookName, bookImage, bookTypeId, bookQuantity FROM book_tb WHERE 1=1";

            // ถ้าผู้ใช้กรอกคำค้นหาที่ไม่ใช่ค่าว่าง
            if (!string.IsNullOrEmpty(searchText))
            {
                if (rdiSbn.Checked)
                {
                    strSql += " AND iSbn = @search"; // ค้นหาจาก ISBN
                }
                else if (rdBookName.Checked)
                {
                    strSql += " AND bookName LIKE @search"; // ค้นหาจากชื่อหนังสือ
                }
            }
            else
            {
                // ถ้าคำค้นหาว่าง ให้แสดงข้อความแจ้งเตือน
                ShareData.showWarningMSG("กรุณาป้อนข้อมูลที่ต้องการค้นหา");
                return;
            }

            SqlTransaction sqlTransaction = conn.BeginTransaction();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = strSql;
            sqlCommand.Transaction = sqlTransaction;

            // เพิ่มพารามิเตอร์การค้นหาตามที่เลือก
            if (rdiSbn.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@search", searchText); // ค้นหา ISBN ที่กรอก
            }
            else if (rdBookName.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@search", "%" + searchText + "%"); // ค้นหาชื่อหนังสือแบบ LIKE
            }

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                conn.Close(); // ปิดการเชื่อมต่อหลังจากได้ข้อมูลแล้ว

                DataTable dt = new DataTable();
                adapter.Fill(dt); // เติมข้อมูลลงใน DataTable

                // เคลียร์ข้อมูลเก่าใน ListView
                lsBook.Items.Clear();

                int orderIndex = 1;
                foreach (DataRow row in dt.Rows)
                {
                    // สร้าง ListViewItem สำหรับแต่ละแถว
                    ListViewItem item = new ListViewItem(orderIndex.ToString());
                    item.SubItems.Add(row["iSbn"].ToString());
                    item.SubItems.Add(row["bookName"].ToString());
                    item.SubItems.Add(row["bookTypeId"].ToString());
                    item.SubItems.Add(row["bookQuantity"].ToString());

                    // เพิ่ม item ลงใน ListView
                    lsBook.Items.Add(item);

                    // เพิ่มลำดับ
                    orderIndex++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void lsBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsBook.SelectedItems.Count > 0)
            {
                btEdit.Enabled = true;
                btAdd.Enabled = false;
                btCancel.Enabled = true;

                // ดึง item ที่เลือก
                ListViewItem selectedItem = lsBook.SelectedItems[0];

                // ดึง movieId และ movieName จาก ListView
                string iSbn = selectedItem.SubItems[1].Text;
                string bookName = selectedItem.SubItems[2].Text;
                string bookTypeName = selectedItem.SubItems[3].Text;
                int bookTypeId = ShareData.bookTypeNames.IndexOf(bookTypeName) + 1;
                string bookQuantity = (selectedItem.SubItems[4].Text);

                // แสดง movieId และ movieName ใน Label และ TextBox
                tbiSbn.Text = iSbn;
                tbBookName.Text = bookName;
                tbBookQuantity.Text = bookQuantity.ToString();
                cbbMovieType.SelectedIndex = bookTypeId - 1;

                // เชื่อมต่อฐานข้อมูลและดึงข้อมูลภาพยนตร์
                using (SqlConnection conn = new SqlConnection(ShareData.conStr))
                {
                    try
                    {
                        conn.Open();

                        string strSql = "SELECT iSbn, bookName, bookImage, bookTypeId, bookQuantity " +
                                        "FROM book_tb WHERE iSbn = @iSbn";

                        using (SqlCommand cmd = new SqlCommand(strSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@iSbn", iSbn);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // แสดงข้อมูลในฟอร์ม
                                    tbiSbn.Text = reader["iSbn"].ToString();
                                    tbBookName.Text = reader["bookName"].ToString();
                                    cbbMovieType.SelectedIndex = int.Parse(reader["bookTypeId"].ToString()) - 1;
                                    tbBookQuantity.Text = reader["bookQuantity"].ToString();
                                    
                                    // ดึงรูปภาพจากฐานข้อมูลและแสดงใน PictureBox
                                    byte[] imageBytes = reader["bookImage"] as byte[];
                                    if (imageBytes != null)
                                    {
                                        using (MemoryStream ms = new MemoryStream(imageBytes))
                                        {
                                            pbBookImg.Image = Image.FromStream(ms);
                                            bookImage = imageBytes;
                                        }
                                    }

                                    imageBytes = reader["bookImage"] as byte[];
                                    if (imageBytes != null)
                                    {
                                        using (MemoryStream ms = new MemoryStream(imageBytes))
                                        {
                                            pbBookImg.Image = Image.FromStream(ms);
                                            bookImage = imageBytes;
                                        }
                                    }
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

        private void btEdit_Click(object sender, EventArgs e)
        {
            btAdd.Enabled = false;
            btCancel.Enabled = true;
            btSaveAddEdit.Enabled = true;
            tbBookName.Enabled = true;
            tbBookQuantity.Enabled = true;
            cbbMovieType.Enabled = true;
            btSelectBookImg.Enabled = true;
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            this.Hide();
        }
    }
}
