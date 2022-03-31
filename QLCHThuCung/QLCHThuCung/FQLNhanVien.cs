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
    public partial class FQLNhanVien : Form
    {
        public int idQL;
        BUS_User bUser;
        public FQLNhanVien()
        {
            InitializeComponent();
            bUser = new BUS_User();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fQuanLy fQL = new fQuanLy();
            fQL.idQL = this.idQL;

            this.Close();
            fQL.Show();
        }

        private void FQLNhanVien_Load(object sender, EventArgs e)
        {
            loadDSUsers(dgDSNV);
            loabCBTimKiem(cbTimKiem);
            loabCBTrangThai(cbTrangThai);
            loabCBLoaiUser(cbLoaiNV);

        }

        private void loadDSUsers(DataGridView dg)
        {
            dg.DataSource = null;
            bUser.GetDSUsers(dg);

            dg.Columns[0].Width = (int)(dg.Width * 0.10);
            dg.Columns[1].Width = (int)(dg.Width * 0.25);
            dg.Columns[2].Width = (int)(dg.Width * 0.10);
            dg.Columns[3].Width = (int)(dg.Width * 0.10);
            dg.Columns[4].Width = (int)(dg.Width * 0.15);
            dg.Columns[5].Width = (int)(dg.Width * 0.10);
            dg.Columns[6].Width = (int)(dg.Width * 0.10);
        }
        private void loabCBTimKiem(ComboBox cb)
        {
            cb.Items.Add("Mã nhân viên");
            cb.Items.Add("Mã loại nhân viên");
            cb.Items.Add("Số điện thoại");
            cb.Items.Add("Chứng minh nhân dân");
            cb.Items.Add("Tên tài khoản");
            cb.SelectedIndex = 0;
        }

        private void loabCBTrangThai(ComboBox cb)
        {
            cb.Items.Add("Đang hoạt động");
            cb.Items.Add("Đã khóa");
            cb.SelectedIndex = 0;
        }

        private void loabCBLoaiUser(ComboBox cb)
        {
            BUS_LoaiUser bLoaiUser = new BUS_LoaiUser();
            bLoaiUser.GetDSLoaiUser(cb);
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (tbTimKiem.Text.Replace(" ", "").Length != 0)
            {
                if (cbTimKiem.SelectedIndex != 4)
                {
                    if (IsNumber(tbTimKiem.Text.Replace(" ", "")))
                    {
                        if (cbTimKiem.SelectedIndex == 0)
                        {
                            bUser.FindUserByID(dgDSNV, int.Parse(tbTimKiem.Text.Replace(" ", "")));

                        }
                        else if (cbTimKiem.SelectedIndex == 1)
                        {
                            bUser.FindUserByLoaiUserID(dgDSNV, int.Parse(tbTimKiem.Text.Replace(" ", "")));
                        }
                        else if (cbTimKiem.SelectedIndex == 2)
                        {
                            bUser.FindUserBySDT(dgDSNV, tbTimKiem.Text.Replace(" ", ""));
                        }
                        else
                        {
                            bUser.FindUserByCMND(dgDSNV, tbTimKiem.Text.Replace(" ", ""));
                        }
                    }
                    else
                        MessageBox.Show("Vui lòng chỉ nhập số!!");
                }
                else
                {
                    bUser.FindUserByTenTK(dgDSNV, tbTimKiem.Text.Replace(" ", ""));
                }
            }
            else
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!!");
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

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            loadDSUsers(dgDSNV);
        }

        private void dgDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgDSNV.Rows.Count)
            {
                User u = bUser.GetUserByID(int.Parse(dgDSNV.Rows[e.RowIndex].Cells[0].Value.ToString()));
                tbMaNV.Text = u.UserID.ToString();
                tbHoTen.Text = u.HoTen;
                tbTaiKhoan.Text = u.TaiKhoan;
                tbCMND.Text = u.CMND;
                tbEmail.Text = u.Email;
                tbGioiTinh.Text = u.GioiTinh;
                tbSDT.Text = u.SDT;
                tbDiaChi.Text = u.DiaChi;
                dtpNgaySinh.Text = u.NgaySinh.ToString();
                dtpNgayVaoLam.Text = u.NgayVaoLam.ToString();

                if (u.TrangThai)
                {
                    cbTrangThai.SelectedIndex = 0;
                }
                else
                    cbTrangThai.SelectedIndex = 1;
                cbLoaiNV.SelectedValue = u.LoaiUserID;
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            User u = bUser.GetUserByID(int.Parse(tbMaNV.Text));

            if (tbHoTen.Text.Replace(" ", "").Length != 0)
            {
                u.HoTen = tbHoTen.Text;
                if (DateTime.Now.Year - dtpNgaySinh.Value.Year > 15)
                {
                    u.NgaySinh = dtpNgaySinh.Value;
                    u.NgayVaoLam = dtpNgayVaoLam.Value;
                    if (tbGioiTinh.Text.Replace(" ", "").Length != 0)
                    {
                        u.GioiTinh = tbGioiTinh.Text;
                        if (IsNumber(tbCMND.Text.Replace(" ", "")) && IsNumber(tbSDT.Text.Replace(" ", "")))
                        {
                            u.CMND = tbCMND.Text.Replace(" ", "");
                            u.SDT = tbSDT.Text.Replace(" ", "");
                            u.LoaiUserID = int.Parse(cbLoaiNV.SelectedValue.ToString());
                            u.DiaChi = tbDiaChi.Text;
                            if (cbTrangThai.SelectedIndex == 0)
                            {
                                u.TrangThai = true;
                            }
                            else
                                u.TrangThai = false;
                            if (bUser.UpdateUser(u))
                            {
                                MessageBox.Show("Cập nhật thông tin nhân viên thành công!!!");

                            }
                            else
                                MessageBox.Show("Cập nhật thông tin nhân viên thất bại!!!");
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập CMND/CCCD, số điện thoại là số!!!");
                        }
                    }
                    else
                        MessageBox.Show("Vui lòng nhập giới tính!!!");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tuổi nhân viên lớn hơn 16!!!");
                }

            }
            else
                MessageBox.Show("Vui lòng nhập tên nhân viên!!!");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (bUser.DeleteUser(int.Parse(tbMaNV.Text)))
            {
                MessageBox.Show("Xóa thành công!!!");
                loadDSUsers(dgDSNV);
            }
            else
                MessageBox.Show("Xóa nhân viên thất bại!!!");
        }

        private void btThêm_Click(object sender, EventArgs e)
        {
            User u = new User();
            if (tbHoTen.Text.Replace(" ", "").Length != 0)
            {
                u.HoTen = tbHoTen.Text;
                if (DateTime.Now.Year - dtpNgaySinh.Value.Year > 15)
                {
                    u.NgaySinh = dtpNgaySinh.Value;
                    u.NgayVaoLam = dtpNgayVaoLam.Value;
                    if (tbGioiTinh.Text.Replace(" ", "").Length != 0)
                    {
                        u.GioiTinh = tbGioiTinh.Text;
                        if (IsNumber(tbCMND.Text.Replace(" ", "")) && IsNumber(tbSDT.Text.Replace(" ", "")))
                        {
                            if (!(bUser.FindUserByCMND(tbCMND.Text.Replace(" ", ""))))
                            {
                                u.CMND = tbCMND.Text.Replace(" ", "");
                                if (!(bUser.FindUserBySDT(tbSDT.Text.Replace(" ", ""))))
                                {
                                    u.SDT = tbSDT.Text.Replace(" ", "");
                                    u.DiaChi = tbDiaChi.Text;
                                    u.Email = tbEmail.Text;
                                    if (!(bUser.FindUserByTenTK(tbTaiKhoan.Text.Replace(" ", ""))))
                                    {
                                        u.TaiKhoan = tbTaiKhoan.Text.Replace(" ", "");
                                        u.MatKhau = "1";
                                        u.LoaiUserID = int.Parse(cbLoaiNV.SelectedValue.ToString());
                                        if (cbTrangThai.SelectedIndex == 0)
                                        {
                                            u.TrangThai = true;
                                        }
                                        else
                                            u.TrangThai = false;

                                        if (bUser.AddUser(u))
                                        {
                                            MessageBox.Show("Thêm nhân viên thành công!!");
                                            loadDSUsers(dgDSNV);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Thêm nhân viên thất bại!!!");
                                        }
                                    }
                                    else
                                        MessageBox.Show("Trùng tên tài khoản!!!");

                                }
                                else
                                    MessageBox.Show("Trùng số điện thoại!!!");

                            }
                            else
                                MessageBox.Show("Trùng CMND/CCCD!!!");

                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập CMND/CCCD, số điện thoại là số!!!");
                        }
                    }
                    else
                        MessageBox.Show("Vui lòng nhập giới tính!!!");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tuổi nhân viên lớn hơn 16!!!");
                }

            }
            else
                MessageBox.Show("Vui lòng nhập tên nhân viên!!!");
        }

    }
}
