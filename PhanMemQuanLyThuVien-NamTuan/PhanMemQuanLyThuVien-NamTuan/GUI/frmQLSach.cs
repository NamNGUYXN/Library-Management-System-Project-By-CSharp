using PhanMemQuanLyThuVien_NamTuan.BUS;
using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyThuVien_NamTuan
{
    public partial class frmQLSach : Form
    {
        public frmQLSach()
        {
            InitializeComponent();
        }

        void DisplayCategory()
        {
            DataTable data = TheLoaiBUS.GetData();
            cboCategory.DataSource = data;
            cboCategory.DisplayMember = "TenTL";
            cboCategory.ValueMember = "MaTL";
        }

        void DisplayAuthor()
        {
            DataTable data = TacGiaBUS.GetData();
            cboAuthor.DataSource = data;
            cboAuthor.DisplayMember = "HoTenTG";
            cboAuthor.ValueMember = "MaTG";
        }

        void DisplayPublisher()
        {
            DataTable data = NhaXuatBanBUS.GetData();
            cboPublisher.DataSource = data;
            cboPublisher.DisplayMember = "TenNXB";
            cboPublisher.ValueMember = "MaNXB";
        }

        void DisplayFilterCategory()
        {
            DataTable data = TheLoaiBUS.GetData();
            cboFilterCategory.Items.Add("Tất cả");
            foreach (DataRow dr in data.Rows)
            {
                cboFilterCategory.Items.Add(dr[1]);
            }
        }

        void DisplayFilterAuthor()
        {
            DataTable data = TacGiaBUS.GetData();
            cboFilterAuthor.Items.Add("Tất cả");
            foreach (DataRow dr in data.Rows)
            {
                cboFilterAuthor.Items.Add(dr[1]);
            }
        }

        void DisplayFilterPublisher()
        {
            DataTable data = NhaXuatBanBUS.GetData();
            cboFilterPublisher.Items.Add("Tất cả");
            foreach (DataRow dr in data.Rows)
            {
                cboFilterPublisher.Items.Add(dr[1]);
            }
        }

        void DisplayNextBookId()
        {
            txtBookId.Text = SachBUS.CreateNextId();
        }

        void DisplayBook(DataTable data = null)
        {
            if (data == null) data = SachBUS.GetData();

            dgvDataList.DataSource = data;
            txtQuantity.Text = data.Rows.Count.ToString();

            // Xóa việc chương trình tự chọn hàng đầu tiên trong DataGridView
            dgvDataList.ClearSelection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            // Không tự động tạo các cột tiêu đề
            dgvDataList.AutoGenerateColumns = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            // Hiện dữ liệu sách vào DataGridView
            DisplayBook();
            // Hiện mã sách kế tiếp
            DisplayNextBookId();
            // Hiện dữ liệu trong combobox ở phần nhập liệu
            DisplayCategory();
            DisplayAuthor();
            DisplayPublisher();
            cboCategory.SelectedIndex = -1;
            cboAuthor.SelectedIndex = -1;
            cboPublisher.SelectedIndex = -1;
            // Hiện dữ liệu trong combobox ở phần bộ lọc
            DisplayFilterCategory();
            DisplayFilterAuthor();
            DisplayFilterPublisher();
            cboFilterCategory.SelectedIndex = 0;
            cboFilterAuthor.SelectedIndex = 0;
            cboFilterPublisher.SelectedIndex = 0;
            // Hiện lời nhắc dưới ô nhập
            lblCheckBookName.Text = "Vui lòng nhập tên sách!";
            lblCheckPublicationDate.Text = "Vui lòng nhập năm xuất bản!";
        }

        // Sự kiện xảy ra khi chọn vào 1 dòng dữ liệu trong DataGridView
        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            try
            {
                string MaSach, TenSach, TheLoai, TacGia, NXB;
                MaSach = dgvDataList.CurrentRow.Cells["MaSach"].Value.ToString();
                TenSach = dgvDataList.CurrentRow.Cells["TenSach"].Value.ToString();
                TheLoai = dgvDataList.CurrentRow.Cells["MaTL"].Value.ToString();
                TacGia = dgvDataList.CurrentRow.Cells["MaTG"].Value.ToString();
                NXB = dgvDataList.CurrentRow.Cells["MaNXB"].Value.ToString();
                string NamXuatBan = dgvDataList.CurrentRow.Cells["NamXuatBan"].Value.ToString();
                int SoLuong = (int)dgvDataList.CurrentRow.Cells["SoLuong"].Value;

                txtBookId.Text = MaSach;
                txtBookName.Text = TenSach;
                cboCategory.SelectedValue = TheLoai;
                cboAuthor.SelectedValue = TacGia;
                cboPublisher.SelectedValue = NXB;
                txtPublicationDate.Text = NamXuatBan;
                nudInStock.Value = SoLuong;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        // Chọn tìm theo mã
        private void radBookId_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = SachBUS.SearchData("MaSach", txtSearch.Text);
            DisplayBook(data);
        }

        // Chọn tìm theo tên
        private void radBookName_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = SachBUS.SearchData("TenSach", txtSearch.Text);
            DisplayBook(data);
        }

        // Sự kiện xảy ra khi nội dung tìm thay đổi
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (radBookId.Checked)
                radBookId_CheckedChanged(sender, e);
            else
                radBookName_CheckedChanged(sender, e);
        }

        // Reset form
        void ResetAll()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            DisplayBook();
            DisplayNextBookId();
            cboFilterCategory.SelectedIndex = 0;
            cboFilterAuthor.SelectedIndex = 0;
            cboFilterPublisher.SelectedIndex = 0;
            cboAuthor.SelectedIndex = -1;
            cboCategory.SelectedIndex = -1;
            cboPublisher.SelectedIndex = -1;
            txtBookName.Text = "";
            txtPublicationDate.Text = "";
            nudInStock.Value = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            radBookId.Checked = true;
            ResetAll();
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            string TenSach = txtBookName.Text;
            if (TenSach == "")
                lblCheckBookName.Text = "Vui lòng nhập tên sách!";
            else 
                lblCheckBookName.Text = "";
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtPublicationDate_TextChanged(object sender, EventArgs e)
        {
            string NamXuatBan = txtPublicationDate.Text;
            bool NamXBHopLe = Regex.IsMatch(NamXuatBan, @"\d+");
            DateTime dtNow = DateTime.Now;
            int NamHienTai = dtNow.Year;
            if (NamXuatBan == "")
                lblCheckPublicationDate.Text = "Vui lòng nhập năm xuất bản!";
            else if (!NamXBHopLe || (int.Parse(NamXuatBan) > NamHienTai || int.Parse(NamXuatBan) < 1800))
                lblCheckPublicationDate.Text = "Năm xuất bản không hợp lệ!";
            else
                lblCheckPublicationDate.Text = "";
        }

        // Khi ô chọn thay đổi nếu rỗng hiện lời nhắc
        private void cboCategory_TextChanged(object sender, EventArgs e)
        {
            string TheLoai = cboCategory.Text;
            if (TheLoai == "")
                lblCheckCategory.Text = "Vui lòng chọn thể loại!";
            else 
                lblCheckCategory.Text = "";
        }

        // Khi ô chọn thay đổi nếu rỗng hiện lời nhắc
        private void cboAuthor_TextChanged(object sender, EventArgs e)
        {
            string TacGia = cboAuthor.Text;
            if (TacGia == "")
                lblCheckAuthor.Text = "Vui lòng chọn tác giả!";
            else 
                lblCheckAuthor.Text = "";
        }

        // Khi ô chọn thay đổi nếu rỗng hiện lời nhắc
        private void cboPublisher_TextChanged(object sender, EventArgs e)
        {
            string NXB = cboPublisher.Text;
            if (NXB == "")
                lblCheckPublisher.Text = "Vui lòng chọn nhà xuất bản!";
            else 
                lblCheckPublisher.Text = "";
        }

        private void txtPublicationDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Chức năng bộ lọc
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string category, author, publisher;

            if (cboFilterCategory.Text == cboFilterCategory.Items[0].ToString())
                category = "1 = 1";
            else
                category = $"tl.TenTL = N'{cboFilterCategory.Text}'";

            if (cboFilterAuthor.Text == cboFilterAuthor.Items[0].ToString())
                author = "1 = 1";
            else
                author = $"tg.HoTenTG = N'{cboFilterAuthor.Text}'";

            if (cboFilterPublisher.Text == cboFilterPublisher.Items[0].ToString())
                publisher = "1 = 1";
            else 
                publisher = $"nxb.TenNXB = N'{cboFilterPublisher.Text}'";

            string query = "SELECT * FROM Sach s INNER JOIN TheLoai tl ON s.MaTL = tl.MaTL";
            query += " INNER JOIN NhaXuatBan nxb ON s.MaNXB = nxb.MaNXB";
            query += " INNER JOIN TacGia tg ON s.MaTG = tg.MaTG";
            query += $" WHERE s.TrangThai = 1 AND {category} AND {author} AND {publisher}";

            DisplayBook(SachBUS.GetData(query));
        }

        string CheckValidInput(out string MaSach, out string TenSach, out string MaTL, out string MaTG,
            out string MaNXB, out string NamXuatBan, out int SoLuong)
        {
            MaSach = txtBookId.Text;
            TenSach = txtBookName.Text.Trim();
            MaTL = (cboCategory.SelectedIndex != -1) ?
                cboCategory.SelectedValue.ToString() : "";
            MaTG = (cboAuthor.SelectedIndex != -1) ?
                cboAuthor.SelectedValue.ToString() : "";
            MaNXB = (cboPublisher.SelectedIndex != -1) ?
                cboPublisher.SelectedValue.ToString() : "";
            SoLuong = (int)nudInStock.Value;
            NamXuatBan = txtPublicationDate.Text;

            string ThongBao = "";
            if (TenSach == "") ThongBao += "Vui lòng nhập tên sách!";

            if (MaTL == "")
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Thể loại không tồn tại!";
            }

            if (MaTG == "")
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Tác giả không tồn tại!";
            }

            if (MaNXB == "")
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Nhà xuất bản không tồn tại!";
            }

            DateTime dtNow = DateTime.Now;
            int NamHienTai = dtNow.Year;
            bool NamXBHopLe = Regex.IsMatch(NamXuatBan, @"\d+");
            if (!NamXBHopLe || (int.Parse(NamXuatBan) > NamHienTai || int.Parse(NamXuatBan) < 1800))
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Năm xuất bản không hợp lệ!";
            }

            return ThongBao;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý thêm?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaSach, TenSach, MaTL, MaTG, MaNXB, NamXuatBan;
                int SoLuong;
                string ThongBao = CheckValidInput(out MaSach, out TenSach,  out MaTL, out MaTG, out MaNXB,
                    out NamXuatBan, out SoLuong);

                if (ThongBao == "")
                {
                    ParameterCSDL pMaSach = new ParameterCSDL("MaSach", MaSach);
                    ParameterCSDL pTenSach = new ParameterCSDL("TenSach", TenSach);
                    ParameterCSDL pMaTL = new ParameterCSDL("MaTL", MaTL);
                    ParameterCSDL pMaTG = new ParameterCSDL("MaTG", MaTG);
                    ParameterCSDL pMaNXB = new ParameterCSDL("MaNXB", MaNXB);
                    ParameterCSDL pNamXuatBan = new ParameterCSDL("NamXuatBan", NamXuatBan.ToString());
                    ParameterCSDL pSoLuong = new ParameterCSDL("SoLuong", SoLuong.ToString());
                    ParameterCSDL[] pArray = { pMaSach, pTenSach, pMaTL, pMaTG, pMaNXB, pNamXuatBan, pSoLuong };
                    List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                    LstParams.AddRange(pArray);
                    // Kiểm tra xem sách vừa thêm đã tồn tại chưa
                    string query = $"SELECT MaSach FROM Sach WHERE TenSach = N'{TenSach}' AND MaTL = '{MaTL}'";
                    query += $" AND MaTG = '{MaTG}' AND MaNXB = '{MaNXB}' AND NamXuatBan = {NamXuatBan}";

                    DataTable data = SachBUS.GetData(query);
                    int ExistBook = data.Rows.Count;
                    // Nếu có rồi thì update số lượng
                    if (ExistBook > 0)
                    {
                        string MaSachTrongCSDL = data.Rows[0][0].ToString();
                        int RowsAffected = SachBUS.UpdateInStock(MaSachTrongCSDL, SoLuong);

                        if (RowsAffected > 0)
                        {
                            MessageBox.Show("Số lượng của sách đã được cập nhật!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ResetAll();
                        }
                    }
                    else
                    {
                        int RowsAffected = SachBUS.InsertData(LstParams);

                        if (RowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ResetAll();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(ThongBao, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý sửa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaSach, TenSach, MaTL, MaTG, MaNXB, NamXuatBan;
                int SoLuong;
                string ThongBao = CheckValidInput(out MaSach, out TenSach, out MaTL, out MaTG, out MaNXB,
                    out NamXuatBan, out SoLuong);

                if (ThongBao == "")
                {
                    ParameterCSDL pMaSach = new ParameterCSDL("MaSach", MaSach);
                    ParameterCSDL pTenSach = new ParameterCSDL("TenSach", TenSach);
                    ParameterCSDL pMaTL = new ParameterCSDL("MaTL", MaTL);
                    ParameterCSDL pMaTG = new ParameterCSDL("MaTG", MaTG);
                    ParameterCSDL pMaNXB = new ParameterCSDL("MaNXB", MaNXB);
                    ParameterCSDL pNamXuatBan = new ParameterCSDL("NamXuatBan", NamXuatBan.ToString());
                    ParameterCSDL pSoLuong = new ParameterCSDL("SoLuong", SoLuong.ToString());
                    ParameterCSDL[] pArray = { pMaSach, pTenSach, pMaTL, pMaTG, pMaNXB, pNamXuatBan, pSoLuong };
                    List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                    LstParams.AddRange(pArray);
                    // Kiểm tra xem nội dung sửa có khác ban đầu ko
                    string query = $"SELECT * FROM Sach WHERE MaSach = '{MaSach}' AND TenSach = N'{TenSach}'";
                    query += $" AND MaTL = '{MaTL}' AND MaTG = '{MaTG}' AND MaNXB = '{MaNXB}'";
                    query += $" AND NamXuatBan = {NamXuatBan} AND SoLuong = {SoLuong}";

                    int NotChangeData = SachBUS.GetData(query).Rows.Count;
                    // Khi nội dung sửa khác ban đầu thì cập nhật lại
                    if (NotChangeData == 0)
                    {
                        query = $"SELECT * FROM Sach WHERE TenSach = N'{TenSach}' AND MaTL = '{MaTL}'";
                        query += $" AND MaTG = '{MaTG}' AND MaNXB = '{MaNXB}' AND NamXuatBan = '{NamXuatBan}'";
                        int ExistBook = SachBUS.GetData(query).Rows.Count;

                        if (ExistBook > 0)
                        {
                            MessageBox.Show("Sách này đã tồn tại!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            int RowsAffected = SachBUS.UpdateData(LstParams);

                            if (RowsAffected > 0)
                            {
                                MessageBox.Show("Sửa thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ResetAll();
                            }
                        }    
                    }
                }
                else
                {
                    MessageBox.Show(ThongBao, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý xóa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaSach = txtBookId.Text;

                int RowsAffected = SachBUS.DeleteData(MaSach);

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetAll();
                }
            }
        }
    }
}
