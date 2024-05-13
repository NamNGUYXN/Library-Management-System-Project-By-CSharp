using PhanMemQuanLyThuVien_NamTuan.BUS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyThuVien_NamTuan
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDSSachHong_Click(object sender, EventArgs e)
        {
            dgvDataList.Columns.Clear();
            string query = "SELECT * FROM SachHong";
            dgvDataList.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn colMaSH = new DataGridViewTextBoxColumn();
            colMaSH.DataPropertyName = "MaSH";
            colMaSH.HeaderText = "Mã sách hỏng";
            DataGridViewTextBoxColumn colMaTDG = new DataGridViewTextBoxColumn();
            colMaTDG.DataPropertyName = "MaTDG";
            colMaTDG.HeaderText = "Mã thẻ ĐG";
            DataGridViewTextBoxColumn colMaSach = new DataGridViewTextBoxColumn();
            colMaSach.DataPropertyName = "MaSach";
            colMaSach.HeaderText = "Mã sách";
            DataGridViewTextBoxColumn colMoTa = new DataGridViewTextBoxColumn();
            colMoTa.DataPropertyName = "MoTa";
            colMoTa.HeaderText = "Mô tả";
            DataGridViewTextBoxColumn colNgayBaoHong = new DataGridViewTextBoxColumn();
            colNgayBaoHong.DataPropertyName = "NgayBaoHong";
            colNgayBaoHong.HeaderText = "Ngày báo hỏng";

            dgvDataList.Columns.Add(colMaSH);
            dgvDataList.Columns.Add(colMaTDG);
            dgvDataList.Columns.Add(colMaSach);
            dgvDataList.Columns.Add(colMoTa);
            dgvDataList.Columns.Add(colNgayBaoHong);

            DataTable data = SachHongBUS.GetData(query);
            dgvDataList.DataSource = data;
            dgvDataList.ClearSelection();
        }

        private void btnDSTDGHH_Click(object sender, EventArgs e)
        {
            dgvDataList.Columns.Clear();
            string dtNow = DateTime.Now.ToString("yyyy/MM/dd");
            string query = "SELECT * FROM TheDocGia WHERE NgayHetHan < '" + dtNow + "'";
            dgvDataList.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn colMaTDG = new DataGridViewTextBoxColumn();
            colMaTDG.DataPropertyName = "MaTDG";
            colMaTDG.HeaderText = "Mã thẻ ĐG";
            DataGridViewTextBoxColumn colHoTenDG = new DataGridViewTextBoxColumn();
            colHoTenDG.DataPropertyName = "MaTDG";
            colHoTenDG.HeaderText = "Mã thẻ ĐG";
            DataGridViewTextBoxColumn colGioiTinh = new DataGridViewTextBoxColumn();
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.HeaderText = "Giới tính";
            DataGridViewTextBoxColumn colDiaChi = new DataGridViewTextBoxColumn();
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa chỉ";
            DataGridViewTextBoxColumn colSDT = new DataGridViewTextBoxColumn();
            colSDT.DataPropertyName = "SDT";
            colSDT.HeaderText = "SĐT";
            DataGridViewTextBoxColumn colCCCD = new DataGridViewTextBoxColumn();
            colCCCD.DataPropertyName = "CCCD";
            colCCCD.HeaderText = "CCCD";
            DataGridViewTextBoxColumn colNgayTao = new DataGridViewTextBoxColumn();
            colNgayTao.DataPropertyName = "NgayTao";
            colNgayTao.HeaderText = "Ngày tạo";
            DataGridViewTextBoxColumn colNgayHetHan = new DataGridViewTextBoxColumn();
            colNgayHetHan.DataPropertyName = "NgayHetHan";
            colNgayHetHan.HeaderText = "Ngày hết";

            dgvDataList.Columns.Add(colMaTDG);
            dgvDataList.Columns.Add(colHoTenDG);
            dgvDataList.Columns.Add(colGioiTinh);
            dgvDataList.Columns.Add(colDiaChi);
            dgvDataList.Columns.Add(colSDT);
            dgvDataList.Columns.Add(colCCCD);
            dgvDataList.Columns.Add(colNgayTao);
            dgvDataList.Columns.Add(colNgayHetHan);

            DataTable data = TheDocGiaBus.GetData(query);
            dgvDataList.DataSource = data;
            dgvDataList.ClearSelection();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            cboFilter.SelectedIndex = 0;
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TongPhieuMuon, TongSachMuon, TongSachHong;

            switch (cboFilter.SelectedIndex)
            {
                case 0:
                {
                    TongPhieuMuon = "SELECT COUNT(MaPhieu) FROM PhieuMuonTra";
                    TongSachMuon = "SELECT COUNT(MaSach) FROM CTPhieuMuonTra";
                    TongSachHong = "SELECT COUNT(MaSH) FROM SachHong";
                }break;
                case 1:
                {
                    TongPhieuMuon = "SELECT COUNT(MaPhieu) FROM PhieuMuonTra WHERE DAY(NgayTao) = DAY(GETDATE())";
                    TongSachMuon = "SELECT COUNT(MaSach) FROM PhieuMuonTra p INNER JOIN CTPhieuMuonTra ct";
                    TongSachMuon += " ON p.MaPhieu = ct.MaPhieu WHERE DAY(NgayTao) = DAY(GETDATE())";
                    TongSachHong = "SELECT COUNT(MaSH) FROM SachHong WHERE DAY(NgayBaoHong) = DAY(GETDATE())";
                }break;
                case 2:
                {
                    TongPhieuMuon = "SELECT COUNT(MaPhieu) FROM PhieuMuonTra WHERE YEAR(NgayTao) = YEAR(GETDATE())";
                    TongPhieuMuon += " AND MONTH(NgayTao) = MONTH(GETDATE())";
                    TongSachMuon = "SELECT COUNT(MaSach) FROM PhieuMuonTra p INNER JOIN CTPhieuMuonTra ct";
                    TongSachMuon += " ON p.MaPhieu = ct.MaPhieu WHERE YEAR(NgayTao) = YEAR(GETDATE())";
                    TongSachMuon += " AND MONTH(NgayTao) = MONTH(GETDATE())";
                    TongSachHong = "SELECT COUNT(MaSH) FROM SachHong WHERE YEAR(NgayBaoHong) = YEAR(GETDATE())";
                    TongSachHong += " AND MONTH(NgayBaoHong) = MONTH(GETDATE())";
                }
                break;
                case 3:
                {
                    TongPhieuMuon = "SELECT COUNT(MaPhieu) FROM PhieuMuonTra WHERE YEAR(NgayTao) = YEAR(GETDATE())";
                    TongSachMuon = "SELECT COUNT(MaSach) FROM PhieuMuonTra p INNER JOIN CTPhieuMuonTra ct";
                    TongSachMuon += " ON p.MaPhieu = ct.MaPhieu WHERE YEAR(NgayTao) = YEAR(GETDATE())";
                    TongSachHong = "SELECT COUNT(MaSH) FROM SachHong WHERE YEAR(NgayBaoHong) = YEAR(GETDATE())";
                }break;
                default: TongPhieuMuon = ""; TongSachMuon = ""; TongSachHong = ""; break;
            }
            txtTongPhieuMuon.Text = PhieuMuonTraBUS.GetData(TongPhieuMuon).Rows[0][0].ToString();
            txtTongSachMuon.Text = PhieuMuonTraBUS.GetData(TongSachMuon).Rows[0][0].ToString();
            txtTongSachHong.Text = SachHongBUS.GetData(TongSachHong).Rows[0][0].ToString();
        }

        private void dgvDataList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDataList.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn &&
        dgvDataList.Columns[e.ColumnIndex].ValueType == typeof(DateTime))
            {
                DateTime date;
                if (DateTime.TryParse(e.Value?.ToString(), out date))
                {
                    e.Value = date.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
