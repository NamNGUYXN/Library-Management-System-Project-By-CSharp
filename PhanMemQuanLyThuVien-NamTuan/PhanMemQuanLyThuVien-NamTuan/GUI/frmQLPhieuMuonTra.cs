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

namespace PhanMemQuanLyThuVien_NamTuan
{
    public partial class frmQLPhieuMuonTra : Form
    {
        int SoLuongSachMax = 0;
        public frmQLPhieuMuonTra()
        {
            InitializeComponent();
        }

        void HienThiMaDocGia()
        {
            DateTime dt = DateTime.Now;
            string HienTai = dt.ToString("yyyy/MM/dd");
            string query = "SELECT MaTDG FROM TheDocGia WHERE TrangThai != 0 AND NgayHetHan > '" + HienTai + "'";
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            cboLibraryCardId.DataSource = data;
            cboLibraryCardId.ValueMember = "MaTDG";
            cboLibraryCardId.DisplayMember = "MaTDG";
            // Xóa việc chương trình tự chọn hàng đầu tiên trong cboReaderId
            cboLibraryCardId.Text = "";
        }

        void HienThiMaSach(string query = "SELECT MaSach FROM Sach WHERE TrangThai = 1")
        {
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            clbBooks.DataSource = data;
            clbBooks.DisplayMember = "MaSach";
            clbBooks.ValueMember = "MaSach";
            // Xóa việc chương trình tự chọn hàng đầu tiên trong clbBooks
            clbBooks.ClearSelected();
        }

        void HienThiMaTK()
        {
            txtLibrarianId.Text = frmDangNhap.MaTK.ToUpper();
        }

        void HienThiHanTra()
        {
            DateTime CurrentDate = DateTime.Now;
            int NgayHT = CurrentDate.Day;
            int ThangHT = CurrentDate.Month;
            int NamHT = CurrentDate.Year;

            // Class này tự viết
            TimNgayThangNam timNTN = new TimNgayThangNam(NgayHT, ThangHT, NamHT);
            DateTime AfterDate = timNTN.SauSoNgay(21); // 3 tuần
            dtpTerm.Text = AfterDate.ToString();
        }

        void HienThiMaPhieuKeTiep()
        {
            // Tìm mã phiếu cao nhất trong csdl
            string query = "SELECT MAX(MaPhieu) FROM PhieuMuonTra";
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            string MaPhieuMax = data.Rows[0][0].ToString();

            if (MaPhieuMax == "")
                txtLoanCardId.Text = "P001";
            else
            {
                // Tách ra phần chuỗi và số
                string StringPart = Regex.Match(MaPhieuMax, @"[A-Z]+").Value;
                int NumberPart = int.Parse(Regex.Match(MaPhieuMax, @"\d+").Value);

                // Tăng phần số lên 1 đơn vị
                NumberPart++;

                // Nối phần chuỗi và số lại
                string MaPhieuKeTiep = StringPart + NumberPart.ToString("D3");
                txtLoanCardId.Text = MaPhieuKeTiep;
            } 
                
        }

        void HienThiBangPhieuMuon(string query = "SELECT * FROM PhieuMuonTra")
        {
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
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

            cboFilterDate.Items.Add("Tất cả");
            cboFilterDate.Items.Add("Ngày tạo");
            cboFilterDate.Items.Add("Hạn trả");
            cboFilterDate.Items.Add("Ngày trả");
            cboFilterLibraryCardId.Items.Add("Tất cả");
            cboFilterLibrarianId.Items.Add("Tất cả");
            cboCompleted.Items.Add("Tất cả");
            cboCompleted.Items.Add("Chưa");
            cboCompleted.Items.Add("Rồi");
            DoDuLieu.DoDuLieucbo("MaTDG", "TheDocGia", cboFilterLibraryCardId);
            DoDuLieu.DoDuLieucbo("MaTK", "TaiKhoan", cboFilterLibrarianId);
            cboFilterDate.SelectedIndex = 0;
            cboCompleted.SelectedIndex = 0;
            cboFilterLibraryCardId.SelectedIndex = 0;
            cboFilterLibrarianId.SelectedIndex = 0;

            HienThiBangPhieuMuon();
            HienThiMaDocGia();
            HienThiMaTK();
            HienThiMaSach();
            HienThiHanTra();
            HienThiMaPhieuKeTiep();
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
            // Không cho nhập vào ô tìm sách
            txtSearchBook.Enabled = false;
            btnBorrow.Enabled = false;

            // Không hiển thị thông tin sách
            txtBookName.Text = "";
            txtCategory.Text = "";
            txtAuthor.Text = "";

            // Đưa dữ liệu tại hàng đang click vào các biến
            string MaPhieu, MaTK, MaTDG, GhiChu;
            DateTime HanTra;
            MaPhieu = dgvDataList.CurrentRow.Cells["MaPhieu"].Value.ToString();
            MaTK = dgvDataList.CurrentRow.Cells["MaTK"].Value.ToString();
            MaTDG = dgvDataList.CurrentRow.Cells["MaTDG"].Value.ToString();
            HanTra = (DateTime)dgvDataList.CurrentRow.Cells["HanTra"].Value;
            GhiChu = dgvDataList.CurrentRow.Cells["GhiChu"].Value.ToString();

            //
            bool DaTra = (bool)dgvDataList.CurrentRow.Cells["DaTra"].Value;
            if (!DaTra) btnReturn.Enabled = true;
            else btnReturn.Enabled = false;

            DateTime dt = DateTime.Now;
            if (HanTra < dt && !DaTra) btnExtend.Enabled = true;
            else btnExtend.Enabled = false;

            // Hiển thị lên các ô nhập
            txtLoanCardId.Text = MaPhieu;
            cboLibraryCardId.Text = MaTDG;
            txtLibrarianId.Text = MaTK;
            dtpTerm.Text = HanTra.ToString();
            txtNote.Text = GhiChu;

            // Xóa các item trong clbBooks và lstBooks
            clbBooks.DataSource = null;
            clbBooks.Items.Clear();
            lstBooks.Items.Clear();

            // Lấy các mã sách trong phiếu mượn và đưa vào lstBooks
            string query = "SELECT s.MaSach";
            query += " FROM Sach s INNER JOIN CTPhieuMuonTra ctpmt ";
            query += " ON s.MaSach = ctpmt.MaSach WHERE MaPhieu = '" + MaPhieu + "'";
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            foreach (DataRow dr in data.Rows)
            {
                lstBooks.Items.Add(dr[0].ToString());
            }

            // Lấy thông tin độc giả đưa vào phần thông tin độc giả
            query = "SELECT HoTenDG, SDT";
            query += " FROM TheDocGia WHERE MaTDG = '" + MaTDG + "'";
            data = ThucThiTruyVanBus.LayDuLieu(query);
            if (data.Rows.Count > 0)
            {
                txtReaderName.Text = data.Rows[0][0].ToString();
                txtPhone.Text = data.Rows[0][1].ToString();
            }
        }

        // Khi chọn độc giả từ cboReaderId
        private void cboReaderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra vị trí chọn item trong cboReaderId hợp lệ
            if (cboLibraryCardId.SelectedIndex != -1)
            {
                // Lấy đc mã độc giả từ giá trị đang đc chọn ở cboReaderId
                string MaTDG = cboLibraryCardId.SelectedValue.ToString();
                // Lấy thông tin độc giả từ csdl và đưa vào phần thông tin độc giả
                string query = "SELECT HoTenDG, SDT";
                query += " FROM TheDocGia WHERE MaTDG = '" + MaTDG + "'";
                DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
                if (data.Rows.Count > 0)
                {
                    txtReaderName.Text = data.Rows[0][0].ToString();
                    txtPhone.Text = data.Rows[0][1].ToString();
                }
            }    

            // Ko hợp lệ thì ko hiện lên phần thông tin độc giả
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
                // Lấy item đang đc click
                ListViewItem SelectedItem = lstBooks.SelectedItems[0];
                // Lấy đc mã sách từ SelectedItem
                string MaSach = SelectedItem.Text;
                // Lấy thông tin sách từ csdl và đưa vào phần thông tin sách
                string query = "SELECT TenSach, TenTL, HoTenTG ";
                query += " FROM Sach s INNER JOIN TheLoai tl ON s.MaTL = tl.MaTL ";
                query += " INNER JOIN TacGia tg ON s.MaTG = tg.MaTG ";
                query += " WHERE MaSach = '" + MaSach + "'";
                DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
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
                string query = "SELECT TenSach, TenTL, HoTenTG ";
                query += " FROM Sach s INNER JOIN TheLoai tl ON s.MaTL = tl.MaTL ";
                query += " INNER JOIN TacGia tg ON s.MaTG = tg.MaTG ";
                query += " WHERE MaSach = '" + MaSach + "'";
                DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
                if (data.Rows.Count > 0)
                {
                    txtBookName.Text = data.Rows[0][0].ToString();
                    txtCategory.Text = data.Rows[0][1].ToString();
                    txtAuthor.Text = data.Rows[0][2].ToString();
                }
            }

            // Ko hợp lệ thì ko hiện lên phần thông tin sách
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
                    SoLuongSachMax++;
                    //Kiểm tra số lượng sách cho mượn ko hơn 3 cuốn
                    if (SoLuongSachMax <= 3)
                    {
                        lstBooks.Items.Add(MaSach);
                    }
                    // Trường hợp hơn 3 cuốn
                    else
                    {
                        SoLuongSachMax--;
                        e.NewValue = CheckState.Unchecked;
                        MessageBox.Show("Số sách được mượn tối đa 3 cuốn",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // Trường hợp bỏ check sách
                else
                {
                    // Nếu bỏ check thì số lượng sách cho mượn -1
                    SoLuongSachMax--;

                    // Tìm vị trí mã sách trong lstBooks mà bỏ check bên clbBooks
                    int ViTri = 0;
                    foreach (ListViewItem item in lstBooks.Items)
                    {
                        if (item.Text == MaSach) break;
                        ViTri++;
                    }
                    // Xóa item tại vị trí vừa tìm đc
                    lstBooks.Items.RemoveAt(ViTri);
                }
            }
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            // Trường hợp khi xóa hết nội dung tìm sách
            if (txtSearchBook.Text == "")
            {
                // Hiển thị lại các mã sách trong clbBooks
                HienThiMaSach();
                // Tạo list lưu các index mà được checked bên lstBooks
                List<int> lstIndex = new List<int>();

                // Lặp qua các object của clbBooks
                foreach (object clbItem in clbBooks.Items)
                {
                    // Thử ép kiểu object clbBooks.Items[0] sang DataRowView
                    // Nếu thành công drv = clbBooks.Items[0]
                    // Nếu thất bại drv = null
                    DataRowView drv = clbItem as DataRowView;

                    // Lặp qua các item của lstBooks
                    foreach (ListViewItem item in lstBooks.Items)
                    {
                        if (drv != null)
                        {
                            // Dùng tên cột cụ thể để lấy được giá trị thực tế.
                            // Lấy các index mà tại đó giá trị phải checked
                            if (item.Text == drv["MaSach"].ToString())
                            {
                                int index = clbBooks.Items.IndexOf(clbItem);
                                // Ko thiết lập checked trực tiếp ở đây đc
                                // Thêm index vừa lấy đc vào lstIndex
                                lstIndex.Add(index);
                            }
                        }
                    }
                }
                // Thiết lập checked cho các item clbBooks tại index đã lấy được
                for (int i = 0; i < lstIndex.Count; i++)
                {
                    clbBooks.SetItemChecked(lstIndex[i], true);
                }
            }
            // Trường hợp nhập đúng mã sách cần tìm
            else
            {
                // Lấy mã sách đã nhập và tìm trên csdl rồi đưa dữ liệu vào clbBooks
                string MaSach = txtSearchBook.Text;
                string query = "SELECT MaSach FROM Sach";
                query += " WHERE MaSach = '" + MaSach + "'";
                HienThiMaSach(query);

                // Số lượng dữ liệu trong clbBooks khi này phải > 0
                if (clbBooks.Items.Count > 0)
                {
                    // Lặp qua các item của lstBooks
                    foreach (ListViewItem item in lstBooks.Items)
                    {
                        DataRowView drv = clbBooks.Items[0] as DataRowView;
                        if (drv != null)
                        {
                            // Nếu bên lstBooks có item vừa tìm
                            // Thì cho item bên clbBooks checked lên
                            if (item.Text == drv["MaSach"].ToString())
                                clbBooks.SetItemChecked(0, true);
                        }
                    }
                }
            }
        }

        void ResetDuLieuNhap()
        {
            // Reset biến global SoLuongSachMax
            SoLuongSachMax = 0;

            txtSearchBook.Enabled = true;
            btnReturn.Enabled = false;
            btnBorrow.Enabled = true;

            cboLibraryCardId.SelectedIndex = -1;
            cboLibraryCardId.SelectedValue = "";
            cboLibraryCardId.Text = "";

            clbBooks.SelectedIndex = -1;
            clbBooks.SelectedValue = "";

            txtSearchBook.Text = "";
            txtNote.Text = "";

            // Xóa các item trong lstBooks và clbBooks
            lstBooks.Items.Clear();
            clbBooks.DataSource = null;
            clbBooks.Items.Clear();

            // Hiển thị lại vài thông tin
            HienThiBangPhieuMuon();
            HienThiMaPhieuKeTiep();
            HienThiMaTK();
            HienThiMaSach();
            HienThiHanTra();

            cboFilterDate.SelectedIndex = 0;
            cboCompleted.SelectedIndex = 0;
            cboFilterLibraryCardId.SelectedIndex = 0;
            cboFilterLibrarianId.SelectedIndex = 0;
            chkLate.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM PhieuMuonTra";
            query += " WHERE MaPhieu LIKE '%" + NoiDungTim + "%'";
            HienThiBangPhieuMuon(query);
            cboFilterDate.SelectedIndex = 0;
            cboCompleted.SelectedIndex = 0;
            cboFilterLibraryCardId.SelectedIndex = 0;
            cboFilterLibrarianId.SelectedIndex = 0;
            chkLate.Checked = false;
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
            string IDDGQuery, IDTKQuery, DateType, DateQuery, StartDate, EndDate;
            string LateQuery, CompletedQuery;
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
                DateQuery = DateType + " BETWEEN '" + StartDate + "' AND '" + EndDate + "'";
            else DateQuery = "1 = 1";

            if (cboFilterLibraryCardId.Text == cboFilterLibraryCardId.Items[0].ToString())
                IDDGQuery = "1 = 1";
            else IDDGQuery = "MaTDG = '" + cboFilterLibraryCardId.Text + "'";

            if (cboFilterLibrarianId.Text == cboFilterLibrarianId.Items[0].ToString())
                IDTKQuery = "1 = 1";
            else IDTKQuery = "MaTK = '" + cboFilterLibrarianId.Text + "'";

            switch(cboCompleted.SelectedIndex)
            {
                case 1: CompletedQuery = "DaTra = 0"; break;
                case 2: CompletedQuery = "DaTra = 1"; break;
                default: CompletedQuery = "1 = 1"; break;
            }

            DateTime dt = DateTime.Now;
            string CurrentDate = dt.ToString("yyyy/MM/dd");
            if (chkLate.Checked == true)
                LateQuery = "(NgayTra > HanTra OR (DaTra = 0 AND '" + CurrentDate + "' > HanTra))";
            else LateQuery = "1 = 1";
            //MessageBox.Show("SELECT * FROM PhieuMuonTra WHERE " + DateQuery + " AND " +
            //    IDDGQuery + " AND " + IDTKQuery + " AND " + CompletedQuery + " AND " + LateQuery);
            HienThiBangPhieuMuon("SELECT * FROM PhieuMuonTra WHERE " + DateQuery + " AND " +
                IDDGQuery + " AND " + IDTKQuery + " AND " + CompletedQuery + " AND " + LateQuery);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmXacNhanTra frmXacNhanTra = new frmXacNhanTra();
            frmXacNhanTra.MaPhieu = dgvDataList.CurrentRow.Cells["MaPhieu"].Value.ToString();
            frmXacNhanTra.MaTDG = dgvDataList.CurrentRow.Cells["MaTDG"].Value.ToString();
            frmXacNhanTra.ShowDialog();
            ResetDuLieuNhap();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý cho mượn?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query, MaPhieu, MaTDG, MaTK, NgayTao, HanTra, NgayTra, GhiChu;
                int DaTra;
                ListView lst = lstBooks;
                MaPhieu = txtLoanCardId.Text;
                MaTDG = cboLibraryCardId.Text;
                MaTK = txtLibrarianId.Text;
                DateTime dt = DateTime.Now;
                NgayTao = dt.ToString("yyyy/MM/dd");
                HanTra = dtpTerm.Value.ToString("yyyy/MM/dd");
                NgayTra = "null";
                DaTra = 0;
                GhiChu = txtNote.Text;

                string ThongBao = "";
                if (MaTDG == "") ThongBao += "Vui lòng chọn thẻ độc giả!";

                if (lst.Items.Count < 1)
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng chọn sách!";
                }

                //
                query = "SELECT COUNT(*) FROM PhieuMuonTra p INNER JOIN CTPhieuMuonTra ct";
                query += " ON p.MaPhieu = ct.MaPhieu WHERE MaTDG = '" + MaTDG + "' AND DaTra = 0";
                int SoSachDaMuon = (int)ThucThiTruyVanBus.LayDuLieu(query).Rows[0][0];
                int SoSachDuocMuon = 3 - SoSachDaMuon;
                if (lst.Items.Count > SoSachDuocMuon)
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    if (SoSachDuocMuon == 0)
                        ThongBao += "Độc giả này đã hết lượt mượn sách!";
                    else
                        ThongBao += "Độc giả này chỉ được mượn thêm " + SoSachDuocMuon + " cuốn!";
                }

                if (ThongBao == "")
                {
                    query = "INSERT INTO PhieuMuonTra (MaPhieu, MaTDG, MaTK, NgayTao,";
                    query += " HanTra, NgayTra, DaTra, GhiChu) VALUES ('" + MaPhieu + "',";
                    query += " '" + MaTDG + "', '" + MaTK + "', '" + NgayTao + "',";
                    query += " '" + HanTra + "', " + NgayTra + ", " + DaTra + ", '" + GhiChu + "')";
                    int RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);

                    foreach (ListViewItem item in lst.Items)
                    {
                        query = "INSERT INTO CTPhieuMuonTra (MaPhieu, MaSach) VALUES ('" + MaPhieu + "',";
                        query += " '" + item.Text + "')";
                        RowsAffected += ThucThiTruyVanBus.ThaoTacDuLieu(query);

                        //
                        query = "SELECT SoLuong FROM Sach WHERE MaSach = '" + item.Text + "'";
                        int SoLuong = (int)ThucThiTruyVanBus.LayDuLieu(query).Rows[0][0];
                        SoLuong--;
                        query = "UPDATE Sach SET SoLuong = " + SoLuong + " WHERE MaSach = '" + item.Text + "'";
                        RowsAffected += ThucThiTruyVanBus.ThaoTacDuLieu(query);
                    }

                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Cho mượn thành công!", "Thông báo",
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

        private void btnExtend_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý gia hạn?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaPhieu, HanTra, ThongBao = "";
                MaPhieu = txtLoanCardId.Text;
                DateTime dt = DateTime.Now;
                TimNgayThangNam TimNTN1 = new TimNgayThangNam(dt.Day, dt.Month, dt.Year);
                HanTra = TimNTN1.SauSoNgay(7).ToString("yyyy/MM/dd");

                string query = "SELECT HanTra FROM PhieuMuonTra WHERE MaPhieu = '" + MaPhieu + "'";
                DateTime HanTraTrongCSDL = (DateTime)ThucThiTruyVanBus.LayDuLieu(query).Rows[0][0];
                TimNgayThangNam TimNTN2 = new TimNgayThangNam(HanTraTrongCSDL);
                DateTime NgayToiDaDuocGiaHan = TimNTN2.SauSoNgay(5);
                if (dt > NgayToiDaDuocGiaHan)
                {
                    ThongBao += "Thời hạn độc giả được gia hạn đã hơn 5 ngày!";
                }

                if (ThongBao == "")
                {
                    query = "UPDATE PhieuMuonTra SET HanTra = '" + HanTra + "'";
                    query += " WHERE MaPhieu = '" + MaPhieu + "'";

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
    }
}
