namespace MiniProjectLibraryManagementSystem
{
    partial class FrmBookManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookManage));
            this.btMainMenu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbiSbn = new System.Windows.Forms.MaskedTextBox();
            this.btSaveAddEdit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btEdit = new System.Windows.Forms.Button();
            this.btSelectBookImg = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.pbBookImg = new System.Windows.Forms.PictureBox();
            this.cbbMovieType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBookQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdiSbn = new System.Windows.Forms.RadioButton();
            this.rdBookName = new System.Windows.Forms.RadioButton();
            this.lsBook = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSearch = new System.Windows.Forms.Button();
            this.btSearchAll = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btMainMenu
            // 
            this.btMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btMainMenu.Image")));
            this.btMainMenu.Location = new System.Drawing.Point(860, 21);
            this.btMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(56, 81);
            this.btMainMenu.TabIndex = 55;
            this.btMainMenu.Text = "กลับสู่หน้าหลัก";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbiSbn);
            this.groupBox2.Controls.Add(this.btSaveAddEdit);
            this.groupBox2.Controls.Add(this.btCancel);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btEdit);
            this.groupBox2.Controls.Add(this.btSelectBookImg);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.pbBookImg);
            this.groupBox2.Controls.Add(this.cbbMovieType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbBookQuantity);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbBookName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(473, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(460, 281);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลหนังสือ";
            // 
            // tbiSbn
            // 
            this.tbiSbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbiSbn.Location = new System.Drawing.Point(102, 23);
            this.tbiSbn.Mask = "###-#-####-####-#";
            this.tbiSbn.Name = "tbiSbn";
            this.tbiSbn.Size = new System.Drawing.Size(187, 29);
            this.tbiSbn.TabIndex = 56;
            this.tbiSbn.Click += new System.EventHandler(this.tbiSbn_Click);
            // 
            // btSaveAddEdit
            // 
            this.btSaveAddEdit.Image = ((System.Drawing.Image)(resources.GetObject("btSaveAddEdit.Image")));
            this.btSaveAddEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSaveAddEdit.Location = new System.Drawing.Point(258, 221);
            this.btSaveAddEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btSaveAddEdit.Name = "btSaveAddEdit";
            this.btSaveAddEdit.Size = new System.Drawing.Size(56, 50);
            this.btSaveAddEdit.TabIndex = 49;
            this.btSaveAddEdit.Text = "บันทึก";
            this.btSaveAddEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSaveAddEdit.UseVisualStyleBackColor = true;
            this.btSaveAddEdit.Click += new System.EventHandler(this.btSaveAddEdit_Click);
            // 
            // btCancel
            // 
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancel.Location = new System.Drawing.Point(353, 221);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(56, 50);
            this.btCancel.TabIndex = 52;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(310, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 30);
            this.label16.TabIndex = 26;
            this.label16.Text = "รูปตัวอย่างหนังสือ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btEdit
            // 
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEdit.Location = new System.Drawing.Point(158, 221);
            this.btEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(56, 50);
            this.btEdit.TabIndex = 51;
            this.btEdit.Text = "แก้ไข";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btSelectBookImg
            // 
            this.btSelectBookImg.Location = new System.Drawing.Point(429, 171);
            this.btSelectBookImg.Margin = new System.Windows.Forms.Padding(2);
            this.btSelectBookImg.Name = "btSelectBookImg";
            this.btSelectBookImg.Size = new System.Drawing.Size(22, 19);
            this.btSelectBookImg.TabIndex = 23;
            this.btSelectBookImg.Text = "...";
            this.btSelectBookImg.UseVisualStyleBackColor = true;
            this.btSelectBookImg.Click += new System.EventHandler(this.btSelectBookImg_Click);
            // 
            // btAdd
            // 
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdd.Location = new System.Drawing.Point(54, 221);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(56, 50);
            this.btAdd.TabIndex = 50;
            this.btAdd.Text = "เพิ่ม";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // pbBookImg
            // 
            this.pbBookImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBookImg.InitialImage = null;
            this.pbBookImg.Location = new System.Drawing.Point(321, 50);
            this.pbBookImg.Margin = new System.Windows.Forms.Padding(2);
            this.pbBookImg.Name = "pbBookImg";
            this.pbBookImg.Size = new System.Drawing.Size(103, 140);
            this.pbBookImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImg.TabIndex = 21;
            this.pbBookImg.TabStop = false;
            // 
            // cbbMovieType
            // 
            this.cbbMovieType.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbbMovieType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMovieType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMovieType.FormattingEnabled = true;
            this.cbbMovieType.Items.AddRange(new object[] {
            "การศึกษา",
            "บันเทิง",
            "วรรณกรรมและนวนิยาย",
            "ประวัติศาสตร์และวัฒนธรรม",
            "ธุรกิจและการเงิน",
            "จิตวิทยาและพัฒนาตนเอง",
            "สุขภาพและโภชนาการ",
            "เทคโนโลยีและวิทยาศาสตร์",
            "ศาสนาและปรัชญา",
            "บ้านและสวน",
            "แม่และเด็ก",
            "ท่องเที่ยวและไลฟ์สไตล์"});
            this.cbbMovieType.Location = new System.Drawing.Point(101, 113);
            this.cbbMovieType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMovieType.Name = "cbbMovieType";
            this.cbbMovieType.Size = new System.Drawing.Size(188, 32);
            this.cbbMovieType.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "หมวดหมู่";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbBookQuantity
            // 
            this.tbBookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookQuantity.Location = new System.Drawing.Point(101, 159);
            this.tbBookQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.tbBookQuantity.MaxLength = 5;
            this.tbBookQuantity.Multiline = true;
            this.tbBookQuantity.Name = "tbBookQuantity";
            this.tbBookQuantity.Size = new System.Drawing.Size(188, 31);
            this.tbBookQuantity.TabIndex = 20;
            this.tbBookQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBookQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbiSbn_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "จำนวนหนังสือ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbBookName
            // 
            this.tbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookName.Location = new System.Drawing.Point(101, 64);
            this.tbBookName.Margin = new System.Windows.Forms.Padding(2);
            this.tbBookName.Multiline = true;
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(188, 34);
            this.tbBookName.TabIndex = 20;
            this.tbBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "ชื่อหนังสือ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 19);
            this.label13.TabIndex = 19;
            this.label13.Text = "รหัสหนังสือ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 50);
            this.label1.TabIndex = 53;
            this.label1.Text = "จัดการหนังสือ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdiSbn);
            this.groupBox1.Controls.Add(this.rdBookName);
            this.groupBox1.Controls.Add(this.lsBook);
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.btSearchAll);
            this.groupBox1.Controls.Add(this.tbSearch);
            this.groupBox1.Location = new System.Drawing.Point(21, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 281);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาหนังสือ";
            // 
            // rdiSbn
            // 
            this.rdiSbn.AutoSize = true;
            this.rdiSbn.Checked = true;
            this.rdiSbn.Location = new System.Drawing.Point(18, 24);
            this.rdiSbn.Name = "rdiSbn";
            this.rdiSbn.Size = new System.Drawing.Size(76, 17);
            this.rdiSbn.TabIndex = 7;
            this.rdiSbn.TabStop = true;
            this.rdiSbn.Text = "รหัสหนังสือ";
            this.rdiSbn.UseVisualStyleBackColor = true;
            this.rdiSbn.CheckedChanged += new System.EventHandler(this.rdiSbn_CheckedChanged);
            // 
            // rdBookName
            // 
            this.rdBookName.AutoSize = true;
            this.rdBookName.Location = new System.Drawing.Point(100, 24);
            this.rdBookName.Name = "rdBookName";
            this.rdBookName.Size = new System.Drawing.Size(70, 17);
            this.rdBookName.TabIndex = 5;
            this.rdBookName.Text = "ชื่อหนังสือ";
            this.rdBookName.UseVisualStyleBackColor = true;
            this.rdBookName.CheckedChanged += new System.EventHandler(this.rdBookName_CheckedChanged);
            // 
            // lsBook
            // 
            this.lsBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
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
            this.lsBook.SelectedIndexChanged += new System.EventHandler(this.lsBook_SelectedIndexChanged);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "ลำดับ";
            this.ColumnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "รหัสหนังสือ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ชื่อหนังสือ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "หมวดหมู่";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "จำนวนทั้งหมด";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(267, 46);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "ค้นหา";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btSearchAll
            // 
            this.btSearchAll.Location = new System.Drawing.Point(346, 46);
            this.btSearchAll.Name = "btSearchAll";
            this.btSearchAll.Size = new System.Drawing.Size(75, 23);
            this.btSearchAll.TabIndex = 3;
            this.btSearchAll.Text = "ค้นหาทั้งหมด";
            this.btSearchAll.UseVisualStyleBackColor = true;
            this.btSearchAll.Click += new System.EventHandler(this.btSearchAll_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(18, 48);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(243, 20);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // FrmBookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(960, 430);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBookManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Book Management";
            this.Load += new System.EventHandler(this.FrmBookManage_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSaveAddEdit;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btSelectBookImg;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.PictureBox pbBookImg;
        private System.Windows.Forms.ComboBox cbbMovieType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdiSbn;
        private System.Windows.Forms.RadioButton rdBookName;
        private System.Windows.Forms.ListView lsBook;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btSearchAll;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBookQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.MaskedTextBox tbiSbn;
    }
}