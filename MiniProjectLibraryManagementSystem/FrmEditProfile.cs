using System;

using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;


using System.Windows.Forms;

namespace MiniProjectLibraryManagementSystem
{
    public partial class FrmEditProfile : Form
    {
        private byte[] userProfile;
        private bool isEditMode = false; // Track if we're in edit mode

        public FrmEditProfile()
        {
            InitializeComponent();
            InitializeFormState();
        }

        private bool IsEmailExists(string email, int userId)
        {
            using (SqlConnection conn = new SqlConnection(ShareData.conStr))
            {
                conn.Open();

                string strSql = "SELECT COUNT(*) FROM user_tb WHERE userEmail = @userEmail AND userId <> @userId";

                SqlCommand sqlCommand = new SqlCommand(strSql, conn);
                sqlCommand.Parameters.AddWithValue("@userEmail", email);
                sqlCommand.Parameters.AddWithValue("@userId", userId);

                int count = (int)sqlCommand.ExecuteScalar();

                return count > 0;
            }
        }

        private bool IsPhoneExists(string phone, int userId)
        {
            using (SqlConnection conn = new SqlConnection(ShareData.conStr))
            {
                conn.Open();

                string strSql = "SELECT COUNT(*) FROM user_tb WHERE userPhone = @userPhone AND userId <> @userId";

                SqlCommand sqlCommand = new SqlCommand(strSql, conn);
                sqlCommand.Parameters.AddWithValue("@userPhone", phone);
                sqlCommand.Parameters.AddWithValue("@userId", userId);

                int count = (int)sqlCommand.ExecuteScalar();

                return count > 0;
            }
        }


        private void InitializeFormState()
        {
            // Disable editing initially
            groupBox1.Enabled = false;
            tbID.Enabled = false; // userID cannot be edited
            tbType.Enabled = false; // userType cannot be edited
            tbPassword.Enabled = false; // Password fields disabled initially
            tbConfirmPassword.Enabled = false;
            btSave.Enabled = false;
            isEditMode = false;
            btCancel.Enabled = false;
        }

        private void FrmEditProfile_Load(object sender, EventArgs e)
        {
            // Load user data from ShareData (set during login)
            try
            {
                tbID.Text = ShareData.userId.ToString();
                tbName.Text = ShareData.userFullName;
                tbEmail.Text = ShareData.userEmail;
                tbPhone.Text = ShareData.userPhone;
                tbType.Text = ShareData.userType;

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

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPhoto_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                MessageBox.Show("กรุณากดปุ่มแก้ไขก่อนเปลี่ยนรูปภาพ");
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png",
                Title = "เลือกไฟล์รูปภาพ"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbProfile.Image = Image.FromFile(ofd.FileName);
                    string extFile = Path.GetExtension(ofd.FileName).ToLower();

                    using (MemoryStream ms = new MemoryStream())
                    {
                        if (extFile == ".jpg" || extFile == ".jpeg")
                        {
                            pbProfile.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        else if (extFile == ".png")
                        {
                            pbProfile.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        }

                        userProfile = ms.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการโหลดรูปภาพ: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรูปภาพ");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            // Enable editing of fields in groupBox1 and the save button
            groupBox1.Enabled = true;
            tbID.Enabled = false; // userID cannot be edited
            tbType.Enabled = false; // userType cannot be edited
            tbPassword.Enabled = true; // Enable password fields
            tbConfirmPassword.Enabled = true;
            btSave.Enabled = true;
            isEditMode = true; // Set edit mode to true
            btEdit.Enabled = false; // Disable edit button
            btCancel.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                MessageBox.Show("กรุณากดปุ่มแก้ไขก่อนบันทึก");
                return;
            }

            // Validate input fields
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อและนามสกุล");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("กรุณากรอกอีเมล์ให้ถูกต้อง");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์");
                return;
            }
            else if (IsEmailExists(tbEmail.Text.Trim(), ShareData.userId))
            {
                ShareData.showWarningMSG("อีเมลนี้มีผู้ใช้แล้ว");
                return;
            }

            else if (IsPhoneExists(tbPhone.Text.Trim(), ShareData.userId))
            {
                ShareData.showWarningMSG("เบอร์โทรศัพท์นี้มีผู้ใช้แล้ว");
                return;
            }

            // Validate password if user wants to change it
            string newPassword = null;
            if (!string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                if (tbPassword.Text.Length < 6)
                {
                    MessageBox.Show("รหัสผ่านต้องมีอย่างน้อย 6 ตัวอักษร");
                    return;
                }
                if (tbPassword.Text != tbConfirmPassword.Text)
                {
                    MessageBox.Show("รหัสผ่านและการยืนยันรหัสผ่านไม่ตรงกัน");
                    return;
                }
                newPassword = tbPassword.Text;
            }

            // Save the updated profile to the database
            using (SqlConnection conn = new SqlConnection(ShareData.conStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE user_tb SET userFullName = @userFullName, userEmail = @userEmail, userPhone = @userPhone";
                    if (newPassword != null)
                    {
                        query += ", userPassword = @userPassword";
                    }
                    if (userProfile != null)
                    {
                        query += ", userImage = @userImage";
                    }
                    query += " WHERE userId = @userId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userFullName", tbName.Text.Trim());
                        cmd.Parameters.AddWithValue("@userEmail", tbEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@userPhone", tbPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@userId", ShareData.userId);

                        if (newPassword != null)
                        {
                            cmd.Parameters.AddWithValue("@userPassword", newPassword);
                        }
                        if (userProfile != null)
                        {
                            cmd.Parameters.AddWithValue("@userImage", userProfile);
                        }
                        else if (ShareData.userImage != null)
                        {
                            cmd.Parameters.AddWithValue("@userImage", ShareData.userImage); // Keep existing image if unchanged
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@userImage", DBNull.Value);
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Update ShareData with new values
                            ShareData.userFullName = tbName.Text.Trim();
                            ShareData.userEmail = tbEmail.Text.Trim();
                            ShareData.userPhone = tbPhone.Text.Trim();
                            if (newPassword != null)
                            {
                                ShareData.userPassword = newPassword;
                            }
                            if (userProfile != null)
                            {
                                ShareData.userImage = userProfile;
                            }

                            MessageBox.Show("บันทึกข้อมูลสำเร็จ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Disable editing after saving
                            groupBox1.Enabled = false;
                            tbPassword.Enabled = false;
                            //tbConfirmPassword.Enabled = false;
                            btSave.Enabled = false;
                            isEditMode = false;
                            btCancel.Enabled = false;
                            btEdit.Enabled = true; // Enable edit button
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบผู้ใช้ที่ต้องการอัปเดต");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล: " + ex.Message);
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            // Reset the form to initial state
            FrmEditProfile_Load(null, null); // Reload original data
            groupBox1.Enabled = false;
            tbPassword.Enabled = false;
            tbConfirmPassword.Enabled = false;
            btSave.Enabled = false;
            isEditMode = false;
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
            userProfile = null; // Reset new image
            btEdit.Enabled = true; // Enable edit button
            btCancel.Enabled = false;
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }
    }
}