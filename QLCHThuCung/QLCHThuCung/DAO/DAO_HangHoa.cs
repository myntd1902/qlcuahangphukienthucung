using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHThuCung.DAO
{
    class DAO_HangHoa
    {
        QLCHThuCungDataContext db;
        public DAO_HangHoa()
        {
            db = new QLCHThuCungDataContext();
        }

        public dynamic GetDSHangHoa()
        {
            var ds = db.HangHoas.Select(s => new
            {
                s.HangHoaID,
                s.TenHangHoa,
                s.SoLuongTK,
                s.ThuongHieu,
                s.TinhTrang,
                s.LoaiHangHoaID,
                s.NhaCungCapID
            }).ToList();
            return ds;
        }

        public HangHoa GetHangHoaByID(int idHH)
        {
            HangHoa hh = db.HangHoas.FirstOrDefault(s => s.HangHoaID == idHH);
            return hh;
        }

        public dynamic FindHangHoaByID(int idHH)
        {
            var hh = db.HangHoas.Where(s => s.HangHoaID == idHH).Select(s => new
            {
                s.HangHoaID,
                s.TenHangHoa,
                s.SoLuongTK,
                s.ThuongHieu,
                s.TinhTrang,
                s.LoaiHangHoaID,
                s.NhaCungCapID
            }).ToList();
            return hh;
        }

        public dynamic FindHangHoaByIDLoaiHH(int idLoaHH)
        {
            var ds = db.HangHoas.Where(s => s.LoaiHangHoaID == idLoaHH).Select(s => new
            {
                s.HangHoaID,
                s.TenHangHoa,
                s.SoLuongTK,
                s.ThuongHieu,
                s.TinhTrang,
                s.LoaiHangHoaID,
                s.NhaCungCapID
            }).ToList();
            return ds;
        }

        public dynamic FindHangHoaByIDNCC(int idNCC)
        {
            var ds = db.HangHoas.Where(s => s.LoaiHangHoaID == idNCC).Select(s => new
            {
                s.HangHoaID,
                s.TenHangHoa,
                s.SoLuongTK,
                s.ThuongHieu,
                s.TinhTrang,
                s.LoaiHangHoaID,
                s.NhaCungCapID
            }).ToList();
            return ds;
        }

        public void AddHangHoa(HangHoa hh)
        {
            db.HangHoas.InsertOnSubmit(hh);
            db.SubmitChanges();
        }

        public void DeleteHangHoa(int idHH)
        {
            db.HangHoas.DeleteOnSubmit(db.HangHoas.FirstOrDefault(h => h.HangHoaID == idHH));
            db.SubmitChanges();
        }

        public bool UpdateHangHoa(HangHoa hhnew)
        {
            try
            {
                HangHoa hh;
                hh = db.HangHoas.FirstOrDefault(h => h.HangHoaID == hhnew.HangHoaID);
                hh.TenHangHoa = hhnew.TenHangHoa;
                hh.SoLuongTK = hhnew.SoLuongTK;
                hh.ThuongHieu = hhnew.ThuongHieu;
                hh.TinhTrang = hhnew.TinhTrang;
                hh.GiaNiemYet = hhnew.GiaNiemYet;
                hh.GiaNhap = hhnew.GiaNhap;
                hh.LoaiHangHoaID = hhnew.LoaiHangHoaID;
                hh.NhaCungCapID = hhnew.NhaCungCapID;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public dynamic TkDoanhThu(DateTime ngayBD, DateTime ngayKT)
        {
            var result = db.RP_DoanhThuTheoNgay(ngayBD, ngayKT).ToList();
            return result;
        }
        public dynamic TkChiPhi()
        {
            var result = db.RP_TongChiPhi().ToList();
            return result;
        }
    }
}
