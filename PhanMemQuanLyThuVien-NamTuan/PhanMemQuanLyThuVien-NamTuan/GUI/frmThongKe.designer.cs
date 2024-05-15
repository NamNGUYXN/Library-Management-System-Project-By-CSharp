namespace PhanMemQuanLyThuVien_NamTuan
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.panTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panFunction = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDSSachHong = new System.Windows.Forms.Button();
            this.btnDSTDGHH = new System.Windows.Forms.Button();
            this.panStatistic = new System.Windows.Forms.Panel();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.panSumNotIntactBook = new System.Windows.Forms.Panel();
            this.txtTongSachHong = new System.Windows.Forms.TextBox();
            this.lblSumNotIntactBook = new System.Windows.Forms.Label();
            this.panSumBookBorrowed = new System.Windows.Forms.Panel();
            this.txtTongSachMuon = new System.Windows.Forms.TextBox();
            this.lblSumBookBorrowed = new System.Windows.Forms.Label();
            this.panSumLoanCard = new System.Windows.Forms.Panel();
            this.txtTongPhieuMuon = new System.Windows.Forms.TextBox();
            this.lblSumLoanCard = new System.Windows.Forms.Label();
            this.panDataList = new System.Windows.Forms.Panel();
            this.dgvDataList = new System.Windows.Forms.DataGridView();
            this.panTitle.SuspendLayout();
            this.panFunction.SuspendLayout();
            this.panStatistic.SuspendLayout();
            this.panSumNotIntactBook.SuspendLayout();
            this.panSumBookBorrowed.SuspendLayout();
            this.panSumLoanCard.SuspendLayout();
            this.panDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "add-icon.png");
            this.imgIcon.Images.SetKeyName(1, "back-icon.png");
            this.imgIcon.Images.SetKeyName(2, "close-icon.png");
            this.imgIcon.Images.SetKeyName(3, "dealine-icon.png");
            this.imgIcon.Images.SetKeyName(4, "delete-icon.png");
            this.imgIcon.Images.SetKeyName(5, "edit-icon.png");
            this.imgIcon.Images.SetKeyName(6, "reset-icon.png");
            this.imgIcon.Images.SetKeyName(7, "book-icon.png");
            this.imgIcon.Images.SetKeyName(8, "check-icon.png");
            this.imgIcon.Images.SetKeyName(9, "statistic.png");
            this.imgIcon.Images.SetKeyName(10, "filter-icon.png");
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.Color.Teal;
            this.panTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Location = new System.Drawing.Point(12, 12);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(720, 44);
            this.panTitle.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(277, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỐNG KÊ";
            // 
            // panFunction
            // 
            this.panFunction.BackColor = System.Drawing.Color.Teal;
            this.panFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFunction.Controls.Add(this.btnBack);
            this.panFunction.Controls.Add(this.btnDSSachHong);
            this.panFunction.Controls.Add(this.btnDSTDGHH);
            this.panFunction.Location = new System.Drawing.Point(12, 62);
            this.panFunction.Name = "panFunction";
            this.panFunction.Size = new System.Drawing.Size(146, 170);
            this.panFunction.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.ImageIndex = 1;
            this.btnBack.ImageList = this.imgIcon;
            this.btnBack.Location = new System.Drawing.Point(10, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 47);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Trở lại";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDSSachHong
            // 
            this.btnDSSachHong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSSachHong.Location = new System.Drawing.Point(10, 60);
            this.btnDSSachHong.Name = "btnDSSachHong";
            this.btnDSSachHong.Size = new System.Drawing.Size(124, 47);
            this.btnDSSachHong.TabIndex = 2;
            this.btnDSSachHong.Text = "DS Sách hỏng";
            this.btnDSSachHong.UseVisualStyleBackColor = true;
            this.btnDSSachHong.Click += new System.EventHandler(this.btnDSSachHong_Click);
            // 
            // btnDSTDGHH
            // 
            this.btnDSTDGHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSTDGHH.Location = new System.Drawing.Point(10, 109);
            this.btnDSTDGHH.Name = "btnDSTDGHH";
            this.btnDSTDGHH.Size = new System.Drawing.Size(124, 47);
            this.btnDSTDGHH.TabIndex = 3;
            this.btnDSTDGHH.Text = "DS Thẻ ĐG hết hạn";
            this.btnDSTDGHH.UseVisualStyleBackColor = true;
            this.btnDSTDGHH.Click += new System.EventHandler(this.btnDSTDGHH_Click);
            // 
            // panStatistic
            // 
            this.panStatistic.BackColor = System.Drawing.Color.Teal;
            this.panStatistic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panStatistic.Controls.Add(this.lblSelect);
            this.panStatistic.Controls.Add(this.cboFilter);
            this.panStatistic.Controls.Add(this.panSumNotIntactBook);
            this.panStatistic.Controls.Add(this.panSumBookBorrowed);
            this.panStatistic.Controls.Add(this.panSumLoanCard);
            this.panStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panStatistic.ForeColor = System.Drawing.Color.White;
            this.panStatistic.Location = new System.Drawing.Point(164, 62);
            this.panStatistic.Name = "panStatistic";
            this.panStatistic.Size = new System.Drawing.Size(568, 170);
            this.panStatistic.TabIndex = 10;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(7, 14);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(110, 16);
            this.lblSelect.TabIndex = 25;
            this.lblSelect.Text = "Thống kê theo:";
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "Tất cả",
            "Ngày",
            "Tháng",
            "Năm"});
            this.cboFilter.Location = new System.Drawing.Point(123, 11);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(143, 24);
            this.cboFilter.TabIndex = 24;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // panSumNotIntactBook
            // 
            this.panSumNotIntactBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panSumNotIntactBook.Controls.Add(this.txtTongSachHong);
            this.panSumNotIntactBook.Controls.Add(this.lblSumNotIntactBook);
            this.panSumNotIntactBook.Location = new System.Drawing.Point(378, 54);
            this.panSumNotIntactBook.Name = "panSumNotIntactBook";
            this.panSumNotIntactBook.Size = new System.Drawing.Size(178, 102);
            this.panSumNotIntactBook.TabIndex = 22;
            // 
            // txtTongSachHong
            // 
            this.txtTongSachHong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTongSachHong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongSachHong.Enabled = false;
            this.txtTongSachHong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSachHong.Location = new System.Drawing.Point(61, 42);
            this.txtTongSachHong.Name = "txtTongSachHong";
            this.txtTongSachHong.ReadOnly = true;
            this.txtTongSachHong.Size = new System.Drawing.Size(57, 19);
            this.txtTongSachHong.TabIndex = 17;
            this.txtTongSachHong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSumNotIntactBook
            // 
            this.lblSumNotIntactBook.AutoSize = true;
            this.lblSumNotIntactBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumNotIntactBook.ForeColor = System.Drawing.Color.Black;
            this.lblSumNotIntactBook.Location = new System.Drawing.Point(3, 0);
            this.lblSumNotIntactBook.Name = "lblSumNotIntactBook";
            this.lblSumNotIntactBook.Size = new System.Drawing.Size(123, 20);
            this.lblSumNotIntactBook.TabIndex = 15;
            this.lblSumNotIntactBook.Text = "Tổng sách hỏng";
            // 
            // panSumBookBorrowed
            // 
            this.panSumBookBorrowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panSumBookBorrowed.Controls.Add(this.txtTongSachMuon);
            this.panSumBookBorrowed.Controls.Add(this.lblSumBookBorrowed);
            this.panSumBookBorrowed.ForeColor = System.Drawing.Color.Transparent;
            this.panSumBookBorrowed.Location = new System.Drawing.Point(194, 54);
            this.panSumBookBorrowed.Name = "panSumBookBorrowed";
            this.panSumBookBorrowed.Size = new System.Drawing.Size(178, 102);
            this.panSumBookBorrowed.TabIndex = 23;
            // 
            // txtTongSachMuon
            // 
            this.txtTongSachMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTongSachMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongSachMuon.Enabled = false;
            this.txtTongSachMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSachMuon.Location = new System.Drawing.Point(61, 44);
            this.txtTongSachMuon.Name = "txtTongSachMuon";
            this.txtTongSachMuon.ReadOnly = true;
            this.txtTongSachMuon.Size = new System.Drawing.Size(57, 19);
            this.txtTongSachMuon.TabIndex = 17;
            this.txtTongSachMuon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSumBookBorrowed
            // 
            this.lblSumBookBorrowed.AutoSize = true;
            this.lblSumBookBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumBookBorrowed.ForeColor = System.Drawing.Color.Black;
            this.lblSumBookBorrowed.Location = new System.Drawing.Point(3, 0);
            this.lblSumBookBorrowed.Name = "lblSumBookBorrowed";
            this.lblSumBookBorrowed.Size = new System.Drawing.Size(127, 20);
            this.lblSumBookBorrowed.TabIndex = 15;
            this.lblSumBookBorrowed.Text = "Tổng sách mượn";
            // 
            // panSumLoanCard
            // 
            this.panSumLoanCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panSumLoanCard.Controls.Add(this.txtTongPhieuMuon);
            this.panSumLoanCard.Controls.Add(this.lblSumLoanCard);
            this.panSumLoanCard.Location = new System.Drawing.Point(10, 54);
            this.panSumLoanCard.Name = "panSumLoanCard";
            this.panSumLoanCard.Size = new System.Drawing.Size(178, 102);
            this.panSumLoanCard.TabIndex = 21;
            // 
            // txtTongPhieuMuon
            // 
            this.txtTongPhieuMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtTongPhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongPhieuMuon.Enabled = false;
            this.txtTongPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongPhieuMuon.Location = new System.Drawing.Point(61, 42);
            this.txtTongPhieuMuon.Name = "txtTongPhieuMuon";
            this.txtTongPhieuMuon.ReadOnly = true;
            this.txtTongPhieuMuon.Size = new System.Drawing.Size(57, 19);
            this.txtTongPhieuMuon.TabIndex = 17;
            this.txtTongPhieuMuon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSumLoanCard
            // 
            this.lblSumLoanCard.AutoSize = true;
            this.lblSumLoanCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumLoanCard.ForeColor = System.Drawing.Color.Black;
            this.lblSumLoanCard.Location = new System.Drawing.Point(3, 3);
            this.lblSumLoanCard.Name = "lblSumLoanCard";
            this.lblSumLoanCard.Size = new System.Drawing.Size(132, 20);
            this.lblSumLoanCard.TabIndex = 15;
            this.lblSumLoanCard.Text = "Tổng phiếu mượn";
            // 
            // panDataList
            // 
            this.panDataList.Controls.Add(this.dgvDataList);
            this.panDataList.Location = new System.Drawing.Point(12, 238);
            this.panDataList.Name = "panDataList";
            this.panDataList.Size = new System.Drawing.Size(720, 288);
            this.panDataList.TabIndex = 11;
            // 
            // dgvDataList
            // 
            this.dgvDataList.AllowUserToAddRows = false;
            this.dgvDataList.AllowUserToDeleteRows = false;
            this.dgvDataList.AllowUserToResizeColumns = false;
            this.dgvDataList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDataList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataList.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataList.GridColor = System.Drawing.Color.Black;
            this.dgvDataList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvDataList.Location = new System.Drawing.Point(0, 0);
            this.dgvDataList.MultiSelect = false;
            this.dgvDataList.Name = "dgvDataList";
            this.dgvDataList.ReadOnly = true;
            this.dgvDataList.RowHeadersVisible = false;
            this.dgvDataList.RowHeadersWidth = 82;
            this.dgvDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataList.Size = new System.Drawing.Size(720, 288);
            this.dgvDataList.TabIndex = 12;
            this.dgvDataList.TabStop = false;
            this.dgvDataList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDataList_CellFormatting);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(742, 538);
            this.ControlBox = false;
            this.Controls.Add(this.panTitle);
            this.Controls.Add(this.panFunction);
            this.Controls.Add(this.panStatistic);
            this.Controls.Add(this.panDataList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(758, 577);
            this.MinimumSize = new System.Drawing.Size(758, 577);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.panFunction.ResumeLayout(false);
            this.panStatistic.ResumeLayout(false);
            this.panStatistic.PerformLayout();
            this.panSumNotIntactBook.ResumeLayout(false);
            this.panSumNotIntactBook.PerformLayout();
            this.panSumBookBorrowed.ResumeLayout(false);
            this.panSumBookBorrowed.PerformLayout();
            this.panSumLoanCard.ResumeLayout(false);
            this.panSumLoanCard.PerformLayout();
            this.panDataList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panFunction;
        private System.Windows.Forms.Panel panStatistic;
        private System.Windows.Forms.Panel panDataList;
        private System.Windows.Forms.Panel panSumLoanCard;
        private System.Windows.Forms.TextBox txtTongPhieuMuon;
        private System.Windows.Forms.Label lblSumLoanCard;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDSSachHong;
        private System.Windows.Forms.Button btnDSTDGHH;
        private System.Windows.Forms.Panel panSumNotIntactBook;
        private System.Windows.Forms.TextBox txtTongSachHong;
        private System.Windows.Forms.Label lblSumNotIntactBook;
        private System.Windows.Forms.Panel panSumBookBorrowed;
        private System.Windows.Forms.TextBox txtTongSachMuon;
        private System.Windows.Forms.Label lblSumBookBorrowed;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.DataGridView dgvDataList;
    }
}