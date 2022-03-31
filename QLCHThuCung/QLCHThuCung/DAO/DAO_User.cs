using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHThuCung.DAO
{
    class DAO_User
    {
        QLCHThuCungDataContext db;
        public DAO_User()
        {
            db = new QLCHThuCungDataContext();
        }

        public User GetUserByID(int uID)
        {
            User u = db.Users.FirstOrDefault(s => s.UserID == uID);
            return u;
        }
        public dynamic FindUserByID(int uID)
        {
            var u = db.Users.Where(s => s.UserID == uID).ToList();
            return u;
        }

        public User GetUserByTK(string tk)
        {
            User u = db.Users.FirstOrDefault(s => s.TaiKhoan.Equals(tk));
            return u;
        }

        public dynamic GetDSUsers()
        {
            var ds = db.Users.Select(s => new
            {
                s.UserID,
                s.HoTen,
                s.GioiTinh,
                s.SDT,
                s.NgayVaoLam,
                s.LoaiUserID,
                s.TrangThai
            }).ToList();
            return ds;
        }

        public dynamic FindUserBySDT(string sdt)
        {
            var u = db.Users.Where(s => s.SDT.Contains(sdt)).ToList();
            return u;
        }

        public dynamic FindUserByLoaiUserID(int id)
        {
            var ds = db.Users.Where(s => s.LoaiUserID == id).Select(s => new
            {
                s.UserID,
                s.HoTen,
                s.GioiTinh,
                s.SDT,
                s.NgayVaoLam,
                s.LoaiUserID,
                s.TrangThai
            }).ToList(); ;
            return ds;
        }
        public dynamic FindUserByCMND(string cmnd)
        {
            var u = db.Users.Where(s => s.CMND.Contains(cmnd)).ToList();
            return u;
        }
        public dynamic FindUserByTenTK(string tenTK)
        {
            var u = db.Users.Where(s => s.TaiKhoan.Contains(tenTK)).ToList();
            return u;
        }

        public bool UpDateUser(User uNew)
        {
            User u;
            u = db.Users.FirstOrDefault(s => s.UserID == uNew.UserID);
            if (u != null)
            {
                u.SDT = uNew.SDT;
                u.TrangThai = uNew.TrangThai;
                u.HoTen = uNew.HoTen;
                u.GioiTinh = uNew.GioiTinh;
                u.LoaiUserID = uNew.LoaiUserID;
                u.NgaySinh = uNew.NgaySinh;
                u.NgayVaoLam = uNew.NgayVaoLam;
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public void DeleteUser(int idU)
        {
            db.Users.DeleteOnSubmit(db.Users.FirstOrDefault(s => s.UserID == idU));
            db.SubmitChanges();
        }

        public void AddUser(User u)
        {
            db.Users.InsertOnSubmit(u);
            db.SubmitChanges();
        }

    }
}
