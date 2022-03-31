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
    public partial class fDangNhap : Form
    {
        BUS_User bUser;
        public fDangNhap()
        {
            InitializeComponent();
            bUser = new BUS_User();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            int id = bUser.Login(txtTK.Text, txtMK.Text);
            if ( id > 0)
            {
                User u = bUser.GetUserByID(id);
                if(u.LoaiUserID == 1)
                {
                    fQuanLy fQL = new fQuanLy();
                    fQL.idQL = u.UserID;
                    fQL.Show();
                }
                else if(u.LoaiUserID == 3)
                {
                    fNhanVien fNV = new fNhanVien();
                    fNV.Show();
                }
                this.Hide();
            }
            else
            {
                if (id == 0)
                {
                    MessageBox.Show("Sai tên tài khoản!!");
                }
                else if(id == -1)
                {
                    MessageBox.Show("Sai mật khẩu!!");
                }
                else
                {
                    MessageBox.Show("Tài khoản đã ngừng hoạt động!!");
                }
            }
            
        }

    }
}
