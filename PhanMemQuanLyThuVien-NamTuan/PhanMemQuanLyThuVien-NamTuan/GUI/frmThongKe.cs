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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDSSachHong_Click(object sender, EventArgs e)
        {
            dgvDataList.Columns.Clear();
            string query = "select MaSH, MaTDG, MaSach, MoTa, NgayBaoHong from SachHong group by MaSH, MaTDG, MaSach, MoTa, NgayBaoHong";
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

            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            dgvDataList.DataSource = data;
            dgvDataList.ClearSelection();
        }

        int Tong(string query)
        {
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            return (int)data.Rows[0][0];
        }

        private void btnDSTDGHH_Click(object sender, EventArgs e)
        {
            dgvDataList.Columns.Clear();
            string today = DateTime.Now.ToString("yyyy/MM/dd");
            string query = "select * from TheDocGia where NgayHetHan < '" + today +"'";
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

            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            dgvDataList.DataSource = data;
            dgvDataList.ClearSelection();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            cboFilter.Text = cboFilter.Items[0].ToString();
        }

        private void cboFilter_TextChanged(object sender, EventArgs e)
        {
            string day, month, year;

            day = DateTime.Now.ToString("yyyy/MM/dd");
            month = DateTime.Now.ToString("MM");
            year = DateTime.Now.ToString("yyyy");

            switch (cboFilter.SelectedIndex)
            {
                case 0:
                    {
                        txtTongPhieu.Text = Tong("select COUNT(MaPhieu) from PhieuMuonTra").ToString();
                        txtTongSachMuon.Text = Tong("select COUNT(MaPhieu) from CTPhieuMuonTra").ToString();
                        txtTongSachHong.Text = Tong("select COUNT(MaSach) from SachHong").ToString();
                    }
                    break;
                case 1:
                    {
                        txtTongPhieu.Text = Tong("select COUNT(MaPhieu) from PhieuMuonTra where NgayTao = '"+day+"'").ToString();
                        txtTongSachMuon.Text = Tong("select COUNT(MaSach) from PhieuMuonTra inner join CTPhieuMuonTra on PhieuMuonTra.MaPhieu = CTPhieuMuonTra.MaPhieu where NgayTao = '"+day+"'").ToString();
                        txtTongSachHong.Text = Tong("select COUNT(MaSach) from SachHong where NgayBaoHong = '" + day+"'").ToString();
                    }
                    break;
                case 2:
                    {
                        txtTongPhieu.Text = Tong("select COUNT(MaPhieu) from PhieuMuonTra where YEAR(NgayTao) = '" + year + "' and MONTH(NgayTao) = '"+month+"'").ToString();
                        txtTongSachMuon.Text = Tong("select COUNT(MaSach) from PhieuMuonTra inner join CTPhieuMuonTra on PhieuMuonTra.MaPhieu = CTPhieuMuonTra.MaPhieu where YEAR(NgayTao) = '" + year + "' and MONTH(NgayTao) = '"+month+"'").ToString();
                        txtTongSachHong.Text = Tong("select COUNT(MaSach) from SachHong where  YEAR(NgayBaoHong) = '" + year + "' and MONTH(NgayBaoHong) = '" + month + "'").ToString();
                    }
                    break;
                case 3:
                    {
                        txtTongPhieu.Text = Tong("select COUNT(MaPhieu) from PhieuMuonTra where YEAR(NgayTao) = '" + year + "'").ToString();
                        txtTongSachMuon.Text = Tong("select COUNT(MaSach) from PhieuMuonTra inner join CTPhieuMuonTra on PhieuMuonTra.MaPhieu = CTPhieuMuonTra.MaPhieu where YEAR(NgayTao) = '" + year + "'").ToString();
                        txtTongSachHong.Text = Tong("select COUNT(MaSach) from SachHong where  YEAR(NgayBaoHong) = '" + year + "'").ToString();
                    }
                    break;
            }
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
