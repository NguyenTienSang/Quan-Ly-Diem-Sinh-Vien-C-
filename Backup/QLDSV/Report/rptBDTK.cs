using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class rptBDTK : DevExpress.XtraReports.UI.XtraReport
    {
        private string mlop;

        public rptBDTK(string TenLop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = TenLop;
            this.sqlDataSource1.Fill();
        }


    }
}
