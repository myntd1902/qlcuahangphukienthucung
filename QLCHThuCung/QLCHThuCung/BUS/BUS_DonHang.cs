using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHThuCung.DAO;

namespace QLCHThuCung.BUS
{
    class BUS_DonHang
    {
        DAO_DonHang dDonHang;

        public BUS_DonHang()
        {
            dDonHang = new DAO_DonHang();
        }

        public void LayDSDH(DataGridView d, int maKH)
        {
            d.DataSource = dDonHang.LayDSDH(maKH);
        }

        public void LayCTDH(DataGridView d, int maDH)
        {
            d.DataSource = dDonHang.LayCTDH(maDH);
        }
    }
}
