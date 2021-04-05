using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class frmBDMH : DevExpress.XtraEditors.XtraForm
    {
        public frmBDMH()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            rptBDMH report = new rptBDMH(this.cmbTenLop.SelectedValue.ToString(), this.cmbTenMonHoc.SelectedValue.ToString(), Int32.Parse(this.cmbLan.SelectedItem.ToString()));
            report.cmbTenLop.Text = this.cmbTenLop.Text;
            report.label_TenLop.Text = this.cmbTenMonHoc.Text;
            report.lblLanThi.Text = this.cmbLan.SelectedItem.ToString();
            report.lblAuthor.Text = "Người In Ấn : " + Program.mHoten;

            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
            {
                if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                    return; // Hệ thống chưa chọn đã chạy => Kết thúc
                Program.servername = cmbKhoa.SelectedValue.ToString();
            }
            if (cmbKhoa.SelectedIndex != Program.mKhoa)
            {
                Program.mlogin = Program.remotelogin;
                Program.mpassword = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.mpassword = Program.mpasswordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
            }
        }

      
        private void frmBDMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
            this.DS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);


            // biding data từ data table vào combobox chi nhánh
            cmbKhoa.DataSource = Program.bds_dspm;// sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";

            // lệnh này quan trọng... phải bỏ vào. ==> để cho combo box chạy đúng.
            cmbKhoa.SelectedIndex = 0;
            //maKhoa = ((DataRowView)bdsLOP[0])["MAKH"].ToString();//set  mặc định txtMaKhoa
            // nếu login vào là khoa cntt, thì combox sẽ hiện khoa cntt
            // nếu login vào là khoa vt, thì combox sẽ hiện khoa vt
            cmbKhoa.SelectedIndex = Program.mKhoa;
            //Nhóm quyền PGV

            if (Program.mGroup == "KHOA")
                cmbKhoa.Enabled = false;

            if (Program.mGroup == "PGV")
            {
                Program.bds_dspm.Filter = "TENCN <> 'PHÒNG KẾ TOÁN'";
            }
            txtMaLop.Text = cmbTenLop.SelectedValue.ToString().Trim();
            txtMaMonHoc.Text = cmbTenMonHoc.SelectedValue.ToString().Trim();
            cmbLan.SelectedIndex = 0;
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtMaLop.Text = this.cmbTenLop.SelectedValue.ToString();
            }
            catch { }
        }

        private void cmbTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtMaMonHoc.Text = this.cmbTenMonHoc.SelectedValue.ToString();
            }
            catch { }
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }
    }
}