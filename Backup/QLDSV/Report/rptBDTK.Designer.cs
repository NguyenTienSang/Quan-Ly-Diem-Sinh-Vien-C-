namespace QLDSV.Report
{
    partial class rptBDTK
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBDTK));
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(99.99998F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(184.0244F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition3 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(250.3089F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.crossTabGeneralStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabTotalStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbTenLop = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.crossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
            this.xrCrossTabCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell7 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell8 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell9 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell10 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell11 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell12 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell13 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell14 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.TitleStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.crossTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLDSVConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_INBANGDIEMTONGKET";
            queryParameter1.Name = "@malop";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "D15CQCN1";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "SP_INBANGDIEMTONGKET";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // crossTabGeneralStyle
            // 
            this.crossTabGeneralStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.crossTabGeneralStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabGeneralStyle.BorderWidth = 1F;
            this.crossTabGeneralStyle.Font = new System.Drawing.Font("Arial", 9.75F);
            this.crossTabGeneralStyle.Name = "crossTabGeneralStyle";
            this.crossTabGeneralStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // crossTabDataStyle
            // 
            this.crossTabDataStyle.Name = "crossTabDataStyle";
            this.crossTabDataStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabHeaderStyle
            // 
            this.crossTabHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.crossTabHeaderStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.crossTabHeaderStyle.Name = "crossTabHeaderStyle";
            this.crossTabHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabTotalStyle
            // 
            this.crossTabTotalStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.crossTabTotalStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.crossTabTotalStyle.Name = "crossTabTotalStyle";
            this.crossTabTotalStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbTenLop,
            this.xrLabel1,
            this.label1});
            this.ReportHeader.HeightF = 90.01302F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lbTenLop
            // 
            this.lbTenLop.LocationFloat = new DevExpress.Utils.PointFloat(300.691F, 57.01302F);
            this.lbTenLop.Multiline = true;
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTenLop.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(166.6667F, 57.01302F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel1.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(190.8333F, 10F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(279.0244F, 30.01302F);
            this.label1.StyleName = "TitleStyle";
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "BẢNG ĐIỂM TỔNG KẾT";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.crossTab1});
            this.Detail.HeightF = 125F;
            this.Detail.Name = "Detail";
            // 
            // crossTab1
            // 
            this.crossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCrossTabCell1,
            this.xrCrossTabCell2,
            this.xrCrossTabCell3,
            this.xrCrossTabCell4,
            this.xrCrossTabCell5,
            this.xrCrossTabCell6,
            this.xrCrossTabCell7,
            this.xrCrossTabCell8,
            this.xrCrossTabCell9,
            this.xrCrossTabCell10,
            this.xrCrossTabCell11,
            this.xrCrossTabCell12,
            this.xrCrossTabCell13,
            this.xrCrossTabCell14});
            crossTabColumnDefinition1.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
            crossTabColumnDefinition2.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
            crossTabColumnDefinition3.Visible = false;
            this.crossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            crossTabColumnDefinition1,
            crossTabColumnDefinition2,
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(116.6667F),
            crossTabColumnDefinition3});
            crossTabColumnField1.FieldName = "TENMH";
            this.crossTab1.ColumnFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField[] {
            crossTabColumnField1});
            this.crossTab1.DataAreaStyleName = "crossTabDataStyle";
            crossTabDataField1.FieldName = "DIEM";
            crossTabDataField1.SummaryType = DevExpress.XtraReports.UI.CrossTab.SummaryType.Max;
            this.crossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1});
            this.crossTab1.DataMember = "SP_INBANGDIEMTONGKET";
            this.crossTab1.DataSource = this.sqlDataSource1;
            this.crossTab1.GeneralStyleName = "crossTabGeneralStyle";
            this.crossTab1.HeaderAreaStyleName = "crossTabHeaderStyle";
            this.crossTab1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.crossTab1.Name = "crossTab1";
            crossTabRowDefinition1.Visible = false;
            crossTabRowDefinition2.Visible = false;
            this.crossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(50F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
            crossTabRowDefinition1,
            crossTabRowDefinition2});
            crossTabRowField1.FieldName = "MASV";
            crossTabRowField2.FieldName = "HOTEN";
            this.crossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1,
            crossTabRowField2});
            this.crossTab1.SizeF = new System.Drawing.SizeF(650.9999F, 125F);
            this.crossTab1.TotalAreaStyleName = "crossTabTotalStyle";
            // 
            // xrCrossTabCell1
            // 
            this.xrCrossTabCell1.ColumnIndex = 0;
            this.xrCrossTabCell1.Name = "xrCrossTabCell1";
            this.xrCrossTabCell1.RowIndex = 0;
            this.xrCrossTabCell1.Text = "MASV";
            // 
            // xrCrossTabCell2
            // 
            this.xrCrossTabCell2.ColumnIndex = 1;
            this.xrCrossTabCell2.Name = "xrCrossTabCell2";
            this.xrCrossTabCell2.RowIndex = 0;
            this.xrCrossTabCell2.Text = "HOTEN";
            this.xrCrossTabCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrCrossTabCell3
            // 
            this.xrCrossTabCell3.ColumnIndex = 2;
            this.xrCrossTabCell3.Name = "xrCrossTabCell3";
            this.xrCrossTabCell3.RowIndex = 1;
            this.xrCrossTabCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrCrossTabCell4
            // 
            this.xrCrossTabCell4.ColumnIndex = 2;
            this.xrCrossTabCell4.Name = "xrCrossTabCell4";
            this.xrCrossTabCell4.RowIndex = 0;
            // 
            // xrCrossTabCell5
            // 
            this.xrCrossTabCell5.ColumnIndex = 3;
            this.xrCrossTabCell5.Name = "xrCrossTabCell5";
            this.xrCrossTabCell5.RowIndex = 0;
            this.xrCrossTabCell5.Text = "Grand Total";
            // 
            // xrCrossTabCell6
            // 
            this.xrCrossTabCell6.ColumnIndex = 3;
            this.xrCrossTabCell6.Name = "xrCrossTabCell6";
            this.xrCrossTabCell6.RowIndex = 1;
            // 
            // xrCrossTabCell7
            // 
            this.xrCrossTabCell7.ColumnIndex = 0;
            this.xrCrossTabCell7.Name = "xrCrossTabCell7";
            this.xrCrossTabCell7.RowIndex = 1;
            this.xrCrossTabCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrCrossTabCell8
            // 
            this.xrCrossTabCell8.ColumnIndex = 1;
            this.xrCrossTabCell8.Name = "xrCrossTabCell8";
            this.xrCrossTabCell8.RowIndex = 1;
            this.xrCrossTabCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrCrossTabCell9
            // 
            this.xrCrossTabCell9.ColumnIndex = 0;
            this.xrCrossTabCell9.ColumnSpan = 2;
            this.xrCrossTabCell9.Name = "xrCrossTabCell9";
            this.xrCrossTabCell9.RowIndex = 2;
            this.xrCrossTabCell9.TextFormatString = "Total {0}";
            // 
            // xrCrossTabCell10
            // 
            this.xrCrossTabCell10.ColumnIndex = 0;
            this.xrCrossTabCell10.ColumnSpan = 2;
            this.xrCrossTabCell10.Name = "xrCrossTabCell10";
            this.xrCrossTabCell10.RowIndex = 3;
            this.xrCrossTabCell10.Text = "Grand Total";
            // 
            // xrCrossTabCell11
            // 
            this.xrCrossTabCell11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.xrCrossTabCell11.ColumnIndex = 2;
            this.xrCrossTabCell11.Name = "xrCrossTabCell11";
            this.xrCrossTabCell11.RowIndex = 2;
            // 
            // xrCrossTabCell12
            // 
            this.xrCrossTabCell12.ColumnIndex = 2;
            this.xrCrossTabCell12.Name = "xrCrossTabCell12";
            this.xrCrossTabCell12.RowIndex = 3;
            // 
            // xrCrossTabCell13
            // 
            this.xrCrossTabCell13.ColumnIndex = 3;
            this.xrCrossTabCell13.Name = "xrCrossTabCell13";
            this.xrCrossTabCell13.RowIndex = 2;
            // 
            // xrCrossTabCell14
            // 
            this.xrCrossTabCell14.ColumnIndex = 3;
            this.xrCrossTabCell14.Name = "xrCrossTabCell14";
            this.xrCrossTabCell14.RowIndex = 3;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // TitleStyle
            // 
            this.TitleStyle.Font = new System.Drawing.Font("Arial", 18F);
            this.TitleStyle.Name = "TitleStyle";
            this.TitleStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // rptBDTK
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart;
            this.Margins = new System.Drawing.Printing.Margins(100, 99, 100, 100);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.TitleStyle,
            this.crossTabGeneralStyle,
            this.crossTabHeaderStyle,
            this.crossTabDataStyle,
            this.crossTabTotalStyle});
            this.Version = "20.1";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            ((System.ComponentModel.ISupportInitialize)(this.crossTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRCrossTab crossTab1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell7;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell8;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell9;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell10;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell11;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell12;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell13;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell14;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle TitleStyle;
        public DevExpress.XtraReports.UI.XRLabel xrLabel1;
        public DevExpress.XtraReports.UI.XRLabel lbTenLop;
    }
}
