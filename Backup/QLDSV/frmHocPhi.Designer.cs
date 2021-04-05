namespace QLDSV
{
    partial class frmHocPhi
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
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOCPHILabel;
            System.Windows.Forms.Label sOTIENDADONGLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QLDSV.DS();
            this.sP_TIMSVDHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_TIMSVDHPTableAdapter = new QLDSV.DSTableAdapters.SP_TIMSVDHPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.sINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.sP_THEMHOCPHICHOSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_THEMHOCPHICHOSVTableAdapter = new QLDSV.DSTableAdapters.SP_THEMHOCPHICHOSVTableAdapter();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTim = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.txtSoTienDaDong = new System.Windows.Forms.TextBox();
            this.txtHocPhi = new System.Windows.Forms.TextBox();
            this.sP_THEMHOCPHICHOSVGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTD = new DevExpress.XtraGrid.Columns.GridColumn();
            hOTENLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            hOCPHILabel = new System.Windows.Forms.Label();
            sOTIENDADONGLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TIMSVDHPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_THEMHOCPHICHOSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_THEMHOCPHICHOSVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(136, 110);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(57, 17);
            hOTENLabel.TabIndex = 11;
            hOTENLabel.Text = "HOTEN:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(476, 110);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(56, 17);
            mALOPLabel.TabIndex = 12;
            mALOPLabel.Text = "MALOP:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(146, 64);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(47, 17);
            mASVLabel.TabIndex = 16;
            mASVLabel.Text = "MASV:";
            mASVLabel.Click += new System.EventHandler(this.mASVLabel_Click);
            // 
            // hOCPHILabel
            // 
            hOCPHILabel.AutoSize = true;
            hOCPHILabel.Location = new System.Drawing.Point(274, 99);
            hOCPHILabel.Name = "hOCPHILabel";
            hOCPHILabel.Size = new System.Drawing.Size(62, 17);
            hOCPHILabel.TabIndex = 4;
            hOCPHILabel.Text = "HOCPHI:";
            // 
            // sOTIENDADONGLabel
            // 
            sOTIENDADONGLabel.AutoSize = true;
            sOTIENDADONGLabel.Location = new System.Drawing.Point(518, 96);
            sOTIENDADONGLabel.Name = "sOTIENDADONGLabel";
            sOTIENDADONGLabel.Size = new System.Drawing.Size(116, 17);
            sOTIENDADONGLabel.TabIndex = 6;
            sOTIENDADONGLabel.Text = "SOTIENDADONG:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(258, 65);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(78, 17);
            nIENKHOALabel.TabIndex = 8;
            nIENKHOALabel.Text = "NIENKHOA:";
            // 
            // hOCKYLabel1
            // 
            hOCKYLabel1.AutoSize = true;
            hOCKYLabel1.Location = new System.Drawing.Point(577, 65);
            hOCKYLabel1.Name = "hOCKYLabel1";
            hOCKYLabel1.Size = new System.Drawing.Size(57, 17);
            hOCKYLabel1.TabIndex = 9;
            hOCKYLabel1.Text = "HOCKY:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "THÊM";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1176, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 665);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1176, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 614);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1176, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 614);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_TIMSVDHPBindingSource
            // 
            this.sP_TIMSVDHPBindingSource.DataMember = "SP_TIMSVDHP";
            this.sP_TIMSVDHPBindingSource.DataSource = this.DS;
            // 
            // sP_TIMSVDHPTableAdapter
            // 
            this.sP_TIMSVDHPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // sP_THEMHOCPHICHOSVBindingSource
            // 
            this.sP_THEMHOCPHICHOSVBindingSource.DataMember = "SP_THEMHOCPHICHOSV";
            this.sP_THEMHOCPHICHOSVBindingSource.DataSource = this.DS;
            // 
            // sP_THEMHOCPHICHOSVTableAdapter
            // 
            this.sP_THEMHOCPHICHOSVTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.DS;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(547, 51);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(116, 38);
            this.btnTim.TabIndex = 18;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMaLop);
            this.groupControl1.Controls.Add(this.txtHoTen);
            this.groupControl1.Controls.Add(this.txtMaSV);
            this.groupControl1.Controls.Add(mASVLabel);
            this.groupControl1.Controls.Add(this.btnTim);
            this.groupControl1.Controls.Add(hOTENLabel);
            this.groupControl1.Controls.Add(mALOPLabel);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 51);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1176, 157);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Thông tin sinh viên";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(547, 110);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(100, 23);
            this.txtMaLop.TabIndex = 21;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(209, 104);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(179, 23);
            this.txtHoTen.TabIndex = 20;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(209, 61);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(179, 23);
            this.txtMaSV.TabIndex = 19;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(hOCKYLabel1);
            this.groupControl2.Controls.Add(this.txtHocKy);
            this.groupControl2.Controls.Add(nIENKHOALabel);
            this.groupControl2.Controls.Add(this.txtNienKhoa);
            this.groupControl2.Controls.Add(sOTIENDADONGLabel);
            this.groupControl2.Controls.Add(this.txtSoTienDaDong);
            this.groupControl2.Controls.Add(hOCPHILabel);
            this.groupControl2.Controls.Add(this.txtHocPhi);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 208);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1176, 151);
            this.groupControl2.TabIndex = 24;
            this.groupControl2.Text = "Thông tin học phí";
            // 
            // txtHocKy
            // 
            this.txtHocKy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_THEMHOCPHICHOSVBindingSource, "HOCKY", true));
            this.txtHocKy.Location = new System.Drawing.Point(640, 59);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(166, 23);
            this.txtHocKy.TabIndex = 10;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_THEMHOCPHICHOSVBindingSource, "NIENKHOA", true));
            this.txtNienKhoa.Location = new System.Drawing.Point(342, 67);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(124, 23);
            this.txtNienKhoa.TabIndex = 9;
            // 
            // txtSoTienDaDong
            // 
            this.txtSoTienDaDong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_THEMHOCPHICHOSVBindingSource, "SOTIENDADONG", true));
            this.txtSoTienDaDong.Location = new System.Drawing.Point(640, 93);
            this.txtSoTienDaDong.Name = "txtSoTienDaDong";
            this.txtSoTienDaDong.Size = new System.Drawing.Size(166, 23);
            this.txtSoTienDaDong.TabIndex = 7;
            this.txtSoTienDaDong.TextChanged += new System.EventHandler(this.sOTIENDADONGTextBox_TextChanged);
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_THEMHOCPHICHOSVBindingSource, "HOCPHI", true));
            this.txtHocPhi.Location = new System.Drawing.Point(342, 96);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Size = new System.Drawing.Size(124, 23);
            this.txtHocPhi.TabIndex = 5;
            // 
            // sP_THEMHOCPHICHOSVGridControl
            // 
            this.sP_THEMHOCPHICHOSVGridControl.DataSource = this.sP_THEMHOCPHICHOSVBindingSource;
            this.sP_THEMHOCPHICHOSVGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_THEMHOCPHICHOSVGridControl.Location = new System.Drawing.Point(0, 359);
            this.sP_THEMHOCPHICHOSVGridControl.MainView = this.gridView1;
            this.sP_THEMHOCPHICHOSVGridControl.MenuManager = this.barManager1;
            this.sP_THEMHOCPHICHOSVGridControl.Name = "sP_THEMHOCPHICHOSVGridControl";
            this.sP_THEMHOCPHICHOSVGridControl.Size = new System.Drawing.Size(1176, 220);
            this.sP_THEMHOCPHICHOSVGridControl.TabIndex = 24;
            this.sP_THEMHOCPHICHOSVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG,
            this.colSTD});
            this.gridView1.GridControl = this.sP_THEMHOCPHICHOSVGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.Caption = "Niên khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 94;
            // 
            // colHOCKY
            // 
            this.colHOCKY.Caption = "Học kỳ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 94;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.Caption = "Học phí";
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 25;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 94;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.Caption = "Tiền đã đóng";
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.MinWidth = 25;
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            this.colSOTIENDADONG.Width = 94;
            // 
            // colSTD
            // 
            this.colSTD.FieldName = "STD";
            this.colSTD.MinWidth = 25;
            this.colSTD.Name = "colSTD";
            this.colSTD.Visible = true;
            this.colSTD.VisibleIndex = 4;
            this.colSTD.Width = 94;
            // 
            // frmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 685);
            this.Controls.Add(this.sP_THEMHOCPHICHOSVGridControl);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHocPhi";
            this.Text = "Học Phí";
            this.Load += new System.EventHandler(this.frmHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TIMSVDHPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_THEMHOCPHICHOSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_THEMHOCPHICHOSVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource sP_TIMSVDHPBindingSource;
        private DS DS;
        private DSTableAdapters.SP_TIMSVDHPTableAdapter sP_TIMSVDHPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sP_THEMHOCPHICHOSVBindingSource;
        private DSTableAdapters.SP_THEMHOCPHICHOSVTableAdapter sP_THEMHOCPHICHOSVTableAdapter;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private System.Windows.Forms.Button btnTim;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl sP_THEMHOCPHICHOSVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtSoTienDaDong;
        private System.Windows.Forms.TextBox txtHocPhi;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.TextBox txtNienKhoa;
    }
}