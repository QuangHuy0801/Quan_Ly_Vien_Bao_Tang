namespace QLVT
{
    partial class FormLoaiHinhKhac
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
            System.Windows.Forms.Label tHELOAILabel;
            System.Windows.Forms.Label mASOLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.OK = new DevExpress.XtraEditors.SimpleButton();
            this.PHONGCACHLHK = new DevExpress.XtraEditors.TextEdit();
            this.lOAIHINHKHACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BAOTANGDS = new QLVT.BAOTANGDataSet();
            this.THELOAILHK = new DevExpress.XtraEditors.TextEdit();
            this.MASOLHK = new DevExpress.XtraEditors.TextEdit();
            this.lOAIHINHKHACTableAdapter = new QLVT.BAOTANGDataSetTableAdapters.LOAIHINHKHACTableAdapter();
            this.tableAdapterManager = new QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.tPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTTableAdapter = new QLVT.BAOTANGDataSetTableAdapters.TPNTTableAdapter();
            this.lOAIHINHKHACBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            pHONGCACHLabel = new System.Windows.Forms.Label();
            tHELOAILabel = new System.Windows.Forms.Label();
            mASOLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PHONGCACHLHK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHINHKHACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THELOAILHK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MASOLHK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHINHKHACBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pHONGCACHLabel
            // 
            pHONGCACHLabel.AutoSize = true;
            pHONGCACHLabel.Location = new System.Drawing.Point(23, 134);
            pHONGCACHLabel.Name = "pHONGCACHLabel";
            pHONGCACHLabel.Size = new System.Drawing.Size(81, 16);
            pHONGCACHLabel.TabIndex = 14;
            pHONGCACHLabel.Text = "Phong cách:";
            // 
            // tHELOAILabel
            // 
            tHELOAILabel.AutoSize = true;
            tHELOAILabel.Location = new System.Drawing.Point(23, 84);
            tHELOAILabel.Name = "tHELOAILabel";
            tHELOAILabel.Size = new System.Drawing.Size(59, 16);
            tHELOAILabel.TabIndex = 11;
            tHELOAILabel.Text = "Thể loại:";
            // 
            // mASOLabel
            // 
            mASOLabel.AutoSize = true;
            mASOLabel.Location = new System.Drawing.Point(23, 34);
            mASOLabel.Name = "mASOLabel";
            mASOLabel.Size = new System.Drawing.Size(47, 16);
            mASOLabel.TabIndex = 10;
            mASOLabel.Text = "Mã số:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(pHONGCACHLabel);
            this.panel1.Controls.Add(tHELOAILabel);
            this.panel1.Controls.Add(mASOLabel);
            this.panel1.Controls.Add(this.OK);
            this.panel1.Controls.Add(this.PHONGCACHLHK);
            this.panel1.Controls.Add(this.THELOAILHK);
            this.panel1.Controls.Add(this.MASOLHK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 273);
            this.panel1.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OK.Appearance.Options.UseBackColor = true;
            this.OK.Location = new System.Drawing.Point(150, 193);
            this.OK.Margin = new System.Windows.Forms.Padding(12);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(107, 28);
            this.OK.TabIndex = 16;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click_1);
            // 
            // PHONGCACHLHK
            // 
            this.PHONGCACHLHK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAIHINHKHACBindingSource, "PHONGCACH", true));
            this.PHONGCACHLHK.Location = new System.Drawing.Point(183, 131);
            this.PHONGCACHLHK.Margin = new System.Windows.Forms.Padding(6);
            this.PHONGCACHLHK.Name = "PHONGCACHLHK";
            this.PHONGCACHLHK.Size = new System.Drawing.Size(166, 22);
            this.PHONGCACHLHK.TabIndex = 15;
            // 
            // lOAIHINHKHACBindingSource
            // 
            this.lOAIHINHKHACBindingSource.DataMember = "LOAIHINHKHAC";
            this.lOAIHINHKHACBindingSource.DataSource = this.BAOTANGDS;
            // 
            // BAOTANGDS
            // 
            this.BAOTANGDS.DataSetName = "BAOTANGDS";
            this.BAOTANGDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // THELOAILHK
            // 
            this.THELOAILHK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAIHINHKHACBindingSource, "THELOAI", true));
            this.THELOAILHK.Location = new System.Drawing.Point(183, 78);
            this.THELOAILHK.Margin = new System.Windows.Forms.Padding(6);
            this.THELOAILHK.Name = "THELOAILHK";
            this.THELOAILHK.Size = new System.Drawing.Size(166, 22);
            this.THELOAILHK.TabIndex = 13;
            // 
            // MASOLHK
            // 
            this.MASOLHK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAIHINHKHACBindingSource, "MASO", true));
            this.MASOLHK.Location = new System.Drawing.Point(183, 28);
            this.MASOLHK.Margin = new System.Windows.Forms.Padding(6);
            this.MASOLHK.Name = "MASOLHK";
            this.MASOLHK.Properties.ReadOnly = true;
            this.MASOLHK.Size = new System.Drawing.Size(74, 22);
            this.MASOLHK.TabIndex = 12;
            // 
            // lOAIHINHKHACTableAdapter
            // 
            this.lOAIHINHKHACTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = null;
            this.tableAdapterManager.CT_TRIENLAMTableAdapter = null;
            this.tableAdapterManager.DIEUKHAC_TACTUONGTableAdapter = null;
            this.tableAdapterManager.DIMUONTableAdapter = null;
            this.tableAdapterManager.HOIHOATableAdapter = null;
            this.tableAdapterManager.LOAIHINHKHACTableAdapter = this.lOAIHINHKHACTableAdapter;
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
            // lOAIHINHKHACBindingSource1
            // 
            this.lOAIHINHKHACBindingSource1.DataMember = "FK_LOAIHINHKHAC_TPNT";
            this.lOAIHINHKHACBindingSource1.DataSource = this.tPNTBindingSource;
            // 
            // FormLoaiHinhKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 273);
            this.Controls.Add(this.panel1);
            this.Name = "FormLoaiHinhKhac";
            this.Text = "Loại hình khác";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoaiHinhKhac_FormClosing);
            this.Load += new System.EventHandler(this.FormLoaiHinhKhac_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PHONGCACHLHK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHINHKHACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THELOAILHK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MASOLHK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHINHKHACBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton OK;
        private DevExpress.XtraEditors.TextEdit PHONGCACHLHK;
        private System.Windows.Forms.BindingSource lOAIHINHKHACBindingSource;
        private BAOTANGDataSet BAOTANGDS;
        private DevExpress.XtraEditors.TextEdit THELOAILHK;
        private DevExpress.XtraEditors.TextEdit MASOLHK;
        private BAOTANGDataSetTableAdapters.LOAIHINHKHACTableAdapter lOAIHINHKHACTableAdapter;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tPNTBindingSource;
        private BAOTANGDataSetTableAdapters.TPNTTableAdapter tPNTTableAdapter;
        private System.Windows.Forms.BindingSource lOAIHINHKHACBindingSource1;
    }
}