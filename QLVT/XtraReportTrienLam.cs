using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT
{
    public partial class XtraReportTrienLam : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportTrienLam()
        {
            InitializeComponent();
        }
        public XtraReportTrienLam(DateTime tungay, DateTime dengay)
        {
            InitializeComponent();
            this.sqlTrienLam.Connection.ConnectionString = Program.connstr;
            this.sqlTrienLam.Queries[0].Parameters[0].Value = tungay;
            this.sqlTrienLam.Queries[0].Parameters[1].Value = dengay;
            this.sqlTrienLam.Fill();
        }

    }
}
