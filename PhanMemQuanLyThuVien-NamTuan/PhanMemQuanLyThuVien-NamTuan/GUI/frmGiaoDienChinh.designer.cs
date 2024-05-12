namespace PhanMemQuanLyThuVien_NamTuan
{
    partial class frmGiaoDienChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDienChinh));
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.panBanner = new System.Windows.Forms.Panel();
            this.panFunction = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLibraryCard = new System.Windows.Forms.Button();
            this.btnPublisher = new System.Windows.Forms.Button();
            this.btnLibrarian = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnLoanCard = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.panTitle = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panFunction.SuspendLayout();
            this.panTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "author-icon.png");
            this.imgIcon.Images.SetKeyName(1, "bill-icon.png");
            this.imgIcon.Images.SetKeyName(2, "book-category-icon.png");
            this.imgIcon.Images.SetKeyName(3, "book-icon.png");
            this.imgIcon.Images.SetKeyName(4, "librarian-icon.png");
            this.imgIcon.Images.SetKeyName(5, "library-card-icon.png");
            this.imgIcon.Images.SetKeyName(6, "logout-icon.png");
            this.imgIcon.Images.SetKeyName(7, "password-icon.png");
            this.imgIcon.Images.SetKeyName(8, "publisher-icon.png");
            this.imgIcon.Images.SetKeyName(9, "statistic.png");
            this.imgIcon.Images.SetKeyName(10, "close-icon.png");
            // 
            // panBanner
            // 
            this.panBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panBanner.BackgroundImage")));
            this.panBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBanner.Location = new System.Drawing.Point(12, 166);
            this.panBanner.Name = "panBanner";
            this.panBanner.Size = new System.Drawing.Size(998, 428);
            this.panBanner.TabIndex = 2;
            // 
            // panFunction
            // 
            this.panFunction.BackColor = System.Drawing.Color.Teal;
            this.panFunction.Controls.Add(this.btnChangePassword);
            this.panFunction.Controls.Add(this.btnLibraryCard);
            this.panFunction.Controls.Add(this.btnPublisher);
            this.panFunction.Controls.Add(this.btnLibrarian);
            this.panFunction.Controls.Add(this.btnAuthor);
            this.panFunction.Controls.Add(this.btnLogOut);
            this.panFunction.Controls.Add(this.btnLoanCard);
            this.panFunction.Controls.Add(this.btnBook);
            this.panFunction.Controls.Add(this.btnCategory);
            this.panFunction.Controls.Add(this.btnStatistic);
            this.panFunction.Location = new System.Drawing.Point(12, 62);
            this.panFunction.Name = "panFunction";
            this.panFunction.Size = new System.Drawing.Size(998, 98);
            this.panFunction.TabIndex = 3;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ImageIndex = 7;
            this.btnChangePassword.ImageList = this.imgIcon;
            this.btnChangePassword.Location = new System.Drawing.Point(902, 11);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(84, 75);
            this.btnChangePassword.TabIndex = 9;
            this.btnChangePassword.TabStop = false;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnLibraryCard
            // 
            this.btnLibraryCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLibraryCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibraryCard.ImageIndex = 5;
            this.btnLibraryCard.ImageList = this.imgIcon;
            this.btnLibraryCard.Location = new System.Drawing.Point(505, 11);
            this.btnLibraryCard.Margin = new System.Windows.Forms.Padding(2);
            this.btnLibraryCard.Name = "btnLibraryCard";
            this.btnLibraryCard.Size = new System.Drawing.Size(84, 75);
            this.btnLibraryCard.TabIndex = 6;
            this.btnLibraryCard.TabStop = false;
            this.btnLibraryCard.Text = "Thẻ độc giả";
            this.btnLibraryCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLibraryCard.UseVisualStyleBackColor = true;
            this.btnLibraryCard.Click += new System.EventHandler(this.btnLibraryCard_Click);
            // 
            // btnPublisher
            // 
            this.btnPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublisher.ImageIndex = 8;
            this.btnPublisher.ImageList = this.imgIcon;
            this.btnPublisher.Location = new System.Drawing.Point(406, 11);
            this.btnPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.Size = new System.Drawing.Size(84, 75);
            this.btnPublisher.TabIndex = 5;
            this.btnPublisher.TabStop = false;
            this.btnPublisher.Text = "Nhà xuất bản";
            this.btnPublisher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPublisher.UseVisualStyleBackColor = true;
            this.btnPublisher.Click += new System.EventHandler(this.btnPublisher_Click);
            // 
            // btnLibrarian
            // 
            this.btnLibrarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarian.ImageIndex = 4;
            this.btnLibrarian.ImageList = this.imgIcon;
            this.btnLibrarian.Location = new System.Drawing.Point(11, 11);
            this.btnLibrarian.Margin = new System.Windows.Forms.Padding(2);
            this.btnLibrarian.Name = "btnLibrarian";
            this.btnLibrarian.Size = new System.Drawing.Size(84, 75);
            this.btnLibrarian.TabIndex = 1;
            this.btnLibrarian.TabStop = false;
            this.btnLibrarian.Text = "Thủ thư";
            this.btnLibrarian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLibrarian.UseVisualStyleBackColor = true;
            this.btnLibrarian.Click += new System.EventHandler(this.btnLibrarian_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.ImageIndex = 0;
            this.btnAuthor.ImageList = this.imgIcon;
            this.btnAuthor.Location = new System.Drawing.Point(309, 11);
            this.btnAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(84, 75);
            this.btnAuthor.TabIndex = 4;
            this.btnAuthor.TabStop = false;
            this.btnAuthor.Text = "Tác giả";
            this.btnAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ImageIndex = 6;
            this.btnLogOut.ImageList = this.imgIcon;
            this.btnLogOut.Location = new System.Drawing.Point(802, 11);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(84, 75);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnLoanCard
            // 
            this.btnLoanCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoanCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanCard.ImageIndex = 1;
            this.btnLoanCard.ImageList = this.imgIcon;
            this.btnLoanCard.Location = new System.Drawing.Point(604, 11);
            this.btnLoanCard.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoanCard.Name = "btnLoanCard";
            this.btnLoanCard.Size = new System.Drawing.Size(84, 75);
            this.btnLoanCard.TabIndex = 7;
            this.btnLoanCard.TabStop = false;
            this.btnLoanCard.Text = "Phiếu mượn trả";
            this.btnLoanCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoanCard.UseVisualStyleBackColor = true;
            this.btnLoanCard.Click += new System.EventHandler(this.btnLoanCard_Click);
            // 
            // btnBook
            // 
            this.btnBook.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ImageIndex = 3;
            this.btnBook.ImageList = this.imgIcon;
            this.btnBook.Location = new System.Drawing.Point(111, 11);
            this.btnBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(84, 75);
            this.btnBook.TabIndex = 2;
            this.btnBook.TabStop = false;
            this.btnBook.Text = "Sách";
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ImageIndex = 2;
            this.btnCategory.ImageList = this.imgIcon;
            this.btnCategory.Location = new System.Drawing.Point(210, 11);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(84, 75);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.TabStop = false;
            this.btnCategory.Text = "Thể loại";
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ImageIndex = 9;
            this.btnStatistic.ImageList = this.imgIcon;
            this.btnStatistic.Location = new System.Drawing.Point(703, 11);
            this.btnStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(84, 75);
            this.btnStatistic.TabIndex = 8;
            this.btnStatistic.TabStop = false;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.Color.Teal;
            this.panTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTitle.Controls.Add(this.btnClose);
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Location = new System.Drawing.Point(12, 12);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(998, 44);
            this.panTitle.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageIndex = 10;
            this.btnClose.ImageList = this.imgIcon;
            this.btnClose.Location = new System.Drawing.Point(901, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 38);
            this.btnClose.TabIndex = 9;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Thoát";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(356, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ THƯ VIỆN";
            // 
            // frmGiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1022, 606);
            this.ControlBox = false;
            this.Controls.Add(this.panTitle);
            this.Controls.Add(this.panFunction);
            this.Controls.Add(this.panBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1038, 645);
            this.MinimumSize = new System.Drawing.Size(1038, 645);
            this.Name = "frmGiaoDienChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện chính";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiaoDienChinh_FormClosing);
            this.panFunction.ResumeLayout(false);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.Panel panBanner;
        private System.Windows.Forms.Panel panFunction;
        private System.Windows.Forms.Button btnLibrarian;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnPublisher;
        private System.Windows.Forms.Button btnLibraryCard;
        private System.Windows.Forms.Button btnLoanCard;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnClose;
    }
}