using DevExpress.CodeParser;
using System;
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

namespace QLVT
{
    public partial class FormRestore : Form
    {
        public FormRestore()
        {
            InitializeComponent();
        }

        private void FormRestore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAOTANGDataSet.RESTORE' table. You can move, or remove it, as needed.
            BAOTANGDS.EnforceConstraints = false;
            this.RSTA.Connection.ConnectionString = Program.connstr;
            this.RSTA.Fill(this.BAOTANGDS.RESTORE);
            if (RSBS.Count > 0)
            {
                DataRowView dt = ((DataRowView)RSBS[0]);
                String restore_date = dt["restore_date"].ToString();
                Console.WriteLine(restore_date);
                labelLS.Text = "(Lịch sử gần nhất:" + restore_date + ")";
            }

        }

        private void historyRS_Click(object sender, EventArgs e)
        {
            if (restoreGridControl.Visible) historyRS.Text = "Xem lịch sử";
            else historyRS.Text = "Đóng lịch sử";
            restoreGridControl.Visible = !restoreGridControl.Visible;
        }

        private void RESTORE_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("Nếu thành công app sẽ tự khởi động lại. Bạn có thực sự muốn RESTORE không!", "Xác nhận", MessageBoxButtons.OKCancel)
                 == DialogResult.OK)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Backup file (*.bak)|*.bak|All file (*.*)|*.*";
                openFileDialog.InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\backup";
                bool exists = System.IO.Directory.Exists(openFileDialog.InitialDirectory);
                if (!exists)
                    System.IO.Directory.CreateDirectory(openFileDialog.InitialDirectory);
                openFileDialog.Title = "Open Backuping File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine(openFileDialog.FileName);

                    if (Regex.IsMatch(openFileDialog.FileName, @".bak$") == false)
                    {
                        MessageBox.Show("Tên file backup phải có đuôi .bak", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    try
                    {
                        this.Enabled = false;
                        String query = "USE [master] " +
                            " ALTER DATABASE [BAOTANG]  SET OFFLINE WITH ROLLBACK IMMEDIATE " +
                            " RESTORE DATABASE [BAOTANG] FROM DISK =  '"+ openFileDialog.FileName + "'WITH REPLACE" +
                            " ALTER DATABASE [BAOTANG]  SET ONLINE";
                        Program.ExecSqlNonQuery(query);
                        MessageBox.Show("Restore thành công. XONG! Vui lòng nhấn OK để chạy lại ứng dụng.", "", MessageBoxButtons.OK);
                        this.RSTA.Fill(this.BAOTANGDS.RESTORE);
                        DataRowView dt = ((DataRowView)RSBS[0]);
                        String restore_date = dt["restore_date"].ToString();
                        Console.WriteLine(restore_date);
                        labelLS.Text = "(Lịch sử gần nhất:" + restore_date + ")";
                        this.Enabled = true;
                        Application.Restart();
                    }
                    catch (Exception ex)
                    {
                        this.Enabled = true;
                        MessageBox.Show("Lỗi restore. \n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }

               
            }
        }
    }
}
