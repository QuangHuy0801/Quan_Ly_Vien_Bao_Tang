using DevExpress.DataProcessing;
using DevExpress.Utils.CommonDialogs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLVT
{
    public partial class FormBackup : Form
    {
        public FormBackup()
        {
            InitializeComponent();
        }

        private void FormBackup_Load(object sender, EventArgs e)
        {
            BAOTANGDS.EnforceConstraints = false;
            this.BKTA.Connection.ConnectionString = Program.connstr;
            this.BKTA.Fill(this.BAOTANGDS.BACKUP);
            if (BKBS.Count > 0)
            {
                DataRowView dt = ((DataRowView)BKBS[0]);
                String backup_finish_date = dt["backup_finish_date"].ToString();
                Console.WriteLine(backup_finish_date);
                labelLS.Text = "(Lịch sử gần nhất:" + backup_finish_date + ")";
            }    
        }

        private void historyBK_Click(object sender, EventArgs e)
        {
            if (backupGridControl.Visible) historyBK.Text = "Xem lịch sử";
            else historyBK.Text = "Đóng lịch sử";
            backupGridControl.Visible = !backupGridControl.Visible;   
        }

        private void BACKUP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn BACKUP không!", "Xác nhận", MessageBoxButtons.OKCancel)
                 == DialogResult.OK)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Backup file (*.bak)|*.bak|All file (*.*)|*.*";
                saveFileDialog.InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\backup";
                Console.WriteLine(saveFileDialog.InitialDirectory);
                bool exists = System.IO.Directory.Exists(saveFileDialog.InitialDirectory);
                if (!exists)
                    System.IO.Directory.CreateDirectory(saveFileDialog.InitialDirectory);
                saveFileDialog.Title = "Save Backuping File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine(saveFileDialog.FileName);

                    if (Regex.IsMatch(saveFileDialog.FileName, @".bak$") == false)
                    {
                        MessageBox.Show("Tên file backup phải có đuôi .bak", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    try
                    {
                        this.Enabled = false;
                        String query = "exec sp_Backup '" + saveFileDialog.FileName + "'";
                        Program.ExecSqlNonQuery(query);
                        MessageBox.Show("Backup thành công. XONG! ", "", MessageBoxButtons.OK);
                        this.BKTA.Fill(this.BAOTANGDS.BACKUP);
                        DataRowView dt = ((DataRowView)BKBS[0]);
                        String backup_finish_date = dt["backup_finish_date"].ToString();
                        Console.WriteLine(backup_finish_date);
                        labelLS.Text = "(Lịch sử gần nhất:" + backup_finish_date + ")";
                        this.Enabled = true;

                    }
                    catch (Exception ex)
                    {
                        this.Enabled = true;
                        MessageBox.Show("Lỗi backup. \n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backupGridControl_Click(object sender, EventArgs e)
        {

        }

        private void labelLS_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
