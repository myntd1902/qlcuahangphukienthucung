using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHThuCung.DAO;

namespace QLCHThuCung.BUS
{
    class BUS_LoaiHangHoa
    {
        DAO_LoaiHH dLoaiHH;

        public BUS_LoaiHangHoa()
        {
             dLoaiHH = new DAO_LoaiHH();
        }
        
        public void GetDSLoaiHH(ComboBox cb)
        {
            cb.DataSource = dLoaiHH.GetDSLoaiHH();
            cb.DisplayMember = "TenLoai";
            cb.ValueMember = "LoaiHangHoaID";
        }
    }
}
