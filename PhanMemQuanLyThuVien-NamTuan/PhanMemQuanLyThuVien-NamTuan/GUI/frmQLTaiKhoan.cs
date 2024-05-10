using GUI;
using PhanMemQuanLyThuVien_NamTuan.BUS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

        void HienThiMaTKKeTiep()
        {
            // Tìm mã tài khoản cao nhất trong csdl
            string query = "SELECT MAX(MaTK) FROM TaiKhoan";
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            string MaTKMax = data.Rows[0][0].ToString();

            // Tách ra phần chuỗi và số
            string StringPart = Regex.Match(MaTKMax, @"[A-Z]+").Value;
            int NumberPart = int.Parse(Regex.Match(MaTKMax, @"\d+").Value);

            // Tăng phần số lên 1 đơn vị
            NumberPart++;

            // Nối phần chuỗi và số lại
            string MaTKKeTiep = StringPart + NumberPart.ToString("D3");
            txtLibrarianId.Text = MaTKKeTiep;
        }

        void HienThiBangTK(string query = "SELECT * FROM TaiKhoan WHERE TrangThai = 1")
        {
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            dgvDataList.DataSource = data;
            txtQuantity.Text = data.Rows.Count.ToString();

            // Xóa việc chương trình tự chọn hàng đầu tiên trong DataGridView
            dgvDataList.ClearSelection();
        }

        private void frmThuThu_Load(object sender, EventArgs e)
        {
            // Không tự động tạo các cột tiêu đề
            dgvDataList.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colMatKhau = new DataGridViewTextBoxColumn();
            colMatKhau.DataPropertyName = "MatKhau";
            colMatKhau.Name = "MatKhau";

            colMatKhau.Visible = false;
            dgvDataList.Columns.Add(colMatKhau);

            HienThiBangTK();
            HienThiMaTKKeTiep();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            lblCheckName.Text = "Vui lòng nhập họ tên!";
            lblCheckPhone.Text = "Vui lòng nhập SĐT";
            lblCheckPassword.Text = "Vui lòng nhập mật khẩu!";

            dtpBirth.Text = MaxBirth();
        }

        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
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

        private void radLibrarianId_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM TaiKhoan WHERE TrangThai = 1";
            query += " AND MaTK LIKE '%" + NoiDungTim + "%'";
            HienThiBangTK(query);
        }

        private void radLibrarianName_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM TaiKhoan WHERE TrangThai = 1";
            query += " AND HoTen LIKE N'%" + NoiDungTim + "%'";
            HienThiBangTK(query);
        }

        private void radPhone_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM TaiKhoan WHERE TrangThai = 1";
            query += " AND SDT LIKE '%" + NoiDungTim + "%'";
            HienThiBangTK(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query;

            if (radLibrarianId.Checked)
            {
                query = "SELECT * FROM TaiKhoan WHERE TrangThai = 1";
                query += " AND MaTK LIKE '%" + NoiDungTim + "%'";
                
            }
            else if (radLibrarianName.Checked)
            {
                query = "SELECT * FROM TaiKhoan WHERE TrangThai = 1";
                query += " AND HoTen LIKE N'%" + NoiDungTim + "%'";
            }
            else
            {
                query = "SELECT * FROM TaiKhoan WHERE TrangThai = 1";
                query += " AND SDT LIKE '%" + NoiDungTim + "%'";
            }

            HienThiBangTK(query);
        }

        string MaxBirth()
        {
            DateTime dt = DateTime.Now;
            int yearValid = dt.Year - 15;
            DateTime dt2 = new DateTime(yearValid, 12, 31);
            return dt2.ToString();
        }

        void ResetDuLieuNhap()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            lblCheckPassword.Visible = true;
            chkShowPassword.Visible = true;
            HienThiBangTK();
            HienThiMaTKKeTiep();
            txtLibrarianName.Text = "";
            dtpBirth.Text = MaxBirth();
            radMale.Checked = true;
            txtPhone.Text = "";
            txtPassword.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý thêm?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaTK, HoTen, NgaySinh, GioiTinh, SDT, MatKhau;
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

                DateTime dt = DateTime.Now;
                int NgayHT = dt.Day, ThangHT = dt.Month, NamHT = dt.Year;
                DateTime dtNgaySinh = dtpBirth.Value;
                int NgayS = dtNgaySinh.Day, ThangS = dtNgaySinh.Month, NamS = dtNgaySinh.Year;
                if (NamS > NamHT || (NamS == NamHT && ThangS > ThangHT) ||
                    (ThangS == ThangHT && NgayS > NgayHT))
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Ngày sinh không hợp lệ!";
                }

                if (ThongBao == "")
                {
                    string query = "INSERT INTO TaiKhoan (MaTK, HoTen,";
                    query += " NgaySinh, GioiTinh, SDT, MatKhau, Quyen, TrangThai)";
                    query += " VALUES ('" + MaTK + "', N'" + HoTen + "',";
                    query += " '" + NgaySinh + "', N'" + GioiTinh + "', '" + SDT + "',";
                    query += " '" + MatKhau + "', 0, 1)";

                    int RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);

                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetDuLieuNhap();
                    }
                }
                else
                {
                    MessageBox.Show(ThongBao, "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    lblCheckName.Text = (txtLibrarianName.Text == "") ?
                        "Vui lòng nhập họ tên!" : "";
                    lblCheckPhone.Text = (txtPhone.Text == "") ?
                        "Vui lòng nhập SĐT!" : "";
                    lblCheckPassword.Text = (txtPassword.Text == "") ?
                        "Vui lòng nhập mật khẩu!" : "";
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

                DateTime dt = DateTime.Now;
                int NgayHT = dt.Day, ThangHT = dt.Month, NamHT = dt.Year;
                DateTime dtNgaySinh = dtpBirth.Value;
                int NgayS = dtNgaySinh.Day, ThangS = dtNgaySinh.Month, NamS = dtNgaySinh.Year;
                if (NamS > NamHT || (NamS == NamHT && ThangS > ThangHT) ||
                    (ThangS == ThangHT && NgayS > NgayHT))
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Ngày sinh không hợp lệ!";
                }

                if (ThongBao == "")
                {
                    string query = "UPDATE TaiKhoan SET HoTen = N'" + HoTen + "',";
                    query += " NgaySinh = '" + NgaySinh + "', GioiTinh = N'" + GioiTinh + "',";
                    query += " SDT = '" + SDT + "', MatKhau = '" + MatKhau + "'";
                    query += " WHERE MaTK = '" + MaTK + "'";

                    int RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);

                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetDuLieuNhap();
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

                string query = "UPDATE TaiKhoan SET TrangThai = 0";
                query += " WHERE MaTK = '" + MaTK + "'";

                int RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetDuLieuNhap();
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lblCheckPhone.Text = "SĐT không hợp lệ";
            }

            string SDT = txtPhone.Text;
            if (!char.IsControl(e.KeyChar) && SDT.Length >= 12)
            {
                e.Handled = true;
                lblCheckPhone.Text = "SĐT tối đa 12 số";
            }    
        }

        private void txtLibrarianName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                lblCheckName.Text = "Họ tên không hợp lệ";
            }
        }

        private void txtLibrarianName_TextChanged(object sender, EventArgs e)
        {
            string HoTen = txtLibrarianName.Text;
            if (HoTen == "")
            {
                lblCheckName.Text = "Vui lòng nhập họ tên!";
            }
            else lblCheckName.Text = "";
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string Phone = txtPhone.Text;
            if (Phone == "")
            {
                lblCheckPhone.Text = "Vui lòng nhập SĐT";
            }
            else lblCheckPhone.Text = "";
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string Password = txtPassword.Text;
            if (Password == "")
            {
                lblCheckPassword.Text = "Vui lòng nhập mật khẩu!";
            }
            else lblCheckPassword.Text = "";
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }
    }
}
