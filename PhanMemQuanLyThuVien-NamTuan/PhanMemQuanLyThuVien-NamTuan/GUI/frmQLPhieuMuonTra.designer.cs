namespace PhanMemQuanLyThuVien_NamTuan
{
    partial class frmQLPhieuMuonTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLPhieuMuonTra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.cboFilterCompleted = new System.Windows.Forms.ComboBox();
            this.chkFilterLate = new System.Windows.Forms.CheckBox();
            this.cboFilterLibrarianId = new System.Windows.Forms.ComboBox();
            this.cboFilterLibraryCardId = new System.Windows.Forms.ComboBox();
            this.cboFilterDate = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSelectFilter = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnExtend = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.lstBooks = new System.Windows.Forms.ListView();
            this.clbBooks = new System.Windows.Forms.CheckedListBox();
            this.cboLibraryCardId = new System.Windows.Forms.ComboBox();
            this.txtLibrarianId = new System.Windows.Forms.TextBox();
            this.txtLoanCardId = new System.Windows.Forms.TextBox();
            this.lblLibrarianId = new System.Windows.Forms.Label();
            this.lblLoanCardId = new System.Windows.Forms.Label();
            this.lblReaderId = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.grpInfoReader = new System.Windows.Forms.GroupBox();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDataList = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.grpInfoBook = new System.Windows.Forms.GroupBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpInfoReader.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.grpInfoBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "back-icon.png");
            this.imgIcon.Images.SetKeyName(1, "dealine-icon.png");
            this.imgIcon.Images.SetKeyName(2, "reset-icon.png");
            this.imgIcon.Images.SetKeyName(3, "borrow-book-icon.png");
            this.imgIcon.Images.SetKeyName(4, "filter-icon.png");
            this.imgIcon.Images.SetKeyName(5, "return-book-icon.png");
            this.imgIcon.Images.SetKeyName(6, "note-icon.png");
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.cboFilterCompleted);
            this.panel7.Controls.Add(this.chkFilterLate);
            this.panel7.Controls.Add(this.cboFilterLibrarianId);
            this.panel7.Controls.Add(this.cboFilterLibraryCardId);
            this.panel7.Controls.Add(this.cboFilterDate);
            this.panel7.Controls.Add(this.dtpEndDate);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.dtpStartDate);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.lblEndDate);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.lblSelectFilter);
            this.panel7.Controls.Add(this.lblStartDate);
            this.panel7.Location = new System.Drawing.Point(12, 153);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(510, 98);
            this.panel7.TabIndex = 20;
            // 
            // cboFilterCompleted
            // 
            this.cboFilterCompleted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterCompleted.FormattingEnabled = true;
            this.cboFilterCompleted.Location = new System.Drawing.Point(256, 72);
            this.cboFilterCompleted.Name = "cboFilterCompleted";
            this.cboFilterCompleted.Size = new System.Drawing.Size(118, 21);
            this.cboFilterCompleted.TabIndex = 37;
            // 
            // chkFilterLate
            // 
            this.chkFilterLate.AutoSize = true;
            this.chkFilterLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFilterLate.ForeColor = System.Drawing.Color.White;
            this.chkFilterLate.Location = new System.Drawing.Point(384, 72);
            this.chkFilterLate.Name = "chkFilterLate";
            this.chkFilterLate.Size = new System.Drawing.Size(79, 20);
            this.chkFilterLate.TabIndex = 38;
            this.chkFilterLate.Text = "Trễ hạn";
            this.chkFilterLate.UseVisualStyleBackColor = true;
            // 
            // cboFilterLibrarianId
            // 
            this.cboFilterLibrarianId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFilterLibrarianId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFilterLibrarianId.FormattingEnabled = true;
            this.cboFilterLibrarianId.Location = new System.Drawing.Point(384, 26);
            this.cboFilterLibrarianId.Name = "cboFilterLibrarianId";
            this.cboFilterLibrarianId.Size = new System.Drawing.Size(118, 21);
            this.cboFilterLibrarianId.TabIndex = 37;
            // 
            // cboFilterLibraryCardId
            // 
            this.cboFilterLibraryCardId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFilterLibraryCardId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFilterLibraryCardId.FormattingEnabled = true;
            this.cboFilterLibraryCardId.Location = new System.Drawing.Point(256, 26);
            this.cboFilterLibraryCardId.Name = "cboFilterLibraryCardId";
            this.cboFilterLibraryCardId.Size = new System.Drawing.Size(118, 21);
            this.cboFilterLibraryCardId.TabIndex = 37;
            // 
            // cboFilterDate
            // 
            this.cboFilterDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterDate.FormattingEnabled = true;
            this.cboFilterDate.Location = new System.Drawing.Point(58, 26);
            this.cboFilterDate.Name = "cboFilterDate";
            this.cboFilterDate.Size = new System.Drawing.Size(128, 21);
            this.cboFilterDate.TabIndex = 7;
            this.cboFilterDate.SelectedIndexChanged += new System.EventHandler(this.cboFilterDate_SelectedIndexChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(128, 72);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(115, 20);
            this.dtpEndDate.TabIndex = 5;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(253, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Đã trả";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(7, 72);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(115, 20);
            this.dtpStartDate.TabIndex = 6;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(381, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã TK";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(125, 53);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(72, 16);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(253, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã thẻ ĐG";
            // 
            // lblSelectFilter
            // 
            this.lblSelectFilter.AutoSize = true;
            this.lblSelectFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFilter.ForeColor = System.Drawing.Color.White;
            this.lblSelectFilter.Location = new System.Drawing.Point(55, 7);
            this.lblSelectFilter.Name = "lblSelectFilter";
            this.lblSelectFilter.Size = new System.Drawing.Size(105, 16);
            this.lblSelectFilter.TabIndex = 4;
            this.lblSelectFilter.Text = "Chọn ngày lọc";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(4, 53);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(63, 16);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Từ ngày";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 44);
            this.panel1.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(214, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(566, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ THÔNG TIN PHIẾU MƯỢN TRẢ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.btnBorrow);
            this.panel2.Controls.Add(this.btnExtend);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Location = new System.Drawing.Point(13, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 85);
            this.panel2.TabIndex = 16;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ImageIndex = 5;
            this.btnReturn.ImageList = this.imgIcon;
            this.btnReturn.Location = new System.Drawing.Point(87, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(78, 72);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Trả";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ImageIndex = 3;
            this.btnBorrow.ImageList = this.imgIcon;
            this.btnBorrow.Location = new System.Drawing.Point(3, 5);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(78, 72);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "Mượn";
            this.btnBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnExtend
            // 
            this.btnExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtend.ImageIndex = 1;
            this.btnExtend.ImageList = this.imgIcon;
            this.btnExtend.Location = new System.Drawing.Point(171, 5);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(78, 72);
            this.btnExtend.TabIndex = 5;
            this.btnExtend.Text = "Gia hạn";
            this.btnExtend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ImageIndex = 2;
            this.btnReset.ImageList = this.imgIcon;
            this.btnReset.Location = new System.Drawing.Point(339, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 72);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ImageIndex = 4;
            this.btnFilter.ImageList = this.imgIcon;
            this.btnFilter.Location = new System.Drawing.Point(255, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(78, 72);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ImageIndex = 0;
            this.btnBack.ImageList = this.imgIcon;
            this.btnBack.Location = new System.Drawing.Point(423, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 72);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Trở lại";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtSearchBook);
            this.panel4.Controls.Add(this.lstBooks);
            this.panel4.Controls.Add(this.clbBooks);
            this.panel4.Controls.Add(this.cboLibraryCardId);
            this.panel4.Controls.Add(this.txtLibrarianId);
            this.panel4.Controls.Add(this.txtLoanCardId);
            this.panel4.Controls.Add(this.lblLibrarianId);
            this.panel4.Controls.Add(this.lblLoanCardId);
            this.panel4.Controls.Add(this.lblReaderId);
            this.panel4.Controls.Add(this.dtpDueDate);
            this.panel4.Controls.Add(this.lblDueDate);
            this.panel4.Controls.Add(this.txtNote);
            this.panel4.Controls.Add(this.lblNote);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(683, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 325);
            this.panel4.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Đã chọn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tìm mã sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Chọn sách";
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(97, 110);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(202, 22);
            this.txtSearchBook.TabIndex = 40;
            this.txtSearchBook.TextChanged += new System.EventHandler(this.txtSearchBook_TextChanged);
            // 
            // lstBooks
            // 
            this.lstBooks.HideSelection = false;
            this.lstBooks.Location = new System.Drawing.Point(206, 153);
            this.lstBooks.MultiSelect = false;
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Scrollable = false;
            this.lstBooks.Size = new System.Drawing.Size(93, 89);
            this.lstBooks.TabIndex = 39;
            this.lstBooks.UseCompatibleStateImageBehavior = false;
            this.lstBooks.View = System.Windows.Forms.View.List;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // clbBooks
            // 
            this.clbBooks.FormattingEnabled = true;
            this.clbBooks.Location = new System.Drawing.Point(97, 153);
            this.clbBooks.Name = "clbBooks";
            this.clbBooks.Size = new System.Drawing.Size(103, 89);
            this.clbBooks.TabIndex = 38;
            this.clbBooks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbBooks_ItemCheck);
            this.clbBooks.SelectedIndexChanged += new System.EventHandler(this.clbBooks_SelectedIndexChanged);
            // 
            // cboLibraryCardId
            // 
            this.cboLibraryCardId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboLibraryCardId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboLibraryCardId.FormattingEnabled = true;
            this.cboLibraryCardId.Location = new System.Drawing.Point(97, 37);
            this.cboLibraryCardId.Name = "cboLibraryCardId";
            this.cboLibraryCardId.Size = new System.Drawing.Size(202, 24);
            this.cboLibraryCardId.TabIndex = 37;
            this.cboLibraryCardId.SelectedIndexChanged += new System.EventHandler(this.cboLibraryCardId_SelectedIndexChanged);
            // 
            // txtLibrarianId
            // 
            this.txtLibrarianId.Enabled = false;
            this.txtLibrarianId.Location = new System.Drawing.Point(97, 72);
            this.txtLibrarianId.Name = "txtLibrarianId";
            this.txtLibrarianId.Size = new System.Drawing.Size(202, 22);
            this.txtLibrarianId.TabIndex = 32;
            // 
            // txtLoanCardId
            // 
            this.txtLoanCardId.Enabled = false;
            this.txtLoanCardId.Location = new System.Drawing.Point(97, 5);
            this.txtLoanCardId.Name = "txtLoanCardId";
            this.txtLoanCardId.Size = new System.Drawing.Size(202, 22);
            this.txtLoanCardId.TabIndex = 33;
            // 
            // lblLibrarianId
            // 
            this.lblLibrarianId.AutoSize = true;
            this.lblLibrarianId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarianId.ForeColor = System.Drawing.Color.White;
            this.lblLibrarianId.Location = new System.Drawing.Point(19, 75);
            this.lblLibrarianId.Name = "lblLibrarianId";
            this.lblLibrarianId.Size = new System.Drawing.Size(76, 16);
            this.lblLibrarianId.TabIndex = 28;
            this.lblLibrarianId.Text = "Mã thủ thư";
            // 
            // lblLoanCardId
            // 
            this.lblLoanCardId.AutoSize = true;
            this.lblLoanCardId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanCardId.ForeColor = System.Drawing.Color.White;
            this.lblLoanCardId.Location = new System.Drawing.Point(25, 8);
            this.lblLoanCardId.Name = "lblLoanCardId";
            this.lblLoanCardId.Size = new System.Drawing.Size(70, 16);
            this.lblLoanCardId.TabIndex = 29;
            this.lblLoanCardId.Text = "Mã phiếu";
            // 
            // lblReaderId
            // 
            this.lblReaderId.AutoSize = true;
            this.lblReaderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReaderId.ForeColor = System.Drawing.Color.White;
            this.lblReaderId.Location = new System.Drawing.Point(17, 40);
            this.lblReaderId.Name = "lblReaderId";
            this.lblReaderId.Size = new System.Drawing.Size(78, 16);
            this.lblReaderId.TabIndex = 31;
            this.lblReaderId.Text = "Mã thẻ ĐG";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(97, 260);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(202, 22);
            this.dtpDueDate.TabIndex = 27;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.White;
            this.lblDueDate.Location = new System.Drawing.Point(37, 265);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(57, 16);
            this.lblDueDate.TabIndex = 26;
            this.lblDueDate.Text = "Hạn trả";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(97, 292);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(202, 22);
            this.txtNote.TabIndex = 25;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(37, 292);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(58, 16);
            this.lblNote.TabIndex = 24;
            this.lblNote.Text = "Ghi chú";
            // 
            // grpInfoReader
            // 
            this.grpInfoReader.Controls.Add(this.txtReaderName);
            this.grpInfoReader.Controls.Add(this.lblReaderName);
            this.grpInfoReader.Controls.Add(this.txtPhone);
            this.grpInfoReader.Controls.Add(this.lblPhone);
            this.grpInfoReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoReader.ForeColor = System.Drawing.Color.White;
            this.grpInfoReader.Location = new System.Drawing.Point(3, 117);
            this.grpInfoReader.Name = "grpInfoReader";
            this.grpInfoReader.Size = new System.Drawing.Size(318, 79);
            this.grpInfoReader.TabIndex = 5;
            this.grpInfoReader.TabStop = false;
            this.grpInfoReader.Text = "Thông tin độc giả";
            // 
            // txtReaderName
            // 
            this.txtReaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReaderName.Location = new System.Drawing.Point(94, 21);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.ReadOnly = true;
            this.txtReaderName.Size = new System.Drawing.Size(202, 22);
            this.txtReaderName.TabIndex = 4;
            this.txtReaderName.TabStop = false;
            // 
            // lblReaderName
            // 
            this.lblReaderName.AutoSize = true;
            this.lblReaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReaderName.ForeColor = System.Drawing.Color.White;
            this.lblReaderName.Location = new System.Drawing.Point(36, 23);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(52, 16);
            this.lblReaderName.TabIndex = 0;
            this.lblReaderName.Text = "Họ tên";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(94, 49);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(202, 22);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TabStop = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(51, 52);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(37, 16);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "SĐT";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDataList);
            this.panel3.Location = new System.Drawing.Point(13, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 337);
            this.panel3.TabIndex = 18;
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
            this.dgvDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.MaTDG,
            this.MaTK,
            this.NgayTao,
            this.HanTra,
            this.NgayTra,
            this.DaTra,
            this.GhiChu});
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
            this.dgvDataList.Size = new System.Drawing.Size(665, 337);
            this.dgvDataList.TabIndex = 10;
            this.dgvDataList.TabStop = false;
            this.dgvDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataList_CellClick);
            this.dgvDataList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDataList_CellFormatting);
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.MinimumWidth = 8;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            // 
            // MaTDG
            // 
            this.MaTDG.DataPropertyName = "MaTDG";
            this.MaTDG.HeaderText = "Mã thẻ ĐG";
            this.MaTDG.MinimumWidth = 8;
            this.MaTDG.Name = "MaTDG";
            this.MaTDG.ReadOnly = true;
            // 
            // MaTK
            // 
            this.MaTK.DataPropertyName = "MaTK";
            this.MaTK.HeaderText = "Mã TK";
            this.MaTK.MinimumWidth = 8;
            this.MaTK.Name = "MaTK";
            this.MaTK.ReadOnly = true;
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "NgayTao";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.NgayTao.DefaultCellStyle = dataGridViewCellStyle3;
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.MinimumWidth = 8;
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            // 
            // HanTra
            // 
            this.HanTra.DataPropertyName = "HanTra";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.HanTra.DefaultCellStyle = dataGridViewCellStyle4;
            this.HanTra.HeaderText = "Hạn trả";
            this.HanTra.MinimumWidth = 8;
            this.HanTra.Name = "HanTra";
            this.HanTra.ReadOnly = true;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.NgayTra.DefaultCellStyle = dataGridViewCellStyle5;
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.MinimumWidth = 8;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            // 
            // DaTra
            // 
            this.DaTra.DataPropertyName = "DaTra";
            this.DaTra.HeaderText = "Đã trả";
            this.DaTra.MinimumWidth = 8;
            this.DaTra.Name = "DaTra";
            this.DaTra.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 8;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(528, 196);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 55);
            this.panel5.TabIndex = 20;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(134, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tìm mã phiếu";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblQuantity);
            this.panel6.Controls.Add(this.txtQuantity);
            this.panel6.Location = new System.Drawing.Point(528, 153);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(149, 37);
            this.panel6.TabIndex = 19;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(3, 8);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 16);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(77, 7);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(63, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Teal;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.grpInfoBook);
            this.panel8.Controls.Add(this.grpInfoReader);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(683, 62);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(326, 201);
            this.panel8.TabIndex = 21;
            // 
            // grpInfoBook
            // 
            this.grpInfoBook.Controls.Add(this.txtBookName);
            this.grpInfoBook.Controls.Add(this.txtCategory);
            this.grpInfoBook.Controls.Add(this.lblBookName);
            this.grpInfoBook.Controls.Add(this.lblCategoryName);
            this.grpInfoBook.Controls.Add(this.lblAuthor);
            this.grpInfoBook.Controls.Add(this.txtAuthor);
            this.grpInfoBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoBook.ForeColor = System.Drawing.Color.White;
            this.grpInfoBook.Location = new System.Drawing.Point(3, 4);
            this.grpInfoBook.Name = "grpInfoBook";
            this.grpInfoBook.Size = new System.Drawing.Size(318, 107);
            this.grpInfoBook.TabIndex = 6;
            this.grpInfoBook.TabStop = false;
            this.grpInfoBook.Text = "Thông tin sách";
            // 
            // txtBookName
            // 
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
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(94, 75);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(202, 22);
            this.txtAuthor.TabIndex = 4;
            this.txtAuthor.TabStop = false;
            // 
            // frmQLPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1022, 606);
            this.ControlBox = false;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1038, 645);
            this.MinimumSize = new System.Drawing.Size(1038, 645);
            this.Name = "frmQLPhieuMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phiếu mượn trả";
            this.Load += new System.EventHandler(this.frmPhieuMuonTra_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.grpInfoReader.ResumeLayout(false);
            this.grpInfoReader.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.grpInfoBook.ResumeLayout(false);
            this.grpInfoBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox grpInfoReader;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboFilterDate;
        private System.Windows.Forms.Label lblSelectFilter;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox grpInfoBook;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtLibrarianId;
        private System.Windows.Forms.TextBox txtLoanCardId;
        private System.Windows.Forms.Label lblLibrarianId;
        private System.Windows.Forms.Label lblLoanCardId;
        private System.Windows.Forms.Label lblReaderId;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox cboLibraryCardId;
        private System.Windows.Forms.DataGridView dgvDataList;
        private System.Windows.Forms.CheckedListBox clbBooks;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.ListView lstBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFilterLibraryCardId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkFilterLate;
        private System.Windows.Forms.ComboBox cboFilterLibrarianId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFilterCompleted;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}