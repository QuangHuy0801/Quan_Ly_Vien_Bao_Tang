namespace QLVT
{
    partial class FormDiMuon
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
            System.Windows.Forms.Label nGAYTRALabel;
            System.Windows.Forms.Label nGAYMUONLabel;
            System.Windows.Forms.Label tENBSTLabel;
            System.Windows.Forms.Label mATPNTLabel;
            System.Windows.Forms.Label mATPNTLabel1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.MASO = new DevExpress.XtraEditors.TextEdit();
            this.dimuonBS = new System.Windows.Forms.BindingSource(this.components);
            this.BAOTANGDS = new QLVT.BAOTANGDataSet();
            this.NGAYTRADM = new DevExpress.XtraEditors.DateEdit();
            this.NGAYMUONDM = new DevExpress.XtraEditors.DateEdit();
            this.MASODM = new DevExpress.XtraEditors.TextEdit();
            this.OK = new DevExpress.XtraEditors.SimpleButton();
            this.cb_bstdm = new System.Windows.Forms.ComboBox();
            this.tTBOSUUTAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dimuonTA = new QLVT.BAOTANGDataSetTableAdapters.DIMUONTableAdapter();
            this.tableAdapterManager = new QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.tTBOSUUTAPTableAdapter = new QLVT.BAOTANGDataSetTableAdapters.TTBOSUUTAPTableAdapter();
            this.tPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTTableAdapter = new QLVT.BAOTANGDataSetTableAdapters.TPNTTableAdapter();
            nGAYTRALabel = new System.Windows.Forms.Label();
            nGAYMUONLabel = new System.Windows.Forms.Label();
            tENBSTLabel = new System.Windows.Forms.Label();
            mATPNTLabel = new System.Windows.Forms.Label();
            mATPNTLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MASO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimuonBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYTRADM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYTRADM.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYMUONDM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYMUONDM.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MASODM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTBOSUUTAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nGAYTRALabel
            // 
            nGAYTRALabel.AutoSize = true;
            nGAYTRALabel.Location = new System.Drawing.Point(43, 168);
            nGAYTRALabel.Name = "nGAYTRALabel";
            nGAYTRALabel.Size = new System.Drawing.Size(61, 16);
            nGAYTRALabel.TabIndex = 16;
            nGAYTRALabel.Text = "Ngày trả:";
            // 
            // nGAYMUONLabel
            // 
            nGAYMUONLabel.AutoSize = true;
            nGAYMUONLabel.Location = new System.Drawing.Point(43, 124);
            nGAYMUONLabel.Name = "nGAYMUONLabel";
            nGAYMUONLabel.Size = new System.Drawing.Size(79, 16);
            nGAYMUONLabel.TabIndex = 14;
            nGAYMUONLabel.Text = "Ngày mượn:";
            // 
            // tENBSTLabel
            // 
            tENBSTLabel.AutoSize = true;
            tENBSTLabel.Location = new System.Drawing.Point(43, 82);
            tENBSTLabel.Name = "tENBSTLabel";
            tENBSTLabel.Size = new System.Drawing.Size(99, 16);
            tENBSTLabel.TabIndex = 13;
            tENBSTLabel.Text = "Tên bộ sưu tập:";
            // 
            // mATPNTLabel
            // 
            mATPNTLabel.AutoSize = true;
            mATPNTLabel.Location = new System.Drawing.Point(-10, -28);
            mATPNTLabel.Name = "mATPNTLabel";
            mATPNTLabel.Size = new System.Drawing.Size(47, 16);
            mATPNTLabel.TabIndex = 11;
            mATPNTLabel.Text = "Mã số:";
            // 
            // mATPNTLabel1
            // 
            mATPNTLabel1.AutoSize = true;
            mATPNTLabel1.Location = new System.Drawing.Point(43, 43);
            mATPNTLabel1.Name = "mATPNTLabel1";
            mATPNTLabel1.Size = new System.Drawing.Size(47, 16);
            mATPNTLabel1.TabIndex = 19;
            mATPNTLabel1.Text = "Mã số:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(mATPNTLabel1);
            this.panel1.Controls.Add(this.MASO);
            this.panel1.Controls.Add(nGAYTRALabel);
            this.panel1.Controls.Add(this.NGAYTRADM);
            this.panel1.Controls.Add(nGAYMUONLabel);
            this.panel1.Controls.Add(tENBSTLabel);
            this.panel1.Controls.Add(mATPNTLabel);
            this.panel1.Controls.Add(this.NGAYMUONDM);
            this.panel1.Controls.Add(this.MASODM);
            this.panel1.Controls.Add(this.OK);
            this.panel1.Controls.Add(this.cb_bstdm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 278);
            this.panel1.TabIndex = 0;
            // 
            // MASO
            // 
            this.MASO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dimuonBS, "MATPNT", true));
            this.MASO.Location = new System.Drawing.Point(158, 40);
            this.MASO.Name = "MASO";
            this.MASO.Properties.ReadOnly = true;
            this.MASO.Size = new System.Drawing.Size(77, 22);
            this.MASO.TabIndex = 20;
            // 
            // dimuonBS
            // 
            this.dimuonBS.DataMember = "DIMUON";
            this.dimuonBS.DataSource = this.BAOTANGDS;
            // 
            // BAOTANGDS
            // 
            this.BAOTANGDS.DataSetName = "BAOTANGDataSet";
            this.BAOTANGDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NGAYTRADM
            // 
            this.NGAYTRADM.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dimuonBS, "NGAYTRA", true));
            this.NGAYTRADM.EditValue = null;
            this.NGAYTRADM.Location = new System.Drawing.Point(158, 165);
            this.NGAYTRADM.Margin = new System.Windows.Forms.Padding(10);
            this.NGAYTRADM.Name = "NGAYTRADM";
            this.NGAYTRADM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NGAYTRADM.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NGAYTRADM.Size = new System.Drawing.Size(156, 22);
            this.NGAYTRADM.TabIndex = 17;
            // 
            // NGAYMUONDM
            // 
            this.NGAYMUONDM.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dimuonBS, "NGAYMUON", true));
            this.NGAYMUONDM.EditValue = null;
            this.NGAYMUONDM.Location = new System.Drawing.Point(158, 121);
            this.NGAYMUONDM.Margin = new System.Windows.Forms.Padding(10);
            this.NGAYMUONDM.Name = "NGAYMUONDM";
            this.NGAYMUONDM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NGAYMUONDM.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NGAYMUONDM.Size = new System.Drawing.Size(156, 22);
            this.NGAYMUONDM.TabIndex = 15;
            // 
            // MASODM
            // 
            this.MASODM.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dimuonBS, "MATPNT", true));
            this.MASODM.Location = new System.Drawing.Point(185, -23);
            this.MASODM.Margin = new System.Windows.Forms.Padding(10);
            this.MASODM.Name = "MASODM";
            this.MASODM.Properties.ReadOnly = true;
            this.MASODM.Size = new System.Drawing.Size(202, 22);
            this.MASODM.TabIndex = 12;
            // 
            // OK
            // 
            this.OK.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OK.Appearance.Options.UseBackColor = true;
            this.OK.Location = new System.Drawing.Point(114, 217);
            this.OK.Margin = new System.Windows.Forms.Padding(15);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(121, 29);
            this.OK.TabIndex = 19;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click_1);
            // 
            // cb_bstdm
            // 
            this.cb_bstdm.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tTBOSUUTAPBindingSource, "TEN", true));
            this.cb_bstdm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tTBOSUUTAPBindingSource, "TEN", true));
            this.cb_bstdm.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dimuonBS, "TENBST", true));
            this.cb_bstdm.DataSource = this.tTBOSUUTAPBindingSource;
            this.cb_bstdm.DisplayMember = "TEN";
            this.cb_bstdm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_bstdm.FormattingEnabled = true;
            this.cb_bstdm.Location = new System.Drawing.Point(158, 79);
            this.cb_bstdm.Name = "cb_bstdm";
            this.cb_bstdm.Size = new System.Drawing.Size(156, 24);
            this.cb_bstdm.TabIndex = 18;
            this.cb_bstdm.ValueMember = "TEN";
            this.cb_bstdm.SelectedIndexChanged += new System.EventHandler(this.cb_bstdm_SelectedIndexChanged);
            // 
            // tTBOSUUTAPBindingSource
            // 
            this.tTBOSUUTAPBindingSource.DataMember = "TTBOSUUTAP";
            this.tTBOSUUTAPBindingSource.DataSource = this.BAOTANGDS;
            // 
            // dimuonTA
            // 
            this.dimuonTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = null;
            this.tableAdapterManager.CT_TRIENLAMTableAdapter = null;
            this.tableAdapterManager.DIEUKHAC_TACTUONGTableAdapter = null;
            this.tableAdapterManager.DIMUONTableAdapter = this.dimuonTA;
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
            // tTBOSUUTAPTableAdapter
            // 
            this.tTBOSUUTAPTableAdapter.ClearBeforeFill = true;
            // 
            // tPNTBindingSource
            // 
            this.tPNTBindingSource.DataMember = "TPNT";
            this.tPNTBindingSource.DataSource = this.BAOTANGDS;
            // 
            // tPNTTableAdapter
            // 
            this.tPNTTableAdapter.ClearBeforeFill = true;
            // 
            // FormDiMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 278);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDiMuon";
            this.Text = "Đi mượn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDiMuon_FormClosing);
            this.Load += new System.EventHandler(this.FormDiMuon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MASO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimuonBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYTRADM.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYTRADM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYMUONDM.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYMUONDM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MASODM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTBOSUUTAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.DateEdit NGAYTRADM;
        private BAOTANGDataSet BAOTANGDS;
        private DevExpress.XtraEditors.DateEdit NGAYMUONDM;
        private DevExpress.XtraEditors.TextEdit MASODM;
        private DevExpress.XtraEditors.SimpleButton OK;
        private System.Windows.Forms.ComboBox cb_bstdm;
        private System.Windows.Forms.BindingSource tTBOSUUTAPBindingSource;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BAOTANGDataSetTableAdapters.TTBOSUUTAPTableAdapter tTBOSUUTAPTableAdapter;
        public System.Windows.Forms.BindingSource dimuonBS;
        public BAOTANGDataSetTableAdapters.DIMUONTableAdapter dimuonTA;
        private DevExpress.XtraEditors.TextEdit MASO;
        private System.Windows.Forms.BindingSource tPNTBindingSource;
        private BAOTANGDataSetTableAdapters.TPNTTableAdapter tPNTTableAdapter;
    }
}