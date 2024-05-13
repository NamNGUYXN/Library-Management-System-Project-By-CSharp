using GUI;
using PhanMemQuanLyThuVien_NamTuan.BUS;
using PhanMemQuanLyThuVien_NamTuan.DTO;
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

namespace PhanMemQuanLyThuVien_NamTuan.GUI
{
    public partial class frmXacNhanTra : Form
    {
        public string MaPhieu = "";
        public string MaTDG = "";
        List<SachHong> DSSachHong = new List<SachHong>();
        List<string> DSSach = new List<string>();
        string MaSach = "";
        string MoTa = "";

        public frmXacNhanTra()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DisplayBookId()
        {
            string query = $"SELECT MaSach FROM CTPhieuMuonTra WHERE MaPhieu = '{MaPhieu}'";
            DataTable data = CTPhieuMuonTraBUS.GetData(query);
            // Đưa các mã sách vào list DSSach
            foreach (DataRow dr in data.Rows)
            {
                DSSach.Add(dr[0].ToString());
            }
            clbBooks.DataSource = data;
            clbBooks.DisplayMember = "MaSach";
            clbBooks.ValueMember = "MaSach";
            // Xóa việc chương trình tự chọn hàng đầu tiên trong clbBooks
            clbBooks.ClearSelected();
        }

        private void frmXacNhanTra_Load(object sender, EventArgs e)
        {
            txtDescription.Enabled = false;
            btnSaveDescription.Enabled = false;

            DisplayBookId();
        }

        // Sự kiện xảy ra khi nội dung ô mô tả
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            MoTa = txtDescription.Text;
        }

        private void clbBooks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Trường hợp check mã sách
            if (e.NewValue == CheckState.Checked)
            {
                txtDescription.Enabled = true;
                btnSaveDescription.Enabled = true;
                MaSach = clbBooks.SelectedValue.ToString();
                SachHong sh = new SachHong(MaSach, "");
                DSSachHong.Add(sh);

                // Khi sách đó check nghĩa là trong DSSach ta sẽ bỏ mã sách tương ứng
                int index = 0;
                foreach (string sach in DSSach)
                {
                    if (sach == clbBooks.SelectedValue.ToString()) break;
                    index++;
                }
                DSSach.RemoveAt(index);
            }
            //Trường hợp bỏ check
            else
            {
                txtDescription.Text = "";
                txtDescription.Enabled = false;
                btnSaveDescription.Enabled = false;

                // Khi sách đó bỏ check nghĩa là trong DSSachHong ta sẽ bỏ mã sách tương ứng
                int index = 0;
                foreach (SachHong itemSH in DSSachHong)
                {
                    if (itemSH.MaSach == clbBooks.SelectedValue.ToString()) break;
                    index++;
                }
                DSSachHong.RemoveAt(index);

                // Thêm lại sách đó vào DSSach
                string MaSach = clbBooks.SelectedValue.ToString();
                DSSach.Add(MaSach);
            }
        }

        private void clbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
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

                int index = clbBooks.SelectedIndex;
                // Trường hợp tại ô vừa nhấn nếu ko có check
                if (!clbBooks.GetItemChecked(index))
                {
                    txtDescription.Enabled = false;
                    btnSaveDescription.Enabled = false;
                    txtDescription.Text = "";
                }
                // Trường hợp có check lên
                else
                {
                    txtDescription.Enabled = true;
                    btnSaveDescription.Enabled = true;
                    // Tìm mô tả của sách hỏng đó gán cho textbox
                    foreach (SachHong sh in DSSachHong)
                    {
                        if (sh.MaSach == clbBooks.SelectedValue.ToString())
                            txtDescription.Text = sh.MoTa;
                    }
                }
            }
        }

        private void btnSaveDescription_Click(object sender, EventArgs e)
        {
            // Trường hợp tại mã sách đang nhấn có check lên
            int index = clbBooks.SelectedIndex;
            if (clbBooks.GetItemChecked(index))
            {
                // Thì gán mô tả cho sách hỏng đó
                foreach (SachHong sh in DSSachHong)
                {
                    if (sh.MaSach == clbBooks.SelectedValue.ToString())
                        sh.MoTa = this.MoTa;
                }
            }

            if (MoTa == "")
            {
                MessageBox.Show("Mô tả không được để trống!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý xác nhận trả?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string ThongBao = "";
                foreach (SachHong sh in DSSachHong)
                {
                    if (sh.MoTa == "")
                        ThongBao += $"Mô tả của mã sách {sh.MaSach} chưa nhập!\n";
                }
                
                if (ThongBao == "")
                {
                    string NgayTra = DateTime.Now.ToString("yyyy/MM/dd");
                    int RowsAffected = PhieuMuonTraBUS.UpdateData(MaPhieu, NgayTra);

                    ParameterCSDL pNgayBaoHong = new ParameterCSDL("NgayBaoHong", NgayTra);
                    foreach (SachHong sh in DSSachHong)
                    {
                        string MaSH = SachHongBUS.CreateNextId();
                        string MaSach = sh.MaSach;
                        string MoTa = sh.MoTa;
                        ParameterCSDL pMaSH = new ParameterCSDL("MaSH", MaSH);
                        ParameterCSDL pMaSach = new ParameterCSDL("MaSach", MaSach);
                        ParameterCSDL pMaTDG = new ParameterCSDL("MaTDG", MaTDG);
                        ParameterCSDL pMoTa = new ParameterCSDL("MoTa", MoTa);
                        ParameterCSDL[] pArray = { pMaSH, pMaSach, pMaTDG, pMoTa, pNgayBaoHong };
                        List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                        LstParams.AddRange(pArray);
                        SachHongBUS.InsertData(LstParams);
                    }

                    foreach (string sach in DSSach)
                    {
                        SachBUS.UpdateInStock(sach, 1);
                    }

                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Xác nhận trả thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                    MessageBox.Show(ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
