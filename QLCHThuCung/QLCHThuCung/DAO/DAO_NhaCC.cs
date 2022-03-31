using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHThuCung.DAO
{
    class DAO_NhaCC
    {
        QLCHThuCungDataContext db;
        public DAO_NhaCC()
        {
            db = new QLCHThuCungDataContext();
        }

        public dynamic getDSNCC()
        {
            var ds = db.NhaCungCaps.Select(s => new
            {
                s.NhaCungCapID,
                s.TenCongTy,
                s.SDT,
                s.Email,
                s.DiaChi
            }).ToList();

            return ds;
        }

        public NhaCungCap GetNCCByID(int idNCC)
        {
            NhaCungCap ncc = db.NhaCungCaps.FirstOrDefault(s => s.NhaCungCapID == idNCC);
            return ncc;
        }
    }
}
