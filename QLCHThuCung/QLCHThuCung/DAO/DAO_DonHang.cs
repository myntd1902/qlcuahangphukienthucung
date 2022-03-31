using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHThuCung.DAO
{
    class DAO_DonHang
    {
        QLCHThuCungDataContext db;
        public DAO_DonHang()
        {
            db = new QLCHThuCungDataContext();
        }

        public dynamic LayDSDH(int maKH)
        {
            var ds = db.DonHangs.Where(s => s.KhachHangID == maKH)
                .Select(s => new
            {
                s.DonHangID,
                s.NgayTao,
                s.User.HoTen
            }).ToList();
            return ds;
        }

        public dynamic LayCTDH(int maDH)
        {
            var ds = db.ChiTietDonHangs.Where(s => s.DonHangID == maDH)
                .Select(s => new
                {
                    s.HangHoa.TenHangHoa,
                    s.SoLuong,
                    s.DonGia,
                    s.GiamGia
                }).ToList();
            return ds;
        }
    }
}
