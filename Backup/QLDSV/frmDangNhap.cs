using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = 0;
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
            {
                Program.servername = cmbKhoa.SelectedValue.ToString();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn thoát không ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {


            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được trống", "Lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }

            else if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }

            Program.mlogin = txtLogin.Text;//Gán tài khoản vừa nhập cho biền mlogin
            Program.mpassword = txtPass.Text;//Gán mật khẩu vừa nhập cho biến mpassword
            //Nếu kết nối == 0 thì kết thúc
            if (Program.KetNoi() == 0) return;//Nếu kết nối không được sẽ return
            Program.mKhoa = cmbKhoa.SelectedIndex;// 0: CNTT ,  1: VT, 2: HỌC PHÍ
            Program.bds_dspm = bdsDSPM;
            Program.mloginDN = Program.mlogin;//Gan lại mlogin cho mloginDN
            Program.mpasswordDN = Program.mpassword;//Gán lại mpassword cho mpasswordDN
                                                    //MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OK);



            String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
            Program.MyReader = Program.ExecSqlDataReader(strLenh);
            if (Program.MyReader == null)
            {
                return;
            }

            Program.MyReader.Read();

            
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\nBạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }

            Program.username = Program.MyReader.GetString(0);     // Lay user name
            Program.mHoten = Program.MyReader.GetString(1);
            Program.mGroup = Program.MyReader.GetString(2);


            Program.MyReader.Close();
            Program.conn.Close();

            // truy cập vào frm main
            Program.frmMain = new frmMain();

            // hiện thông tin tài khoản
            Program.frmMain.lblMAGV.Text = "mã giảng viên : " + Program.username.Trim();
            Program.frmMain.lblHOTEN.Text = "họ và tên : " + Program.mHoten.Trim();
            Program.frmMain.lblNHOM.Text = "nhóm : " + Program.mGroup;
            Program.frmMain.Show();
            this.Visible = false;
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

     

        private void frmDangNhap_VisibleChanged(object sender, EventArgs e)
        {
            Program.bds_dspm.RemoveFilter();
            cmbKhoa_SelectedIndexChanged(sender, e);
        }
    }
}
