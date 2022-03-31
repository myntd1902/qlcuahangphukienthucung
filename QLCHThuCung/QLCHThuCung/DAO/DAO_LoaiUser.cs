using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHThuCung.DAO
{
    class DAO_LoaiUser
    {
        QLCHThuCungDataContext db;
        public DAO_LoaiUser()
        {
            db = new QLCHThuCungDataContext();
        }

        public dynamic GetDSLoaiUser()
        {
            var ds = db.LoaiUsers.Select(s => new
            {
                s.LoaiUserID,
                s.TenLoai
            }).ToList();
            return ds;
        }
    }
}
