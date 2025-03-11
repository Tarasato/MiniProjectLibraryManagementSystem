namespace MiniProjectLibraryManagementSystem
{
    partial class FrmBookTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookTransaction));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdiSbn = new System.Windows.Forms.RadioButton();
            this.cdNotReturnYet = new System.Windows.Forms.CheckBox();
            this.lsBook = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbborrowId = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSaveAddEdit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbiSbn = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbBorrowId = new System.Windows.Forms.Label();
            this.tbuserId = new System.Windows.Forms.TextBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdiSbn);
            this.groupBox1.Controls.Add(this.cdNotReturnYet);
            this.groupBox1.Controls.Add(this.lsBook);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rbborrowId);
            this.groupBox1.Location = new System.Drawing.Point(28, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาการยืมหนังสือ";
            // 
            // rdiSbn
            // 
            this.rdiSbn.AutoSize = true;
            this.rdiSbn.Location = new System.Drawing.Point(164, 23);
            this.rdiSbn.Name = "rdiSbn";
            this.rdiSbn.Size = new System.Drawing.Size(76, 17);
            this.rdiSbn.TabIndex = 7;
            this.rdiSbn.TabStop = true;
            this.rdiSbn.Text = "รหัสหนังสือ";
            this.rdiSbn.UseVisualStyleBackColor = true;
            // 
            // cdNotReturnYet
            // 
            this.cdNotReturnYet.AutoSize = true;
            this.cdNotReturnYet.Location = new System.Drawing.Point(246, 23);
            this.cdNotReturnYet.Name = "cdNotReturnYet";
            this.cdNotReturnYet.Size = new System.Drawing.Size(99, 17);
            this.cdNotReturnYet.TabIndex = 6;
            this.cdNotReturnYet.Text = "ยังไม่คืนเท่านั้น";
            this.cdNotReturnYet.UseVisualStyleBackColor = true;
            // 
            // lsBook
            // 
            this.lsBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.lsBook.FullRowSelect = true;
            this.lsBook.GridLines = true;
            this.lsBook.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsBook.HideSelection = false;
            this.lsBook.Location = new System.Drawing.Point(18, 75);
            this.lsBook.Name = "lsBook";
            this.lsBook.Size = new System.Drawing.Size(403, 193);
            this.lsBook.TabIndex = 4;
            this.lsBook.UseCompatibleStateImageBehavior = false;
            this.lsBook.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "ลำดับ";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "รหัสการยืม";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "รหัสผู้ใช้";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "รหัสหนังสือ";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "สถานะ";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 130;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ค้นหา";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "รหัสผู้ใช้";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbborrowId
            // 
            this.rbborrowId.AutoSize = true;
            this.rbborrowId.Location = new System.Drawing.Point(82, 23);
            this.rbborrowId.Name = "rbborrowId";
            this.rbborrowId.Size = new System.Drawing.Size(76, 17);
            this.rbborrowId.TabIndex = 0;
            this.rbborrowId.Text = "รหัสการยืม";
            this.rbborrowId.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "ยืม/คืน หนังสือ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSaveAddEdit);
            this.groupBox2.Controls.Add(this.btCancel);
            this.groupBox2.Controls.Add(this.btEdit);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbiSbn);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lbBorrowId);
            this.groupBox2.Controls.Add(this.tbuserId);
            this.groupBox2.Controls.Add(this.dtpReturnDate);
            this.groupBox2.Controls.Add(this.dtpBorrowDate);
            this.groupBox2.Location = new System.Drawing.Point(480, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(363, 281);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลการ ยืม/คืน หนังสือ";
            // 
            // btSaveAddEdit
            // 
            this.btSaveAddEdit.Image = ((System.Drawing.Image)(resources.GetObject("btSaveAddEdit.Image")));
            this.btSaveAddEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSaveAddEdit.Location = new System.Drawing.Point(258, 166);
            this.btSaveAddEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btSaveAddEdit.Name = "btSaveAddEdit";
            this.btSaveAddEdit.Size = new System.Drawing.Size(56, 50);
            this.btSaveAddEdit.TabIndex = 49;
            this.btSaveAddEdit.Text = "บันทึก";
            this.btSaveAddEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSaveAddEdit.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancel.Location = new System.Drawing.Point(158, 221);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(56, 50);
            this.btCancel.TabIndex = 52;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEdit.Location = new System.Drawing.Point(158, 166);
            this.btEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(56, 50);
            this.btEdit.TabIndex = 51;
            this.btEdit.Text = "แก้ไข";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdd.Location = new System.Drawing.Point(54, 166);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(56, 50);
            this.btAdd.TabIndex = 50;
            this.btAdd.Text = "เพิ่ม";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "รหัสการยืม";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "รหัสผู้ใช้";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "วันที่คืน";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "วันที่ยืม";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbiSbn
            // 
            this.tbiSbn.Location = new System.Drawing.Point(101, 78);
            this.tbiSbn.Margin = new System.Windows.Forms.Padding(2);
            this.tbiSbn.Multiline = true;
            this.tbiSbn.Name = "tbiSbn";
            this.tbiSbn.Size = new System.Drawing.Size(188, 19);
            this.tbiSbn.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(8, 78);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 19);
            this.label13.TabIndex = 19;
            this.label13.Text = "รหัสหนังสือ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBorrowId
            // 
            this.lbBorrowId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbBorrowId.Location = new System.Drawing.Point(101, 21);
            this.lbBorrowId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBorrowId.Name = "lbBorrowId";
            this.lbBorrowId.Size = new System.Drawing.Size(188, 19);
            this.lbBorrowId.TabIndex = 4;
            this.lbBorrowId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbuserId
            // 
            this.tbuserId.Location = new System.Drawing.Point(101, 49);
            this.tbuserId.Margin = new System.Windows.Forms.Padding(2);
            this.tbuserId.Name = "tbuserId";
            this.tbuserId.Size = new System.Drawing.Size(189, 20);
            this.tbuserId.TabIndex = 5;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(102, 135);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(189, 20);
            this.dtpReturnDate.TabIndex = 8;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(102, 106);
            this.dtpBorrowDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(189, 20);
            this.dtpBorrowDate.TabIndex = 8;
            // 
            // btMainMenu
            // 
            this.btMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btMainMenu.Image")));
            this.btMainMenu.Location = new System.Drawing.Point(787, 11);
            this.btMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(56, 81);
            this.btMainMenu.TabIndex = 51;
            this.btMainMenu.Text = "กลับสู่หน้าหลัก";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            // 
            // FrmBookTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(878, 405);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBookTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Book Transaction";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbborrowId;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsBook;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox cdNotReturnYet;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbiSbn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbBorrowId;
        private System.Windows.Forms.TextBox tbuserId;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.RadioButton rdiSbn;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSaveAddEdit;
        private System.Windows.Forms.Button btMainMenu;
    }
}

