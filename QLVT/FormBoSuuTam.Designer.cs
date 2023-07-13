namespace QLVT
{
    partial class FormBoSuuTam
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
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hINHTHUCLabel;
            System.Windows.Forms.Label mOTALabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label nGUOIGIAODICHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoSuuTam));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.NGUOIGIAODICH = new DevExpress.XtraEditors.TextEdit();
            this.bstDB = new System.Windows.Forms.BindingSource(this.components);
            this.BAOTANGDS = new QLVT.BAOTANGDataSet();
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
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.SDT = new DevExpress.XtraEditors.TextEdit();
            this.DIACHI = new DevExpress.XtraEditors.TextEdit();
            this.MOTA = new DevExpress.XtraEditors.TextEdit();
            this.HINHTHUC = new DevExpress.XtraEditors.TextEdit();
            this.TEN = new DevExpress.XtraEditors.TextEdit();
            this.bstGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHINHTHUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGUOIGIAODICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.bstTA = new QLVT.BAOTANGDataSetTableAdapters.BOSUUTAPTableAdapter();
            this.tableAdapterManager = new QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.diMuonTA = new QLVT.BAOTANGDataSetTableAdapters.DIMUONTableAdapter();
            this.diMuonDB = new System.Windows.Forms.BindingSource(this.components);
            tENLabel = new System.Windows.Forms.Label();
            hINHTHUCLabel = new System.Windows.Forms.Label();
            mOTALabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            nGUOIGIAODICHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NGUOIGIAODICH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DIACHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MOTA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HINHTHUC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diMuonDB)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(61, 84);
            tENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(98, 16);
            tENLabel.TabIndex = 0;
            tENLabel.Text = "Tên bộ sưu tầm";
            // 
            // hINHTHUCLabel
            // 
            hINHTHUCLabel.AutoSize = true;
            hINHTHUCLabel.Location = new System.Drawing.Point(521, 80);
            hINHTHUCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hINHTHUCLabel.Name = "hINHTHUCLabel";
            hINHTHUCLabel.Size = new System.Drawing.Size(66, 16);
            hINHTHUCLabel.TabIndex = 2;
            hINHTHUCLabel.Text = "Hình thức:";
            // 
            // mOTALabel
            // 
            mOTALabel.AutoSize = true;
            mOTALabel.Location = new System.Drawing.Point(61, 271);
            mOTALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mOTALabel.Name = "mOTALabel";
            mOTALabel.Size = new System.Drawing.Size(44, 16);
            mOTALabel.TabIndex = 4;
            mOTALabel.Text = "Mô tả:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(521, 176);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(51, 16);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(1055, 80);
            sODTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(37, 16);
            sODTLabel.TabIndex = 8;
            sODTLabel.Text = "SĐT:";
            // 
            // nGUOIGIAODICHLabel
            // 
            nGUOIGIAODICHLabel.AutoSize = true;
            nGUOIGIAODICHLabel.Location = new System.Drawing.Point(61, 176);
            nGUOIGIAODICHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGUOIGIAODICHLabel.Name = "nGUOIGIAODICHLabel";
            nGUOIGIAODICHLabel.Size = new System.Drawing.Size(100, 16);
            nGUOIGIAODICHLabel.TabIndex = 10;
            nGUOIGIAODICHLabel.Text = "Người giao dịch:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 30);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1538, 1025);
            this.panelControl2.TabIndex = 15;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.bstGridControl);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 77);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1534, 946);
            this.panelControl3.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(nGUOIGIAODICHLabel);
            this.panelControl4.Controls.Add(this.NGUOIGIAODICH);
            this.panelControl4.Controls.Add(sODTLabel);
            this.panelControl4.Controls.Add(this.SDT);
            this.panelControl4.Controls.Add(dIACHILabel);
            this.panelControl4.Controls.Add(this.DIACHI);
            this.panelControl4.Controls.Add(mOTALabel);
            this.panelControl4.Controls.Add(this.MOTA);
            this.panelControl4.Controls.Add(hINHTHUCLabel);
            this.panelControl4.Controls.Add(this.HINHTHUC);
            this.panelControl4.Controls.Add(tENLabel);
            this.panelControl4.Controls.Add(this.TEN);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Enabled = false;
            this.panelControl4.Location = new System.Drawing.Point(2, 230);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1530, 714);
            this.panelControl4.TabIndex = 2;
            // 
            // NGUOIGIAODICH
            // 
            this.NGUOIGIAODICH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bstDB, "NGUOIGIAODICH", true));
            this.NGUOIGIAODICH.Location = new System.Drawing.Point(285, 172);
            this.NGUOIGIAODICH.Margin = new System.Windows.Forms.Padding(4);
            this.NGUOIGIAODICH.MenuManager = this.barManager1;
            this.NGUOIGIAODICH.Name = "NGUOIGIAODICH";
            this.NGUOIGIAODICH.Size = new System.Drawing.Size(156, 22);
            this.NGUOIGIAODICH.TabIndex = 11;
            // 
            // bstDB
            // 
            this.bstDB.DataMember = "BOSUUTAP";
            this.bstDB.DataSource = this.BAOTANGDS;
            // 
            // BAOTANGDS
            // 
            this.BAOTANGDS.DataSetName = "BAOTANGDataSet";
            this.BAOTANGDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1538, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1055);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1538, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1025);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1538, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1025);
            // 
            // SDT
            // 
            this.SDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bstDB, "SODT", true));
            this.SDT.Location = new System.Drawing.Point(1173, 76);
            this.SDT.Margin = new System.Windows.Forms.Padding(4);
            this.SDT.MenuManager = this.barManager1;
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(215, 22);
            this.SDT.TabIndex = 9;
            // 
            // DIACHI
            // 
            this.DIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bstDB, "DIACHI", true));
            this.DIACHI.Location = new System.Drawing.Point(715, 173);
            this.DIACHI.Margin = new System.Windows.Forms.Padding(4);
            this.DIACHI.MenuManager = this.barManager1;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Size = new System.Drawing.Size(229, 22);
            this.DIACHI.TabIndex = 7;
            // 
            // MOTA
            // 
            this.MOTA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bstDB, "MOTA", true));
            this.MOTA.Location = new System.Drawing.Point(285, 268);
            this.MOTA.Margin = new System.Windows.Forms.Padding(4);
            this.MOTA.MenuManager = this.barManager1;
            this.MOTA.Name = "MOTA";
            this.MOTA.Size = new System.Drawing.Size(269, 22);
            this.MOTA.TabIndex = 5;
            // 
            // HINHTHUC
            // 
            this.HINHTHUC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bstDB, "HINHTHUC", true));
            this.HINHTHUC.Location = new System.Drawing.Point(715, 76);
            this.HINHTHUC.Margin = new System.Windows.Forms.Padding(4);
            this.HINHTHUC.MenuManager = this.barManager1;
            this.HINHTHUC.Name = "HINHTHUC";
            this.HINHTHUC.Size = new System.Drawing.Size(156, 22);
            this.HINHTHUC.TabIndex = 3;
            // 
            // TEN
            // 
            this.TEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bstDB, "TEN", true));
            this.TEN.Location = new System.Drawing.Point(285, 76);
            this.TEN.Margin = new System.Windows.Forms.Padding(4);
            this.TEN.MenuManager = this.barManager1;
            this.TEN.Name = "TEN";
            this.TEN.Size = new System.Drawing.Size(156, 22);
            this.TEN.TabIndex = 1;
            // 
            // bstGridControl
            // 
            this.bstGridControl.DataSource = this.bstDB;
            this.bstGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bstGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.bstGridControl.Location = new System.Drawing.Point(2, 2);
            this.bstGridControl.MainView = this.gridView1;
            this.bstGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.bstGridControl.MenuManager = this.barManager1;
            this.bstGridControl.Name = "bstGridControl";
            this.bstGridControl.Size = new System.Drawing.Size(1530, 228);
            this.bstGridControl.TabIndex = 1;
            this.bstGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTEN,
            this.colHINHTHUC,
            this.colMOTA,
            this.colDIACHI,
            this.colSODT,
            this.colNGUOIGIAODICH});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.bstGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên bộ sưu tập";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 31;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.ReadOnly = true;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 0;
            this.colTEN.Width = 117;
            // 
            // colHINHTHUC
            // 
            this.colHINHTHUC.Caption = "Hình thức";
            this.colHINHTHUC.FieldName = "HINHTHUC";
            this.colHINHTHUC.MinWidth = 31;
            this.colHINHTHUC.Name = "colHINHTHUC";
            this.colHINHTHUC.OptionsColumn.ReadOnly = true;
            this.colHINHTHUC.Visible = true;
            this.colHINHTHUC.VisibleIndex = 1;
            this.colHINHTHUC.Width = 117;
            // 
            // colMOTA
            // 
            this.colMOTA.Caption = "Mô tả";
            this.colMOTA.FieldName = "MOTA";
            this.colMOTA.MinWidth = 31;
            this.colMOTA.Name = "colMOTA";
            this.colMOTA.OptionsColumn.ReadOnly = true;
            this.colMOTA.Visible = true;
            this.colMOTA.VisibleIndex = 2;
            this.colMOTA.Width = 117;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 31;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.ReadOnly = true;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 117;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "Số điện thoại";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 31;
            this.colSODT.Name = "colSODT";
            this.colSODT.OptionsColumn.ReadOnly = true;
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 4;
            this.colSODT.Width = 117;
            // 
            // colNGUOIGIAODICH
            // 
            this.colNGUOIGIAODICH.Caption = "Người giao dịch";
            this.colNGUOIGIAODICH.FieldName = "NGUOIGIAODICH";
            this.colNGUOIGIAODICH.MinWidth = 31;
            this.colNGUOIGIAODICH.Name = "colNGUOIGIAODICH";
            this.colNGUOIGIAODICH.OptionsColumn.ReadOnly = true;
            this.colNGUOIGIAODICH.Visible = true;
            this.colNGUOIGIAODICH.VisibleIndex = 5;
            this.colNGUOIGIAODICH.Width = 117;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1534, 75);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(727, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "BỘ SƯU TẦM";
            // 
            // bstTA
            // 
            this.bstTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = this.bstTA;
            this.tableAdapterManager.CT_TRIENLAMTableAdapter = null;
            this.tableAdapterManager.DIEUKHAC_TACTUONGTableAdapter = null;
            this.tableAdapterManager.DIMUONTableAdapter = this.diMuonTA;
            this.tableAdapterManager.HOIHOATableAdapter = null;
            this.tableAdapterManager.LOAIHINHKHACTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TPNTTableAdapter = null;
            this.tableAdapterManager.TRIENLAMTableAdapter = null;
            this.tableAdapterManager.TTBOSUUTAPTableAdapter = null;
            this.tableAdapterManager.TTTACGIATableAdapter = null;
            this.tableAdapterManager.TTTPNTTableAdapter = null;
            this.tableAdapterManager.TTXUATXUTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XUATXUTableAdapter = null;
            // 
            // diMuonTA
            // 
            this.diMuonTA.ClearBeforeFill = true;
            // 
            // diMuonDB
            // 
            this.diMuonDB.DataMember = "FK_DIMUON_BOSUUTAP";
            this.diMuonDB.DataSource = this.bstDB;
            // 
            // FormBoSuuTam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1538, 1055);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormBoSuuTam";
            this.Text = "Bộ sưu tập";
            this.Load += new System.EventHandler(this.FormBoSuuTam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NGUOIGIAODICH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DIACHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MOTA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HINHTHUC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diMuonDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
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
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bstDB;
        private BAOTANGDataSet BAOTANGDS;
        private BAOTANGDataSetTableAdapters.BOSUUTAPTableAdapter bstTA;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl bstGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHINHTHUC;
        private DevExpress.XtraGrid.Columns.GridColumn colMOTA;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colNGUOIGIAODICH;
        private DevExpress.XtraEditors.TextEdit NGUOIGIAODICH;
        private DevExpress.XtraEditors.TextEdit SDT;
        private DevExpress.XtraEditors.TextEdit DIACHI;
        private DevExpress.XtraEditors.TextEdit MOTA;
        private DevExpress.XtraEditors.TextEdit HINHTHUC;
        private DevExpress.XtraEditors.TextEdit TEN;
        private BAOTANGDataSetTableAdapters.DIMUONTableAdapter diMuonTA;
        private System.Windows.Forms.BindingSource diMuonDB;
    }
}