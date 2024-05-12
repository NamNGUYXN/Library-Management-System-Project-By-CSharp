namespace PhanMemQuanLyThuVien_NamTuan
{
    partial class frmQLSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSach));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblInStock = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nudInStock = new System.Windows.Forms.NumericUpDown();
            this.lblCheckManufacturer = new System.Windows.Forms.Label();
            this.lblCheckAuthor = new System.Windows.Forms.Label();
            this.lblCheckCategory = new System.Windows.Forms.Label();
            this.lblCheckInStock = new System.Windows.Forms.Label();
            this.lblCheckPublicationDate = new System.Windows.Forms.Label();
            this.lblCheckBookName = new System.Windows.Forms.Label();
            this.cboAuthor = new System.Windows.Forms.ComboBox();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtPublicationDate = new System.Windows.Forms.TextBox();
            this.txtInStock = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblPublicationDate = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.dgvDataList = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.radBookName = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radBookId = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cboFilterPublisher = new System.Windows.Forms.ComboBox();
            this.cboFilterAuthor = new System.Windows.Forms.ComboBox();
            this.cboFilterCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 44);
            this.panel1.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(300, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(396, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ THÔNG TIN SÁCH";
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "add-icon.png");
            this.imgIcon.Images.SetKeyName(1, "back-icon.png");
            this.imgIcon.Images.SetKeyName(2, "delete-icon.png");
            this.imgIcon.Images.SetKeyName(3, "edit-icon.png");
            this.imgIcon.Images.SetKeyName(4, "reset-icon.png");
            this.imgIcon.Images.SetKeyName(5, "filter-icon.png");
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(105, 84);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(207, 22);
            this.txtBookName.TabIndex = 1;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthors.ForeColor = System.Drawing.Color.White;
            this.lblAuthors.Location = new System.Drawing.Point(39, 218);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(60, 16);
            this.lblAuthors.TabIndex = 0;
            this.lblAuthors.Text = "Tác giả";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturer.ForeColor = System.Drawing.Color.White;
            this.lblManufacturer.Location = new System.Drawing.Point(2, 286);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(97, 16);
            this.lblManufacturer.TabIndex = 0;
            this.lblManufacturer.Text = "Nhà xuất bản";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(35, 153);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(64, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Thể loại";
            // 
            // lblInStock
            // 
            this.lblInStock.AutoSize = true;
            this.lblInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInStock.ForeColor = System.Drawing.Color.White;
            this.lblInStock.Location = new System.Drawing.Point(31, 410);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(68, 16);
            this.lblInStock.TabIndex = 0;
            this.lblInStock.Text = "Số lượng";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.White;
            this.lblBookName.Location = new System.Drawing.Point(28, 87);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(71, 16);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Tên sách";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.nudInStock);
            this.panel4.Controls.Add(this.lblCheckManufacturer);
            this.panel4.Controls.Add(this.lblCheckAuthor);
            this.panel4.Controls.Add(this.lblCheckCategory);
            this.panel4.Controls.Add(this.lblCheckInStock);
            this.panel4.Controls.Add(this.lblCheckPublicationDate);
            this.panel4.Controls.Add(this.lblCheckBookName);
            this.panel4.Controls.Add(this.cboAuthor);
            this.panel4.Controls.Add(this.cboPublisher);
            this.panel4.Controls.Add(this.cboCategory);
            this.panel4.Controls.Add(this.txtPublicationDate);
            this.panel4.Controls.Add(this.txtInStock);
            this.panel4.Controls.Add(this.txtBookId);
            this.panel4.Controls.Add(this.txtBookName);
            this.panel4.Controls.Add(this.lblAuthors);
            this.panel4.Controls.Add(this.lblManufacturer);
            this.panel4.Controls.Add(this.lblCategory);
            this.panel4.Controls.Add(this.lblPublicationDate);
            this.panel4.Controls.Add(this.lblBookId);
            this.panel4.Controls.Add(this.lblInStock);
            this.panel4.Controls.Add(this.lblBookName);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(683, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 532);
            this.panel4.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 346);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // nudInStock
            // 
            this.nudInStock.Location = new System.Drawing.Point(105, 408);
            this.nudInStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInStock.Name = "nudInStock";
            this.nudInStock.Size = new System.Drawing.Size(207, 22);
            this.nudInStock.TabIndex = 14;
            // 
            // lblCheckManufacturer
            // 
            this.lblCheckManufacturer.AutoSize = true;
            this.lblCheckManufacturer.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckManufacturer.Location = new System.Drawing.Point(102, 310);
            this.lblCheckManufacturer.Name = "lblCheckManufacturer";
            this.lblCheckManufacturer.Size = new System.Drawing.Size(0, 16);
            this.lblCheckManufacturer.TabIndex = 13;
            // 
            // lblCheckAuthor
            // 
            this.lblCheckAuthor.AutoSize = true;
            this.lblCheckAuthor.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckAuthor.Location = new System.Drawing.Point(102, 242);
            this.lblCheckAuthor.Name = "lblCheckAuthor";
            this.lblCheckAuthor.Size = new System.Drawing.Size(0, 16);
            this.lblCheckAuthor.TabIndex = 13;
            // 
            // lblCheckCategory
            // 
            this.lblCheckCategory.AutoSize = true;
            this.lblCheckCategory.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckCategory.Location = new System.Drawing.Point(102, 177);
            this.lblCheckCategory.Name = "lblCheckCategory";
            this.lblCheckCategory.Size = new System.Drawing.Size(0, 16);
            this.lblCheckCategory.TabIndex = 13;
            // 
            // lblCheckInStock
            // 
            this.lblCheckInStock.AutoSize = true;
            this.lblCheckInStock.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckInStock.Location = new System.Drawing.Point(102, 433);
            this.lblCheckInStock.Name = "lblCheckInStock";
            this.lblCheckInStock.Size = new System.Drawing.Size(0, 16);
            this.lblCheckInStock.TabIndex = 12;
            // 
            // lblCheckPublicationDate
            // 
            this.lblCheckPublicationDate.AutoSize = true;
            this.lblCheckPublicationDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckPublicationDate.Location = new System.Drawing.Point(102, 373);
            this.lblCheckPublicationDate.Name = "lblCheckPublicationDate";
            this.lblCheckPublicationDate.Size = new System.Drawing.Size(0, 16);
            this.lblCheckPublicationDate.TabIndex = 12;
            // 
            // lblCheckBookName
            // 
            this.lblCheckBookName.AutoSize = true;
            this.lblCheckBookName.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckBookName.Location = new System.Drawing.Point(102, 109);
            this.lblCheckBookName.Name = "lblCheckBookName";
            this.lblCheckBookName.Size = new System.Drawing.Size(0, 16);
            this.lblCheckBookName.TabIndex = 12;
            // 
            // cboAuthor
            // 
            this.cboAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAuthor.FormattingEnabled = true;
            this.cboAuthor.Location = new System.Drawing.Point(105, 215);
            this.cboAuthor.Name = "cboAuthor";
            this.cboAuthor.Size = new System.Drawing.Size(207, 24);
            this.cboAuthor.TabIndex = 2;
            this.cboAuthor.TextChanged += new System.EventHandler(this.cboAuthor_TextChanged);
            // 
            // cboPublisher
            // 
            this.cboPublisher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPublisher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(105, 283);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(207, 24);
            this.cboPublisher.TabIndex = 2;
            this.cboPublisher.TextChanged += new System.EventHandler(this.cboManufacturer_TextChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(105, 150);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(207, 24);
            this.cboCategory.TabIndex = 2;
            this.cboCategory.TextChanged += new System.EventHandler(this.cboCategory_TextChanged);
            // 
            // txtPublicationDate
            // 
            this.txtPublicationDate.Location = new System.Drawing.Point(105, 479);
            this.txtPublicationDate.Name = "txtPublicationDate";
            this.txtPublicationDate.Size = new System.Drawing.Size(207, 22);
            this.txtPublicationDate.TabIndex = 1;
            this.txtPublicationDate.TextChanged += new System.EventHandler(this.txtPublicationDate_TextChanged);
            this.txtPublicationDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPublicationDate_KeyPress);
            // 
            // txtInStock
            // 
            this.txtInStock.Location = new System.Drawing.Point(105, 436);
            this.txtInStock.Name = "txtInStock";
            this.txtInStock.Size = new System.Drawing.Size(207, 22);
            this.txtInStock.TabIndex = 1;
            this.txtInStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInStock_KeyPress);
            // 
            // txtBookId
            // 
            this.txtBookId.Enabled = false;
            this.txtBookId.Location = new System.Drawing.Point(105, 18);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(207, 22);
            this.txtBookId.TabIndex = 1;
            // 
            // lblPublicationDate
            // 
            this.lblPublicationDate.AutoSize = true;
            this.lblPublicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicationDate.ForeColor = System.Drawing.Color.White;
            this.lblPublicationDate.Location = new System.Drawing.Point(-2, 351);
            this.lblPublicationDate.Name = "lblPublicationDate";
            this.lblPublicationDate.Size = new System.Drawing.Size(101, 16);
            this.lblPublicationDate.TabIndex = 0;
            this.lblPublicationDate.Text = "Năm xuất bản";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.ForeColor = System.Drawing.Color.White;
            this.lblBookId.Location = new System.Drawing.Point(34, 21);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(65, 16);
            this.lblBookId.TabIndex = 0;
            this.lblBookId.Text = "Mã sách";
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
            this.MaSach,
            this.TenSach,
            this.MaTL,
            this.TenTL,
            this.MaTG,
            this.HoTenTG,
            this.MaNXB,
            this.TenNXB,
            this.NamXuatBan,
            this.SoLuong});
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
            this.dgvDataList.Size = new System.Drawing.Size(665, 344);
            this.dgvDataList.TabIndex = 9;
            this.dgvDataList.TabStop = false;
            this.dgvDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataList_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã";
            this.MaSach.MinimumWidth = 8;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên";
            this.TenSach.MinimumWidth = 8;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // MaTL
            // 
            this.MaTL.DataPropertyName = "MaTL";
            this.MaTL.HeaderText = "Mã TL";
            this.MaTL.MinimumWidth = 8;
            this.MaTL.Name = "MaTL";
            this.MaTL.ReadOnly = true;
            this.MaTL.Visible = false;
            // 
            // TenTL
            // 
            this.TenTL.DataPropertyName = "TenTL";
            this.TenTL.HeaderText = "Thể loại";
            this.TenTL.MinimumWidth = 8;
            this.TenTL.Name = "TenTL";
            this.TenTL.ReadOnly = true;
            // 
            // MaTG
            // 
            this.MaTG.DataPropertyName = "MaTG";
            this.MaTG.HeaderText = "Mã TG";
            this.MaTG.MinimumWidth = 8;
            this.MaTG.Name = "MaTG";
            this.MaTG.ReadOnly = true;
            this.MaTG.Visible = false;
            // 
            // HoTenTG
            // 
            this.HoTenTG.DataPropertyName = "HoTenTG";
            this.HoTenTG.HeaderText = "Tác giả";
            this.HoTenTG.MinimumWidth = 8;
            this.HoTenTG.Name = "HoTenTG";
            this.HoTenTG.ReadOnly = true;
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.MinimumWidth = 8;
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.ReadOnly = true;
            this.MaNXB.Visible = false;
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "TenNXB";
            this.TenNXB.HeaderText = "NXB";
            this.TenNXB.MinimumWidth = 8;
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.ReadOnly = true;
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.DataPropertyName = "NamXuatBan";
            this.NamXuatBan.HeaderText = "Năm XB";
            this.NamXuatBan.MinimumWidth = 8;
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDataList);
            this.panel3.Location = new System.Drawing.Point(12, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 344);
            this.panel3.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ImageIndex = 1;
            this.btnBack.ImageList = this.imgIcon;
            this.btnBack.Location = new System.Drawing.Point(423, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 72);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Trở lại";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ImageIndex = 4;
            this.btnReset.ImageList = this.imgIcon;
            this.btnReset.Location = new System.Drawing.Point(339, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 72);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ImageIndex = 3;
            this.btnUpdate.ImageList = this.imgIcon;
            this.btnUpdate.Location = new System.Drawing.Point(171, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 72);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.imgIcon;
            this.btnDelete.Location = new System.Drawing.Point(87, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 72);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.imgIcon;
            this.btnAdd.Location = new System.Drawing.Point(3, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 72);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Location = new System.Drawing.Point(12, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 85);
            this.panel2.TabIndex = 9;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ImageIndex = 5;
            this.btnFilter.ImageList = this.imgIcon;
            this.btnFilter.Location = new System.Drawing.Point(255, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(78, 72);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // radBookName
            // 
            this.radBookName.AutoSize = true;
            this.radBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBookName.ForeColor = System.Drawing.Color.White;
            this.radBookName.Location = new System.Drawing.Point(121, 8);
            this.radBookName.Name = "radBookName";
            this.radBookName.Size = new System.Drawing.Size(89, 20);
            this.radBookName.TabIndex = 6;
            this.radBookName.Text = "Tên sách";
            this.radBookName.UseVisualStyleBackColor = true;
            this.radBookName.CheckedChanged += new System.EventHandler(this.radBookName_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(228, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(282, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.radBookName);
            this.panel5.Controls.Add(this.radBookId);
            this.panel5.Location = new System.Drawing.Point(12, 207);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(522, 37);
            this.panel5.TabIndex = 13;
            // 
            // radBookId
            // 
            this.radBookId.AutoSize = true;
            this.radBookId.Checked = true;
            this.radBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBookId.ForeColor = System.Drawing.Color.White;
            this.radBookId.Location = new System.Drawing.Point(19, 8);
            this.radBookId.Name = "radBookId";
            this.radBookId.Size = new System.Drawing.Size(83, 20);
            this.radBookId.TabIndex = 6;
            this.radBookId.TabStop = true;
            this.radBookId.Text = "Mã sách";
            this.radBookId.UseVisualStyleBackColor = true;
            this.radBookId.CheckedChanged += new System.EventHandler(this.radBookId_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblQuantity);
            this.panel6.Controls.Add(this.txtQuantity);
            this.panel6.Location = new System.Drawing.Point(540, 207);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(137, 37);
            this.panel6.TabIndex = 20;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(3, 9);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 16);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(77, 8);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(53, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.cboFilterPublisher);
            this.panel7.Controls.Add(this.cboFilterAuthor);
            this.panel7.Controls.Add(this.cboFilterCategory);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(12, 152);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(665, 49);
            this.panel7.TabIndex = 21;
            // 
            // cboFilterPublisher
            // 
            this.cboFilterPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterPublisher.FormattingEnabled = true;
            this.cboFilterPublisher.Location = new System.Drawing.Point(451, 23);
            this.cboFilterPublisher.Name = "cboFilterPublisher";
            this.cboFilterPublisher.Size = new System.Drawing.Size(207, 21);
            this.cboFilterPublisher.TabIndex = 2;
            // 
            // cboFilterAuthor
            // 
            this.cboFilterAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterAuthor.FormattingEnabled = true;
            this.cboFilterAuthor.Location = new System.Drawing.Point(229, 23);
            this.cboFilterAuthor.Name = "cboFilterAuthor";
            this.cboFilterAuthor.Size = new System.Drawing.Size(207, 21);
            this.cboFilterAuthor.TabIndex = 2;
            // 
            // cboFilterCategory
            // 
            this.cboFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterCategory.FormattingEnabled = true;
            this.cboFilterCategory.Location = new System.Drawing.Point(7, 23);
            this.cboFilterCategory.Name = "cboFilterCategory";
            this.cboFilterCategory.Size = new System.Drawing.Size(207, 21);
            this.cboFilterCategory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(502, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhà xuất bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(303, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tác giả";
            // 
            // frmQLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1022, 606);
            this.ControlBox = false;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1038, 645);
            this.MinimumSize = new System.Drawing.Size(1038, 645);
            this.Name = "frmQLSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboPublisher;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtInStock;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.ComboBox cboAuthor;
        private System.Windows.Forms.DataGridView dgvDataList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radBookName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPublicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.RadioButton radBookId;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cboFilterPublisher;
        private System.Windows.Forms.ComboBox cboFilterAuthor;
        private System.Windows.Forms.ComboBox cboFilterCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtPublicationDate;
        private System.Windows.Forms.Label lblCheckInStock;
        private System.Windows.Forms.Label lblCheckPublicationDate;
        private System.Windows.Forms.Label lblCheckBookName;
        private System.Windows.Forms.Label lblCheckManufacturer;
        private System.Windows.Forms.Label lblCheckAuthor;
        private System.Windows.Forms.Label lblCheckCategory;
        private System.Windows.Forms.NumericUpDown nudInStock;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}