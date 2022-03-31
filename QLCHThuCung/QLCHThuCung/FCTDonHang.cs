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
    public partial class FCTDonHang : Form
    {
        public int idCT;
        public int maDH;
        BUS_DonHang bDonHang;
        public FCTDonHang()
        {
            InitializeComponent();
            bDonHang = new BUS_DonHang();
        }
        public void HienCTDH(int maDH)
        {
            dgvCTDH.DataSource = null;
            bDonHang.LayCTDH(dgvCTDH,maDH);

            dgvCTDH.Columns[0].Width = (int)(dgvCTDH.Width * 0.25);
            dgvCTDH.Columns[1].Width = (int)(dgvCTDH.Width * 0.2);
            dgvCTDH.Columns[2].Width = (int)(dgvCTDH.Width * 0.25);
            dgvCTDH.Columns[3].Width = (int)(dgvCTDH.Width * 0.25);

            dgvCTDH.Columns[0].HeaderText = "Tên Hàng Hóa";
            dgvCTDH.Columns[1].HeaderText = "Số Lượng";
            dgvCTDH.Columns[2].HeaderText = "Đơn Giá";
            dgvCTDH.Columns[3].HeaderText = "Giảm Giá";
        }

        private void FCTDonHang_Load(object sender, EventArgs e)
        {
            HienCTDH(maDH);
        }
    }
}
