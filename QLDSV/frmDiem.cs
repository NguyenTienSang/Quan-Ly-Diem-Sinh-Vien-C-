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
    public partial class frmDiem : DevExpress.XtraEditors.XtraForm
    {
        List<int> check = new List<int>();
        List<int> soLanThi = new List<int>();
        int lanthi;
        private bool thaydoi;

        public frmDiem()
        {
            soLanThi.Add(1);
            soLanThi.Add(2);
            InitializeComponent();
        }

    

        private void frmDiem_Load(object sender, EventArgs e)
        {
            
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "KHOA")
            {
                cmbKhoa.Enabled = false;
            }
            else
            {
                cmbKhoa.Enabled = true;
            }

            DS.EnforceConstraints = false;//
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            btnGhi.Enabled = btnRefresh.Enabled = false;

            cmbLanThi.SelectedValue = 1;
            cmbLanThi.DataSource = soLanThi;
            txtLop.Text = cmbLop.SelectedValue.ToString().Trim();
            txtMonHoc.Text = cmbMonHoc.SelectedValue.ToString().Trim();
            sp_DANHSACHNHAPDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            if (Program.mGroup == "KHOA")
                cmbKhoa.Enabled = false;

            if (Program.mGroup == "PGV")
            {
                Program.bds_dspm.Filter = "TENCN <> 'PHÒNG KẾ TOÁN'";
            }
        }

       

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

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
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

                this.sp_DANHSACHNHAPDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            }
        }
        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtLop.Text = cmbLop.SelectedValue.ToString().Trim();
            }
            catch (Exception) { }
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMonHoc.Text = cmbMonHoc.SelectedValue.ToString().Trim();
            }
            catch (Exception) { }
        }

       


        private void btnBatDau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtLop.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Lớp", "Thông báo !", MessageBoxButtons.OK);
            }
            else if (txtMonHoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Môn học", "Thông báo !", MessageBoxButtons.OK);
            }
            else
            {
                cmbKhoa.Enabled = false;
                sp_DANHSACHNHAPDIEMGridControl.Visible = true;
                btnGhi.Enabled = true;
                btnThoat.Enabled = true;
                btnBatDau.Enabled = false;
                //edit();
                this.check = new List<int>();
                lanthi = int.Parse(cmbLanThi.SelectedValue.ToString());
                MessageBox.Show("Mã lớp: " + txtLop.Text.Trim() + ", Mã môn học: " + txtMonHoc.Text.Trim() + ", Lần thi: " + lanthi,
                                                "Xác nhận", MessageBoxButtons.OK);

                SqlConnection sqlConnection2 = new SqlConnection(Program.connstr);
                SqlCommand sqlCommand2 = sqlConnection2.CreateCommand();
                this.sp_DANHSACHNHAPDIEMTableAdapter.Connection = sqlConnection2;
                sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand2.CommandText = "SP_KIEMTRADIEMTHEOLAN";
                sqlCommand2.Parameters.Add(new SqlParameter("@MALOP", txtLop.Text));
                sqlCommand2.Parameters.Add(new SqlParameter("@MAMH", txtMonHoc.Text));
                sqlCommand2.Parameters.Add(new SqlParameter("@LAN", 1));
                SqlParameter sqlParameter2 = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
                sqlParameter2.Direction = System.Data.ParameterDirection.ReturnValue;
                sqlCommand2.Parameters.Add(sqlParameter2);
                sqlConnection2.Open();
                sqlCommand2.ExecuteNonQuery();
                int result = (int)sqlCommand2.Parameters["@return"].Value;
                Console.WriteLine(result);
                sqlConnection2.Close();
                if (result == 1)//Chưa thi lần nào
                {

                    if (lanthi == 2)//Chưa thi lần nào mà combobox là lần 2 thì báo lỗi
                    {
                        beginForm();
                        MessageBox.Show("Lớp này chưa thi môn này lần 1");

                        return;//Rrturn về
                    }
                }
                else//Đã thi rồi
                {
                    SqlConnection sqlConnection3 = new SqlConnection(Program.connstr);
                    SqlCommand sqlCommand3 = sqlConnection3.CreateCommand();
                    sqlCommand3.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand3.CommandText = "SP_KIEMTRADIEMTHEOLAN";
                    sqlCommand3.Parameters.Add(new SqlParameter("@MALOP", txtLop.Text));
                    sqlCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@MAMH", txtMonHoc.Text));
                    sqlCommand3.Parameters.Add(new SqlParameter("@LAN", 2));
                    SqlParameter sqlParameter3 = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
                    sqlParameter3.Direction = System.Data.ParameterDirection.ReturnValue;
                    sqlCommand3.Parameters.Add(sqlParameter3);
                    sqlConnection3.Open();
                    sqlCommand3.ExecuteNonQuery();
                    int result3 = (int)sqlCommand3.Parameters["@return"].Value;

                    if (lanthi == 1)//Thi lần 1
                    {
                        if (result3 == 2)
                        {
                            beginForm();
                            MessageBox.Show("Đã có điểm lần 2 không được phép sửa lần 1 nữa");
                            return;
                        }
                        this.sp_DANHSACHNHAPDIEMTableAdapter.Fill(this.DS.sp_DANHSACHNHAPDIEM, txtLop.Text, txtMonHoc.Text, (short)lanthi);
                        MessageBox.Show("Nhập Lại lần 1");
                        thaydoi = true;
                        return;
                    }
                    if (lanthi == 2)//Thi lần 2
                    {
                        if (result3 == 2)
                        {
                            sqlConnection3.Close();
                            //this.sp_DANHSACHNHAPDIEMTableAdapter.ClearBeforeFill();
                            this.sp_DANHSACHNHAPDIEMTableAdapter.Fill(this.DS.sp_DANHSACHNHAPDIEM, txtLop.Text, txtMonHoc.Text, (short)lanthi);
                            MessageBox.Show("Nhập lại lần 2");
                            thaydoi = true;
                            return;
                        }
                    }
                }

                try
                {
                    String lenh = "SELECT MASV FROM SINHVIEN WHERE MALOP ='" + txtLop.Text + "'AND NGHIHOC = 0";
                    SqlDataReader kts = Program.ExecSqlDataReader(lenh);

                    int k = 0;
                    while (kts.Read())  //đọc từng dòng
                    {
                        SqlConnection sqlConnection = new SqlConnection(Program.connstr);
                        SqlCommand sqlCommand = sqlConnection.CreateCommand();
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandText = "sp_THEMDSSVNHAPDIEM";
                        sqlCommand.Parameters.Add(new SqlParameter("@MASV", kts.GetString(0)));
                        sqlCommand.Parameters.Add(new SqlParameter("@MAMH", txtMonHoc.Text));
                        sqlCommand.Parameters.Add(new SqlParameter("@LAN", lanthi));
                        SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
                        sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
                        sqlCommand.Parameters.Add(sqlParameter);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        k++;
                        sqlConnection.Close();
                    }
                    Console.WriteLine(k);
                    kts.Close();
                    if (k == 0)
                    {
                        MessageBox.Show("Lớp không có sinh viên");
                        btnGhi.Enabled = false;
                        btnThoat.Enabled = true;
                        btnBatDau.Enabled = true;
                    }
                    this.sp_DANHSACHNHAPDIEMTableAdapter.Fill(this.DS.sp_DANHSACHNHAPDIEM, txtLop.Text, txtMonHoc.Text, (short)lanthi);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        void beginForm()
        {
            thaydoi = false;
            cmbKhoa.Enabled = true;
            sp_DANHSACHNHAPDIEMGridControl.Visible = false;
            btnGhi.Enabled = false;
            btnThoat.Enabled = true;
            //ExitForm.Enabled = true;
            btnBatDau.Enabled = true;
        }

        void edit()
        {
            cmbKhoa.Enabled = false;
            sp_DANHSACHNHAPDIEMGridControl.Visible = true;
            btnGhi.Enabled = true;
            btnThoat.Enabled = true;
            //ExitForm.Enabled = false;
            btnBatDau.Enabled = false;
        }

        private int kiemtradiemtheolan(string malop, string mamh, int lan)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            String str_sp = "dbo.SP_KIEMTRADIEMTHEOLAN";
            Program.Sqlcmd = Program.conn.CreateCommand();
            Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.Sqlcmd.CommandText = str_sp;
            Program.Sqlcmd.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = malop;
            Program.Sqlcmd.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = mamh;
            Program.Sqlcmd.Parameters.Add("@LAN", SqlDbType.Int).Value = lan;
            Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.Sqlcmd.ExecuteNonQuery();
            String ret = Program.Sqlcmd.Parameters["@Ret"].Value.ToString();
            if (ret == "1")
            {
                return 1; //đã có điểm
            }
            else if (ret == "0")
            {
                return 0; //chưa có điểm
            }
            return 0;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmbLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<float> listDiem = new List<float>();

            int x = Int32.Parse(bdsSPDIEMSV.Count.ToString());
            for (int i = 0; i < x; i++)
            {
                String Diem = ((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString();
                float DiemFloat = float.Parse(Diem);
                if (DiemFloat >= 10 || DiemFloat < 0)
                {
                    String Ten = ((DataRowView)bdsSPDIEMSV[i])["HOTEN"].ToString();
                    System.Windows.Forms.MessageBox.Show("Mời bạn nhập lại điểm cho sinh viên với Điểm từ 0-10");
                    return;
                }
                listDiem.Add(DiemFloat);
            }
            for (int i = 0; i < x; i++)
            {
                String Diem = listDiem[i].ToString();
                String Masv = ((DataRowView)bdsSPDIEMSV[i])["MASV"].ToString();
                SqlConnection sqlConnection = new SqlConnection(Program.connstr);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_UPDATEDIEM";
                sqlCommand.Parameters.Add(new SqlParameter("@MASV", Masv));
                sqlCommand.Parameters.Add(new SqlParameter("@MAMH", txtMonHoc.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@DIEM", Diem));
                sqlCommand.Parameters.Add(new SqlParameter("@LAN", lanthi));
                SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
                sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();


            }
            System.Windows.Forms.MessageBox.Show("Thành Công");
            beginForm();
        }

        
    }
}