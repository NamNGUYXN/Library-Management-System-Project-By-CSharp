using PhanMemQuanLyThuVien_NamTuan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyThuVien_NamTuan
{
    public partial class frmQLTacGia : Form
    {
        public frmQLTacGia()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void HienThiMaTGKeTiep()
        {
            // Tìm mã tác giả cao nhất trong csdl
            string query = "SELECT MAX(MaTG) FROM TacGia";
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            string MaTGMax = data.Rows[0][0].ToString();

            if (MaTGMax == "")
                txtAuthorId.Text = "TG001";
            else
            {
                // Tách ra phần chuỗi và số
                string StringPart = Regex.Match(MaTGMax, @"[A-Z]+").Value;
                int NumberPart = int.Parse(Regex.Match(MaTGMax, @"\d+").Value);

                // Tăng phần số lên 1 đơn vị
                NumberPart++;

                // Nối phần chuỗi và số lại
                string MaTGKeTiep = StringPart + NumberPart.ToString("D3");
                txtAuthorId.Text = MaTGKeTiep;
            }
        }

        void HienThiBangTacGia(string query = "SELECT * FROM TacGia WHERE TrangThai = 1")
        {
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            dgvDataList.DataSource = data;
            txtQuantity.Text = data.Rows.Count.ToString();

            // Xóa việc chương trình tự chọn hàng đầu tiên trong DataGridView
            dgvDataList.ClearSelection();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            // Không tự động tạo các cột tiêu đề
            dgvDataList.AutoGenerateColumns = false;

            HienThiBangTacGia();
            HienThiMaTGKeTiep();

            lblCheckName.Text = "Vui lòng nhập họ tên!";
            lblCheckHometown.Text = "Vui lòng nhập quê quán!";

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            try
            {
                string MaTG, HoTenTG, GioiTinh, QueQuan;
                MaTG = dgvDataList.CurrentRow.Cells["MaTG"].Value.ToString();
                HoTenTG = dgvDataList.CurrentRow.Cells["HoTenTG"].Value.ToString();
                GioiTinh = dgvDataList.CurrentRow.Cells["GioiTinh"].Value.ToString();
                QueQuan = dgvDataList.CurrentRow.Cells["QueQuan"].Value.ToString();

                txtAuthorId.Text = MaTG;
                txtAuthorName.Text = HoTenTG;
                radMale.Checked = (GioiTinh == "Nam") ? true : false;
                radFemale.Checked = (GioiTinh == "Nữ") ? true : false;
                txtHometown.Text = QueQuan;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void radBookId_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM TacGia WHERE TrangThai = 1";
            query += " AND MaTG LIKE '%" + NoiDungTim + "%'";
            HienThiBangTacGia(query);
        }

        private void radBookName_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM TacGia WHERE TrangThai = 1";
            query += " AND HoTenTG LIKE N'%" + NoiDungTim + "%'";
            HienThiBangTacGia(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query;

            if (radAuthorId.Checked)
            {
                query = "SELECT * FROM TacGia WHERE TrangThai = 1";
                query += " AND MaTG LIKE '%" + NoiDungTim + "%'";

            }
            else
            {
                query = "SELECT * FROM TacGia WHERE TrangThai = 1";
                query += " AND HoTenTG LIKE N'%" + NoiDungTim + "%'";
            }

            HienThiBangTacGia(query);
        }

        void ResetDuLieuNhap()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            HienThiMaTGKeTiep();
            HienThiBangTacGia();
            txtAuthorName.Text = "";
            radMale.Checked = true;
            txtHometown.Text = "";
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
                string MaTG, HoTenTG, GioiTinh, QueQuan;
                MaTG = txtAuthorId.Text;
                HoTenTG = txtAuthorName.Text;
                GioiTinh = (radMale.Checked) ? "Nam" : "Nữ";
                QueQuan = txtHometown.Text;

                string ThongBao = "";
                if (HoTenTG == "") ThongBao += "Vui lòng nhập họ tên!";

                if (QueQuan == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng nhập quê quán!";
                }

                if (ThongBao == "")
                {
                    string query = "INSERT INTO TacGia (MaTG, HoTenTG, GioiTinh, QueQuan, TrangThai)";
                    query += " VALUES ('" + MaTG + "', N'" + HoTenTG + "', N'" + GioiTinh + "',";
                    query += " N'" + QueQuan + "', 1)";

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
                string MaTG, HoTenTG, GioiTinh, QueQuan;
                MaTG = txtAuthorId.Text;
                HoTenTG = txtAuthorName.Text;
                GioiTinh = (radMale.Checked) ? "Nam" : "Nữ";
                QueQuan = txtHometown.Text;

                string ThongBao = "";
                if (HoTenTG == "") ThongBao += "Vui lòng nhập họ tên!";

                if (QueQuan == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng nhập quê quán!";
                }

                if (ThongBao == "")
                {
                    string query = "UPDATE TacGia SET HoTenTG = N'" + HoTenTG + "',";
                    query += " GioiTinh = N'" + GioiTinh + "', QueQuan = N'" + QueQuan + "'";
                    query += " WHERE MaTG = '" + MaTG + "'";

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
                string MaTG;
                MaTG = txtAuthorId.Text;

                string query = "UPDATE TacGia SET TrangThai = 0 WHERE MaTG = '" + MaTG + "'";

                int RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetDuLieuNhap();
                }
            }
        }

        private void txtAuthorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                lblCheckName.Text = "Họ tên không hợp lệ!";
            }
        }

        private void txtAuthorName_TextChanged(object sender, EventArgs e)
        {
            string HoTen = txtAuthorName.Text;
            if (HoTen == "")
            {
                lblCheckName.Text = "Vui lòng nhập họ tên!";
            }
            else lblCheckName.Text = "";
        }

        private void txtHometown_TextChanged(object sender, EventArgs e)
        {
            string Quequan = txtHometown.Text;
            if (Quequan == "")
            {
                lblCheckHometown.Text = "Vui lòng nhập quê quán!";
            }
            else lblCheckHometown.Text = "";
        }
    }
}
