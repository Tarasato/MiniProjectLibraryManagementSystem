namespace MiniProjectLibraryManagementSystem
{
    partial class FrmBookBorrowHistories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookBorrowHistories));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsBookBorrow = new System.Windows.Forms.ListView();
            this.รหัสยืม = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ชื่อหนังสือ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.วันที่ยืม = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.วันที่คืน = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ผู้ยืม = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ผู้ทำเรื่องยืม = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ผู้ทำเรื่องคืน = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSearch = new System.Windows.Forms.Button();
            this.cbUserId = new System.Windows.Forms.CheckBox();
            this.cbdtpBorrow = new System.Windows.Forms.CheckBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.HeadLabel.Location = new System.Drawing.Point(142, 9);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(529, 64);
            this.HeadLabel.TabIndex = 3;
            this.HeadLabel.Text = "ประวัติการยืมหนังสือ";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpBorrow
            // 
            this.dtpBorrow.CustomFormat = "MM/yyyy";
            this.dtpBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpBorrow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBorrow.Location = new System.Drawing.Point(219, 150);
            this.dtpBorrow.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.ShowUpDown = true;
            this.dtpBorrow.Size = new System.Drawing.Size(110, 22);
            this.dtpBorrow.TabIndex = 4;
            // 
            // tbUserId
            // 
            this.tbUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUserId.Location = new System.Drawing.Point(219, 122);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(110, 22);
            this.tbUserId.TabIndex = 5;
            this.tbUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserId_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(161, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ไอดีผู้ยืม";
            // 
            // lsBookBorrow
            // 
            this.lsBookBorrow.AutoArrange = false;
            this.lsBookBorrow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.รหัสยืม,
            this.ชื่อหนังสือ,
            this.วันที่ยืม,
            this.วันที่คืน,
            this.ผู้ยืม,
            this.ผู้ทำเรื่องยืม,
            this.ผู้ทำเรื่องคืน});
            this.lsBookBorrow.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsBookBorrow.HideSelection = false;
            this.lsBookBorrow.Location = new System.Drawing.Point(50, 181);
            this.lsBookBorrow.Name = "lsBookBorrow";
            this.lsBookBorrow.Size = new System.Drawing.Size(642, 286);
            this.lsBookBorrow.TabIndex = 7;
            this.lsBookBorrow.UseCompatibleStateImageBehavior = false;
            this.lsBookBorrow.View = System.Windows.Forms.View.Details;
            // 
            // รหัสยืม
            // 
            this.รหัสยืม.Text = "รหัสยืม";
            this.รหัสยืม.Width = 91;
            // 
            // ชื่อหนังสือ
            // 
            this.ชื่อหนังสือ.Text = "ชื่อหนังสือ";
            this.ชื่อหนังสือ.Width = 101;
            // 
            // วันที่ยืม
            // 
            this.วันที่ยืม.DisplayIndex = 3;
            this.วันที่ยืม.Text = "วันที่ยืม";
            this.วันที่ยืม.Width = 87;
            // 
            // วันที่คืน
            // 
            this.วันที่คืน.DisplayIndex = 4;
            this.วันที่คืน.Text = "วันที่คืน";
            this.วันที่คืน.Width = 87;
            // 
            // ผู้ยืม
            // 
            this.ผู้ยืม.DisplayIndex = 2;
            this.ผู้ยืม.Text = "ผู้ยืม";
            this.ผู้ยืม.Width = 99;
            // 
            // ผู้ทำเรื่องยืม
            // 
            this.ผู้ทำเรื่องยืม.Text = "ผู้ทำเรื่องยืม";
            this.ผู้ทำเรื่องยืม.Width = 81;
            // 
            // ผู้ทำเรื่องคืน
            // 
            this.ผู้ทำเรื่องคืน.Text = "ผู้ทำเรื่องคืน";
            this.ผู้ทำเรื่องคืน.Width = 90;
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSearch.Location = new System.Drawing.Point(345, 150);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(74, 25);
            this.btSearch.TabIndex = 10;
            this.btSearch.Text = "ค้นหา";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // cbUserId
            // 
            this.cbUserId.AutoSize = true;
            this.cbUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbUserId.Location = new System.Drawing.Point(140, 127);
            this.cbUserId.Name = "cbUserId";
            this.cbUserId.Size = new System.Drawing.Size(15, 14);
            this.cbUserId.TabIndex = 12;
            this.cbUserId.UseVisualStyleBackColor = true;
            this.cbUserId.Click += new System.EventHandler(this.cbUserId_Click);
            // 
            // cbdtpBorrow
            // 
            this.cbdtpBorrow.AutoSize = true;
            this.cbdtpBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbdtpBorrow.Location = new System.Drawing.Point(140, 154);
            this.cbdtpBorrow.Name = "cbdtpBorrow";
            this.cbdtpBorrow.Size = new System.Drawing.Size(15, 14);
            this.cbdtpBorrow.TabIndex = 13;
            this.cbdtpBorrow.UseVisualStyleBackColor = true;
            this.cbdtpBorrow.Click += new System.EventHandler(this.cbdtpBorrow_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Transparent;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btCancel.Image = global::MiniProjectLibraryManagementSystem.Properties.Resources.cancel;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancel.Location = new System.Drawing.Point(727, 290);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(61, 75);
            this.btCancel.TabIndex = 14;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btMainMenu.Image = global::MiniProjectLibraryManagementSystem.Properties.Resources.MainMenu1;
            this.btMainMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMainMenu.Location = new System.Drawing.Point(727, 371);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(61, 89);
            this.btMainMenu.TabIndex = 11;
            this.btMainMenu.Text = "กลับสู่หน้าหลัก";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = false;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(162, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "ปี เดือน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(137, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "ค้นหาประวัติการยืม";
            // 
            // FrmBookBorrowHistories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.cbdtpBorrow);
            this.Controls.Add(this.cbUserId);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.lsBookBorrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserId);
            this.Controls.Add(this.dtpBorrow);
            this.Controls.Add(this.HeadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBookBorrowHistories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Book Borrow Histories";
            this.Load += new System.EventHandler(this.FrmBookBorrowHistories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsBookBorrow;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.CheckBox cbUserId;
        private System.Windows.Forms.CheckBox cbdtpBorrow;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader รหัสยืม;
        private System.Windows.Forms.ColumnHeader ชื่อหนังสือ;
        private System.Windows.Forms.ColumnHeader วันที่ยืม;
        private System.Windows.Forms.ColumnHeader วันที่คืน;
        private System.Windows.Forms.ColumnHeader ผู้ยืม;
        private System.Windows.Forms.ColumnHeader ผู้ทำเรื่องยืม;
        private System.Windows.Forms.ColumnHeader ผู้ทำเรื่องคืน;
    }
}