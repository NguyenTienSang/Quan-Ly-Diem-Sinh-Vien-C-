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
    public partial class frmMonHoc : Form
    {
        Int32 vitri = 0;
        bool isEditing = true;

        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void mONHOCBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void mONHOCBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void mONHOCBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void mONHOCBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
            if (Program.mGroup == "KHOA")
            {
                btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
            }
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.DS.DIEM);

            txtMaMH.ReadOnly = true;
            btnGhi.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isEditing = false;
            vitri = bdsMONHOC.Position;         //lấy vi tri của row hiện tại, tính từ 0
            gcMonHoc.Enabled = false;

            bdsMONHOC.AddNew();             // thao tác chuẩn bị thêm 1 new item/row 

            txtMaMH.ReadOnly = false;
            txtMaMH.Focus();

            //custom từng nút lệnh
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaMH.Focus();
            }
            else if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtTenMH.Focus();
            }
            

            else
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                String str_sp = "sp_KiemTraMaMonHocTonTai";
                Program.Sqlcmd = Program.conn.CreateCommand();
                Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.Sqlcmd.CommandText = str_sp;
                Program.Sqlcmd.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = txtMaMH.Text;
                Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.Sqlcmd.ExecuteNonQuery();
                String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                gcMonHoc.Enabled = true;
                btnGhi.Enabled = false;
                if (ret == "1" && isEditing == false)
                {
                    MessageBox.Show("Mã đã tồn tại đã tồn tại. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        bdsMONHOC.EndEdit();            // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                        bdsMONHOC.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                        this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.MONHOCTableAdapter.Update(this.DS.MONHOC);         // cập nhật dl từ dataset về database thông qua tableadapter

                        isEditing = true;
                        btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
                        txtMaMH.ReadOnly = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi môn học " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMONHOC.CancelEdit();
            if (isEditing == false)
            {
                bdsMONHOC.Position = vitri;
                gcMonHoc.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
                txtMaMH.ReadOnly = true;
                isEditing = true;
            }
        }

        
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsMONHOC.Count == 0)
            {
                return;
            }
            else
            {
                if (bdsDIEM.Count > 0)
                {
                    MessageBox.Show("Môn học hiện đang có điểm sinh viên, không thể xóa !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa Môn học ?", "Thông báo !", MessageBoxButtons.YesNo);
                    if (ds == DialogResult.Yes)
                    {
                        try
                        {
                            bdsMONHOC.RemoveCurrent();          //xóa row đang chọn ra khỏi dataset
                            //this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.MONHOCTableAdapter.Update(this.DS.MONHOC);
                            //this.bdsMONHOC.ResetCurrentItem();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa Môn học. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }
    }   
        
    }
