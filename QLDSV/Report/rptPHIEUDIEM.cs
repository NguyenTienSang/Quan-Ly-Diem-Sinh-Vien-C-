using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class rptPHIEUDIEM : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPHIEUDIEM(String MaSV)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MaSV;
            this.sqlDataSource1.Fill();
        }

    }
}
