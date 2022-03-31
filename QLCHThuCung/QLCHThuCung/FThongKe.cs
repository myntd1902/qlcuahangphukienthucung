using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using QLCHThuCung.BUS;

namespace QLCHThuCung
{
    public partial class FThongKe : Form
    {
        BUS_HangHoa bHangHoa;
        public int idQL;
        public FThongKe()
        {
            InitializeComponent();
            bHangHoa = new BUS_HangHoa();
        }

        private void FThongKe_Load(object sender, EventArgs e)
        {
            dtpNgayBD.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpNgayKT.Value = DateTime.Now;
        }

        private void btDoanhThu_Click(object sender, EventArgs e)
        {
            CRDoanhThu crDT = new CRDoanhThu();

            FDoanhThu fDT = new FDoanhThu();
            crDT.SetDataSource(bHangHoa.TKDoanhThu(dtpNgayBD.Value, dtpNgayKT.Value));

            ParameterValues ngayBD = new ParameterValues();
            ngayBD.AddValue( dtpNgayBD.Value);
            ParameterValues ngayKT = new ParameterValues();
            ngayKT.AddValue(dtpNgayKT.Value);

            crDT.DataDefinition.ParameterFields["ngayBD"].ApplyCurrentValues(ngayBD);
            crDT.DataDefinition.ParameterFields["ngayKT"].ApplyCurrentValues(ngayKT);

            fDT.crDoanhThu.ReportSource = crDT;
            fDT.Show();
        }

        private void btChiPhi_Click(object sender, EventArgs e)
        {
            CRChiPhi crCP = new CRChiPhi();

            FChiPhi fCP = new FChiPhi();
            crCP.SetDataSource(bHangHoa.TKChiPhi());

            fCP.crChiPhi.ReportSource = crCP;
            fCP.Show();
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            if(dtpNgayBD.Value >= dtpNgayKT.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!!!");
                dtpNgayBD.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            }
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayBD.Value >= dtpNgayKT.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!!!");
                dtpNgayBD.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            fQuanLy fQL = new fQuanLy();
            fQL.idQL = this.idQL;

            this.Close();
            fQL.Show();
        }
    }
}
