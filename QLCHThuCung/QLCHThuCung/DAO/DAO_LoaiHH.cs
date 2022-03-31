using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHThuCung.DAO
{
    class DAO_LoaiHH
    {
        QLCHThuCungDataContext db;
        public DAO_LoaiHH()
        {
            db = new QLCHThuCungDataContext();
        }
        public dynamic GetDSLoaiHH()
        {
            var ds = db.LoaiHangHoas.Select(s => new
            {
                s.LoaiHangHoaID,
                s.TenLoai
            }).ToList();

            return ds;
        }

    }
}
