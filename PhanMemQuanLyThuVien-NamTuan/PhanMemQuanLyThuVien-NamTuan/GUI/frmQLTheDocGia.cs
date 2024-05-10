using PhanMemQuanLyThuVien_NamTuan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyThuVien_NamTuan
{
    public partial class frmQLTheDocGia : Form
    {
        public frmQLTheDocGia()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void HienThiMaTDGKeTiep()
        {
            // Tìm mã thẻ độc giả cao nhất trong csdl
            string query = "SELECT MAX(MaTDG) FROM TheDocGia";
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            string MaTDGMax = data.Rows[0][0].ToString();

            if (MaTDGMax == "")
                txtLibraryCardId.Text = "TDG001";
            else
            {
                // Tách ra phần chuỗi và số
                string StringPart = Regex.Match(MaTDGMax, @"[A-Z]+").Value;
                int NumberPart = int.Parse(Regex.Match(MaTDGMax, @"\d+").Value);

                // Tăng phần số lên 1 đơn vị
                NumberPart++;

                // Nối phần chuỗi và số lại
                string MaTDGKeTiep = StringPart + NumberPart.ToString("D3");
                txtLibraryCardId.Text = MaTDGKeTiep;
            }
        }

        void HienThiNgayHetHan()
        {
            DateTime CurrentDate = DateTime.Now;
            int NgayHT = CurrentDate.Day;
            int ThangHT = CurrentDate.Month;
            int NamHT = CurrentDate.Year;

            // Class này tự viết
            TimNgayThangNam timNTN = new TimNgayThangNam(NgayHT, ThangHT, NamHT);
            DateTime AfterDate = timNTN.SauSoNgay(180); // 6 tháng
            dtpExpiryDate.Text = AfterDate.ToString();
        }

        void HienThiBangTheDG(string query = "SELECT * FROM TheDocGia WHERE TrangThai = 1")
        {
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            dgvDataList.DataSource = data;
            txtQuantity.Text = data.Rows.Count.ToString();

            // Xóa việc chương trình tự chọn hàng đầu tiên trong DataGridView
            dgvDataList.ClearSelection();
        }

        private void frmTheDocGia_Load(object sender, EventArgs e)
        {
            // Không tự động tạo các cột tiêu đề
            dgvDataList.AutoGenerateColumns = false;

            HienThiBangTheDG();
            HienThiMaTDGKeTiep();
            HienThiNgayHetHan();

            lblCheckName.Text = "Vui lòng nhập họ tên!";
            lblCheckAddress.Text = "Vui lòng nhập địa chỉ!";
            lblCheckPhone.Text = "Vui lòng nhập họ tên!";
            lblCheckIdCard.Text = "Vui lòng nhập CCCD!";

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnExtend.Enabled = false;
        }

        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            try
            {
                string MaTDG, HoTenDG, GioiTinh, DiaChi, SDT, CCCD;
                DateTime NgayHetHan;
                MaTDG = dgvDataList.CurrentRow.Cells["MaTDG"].Value.ToString();
                HoTenDG = dgvDataList.CurrentRow.Cells["HoTenDG"].Value.ToString();
                GioiTinh = dgvDataList.CurrentRow.Cells["GioiTinh"].Value.ToString();
                DiaChi = dgvDataList.CurrentRow.Cells["DiaChi"].Value.ToString();
                SDT = dgvDataList.CurrentRow.Cells["SDT"].Value.ToString();
                CCCD = dgvDataList.CurrentRow.Cells["CCCD"].Value.ToString();
                NgayHetHan = (DateTime)dgvDataList.CurrentRow.Cells["NgayHetHan"].Value;

                DateTime dt = DateTime.Now;
                if (dt > NgayHetHan) btnExtend.Enabled = true;
                else btnExtend.Enabled = false;

                txtLibraryCardId.Text = MaTDG;
                txtReaderName.Text = HoTenDG;
                radMale.Checked = (GioiTinh == "Nam") ? true : false;
                radFemale.Checked = (GioiTinh == "Nữ") ? true : false;
                txtAddress.Text = DiaChi;
                txtPhone.Text = SDT;
                txtIdCard.Text = CCCD;
                dtpExpiryDate.Text = NgayHetHan.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void radReaderId_CheckedChanged(object sender, EventArgs e)
        {
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM TheDocGia WHERE TrangThai = 1";
            query += " AND MaTDG LIKE '%" + NoiDungTim + "%'";
            HienThiBangTheDG(query);
        }

        private void radReaderName_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM TheDocGia WHERE TrangThai = 1";
            query += " AND HoTenDG LIKE N'%" + NoiDungTim + "%'";
            HienThiBangTheDG(query);
        }

        private void radIdCard_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM TheDocGia WHERE TrangThai = 1";
            query += " AND CCCD LIKE '%" + NoiDungTim + "%'";
            HienThiBangTheDG(query);
        }

        private void radPhone_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM TheDocGia WHERE TrangThai = 1";
            query += " AND SDT LIKE '%" + NoiDungTim + "%'";
            HienThiBangTheDG(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query;

            if (radReaderId.Checked)
            {
                query = "SELECT * FROM TheDocGia WHERE TrangThai = 1";
                query += " AND MaTDG LIKE '%" + NoiDungTim + "%'";

            }
            else if (radReaderName.Checked)
            {
                query = "SELECT * FROM TheDocGia WHERE TrangThai = 1";
                query += " AND HoTenDG LIKE N'%" + NoiDungTim + "%'";
            }
            else if (radIdCard.Checked)
            {
                query = "SELECT * FROM TheDocGia WHERE TrangThai = 1";
                query += " AND CCCD LIKE '%" + NoiDungTim + "%'";
            }
            else
            {
                query = "SELECT * FROM TheDocGia WHERE TrangThai = 1";
                query += " AND SDT LIKE '%" + NoiDungTim + "%'";
            }

            HienThiBangTheDG(query);
        }

        void ResetDuLieuNhap()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnExtend.Enabled = false;
            HienThiBangTheDG();
            HienThiMaTDGKeTiep();
            HienThiNgayHetHan();
            txtReaderName.Text = "";
            radMale.Checked = true;
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtIdCard.Text = "";
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
                string MaTDG, HoTenDG, GioiTinh, DiaChi, SDT, CCCD, NgayTao, NgayHetHan;
                MaTDG = txtLibraryCardId.Text;
                HoTenDG = txtReaderName.Text;
                GioiTinh = (radMale.Checked) ? "Nam" : "Nữ";
                DiaChi = txtAddress.Text;
                SDT = txtPhone.Text;
                CCCD = txtIdCard.Text;
                DateTime dt = DateTime.Now;
                NgayTao = dt.ToString();
                NgayHetHan = dtpExpiryDate.Value.ToString("yyyy/MM/dd");

                string ThongBao = "";
                if (HoTenDG == "") ThongBao += "Vui lòng nhập họ tên!";

                if (DiaChi == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng nhập địa chỉ!";
                }

                if (SDT == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng nhập SĐT!";
                }

                if (CCCD == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng nhập CCCD!";
                }

                if (ThongBao == "")
                {
                    string query = "INSERT INTO TheDocGia (MaTDG, HoTenDG, GioiTinh, DiaChi,";
                    query += " SDT, CCCD, NgayTao, NgayHetHan, TrangThai) VALUES";
                    query += " ('" + MaTDG + "', N'" + HoTenDG + "', N'" + GioiTinh + "',";
                    query += " N'" + DiaChi + "', '" + SDT + "', '" + CCCD + "',";
                    query += " '" + NgayTao + "', '" + NgayHetHan + "', 1)";

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
                string MaTDG, HoTenDG, GioiTinh, DiaChi, SDT, CCCD;
                MaTDG = txtLibraryCardId.Text;
                HoTenDG = txtReaderName.Text;
                GioiTinh = (radMale.Checked) ? "Nam" : "Nữ";
                DiaChi = txtAddress.Text;
                SDT = txtPhone.Text;
                CCCD = txtIdCard.Text;

                string ThongBao = "";
                if (HoTenDG == "") ThongBao += "Vui lòng nhập họ tên!";

                if (DiaChi == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng nhập địa chỉ!";
                }

                if (SDT == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng nhập SĐT!";
                }

                if (CCCD == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng nhập CCCD!";
                }

                if (ThongBao == "")
                {
                    string query = "UPDATE TheDocGia SET HoTenDG = N'" + HoTenDG + "',";
                    query += " GioiTinh = N'" + GioiTinh + "', DiaChi = N'" + DiaChi + "',";
                    query += " SDT = '" + SDT + "', CCCD = '" + CCCD + "'";
                    query += " WHERE MaTDG = '" + MaTDG + "'";

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
                string MaTDG;
                MaTDG = txtLibraryCardId.Text;

                string query = "UPDATE TheDocGia SET TrangThai = 0";
                query += " WHERE MaTDG = '" + MaTDG + "'";

                int RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetDuLieuNhap();
                }
            }
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý gia hạn?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaTDG, NgayHetHan, ThongBao = "";
                MaTDG = txtLibraryCardId.Text;
                DateTime dt = DateTime.Now;
                TimNgayThangNam TimNTN1 = new TimNgayThangNam(dt.Day, dt.Month, dt.Year);
                NgayHetHan = TimNTN1.SauSoNgay(180).ToString("yyyy/MM/dd");

                string query = "SELECT NgayHetHan FROM TheDocGia WHERE MaTDG = '" + MaTDG + "'";
                DateTime NgayHetHanTrongCSDL = (DateTime)ThucThiTruyVanBus.LayDuLieu(query).Rows[0][0];
                TimNgayThangNam TimNTN2 = new TimNgayThangNam(NgayHetHanTrongCSDL);
                DateTime NgayToiDaDuocGiaHan = TimNTN2.SauSoNgay(10);
                if (dt > NgayToiDaDuocGiaHan)
                {
                    ThongBao += "Thời hạn độc giả được gia hạn đã hơn 10 ngày!";
                }

                if (ThongBao == "")
                {
                    query = "UPDATE TheDocGia SET NgayHetHan = '" + NgayHetHan + "'";
                    query += " WHERE MaTDG = '" + MaTDG + "'";

                    int RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);

                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Gia hạn thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetDuLieuNhap();
                    }
                }
                else
                {
                    MessageBox.Show(ThongBao, "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void txtReaderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                lblCheckName.Text = "Họ tên không hợp lệ!";
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lblCheckPhone.Text = "SĐT không hợp lệ!";
            }

            string SDT = txtPhone.Text;
            if (!char.IsControl(e.KeyChar) && SDT.Length >= 12)
            {
                e.Handled = true;
                lblCheckPhone.Text = "SĐT tối đa 12 số";
            }
        }

        private void txtIdCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lblCheckIdCard.Text = "CCCD không hợp lệ!";
            }

            string CCCD = txtIdCard.Text;
            if (!char.IsControl(e.KeyChar) && CCCD.Length >= 12)
            {
                e.Handled = true;
                lblCheckIdCard.Text = "CCCD tối đa 12 số";
            }
        }

        private void txtReaderName_TextChanged(object sender, EventArgs e)
        {
            string HoTen = txtReaderName.Text;
            if (HoTen == "")
            {
                lblCheckName.Text = "Vui lòng nhập họ tên!";
            }
            else lblCheckName.Text = "";
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            string DiaChi = txtAddress.Text;
            if (DiaChi == "")
            {
                lblCheckAddress.Text = "Vui lòng nhập địa chỉ!";
            }
            else lblCheckAddress.Text = "";
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string SDT = txtPhone.Text;
            if (SDT == "")
            {
                lblCheckPhone.Text = "Vui lòng nhập họ tên!";
            }
            else lblCheckPhone.Text = "";
        }

        private void txtIdCard_TextChanged(object sender, EventArgs e)
        {
            string CCCD = txtIdCard.Text;
            if (CCCD == "")
            {
                lblCheckIdCard.Text = "Vui lòng nhập CCCD!";
            }
            else lblCheckIdCard.Text = "";
        }
    }
}