using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHThuCung.DAO;


namespace QLCHThuCung.BUS
{

    class BUS_HangHoa
    {
        DAO_HangHoa dHangHoa;

        public BUS_HangHoa(){
            dHangHoa = new DAO_HangHoa();
        }

        public void GetDSHangHoa(DataGridView dg)
        {
            dg.DataSource = dHangHoa.GetDSHangHoa();

        }

        public HangHoa GetHangHoaByID(int idHH)
        {
            HangHoa hh = dHangHoa.GetHangHoaByID(idHH);
            return hh;
        }

        public void FindHangHoaByID(DataGridView dg ,int idHH)
        {
            dg.DataSource = dHangHoa.FindHangHoaByID(idHH);
        }

        public void FindHangHoaByIDLoaiHH(DataGridView dg, int idLoaiHH)
        {
            dg.DataSource = dHangHoa.FindHangHoaByIDLoaiHH(idLoaiHH);
        }
        public void FindHangHoaByIDNCC(DataGridView dg, int idNCC)
        {
            dg.DataSource = dHangHoa.FindHangHoaByIDNCC(idNCC);
        }

        public bool AddHoangHoa(HangHoa hh)
        {
            try {
                dHangHoa.AddHangHoa(hh);
                return true;
             }
            catch(SqlException ex2)
            {
                return false;
            }
        }

        public bool DeleteHangHoa(int idHH)
        {
            try
            {
                dHangHoa.DeleteHangHoa(idHH);
                return true;
            }
            catch (SqlException ex2)
            {
                return false;
            }
        }

        public bool UpdateHangHoa(HangHoa hh)
        {
            return dHangHoa.UpdateHangHoa(hh);
        }

        public dynamic TKDoanhThu(DateTime ngayBD, DateTime ngayKT)
        {
            return dHangHoa.TkDoanhThu(ngayBD, ngayKT);
        }
        public dynamic TKChiPhi()
        {
            return dHangHoa.TkChiPhi();
        }
    }
}
