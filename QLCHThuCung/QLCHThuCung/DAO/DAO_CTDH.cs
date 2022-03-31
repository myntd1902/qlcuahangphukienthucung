using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHThuCung.DAO
{
    class DAO_CTDH
    {
        QLCHThuCungDataContext db;
        public DAO_CTDH()
        {
            db = new QLCHThuCungDataContext();
        }
    }
}
