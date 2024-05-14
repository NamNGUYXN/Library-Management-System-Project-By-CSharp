using GUI;
using PhanMemQuanLyThuVien_NamTuan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Reflection;
using System.Collections;
using PhanMemQuanLyThuVien_NamTuan.GUI;
using PhanMemQuanLyThuVien_NamTuan.DTO;

namespace PhanMemQuanLyThuVien_NamTuan
{
    public partial class frmQLPhieuMuonTra : Form
    {
        int ValidBookQuantity = 0;
        public frmQLPhieuMuonTra()
        {
            InitializeComponent();
        }

        void DisplayLibraryCardId()
        {
            DateTime dt = DateTime.Now;
            string NgayHienTai = dt.ToString("yyyy/MM/dd");
            string query = "SELECT MaTDG FROM TheDocGia WHERE TrangThai = 1 AND NgayHetHan > '" + NgayHienTai + "'";
            cboLibraryCardId.DataSource = TheDocGiaBus.GetData(query);
            cboLibraryCardId.ValueMember = "MaTDG";
            cboLibraryCardId.DisplayMember = "MaTDG";
            // Xóa việc chương trình tự chọn hàng đầu tiên trong cboLibraryCardId
            cboLibraryCardId.SelectedIndex = -1;
        }

        void DisplayBookId(DataTable data = null)
        {
            if (data == null)
            {
                string query = "SELECT MaSach FROM Sach WHERE TrangThai = 1 AND SoLuong <> 0";
                data = SachBUS.GetData(query);
            }
            clbBooks.DataSource = data;
            clbBooks.DisplayMember = "MaSach";
            clbBooks.ValueMember = "MaSach";
            // Xóa việc chương trình tự chọn hàng đầu tiên trong clbBooks
            clbBooks.ClearSelected();
        }

        void DisplayLibrarianId()
        {
            txtLibrarianId.Text = frmDangNhap.MaTK.ToUpper();
        }

        void DisplayDueDate()
        {
            dtpDueDate.Text = PhieuMuonTraBUS.SauSoNgay(DateTime.Now, 21).ToString();
        }

        void DisplayFilterDate()
        {
            cboFilterDate.Items.Add("Tất cả");
            cboFilterDate.Items.Add("Ngày tạo");
            cboFilterDate.Items.Add("Hạn trả");
            cboFilterDate.Items.Add("Ngày trả");
        }

        void DisplayFilterLibraryCardId()
        {
            DataTable data = TheDocGiaBus.GetData();
            cboFilterLibraryCardId.Items.Add("Tất cả");
            foreach (DataRow dr in data.Rows)
            {
                cboFilterLibraryCardId.Items.Add(dr[0]);
            }
        }

        void DisplayFilterLibrarianId()
        {
            DataTable data = TaiKhoanBUS.GetData();
            cboFilterLibrarianId.Items.Add("Tất cả");
            foreach (DataRow dr in data.Rows)
            {
                cboFilterLibrarianId.Items.Add(dr[0]);
            }
        }

        void DisplayFilterCompleted()
        {
            cboFilterCompleted.Items.Add("Tất cả");
            cboFilterCompleted.Items.Add("Chưa");
            cboFilterCompleted.Items.Add("Rồi");
        }

        void DisplayNextLoanCardId()
        {
            txtLoanCardId.Text = PhieuMuonTraBUS.CreateNextId();
        }

        void DisplayLoanCard(DataTable data = null)
        {
            if (data == null) data = PhieuMuonTraBUS.GetData();

            dgvDataList.DataSource = data;
            txtQuantity.Text = data.Rows.Count.ToString();

            // Xóa việc chương trình tự chọn hàng đầu tiên trong dgvDataList
            dgvDataList.ClearSelection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhieuMuonTra_Load(object sender, EventArgs e)
        {
            // Không tự động tạo các cột tiêu đề
            dgvDataList.AutoGenerateColumns = false;
            btnReturn.Enabled = false;
            btnBorrow.Enabled = true;
            btnExtend.Enabled = false;
            // Hiện dữ liệu trong combobox ở phần nhập liệu
            DisplayLoanCard();
            DisplayLibraryCardId();
            DisplayLibrarianId();
            DisplayBookId();
            DisplayDueDate();
            DisplayNextLoanCardId();
            // Hiện dữ liệu trong combobox ở phần bộ lọc
            DisplayFilterDate();
            DisplayFilterCompleted();
            DisplayFilterLibraryCardId();
            DisplayFilterLibrarianId();
            cboFilterDate.SelectedIndex = 0;
            cboFilterCompleted.SelectedIndex = 0;
            cboFilterLibraryCardId.SelectedIndex = 0;
            cboFilterLibrarianId.SelectedIndex = 0;
        }

        // Sửa cách hiển thị dữ liệu của cột đã trả
        private void dgvDataList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value.GetType() == typeof(bool) && e.RowIndex >= 0)
            {
                bool value = (bool)e.Value;

                // Tùy chỉnh cách hiển thị của giá trị boolean
                if (value) e.Value = "Rồi";
                else e.Value = "Chưa";

                // Đặt kiểu dữ liệu của ô là chuỗi để đảm bảo hiển thị đúng
                e.FormattingApplied = true;
            }
        }

        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSearchBook.Enabled = false;
            btnBorrow.Enabled = false;
            cboLibraryCardId.Enabled = false;
            txtNote.Enabled = false;
            txtBookName.Text = "";
            txtCategory.Text = "";
            txtAuthor.Text = "";
            txtSearchBook.Text = "";
            try
            {
                string MaPhieu, MaTK, MaTDG, GhiChu;
                DateTime HanTra;
                MaPhieu = dgvDataList.CurrentRow.Cells["MaPhieu"].Value.ToString();
                MaTK = dgvDataList.CurrentRow.Cells["MaTK"].Value.ToString();
                MaTDG = dgvDataList.CurrentRow.Cells["MaTDG"].Value.ToString();
                HanTra = (DateTime)dgvDataList.CurrentRow.Cells["HanTra"].Value;
                GhiChu = dgvDataList.CurrentRow.Cells["GhiChu"].Value.ToString();
                bool DaTra = (bool)dgvDataList.CurrentRow.Cells["DaTra"].Value;
                // Chưa trả thì nút trả sách sẽ nhấn đc
                if (!DaTra) btnReturn.Enabled = true;
                else btnReturn.Enabled = false;

                // Hết hạn và chưa trả mới nhấn đc nút gia hạn
                DateTime dtNow = DateTime.Now;
                if (dtNow > HanTra && !DaTra) btnExtend.Enabled = true;
                else btnExtend.Enabled = false;

                // Hiển thị lên các ô nhập
                txtLoanCardId.Text = MaPhieu;
                cboLibraryCardId.Text = MaTDG;
                txtLibrarianId.Text = MaTK;
                dtpDueDate.Text = HanTra.ToString();
                txtNote.Text = GhiChu;

                // Xóa các item trong clbBooks và lstBooks
                clbBooks.DataSource = null;
                clbBooks.Items.Clear();
                lstBooks.Items.Clear();
                // Lấy các mã sách trong phiếu mượn và đưa vào lstBooks
                string query = $"SELECT MaSach FROM CTPhieuMuonTra WHERE MaPhieu = '{MaPhieu}'";
                DataTable data = CTPhieuMuonTraBUS.GetData(query);
                foreach (DataRow dr in data.Rows)
                {
                    lstBooks.Items.Add(dr[0].ToString());
                }

                // Lấy thông tin độc giả đưa vào phần thông tin độc giả
                query = $"SELECT HoTenDG, SDT FROM TheDocGia WHERE MaTDG = '{MaTDG}'";
                data = TheDocGiaBus.GetData(query);
                if (data.Rows.Count > 0)
                {
                    txtReaderName.Text = data.Rows[0][0].ToString();
                    txtPhone.Text = data.Rows[0][1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        // Khi chọn độc giả từ cboLibraryCardId
        private void cboLibraryCardId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra vị trí chọn item trong cboLibraryCardId hợp lệ
            if (cboLibraryCardId.SelectedIndex != -1)
            {
                // Lấy đc mã độc giả từ giá trị đang đc chọn ở cboLibraryCardId
                string MaTDG = cboLibraryCardId.SelectedValue.ToString();
                // Lấy thông tin độc giả từ csdl và đưa vào phần thông tin độc giả
                string query = $"SELECT HoTenDG, SDT FROM TheDocGia WHERE MaTDG = '{MaTDG}'";
                DataTable data = TheDocGiaBus.GetData(query);
                if (data.Rows.Count > 0)
                {
                    txtReaderName.Text = data.Rows[0][0].ToString();
                    txtPhone.Text = data.Rows[0][1].ToString();
                }
            }
            else
            {
                txtReaderName.Text = "";
                txtPhone.Text = "";
            }
        }

        // Khi bấm vào các item trong lstBooks
        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra lstBooks có ít nhất 1 item
            if (lstBooks.SelectedItems.Count > 0)
            {
                // Lấy đc mã sách từ SelectedItem
                string MaSach = lstBooks.SelectedItems[0].Text;
                // Lấy thông tin sách từ csdl và đưa vào phần thông tin sách
                string query = "SELECT TenSach, TenTL, HoTenTG FROM Sach s INNER JOIN TheLoai tl";
                query += " ON s.MaTL = tl.MaTL INNER JOIN TacGia tg ON s.MaTG = tg.MaTG";
                query += $" WHERE MaSach = '{MaSach}'";
                DataTable data = SachBUS.GetData(query);
                if (data.Rows.Count > 0)
                {
                    txtBookName.Text = data.Rows[0][0].ToString();
                    txtCategory.Text = data.Rows[0][1].ToString();
                    txtAuthor.Text = data.Rows[0][2].ToString();
                }
            }
        }

        // Khi bấm vào các item trong clbBooks
        private void clbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra vị trí chọn item trong clbBooks hợp lệ
            if (clbBooks.SelectedIndex != -1)
            {
                // Lấy đc mã sách từ giá trị đang đc chọn ở clbBooks
                string MaSach = clbBooks.SelectedValue.ToString();
                // Lấy thông tin sách từ csdl và đưa vào phần thông tin sách
                string query = "SELECT TenSach, TenTL, HoTenTG FROM Sach s INNER JOIN TheLoai tl";
                query += " ON s.MaTL = tl.MaTL INNER JOIN TacGia tg ON s.MaTG = tg.MaTG";
                query += $" WHERE MaSach = '{MaSach}'";
                DataTable data = SachBUS.GetData(query);
                if (data.Rows.Count > 0)
                {
                    txtBookName.Text = data.Rows[0][0].ToString();
                    txtCategory.Text = data.Rows[0][1].ToString();
                    txtAuthor.Text = data.Rows[0][2].ToString();
                }
            }
            else
            {
                txtBookName.Text = "";
                txtCategory.Text = "";
                txtAuthor.Text = "";
            }
        }

        // Khi check vào ô vuông nằm cạnh item của clbBooks
        private void clbBooks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Kiểm tra vị trí chọn item trong clbBooks hợp lệ
            if (clbBooks.SelectedIndex != -1)
            {
                // Lấy đc mã sách từ giá trị đang đc chọn ở clbBooks
                string MaSach = clbBooks.SelectedValue.ToString();

                // Trường hợp check sách
                if (e.NewValue == CheckState.Checked)
                {
                    // Nếu check lên thì số lượng sách cho mượn +1
                    ValidBookQuantity++;
                    //Kiểm tra số lượng sách cho mượn ko hơn 3 cuốn
                    if (ValidBookQuantity <= 3)
                    {
                        lstBooks.Items.Add(MaSach);
                    }
                    // Trường hợp hơn 3 cuốn
                    else
                    {
                        ValidBookQuantity--;
                        e.NewValue = CheckState.Unchecked;
                        MessageBox.Show("Số sách được mượn tối đa 3 cuốn",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                // Trường hợp bỏ check sách
                else
                {
                    // Nếu bỏ check thì số lượng sách cho mượn -1
                    ValidBookQuantity--;

                    // Tìm vị trí mã sách trong lstBooks mà vừa bỏ check bên clbBooks
                    int pos = 0;
                    foreach (ListViewItem item in lstBooks.Items)
                    {
                        if (item.Text == MaSach) break;
                        pos++;
                    }
                    // Xóa item tại vị trí vừa tìm đc
                    lstBooks.Items.RemoveAt(pos);
                }
            }
        }

        // Tìm mã sách
        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            string MaSach = txtSearchBook.Text;
            string query = "SELECT MaSach FROM Sach WHERE TrangThai = 1 AND SoLuong <> 0 AND MaSach LIKE @MaSach";
            ParameterCSDL param = new ParameterCSDL("MaSach", $"%{MaSach}%");
            List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
            LstParams.Add(param);
            DataTable data = SachBUS.GetData(query, LstParams);

            // Hiển thị các mã sách trong clbBooks
            DisplayBookId(data);

            // Xóa hết check
            for (int i = 0; i < clbBooks.Items.Count; i++)
            {
                clbBooks.SetItemChecked(i, false);
            }

            // Lặp qua các object của clbBooks
            for (int i = 0; i < clbBooks.Items.Count; i++)
            {
                // Thử ép kiểu object clbBooks.Items[0] sang DataRowView
                // Nếu thành công drv = clbBooks.Items[0]
                // Nếu thất bại drv = null
                DataRowView drv = clbBooks.Items[i] as DataRowView;
                // Lặp qua các item của lstBooks
                foreach (ListViewItem item in lstBooks.Items)
                {
                    if (drv != null)
                    {
                        // Dùng tên cột cụ thể để lấy được giá trị thực tế.
                        // Lấy các index mà tại đó giá trị phải checked
                        if (item.Text == drv["MaSach"].ToString())
                            clbBooks.SetItemChecked(i, true);
                    }
                }
            }
        }

        void ResetAll()
        {
            // Reset biến global ValidBookQuantity
            ValidBookQuantity = 0;

            txtSearchBook.Enabled = true;
            txtNote.Enabled = true;
            btnReturn.Enabled = false;
            btnBorrow.Enabled = true;
            btnExtend.Enabled = false;
            cboLibraryCardId.Enabled = true;
            chkFilterLate.Checked = false;
            cboLibraryCardId.SelectedIndex = -1;
            clbBooks.SelectedIndex = -1;
            cboFilterDate.SelectedIndex = 0;
            cboFilterCompleted.SelectedIndex = 0;
            cboFilterLibraryCardId.SelectedIndex = 0;
            cboFilterLibrarianId.SelectedIndex = 0;
            // Xóa các item trong lstBooks và clbBooks
            lstBooks.Items.Clear();
            clbBooks.DataSource = null;
            clbBooks.Items.Clear();
            // Hiển thị lại vài thông tin
            DisplayLoanCard();
            DisplayNextLoanCardId();
            DisplayLibrarianId();
            DisplayBookId();
            DisplayDueDate();

            txtSearchBook.Text = "";
            txtNote.Text = "";
            dtpStartDate.Value = dtpEndDate.Value = DateTime.Now;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            ResetAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = PhieuMuonTraBUS.SearchData("MaPhieu", txtSearch.Text);
            DisplayLoanCard(data);
        }

        private void cboFilterDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilterDate.SelectedIndex != -1)
            {
                if (cboFilterDate.SelectedIndex == 0)
                {
                    dtpStartDate.Enabled = false;
                    dtpEndDate.Enabled = false;
                }
                else
                {
                    dtpStartDate.Enabled = true;
                    dtpEndDate.Enabled = true;
                }
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if(dtpEndDate.Value < dtpStartDate.Value)
            {
                dtpEndDate.Value = dtpStartDate.Value;
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                dtpStartDate.Value = dtpEndDate.Value;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string LibraryCardId, LibrarianId, DateType, Date, StartDate, EndDate;
            string Late, Completed;
            StartDate = dtpStartDate.Value.ToString("yyyy/MM/dd");
            EndDate = dtpEndDate.Value.ToString("yyyy/MM/dd");

            switch (cboFilterDate.SelectedIndex)
            {
                case 1: DateType = "NgayTao"; break;
                case 2: DateType = "HanTra"; break;
                case 3: DateType = "NgayTra"; break;
                default: DateType = ""; break;
            }

            if (DateType != "")
                Date = $"{DateType} BETWEEN '{StartDate}' AND '{EndDate}'";
            else Date = "1 = 1";

            if (cboFilterLibraryCardId.Text == cboFilterLibraryCardId.Items[0].ToString())
                LibraryCardId = "1 = 1";
            else LibraryCardId = $"MaTDG = '{cboFilterLibraryCardId.Text}'";

            if (cboFilterLibrarianId.Text == cboFilterLibrarianId.Items[0].ToString())
                LibrarianId = "1 = 1";
            else LibrarianId = $"MaTK = '{cboFilterLibrarianId.Text}'";

            switch (cboFilterCompleted.SelectedIndex)
            {
                case 1: Completed = "DaTra = 0"; break;
                case 2: Completed = "DaTra = 1"; break;
                default: Completed = "1 = 1"; break;
            }
            DateTime dtNow = DateTime.Now;
            string CurrentDate = dtNow.ToString("yyyy/MM/dd");
            if (chkFilterLate.Checked == true)
                Late = $"(NgayTra > HanTra OR (DaTra = 0 AND '{CurrentDate}' > HanTra))";
            else Late = "1 = 1";

            string query = $"SELECT * FROM PhieuMuonTra WHERE {Date} AND {LibraryCardId} AND {LibrarianId}";
            query += $" AND {Completed} AND {Late}";
            DataTable data = PhieuMuonTraBUS.GetData(query);
            DisplayLoanCard(data);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmXacNhanTra frmXacNhanTra = new frmXacNhanTra();
            frmXacNhanTra.MaPhieu = dgvDataList.CurrentRow.Cells["MaPhieu"].Value.ToString();
            frmXacNhanTra.MaTDG = dgvDataList.CurrentRow.Cells["MaTDG"].Value.ToString();
            frmXacNhanTra.ShowDialog();
            ResetAll();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý cho mượn?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaPhieu, MaTDG, MaTK, NgayTao, HanTra, GhiChu;
                MaPhieu = txtLoanCardId.Text;
                MaTDG = (cboLibraryCardId.SelectedIndex != -1) ? 
                    cboLibraryCardId.SelectedValue.ToString() : "";
                MaTK = txtLibrarianId.Text;
                DateTime dtNow = DateTime.Now;
                NgayTao = dtNow.ToString("yyyy/MM/dd");
                HanTra = dtpDueDate.Value.ToString("yyyy/MM/dd");
                GhiChu = txtNote.Text;

                string ThongBao = "";
                if (MaTDG == "") ThongBao += "Thẻ độc giả không tồn tại hoặc đã hết hạn!";

                if (lstBooks.Items.Count < 1)
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng chọn sách!";
                }

                string query = "SELECT COUNT(MaSach) FROM PhieuMuonTra p INNER JOIN CTPhieuMuonTra ct";
                query += $" ON p.MaPhieu = ct.MaPhieu WHERE MaTDG = '{MaTDG}' AND DaTra = 0";
                int SoSachDaMuon = (int)PhieuMuonTraBUS.GetData(query).Rows[0][0];
                int SoSachDuocMuon = 3 - SoSachDaMuon;
                if (lstBooks.Items.Count > SoSachDuocMuon)
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    if (SoSachDuocMuon == 0)
                        ThongBao += "Độc giả này đã hết lượt mượn sách!";
                    else
                        ThongBao += $"Độc giả này chỉ được mượn thêm {SoSachDuocMuon} cuốn!";
                }

                if (ThongBao == "")
                {
                    query = "INSERT INTO PhieuMuonTra (MaPhieu, MaTDG, MaTK, NgayTao,";
                    query += " HanTra, NgayTra, DaTra, GhiChu) VALUES ('" + MaPhieu + "',";
                    ParameterCSDL pMaPhieu = new ParameterCSDL("MaPhieu", MaPhieu);
                    ParameterCSDL pMaTDG = new ParameterCSDL("MaTDG", MaTDG);
                    ParameterCSDL pMaTK = new ParameterCSDL("MaTK", MaTK);
                    ParameterCSDL pNgayTao = new ParameterCSDL("NgayTao", NgayTao);
                    ParameterCSDL pHanTra = new ParameterCSDL("HanTra", HanTra);
                    ParameterCSDL pGhiChu = new ParameterCSDL("GhiChu", GhiChu);
                    ParameterCSDL[] pArray = { pMaPhieu, pMaTDG, pMaTK, pNgayTao, pHanTra, pGhiChu };
                    List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                    LstParams.AddRange(pArray);

                    int RowsAffected = PhieuMuonTraBUS.InsertData(LstParams);

                    foreach (ListViewItem item in lstBooks.Items)
                    {
                        string MaSach = item.Text;
                        CTPhieuMuonTraBUS.InsertData(MaPhieu, MaSach);
                        SachBUS.UpdateInStock(MaSach, -1);
                    }

                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Cho mượn thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetAll();
                    }
                }
                else
                {
                    MessageBox.Show(ThongBao, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý gia hạn?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaPhieu, HanTra, ThongBao = "";
                MaPhieu = txtLoanCardId.Text;
                DateTime dtNow = DateTime.Now;
                HanTra = PhieuMuonTraBUS.SauSoNgay(dtNow, 7).ToString("yyyy/MM/dd");

                // Lấy ngày của sau 5 ngày kể từ ngày hết hạn
                string query = $"SELECT HanTra FROM PhieuMuonTra WHERE MaPhieu = '{MaPhieu}'";
                DateTime HanTraTrongCSDL = (DateTime)PhieuMuonTraBUS.GetData(query).Rows[0][0];
                DateTime NgayToiDaDuocGiaHan = PhieuMuonTraBUS.SauSoNgay(HanTraTrongCSDL, 5);

                // Nếu qua 5 ngày kể từ ngày hết hạn
                if (dtNow > NgayToiDaDuocGiaHan)
                {
                    ThongBao += "Thời hạn độc giả được gia hạn đã hơn 5 ngày!";
                }

                if (ThongBao == "")
                {
                    int RowsAffected = PhieuMuonTraBUS.Extend(MaPhieu, HanTra);

                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Gia hạn thành công!", "Thông báo",
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
    }
}
