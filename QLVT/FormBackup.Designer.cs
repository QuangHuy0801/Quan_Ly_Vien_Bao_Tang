namespace QLVT
{
    partial class FormBackup
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
            this.BACKUP = new DevExpress.XtraEditors.SimpleButton();
            this.backupGridControl = new DevExpress.XtraGrid.GridControl();
            this.BKBS = new System.Windows.Forms.BindingSource(this.components);
            this.BAOTANGDS = new QLVT.BAOTANGDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldatabase_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_finish_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphysical_device_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.historyBK = new DevExpress.XtraEditors.SimpleButton();
            this.labelLS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BKTA = new QLVT.BAOTANGDataSetTableAdapters.BACKUPTableAdapter();
            this.tableAdapterManager = new QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BKBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BACKUP);
            this.panel1.Controls.Add(this.backupGridControl);
            this.panel1.Controls.Add(this.historyBK);
            this.panel1.Controls.Add(this.labelLS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 601);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BACKUP
            // 
            this.BACKUP.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.BACKUP.Appearance.Options.UseBackColor = true;
            this.BACKUP.Location = new System.Drawing.Point(447, 436);
            this.BACKUP.Name = "BACKUP";
            this.BACKUP.Size = new System.Drawing.Size(157, 48);
            this.BACKUP.TabIndex = 4;
            this.BACKUP.Text = "BACKUP";
            this.BACKUP.Click += new System.EventHandler(this.BACKUP_Click);
            // 
            // backupGridControl
            // 
            this.backupGridControl.DataSource = this.BKBS;
            this.backupGridControl.Location = new System.Drawing.Point(3, 187);
            this.backupGridControl.MainView = this.gridView1;
            this.backupGridControl.Name = "backupGridControl";
            this.backupGridControl.Size = new System.Drawing.Size(1052, 220);
            this.backupGridControl.TabIndex = 3;
            this.backupGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.backupGridControl.Visible = false;
            this.backupGridControl.Click += new System.EventHandler(this.backupGridControl_Click);
            // 
            // BKBS
            // 
            this.BKBS.DataMember = "BACKUP";
            this.BKBS.DataSource = this.BAOTANGDS;
            // 
            // BAOTANGDS
            // 
            this.BAOTANGDS.DataSetName = "BAOTANGDataSet";
            this.BAOTANGDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldatabase_name,
            this.colbackup_start_date,
            this.colbackup_finish_date,
            this.colphysical_device_name});
            this.gridView1.GridControl = this.backupGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // coldatabase_name
            // 
            this.coldatabase_name.FieldName = "database_name";
            this.coldatabase_name.MinWidth = 25;
            this.coldatabase_name.Name = "coldatabase_name";
            this.coldatabase_name.OptionsColumn.ReadOnly = true;
            this.coldatabase_name.Visible = true;
            this.coldatabase_name.VisibleIndex = 0;
            this.coldatabase_name.Width = 94;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.DisplayFormat.FormatString = "G";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.MinWidth = 25;
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.OptionsColumn.ReadOnly = true;
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 1;
            this.colbackup_start_date.Width = 94;
            // 
            // colbackup_finish_date
            // 
            this.colbackup_finish_date.DisplayFormat.FormatString = "G";
            this.colbackup_finish_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_finish_date.FieldName = "backup_finish_date";
            this.colbackup_finish_date.MinWidth = 25;
            this.colbackup_finish_date.Name = "colbackup_finish_date";
            this.colbackup_finish_date.OptionsColumn.ReadOnly = true;
            this.colbackup_finish_date.Visible = true;
            this.colbackup_finish_date.VisibleIndex = 2;
            this.colbackup_finish_date.Width = 94;
            // 
            // colphysical_device_name
            // 
            this.colphysical_device_name.FieldName = "physical_device_name";
            this.colphysical_device_name.MinWidth = 25;
            this.colphysical_device_name.Name = "colphysical_device_name";
            this.colphysical_device_name.OptionsColumn.ReadOnly = true;
            this.colphysical_device_name.Visible = true;
            this.colphysical_device_name.VisibleIndex = 3;
            this.colphysical_device_name.Width = 94;
            // 
            // historyBK
            // 
            this.historyBK.Location = new System.Drawing.Point(471, 139);
            this.historyBK.Name = "historyBK";
            this.historyBK.Size = new System.Drawing.Size(94, 29);
            this.historyBK.TabIndex = 2;
            this.historyBK.Text = "Xem lịch sử";
            this.historyBK.Click += new System.EventHandler(this.historyBK_Click);
            // 
            // labelLS
            // 
            this.labelLS.AutoSize = true;
            this.labelLS.Location = new System.Drawing.Point(389, 101);
            this.labelLS.Name = "labelLS";
            this.labelLS.Size = new System.Drawing.Size(265, 16);
            this.labelLS.TabIndex = 1;
            this.labelLS.Text = "(Lịch sử gần nhất: Chưa có bản backup nào)";
            this.labelLS.Click += new System.EventHandler(this.labelLS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BACKUP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BKTA
            // 
            this.BKTA.ClearBeforeFill = true;
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
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 601);
            this.Controls.Add(this.panel1);
            this.Name = "FormBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.FormBackup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BKBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLS;
        private DevExpress.XtraEditors.SimpleButton historyBK;
        private BAOTANGDataSet BAOTANGDS;
        private System.Windows.Forms.BindingSource BKBS;
        private BAOTANGDataSetTableAdapters.BACKUPTableAdapter BKTA;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl backupGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coldatabase_name;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_finish_date;
        private DevExpress.XtraGrid.Columns.GridColumn colphysical_device_name;
        private DevExpress.XtraEditors.SimpleButton BACKUP;
    }
}