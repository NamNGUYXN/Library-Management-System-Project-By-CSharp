using GUI;
using PhanMemQuanLyThuVien_NamTuan.BUS;
using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PhanMemQuanLyThuVien_NamTuan
{
    public partial class frmQLTaiKhoan : Form
    {
        public frmQLTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DisplayNextLibrarianId()
        {
            txtLibrarianId.Text = TuDongTao.MaKeTiep("MaTK", "TaiKhoan", "TK");
        }

        void DisplayLibrarian(DataTable data = null, string query = null)
        {
            if (data == null) data = TaiKhoanBUS.GetData();
            if (query != null) data = TaiKhoanBUS.GetData(query);

            dgvDataList.DataSource = data;
            txtQuantity.Text = data.Rows.Count.ToString();

            // Xóa việc chương trình tự chọn hàng đầu tiên trong DataGridView
            dgvDataList.ClearSelection();
        }

        void MaxMinBirth()
        {
            DateTime dt = DateTime.Now;
            int yearValid = dt.Year - 15;
            DateTime dt2 = new DateTime(yearValid, 12, 31);
            dtpBirth.MaxDate = dt2;
            dtpBirth.MinDate = new DateTime(1900, 1, 1);
            dtpBirth.Text = dt2.ToString();
        }

        private void frmThuThu_Load(object sender, EventArgs e)
        {
            // Không tự động tạo các cột tiêu đề
            dgvDataList.AutoGenerateColumns = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            DataGridViewTextBoxColumn colMatKhau = new DataGridViewTextBoxColumn();
            colMatKhau.DataPropertyName = "MatKhau";
            colMatKhau.Name = "MatKhau";
            colMatKhau.Visible = false;
            dgvDataList.Columns.Add(colMatKhau);
            // Hiện dữ liệu tài khoản vào DataGridView
            DisplayLibrarian();
            // Hiện mã tài khoản kế tiếp
            DisplayNextLibrarianId();
            // Hiện lời nhắc dưới ô nhập
            lblCheckName.Text = "Vui lòng nhập họ tên!";
            lblCheckPhone.Text = "Vui lòng nhập SĐT";
            lblCheckPassword.Text = "Vui lòng nhập mật khẩu!";
            // Hiện max min ngày sinh
            MaxMinBirth();
        }

        // Sự kiện xảy ra khi chọn vào 1 dòng trong DataGridView
        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            chkShowPassword.Checked = false;
            try
            {
                string MaTK, HoTenTT, GioiTinh, SDT, MatKhau;
                DateTime NgaySinh;

                MaTK = dgvDataList.CurrentRow.Cells["MaTK"].Value.ToString();
                HoTenTT = dgvDataList.CurrentRow.Cells["HoTen"].Value.ToString();
                NgaySinh = (DateTime)dgvDataList.CurrentRow.Cells["NgaySinh"].Value;
                GioiTinh = dgvDataList.CurrentRow.Cells["GioiTinh"].Value.ToString();
                SDT = dgvDataList.CurrentRow.Cells["SDT"].Value.ToString();
                MatKhau = dgvDataList.CurrentRow.Cells["MatKhau"].Value.ToString();

                if (frmDangNhap.MaTK.ToUpper() == MaTK)
                {
                    btnDelete.Enabled = false;
                    lblPassword.Visible = false;
                    txtPassword.Visible = false;
                    lblCheckPassword.Visible = false;
                    chkShowPassword.Visible = false;
                }
                else
                {
                    lblPassword.Visible = true;
                    txtPassword.Visible = true;
                    lblCheckPassword.Visible = true;
                    chkShowPassword.Visible = true;
                }

                txtLibrarianId.Text = MaTK;
                txtLibrarianName.Text = HoTenTT;
                dtpBirth.Text = NgaySinh.ToString();
                radMale.Checked = (GioiTinh == "Nam") ? true : false;
                radFemale.Checked = (GioiTinh == "Nữ") ? true : false;
                txtPhone.Text = SDT;
                txtPassword.Text = MatKhau;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        // Chọn tìm theo mã
        private void radLibrarianId_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = TaiKhoanBUS.SearchData("MaTK", txtSearch.Text);
            DisplayLibrarian(data);
        }

        // Chọn tìm theo tên
        private void radLibrarianName_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = TaiKhoanBUS.SearchData("HoTen", txtSearch.Text);
            DisplayLibrarian(data);
        }

        // Chọn tìm theo sdt
        private void radPhone_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = TaiKhoanBUS.SearchData("SDT", txtSearch.Text);
            DisplayLibrarian(data);
        }

        // Sự kiện xảy ra khi nội dung tìm thay đổi
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (radLibrarianId.Checked)
                radLibrarianId_CheckedChanged(sender, e);
            else if (radLibrarianName.Checked)
                radLibrarianName_CheckedChanged(sender, e);
            else
                radPhone_CheckedChanged(sender, e);
        }

        // Reset form
        void ResetAll()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            lblCheckPassword.Visible = true;
            chkShowPassword.Visible = true;
            radMale.Checked = true;
            chkShowPassword.Checked = false;
            DisplayLibrarian();
            DisplayNextLibrarianId();
            MaxMinBirth();
            txtLibrarianName.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        // Ngăn ko cho nhập sdt ko hợp lệ
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool KeyDelete = (e.KeyChar == (char)Keys.Delete);
            bool KeyBackspace = (e.KeyChar == (char)Keys.Back);
            if (!KeyDelete && !KeyBackspace && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            string SDT = txtPhone.Text;
            if (!KeyDelete && !KeyBackspace && SDT.Length >= 12)
            {
                e.Handled = true;
                lblCheckPhone.Text = "SĐT tối đa 12 số";
            }
        }

        // Ngăn ko cho nhập tên ko hợp lệ
        private void txtLibrarianName_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool KeyDelete = (e.KeyChar == (char)Keys.Delete);
            bool KeyBackspace = (e.KeyChar == (char)Keys.Back);
            if (!char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                !KeyDelete && !KeyBackspace)
            {
                e.Handled = true;
            }
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtLibrarianName_TextChanged(object sender, EventArgs e)
        {
            string HoTen = txtLibrarianName.Text;
            if (HoTen == "")
                lblCheckName.Text = "Vui lòng nhập họ tên!";
            else 
                lblCheckName.Text = "";
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string SDT = txtPhone.Text;
            // Kiểm tra số điện thoại vừa nhập đã tồn tại hay chưa
            string query = $"SELECT SDT FROM TaiKhoan WHERE SDT = '{SDT}' AND MaTK <> '{txtLibrarianId.Text}'";
            int ExistPhone = TaiKhoanBUS.GetData(query).Rows.Count;
            if (SDT == "")
                lblCheckPhone.Text = "Vui lòng nhập SĐT!";
            else if (ExistPhone > 0)
                lblCheckPhone.Text = "SĐT đã tồn tại!";
            else
                lblCheckPhone.Text = "";
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string Password = txtPassword.Text;
            if (Password == "")
                lblCheckPassword.Text = "Vui lòng nhập mật khẩu!";
            else 
                lblCheckPassword.Text = "";
        }

        // Hiện mật khẩu
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        string CheckValidInput(out string MaTK, out string HoTen, out string NgaySinh,
            out string GioiTinh, out string SDT, out string MatKhau)
        {
            MaTK = txtLibrarianId.Text;
            HoTen = txtLibrarianName.Text;
            NgaySinh = dtpBirth.Value.ToString("yyyy/MM/dd");
            GioiTinh = (radMale.Checked) ? "Nam" : "Nữ";
            SDT = txtPhone.Text;
            MatKhau = txtPassword.Text;

            string ThongBao = "";
            if (HoTen == "") ThongBao += "Vui lòng nhập họ tên!";

            if (SDT == "")
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Vui lòng nhập SĐT!";
            }

            if (MatKhau == "")
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Vui lòng nhập mật khẩu!";
            }

            string query = $"SELECT SDT FROM TaiKhoan WHERE SDT = '{SDT}' AND MaTK <> '{txtLibrarianId.Text}'";
            int ExistPhone = TaiKhoanBUS.GetData(query).Rows.Count;
            if (ExistPhone > 0)
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "SĐT đã tồn tại!";
            }

            return ThongBao;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý thêm?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaTK, HoTen, NgaySinh, GioiTinh, SDT, MatKhau;
                string ThongBao = CheckValidInput(out MaTK, out HoTen, out NgaySinh, out GioiTinh, 
                    out SDT, out MatKhau);

                if (ThongBao == "")
                {
                    ParameterCSDL pMaTK = new ParameterCSDL("MaTK", MaTK);
                    ParameterCSDL pHoTen = new ParameterCSDL("HoTen", HoTen.Trim());
                    ParameterCSDL pNgaySinh = new ParameterCSDL("NgaySinh", NgaySinh);
                    ParameterCSDL pGioiTinh = new ParameterCSDL("GioiTinh", GioiTinh);
                    ParameterCSDL pSDT = new ParameterCSDL("SDT", SDT);
                    ParameterCSDL pMatKhau = new ParameterCSDL("MatKhau", MatKhau);
                    ParameterCSDL[] pArray = { pMaTK, pHoTen, pNgaySinh, pGioiTinh, pSDT, pMatKhau };
                    List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                    LstParams.AddRange(pArray);

                    int RowsAffected = TaiKhoanBUS.InsertData(LstParams);

                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetAll();
                    }
                }
                else
                {
                    MessageBox.Show(ThongBao, "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý sửa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaTK, HoTen, NgaySinh, GioiTinh, SDT, MatKhau;
                string ThongBao = CheckValidInput(out MaTK, out HoTen, out NgaySinh, out GioiTinh,
                    out SDT, out MatKhau);

                if (ThongBao == "")
                {
                    ParameterCSDL pMaTK = new ParameterCSDL("MaTK", MaTK);
                    ParameterCSDL pHoTen = new ParameterCSDL("HoTen", HoTen.Trim());
                    ParameterCSDL pNgaySinh = new ParameterCSDL("NgaySinh", NgaySinh);
                    ParameterCSDL pGioiTinh = new ParameterCSDL("GioiTinh", GioiTinh);
                    ParameterCSDL pSDT = new ParameterCSDL("SDT", SDT);
                    ParameterCSDL pMatKhau = new ParameterCSDL("MatKhau", MatKhau);
                    ParameterCSDL[] pArray = { pMaTK, pHoTen, pNgaySinh, pGioiTinh, pSDT, pMatKhau };
                    List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                    LstParams.AddRange(pArray);
                    // Kiểm tra xem nội dung sửa có khác ban đầu ko
                    string query = $"SELECT * FROM TaiKhoan WHERE MaTK = '{MaTK}' AND HoTen = N'{HoTen}'";
                    query += $" AND NgaySinh = '{NgaySinh}' AND GioiTinh = N'{GioiTinh}' AND SDT = '{SDT}'";
                    query += $" AND MatKhau = '{MatKhau}'";

                    int NotChangeData = TaiKhoanBUS.GetData(query).Rows.Count;
                    // Khi nội dung sửa khác ban đầu thì cập nhật lại
                    if (NotChangeData == 0)
                    {
                        int RowsAffected = TaiKhoanBUS.UpdateData(LstParams);

                        if (RowsAffected > 0)
                        {
                            MessageBox.Show("Sửa thành công!", "Thông báo",
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý xóa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaTK = txtLibrarianId.Text;

                int RowsAffected = TaiKhoanBUS.DeleteData(MaTK);

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
