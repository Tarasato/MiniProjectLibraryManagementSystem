namespace MiniProjectLibraryManagementSystem
{
    partial class FrmBookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookList));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdISBN = new System.Windows.Forms.RadioButton();
            this.rdBookName = new System.Windows.Forms.RadioButton();
            this.btSearch = new System.Windows.Forms.Button();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.cbbBookType = new System.Windows.Forms.ComboBox();
            this.rdBookType = new System.Windows.Forms.RadioButton();
            this.pcbBookCover = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsBookList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pcbBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbSearch.Location = new System.Drawing.Point(35, 164);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(279, 26);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.HeadLabel.Location = new System.Drawing.Point(310, -4);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(303, 50);
            this.HeadLabel.TabIndex = 2;
            this.HeadLabel.Text = "รายการหนังสือ";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ค้นหาด้วย";
            // 
            // rdISBN
            // 
            this.rdISBN.AutoSize = true;
            this.rdISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdISBN.Location = new System.Drawing.Point(35, 88);
            this.rdISBN.Name = "rdISBN";
            this.rdISBN.Size = new System.Drawing.Size(214, 20);
            this.rdISBN.TabIndex = 0;
            this.rdISBN.TabStop = true;
            this.rdISBN.Text = "เลขมาตรฐานสากลประจำหนังสือ (ISBN)";
            this.rdISBN.UseVisualStyleBackColor = true;
            this.rdISBN.Click += new System.EventHandler(this.rdISBN_Click);
            // 
            // rdBookName
            // 
            this.rdBookName.AutoSize = true;
            this.rdBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdBookName.Location = new System.Drawing.Point(35, 114);
            this.rdBookName.Name = "rdBookName";
            this.rdBookName.Size = new System.Drawing.Size(72, 20);
            this.rdBookName.TabIndex = 1;
            this.rdBookName.TabStop = true;
            this.rdBookName.Text = "ชื่อหนังสือ";
            this.rdBookName.UseVisualStyleBackColor = true;
            this.rdBookName.Click += new System.EventHandler(this.rdBookName_Click);
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSearch.Location = new System.Drawing.Point(320, 164);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(74, 25);
            this.btSearch.TabIndex = 5;
            this.btSearch.Text = "ค้นหา";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btMainMenu.Image = global::MiniProjectLibraryManagementSystem.Properties.Resources.MainMenu1;
            this.btMainMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMainMenu.Location = new System.Drawing.Point(848, 12);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(90, 80);
            this.btMainMenu.TabIndex = 7;
            this.btMainMenu.Text = "กลับสู่หน้าหลัก";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = false;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Transparent;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancel.Location = new System.Drawing.Point(400, 165);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(83, 24);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // cbbBookType
            // 
            this.cbbBookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBookType.FormattingEnabled = true;
            this.cbbBookType.Items.AddRange(new object[] {
            "การศึกษา",
            "บันเทิง  ",
            "วรรณกรรมและนวนิยาย  ",
            "ประวัติศาสตร์และวัฒนธรรม  ",
            "ธุรกิจและการเงิน  ",
            "จิตวิทยาและพัฒนาตนเอง  ",
            "สุขภาพและโภชนาการ  ",
            "เทคโนโลยีและวิทยาศาสตร์  ",
            "ศาสนาและปรัชญา  ",
            "บ้านและสวน  ",
            "แม่และเด็ก ",
            "ท่องเที่ยวและไลฟ์สไตล์"});
            this.cbbBookType.Location = new System.Drawing.Point(107, 139);
            this.cbbBookType.Name = "cbbBookType";
            this.cbbBookType.Size = new System.Drawing.Size(207, 21);
            this.cbbBookType.TabIndex = 3;
            // 
            // rdBookType
            // 
            this.rdBookType.AutoSize = true;
            this.rdBookType.Location = new System.Drawing.Point(35, 140);
            this.rdBookType.Name = "rdBookType";
            this.rdBookType.Size = new System.Drawing.Size(66, 17);
            this.rdBookType.TabIndex = 2;
            this.rdBookType.TabStop = true;
            this.rdBookType.Text = "หมวดหมู่";
            this.rdBookType.UseVisualStyleBackColor = true;
            this.rdBookType.Click += new System.EventHandler(this.rdBookType_Click);
            // 
            // pcbBookCover
            // 
            this.pcbBookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbBookCover.Location = new System.Drawing.Point(756, 196);
            this.pcbBookCover.Name = "pcbBookCover";
            this.pcbBookCover.Size = new System.Drawing.Size(168, 228);
            this.pcbBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBookCover.TabIndex = 19;
            this.pcbBookCover.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(804, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "รูปหนังสือ";
            // 
            // lsBookList
            // 
            this.lsBookList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsBookList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsBookList.FullRowSelect = true;
            this.lsBookList.GridLines = true;
            this.lsBookList.HideSelection = false;
            this.lsBookList.Location = new System.Drawing.Point(35, 196);
            this.lsBookList.Name = "lsBookList";
            this.lsBookList.Size = new System.Drawing.Size(690, 228);
            this.lsBookList.TabIndex = 21;
            this.lsBookList.UseCompatibleStateImageBehavior = false;
            this.lsBookList.View = System.Windows.Forms.View.Details;
            this.lsBookList.SelectedIndexChanged += new System.EventHandler(this.lsBookList_SelectedIndexChanged_1);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "หมายเลขISBN";
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ชื่อหนังสือ";
            this.columnHeader3.Width = 248;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "หมวดหมู่";
            this.columnHeader4.Width = 159;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "จำนวนทั้งหมด";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "จำนวนที่ยืมได้";
            this.columnHeader6.Width = 83;
            // 
            // FrmBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(950, 447);
            this.Controls.Add(this.lsBookList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbBookCover);
            this.Controls.Add(this.rdBookType);
            this.Controls.Add(this.cbbBookType);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdBookName);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.rdISBN);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Book list";
            this.Load += new System.EventHandler(this.FrmBookList_Load);
            this.Shown += new System.EventHandler(this.FrmBookList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdISBN;
        private System.Windows.Forms.RadioButton rdBookName;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ComboBox cbbBookType;
        private System.Windows.Forms.RadioButton rdBookType;
        private System.Windows.Forms.PictureBox pcbBookCover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsBookList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}