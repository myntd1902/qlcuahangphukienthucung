using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHThuCung.DAO;

namespace QLCHThuCung.BUS
{
    class BUS_LoaiUser
    {
        DAO_LoaiUser dLoaiUser;
        public BUS_LoaiUser()
        {
            dLoaiUser = new DAO_LoaiUser();
        }

        public void GetDSLoaiUser(ComboBox cb)
        {
            cb.DataSource = dLoaiUser.GetDSLoaiUser();
            cb.DisplayMember = "TenLoai";
            cb.ValueMember = "LoaiUserID";
        }
    }
}
