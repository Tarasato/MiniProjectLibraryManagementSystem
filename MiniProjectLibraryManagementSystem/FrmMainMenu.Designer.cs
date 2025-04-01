namespace MiniProjectLibraryManagementSystem
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.btEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLogOut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbUserType = new System.Windows.Forms.Label();
            this.lbIDcard = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btBookListBt = new System.Windows.Forms.Button();
            this.btBookManage = new System.Windows.Forms.Button();
            this.btBookTranBt = new System.Windows.Forms.Button();
            this.btBookBorrowHistories = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(17, 279);
            this.btEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(68, 49);
            this.btEdit.TabIndex = 0;
            this.btEdit.Text = "EditProFile";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLogOut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbUserType);
            this.groupBox1.Controls.Add(this.lbIDcard);
            this.groupBox1.Controls.Add(this.pbProfile);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Location = new System.Drawing.Point(511, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(223, 344);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btLogOut
            // 
            this.btLogOut.Image = global::MiniProjectLibraryManagementSystem.Properties.Resources.Custom_Icon_Design_Flatastic_9_Logout_48;
            this.btLogOut.Location = new System.Drawing.Point(89, 279);
            this.btLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(86, 49);
            this.btLogOut.TabIndex = 20;
            this.btLogOut.Text = "log out";
            this.btLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLogOut.UseVisualStyleBackColor = true;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "userName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "userType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "userID";
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbName.Location = new System.Drawing.Point(71, 243);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(147, 24);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "-";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUserType
            // 
            this.lbUserType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserType.ForeColor = System.Drawing.Color.Black;
            this.lbUserType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbUserType.Location = new System.Drawing.Point(71, 204);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(89, 24);
            this.lbUserType.TabIndex = 18;
            this.lbUserType.Text = "-";
            this.lbUserType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIDcard
            // 
            this.lbIDcard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbIDcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDcard.ForeColor = System.Drawing.Color.Black;
            this.lbIDcard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbIDcard.Location = new System.Drawing.Point(71, 166);
            this.lbIDcard.Name = "lbIDcard";
            this.lbIDcard.Size = new System.Drawing.Size(89, 24);
            this.lbIDcard.TabIndex = 18;
            this.lbIDcard.Text = "-";
            this.lbIDcard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbProfile
            // 
            this.pbProfile.Location = new System.Drawing.Point(42, 22);
            this.pbProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(118, 119);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfile.TabIndex = 1;
            this.pbProfile.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 76);
            this.label6.TabIndex = 20;
            this.label6.Text = "เมนูหลัก";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btBookListBt
            // 
            this.btBookListBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBookListBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBookListBt.Image = global::MiniProjectLibraryManagementSystem.Properties.Resources.Itzikgur_My_Seven_Books_1_48;
            this.btBookListBt.Location = new System.Drawing.Point(38, 119);
            this.btBookListBt.Margin = new System.Windows.Forms.Padding(2);
            this.btBookListBt.Name = "btBookListBt";
            this.btBookListBt.Size = new System.Drawing.Size(206, 111);
            this.btBookListBt.TabIndex = 21;
            this.btBookListBt.TabStop = false;
            this.btBookListBt.Text = "BookList";
            this.btBookListBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBookListBt.UseVisualStyleBackColor = true;
            this.btBookListBt.Click += new System.EventHandler(this.btBookListBt_Click);
            // 
            // btBookManage
            // 
            this.btBookManage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBookManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBookManage.Image = global::MiniProjectLibraryManagementSystem.Properties.Resources.Itzikgur_My_Seven_Books_1_48;
            this.btBookManage.Location = new System.Drawing.Point(263, 240);
            this.btBookManage.Margin = new System.Windows.Forms.Padding(2);
            this.btBookManage.Name = "btBookManage";
            this.btBookManage.Size = new System.Drawing.Size(206, 111);
            this.btBookManage.TabIndex = 0;
            this.btBookManage.TabStop = false;
            this.btBookManage.Text = "BookManage";
            this.btBookManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBookManage.UseVisualStyleBackColor = true;
            this.btBookManage.Click += new System.EventHandler(this.btBookManage_Click);
            // 
            // btBookTranBt
            // 
            this.btBookTranBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBookTranBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBookTranBt.Image = global::MiniProjectLibraryManagementSystem.Properties.Resources.Martz90_Circle_Books_48;
            this.btBookTranBt.Location = new System.Drawing.Point(38, 240);
            this.btBookTranBt.Margin = new System.Windows.Forms.Padding(2);
            this.btBookTranBt.Name = "btBookTranBt";
            this.btBookTranBt.Size = new System.Drawing.Size(206, 111);
            this.btBookTranBt.TabIndex = 0;
            this.btBookTranBt.TabStop = false;
            this.btBookTranBt.Text = "BookTransaction";
            this.btBookTranBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBookTranBt.UseVisualStyleBackColor = true;
            this.btBookTranBt.Click += new System.EventHandler(this.btBookTranBt_Click);
            // 
            // btBookBorrowHistories
            // 
            this.btBookBorrowHistories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBookBorrowHistories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBookBorrowHistories.Image = global::MiniProjectLibraryManagementSystem.Properties.Resources.Itzikgur_My_Seven_Books_1_48;
            this.btBookBorrowHistories.Location = new System.Drawing.Point(263, 119);
            this.btBookBorrowHistories.Margin = new System.Windows.Forms.Padding(2);
            this.btBookBorrowHistories.Name = "btBookBorrowHistories";
            this.btBookBorrowHistories.Size = new System.Drawing.Size(206, 111);
            this.btBookBorrowHistories.TabIndex = 0;
            this.btBookBorrowHistories.TabStop = false;
            this.btBookBorrowHistories.Text = "Borrow Histories";
            this.btBookBorrowHistories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBookBorrowHistories.UseVisualStyleBackColor = true;
            this.btBookBorrowHistories.Click += new System.EventHandler(this.btBookBorrowHistories_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(772, 366);
            this.Controls.Add(this.btBookListBt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btBookBorrowHistories);
            this.Controls.Add(this.btBookManage);
            this.Controls.Add(this.btBookTranBt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - MainMenu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btBookTranBt;
        private System.Windows.Forms.Button btBookManage;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.Label lbIDcard;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btBookListBt;
        private System.Windows.Forms.Button btLogOut;
        private System.Windows.Forms.Button btBookBorrowHistories;
    }
}