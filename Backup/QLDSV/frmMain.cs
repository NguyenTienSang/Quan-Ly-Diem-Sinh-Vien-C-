using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
    
namespace QLDSV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheeckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

      

        private void frmMain_Load(object sender, EventArgs e)
        {
            Form frm = this.CheeckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                if(Program.mKhoa.ToString() == "0" || Program.mKhoa.ToString() == "1")
                {
                    btnHocPhi.Enabled = false;
                }
               else 
                {
                    btn_Lop.Enabled = btn_Subject.Enabled = btnSinhVien.Enabled = btn_Mark.Enabled = false;
                }
                f.Close();
            }
        }

        

        private void lblMAGV_Click(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_Subject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheeckExists(typeof(frmMonHoc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheeckExists(typeof(frmSinhVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_Lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheeckExists(typeof(frmLop));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_Mark_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheeckExists(typeof(frmDiem));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDiem f = new frmDiem();
                f.MdiParent = this;
                f.Show();
            }
        }




        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
            DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn đăng xuất không ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                this.Hide();



            }
        }

        private void btnDangXuat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn đăng xuất không ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                this.Close();
            }
            Program.frmDangNhap.Visible = true;
        }

        private void btnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheeckExists(typeof(frmHocPhi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmHocPhi f = new frmHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheeckExists(typeof(frmTaoTaiKhoan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }
        

        private void btnInDSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheeckExists(typeof(Report.frmINDSSV));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Report.frmINDSSV f = new Report.frmINDSSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBDMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheeckExists(typeof(Report.frmBDMH));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Report.frmBDMH f = new Report.frmBDMH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheeckExists(typeof(Report.frmPHIEUDIEM));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Report.frmPHIEUDIEM f = new Report.frmPHIEUDIEM();
                f.MdiParent = this;
                f.Show();
            }
        }

       

        private void btn_Lop_ItemClick1(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheeckExists(typeof(frmLop));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void DangXuatbtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn đăng xuất không ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                this.Close();
            }
            Program.frmDangNhap.Visible = true;
        }

        private void btnDangXuat_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn đăng xuất không ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                this.Close();
            }
            Program.frmDangNhap.Visible = true;
        }

        private void btnBDTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheeckExists(typeof(Report.frmBDTK));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Report.frmBDTK f = new Report.frmBDTK();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
