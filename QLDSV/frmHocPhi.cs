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
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        List<int> sohocky = new List<int>();
        List<string> sonienkhoa = new List<string>();
        String masv = "";
        public frmHocPhi()
        {
            sohocky.Add(1);
            sohocky.Add(2);
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
           
            //cmbHocKy.DataSource = sohocky;
            //cmbHocKy.SelectedIndex = 0;
            //String sDate = DateTime.Now.ToString();
            //DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            //string currentyear = datevalue.Year.ToString();
            //int currentvalue = 15;
            //int oldyear = int.Parse(currentyear) - currentvalue;
            //string tmp = "";
            //for (int i = 0; i < currentvalue + 1; i++)
            //{
            //    tmp = oldyear + "-" + (oldyear + 1);
            //    oldyear = oldyear + 1;
            //    sonienkhoa.Add(tmp);
            //}
            //this.txtNienKhoa.Text = sonienkhoa.ToString();
            //this.txtNienKhoa.Text = currentvalue.ToString();


        }

       

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

      

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mASVLabel_Click(object sender, EventArgs e)
        {

        }

        

        private void btnTim_Click(object sender, EventArgs e)
        {
            masv = txtMaSV.Text.Trim();
            if (masv.Length < 4)
            {
                MessageBox.Show("Mã số sinh viên phải nhiều hơn 4 kí tự", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (Program.KetNoi() == 0) return;

            String lenh = "SELECT HO,TEN ,MALOP FROM [dbo].SINHVIEN WHERE MASV ='" + this.masv + "' and NGHIHOC = 'false'";
            Program.MyReader = Program.ExecSqlDataReader(lenh);
            Program.MyReader.Read();
            this.txtHoTen.Text = Program.MyReader.GetString(0) + ' ' + Program.MyReader.GetString(1);
            this.txtMaLop.Text = Program.MyReader.GetString(2);
            
            Program.MyReader.Close();
            string strLenh = "EXEC [dbo].[SP_THEMHOCPHICHOSV] '" + this.masv + "' ";
            Program.MyReader = Program.ExecSqlDataReader(strLenh);
            Program.MyReader.Read();
            this.txtNienKhoa.Text = Program.MyReader.GetString(0);
            this.txtHocKy.Text = Program.MyReader.GetInt32(1).ToString();
            this.txtHocPhi.Text = Program.MyReader.GetInt32(2).ToString();
            this.txtSoTienDaDong.Text = Program.MyReader.GetInt32(3).ToString();
            Program.MyReader.Close();
            try
            {
                this.sP_TIMSVDHPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_TIMSVDHPTableAdapter.Fill(this.DS.SP_TIMSVDHP, masv);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void sOTIENDADONGTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}