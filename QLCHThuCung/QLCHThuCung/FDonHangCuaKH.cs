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
    public partial class FDonHangCuaKH : Form
    {
        public int idD;
        public int maKH;
        BUS_DonHang bDonHang;
        public FDonHangCuaKH()
        {
            InitializeComponent();
            bDonHang = new BUS_DonHang();
        }

        private void LayDSDH(int maKH)
        {
            dgvDSDH.DataSource = null;
            bDonHang.LayDSDH(dgvDSDH, maKH);

            dgvDSDH.Columns[0].Width = (int)(dgvDSDH.Width * 0.25);
            dgvDSDH.Columns[1].Width = (int)(dgvDSDH.Width * 0.35);
            dgvDSDH.Columns[2].Width = (int)(dgvDSDH.Width * 0.35);

            dgvDSDH.Columns[0].HeaderText = "ID";
            dgvDSDH.Columns[1].HeaderText = "Ngày Tạo";
            dgvDSDH.Columns[2].HeaderText = "Nhân Viên";
        }
        private void FDonHangCuaKH_Load(object sender, EventArgs e)
        {
            LayDSDH(maKH);
        }

        private void dgvDSDH_DoubleClick(object sender, EventArgs e)
        {
            int ma;
            ma = int.Parse(dgvDSDH.CurrentRow.Cells[0].Value.ToString());
            FCTDonHang f = new FCTDonHang();
            f.maDH = ma;
            f.idCT = this.idD;
            f.ShowDialog();
        }
    }
}
