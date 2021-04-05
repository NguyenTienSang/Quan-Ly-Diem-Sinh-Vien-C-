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
using System.Data.SqlClient;

namespace QLDSV
{
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

      



        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            String tendangnhap = txtTaiKhoan.Text;
            String matkhau = txtMatKhau.Text;
            String reMakhau = txtMatKhau2.Text;
            if (matkhau != reMakhau)
            {
                MessageBox.Show("Mật Khẩu nhập lại không khớp");
                return;
            }
            if (tendangnhap.Trim().Length == 0 || matkhau.Trim().Length == 0)
            {
                MessageBox.Show("Không thể tạo tài khoản khi dữ có dữ liệu rỗng");
                return;
            }
            //MessageBox.Show(tendangnhap+"'"+ matkhau+"'"+cmbNhom.Text);
            //MessageBox.Show(cmbNhom.Text);
            try
            {
               

                string cmd = $"exec dbo.SP_TAOLOGIN '{tendangnhap.Trim()}','{matkhau.Trim()}','{cmbMa.Text.Trim()}','{cmbNhom.Text}'";
                Program.ExecSqlDataReader(cmd);
                if(Program.MyReader != null)
                {

                    MessageBox.Show("Tạo tài khoản thành công");
                    this.v_LAYDANHSACHGIANGVIENTableAdapter.Fill(this.DS.V_LAYDANHSACHGIANGVIEN);
                    return;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Tạo Login : " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_LAYDANHSACHGIANGVIEN' table. You can move, or remove it, as needed.
            this.v_LAYDANHSACHGIANGVIENTableAdapter.Fill(this.DS.V_LAYDANHSACHGIANGVIEN);
            if (String.Compare(Program.mGroup, "PGV") == 0)
            {
                cmbNhom.Items.Add("PGV");
                cmbNhom.Items.Add("KHOA");
                cmbNhom.Items.Add("USER");
            }
            else if (String.Compare(Program.mGroup, "PKTOAN") == 0)
            {
                cmbNhom.Items.Add("PKTOAN");
            }
            else if (String.Compare(Program.mGroup, "KHOA") == 0)
            {
                cmbNhom.Items.Add("KHOA");
                cmbNhom.Items.Add("USER");
            }
            cmbNhom.SelectedIndex = 0;

        }
    }
}