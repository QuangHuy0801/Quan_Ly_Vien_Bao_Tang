using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormReportTrienLam : Form
    {
        public FormReportTrienLam()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (TUNGAY.Text  == "")

            {
                MessageBox.Show("Từ ngày bị trống!", "", MessageBoxButtons.OK);
                return;

            }
            if (DENNGAY.Text == "")

            {
                MessageBox.Show("Đến ngày bị trống!", "", MessageBoxButtons.OK);
                return;
            }

            if (DateTime.Parse(DENNGAY.Text.ToString()) < DateTime.Parse(TUNGAY.Text.ToString()))

            {
                MessageBox.Show("Thời gian sau phải lớn hơn thời gian trước!", "", MessageBoxButtons.OK);
                return;
            }
            XtraReportTrienLam rpt = new XtraReportTrienLam(DateTime.Parse(TUNGAY.Text.ToString()), DateTime.Parse(DENNGAY.Text.ToString()));
            rpt.sqlTrienLam.Connection.ConnectionString = Program.connstr;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }
    }
}
