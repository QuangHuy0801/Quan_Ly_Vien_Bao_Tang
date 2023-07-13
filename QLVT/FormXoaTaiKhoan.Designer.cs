namespace QLVT
{
    partial class FormXoaTaiKhoan
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
            System.Windows.Forms.Label label3;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTao = new System.Windows.Forms.Button();
            this.username = new DevExpress.XtraEditors.TextEdit();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.username.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonTao);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username:";
            // 
            // buttonTao
            // 
            this.buttonTao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTao.BackColor = System.Drawing.Color.Red;
            this.buttonTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTao.Location = new System.Drawing.Point(333, 260);
            this.buttonTao.Name = "buttonTao";
            this.buttonTao.Size = new System.Drawing.Size(145, 32);
            this.buttonTao.TabIndex = 8;
            this.buttonTao.Text = "XÓA";
            this.buttonTao.UseVisualStyleBackColor = false;
            this.buttonTao.Click += new System.EventHandler(this.buttonTao_Click);
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.username.Location = new System.Drawing.Point(369, 170);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(229, 22);
            this.username.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(310, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(183, 25);
            label3.TabIndex = 5;
            label3.Text = "XÓA TÀI KHOẢN";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormXoaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormXoaTaiKhoan";
            this.Text = "Xóa tài khoản";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.username.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTao;
        private DevExpress.XtraEditors.TextEdit username;
    }
}