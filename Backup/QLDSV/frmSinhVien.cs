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
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        String maKhoa = "";
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {

            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";

            // lệnh này quan trọng... phải bỏ vào. ==> để cho combo box chạy đúng.
            cmbKhoa.SelectedIndex = 0;
         
            cmbKhoa.SelectedIndex = Program.mKhoa;
          
            btnGhi.Enabled = false;

            DS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr; // lấy data của Site tương ứng
            this.lOPTableAdapter.Fill(this.DS.LOP);
           
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.DS.DIEM);


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
            this.bdsLop.EndEdit();
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
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dIEMTableAdapter.Fill(this.DS.DIEM);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            vitri = bdsSV.Position; //lấy vị trí lớp  
            bdsSV.AddNew(); //thêm mới 1 hàng vào danh sách
            cmbKhoa.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = true;
            sINHVIENGridControl.Enabled = lOPGridControl.Enabled = false;
            mALOPComboBox.DataSource = bdsLop;
            mALOPComboBox.DisplayMember = "MALOP";
            mALOPComboBox.ValueMember = "MALOP";
            mALOPComboBox.SelectedIndex = 0;
        }

        private void pHAILabel_Click(object sender, EventArgs e)
        {

        }

        private void pHAICheckEdit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gHICHUTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.DS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa lớp này vì Lớp đã có sinh viên.", "", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa Lớp này?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    bdsSV.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.DS.LOP);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa Lớp.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.DS.LOP);
                    return;
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void mASVComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mALOPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mASVTextEdit.Text.Trim().Length == 0 || mALOPComboBox.Text.Trim().Length == 0
                || hOTextEdit.Text.Trim().Length == 0 || tENTextEdit.Text.Trim().Length == 0
                || nOISINHTextEdit.Text.Trim().Length == 0 || dIACHITextEdit.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Thông tin không được trống", "", MessageBoxButtons.OK);
            }
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            String str_sp = "sp_KiemTraMaSinhVienTonTai";
            Program.Sqlcmd = Program.conn.CreateCommand();
            Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.Sqlcmd.CommandText = str_sp;
            Program.Sqlcmd.Parameters.Add("@MASV", SqlDbType.VarChar).Value = mASVTextEdit.Text;
            Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.Sqlcmd.ExecuteNonQuery();
            String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
            if (ret == "1")
            {
                MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            else
            {
                try
                {
                    
                    bdsSV.EndEdit(); //kết thúc quá trình chỉnh sửa dữ liệu và gửi về DataSet.
                    bdsSV.ResetCurrentItem();//đọc lại row hiện tại đang đứng và dữ liệu không còn ở dạng tạm nữa mà hiện thị dữ liệu đã chính thức ghi vào DataSet
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                    this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.DS.LOP);
                    cmbKhoa.Enabled = true;
                    MessageBox.Show("Thêm Sv Thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }
    }
}