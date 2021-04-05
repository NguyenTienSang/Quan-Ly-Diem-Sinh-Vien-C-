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

namespace QLDSV
{
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        String nLogin = "";
        String nPass = "";
        String nUserName = "";
        String nRole = "";
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Login name", "Thông báo !", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            else if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo !", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }
            else if (txtMAGV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn giảng viên", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            else
            {
                nLogin = txtLogin.Text.Trim();
                nPass = txtPass.Text.Trim();
                nRole = cmbRole.Text.Trim();

                try
                {
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    String str_sp = "dbo.SP_TAOLOGIN";
                    Program.Sqlcmd = Program.conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_sp;
                    Program.Sqlcmd.Parameters.Add("@LGNAME", SqlDbType.NChar).Value = nLogin;
                    Program.Sqlcmd.Parameters.Add("@PASS", SqlDbType.NChar).Value = nPass;
                    Program.Sqlcmd.Parameters.Add("@USERNAME", SqlDbType.NChar).Value = nUserName;
                    Program.Sqlcmd.Parameters.Add("@ROLE", SqlDbType.NChar).Value = nRole;
                    Program.Sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo Login thành công !", "Thông báo !", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("server principal"))
                    {
                        MessageBox.Show("Login name bị trùng. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else if (ex.Message.Contains("User, group, or role"))
                    {
                        MessageBox.Show("Giảng viên này đã được tạo login. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn hủy thao tác đăng ký tài khoản?",
                     "Xác thực", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }
}