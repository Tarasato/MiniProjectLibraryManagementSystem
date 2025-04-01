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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MiniProjectLibraryManagementSystem
{
    public partial class FrmBookList : Form
    {
        public FrmBookList()
        {
            InitializeComponent();
        }
        //++++++++++++++++++++++++++++++++ Method And Variable +++++++++++++++++++++++++++++++++++++++++++++++++

        //Create variable collect Movie and Director Image in data type ( byte[] ) for store in DB type image
        byte[] bookImage;


        //Method Get all from book_tb ====================
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(ShareData.conStr))
            {
                conn.Open();
                string strSql = "SELECT iSbn, bookName, bookImage, bookTypeId, bookQuantity, bookAvailable FROM book_tb";

                using (SqlCommand sqlCommand = new SqlCommand(strSql, conn))
                {
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // ✅ ตั้งค่าคอลัมน์ ListView หากยังไม่มี
                        if (lsBookList.Columns.Count == 0)
                        {
                            lsBookList.View = View.Details;
                            lsBookList.Columns.Add("ISBN", 100);
                            lsBookList.Columns.Add("ชื่อหนังสือ", 200);
                            lsBookList.Columns.Add("ประเภทหนังสือ", 100);
                            lsBookList.Columns.Add("จำนวนทั้งหมด", 100);
                            lsBookList.Columns.Add("จำนวนคงเหลือ", 100);
                        }

                        lsBookList.Items.Clear();
                        int orderIndex = 1;

                        foreach (DataRow row in dt.Rows)
                        {
                            ListViewItem item = new ListViewItem(orderIndex.ToString());
                            item.SubItems.Add(row["iSbn"].ToString());
                            item.SubItems.Add(row["bookName"].ToString());

                            // ✅ ตรวจสอบ bookTypeId ว่ามีใน List หรือไม่
                            int bookTypeId = Convert.ToInt32(row["bookTypeId"]);
                            string bookTypeName = (bookTypeId - 1 < ShareData.bookTypeNames.Count)
                                ? ShareData.bookTypeNames[bookTypeId - 1]
                                : "ไม่ทราบประเภท";

                            item.SubItems.Add(bookTypeName);
                            item.SubItems.Add(row["bookQuantity"].ToString());
                            item.SubItems.Add(row["bookAvailable"].ToString());

                            lsBookList.Items.Add(item);
                            orderIndex++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        //Method Search by ISBN=========================== 
        private void SearchByISBN(string iSbn)
        {
            using (SqlConnection connection = new SqlConnection(ShareData.conStr))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM book_tb WHERE iSbn = @iSbn";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@iSbn", iSbn);

                    SqlDataReader reader = command.ExecuteReader();
                    lsBookList.Items.Clear(); // ล้างข้อมูลก่อนเพิ่ม

                    if (reader.Read())
                    {
                        int bookTypeId = Convert.ToInt32(reader["bookTypeId"]);
                        string bookTypeName = (bookTypeId >= 0 && bookTypeId < ShareData.bookTypeNames.Count)
                            ? ShareData.bookTypeNames[bookTypeId]
                            : "ไม่ทราบประเภท";

                        ListViewItem item = new ListViewItem(reader["iSbn"].ToString());
                        item.SubItems.Add(reader["bookName"].ToString());
                        item.SubItems.Add(bookTypeName);
                        item.SubItems.Add(reader["bookQuantity"].ToString());
                        item.SubItems.Add(reader["bookAvailable"].ToString());

                        item.Tag = reader["iSbn"].ToString();
                        lsBookList.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบ ISBN ของหนังสือที่ค้นหา", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
            }
        }

        //Method Search by book name======================
        private void SearchByBookName(string bookName)
        {
            using (SqlConnection connection = new SqlConnection(ShareData.conStr))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM book_tb WHERE bookName LIKE @bookName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@bookName", "%" + bookName + "%");

                    SqlDataReader reader = command.ExecuteReader();
                    lsBookList.Items.Clear(); // ล้างข้อมูลก่อนเพิ่มรายการใหม่

                    while (reader.Read())
                    {
                        int bookTypeId = Convert.ToInt32(reader["bookTypeId"]);
                        string bookTypeName = (bookTypeId >= 0 && bookTypeId < ShareData.bookTypeNames.Count)
                            ? ShareData.bookTypeNames[bookTypeId]
                            : "ไม่ทราบประเภท";

                        ListViewItem item = new ListViewItem(reader["iSbn"].ToString());
                        item.SubItems.Add(reader["bookName"].ToString());
                        item.SubItems.Add(bookTypeName);
                        item.SubItems.Add(reader["bookQuantity"].ToString());
                        item.SubItems.Add(reader["bookAvailable"].ToString());

                        lsBookList.Items.Add(item);
                    }

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("ไม่พบรายชื่อหนังสือที่ค้นหา", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
            }
        }

        //Method Search by book type======================
        private void SearchByBookType(int selectedIndex)
        {
            if (selectedIndex < 0 || selectedIndex >= ShareData.bookTypeNames.Count)
            {
                MessageBox.Show("กรุณาเลือกประเภทหนังสือที่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(ShareData.conStr))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM book_tb WHERE bookTypeId = @bookTypeId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@bookTypeId", selectedIndex);

                    SqlDataReader reader = command.ExecuteReader();
                    lsBookList.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["iSbn"].ToString());
                        item.SubItems.Add(reader["bookName"].ToString());
                        item.SubItems.Add(ShareData.bookTypeNames[selectedIndex]); // ใช้ชื่อหมวดหมู่แทนเลข
                        item.SubItems.Add(reader["bookQuantity"].ToString());
                        item.SubItems.Add(reader["bookAvailable"].ToString());

                        lsBookList.Items.Add(item);
                    }

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("ไม่พบหนังสือในหมวดหมู่ที่เลือก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //+++++++++++++++++++++++++++++++ End of Method And Variable +++++++++++++++++++++++++++++++++++++++++++

        //FormLoad
        private void FrmBookList_Load(object sender, EventArgs e)
        {
            btCancel.PerformClick();
            //Connection DB chenck
            /*
            using (SqlConnection conn = new SqlConnection(ShareData.conStr))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("เชื่อมต่อสำเร็จ!", "SQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เชื่อมต่อไม่สำเร็จ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }
        private void FrmBookList_Shown(object sender, EventArgs e)
        {
            btCancel.PerformClick();
        }

        //+++++++++++++++++++++++++++++++++++++++ ListView FUNC +++++++++++++++++++++++++++++++++++++++++++++++++++
        private void lsBookList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lsBookList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsBookList.SelectedItems[0];
                string iSbn = selectedItem.SubItems[1].Text;
                //MessageBox.Show($"Selected ISBN: {iSbn}"); // ✅ Debug เช็คว่า ISBN ถูกเลือกจริงไหม

                using (SqlConnection connection = new SqlConnection(ShareData.conStr))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT * FROM book_tb WHERE iSbn = @iSbn";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@iSbn", iSbn);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            byte[] imageBytes = reader["bookImage"] as byte[];
                            if (imageBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    pcbBookCover.Image = Image.FromStream(ms);  // ใส่ PictureBox ที่คุณใช้แสดงรูปภาพ
                                    bookImage = imageBytes;
                                }
                            }
                            else 
                            {
                                pcbBookCover.Image = null;  // ใส่ PictureBox ที่คุณใช้แสดงรูปภาพ
                                bookImage = null;
                            }
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("เกิดข้อผิดพลาดในการโหลดรูปภาพ: " + ex.Message);
                    }
                }
            }
        }


        //+++++++++++++++++++++++++++++++++++++++ BUTTON FUNC +++++++++++++++++++++++++++++++++++++++++++++++++++
        //btSearch_Click======================================
        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text.Trim();
            //Validate UI (only radio ISBN and Book name )
            if (rdISBN.Checked || rdBookName.Checked)
            {
                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("กรุณาป้อนคำค้นหาที่เลือกไว้ด้วย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            lsBookList.Items.Clear(); // ล้างรายการใน ListView ก่อนแสดงผลลัพธ์ใหม่
            if (rdISBN.Checked)// SearchByISBN
            {
                SearchByISBN(searchText);
            }
            else if (rdBookName.Checked)// SearchByBookName
            {
                SearchByBookName(searchText);
            }
            else if (rdBookType.Checked)// SearchByBookType
            {
                int selectedIndex = cbbBookType.SelectedIndex;

                if (selectedIndex == -1)
                {
                    MessageBox.Show("กรุณาเลือกประเภทหนังสือจากรายการ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SearchByBookType(selectedIndex);
            }
        }
        //btCancel_Click======================================
        private void btCancel_Click(object sender, EventArgs e)
        {
            rdISBN.Checked = true;
            tbSearch.Clear();
            lsBookList.Items.Clear();
            cbbBookType.Enabled = false;
            cbbBookType.SelectedIndex = 0;
            pcbBookCover.Image = null;
            LoadData();
        }
        //btMainMenu_Click====================================== DEV here plzz!!!!!!!!!!!!
        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            this.Hide();
        }

        //+++++++++++++++++++++++++++++++++++++++ RADIO FUNC +++++++++++++++++++++++++++++++++++++++++++++++++++

        //rdISBN_Click=======================================
        private void rdISBN_Click(object sender, EventArgs e)
        {
            lsBookList.Items.Clear();
            tbSearch.Clear();
            tbSearch.Enabled = true;
            cbbBookType.Enabled = false;
            cbbBookType.SelectedIndex = 0;
        }
        //rdBookName_Click=======================================
        private void rdBookName_Click(object sender, EventArgs e)
        {
            lsBookList.Items.Clear();
            tbSearch.Clear();
            tbSearch.Enabled = true;
            cbbBookType.Enabled = false;
            cbbBookType.SelectedIndex = 0;
        }
        //rdBookType_Click=======================================
        private void rdBookType_Click(object sender, EventArgs e)
        {
            lsBookList.Items.Clear();
            tbSearch.Clear();
            tbSearch.Enabled = false;
            cbbBookType.Enabled = true;
        }


        //+++++++++++++++++++++++++++++++++++++++ KEYPRESS FUNC +++++++++++++++++++++++++++++++++++++++++++++++++++
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdISBN.Checked)
            {
                // ตรวจสอบว่ากดตัวเลข (0-9) หรือปุ่ม Backspace ได้เท่านั้น
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; // ป้องกันไม่ให้พิมพ์ตัวอักษรอื่น
                }
            }
        }

        
    }
}
