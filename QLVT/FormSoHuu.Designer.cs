namespace QLVT
{
    partial class FormSoHuu
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
            System.Windows.Forms.Label mASOLabel;
            System.Windows.Forms.Label nGAYSOHUULabel;
            System.Windows.Forms.Label tINHTRANGLabel;
            System.Windows.Forms.Label tRIGIALabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.OK = new System.Windows.Forms.Button();
            this.TRIGIASH = new DevExpress.XtraEditors.TextEdit();
            this.sOHUUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BAOTANGDS = new QLVT.BAOTANGDataSet();
            this.TINHTRANGSH = new DevExpress.XtraEditors.TextEdit();
            this.NGAYSH = new DevExpress.XtraEditors.DateEdit();
            this.MASOSH = new DevExpress.XtraEditors.TextEdit();
            this.sOHUUTableAdapter = new QLVT.BAOTANGDataSetTableAdapters.SOHUUTableAdapter();
            this.tableAdapterManager = new QLVT.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.tPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTTableAdapter = new QLVT.BAOTANGDataSetTableAdapters.TPNTTableAdapter();
            this.sOHUUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            mASOLabel = new System.Windows.Forms.Label();
            nGAYSOHUULabel = new System.Windows.Forms.Label();
            tINHTRANGLabel = new System.Windows.Forms.Label();
            tRIGIALabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRIGIASH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOHUUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TINHTRANGSH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYSH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYSH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MASOSH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOHUUBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mASOLabel
            // 
            mASOLabel.AutoSize = true;
            mASOLabel.Location = new System.Drawing.Point(28, 41);
            mASOLabel.Name = "mASOLabel";
            mASOLabel.Size = new System.Drawing.Size(47, 16);
            mASOLabel.TabIndex = 0;
            mASOLabel.Text = "Mã số:";
            // 
            // nGAYSOHUULabel
            // 
            nGAYSOHUULabel.AutoSize = true;
            nGAYSOHUULabel.Location = new System.Drawing.Point(28, 87);
            nGAYSOHUULabel.Name = "nGAYSOHUULabel";
            nGAYSOHUULabel.Size = new System.Drawing.Size(85, 16);
            nGAYSOHUULabel.TabIndex = 2;
            nGAYSOHUULabel.Text = "Ngày sở hữu:";
            // 
            // tINHTRANGLabel
            // 
            tINHTRANGLabel.AutoSize = true;
            tINHTRANGLabel.Location = new System.Drawing.Point(28, 139);
            tINHTRANGLabel.Name = "tINHTRANGLabel";
            tINHTRANGLabel.Size = new System.Drawing.Size(66, 16);
            tINHTRANGLabel.TabIndex = 4;
            tINHTRANGLabel.Text = "Tình trạng";
            // 
            // tRIGIALabel
            // 
            tRIGIALabel.AutoSize = true;
            tRIGIALabel.Location = new System.Drawing.Point(28, 189);
            tRIGIALabel.Name = "tRIGIALabel";
            tRIGIALabel.Size = new System.Drawing.Size(48, 16);
            tRIGIALabel.TabIndex = 6;
            tRIGIALabel.Text = "Trị giá:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OK);
            this.panel1.Controls.Add(tRIGIALabel);
            this.panel1.Controls.Add(this.TRIGIASH);
            this.panel1.Controls.Add(tINHTRANGLabel);
            this.panel1.Controls.Add(this.TINHTRANGSH);
            this.panel1.Controls.Add(nGAYSOHUULabel);
            this.panel1.Controls.Add(this.NGAYSH);
            this.panel1.Controls.Add(mASOLabel);
            this.panel1.Controls.Add(this.MASOSH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 333);
            this.panel1.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OK.Location = new System.Drawing.Point(146, 262);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(99, 27);
            this.OK.TabIndex = 8;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click_1);
            // 
            // TRIGIASH
            // 
            this.TRIGIASH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sOHUUBindingSource, "TRIGIA", true));
            this.TRIGIASH.Location = new System.Drawing.Point(183, 186);
            this.TRIGIASH.Margin = new System.Windows.Forms.Padding(4);
            this.TRIGIASH.Name = "TRIGIASH";
            this.TRIGIASH.Size = new System.Drawing.Size(156, 22);
            this.TRIGIASH.TabIndex = 7;
            // 
            // sOHUUBindingSource
            // 
            this.sOHUUBindingSource.DataMember = "SOHUU";
            this.sOHUUBindingSource.DataSource = this.BAOTANGDS;
            // 
            // BAOTANGDS
            // 
            this.BAOTANGDS.DataSetName = "BAOTANGDS";
            this.BAOTANGDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TINHTRANGSH
            // 
            this.TINHTRANGSH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sOHUUBindingSource, "TINHTRANG", true));
            this.TINHTRANGSH.Location = new System.Drawing.Point(183, 136);
            this.TINHTRANGSH.Margin = new System.Windows.Forms.Padding(4);
            this.TINHTRANGSH.Name = "TINHTRANGSH";
            this.TINHTRANGSH.Size = new System.Drawing.Size(156, 22);
            this.TINHTRANGSH.TabIndex = 5;
            // 
            // NGAYSH
            // 
            this.NGAYSH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sOHUUBindingSource, "NGAYSOHUU", true));
            this.NGAYSH.EditValue = null;
            this.NGAYSH.Location = new System.Drawing.Point(183, 84);
            this.NGAYSH.Margin = new System.Windows.Forms.Padding(4);
            this.NGAYSH.Name = "NGAYSH";
            this.NGAYSH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NGAYSH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NGAYSH.Size = new System.Drawing.Size(156, 22);
            this.NGAYSH.TabIndex = 3;
            // 
            // MASOSH
            // 
            this.MASOSH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sOHUUBindingSource, "MASO", true));
            this.MASOSH.Location = new System.Drawing.Point(183, 35);
            this.MASOSH.Margin = new System.Windows.Forms.Padding(4);
            this.MASOSH.Name = "MASOSH";
            this.MASOSH.Properties.ReadOnly = true;
            this.MASOSH.Size = new System.Drawing.Size(78, 22);
            this.MASOSH.TabIndex = 1;
            // 
            // sOHUUTableAdapter
            // 
            this.sOHUUTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SOHUUTableAdapter = this.sOHUUTableAdapter;
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
            // sOHUUBindingSource1
            // 
            this.sOHUUBindingSource1.DataMember = "FK_TPNT_SOHUU";
            this.sOHUUBindingSource1.DataSource = this.tPNTBindingSource;
            // 
            // FormSoHuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(393, 333);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSoHuu";
            this.Text = "Sở hữu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSoHuu_FormClosing);
            this.Load += new System.EventHandler(this.FormSoHuu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRIGIASH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOHUUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TINHTRANGSH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYSH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYSH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MASOSH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOHUUBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BAOTANGDataSet BAOTANGDS;
        private System.Windows.Forms.BindingSource sOHUUBindingSource;
        private BAOTANGDataSetTableAdapters.SOHUUTableAdapter sOHUUTableAdapter;
        private DevExpress.XtraEditors.TextEdit MASOSH;
        private DevExpress.XtraEditors.DateEdit NGAYSH;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit TINHTRANGSH;
        private DevExpress.XtraEditors.TextEdit TRIGIASH;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.BindingSource tPNTBindingSource;
        private BAOTANGDataSetTableAdapters.TPNTTableAdapter tPNTTableAdapter;
        private System.Windows.Forms.BindingSource sOHUUBindingSource1;
    }
}