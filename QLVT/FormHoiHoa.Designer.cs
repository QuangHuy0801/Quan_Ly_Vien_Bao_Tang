namespace QLVT
{
    partial class FormHoiHoa
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
            System.Windows.Forms.Label tRUONGPHAILabel;
            System.Windows.Forms.Label vATLIEULabel;
            System.Windows.Forms.Label cHATLIEULabel;
            System.Windows.Forms.Label mASOLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.TRUONGPHAIHH = new DevExpress.XtraEditors.TextEdit();
            this.hOIHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BAOTANGDS = new QLVT.BAOTANGDataSet();
            this.VATLIEUHH = new DevExpress.XtraEditors.TextEdit();
            this.CHATLIEUHH = new DevExpress.XtraEditors.TextEdit();
            this.MASOHH = new DevExpress.XtraEditors.TextEdit();
            this.OK = new DevExpress.XtraEditors.SimpleButton();
            this.hOIHOATableAdapter = new QLVT.BAOTANGDataSetTableAdapters.HOIHOATableAdapter();
            this.tableAdapterManager = new QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.tPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTTableAdapter = new QLVT.BAOTANGDataSetTableAdapters.TPNTTableAdapter();
            this.hOIHOABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            tRUONGPHAILabel = new System.Windows.Forms.Label();
            vATLIEULabel = new System.Windows.Forms.Label();
            cHATLIEULabel = new System.Windows.Forms.Label();
            mASOLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRUONGPHAIHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOIHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATLIEUHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHATLIEUHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MASOHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOIHOABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tRUONGPHAILabel
            // 
            tRUONGPHAILabel.AutoSize = true;
            tRUONGPHAILabel.Location = new System.Drawing.Point(20, 213);
            tRUONGPHAILabel.Name = "tRUONGPHAILabel";
            tRUONGPHAILabel.Size = new System.Drawing.Size(82, 16);
            tRUONGPHAILabel.TabIndex = 16;
            tRUONGPHAILabel.Text = "Trường phái:";
            // 
            // vATLIEULabel
            // 
            vATLIEULabel.AutoSize = true;
            vATLIEULabel.Location = new System.Drawing.Point(20, 151);
            vATLIEULabel.Name = "vATLIEULabel";
            vATLIEULabel.Size = new System.Drawing.Size(54, 16);
            vATLIEULabel.TabIndex = 14;
            vATLIEULabel.Text = "Vật liệu:";
            // 
            // cHATLIEULabel
            // 
            cHATLIEULabel.AutoSize = true;
            cHATLIEULabel.Location = new System.Drawing.Point(20, 87);
            cHATLIEULabel.Name = "cHATLIEULabel";
            cHATLIEULabel.Size = new System.Drawing.Size(61, 16);
            cHATLIEULabel.TabIndex = 11;
            cHATLIEULabel.Text = "Chất liệu:";
            // 
            // mASOLabel
            // 
            mASOLabel.AutoSize = true;
            mASOLabel.Location = new System.Drawing.Point(20, 24);
            mASOLabel.Name = "mASOLabel";
            mASOLabel.Size = new System.Drawing.Size(47, 16);
            mASOLabel.TabIndex = 10;
            mASOLabel.Text = "Mã số:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(tRUONGPHAILabel);
            this.panel1.Controls.Add(this.TRUONGPHAIHH);
            this.panel1.Controls.Add(vATLIEULabel);
            this.panel1.Controls.Add(this.VATLIEUHH);
            this.panel1.Controls.Add(cHATLIEULabel);
            this.panel1.Controls.Add(this.CHATLIEUHH);
            this.panel1.Controls.Add(mASOLabel);
            this.panel1.Controls.Add(this.MASOHH);
            this.panel1.Controls.Add(this.OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 333);
            this.panel1.TabIndex = 0;
            // 
            // TRUONGPHAIHH
            // 
            this.TRUONGPHAIHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOIHOABindingSource, "TRUONGPHAI", true));
            this.TRUONGPHAIHH.Location = new System.Drawing.Point(129, 210);
            this.TRUONGPHAIHH.Margin = new System.Windows.Forms.Padding(24);
            this.TRUONGPHAIHH.Name = "TRUONGPHAIHH";
            this.TRUONGPHAIHH.Size = new System.Drawing.Size(157, 22);
            this.TRUONGPHAIHH.TabIndex = 17;
            // 
            // hOIHOABindingSource
            // 
            this.hOIHOABindingSource.DataMember = "HOIHOA";
            this.hOIHOABindingSource.DataSource = this.BAOTANGDS;
            // 
            // BAOTANGDS
            // 
            this.BAOTANGDS.DataSetName = "BAOTANGDataSet";
            this.BAOTANGDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VATLIEUHH
            // 
            this.VATLIEUHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOIHOABindingSource, "VATLIEU", true));
            this.VATLIEUHH.Location = new System.Drawing.Point(128, 145);
            this.VATLIEUHH.Margin = new System.Windows.Forms.Padding(24);
            this.VATLIEUHH.Name = "VATLIEUHH";
            this.VATLIEUHH.Size = new System.Drawing.Size(158, 22);
            this.VATLIEUHH.TabIndex = 15;
            // 
            // CHATLIEUHH
            // 
            this.CHATLIEUHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOIHOABindingSource, "CHATLIEU", true));
            this.CHATLIEUHH.Location = new System.Drawing.Point(128, 84);
            this.CHATLIEUHH.Margin = new System.Windows.Forms.Padding(24);
            this.CHATLIEUHH.Name = "CHATLIEUHH";
            this.CHATLIEUHH.Size = new System.Drawing.Size(158, 22);
            this.CHATLIEUHH.TabIndex = 13;
            // 
            // MASOHH
            // 
            this.MASOHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOIHOABindingSource, "MASO", true));
            this.MASOHH.Location = new System.Drawing.Point(128, 21);
            this.MASOHH.Margin = new System.Windows.Forms.Padding(24);
            this.MASOHH.Name = "MASOHH";
            this.MASOHH.Properties.ReadOnly = true;
            this.MASOHH.Size = new System.Drawing.Size(100, 22);
            this.MASOHH.TabIndex = 12;
            // 
            // OK
            // 
            this.OK.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OK.Appearance.Options.UseBackColor = true;
            this.OK.Location = new System.Drawing.Point(108, 275);
            this.OK.Margin = new System.Windows.Forms.Padding(15);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(120, 34);
            this.OK.TabIndex = 18;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click_1);
            // 
            // hOIHOATableAdapter
            // 
            this.hOIHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = null;
            this.tableAdapterManager.CT_TRIENLAMTableAdapter = null;
            this.tableAdapterManager.DIEUKHAC_TACTUONGTableAdapter = null;
            this.tableAdapterManager.DIMUONTableAdapter = null;
            this.tableAdapterManager.HOIHOATableAdapter = this.hOIHOATableAdapter;
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
            // tPNTBindingSource
            // 
            this.tPNTBindingSource.DataMember = "TPNT";
            this.tPNTBindingSource.DataSource = this.BAOTANGDS;
            // 
            // tPNTTableAdapter
            // 
            this.tPNTTableAdapter.ClearBeforeFill = true;
            // 
            // hOIHOABindingSource1
            // 
            this.hOIHOABindingSource1.DataMember = "TPNT_HOIHOA";
            this.hOIHOABindingSource1.DataSource = this.tPNTBindingSource;
            // 
            // FormHoiHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 333);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormHoiHoa";
            this.Text = "Hội họa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHoiHoa_FormClosing);
            this.Load += new System.EventHandler(this.FormHoiHoa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRUONGPHAIHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOIHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATLIEUHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHATLIEUHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MASOHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOIHOABindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit TRUONGPHAIHH;
        private System.Windows.Forms.BindingSource hOIHOABindingSource;
        private BAOTANGDataSet BAOTANGDS;
        private DevExpress.XtraEditors.TextEdit VATLIEUHH;
        private DevExpress.XtraEditors.TextEdit CHATLIEUHH;
        private DevExpress.XtraEditors.TextEdit MASOHH;
        private DevExpress.XtraEditors.SimpleButton OK;
        private BAOTANGDataSetTableAdapters.HOIHOATableAdapter hOIHOATableAdapter;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tPNTBindingSource;
        private BAOTANGDataSetTableAdapters.TPNTTableAdapter tPNTTableAdapter;
        private System.Windows.Forms.BindingSource hOIHOABindingSource1;
    }
}