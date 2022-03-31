using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHThuCung.BUS;

namespace QLCHThuCung
{
    public partial class FQLKhachHang : Form
    {
        public int idQL;
        BUS_KhachHang bKhachHang;
        public FQLKhachHang()
        {
            InitializeComponent();
            bKhachHang = new BUS_KhachHang();
        }

        public void HienDSKH(DataGridView d)
        {
            d.DataSource = null;
            bKhachHang.LayDSKH(d);

            d.Columns[0].Width = (int)(d.Width * 0.05);
            d.Columns[1].Width = (int)(d.Width * 0.2);
            d.Columns[2].Width = (int)(d.Width * 0.15);
            d.Columns[3].Width = (int)(d.Width * 0.1);
            d.Columns[4].Width = (int)(d.Width * 0.3);
            d.Columns[5].Width = (int)(d.Width * 0.15);

            d.Columns[0].HeaderText = "ID";
            d.Columns[1].HeaderText = "Họ Tên";
            d.Columns[2].HeaderText = "Ngày Sinh";
            d.Columns[3].HeaderText = "Giới Tính";
            d.Columns[4].HeaderText = "Địa Chỉ";
            d.Columns[5].HeaderText = "SĐT";
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            fQuanLy fQL = new fQuanLy();
            fQL.idQL = this.idQL;
            this.Close();
            fQL.Show();
        }

        private void HienCbTimKiem(ComboBox cb)
        {
            cb.Items.Add("Mã khách hàng");
            cb.Items.Add("Số điện thoại");
            cb.SelectedIndex = 0;
        }

        private void FQLKhachHang_Load(object sender, EventArgs e)
        {
            HienDSKH(dgvDS);
            HienCbTimKiem(cbTimKiem);
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dgvDS.Rows.Count)
            {
                //tbMaKH.Enabled = false;
                tbMaKH.Text = dgvDS.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbHoTen.Text = dgvDS.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNS.Text = dgvDS.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbGT.Text = dgvDS.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbDiaChi.Text = dgvDS.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbSDT.Text = dgvDS.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        public static bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }


        private void btTim_Click(object sender, EventArgs e)
        {
            if (tbTimKiem.Text.Replace(" ", "").Length != 0)
            {
                    if (IsAllDigits(tbTimKiem.Text.Replace(" ", "")))
                    {
                    if (cbTimKiem.SelectedIndex == 0)
                        bKhachHang.TimTheoID(dgvDS, int.Parse(tbTimKiem.Text.Replace(" ", "")));
                    else
                        bKhachHang.TimTheoSDT(dgvDS, tbTimKiem.Text);
                    }
                    else
                        MessageBox.Show("Vui lòng chỉ nhập số!!");
            }
            else
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!!");
        }

        private void btDS_Click(object sender, EventArgs e)
        {
            HienDSKH(dgvDS);
        }

        private void btThêm_Click(object sender, EventArgs e)
        {
            KhachHang k = new KhachHang();
            if (tbHoTen.Text.Replace(" ", "").Length != 0
                && tbGT.Text.Replace(" ", "").Length != 0
                && tbSDT.Text.Replace(" ", "").Length != 0
                && tbDiaChi.Text.Replace(" ", "").Length != 0)
            {
                k.HoTen = tbHoTen.Text;
                k.GioiTinh = tbGT.Text;
                k.NgaySinh = dtpNS.Value;
                k.DiaChi = tbDiaChi.Text;
                if (IsAllDigits(tbSDT.Text.Replace(" ", "")))
                {
                    if (!(bKhachHang.KiemTraSDT(tbSDT.Text.Replace(" ", ""))))
                    {
                        k.SDT = tbSDT.Text;
                        if (bKhachHang.ThemKhachHang(k))
                        {
                            MessageBox.Show("Thêm khách hàng thành công!!");
                            HienDSKH(dgvDS);
                        }
                        else
                            MessageBox.Show("Thêm khách hàng thất bại!!!");
                    }
                    else
                        MessageBox.Show("Số điện thoại này đã được sử dụng!!!");

                }
                else
                    MessageBox.Show("Vui lòng điền đúng!!!");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            KhachHang k = bKhachHang.LayKhachHangID(int.Parse(tbMaKH.Text));
            if (tbHoTen.Text.Replace(" ", "").Length != 0
                && tbGT.Text.Replace(" ", "").Length != 0
                && tbSDT.Text.Replace(" ", "").Length != 0
                && tbDiaChi.Text.Replace(" ", "").Length != 0)
            {
                k.HoTen = tbHoTen.Text;
                k.GioiTinh = tbGT.Text;
                k.NgaySinh = dtpNS.Value;
                k.DiaChi = tbDiaChi.Text;
                if (IsAllDigits(tbSDT.Text.Replace(" ", "")))
                {
                    k.SDT = tbSDT.Text;
                    if (bKhachHang.SuaKhachHang(k))
                    {
                        MessageBox.Show("Sửa khách hàng thành công!!");
                        HienDSKH(dgvDS);
                    }
                    else
                        MessageBox.Show("Sửa khách hàng thất bại!!!");

                }
                else
                    MessageBox.Show("Vui lòng điền đúng!!!");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (bKhachHang.XoaKhachHang(int.Parse(tbMaKH.Text)))
            {
                MessageBox.Show("Xóa khách hàng thành công!!!");
                HienDSKH(dgvDS);
            }
            else
                MessageBox.Show("Không thể xóa khách hàng lâu năm!!!");
        }

        private void dgvDS_DoubleClick(object sender, EventArgs e)
        {
            int ma;
            ma = int.Parse(dgvDS.CurrentRow.Cells[0].Value.ToString());
            FDonHangCuaKH f = new FDonHangCuaKH();
            f.maKH = ma;
            f.idD = this.idQL;
            f.ShowDialog();
        }
    }
    
}
