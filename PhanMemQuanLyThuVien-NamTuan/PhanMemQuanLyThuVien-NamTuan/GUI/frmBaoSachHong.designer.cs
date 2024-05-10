namespace GUI
{
    partial class frmBaoSachHong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoSachHong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveDescription = new System.Windows.Forms.Button();
            this.imgSmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.clbBooks = new System.Windows.Forms.CheckedListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpInfoBook = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.grpInfoBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnSaveDescription);
            this.panel1.Controls.Add(this.clbBooks);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.grpInfoBook);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 274);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveDescription
            // 
            this.btnSaveDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDescription.ImageIndex = 0;
            this.btnSaveDescription.ImageList = this.imgSmallIcon;
            this.btnSaveDescription.Location = new System.Drawing.Point(234, 149);
            this.btnSaveDescription.Name = "btnSaveDescription";
            this.btnSaveDescription.Size = new System.Drawing.Size(103, 23);
            this.btnSaveDescription.TabIndex = 50;
            this.btnSaveDescription.Text = "Lưu mô tả";
            this.btnSaveDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveDescription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveDescription.UseVisualStyleBackColor = true;
            this.btnSaveDescription.Click += new System.EventHandler(this.btnSaveDescription_Click);
            // 
            // imgSmallIcon
            // 
            this.imgSmallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSmallIcon.ImageStream")));
            this.imgSmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSmallIcon.Images.SetKeyName(0, "save-icon.png");
            // 
            // clbBooks
            // 
            this.clbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbBooks.FormattingEnabled = true;
            this.clbBooks.Location = new System.Drawing.Point(19, 145);
            this.clbBooks.Name = "clbBooks";
            this.clbBooks.Size = new System.Drawing.Size(93, 55);
            this.clbBooks.TabIndex = 49;
            this.clbBooks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbBooks_ItemCheck);
            this.clbBooks.SelectedIndexChanged += new System.EventHandler(this.clbBooks_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(121, 178);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(216, 22);
            this.txtDescription.TabIndex = 48;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ImageIndex = 1;
            this.btnBack.ImageList = this.imgIcon;
            this.btnBack.Location = new System.Drawing.Point(19, 214);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 47);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Trở lại";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "report-icon.png");
            this.imgIcon.Images.SetKeyName(1, "back-icon.png");
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ImageIndex = 0;
            this.btnReport.ImageList = this.imgIcon;
            this.btnReport.Location = new System.Drawing.Point(202, 214);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(135, 47);
            this.btnReport.TabIndex = 47;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Chọn sách hỏng";
            // 
            // grpInfoBook
            // 
            this.grpInfoBook.Controls.Add(this.button1);
            this.grpInfoBook.Controls.Add(this.txtBookName);
            this.grpInfoBook.Controls.Add(this.txtCategory);
            this.grpInfoBook.Controls.Add(this.lblBookName);
            this.grpInfoBook.Controls.Add(this.lblCategoryName);
            this.grpInfoBook.Controls.Add(this.lblAuthor);
            this.grpInfoBook.Controls.Add(this.txtAuthor);
            this.grpInfoBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoBook.ForeColor = System.Drawing.Color.White;
            this.grpInfoBook.Location = new System.Drawing.Point(19, 13);
            this.grpInfoBook.Name = "grpInfoBook";
            this.grpInfoBook.Size = new System.Drawing.Size(318, 107);
            this.grpInfoBook.TabIndex = 7;
            this.grpInfoBook.TabStop = false;
            this.grpInfoBook.Text = "Thông tin sách";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBookName
            // 
            this.txtBookName.Enabled = false;
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(94, 15);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(202, 22);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.TabStop = false;
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(94, 45);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(202, 22);
            this.txtCategory.TabIndex = 4;
            this.txtCategory.TabStop = false;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.White;
            this.lblBookName.Location = new System.Drawing.Point(22, 18);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(71, 16);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Tên sách";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.White;
            this.lblCategoryName.Location = new System.Drawing.Point(29, 48);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(64, 16);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Thể loại";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(33, 78);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(60, 16);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Tác giả";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(94, 75);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(202, 22);
            this.txtAuthor.TabIndex = 4;
            this.txtAuthor.TabStop = false;
            // 
            // frmBaoSachHong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(381, 298);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoSachHong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo sách hỏng";
            this.Load += new System.EventHandler(this.frmBaoSachHong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpInfoBook.ResumeLayout(false);
            this.grpInfoBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpInfoBook;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckedListBox clbBooks;
        private System.Windows.Forms.Button btnSaveDescription;
        private System.Windows.Forms.ImageList imgSmallIcon;
    }
}