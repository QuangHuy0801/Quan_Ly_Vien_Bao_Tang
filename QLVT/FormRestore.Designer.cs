namespace QLVT
{
    partial class FormRestore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.restoreGridControl = new DevExpress.XtraGrid.GridControl();
            this.RSBS = new System.Windows.Forms.BindingSource(this.components);
            this.BAOTANGDS = new QLVT.BAOTANGDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colrestore_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldestination_database_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESTORE = new DevExpress.XtraEditors.SimpleButton();
            this.historyRS = new DevExpress.XtraEditors.SimpleButton();
            this.labelLS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RSTA = new QLVT.BAOTANGDataSetTableAdapters.RESTORETableAdapter();
            this.tableAdapterManager = new QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restoreGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.restoreGridControl);
            this.panel1.Controls.Add(this.RESTORE);
            this.panel1.Controls.Add(this.historyRS);
            this.panel1.Controls.Add(this.labelLS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 519);
            this.panel1.TabIndex = 1;
            // 
            // restoreGridControl
            // 
            this.restoreGridControl.DataSource = this.RSBS;
            this.restoreGridControl.Location = new System.Drawing.Point(0, 187);
            this.restoreGridControl.MainView = this.gridView1;
            this.restoreGridControl.Name = "restoreGridControl";
            this.restoreGridControl.Size = new System.Drawing.Size(1052, 220);
            this.restoreGridControl.TabIndex = 4;
            this.restoreGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.restoreGridControl.Visible = false;
            // 
            // RSBS
            // 
            this.RSBS.DataMember = "RESTORE";
            this.RSBS.DataSource = this.BAOTANGDS;
            // 
            // BAOTANGDS
            // 
            this.BAOTANGDS.DataSetName = "BAOTANGDataSet";
            this.BAOTANGDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colrestore_date,
            this.coldestination_database_name,
            this.coluser_name});
            this.gridView1.GridControl = this.restoreGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colrestore_date
            // 
            this.colrestore_date.DisplayFormat.FormatString = "G";
            this.colrestore_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colrestore_date.FieldName = "restore_date";
            this.colrestore_date.MinWidth = 25;
            this.colrestore_date.Name = "colrestore_date";
            this.colrestore_date.OptionsColumn.ReadOnly = true;
            this.colrestore_date.Visible = true;
            this.colrestore_date.VisibleIndex = 0;
            this.colrestore_date.Width = 94;
            // 
            // coldestination_database_name
            // 
            this.coldestination_database_name.FieldName = "destination_database_name";
            this.coldestination_database_name.MinWidth = 25;
            this.coldestination_database_name.Name = "coldestination_database_name";
            this.coldestination_database_name.OptionsColumn.ReadOnly = true;
            this.coldestination_database_name.Visible = true;
            this.coldestination_database_name.VisibleIndex = 1;
            this.coldestination_database_name.Width = 94;
            // 
            // coluser_name
            // 
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.MinWidth = 25;
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.OptionsColumn.ReadOnly = true;
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 2;
            this.coluser_name.Width = 94;
            // 
            // RESTORE
            // 
            this.RESTORE.Appearance.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.RESTORE.Appearance.Options.UseBackColor = true;
            this.RESTORE.Location = new System.Drawing.Point(447, 436);
            this.RESTORE.Name = "RESTORE";
            this.RESTORE.Size = new System.Drawing.Size(157, 48);
            this.RESTORE.TabIndex = 4;
            this.RESTORE.Text = "RESTORE";
            this.RESTORE.Click += new System.EventHandler(this.RESTORE_Click);
            // 
            // historyRS
            // 
            this.historyRS.Location = new System.Drawing.Point(471, 139);
            this.historyRS.Name = "historyRS";
            this.historyRS.Size = new System.Drawing.Size(94, 29);
            this.historyRS.TabIndex = 2;
            this.historyRS.Text = "Xem lịch sử";
            this.historyRS.Click += new System.EventHandler(this.historyRS_Click);
            // 
            // labelLS
            // 
            this.labelLS.AutoSize = true;
            this.labelLS.Location = new System.Drawing.Point(390, 101);
            this.labelLS.Name = "labelLS";
            this.labelLS.Size = new System.Drawing.Size(262, 16);
            this.labelLS.TabIndex = 1;
            this.labelLS.Text = "(Lịch sử gần nhất: Chưa có bản restore nào)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESTORE";
            // 
            // RSTA
            // 
            this.RSTA.ClearBeforeFill = true;
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
            // FormRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 519);
            this.Controls.Add(this.panel1);
            this.Name = "FormRestore";
            this.Text = "Restore";
            this.Load += new System.EventHandler(this.FormRestore_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restoreGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton RESTORE;
        private DevExpress.XtraEditors.SimpleButton historyRS;
        private System.Windows.Forms.Label labelLS;
        private System.Windows.Forms.Label label1;
        private BAOTANGDataSet BAOTANGDS;
        private System.Windows.Forms.BindingSource RSBS;
        private BAOTANGDataSetTableAdapters.RESTORETableAdapter RSTA;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl restoreGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colrestore_date;
        private DevExpress.XtraGrid.Columns.GridColumn coldestination_database_name;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
    }
}