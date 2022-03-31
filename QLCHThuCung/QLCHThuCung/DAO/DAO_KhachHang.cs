using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHThuCung.DAO
{
    class DAO_KhachHang
    {
        QLCHThuCungDataContext db;
        public DAO_KhachHang()
        {
            db = new QLCHThuCungDataContext();
        }

        public dynamic LayDSKH()
        {
            var ds = db.KhachHangs.Select(s => new
            {
                s.KhachHangID,
                s.HoTen,
                s.NgaySinh,
                s.GioiTinh,
                s.DiaChi,
                s.SDT
            }).ToList();
            return ds;
        }

        public dynamic TimTheoID(int ma)
        {
            var ds = db.KhachHangs.Where(s => s.KhachHangID == ma).Select(s => new
            {
                s.KhachHangID,
                s.HoTen,
                s.NgaySinh,
                s.GioiTinh,
                s.DiaChi,
                s.SDT
            }).ToList();
            return ds;
        }

        public dynamic TimTheoSDT(string sdt)
        {
            var ds = db.KhachHangs.Where(s => s.SDT == sdt).Select(s => new
            {
                s.KhachHangID,
                s.HoTen,
                s.NgaySinh,
                s.GioiTinh,
                s.DiaChi,
                s.SDT
            }).ToList();
            return ds;
        }

        public KhachHang KiemTraSDT(string sdt)
        {
            KhachHang k = db.KhachHangs.FirstOrDefault(s => s.SDT == sdt);
            return k;
        }

        public void ThemKhachHang(KhachHang k)
        {
            db.KhachHangs.InsertOnSubmit(k);
            db.SubmitChanges();
        }

        public KhachHang LayKhachHangID(int ma)
        {
            KhachHang k = db.KhachHangs.FirstOrDefault(s => s.KhachHangID == ma);
            return k;
        }

        public bool SuaKhachHang(KhachHang k)
        {
            KhachHang u;
            u = db.KhachHangs.FirstOrDefault(s => s.KhachHangID == k.KhachHangID);
            if (u != null)
            {
                
                u.KhachHangID = k.KhachHangID;
                u.HoTen = k.HoTen;
                u.NgaySinh = k.NgaySinh;
                u.GioiTinh = k.GioiTinh;
                u.DiaChi = k.DiaChi;
                u.SDT = k.SDT;
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public void XoaKhachHang(int ma)
        {
            db.KhachHangs.DeleteOnSubmit(db.KhachHangs.FirstOrDefault(s => s.KhachHangID == ma));
            db.SubmitChanges();
        }
    }
}
