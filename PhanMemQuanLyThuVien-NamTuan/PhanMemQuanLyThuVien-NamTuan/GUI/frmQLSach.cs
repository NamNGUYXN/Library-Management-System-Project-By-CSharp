using PhanMemQuanLyThuVien_NamTuan.BUS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

        void HienThiTheLoai()
        {
            string query = "SELECT MaTL, TenTL FROM TheLoai WHERE TrangThai = 1";
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            cboCategory.DataSource = data;
            cboCategory.DisplayMember = "TenTL";
            cboCategory.ValueMember = "MaTL";
        }

        void HienThiNhaXuatBan()
        {
            string query = "SELECT MaNXB, TenNXB FROM NhaXuatBan WHERE TrangThai = 1";
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            cboManufacturer.DataSource = data;
            cboManufacturer.DisplayMember = "TenNXB";
            cboManufacturer.ValueMember = "MaNXB";
        }

        void HienThiTacGia()
        {
            string query = "SELECT MaTG, HoTenTG FROM TacGia WHERE TrangThai = 1";
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            cboAuthor.DataSource = data;
            cboAuthor.DisplayMember = "HoTenTG";
            cboAuthor.ValueMember = "MaTG";
        }

        void HienThiMaSachKeTiep()
        {
            // Tìm mã sách cao nhất trong csdl
            string query = "SELECT MAX(MaSach) FROM Sach";
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            string MaSachMax = data.Rows[0][0].ToString();

            if (MaSachMax == "")
                txtBookId.Text = "S001";
            else
            {
                // Tách ra phần chuỗi và số
                string StringPart = Regex.Match(MaSachMax, @"[A-Z]+").Value;
                int NumberPart = int.Parse(Regex.Match(MaSachMax, @"\d+").Value);

                // Tăng phần số lên 1 đơn vị
                NumberPart++;

                // Nối phần chuỗi và số lại
                string MaSachKeTiep = StringPart + NumberPart.ToString("D3");
                txtBookId.Text = MaSachKeTiep;
            }
        }

        void HienThiBangSach(string query = "SELECT * FROM Sach s INNER JOIN TheLoai tl ON s.MaTL = tl.MaTL INNER JOIN NhaXuatBan nxb ON s.MaNXB = nxb.MaNXB INNER JOIN TacGia tg ON s.MaTG = tg.MaTG WHERE s.TrangThai = 1")
        {
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
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

            HienThiBangSach();
            HienThiTheLoai();
            HienThiNhaXuatBan();
            HienThiTacGia();
            HienThiMaSachKeTiep();

            cboFilterCategory.Items.Add("Tất cả");
            cboFilterAuthor.Items.Add("Tất cả");
            cboFilterManufacturer.Items.Add("Tất cả");
            DoDuLieu.DoDuLieucbo("TenTL", "TheLoai", cboFilterCategory);
            DoDuLieu.DoDuLieucbo("HoTenTG", "TacGia", cboFilterAuthor);
            DoDuLieu.DoDuLieucbo("TenNXB", "NhaXuatBan", cboFilterManufacturer);
            cboFilterCategory.SelectedIndex = 0;
            cboFilterAuthor.SelectedIndex = 0;
            cboFilterManufacturer.SelectedIndex = 0;

            cboAuthor.SelectedIndex = -1;
            cboCategory.SelectedIndex = -1;
            cboManufacturer.SelectedIndex = -1;

            lblCheckBookName.Text = "Vui lòng nhập tên sách!";
            lblCheckPublicationDate.Text = "Vui lòng nhập năm xuất bản!";
            lblCheckInStock.Text = "Vui lòng nhập số lượng!";

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
                string MaSach, TenSach, TheLoai, TacGia, NXB;
                int NamXuatBan, SoLuong;
                MaSach = dgvDataList.CurrentRow.Cells["MaSach"].Value.ToString();
                TenSach = dgvDataList.CurrentRow.Cells["TenSach"].Value.ToString();
                TheLoai = dgvDataList.CurrentRow.Cells["MaTL"].Value.ToString();
                TacGia = dgvDataList.CurrentRow.Cells["MaTG"].Value.ToString();
                NXB = dgvDataList.CurrentRow.Cells["MaNXB"].Value.ToString();
                NamXuatBan = (int)dgvDataList.CurrentRow.Cells["NamXuatBan"].Value;
                SoLuong = (int)dgvDataList.CurrentRow.Cells["SoLuong"].Value;

                txtBookId.Text = MaSach;
                txtBookName.Text = TenSach;
                cboCategory.SelectedValue = TheLoai;
                cboAuthor.SelectedValue = TacGia;
                cboManufacturer.SelectedValue = NXB;
                txtPublicationDate.Text = NamXuatBan.ToString();
                txtInStock.Text = SoLuong.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void radBookId_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM Sach s INNER JOIN TheLoai tl";
            query += " ON s.MaTL = tl.MaTL INNER JOIN NhaXuatBan nxb";
            query += " ON s.MaNXB = nxb.MaNXB INNER JOIN TacGia tg";
            query += " ON s.MaTG = tg.MaTG WHERE s.TrangThai = 1";
            query += " AND MaSach LIKE '%" + NoiDungTim + "%'";
            HienThiBangSach(query);
        }

        private void radBookName_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM Sach s INNER JOIN TheLoai tl";
            query += " ON s.MaTL = tl.MaTL INNER JOIN NhaXuatBan nxb";
            query += " ON s.MaNXB = nxb.MaNXB INNER JOIN TacGia tg";
            query += " ON s.MaTG = tg.MaTG WHERE s.TrangThai = 1";
            query += " AND TenSach LIKE N'%" + NoiDungTim + "%'";
            HienThiBangSach(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query;

            if (radBookId.Checked)
            {
                query = "SELECT * FROM Sach s INNER JOIN TheLoai tl";
                query += " ON s.MaTL = tl.MaTL INNER JOIN NhaXuatBan nxb";
                query += " ON s.MaNXB = nxb.MaNXB INNER JOIN TacGia tg";
                query += " ON s.MaTG = tg.MaTG WHERE s.TrangThai = 1";
                query += " AND MaSach LIKE '%" + NoiDungTim + "%'";
            }
            else
            {
                query = "SELECT * FROM Sach s INNER JOIN TheLoai tl";
                query += " ON s.MaTL = tl.MaTL INNER JOIN NhaXuatBan nxb";
                query += " ON s.MaNXB = nxb.MaNXB INNER JOIN TacGia tg";
                query += " ON s.MaTG = tg.MaTG WHERE s.TrangThai = 1";
                query += " AND TenSach LIKE N'%" + NoiDungTim + "%'";
            }

            HienThiBangSach(query);
        }

        void ResetDuLieuNhap()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            HienThiMaSachKeTiep();
            HienThiBangSach();
            txtBookName.Text = "";
            txtPublicationDate.Text = "";
            txtInStock.Text = "";
            cboFilterCategory.SelectedIndex = 0;
            cboFilterAuthor.SelectedIndex = 0;
            cboFilterManufacturer.SelectedIndex = 0;
            cboAuthor.SelectedIndex = -1;
            cboCategory.SelectedIndex = -1;
            cboManufacturer.SelectedIndex = -1;
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
                string MaSach, TenSach, MaTL, MaTG, MaNXB;
                int NamXuatBan, SoLuong;
                MaSach = txtBookId.Text;
                TenSach = txtBookName.Text;
                MaTL = (cboCategory.SelectedIndex != -1) ? 
                    cboCategory.SelectedValue.ToString() : "";
                MaTG = (cboAuthor.SelectedIndex != -1) ?
                    cboAuthor.SelectedValue.ToString() : "";
                MaNXB = (cboManufacturer.SelectedIndex != -1) ?
                    cboManufacturer.SelectedValue.ToString() : "";
                NamXuatBan = (txtPublicationDate.Text != "") ?
                    int.Parse(txtPublicationDate.Text) : 0;
                SoLuong = (txtInStock.Text != "") ? 
                    int.Parse(txtInStock.Text) : -1;

                string ThongBao = "";
                if (TenSach == "") ThongBao += "Vui lòng nhập tên sách!";

                if (MaTL == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng chọn thể loại!";
                }

                if (MaTG == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng chọn tác giả!";
                }

                if (MaNXB == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng chọn nhà xuất bản!";
                }

                DateTime dt = DateTime.Now;
                int NamHienTai = dt.Year;
                if (NamXuatBan > NamHienTai || NamXuatBan < 1)
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Năm xuất bản không hợp lệ!";
                }

                if (SoLuong < 0)
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Số lượng không hợp lệ";
                }

                if (ThongBao == "")
                {
                    string query = "INSERT INTO Sach (MaSach, TenSach,";
                    query += " MaTL, MaTG, MaNXB, NamXuatBan, SoLuong, TrangThai)";
                    query += " VALUES ('" + MaSach + "', N'" + TenSach + "',";
                    query += " '" + MaTL + "', '" + MaTG + "', '" + MaNXB + "',";
                    query += " " + NamXuatBan + ", " + SoLuong + ", 1)";

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
                string MaSach, TenSach, MaTL, MaTG, MaNXB;
                int NamXuatBan, SoLuong;
                MaSach = txtBookId.Text;
                TenSach = txtBookName.Text;
                MaTL = (cboCategory.SelectedIndex != -1) ?
                    cboCategory.SelectedValue.ToString() : "";
                MaTG = (cboAuthor.SelectedIndex != -1) ?
                    cboAuthor.SelectedValue.ToString() : "";
                MaNXB = (cboManufacturer.SelectedIndex != -1) ?
                    cboManufacturer.SelectedValue.ToString() : "";
                NamXuatBan = (txtPublicationDate.Text != "") ?
                    int.Parse(txtPublicationDate.Text) : 0;
                SoLuong = (txtInStock.Text != "") ?
                    int.Parse(txtInStock.Text) : -1;

                string ThongBao = "";
                if (TenSach == "") ThongBao += "Vui lòng nhập tên sách!";

                if (MaTL == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng chọn thể loại!";
                } 

                if (MaTG == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng chọn tác giả!";
                }

                if (MaNXB == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng chọn nhà xuất bản!";
                }

                DateTime dt = DateTime.Now;
                int NamHienTai = dt.Year;
                if (NamXuatBan > NamHienTai || NamXuatBan < 1)
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Năm xuất bản không hợp lệ!";
                }    

                if (SoLuong < 0)
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Số lượng không hợp lệ";
                }

                if (ThongBao == "")
                {
                    string query = "UPDATE Sach SET TenSach = N'" + TenSach + "',";
                    query += " MaTL = '" + MaTL + "', MaTG = '" + MaTG + "',";
                    query += " MaNXB = '" + MaNXB + "', NamXuatBan = " + NamXuatBan + ",";
                    query += " SoLuong = " + SoLuong + " WHERE MaSach = '" + MaSach + "'";

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
                string MaSach = txtBookId.Text;

                string query = "UPDATE Sach SET TrangThai = 0";
                query += " WHERE MaSach = '" + MaSach + "'";

                int RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetDuLieuNhap();
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string FilterCategory = "", FilterAuthor = "", FilterManufacturer = "";
            if (cboFilterCategory.Text == cboFilterCategory.Items[0].ToString())
            {
                FilterCategory = "%%";
            }
            else
            {
                FilterCategory = cboFilterCategory.Text;
            }

            if(cboFilterAuthor.Text == cboFilterAuthor.Items[0].ToString())
            {
                FilterAuthor = "%%";
            }
            else
            {
                FilterAuthor = cboFilterAuthor.Text;
            }

            if(cboFilterManufacturer.Text == cboFilterManufacturer.Items[0].ToString())
            {
                FilterManufacturer = "%%";
            }
            else
            {
                FilterManufacturer = cboFilterManufacturer.Text;
            }

            HienThiBangSach("SELECT * FROM Sach s INNER JOIN TheLoai tl ON s.MaTL = tl.MaTL INNER JOIN NhaXuatBan nxb ON s.MaNXB = nxb.MaNXB INNER JOIN TacGia tg ON s.MaTG = tg.MaTG WHERE s.TrangThai = 1 AND nxb.TenNXB LIKE N'"+FilterManufacturer+"' AND tg.HoTenTG LIKE N'" + FilterAuthor+ "' AND tl.TenTL LIKE N'"+FilterCategory+"'");
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            string TenSach = txtBookName.Text;
            if (TenSach == "")
            {
                lblCheckBookName.Text = "Vui lòng nhập tên sách!";
            }
            else lblCheckBookName.Text = "";
        }

        private void txtPublicationDate_TextChanged(object sender, EventArgs e)
        {
            string NamXuatBan = txtPublicationDate.Text;
            if (NamXuatBan == "")
            {
                lblCheckPublicationDate.Text = "Vui lòng nhập năm xuất bản!";
            }
            else lblCheckPublicationDate.Text = "";
        }

        private void txtInStock_TextChanged(object sender, EventArgs e)
        {
            string SoLuong = txtInStock.Text;
            if (SoLuong == "")
            {
                lblCheckInStock.Text = "Vui lòng nhập số lượng!";
            }
            else lblCheckInStock.Text = "";
        }

        private void cboCategory_TextChanged(object sender, EventArgs e)
        {
            string TheLoai = cboCategory.Text;
            if (TheLoai == "")
            {
                lblCheckCategory.Text = "Vui lòng chọn thể loại!";
            }
            else lblCheckCategory.Text = "";
        }

        private void cboAuthor_TextChanged(object sender, EventArgs e)
        {
            string TacGia = cboAuthor.Text;
            if (TacGia == "")
            {
                lblCheckAuthor.Text = "Vui lòng chọn tác giả!";
            }
            else lblCheckAuthor.Text = "";
        }

        private void cboManufacturer_TextChanged(object sender, EventArgs e)
        {
            string NXB = cboManufacturer.Text;
            if (NXB == "")
            {
                lblCheckManufacturer.Text = "Vui lòng chọn nhà xuất bản!";
            }
            else lblCheckManufacturer.Text = "";
        }

        private void txtPublicationDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lblCheckPublicationDate.Text = "Năm xuất bản không hợp lệ!";
            }
        }

        private void txtInStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lblCheckInStock.Text = "Số lượng không hợp lệ!";
            }
        }
    }
}
