using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHThuCung.DAO;

namespace QLCHThuCung.BUS
{
    class BUS_NhaCungCap
    {
        DAO_NhaCC dNCC;

        public BUS_NhaCungCap()
        {
            dNCC = new DAO_NhaCC();
        }

        public void cbNCC(ComboBox cb)
        {
            cb.DataSource = dNCC.getDSNCC();
            cb.ValueMember = "NhaCungCapID";
            cb.DisplayMember = "TenCongTy";
        }
        public NhaCungCap GetNCCByID(int idNCC)
        {
            return dNCC.GetNCCByID(idNCC);
        }

    }
}
