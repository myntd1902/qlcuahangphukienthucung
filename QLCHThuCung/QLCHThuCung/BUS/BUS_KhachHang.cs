using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHThuCung.DAO;

namespace QLCHThuCung.BUS
{
    class BUS_KhachHang
    {
        DAO_KhachHang dKhachHang;
        public BUS_KhachHang()
        {
            dKhachHang = new DAO_KhachHang();
        }

        public void LayDSKH(DataGridView d)
        {
            d.DataSource = dKhachHang.LayDSKH();
        }

        public void TimTheoID(DataGridView dg, int ma)
        {
            dg.DataSource = dKhachHang.TimTheoID(ma);
        }

        public void TimTheoSDT(DataGridView dg, string sdt)
        {
            dg.DataSource = dKhachHang.TimTheoSDT(sdt);
        }

        public bool KiemTraSDT(string sdt)
        {
            var k = dKhachHang.KiemTraSDT(sdt);
            if (k != null)
            {
                return true;
            }
            else
                return false;
        }

        public bool ThemKhachHang(KhachHang k)
        {
            try
            {
                dKhachHang.ThemKhachHang(k);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public KhachHang LayKhachHangID(int ma)
        {
            KhachHang k = dKhachHang.LayKhachHangID(ma);
            return k;
        }

        public bool SuaKhachHang(KhachHang k)
        {
            return dKhachHang.SuaKhachHang(k);
        }

        public bool XoaKhachHang(int ma)
        {
            try
            {
                dKhachHang.XoaKhachHang(ma);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
