namespace QLVT
{
    partial class FormTaiKhoan
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label loginnameLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBS = new System.Windows.Forms.BindingSource(this.components);
            this.userBS = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienBS = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANDataSet1 = new QLVT.TAIKHOANDataSet1();
            this.GROUPP = new System.Windows.Forms.ComboBox();
            this.PASSWORD = new DevExpress.XtraEditors.TextEdit();
            this.loginBS = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.LOGINNAME = new DevExpress.XtraEditors.TextEdit();
            this.loginnameOld = new DevExpress.XtraEditors.TextEdit();
            this.MANV = new System.Windows.Forms.TextBox();
            this.passLabel = new DevExpress.XtraEditors.LabelControl();
            this.nHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableAdapterManager1 = new QLVT.TAIKHOANDataSet1TableAdapters.TableAdapterManager();
            this.tableAdapterManager = new QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.repositoryItemTimeEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.nhanvienTA = new QLVT.TAIKHOANDataSet1TableAdapters.NHANVIENTableAdapter();
            this.userTA = new QLVT.TAIKHOANDataSet1TableAdapters.USERTableAdapter();
            this.groupTA = new QLVT.TAIKHOANDataSet1TableAdapters.GROUPTableAdapter();
            this.loginTA = new QLVT.TAIKHOANDataSet1TableAdapters.LOGINTableAdapter();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            loginnameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PASSWORD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGINNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginnameOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(570, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 25);
            label1.TabIndex = 3;
            label1.Text = "Tài khoản";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(396, 53);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 16);
            label2.TabIndex = 22;
            label2.Text = "Mã nhân viên:";
            // 
            // loginnameLabel
            // 
            loginnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            loginnameLabel.AutoSize = true;
            loginnameLabel.Location = new System.Drawing.Point(405, 193);
            loginnameLabel.Name = "loginnameLabel";
            loginnameLabel.Size = new System.Drawing.Size(80, 16);
            loginnameLabel.TabIndex = 15;
            loginnameLabel.Text = "Login name:";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(436, 118);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 16);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Quyền:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.nHANVIENGridControl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 618);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.GROUPP);
            this.panel3.Controls.Add(this.PASSWORD);
            this.panel3.Controls.Add(this.LOGINNAME);
            this.panel3.Controls.Add(this.loginnameOld);
            this.panel3.Controls.Add(this.MANV);
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(this.passLabel);
            this.panel3.Controls.Add(loginnameLabel);
            this.panel3.Controls.Add(nameLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(0, 279);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 339);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBS, "name", true));
            this.comboBox1.DataSource = this.groupBS;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(581, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 24);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.ValueMember = "name";
            // 
            // groupBS
            // 
            this.groupBS.DataMember = "USER_GROUP";
            this.groupBS.DataSource = this.userBS;
            // 
            // userBS
            // 
            this.userBS.DataMember = "NHANVIEN_USER";
            this.userBS.DataSource = this.nhanvienBS;
            // 
            // nhanvienBS
            // 
            this.nhanvienBS.DataMember = "NHANVIEN";
            this.nhanvienBS.DataSource = this.tAIKHOANDataSet1;
            // 
            // tAIKHOANDataSet1
            // 
            this.tAIKHOANDataSet1.DataSetName = "TAIKHOANDataSet1";
            this.tAIKHOANDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GROUPP
            // 
            this.GROUPP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GROUPP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBS, "name", true));
            this.GROUPP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupBS, "name", true));
            this.GROUPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GROUPP.FormattingEnabled = true;
            this.GROUPP.Location = new System.Drawing.Point(581, 118);
            this.GROUPP.Name = "GROUPP";
            this.GROUPP.Size = new System.Drawing.Size(125, 24);
            this.GROUPP.TabIndex = 27;
            // 
            // PASSWORD
            // 
            this.PASSWORD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PASSWORD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginBS, "password", true));
            this.PASSWORD.Location = new System.Drawing.Point(581, 260);
            this.PASSWORD.MenuManager = this.barManager1;
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Properties.PasswordChar = '*';
            this.PASSWORD.Properties.UseSystemPasswordChar = true;
            this.PASSWORD.Size = new System.Drawing.Size(125, 22);
            this.PASSWORD.TabIndex = 26;
            this.PASSWORD.Visible = false;
            // 
            // loginBS
            // 
            this.loginBS.DataMember = "USER_LOGIN";
            this.loginBS.DataSource = this.userBS;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Tạo tài khoản";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa tài khoản";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Đổi mật khẩu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1100, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 648);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1100, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 618);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1100, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 618);
            // 
            // LOGINNAME
            // 
            this.LOGINNAME.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LOGINNAME.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginBS, "loginname", true));
            this.LOGINNAME.Location = new System.Drawing.Point(581, 192);
            this.LOGINNAME.MenuManager = this.barManager1;
            this.LOGINNAME.Name = "LOGINNAME";
            this.LOGINNAME.Size = new System.Drawing.Size(125, 22);
            this.LOGINNAME.TabIndex = 25;
            // 
            // loginnameOld
            // 
            this.loginnameOld.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginnameOld.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginBS, "loginname", true));
            this.loginnameOld.Location = new System.Drawing.Point(581, 164);
            this.loginnameOld.MenuManager = this.barManager1;
            this.loginnameOld.Name = "loginnameOld";
            this.loginnameOld.Properties.ReadOnly = true;
            this.loginnameOld.Size = new System.Drawing.Size(125, 22);
            this.loginnameOld.TabIndex = 24;
            this.loginnameOld.Visible = false;
            this.loginnameOld.EditValueChanged += new System.EventHandler(this.loginnameTextEdit_EditValueChanged);
            // 
            // MANV
            // 
            this.MANV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBS, "MANV", true));
            this.MANV.Enabled = false;
            this.MANV.Location = new System.Drawing.Point(581, 53);
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            this.MANV.Size = new System.Drawing.Size(100, 22);
            this.MANV.TabIndex = 23;
            // 
            // passLabel
            // 
            this.passLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passLabel.Location = new System.Drawing.Point(425, 266);
            this.passLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(60, 16);
            this.passLabel.TabIndex = 20;
            this.passLabel.Text = "Password:";
            this.passLabel.Visible = false;
            // 
            // nHANVIENGridControl
            // 
            this.nHANVIENGridControl.DataSource = this.nhanvienBS;
            this.nHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nHANVIENGridControl.Location = new System.Drawing.Point(0, 59);
            this.nHANVIENGridControl.MainView = this.gridView1;
            this.nHANVIENGridControl.MenuManager = this.barManager1;
            this.nHANVIENGridControl.Name = "nHANVIENGridControl";
            this.nHANVIENGridControl.Size = new System.Drawing.Size(1100, 220);
            this.nHANVIENGridControl.TabIndex = 1;
            this.nHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colSOCMND,
            this.colDIACHI,
            this.colNGAYSINH});
            this.gridView1.GridControl = this.nHANVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.ReadOnly = true;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.ReadOnly = true;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.ReadOnly = true;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colSOCMND
            // 
            this.colSOCMND.Caption = "Số CMND";
            this.colSOCMND.FieldName = "SOCMND";
            this.colSOCMND.MinWidth = 25;
            this.colSOCMND.Name = "colSOCMND";
            this.colSOCMND.OptionsColumn.ReadOnly = true;
            this.colSOCMND.Visible = true;
            this.colSOCMND.VisibleIndex = 3;
            this.colSOCMND.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.ReadOnly = true;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.ReadOnly = true;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 94;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 59);
            this.panel2.TabIndex = 0;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.NHANVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLVT.TAIKHOANDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_TRIENLAMTableAdapter = null;
            this.tableAdapterManager.DIEUKHAC_TACTUONGTableAdapter = null;
            this.tableAdapterManager.DIMUONTableAdapter = null;
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
            // repositoryItemTimeEdit7
            // 
            this.repositoryItemTimeEdit7.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit7.Name = "repositoryItemTimeEdit7";
            // 
            // nhanvienTA
            // 
            this.nhanvienTA.ClearBeforeFill = true;
            // 
            // userTA
            // 
            this.userTA.ClearBeforeFill = true;
            // 
            // groupTA
            // 
            this.groupTA.ClearBeforeFill = true;
            // 
            // loginTA
            // 
            this.loginTA.ClearBeforeFill = true;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormTaiKhoan";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PASSWORD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGINNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginnameOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private TAIKHOANDataSet1 tAIKHOANDataSet1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl nHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private System.Windows.Forms.Panel panel2;
        private TAIKHOANDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit7;
        private TAIKHOANDataSet1TableAdapters.NHANVIENTableAdapter nhanvienTA;
        private TAIKHOANDataSet1TableAdapters.USERTableAdapter userTA;
        private TAIKHOANDataSet1TableAdapters.GROUPTableAdapter groupTA;
        private TAIKHOANDataSet1TableAdapters.LOGINTableAdapter loginTA;
        private System.Windows.Forms.BindingSource nhanvienBS;
        private DevExpress.XtraEditors.LabelControl passLabel;
        private System.Windows.Forms.TextBox MANV;
        private System.Windows.Forms.BindingSource userBS;
        private System.Windows.Forms.BindingSource loginBS;
        private System.Windows.Forms.BindingSource groupBS;
        private DevExpress.XtraEditors.TextEdit LOGINNAME;
        private DevExpress.XtraEditors.TextEdit loginnameOld;
        private DevExpress.XtraEditors.TextEdit PASSWORD;
        private System.Windows.Forms.ComboBox GROUPP;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}