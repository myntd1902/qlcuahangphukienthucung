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
    public partial class FQLHangHoa : Form
    {
        BUS_HangHoa bHangHoa;
        public int idQL;
        public FQLHangHoa()
        {
            InitializeComponent();
            bHangHoa = new BUS_HangHoa();
        }

        private void FQLHangHoa_Load(object sender, EventArgs e)
        {
            loadDSHangHoa(dgHangHoa);
            loadDSNCC(cbNhaCC);
            loadDSLoaiHH(cbLoaiHH);
            loabCBTimKiem(cbTimKiem);
            loadCBTinhTrang(cbTinhTrang);

        }


        private void loadDSHangHoa(DataGridView dg)
        {
            dg.DataSource = null;
            bHangHoa.GetDSHangHoa(dg);

            dg.Columns[0].Width = (int)(dg.Width * 0.12);
            dg.Columns[1].Width = (int)(dg.Width * 0.25);
            dg.Columns[2].Width = (int)(dg.Width * 0.12);
            dg.Columns[3].Width = (int)(dg.Width * 0.13);
            dg.Columns[4].Width = (int)(dg.Width * 0.10);
            dg.Columns[5].Width = (int)(dg.Width * 0.10);
            dg.Columns[6].Width = (int)(dg.Width * 0.10);
        }

        private void loadDSNCC(ComboBox cb)
        {
            BUS_NhaCungCap bNCC = new BUS_NhaCungCap();
            bNCC.cbNCC(cb);
        }
        private void loadDSLoaiHH(ComboBox cb)
        {
            BUS_LoaiHangHoa bLoaiHH = new BUS_LoaiHangHoa();
            bLoaiHH.GetDSLoaiHH(cb);
        }

        private void loabCBTimKiem(ComboBox cb)
        {
            cb.Items.Add("Mã hàng hóa");
            cb.Items.Add("Mã loại hàng hóa");
            cb.Items.Add("Mã nhà cung cấp");
            cb.SelectedIndex = 0;
        }

        private void loadCBTinhTrang(ComboBox cb)
        {
            cb.Items.Add("Đang bán");
            cb.Items.Add("Ngừng bán");
            cb.SelectedIndex = 0;
        }

        private void dgHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgHangHoa.Rows.Count)
            {
                HangHoa hh = bHangHoa.GetHangHoaByID(int.Parse(dgHangHoa.Rows[e.RowIndex].Cells["HangHoaID"].Value.ToString()));
                tbMaHH.Text = hh.HangHoaID.ToString();
                tbTenHH.Text = hh.TenHangHoa;
                tbGia.Text = hh.GiaNiemYet.ToString();
                tbGiaNhap.Text = hh.GiaNhap.ToString();
                tbSoLuongTK.Text = hh.SoLuongTK.ToString();
                if(hh.ThuongHieu.Replace(" ","").Length != 0)
                {
                    tbThuongHieu.Text = hh.ThuongHieu;
                }
                else
                    tbThuongHieu.Text = " ";
                cbLoaiHH.SelectedValue = hh.LoaiHangHoaID;
                if (hh.TinhTrang)
                {
                    cbTinhTrang.SelectedIndex = 0;
                }
                else
                    cbTinhTrang.SelectedIndex = 1;
                BUS_NhaCungCap bNCC = new BUS_NhaCungCap();
                cbNhaCC.SelectedValue = hh.NhaCungCapID;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            if (tbTenHH.Text.Replace(" ", "").Length != 0)
            {
                hh.TenHangHoa = tbTenHH.Text;
                if (tbGia.Text.Replace(".", "").Length != 0 && tbGiaNhap.Text.Replace(".", "").Length != 0)
                {
                    if(IsNumber(tbGia.Text.Replace(" ", "")) && IsNumber(tbGiaNhap.Text.Replace(" ","")))
                    {
                        if (tbSoLuongTK.Text.Length != 0)
                        {
                            hh.SoLuongTK = int.Parse(tbSoLuongTK.Text);
                        }
                        else
                            hh.SoLuongTK = 0;
                        if (tbThuongHieu.Text.Replace(" ", "").Length != 0)
                        {
                            hh.ThuongHieu = tbThuongHieu.Text;
                        }
                        else
                            hh.ThuongHieu = " ";
                        hh.GiaNiemYet = decimal.Parse(tbGia.Text.Replace(".", ""));
                        hh.GiaNhap = decimal.Parse(tbGiaNhap.Text.Replace(".", ""));
                        hh.LoaiHangHoaID = int.Parse(cbLoaiHH.SelectedValue.ToString());
                        hh.NhaCungCapID = int.Parse(cbNhaCC.SelectedValue.ToString());
                        if (cbTinhTrang.SelectedItem.Equals("Đang bán"))
                        {
                            hh.TinhTrang = true;
                        }
                        else
                        {
                            hh.TinhTrang = false;
                        }
                        if (bHangHoa.AddHoangHoa(hh))
                        {
                            MessageBox.Show("Thêm hàng hóa thành công!!");
                            loadDSHangHoa(dgHangHoa);
                        }
                        else
                        {
                            MessageBox.Show("Thêm hàng hóa thất bại!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập giá niêm yết/giá nhập là số!!!");
                    }
                    
                }
                else
                    MessageBox.Show("Vui lòng nhập giá niêm yết/giá nhập!!!");
                
            }
            else
                MessageBox.Show("Vui lòng nhập tên hàng hóa!!!");

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (bHangHoa.DeleteHangHoa(int.Parse(tbMaHH.Text)))
            {
                MessageBox.Show("Xóa hàng hóa thành công!!");
                loadDSHangHoa(dgHangHoa);
            }
            else
            {
                MessageBox.Show("Xóa hàng hóa thất bại!!");
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.HangHoaID = int.Parse(tbMaHH.Text);
            if (tbTenHH.Text.Replace(" ", "").Length != 0)
            {
                hh.TenHangHoa = tbTenHH.Text;
                if (tbThuongHieu.Text.Replace(" ", "").Length != 0)
                {
                    hh.ThuongHieu = tbThuongHieu.Text;
                    if (tbGia.Text.Replace(" ", "").Length != 0 && tbGiaNhap.Text.Replace(" ", "").Length != 0)
                    {
                        if (IsNumber(tbGia.Text.Replace(" ", "")) && IsNumber(tbGiaNhap.Text.Replace(" ", "")))
                        {
                            hh.GiaNiemYet = Convert.ToDecimal(tbGia.Text.Replace(".", ""));
                            hh.GiaNhap = Convert.ToDecimal(tbGiaNhap.Text.Replace(".", ""));
                            if (tbSoLuongTK.Text.Replace(" ", "").Length != 0)
                            {
                                hh.SoLuongTK = int.Parse(tbSoLuongTK.Text);
                                hh.LoaiHangHoaID = int.Parse(cbLoaiHH.SelectedValue.ToString());
                                hh.NhaCungCapID = int.Parse(cbNhaCC.SelectedValue.ToString());
                                if (cbTinhTrang.Text.Equals("Đang bán"))
                                {
                                    hh.TinhTrang = true;
                                }
                                else
                                    hh.TinhTrang = false;

                                if (bHangHoa.UpdateHangHoa(hh))
                                {
                                    MessageBox.Show("Cập nhật hàng hóa thành công!!");
                                    loadDSHangHoa(dgHangHoa);
                                }
                                else
                                {
                                    MessageBox.Show("Cập nhật hàng hóa thất bại!!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập số lượng!!");
                            }
                        }
                        else
                            MessageBox.Show("Vui lòng nhập giá nhập/giá niêm yết là số!!!");


                    }
                    else
                        MessageBox.Show("Vui lòng nhập giá niêm yết/giá nhập!!!");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên thương hiệu!!");
                }
                
            }
            else
                MessageBox.Show("Vui lòng nhập tên hàng hóa!!");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(tbTimKiem.Text.Replace(" ","").Length != 0)
            {
                if(IsNumber(tbTimKiem.Text.Replace(" ", "")))
                {
                    if (cbTimKiem.SelectedIndex == 0)
                    {
                        bHangHoa.FindHangHoaByID(dgHangHoa, int.Parse(tbTimKiem.Text.Replace(" ", "")));
                       
                    }
                    else if (cbTimKiem.SelectedIndex == 1)
                    {
                        bHangHoa.FindHangHoaByIDLoaiHH(dgHangHoa, int.Parse(tbTimKiem.Text.Replace(" ", "")));
                    }
                    else
                    {
                        bHangHoa.FindHangHoaByIDNCC(dgHangHoa, int.Parse(tbTimKiem.Text.Replace(" ", "")));
                    }
                }
                else
                    MessageBox.Show("Vui lòng chỉ nhập số!!");
            }
            else
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!!");

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            fQuanLy fQL = new fQuanLy();
            fQL.idQL = this.idQL;

            this.Close();
            fQL.Show();
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            loadDSHangHoa(dgHangHoa);
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

    }
}
