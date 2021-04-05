namespace QLDSV
{
    partial class frmTaoTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label hO_TENLabel;
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau2 = new System.Windows.Forms.TextBox();
            this.cmbMa = new System.Windows.Forms.ComboBox();
            this.v_LAYDANHSACHGIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLDSV.DS();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.v_LAYDANHSACHGIANGVIENTableAdapter = new QLDSV.DSTableAdapters.V_LAYDANHSACHGIANGVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            hO_TENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.v_LAYDANHSACHGIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.SuspendLayout();
            // 
            // hO_TENLabel
            // 
            hO_TENLabel.AutoSize = true;
            hO_TENLabel.ForeColor = System.Drawing.Color.Black;
            hO_TENLabel.Location = new System.Drawing.Point(86, 257);
            hO_TENLabel.Name = "hO_TENLabel";
            hO_TENLabel.Size = new System.Drawing.Size(30, 17);
            hO_TENLabel.TabIndex = 52;
            hO_TENLabel.Text = "Mã:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Blue;
            this.btnThoat.Location = new System.Drawing.Point(322, 364);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(169, 58);
            this.btnThoat.TabIndex = 56;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.BackColor = System.Drawing.Color.Red;
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(95, 364);
            this.btnTaoTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(169, 58);
            this.btnTaoTaiKhoan.TabIndex = 55;
            this.btnTaoTaiKhoan.Text = "TẠO TÀI KHOẢN";
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(64, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Nhập Lại Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(64, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nhóm quyền:";
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.Location = new System.Drawing.Point(217, 191);
            this.txtMatKhau2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.PasswordChar = '*';
            this.txtMatKhau2.Size = new System.Drawing.Size(196, 23);
            this.txtMatKhau2.TabIndex = 48;
            // 
            // cmbMa
            // 
            this.cmbMa.DataSource = this.v_LAYDANHSACHGIANGVIENBindingSource;
            this.cmbMa.DisplayMember = "MAGV";
            this.cmbMa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMa.FormattingEnabled = true;
            this.cmbMa.Location = new System.Drawing.Point(217, 257);
            this.cmbMa.Name = "cmbMa";
            this.cmbMa.Size = new System.Drawing.Size(196, 24);
            this.cmbMa.TabIndex = 47;
            this.cmbMa.ValueMember = "MAGV";
            // 
            // v_LAYDANHSACHGIANGVIENBindingSource
            // 
            this.v_LAYDANHSACHGIANGVIENBindingSource.DataMember = "V_LAYDANHSACHGIANGVIEN";
            this.v_LAYDANHSACHGIANGVIENBindingSource.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(217, 138);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(196, 23);
            this.txtMatKhau.TabIndex = 46;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(217, 94);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(196, 23);
            this.txtTaiKhoan.TabIndex = 45;
            // 
            // cmbNhom
            // 
            this.cmbNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Location = new System.Drawing.Point(217, 45);
            this.cmbNhom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(196, 24);
            this.cmbNhom.TabIndex = 44;
            // 
            // v_LAYDANHSACHGIANGVIENTableAdapter
            // 
            this.v_LAYDANHSACHGIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 497);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoTaiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(hO_TENLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhau2);
            this.Controls.Add(this.cmbMa);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.cmbNhom);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_LAYDANHSACHGIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhau2;
        private System.Windows.Forms.ComboBox cmbMa;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.ComboBox cmbNhom;
        private DS DS;
        private System.Windows.Forms.BindingSource v_LAYDANHSACHGIANGVIENBindingSource;
        private DSTableAdapters.V_LAYDANHSACHGIANGVIENTableAdapter v_LAYDANHSACHGIANGVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}