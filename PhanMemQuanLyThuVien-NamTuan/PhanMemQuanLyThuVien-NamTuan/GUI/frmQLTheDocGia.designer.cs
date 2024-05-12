namespace PhanMemQuanLyThuVien_NamTuan
{
    partial class frmQLTheDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTheDocGia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblIdCard = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCheckIdCard = new System.Windows.Forms.Label();
            this.lblCheckPhone = new System.Windows.Forms.Label();
            this.lblCheckAddress = new System.Windows.Forms.Label();
            this.lblCheckName = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.txtLibraryCardId = new System.Windows.Forms.TextBox();
            this.lblLibraryCardId = new System.Windows.Forms.Label();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radPhone = new System.Windows.Forms.RadioButton();
            this.radIdCard = new System.Windows.Forms.RadioButton();
            this.radReaderName = new System.Windows.Forms.RadioButton();
            this.radReaderId = new System.Windows.Forms.RadioButton();
            this.btnExtend = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDataList = new System.Windows.Forms.DataGridView();
            this.MaTDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.ForeColor = System.Drawing.Color.White;
            this.radFemale.Location = new System.Drawing.Point(178, 136);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(44, 20);
            this.radFemale.TabIndex = 3;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.ForeColor = System.Drawing.Color.White;
            this.radMale.Location = new System.Drawing.Point(99, 136);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(57, 20);
            this.radMale.TabIndex = 2;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(99, 192);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(207, 22);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtIdCard
            // 
            this.txtIdCard.Location = new System.Drawing.Point(99, 306);
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(207, 22);
            this.txtIdCard.TabIndex = 5;
            this.txtIdCard.TextChanged += new System.EventHandler(this.txtIdCard_TextChanged);
            this.txtIdCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCard_KeyPress);
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
            this.lblTitle.Location = new System.Drawing.Point(246, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(504, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ THÔNG TIN THẺ ĐỘC GIẢ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(99, 249);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(207, 22);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // lblIdCard
            // 
            this.lblIdCard.AutoSize = true;
            this.lblIdCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCard.ForeColor = System.Drawing.Color.White;
            this.lblIdCard.Location = new System.Drawing.Point(45, 309);
            this.lblIdCard.Name = "lblIdCard";
            this.lblIdCard.Size = new System.Drawing.Size(48, 16);
            this.lblIdCard.TabIndex = 0;
            this.lblIdCard.Text = "CCCD";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(56, 252);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(37, 16);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "SĐT";
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "add-icon.png");
            this.imgIcon.Images.SetKeyName(1, "back-icon.png");
            this.imgIcon.Images.SetKeyName(2, "dealine-icon.png");
            this.imgIcon.Images.SetKeyName(3, "delete-icon.png");
            this.imgIcon.Images.SetKeyName(4, "edit-icon.png");
            this.imgIcon.Images.SetKeyName(5, "reset-icon.png");
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(30, 138);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 16);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Giới tính";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.ForeColor = System.Drawing.Color.White;
            this.lblAdress.Location = new System.Drawing.Point(39, 195);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(54, 16);
            this.lblAdress.TabIndex = 0;
            this.lblAdress.Text = "Địa chỉ";
            // 
            // lblReaderName
            // 
            this.lblReaderName.AutoSize = true;
            this.lblReaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReaderName.ForeColor = System.Drawing.Color.White;
            this.lblReaderName.Location = new System.Drawing.Point(41, 81);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(52, 16);
            this.lblReaderName.TabIndex = 0;
            this.lblReaderName.Text = "Họ tên";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblCheckIdCard);
            this.panel4.Controls.Add(this.lblCheckPhone);
            this.panel4.Controls.Add(this.lblCheckAddress);
            this.panel4.Controls.Add(this.lblCheckName);
            this.panel4.Controls.Add(this.dtpExpiryDate);
            this.panel4.Controls.Add(this.txtLibraryCardId);
            this.panel4.Controls.Add(this.lblLibraryCardId);
            this.panel4.Controls.Add(this.txtReaderName);
            this.panel4.Controls.Add(this.radFemale);
            this.panel4.Controls.Add(this.radMale);
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.txtIdCard);
            this.panel4.Controls.Add(this.txtPhone);
            this.panel4.Controls.Add(this.lblExpiryDate);
            this.panel4.Controls.Add(this.lblIdCard);
            this.panel4.Controls.Add(this.lblPhone);
            this.panel4.Controls.Add(this.lblGender);
            this.panel4.Controls.Add(this.lblAdress);
            this.panel4.Controls.Add(this.lblReaderName);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(683, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 533);
            this.panel4.TabIndex = 10;
            // 
            // lblCheckIdCard
            // 
            this.lblCheckIdCard.AutoSize = true;
            this.lblCheckIdCard.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckIdCard.Location = new System.Drawing.Point(97, 331);
            this.lblCheckIdCard.Name = "lblCheckIdCard";
            this.lblCheckIdCard.Size = new System.Drawing.Size(0, 16);
            this.lblCheckIdCard.TabIndex = 13;
            // 
            // lblCheckPhone
            // 
            this.lblCheckPhone.AutoSize = true;
            this.lblCheckPhone.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckPhone.Location = new System.Drawing.Point(96, 274);
            this.lblCheckPhone.Name = "lblCheckPhone";
            this.lblCheckPhone.Size = new System.Drawing.Size(0, 16);
            this.lblCheckPhone.TabIndex = 13;
            // 
            // lblCheckAddress
            // 
            this.lblCheckAddress.AutoSize = true;
            this.lblCheckAddress.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckAddress.Location = new System.Drawing.Point(96, 217);
            this.lblCheckAddress.Name = "lblCheckAddress";
            this.lblCheckAddress.Size = new System.Drawing.Size(0, 16);
            this.lblCheckAddress.TabIndex = 13;
            // 
            // lblCheckName
            // 
            this.lblCheckName.AutoSize = true;
            this.lblCheckName.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckName.Location = new System.Drawing.Point(97, 103);
            this.lblCheckName.Name = "lblCheckName";
            this.lblCheckName.Size = new System.Drawing.Size(0, 16);
            this.lblCheckName.TabIndex = 13;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CustomFormat = "dd/MM/yyyy";
            this.dtpExpiryDate.Enabled = false;
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(100, 360);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(207, 22);
            this.dtpExpiryDate.TabIndex = 8;
            // 
            // txtLibraryCardId
            // 
            this.txtLibraryCardId.Enabled = false;
            this.txtLibraryCardId.Location = new System.Drawing.Point(100, 21);
            this.txtLibraryCardId.Name = "txtLibraryCardId";
            this.txtLibraryCardId.Size = new System.Drawing.Size(207, 22);
            this.txtLibraryCardId.TabIndex = 7;
            // 
            // lblLibraryCardId
            // 
            this.lblLibraryCardId.AutoSize = true;
            this.lblLibraryCardId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryCardId.ForeColor = System.Drawing.Color.White;
            this.lblLibraryCardId.Location = new System.Drawing.Point(15, 24);
            this.lblLibraryCardId.Name = "lblLibraryCardId";
            this.lblLibraryCardId.Size = new System.Drawing.Size(78, 16);
            this.lblLibraryCardId.TabIndex = 6;
            this.lblLibraryCardId.Text = "Mã thẻ ĐG";
            // 
            // txtReaderName
            // 
            this.txtReaderName.Location = new System.Drawing.Point(100, 78);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(207, 22);
            this.txtReaderName.TabIndex = 1;
            this.txtReaderName.TextChanged += new System.EventHandler(this.txtReaderName_TextChanged);
            this.txtReaderName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReaderName_KeyPress);
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.ForeColor = System.Drawing.Color.White;
            this.lblExpiryDate.Location = new System.Drawing.Point(3, 365);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(98, 16);
            this.lblExpiryDate.TabIndex = 0;
            this.lblExpiryDate.Text = "Ngày hết hạn";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.radPhone);
            this.panel5.Controls.Add(this.radIdCard);
            this.panel5.Controls.Add(this.radReaderName);
            this.panel5.Controls.Add(this.radReaderId);
            this.panel5.Location = new System.Drawing.Point(12, 153);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(522, 37);
            this.panel5.TabIndex = 17;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(303, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // radPhone
            // 
            this.radPhone.AutoSize = true;
            this.radPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPhone.ForeColor = System.Drawing.Color.White;
            this.radPhone.Location = new System.Drawing.Point(242, 8);
            this.radPhone.Name = "radPhone";
            this.radPhone.Size = new System.Drawing.Size(55, 20);
            this.radPhone.TabIndex = 6;
            this.radPhone.Text = "SĐT";
            this.radPhone.UseVisualStyleBackColor = true;
            this.radPhone.CheckedChanged += new System.EventHandler(this.radPhone_CheckedChanged);
            // 
            // radIdCard
            // 
            this.radIdCard.AutoSize = true;
            this.radIdCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIdCard.ForeColor = System.Drawing.Color.White;
            this.radIdCard.Location = new System.Drawing.Point(168, 8);
            this.radIdCard.Name = "radIdCard";
            this.radIdCard.Size = new System.Drawing.Size(66, 20);
            this.radIdCard.TabIndex = 6;
            this.radIdCard.Text = "CCCD";
            this.radIdCard.UseVisualStyleBackColor = true;
            this.radIdCard.CheckedChanged += new System.EventHandler(this.radIdCard_CheckedChanged);
            // 
            // radReaderName
            // 
            this.radReaderName.AutoSize = true;
            this.radReaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radReaderName.ForeColor = System.Drawing.Color.White;
            this.radReaderName.Location = new System.Drawing.Point(90, 8);
            this.radReaderName.Name = "radReaderName";
            this.radReaderName.Size = new System.Drawing.Size(70, 20);
            this.radReaderName.TabIndex = 6;
            this.radReaderName.Text = "Họ tên";
            this.radReaderName.UseVisualStyleBackColor = true;
            this.radReaderName.CheckedChanged += new System.EventHandler(this.radReaderName_CheckedChanged);
            // 
            // radReaderId
            // 
            this.radReaderId.AutoSize = true;
            this.radReaderId.Checked = true;
            this.radReaderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radReaderId.ForeColor = System.Drawing.Color.White;
            this.radReaderId.Location = new System.Drawing.Point(11, 8);
            this.radReaderId.Name = "radReaderId";
            this.radReaderId.Size = new System.Drawing.Size(71, 20);
            this.radReaderId.TabIndex = 6;
            this.radReaderId.TabStop = true;
            this.radReaderId.Text = "Mã thẻ";
            this.radReaderId.UseVisualStyleBackColor = true;
            this.radReaderId.CheckedChanged += new System.EventHandler(this.radReaderId_CheckedChanged);
            // 
            // btnExtend
            // 
            this.btnExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtend.ImageIndex = 2;
            this.btnExtend.ImageList = this.imgIcon;
            this.btnExtend.Location = new System.Drawing.Point(255, 5);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(78, 72);
            this.btnExtend.TabIndex = 0;
            this.btnExtend.Text = "Gia hạn";
            this.btnExtend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDataList);
            this.panel3.Location = new System.Drawing.Point(12, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 399);
            this.panel3.TabIndex = 15;
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
            this.MaTDG,
            this.HoTenDG,
            this.GioiTinh,
            this.DiaChi,
            this.SDT,
            this.CCCD,
            this.NgayTao,
            this.NgayHetHan});
            this.dgvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataList.GridColor = System.Drawing.Color.Black;
            this.dgvDataList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvDataList.Location = new System.Drawing.Point(0, 0);
            this.dgvDataList.MultiSelect = false;
            this.dgvDataList.Name = "dgvDataList";
            this.dgvDataList.ReadOnly = true;
            this.dgvDataList.RowHeadersVisible = false;
            this.dgvDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataList.Size = new System.Drawing.Size(665, 399);
            this.dgvDataList.TabIndex = 10;
            this.dgvDataList.TabStop = false;
            this.dgvDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataList_CellClick);
            // 
            // MaTDG
            // 
            this.MaTDG.DataPropertyName = "MaTDG";
            this.MaTDG.HeaderText = "Mã thẻ";
            this.MaTDG.Name = "MaTDG";
            this.MaTDG.ReadOnly = true;
            // 
            // HoTenDG
            // 
            this.HoTenDG.DataPropertyName = "HoTenDG";
            this.HoTenDG.HeaderText = "Họ tên";
            this.HoTenDG.Name = "HoTenDG";
            this.HoTenDG.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "NgayTao";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.NgayTao.DefaultCellStyle = dataGridViewCellStyle3;
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.NgayHetHan.DefaultCellStyle = dataGridViewCellStyle4;
            this.NgayHetHan.HeaderText = "Ngày hết";
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnExtend);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 85);
            this.panel2.TabIndex = 18;
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
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageIndex = 3;
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
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ImageIndex = 4;
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
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ImageIndex = 5;
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblQuantity);
            this.panel6.Controls.Add(this.txtQuantity);
            this.panel6.Location = new System.Drawing.Point(540, 153);
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
            // frmQLTheDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1022, 606);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1038, 645);
            this.MinimumSize = new System.Drawing.Size(1038, 645);
            this.Name = "frmQLTheDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thẻ độc giả";
            this.Load += new System.EventHandler(this.frmTheDocGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtIdCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblIdCard;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radReaderName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvDataList;
        private System.Windows.Forms.TextBox txtLibraryCardId;
        private System.Windows.Forms.Label lblLibraryCardId;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.RadioButton radIdCard;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.RadioButton radReaderId;
        private System.Windows.Forms.RadioButton radPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.Label lblCheckIdCard;
        private System.Windows.Forms.Label lblCheckPhone;
        private System.Windows.Forms.Label lblCheckAddress;
        private System.Windows.Forms.Label lblCheckName;
    }
}