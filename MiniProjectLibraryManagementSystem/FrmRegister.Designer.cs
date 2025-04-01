namespace MiniProjectLibraryManagementSystem
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRegister = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbUserImg = new System.Windows.Forms.PictureBox();
            this.btSelectImg = new System.Windows.Forms.Button();
            this.lbBacktoLogin = new System.Windows.Forms.Label();
            this.cbbUserType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniProjectLibraryManagementSystem.Properties.Resources.BookLogo;
            this.pictureBox1.Location = new System.Drawing.Point(253, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(323, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "ลงทะเบียน";
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.White;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.Location = new System.Drawing.Point(191, 329);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(211, 48);
            this.btRegister.TabIndex = 11;
            this.btRegister.Text = "ลงทะเบียน";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Location = new System.Drawing.Point(191, 245);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(308, 20);
            this.tbPassword.TabIndex = 10;
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            // 
            // tbFullName
            // 
            this.tbFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullName.Location = new System.Drawing.Point(191, 134);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(308, 20);
            this.tbFullName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(124, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "รหัสผ่าน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(90, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "ชื่อ - นามสกุล";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConfirmPassword.Location = new System.Drawing.Point(191, 282);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(308, 20);
            this.tbConfirmPassword.TabIndex = 13;
            this.tbConfirmPassword.Enter += new System.EventHandler(this.tbConfirmPassword_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(86, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "ยืนยันรหัสผ่าน";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhoneNum.Location = new System.Drawing.Point(191, 208);
            this.tbPhoneNum.MaxLength = 10;
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(308, 20);
            this.tbPhoneNum.TabIndex = 15;
            this.tbPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNum_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(90, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "เบอร์โทรศัพท์";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Location = new System.Drawing.Point(191, 171);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(308, 20);
            this.tbEmail.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(145, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "อีเมล์";
            // 
            // pbUserImg
            // 
            this.pbUserImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUserImg.Location = new System.Drawing.Point(550, 134);
            this.pbUserImg.Name = "pbUserImg";
            this.pbUserImg.Size = new System.Drawing.Size(152, 131);
            this.pbUserImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserImg.TabIndex = 18;
            this.pbUserImg.TabStop = false;
            // 
            // btSelectImg
            // 
            this.btSelectImg.Location = new System.Drawing.Point(708, 235);
            this.btSelectImg.Name = "btSelectImg";
            this.btSelectImg.Size = new System.Drawing.Size(31, 30);
            this.btSelectImg.TabIndex = 19;
            this.btSelectImg.Text = "...";
            this.btSelectImg.UseVisualStyleBackColor = true;
            this.btSelectImg.Click += new System.EventHandler(this.btSelectImg_Click);
            // 
            // lbBacktoLogin
            // 
            this.lbBacktoLogin.AutoSize = true;
            this.lbBacktoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBacktoLogin.ForeColor = System.Drawing.Color.Black;
            this.lbBacktoLogin.Location = new System.Drawing.Point(387, 405);
            this.lbBacktoLogin.Name = "lbBacktoLogin";
            this.lbBacktoLogin.Size = new System.Drawing.Size(89, 16);
            this.lbBacktoLogin.TabIndex = 20;
            this.lbBacktoLogin.Text = "กลับไปหน้าล็อกอิน";
            this.lbBacktoLogin.Click += new System.EventHandler(this.lbBacktoLogin_Click);
            // 
            // cbbUserType
            // 
            this.cbbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserType.FormattingEnabled = true;
            this.cbbUserType.Items.AddRange(new object[] {
            "ผู้ใช้ทั่วไป",
            "ผู้ดูแลระบบ"});
            this.cbbUserType.Location = new System.Drawing.Point(637, 283);
            this.cbbUserType.Name = "cbbUserType";
            this.cbbUserType.Size = new System.Drawing.Size(102, 21);
            this.cbbUserType.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(547, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "ประเภทผู้ใช้";
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.White;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(453, 329);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(211, 48);
            this.btCancel.TabIndex = 23;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbUserType);
            this.Controls.Add(this.lbBacktoLogin);
            this.Controls.Add(this.btSelectImg);
            this.Controls.Add(this.pbUserImg);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPhoneNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Register";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbUserImg;
        private System.Windows.Forms.Button btSelectImg;
        private System.Windows.Forms.Label lbBacktoLogin;
        private System.Windows.Forms.ComboBox cbbUserType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCancel;
    }
}