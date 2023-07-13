namespace QLVT
{
    partial class FormTG
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
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label qUOCTICHLabel;
            System.Windows.Forms.Label tHOIDAILabel;
            System.Windows.Forms.Label pHONGCACHCHINHLabel;
            System.Windows.Forms.Label dIENGIAILabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label nGAYMATLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTG));
            this.tacGiaBS = new System.Windows.Forms.BindingSource(this.components);
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
            this.tacGiaTA = new QLVT.BAOTANGDataSetTableAdapters.TACGIATableAdapter();
            this.tableAdapterManager = new QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.tpntTA = new QLVT.BAOTANGDataSetTableAdapters.TPNTTableAdapter();
            this.tpntBS = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NGAYMATT = new DevExpress.XtraEditors.DateEdit();
            this.DIENGIAII = new DevExpress.XtraEditors.TextEdit();
            this.PHONGCACHCHINHH = new DevExpress.XtraEditors.TextEdit();
            this.THOIDAII = new DevExpress.XtraEditors.TextEdit();
            this.QUOCTICHH = new DevExpress.XtraEditors.TextEdit();
            this.NGAYSINHH = new DevExpress.XtraEditors.DateEdit();
            this.TENN = new DevExpress.XtraEditors.TextEdit();
            this.tACGIAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUOCTICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIDAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONGCACHCHINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIENGIAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            qUOCTICHLabel = new System.Windows.Forms.Label();
            tHOIDAILabel = new System.Windows.Forms.Label();
            pHONGCACHCHINHLabel = new System.Windows.Forms.Label();
            dIENGIAILabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            nGAYMATLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpntBS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYMATT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYMATT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DIENGIAII.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHONGCACHCHINHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THOIDAII.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUOCTICHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYSINHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYSINHH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TENN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(40, 22);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(34, 16);
            tENLabel.TabIndex = 0;
            tENLabel.Text = "Tên:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(430, 30);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(70, 16);
            nGAYSINHLabel.TabIndex = 2;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // qUOCTICHLabel
            // 
            qUOCTICHLabel.AutoSize = true;
            qUOCTICHLabel.Location = new System.Drawing.Point(40, 84);
            qUOCTICHLabel.Name = "qUOCTICHLabel";
            qUOCTICHLabel.Size = new System.Drawing.Size(65, 16);
            qUOCTICHLabel.TabIndex = 4;
            qUOCTICHLabel.Text = "Quốc tịch:";
            // 
            // tHOIDAILabel
            // 
            tHOIDAILabel.AutoSize = true;
            tHOIDAILabel.Location = new System.Drawing.Point(429, 84);
            tHOIDAILabel.Name = "tHOIDAILabel";
            tHOIDAILabel.Size = new System.Drawing.Size(59, 16);
            tHOIDAILabel.TabIndex = 6;
            tHOIDAILabel.Text = "Thời đại:";
            // 
            // pHONGCACHCHINHLabel
            // 
            pHONGCACHCHINHLabel.AutoSize = true;
            pHONGCACHCHINHLabel.Location = new System.Drawing.Point(40, 143);
            pHONGCACHCHINHLabel.Name = "pHONGCACHCHINHLabel";
            pHONGCACHCHINHLabel.Size = new System.Drawing.Size(115, 16);
            pHONGCACHCHINHLabel.TabIndex = 8;
            pHONGCACHCHINHLabel.Text = "Phong cách chính:";
            // 
            // dIENGIAILabel
            // 
            dIENGIAILabel.AutoSize = true;
            dIENGIAILabel.Location = new System.Drawing.Point(430, 143);
            dIENGIAILabel.Name = "dIENGIAILabel";
            dIENGIAILabel.Size = new System.Drawing.Size(63, 16);
            dIENGIAILabel.TabIndex = 10;
            dIENGIAILabel.Text = "Diễn giải:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(532, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 25);
            label1.TabIndex = 3;
            label1.Text = "TÁC GIẢ";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nGAYMATLabel
            // 
            nGAYMATLabel.AutoSize = true;
            nGAYMATLabel.Location = new System.Drawing.Point(818, 26);
            nGAYMATLabel.Name = "nGAYMATLabel";
            nGAYMATLabel.Size = new System.Drawing.Size(68, 16);
            nGAYMATLabel.TabIndex = 12;
            nGAYMATLabel.Text = "Ngày mất:";
            // 
            // tacGiaBS
            // 
            this.tacGiaBS.DataMember = "TACGIA";
            this.tacGiaBS.DataSource = this.BAOTANGDS;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1099, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 517);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1099, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 487);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1099, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 487);
            // 
            // tacGiaTA
            // 
            this.tacGiaTA.ClearBeforeFill = true;
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
            this.tableAdapterManager.TACGIATableAdapter = this.tacGiaTA;
            this.tableAdapterManager.TPNTTableAdapter = this.tpntTA;
            this.tableAdapterManager.TRIENLAMTableAdapter = null;
            this.tableAdapterManager.TTBOSUUTAPTableAdapter = null;
            this.tableAdapterManager.TTTACGIATableAdapter = null;
            this.tableAdapterManager.TTTPNTTableAdapter = null;
            this.tableAdapterManager.TTXUATXUTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XUATXUTableAdapter = null;
            // 
            // tpntTA
            // 
            this.tpntTA.ClearBeforeFill = true;
            // 
            // tpntBS
            // 
            this.tpntBS.AllowNew = false;
            this.tpntBS.DataMember = "FK_TPNT_TACGIA";
            this.tpntBS.DataSource = this.tacGiaBS;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tACGIAGridControl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 487);
            this.panel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(nGAYMATLabel);
            this.panel3.Controls.Add(this.NGAYMATT);
            this.panel3.Controls.Add(dIENGIAILabel);
            this.panel3.Controls.Add(this.DIENGIAII);
            this.panel3.Controls.Add(pHONGCACHCHINHLabel);
            this.panel3.Controls.Add(this.PHONGCACHCHINHH);
            this.panel3.Controls.Add(tHOIDAILabel);
            this.panel3.Controls.Add(this.THOIDAII);
            this.panel3.Controls.Add(qUOCTICHLabel);
            this.panel3.Controls.Add(this.QUOCTICHH);
            this.panel3.Controls.Add(nGAYSINHLabel);
            this.panel3.Controls.Add(this.NGAYSINHH);
            this.panel3.Controls.Add(tENLabel);
            this.panel3.Controls.Add(this.TENN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(0, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1099, 196);
            this.panel3.TabIndex = 2;
            // 
            // NGAYMATT
            // 
            this.NGAYMATT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tacGiaBS, "NGAYMAT", true));
            this.NGAYMATT.EditValue = null;
            this.NGAYMATT.Location = new System.Drawing.Point(974, 23);
            this.NGAYMATT.MenuManager = this.barManager1;
            this.NGAYMATT.Name = "NGAYMATT";
            this.NGAYMATT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NGAYMATT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NGAYMATT.Size = new System.Drawing.Size(167, 22);
            this.NGAYMATT.TabIndex = 13;
            // 
            // DIENGIAII
            // 
            this.DIENGIAII.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tacGiaBS, "DIENGIAI", true));
            this.DIENGIAII.Location = new System.Drawing.Point(556, 140);
            this.DIENGIAII.Margin = new System.Windows.Forms.Padding(4);
            this.DIENGIAII.MenuManager = this.barManager1;
            this.DIENGIAII.Name = "DIENGIAII";
            this.DIENGIAII.Size = new System.Drawing.Size(224, 22);
            this.DIENGIAII.TabIndex = 11;
            // 
            // PHONGCACHCHINHH
            // 
            this.PHONGCACHCHINHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tacGiaBS, "PHONGCACHCHINH", true));
            this.PHONGCACHCHINHH.Location = new System.Drawing.Point(207, 140);
            this.PHONGCACHCHINHH.Margin = new System.Windows.Forms.Padding(4);
            this.PHONGCACHCHINHH.MenuManager = this.barManager1;
            this.PHONGCACHCHINHH.Name = "PHONGCACHCHINHH";
            this.PHONGCACHCHINHH.Size = new System.Drawing.Size(156, 22);
            this.PHONGCACHCHINHH.TabIndex = 9;
            // 
            // THOIDAII
            // 
            this.THOIDAII.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tacGiaBS, "THOIDAI", true));
            this.THOIDAII.Location = new System.Drawing.Point(556, 81);
            this.THOIDAII.Margin = new System.Windows.Forms.Padding(4);
            this.THOIDAII.MenuManager = this.barManager1;
            this.THOIDAII.Name = "THOIDAII";
            this.THOIDAII.Size = new System.Drawing.Size(156, 22);
            this.THOIDAII.TabIndex = 7;
            // 
            // QUOCTICHH
            // 
            this.QUOCTICHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tacGiaBS, "QUOCTICH", true));
            this.QUOCTICHH.Location = new System.Drawing.Point(152, 81);
            this.QUOCTICHH.Margin = new System.Windows.Forms.Padding(4);
            this.QUOCTICHH.MenuManager = this.barManager1;
            this.QUOCTICHH.Name = "QUOCTICHH";
            this.QUOCTICHH.Size = new System.Drawing.Size(156, 22);
            this.QUOCTICHH.TabIndex = 5;
            // 
            // NGAYSINHH
            // 
            this.NGAYSINHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tacGiaBS, "NGAYSINH", true));
            this.NGAYSINHH.EditValue = null;
            this.NGAYSINHH.Location = new System.Drawing.Point(556, 24);
            this.NGAYSINHH.Margin = new System.Windows.Forms.Padding(4);
            this.NGAYSINHH.MenuManager = this.barManager1;
            this.NGAYSINHH.Name = "NGAYSINHH";
            this.NGAYSINHH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NGAYSINHH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NGAYSINHH.Size = new System.Drawing.Size(156, 22);
            this.NGAYSINHH.TabIndex = 3;
            // 
            // TENN
            // 
            this.TENN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tacGiaBS, "TEN", true));
            this.TENN.Location = new System.Drawing.Point(152, 24);
            this.TENN.Margin = new System.Windows.Forms.Padding(4);
            this.TENN.MenuManager = this.barManager1;
            this.TENN.Name = "TENN";
            this.TENN.Size = new System.Drawing.Size(156, 22);
            this.TENN.TabIndex = 1;
            // 
            // tACGIAGridControl
            // 
            this.tACGIAGridControl.DataSource = this.tacGiaBS;
            this.tACGIAGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tACGIAGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.tACGIAGridControl.Location = new System.Drawing.Point(0, 59);
            this.tACGIAGridControl.MainView = this.gridView1;
            this.tACGIAGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.tACGIAGridControl.MenuManager = this.barManager1;
            this.tACGIAGridControl.Name = "tACGIAGridControl";
            this.tACGIAGridControl.Size = new System.Drawing.Size(1099, 232);
            this.tACGIAGridControl.TabIndex = 1;
            this.tACGIAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTEN,
            this.colNGAYSINH,
            this.colNGAYMAT,
            this.colQUOCTICH,
            this.colTHOIDAI,
            this.colPHONGCACHCHINH,
            this.colDIENGIAI});
            this.gridView1.GridControl = this.tACGIAGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.ReadOnly = true;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 0;
            this.colTEN.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.ReadOnly = true;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 1;
            this.colNGAYSINH.Width = 94;
            // 
            // colNGAYMAT
            // 
            this.colNGAYMAT.Caption = "Ngày mất";
            this.colNGAYMAT.FieldName = "NGAYMAT";
            this.colNGAYMAT.MinWidth = 25;
            this.colNGAYMAT.Name = "colNGAYMAT";
            this.colNGAYMAT.OptionsColumn.ReadOnly = true;
            this.colNGAYMAT.Visible = true;
            this.colNGAYMAT.VisibleIndex = 2;
            this.colNGAYMAT.Width = 94;
            // 
            // colQUOCTICH
            // 
            this.colQUOCTICH.Caption = "Quốc tịch";
            this.colQUOCTICH.FieldName = "QUOCTICH";
            this.colQUOCTICH.MinWidth = 25;
            this.colQUOCTICH.Name = "colQUOCTICH";
            this.colQUOCTICH.OptionsColumn.ReadOnly = true;
            this.colQUOCTICH.Visible = true;
            this.colQUOCTICH.VisibleIndex = 3;
            this.colQUOCTICH.Width = 94;
            // 
            // colTHOIDAI
            // 
            this.colTHOIDAI.Caption = "Thời đại";
            this.colTHOIDAI.FieldName = "THOIDAI";
            this.colTHOIDAI.MinWidth = 25;
            this.colTHOIDAI.Name = "colTHOIDAI";
            this.colTHOIDAI.OptionsColumn.ReadOnly = true;
            this.colTHOIDAI.Visible = true;
            this.colTHOIDAI.VisibleIndex = 4;
            this.colTHOIDAI.Width = 94;
            // 
            // colPHONGCACHCHINH
            // 
            this.colPHONGCACHCHINH.Caption = "Phong cách chính";
            this.colPHONGCACHCHINH.FieldName = "PHONGCACHCHINH";
            this.colPHONGCACHCHINH.MinWidth = 25;
            this.colPHONGCACHCHINH.Name = "colPHONGCACHCHINH";
            this.colPHONGCACHCHINH.OptionsColumn.ReadOnly = true;
            this.colPHONGCACHCHINH.Visible = true;
            this.colPHONGCACHCHINH.VisibleIndex = 5;
            this.colPHONGCACHCHINH.Width = 94;
            // 
            // colDIENGIAI
            // 
            this.colDIENGIAI.Caption = "Diễn giải";
            this.colDIENGIAI.FieldName = "DIENGIAI";
            this.colDIENGIAI.MinWidth = 25;
            this.colDIENGIAI.Name = "colDIENGIAI";
            this.colDIENGIAI.OptionsColumn.ReadOnly = true;
            this.colDIENGIAI.Visible = true;
            this.colDIENGIAI.VisibleIndex = 6;
            this.colDIENGIAI.Width = 94;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 59);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FormTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormTG";
            this.Text = "Tác giả";
            this.Load += new System.EventHandler(this.FormTG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpntBS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYMATT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYMATT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DIENGIAII.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHONGCACHCHINHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THOIDAII.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUOCTICHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYSINHH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYSINHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TENN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.BindingSource tacGiaBS;
        private BAOTANGDataSet BAOTANGDS;
        private BAOTANGDataSetTableAdapters.TACGIATableAdapter tacGiaTA;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BAOTANGDataSetTableAdapters.TPNTTableAdapter tpntTA;
        private System.Windows.Forms.BindingSource tpntBS;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl tACGIAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMAT;
        private DevExpress.XtraGrid.Columns.GridColumn colQUOCTICH;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIDAI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHONGCACHCHINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIENGIAI;
        private DevExpress.XtraEditors.TextEdit DIENGIAII;
        private DevExpress.XtraEditors.TextEdit PHONGCACHCHINHH;
        private DevExpress.XtraEditors.TextEdit THOIDAII;
        private DevExpress.XtraEditors.TextEdit QUOCTICHH;
        private DevExpress.XtraEditors.DateEdit NGAYSINHH;
        private DevExpress.XtraEditors.TextEdit TENN;
        private DevExpress.XtraEditors.DateEdit NGAYMATT;
    }
}