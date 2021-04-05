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
    public partial class frmINDSSV : DevExpress.XtraEditors.XtraForm
    {
        public frmINDSSV()
        {
            InitializeComponent();
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
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            }


        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmINDSSV_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            // biding data từ data table vào combobox chi nhánh
            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
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

        }

        

        private void txtMaLop_EditValueChanged(object sender, EventArgs e)
        {

             txtMaLop.Text = cmbTenLop.Text;
        }

        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaLop.Text = cmbTenLop.SelectedValue.ToString().Trim();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMayIn_Click(object sender, EventArgs e)
        {
            string mlop = cmbTenLop.SelectedValue.ToString();
            rptINDSSV rpt = new rptINDSSV(mlop);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnManHinh_Click(object sender, EventArgs e)
        {
            this.sp_InDSSVTableAdapter.Fill(DS.sp_InDSSV, cmbTenLop.SelectedValue.ToString());
            if (sp_InDSSVBindingSource.Count == 0)
            {
                MessageBox.Show("Lớp không có sinh viên. Không có dữ liệu để in", "Thông báo !", MessageBoxButtons.OK);
                btnMayIn.Enabled = false;
            }
            else
            {
                btnMayIn.Enabled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenLop_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}