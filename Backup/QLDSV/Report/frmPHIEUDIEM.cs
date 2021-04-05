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
using System.Data.SqlClient;

namespace QLDSV.Report
{
    public partial class frmPHIEUDIEM : DevExpress.XtraEditors.XtraForm
    {
        String MaSV;
        public frmPHIEUDIEM()
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

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            MaSV = cmbMaSV.SelectedValue.ToString().Trim();
            SV obj = GetTTSV(MaSV);
            txtHoTen.Text = obj.HOTEN;
        }

        private void frmPHIEUDIEM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.DS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

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

            MaSV = cmbMaSV.SelectedValue.ToString().Trim();
            SV obj = GetTTSV(MaSV);
            txtHoTen.Text = obj.HOTEN;

        }

        public class SV
        {
            public string HOTEN { get; set; }
            // public string LOP { get; set; }
        }

        private SV GetTTSV(string masv)
        {
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                using (SqlCommand command = new SqlCommand("sp_LAYHOTENSV", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MASV", SqlDbType.NChar, 12).Value = masv.Trim();
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new SV
                            {
                                HOTEN = (string)reader["HOTEN"],
                            };
                        }
                        return null;
                    }
                }
            }
        }


        private void cmbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MaSV = cmbMaSV.SelectedValue.ToString().Trim();
                SV obj = GetTTSV(MaSV);
                txtHoTen.Text = obj.HOTEN;
            }
            catch (Exception)
            {
                
            }
        }

     

        private void btnIn_Click(object sender, EventArgs e)
        {
            rptPHIEUDIEM report = new rptPHIEUDIEM(this.cmbMaSV.SelectedValue.ToString());
            report.txtTenLop.Text = this.cmbTenLop.Text;
            report.txtMaSV.Text = this.cmbMaSV.Text;
            report.txtTenSV.Text = this.txtHoTen.Text;

            report.lblAuthor.Text = "Người In Ấn : " + Program.mHoten;

            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}