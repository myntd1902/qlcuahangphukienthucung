using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHThuCung
{
    public partial class fQuanLy : Form
    {
        public int idQL;
        public fQuanLy()
        {
            InitializeComponent();
        }

        private void btQLHangHoa_Click(object sender, EventArgs e)
        {
            FQLHangHoa fQLHH = new FQLHangHoa();
            fQLHH.idQL = this.idQL;
            this.Close();
            fQLHH.ShowDialog();
            
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            FQLNhanVien fQLNV = new FQLNhanVien();
            fQLNV.idQL = this.idQL;
            this.Close();
            fQLNV.ShowDialog();
            
        }

        private void btDoanhThu_Click(object sender, EventArgs e)
        {
            FThongKe fTK = new FThongKe();
            fTK.idQL = this.idQL;
            this.Close();
            fTK.ShowDialog();
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            FQLKhachHang fQLKH = new FQLKhachHang();
            fQLKH.idQL = this.idQL;
            this.Close();
            fQLKH.ShowDialog();
        }
    }
}
