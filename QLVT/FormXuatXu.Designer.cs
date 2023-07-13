namespace QLVT
{
    partial class FormXuatXu
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label tENQUOCGIALabel;
            System.Windows.Forms.Label tHOIDAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXuatXu));
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.THOIDAI = new DevExpress.XtraEditors.TextEdit();
            this.xuatXuBS = new System.Windows.Forms.BindingSource(this.components);
            this.BAOTANGDS = new QLVT.BAOTANGDataSet();
            this.TENQUOCGIA = new DevExpress.XtraEditors.TextEdit();
            this.ID = new DevExpress.XtraEditors.TextEdit();
            this.xuatxuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENQUOCGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIDAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xuatXuTA = new QLVT.BAOTANGDataSetTableAdapters.XUATXUTableAdapter();
            this.tableAdapterManager = new QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.tpntTA = new QLVT.BAOTANGDataSetTableAdapters.TPNTTableAdapter();
            this.tpntBS = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDLabel = new System.Windows.Forms.Label();
            tENQUOCGIALabel = new System.Windows.Forms.Label();
            tHOIDAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.THOIDAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuatXuBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TENQUOCGIA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuatxuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpntBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(56, 135);
            iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(24, 16);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // tENQUOCGIALabel
            // 
            tENQUOCGIALabel.AutoSize = true;
            tENQUOCGIALabel.Location = new System.Drawing.Point(376, 132);
            tENQUOCGIALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENQUOCGIALabel.Name = "tENQUOCGIALabel";
            tENQUOCGIALabel.Size = new System.Drawing.Size(86, 16);
            tENQUOCGIALabel.TabIndex = 2;
            tENQUOCGIALabel.Text = "Tên quốc gia:";
            // 
            // tHOIDAILabel
            // 
            tHOIDAILabel.AutoSize = true;
            tHOIDAILabel.Location = new System.Drawing.Point(728, 132);
            tHOIDAILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tHOIDAILabel.Name = "tHOIDAILabel";
            tHOIDAILabel.Size = new System.Drawing.Size(58, 16);
            tHOIDAILabel.TabIndex = 4;
            tHOIDAILabel.Text = "Thời đại:";
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 714);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat,
            this.btnHuy});
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar1.BarAppearance.Normal.Options.UseFont = true;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy thao tác";
            this.btnHuy.Enabled = false;
            this.btnHuy.Id = 7;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1219, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 744);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1219, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1219, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 714);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1215, 75);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(566, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "XUẤT XỨ";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 30);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1219, 714);
            this.panelControl2.TabIndex = 15;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.xuatxuGridControl);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 77);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1215, 635);
            this.panelControl3.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(tHOIDAILabel);
            this.panelControl4.Controls.Add(this.THOIDAI);
            this.panelControl4.Controls.Add(tENQUOCGIALabel);
            this.panelControl4.Controls.Add(this.TENQUOCGIA);
            this.panelControl4.Controls.Add(iDLabel);
            this.panelControl4.Controls.Add(this.ID);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Enabled = false;
            this.panelControl4.Location = new System.Drawing.Point(2, 238);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1211, 395);
            this.panelControl4.TabIndex = 2;
            // 
            // THOIDAI
            // 
            this.THOIDAI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xuatXuBS, "THOIDAI", true));
            this.THOIDAI.Location = new System.Drawing.Point(866, 129);
            this.THOIDAI.Margin = new System.Windows.Forms.Padding(4);
            this.THOIDAI.MenuManager = this.barManager1;
            this.THOIDAI.Name = "THOIDAI";
            this.THOIDAI.Size = new System.Drawing.Size(156, 22);
            this.THOIDAI.TabIndex = 5;
            // 
            // xuatXuBS
            // 
            this.xuatXuBS.DataMember = "XUATXU";
            this.xuatXuBS.DataSource = this.BAOTANGDS;
            // 
            // BAOTANGDS
            // 
            this.BAOTANGDS.DataSetName = "BAOTANGDataSet";
            this.BAOTANGDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TENQUOCGIA
            // 
            this.TENQUOCGIA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xuatXuBS, "TENQUOCGIA", true));
            this.TENQUOCGIA.Location = new System.Drawing.Point(483, 129);
            this.TENQUOCGIA.Margin = new System.Windows.Forms.Padding(4);
            this.TENQUOCGIA.MenuManager = this.barManager1;
            this.TENQUOCGIA.Name = "TENQUOCGIA";
            this.TENQUOCGIA.Size = new System.Drawing.Size(156, 22);
            this.TENQUOCGIA.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xuatXuBS, "ID", true));
            this.ID.Location = new System.Drawing.Point(118, 129);
            this.ID.Margin = new System.Windows.Forms.Padding(4);
            this.ID.MenuManager = this.barManager1;
            this.ID.Name = "ID";
            this.ID.Properties.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(156, 22);
            this.ID.TabIndex = 1;
            // 
            // xuatxuGridControl
            // 
            this.xuatxuGridControl.DataSource = this.xuatXuBS;
            this.xuatxuGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuatxuGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.xuatxuGridControl.Location = new System.Drawing.Point(2, 2);
            this.xuatxuGridControl.MainView = this.gridView1;
            this.xuatxuGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.xuatxuGridControl.MenuManager = this.barManager1;
            this.xuatxuGridControl.Name = "xuatxuGridControl";
            this.xuatxuGridControl.Size = new System.Drawing.Size(1211, 236);
            this.xuatxuGridControl.TabIndex = 1;
            this.xuatxuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTENQUOCGIA,
            this.colTHOIDAI});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.xuatxuGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 31;
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 117;
            // 
            // colTENQUOCGIA
            // 
            this.colTENQUOCGIA.Caption = "Tên quốc gia";
            this.colTENQUOCGIA.FieldName = "TENQUOCGIA";
            this.colTENQUOCGIA.MinWidth = 31;
            this.colTENQUOCGIA.Name = "colTENQUOCGIA";
            this.colTENQUOCGIA.OptionsColumn.ReadOnly = true;
            this.colTENQUOCGIA.Visible = true;
            this.colTENQUOCGIA.VisibleIndex = 1;
            this.colTENQUOCGIA.Width = 117;
            // 
            // colTHOIDAI
            // 
            this.colTHOIDAI.Caption = "Thời đại";
            this.colTHOIDAI.FieldName = "THOIDAI";
            this.colTHOIDAI.MinWidth = 31;
            this.colTHOIDAI.Name = "colTHOIDAI";
            this.colTHOIDAI.OptionsColumn.ReadOnly = true;
            this.colTHOIDAI.Visible = true;
            this.colTHOIDAI.VisibleIndex = 2;
            this.colTHOIDAI.Width = 117;
            // 
            // xuatXuTA
            // 
            this.xuatXuTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = null;
            this.tableAdapterManager.CT_TRIENLAMTableAdapter = null;
            this.tableAdapterManager.DIEUKHAC_TACTUONGTableAdapter = null;
            this.tableAdapterManager.DIMUONTableAdapter = null;
            this.tableAdapterManager.HOIHOATableAdapter = null;
            this.tableAdapterManager.LOAIHINHKHACTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TPNTTableAdapter = this.tpntTA;
            this.tableAdapterManager.TRIENLAMTableAdapter = null;
            this.tableAdapterManager.TTBOSUUTAPTableAdapter = null;
            this.tableAdapterManager.TTTACGIATableAdapter = null;
            this.tableAdapterManager.TTTPNTTableAdapter = null;
            this.tableAdapterManager.TTXUATXUTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XUATXUTableAdapter = this.xuatXuTA;
            // 
            // tpntTA
            // 
            this.tpntTA.ClearBeforeFill = true;
            // 
            // tpntBS
            // 
            this.tpntBS.DataMember = "TPNT";
            this.tpntBS.DataSource = this.BAOTANGDS;
            // 
            // tPNTBindingSource
            // 
            this.tPNTBindingSource.DataMember = "FK_TPNT_XUATXU";
            this.tPNTBindingSource.DataSource = this.xuatXuBS;
            // 
            // FormXuatXu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 744);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormXuatXu";
            this.Text = "Xuất xứ";
            this.Load += new System.EventHandler(this.FormXuatXu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.THOIDAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuatXuBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TENQUOCGIA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuatxuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpntBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource xuatXuBS;
        private BAOTANGDataSet BAOTANGDS;
        private BAOTANGDataSetTableAdapters.XUATXUTableAdapter xuatXuTA;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl xuatxuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTENQUOCGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIDAI;
        private DevExpress.XtraEditors.TextEdit THOIDAI;
        private DevExpress.XtraEditors.TextEdit TENQUOCGIA;
        private DevExpress.XtraEditors.TextEdit ID;
        private BAOTANGDataSetTableAdapters.TPNTTableAdapter tpntTA;
        private System.Windows.Forms.BindingSource tpntBS;
        private System.Windows.Forms.BindingSource tPNTBindingSource;
    }
}