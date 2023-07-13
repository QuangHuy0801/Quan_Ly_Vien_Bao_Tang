namespace QLVT
{
    partial class FormDieuKhacTacTuong
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
            System.Windows.Forms.Label pHONGCACHLabel;
            System.Windows.Forms.Label kHOILUONGLabel;
            System.Windows.Forms.Label cHIEUCAOLabel;
            System.Windows.Forms.Label vATLIEULabel;
            System.Windows.Forms.Label mASOLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.dIEUKHAC_TACTUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BAOTANGDS = new QLVT.BAOTANGDataSet();
            this.OK = new DevExpress.XtraEditors.SimpleButton();
            this.PHONGCACHDKTT = new DevExpress.XtraEditors.TextEdit();
            this.KHOILUONGDKTT = new DevExpress.XtraEditors.TextEdit();
            this.CHIEUCAODKTT = new DevExpress.XtraEditors.TextEdit();
            this.VATLIEUDKTT = new DevExpress.XtraEditors.TextEdit();
            this.MASODKTT = new DevExpress.XtraEditors.TextEdit();
            this.tableAdapterManager = new QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.dkttBS = new System.Windows.Forms.BindingSource(this.components);
            this.dkttTA = new QLVT.BAOTANGDataSetTableAdapters.DIEUKHAC_TACTUONGTableAdapter();
            this.tPNTTableAdapter = new QLVT.BAOTANGDataSetTableAdapters.TPNTTableAdapter();
            pHONGCACHLabel = new System.Windows.Forms.Label();
            kHOILUONGLabel = new System.Windows.Forms.Label();
            cHIEUCAOLabel = new System.Windows.Forms.Label();
            vATLIEULabel = new System.Windows.Forms.Label();
            mASOLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIEUKHAC_TACTUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHONGCACHDKTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHOILUONGDKTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHIEUCAODKTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATLIEUDKTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MASODKTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkttBS)).BeginInit();
            this.SuspendLayout();
            // 
            // pHONGCACHLabel
            // 
            pHONGCACHLabel.AutoSize = true;
            pHONGCACHLabel.Location = new System.Drawing.Point(45, 213);
            pHONGCACHLabel.Name = "pHONGCACHLabel";
            pHONGCACHLabel.Size = new System.Drawing.Size(81, 16);
            pHONGCACHLabel.TabIndex = 20;
            pHONGCACHLabel.Text = "Phong cách:";
            // 
            // kHOILUONGLabel
            // 
            kHOILUONGLabel.AutoSize = true;
            kHOILUONGLabel.Location = new System.Drawing.Point(45, 167);
            kHOILUONGLabel.Name = "kHOILUONGLabel";
            kHOILUONGLabel.Size = new System.Drawing.Size(72, 16);
            kHOILUONGLabel.TabIndex = 18;
            kHOILUONGLabel.Text = "Khối lượng:";
            // 
            // cHIEUCAOLabel
            // 
            cHIEUCAOLabel.AutoSize = true;
            cHIEUCAOLabel.Location = new System.Drawing.Point(45, 119);
            cHIEUCAOLabel.Name = "cHIEUCAOLabel";
            cHIEUCAOLabel.Size = new System.Drawing.Size(70, 16);
            cHIEUCAOLabel.TabIndex = 16;
            cHIEUCAOLabel.Text = "Chiều cao:";
            // 
            // vATLIEULabel
            // 
            vATLIEULabel.AutoSize = true;
            vATLIEULabel.Location = new System.Drawing.Point(45, 79);
            vATLIEULabel.Name = "vATLIEULabel";
            vATLIEULabel.Size = new System.Drawing.Size(54, 16);
            vATLIEULabel.TabIndex = 13;
            vATLIEULabel.Text = "Vật liệu:";
            // 
            // mASOLabel
            // 
            mASOLabel.AutoSize = true;
            mASOLabel.Location = new System.Drawing.Point(45, 36);
            mASOLabel.Name = "mASOLabel";
            mASOLabel.Size = new System.Drawing.Size(47, 16);
            mASOLabel.TabIndex = 12;
            mASOLabel.Text = "Mã số:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(pHONGCACHLabel);
            this.panel1.Controls.Add(kHOILUONGLabel);
            this.panel1.Controls.Add(cHIEUCAOLabel);
            this.panel1.Controls.Add(vATLIEULabel);
            this.panel1.Controls.Add(mASOLabel);
            this.panel1.Controls.Add(this.OK);
            this.panel1.Controls.Add(this.PHONGCACHDKTT);
            this.panel1.Controls.Add(this.KHOILUONGDKTT);
            this.panel1.Controls.Add(this.CHIEUCAODKTT);
            this.panel1.Controls.Add(this.VATLIEUDKTT);
            this.panel1.Controls.Add(this.MASODKTT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 331);
            this.panel1.TabIndex = 0;
            // 
            // dIEUKHAC_TACTUONGBindingSource
            // 
            this.dIEUKHAC_TACTUONGBindingSource.DataMember = "FK_DIEUKHAC_TACTUONG_TPNT";
            this.dIEUKHAC_TACTUONGBindingSource.DataSource = this.tPNTBindingSource;
            // 
            // tPNTBindingSource
            // 
            this.tPNTBindingSource.DataMember = "TPNT";
            this.tPNTBindingSource.DataSource = this.BAOTANGDS;
            // 
            // BAOTANGDS
            // 
            this.BAOTANGDS.DataSetName = "BAOTANGDataSet";
            this.BAOTANGDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OK
            // 
            this.OK.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OK.Appearance.Options.UseBackColor = true;
            this.OK.Location = new System.Drawing.Point(112, 268);
            this.OK.Margin = new System.Windows.Forms.Padding(15);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(127, 33);
            this.OK.TabIndex = 22;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click_1);
            // 
            // PHONGCACHDKTT
            // 
            this.PHONGCACHDKTT.Location = new System.Drawing.Point(178, 210);
            this.PHONGCACHDKTT.Margin = new System.Windows.Forms.Padding(12);
            this.PHONGCACHDKTT.Name = "PHONGCACHDKTT";
            this.PHONGCACHDKTT.Size = new System.Drawing.Size(131, 22);
            this.PHONGCACHDKTT.TabIndex = 21;
            // 
            // KHOILUONGDKTT
            // 
            this.KHOILUONGDKTT.Location = new System.Drawing.Point(178, 161);
            this.KHOILUONGDKTT.Margin = new System.Windows.Forms.Padding(12);
            this.KHOILUONGDKTT.Name = "KHOILUONGDKTT";
            this.KHOILUONGDKTT.Properties.DisplayFormat.FormatString = "n0";
            this.KHOILUONGDKTT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.KHOILUONGDKTT.Properties.EditFormat.FormatString = "n0";
            this.KHOILUONGDKTT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.KHOILUONGDKTT.Size = new System.Drawing.Size(131, 22);
            this.KHOILUONGDKTT.TabIndex = 19;
            // 
            // CHIEUCAODKTT
            // 
            this.CHIEUCAODKTT.Location = new System.Drawing.Point(178, 116);
            this.CHIEUCAODKTT.Margin = new System.Windows.Forms.Padding(12);
            this.CHIEUCAODKTT.Name = "CHIEUCAODKTT";
            this.CHIEUCAODKTT.Properties.DisplayFormat.FormatString = "n0";
            this.CHIEUCAODKTT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CHIEUCAODKTT.Properties.EditFormat.FormatString = "n0";
            this.CHIEUCAODKTT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CHIEUCAODKTT.Size = new System.Drawing.Size(131, 22);
            this.CHIEUCAODKTT.TabIndex = 17;
            // 
            // VATLIEUDKTT
            // 
            this.VATLIEUDKTT.Location = new System.Drawing.Point(178, 76);
            this.VATLIEUDKTT.Margin = new System.Windows.Forms.Padding(12);
            this.VATLIEUDKTT.Name = "VATLIEUDKTT";
            this.VATLIEUDKTT.Size = new System.Drawing.Size(131, 22);
            this.VATLIEUDKTT.TabIndex = 15;
            // 
            // MASODKTT
            // 
            this.MASODKTT.Location = new System.Drawing.Point(178, 33);
            this.MASODKTT.Margin = new System.Windows.Forms.Padding(12);
            this.MASODKTT.Name = "MASODKTT";
            this.MASODKTT.Properties.ReadOnly = true;
            this.MASODKTT.Size = new System.Drawing.Size(82, 22);
            this.MASODKTT.TabIndex = 14;
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
            // dkttBS
            // 
            this.dkttBS.DataMember = "DIEUKHAC_TACTUONG";
            this.dkttBS.DataSource = this.BAOTANGDS;
            // 
            // dkttTA
            // 
            this.dkttTA.ClearBeforeFill = true;
            // 
            // tPNTTableAdapter
            // 
            this.tPNTTableAdapter.ClearBeforeFill = true;
            // 
            // FormDieuKhacTacTuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 331);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDieuKhacTacTuong";
            this.Text = "Điêu khắc - Tạc tượng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDieuKhacTacTuong_FormClosing);
            this.Load += new System.EventHandler(this.FormDieuKhacTacTuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIEUKHAC_TACTUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHONGCACHDKTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHOILUONGDKTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHIEUCAODKTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATLIEUDKTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MASODKTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkttBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton OK;
        private DevExpress.XtraEditors.TextEdit PHONGCACHDKTT;
        private DevExpress.XtraEditors.TextEdit KHOILUONGDKTT;
        private DevExpress.XtraEditors.TextEdit CHIEUCAODKTT;
        private DevExpress.XtraEditors.TextEdit VATLIEUDKTT;
        private DevExpress.XtraEditors.TextEdit MASODKTT;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BAOTANGDataSet BAOTANGDS;
        private System.Windows.Forms.BindingSource dkttBS;
        private BAOTANGDataSetTableAdapters.DIEUKHAC_TACTUONGTableAdapter dkttTA;
        private System.Windows.Forms.BindingSource tPNTBindingSource;
        private BAOTANGDataSetTableAdapters.TPNTTableAdapter tPNTTableAdapter;
        private System.Windows.Forms.BindingSource dIEUKHAC_TACTUONGBindingSource;
    }
}