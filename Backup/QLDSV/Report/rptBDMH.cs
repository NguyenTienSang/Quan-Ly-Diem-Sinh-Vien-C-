using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class rptBDMH : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBDMH(String TenLop, String TenMH, int LanThi)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = TenLop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = TenMH;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = LanThi;
            this.sqlDataSource1.Fill();
        }

    }
}
