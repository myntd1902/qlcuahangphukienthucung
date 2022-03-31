using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHThuCung.DAO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace QLCHThuCung.BUS
{

    class BUS_User
    {
        DAO_User dUser;

        public BUS_User()
        {
            dUser = new DAO_User();
        }

        public int Login(string tk, string mk)
        {
            // -1 sai mật khẩu, 0 sai tên tk, -2 là tk ko hoạt động, 
            User u = dUser.GetUserByTK(tk);
            if (u != null)
            {
                if (u.MatKhau.Equals(mk))
                {
                    if (u.TrangThai)
                    {
                        return u.UserID;
                    }
                    else
                        return -2;
                }
                else
                    return -1;
            }

            return 0;
        }

        public User GetUserByID(int id)
        {
            User u = dUser.GetUserByID(id);
            return u;
        }

        public void GetDSUsers(DataGridView dg)
        {
            dg.DataSource = dUser.GetDSUsers();
        }

        public void FindUserByID(DataGridView dg, int id)
        {
            dg.DataSource = dUser.FindUserByID(id);
        }
        public void FindUserByLoaiUserID(DataGridView dg, int loaiUserID)
        {
            dg.DataSource = dUser.FindUserByLoaiUserID(loaiUserID);
        }
        public void FindUserByCMND(DataGridView dg, string cmnd)
        {
            dg.DataSource = dUser.FindUserByCMND(cmnd);
        }
        public bool FindUserByCMND(string cmnd)
        {
            var u = dUser.FindUserByCMND(cmnd);
            if (u != null)
            {
                return true;
            }
            else
                return false;
        }
        public void FindUserBySDT(DataGridView dg, string sdt)
        {
            dg.DataSource = dUser.FindUserBySDT(sdt);
        }
        public bool FindUserBySDT(string sdt)
        {
            var u = dUser.FindUserBySDT(sdt);
            if (u != null)
            {
                return true;
            }
            else
                return false;
        }

        public void FindUserByTenTK(DataGridView dg, string tenTK)
        {
            dg.DataSource = dUser.FindUserByTenTK(tenTK);
        }
        public bool FindUserByTenTK(string tenTK)
        {
            User u = dUser.FindUserByTenTK(tenTK);
            if (u != null)
            {
                return true;
            }
            else
                return false;
        }
        public bool UpdateUser(User uNew)
        {
            return dUser.UpDateUser(uNew);
        }
        public bool DeleteUser(int idU)
        {
            try
            {
                dUser.DeleteUser(idU);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool AddUser(User u)
        {
            try
            {
                dUser.AddUser(u);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
