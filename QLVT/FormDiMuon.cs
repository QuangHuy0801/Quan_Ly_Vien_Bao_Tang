using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormDiMuon : Form
    {
      
        public FormDiMuon()
        {
            InitializeComponent();
        }
        public int matpnt = 0;
        public String tenbst = "";
        public DateTime ngaymuon;
        public DateTime ngaytra;
        private void dIMUONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dimuonBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.BAOTANGDS);

        }

        private void FormDiMuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BAOTANGDS.TPNT' table. You can move, or remove it, as needed.
            this.tPNTTableAdapter.Fill(this.BAOTANGDS.TPNT);
            BAOTANGDS.EnforceConstraints = false;
            this.tTBOSUUTAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tTBOSUUTAPTableAdapter.Fill(this.BAOTANGDS.TTBOSUUTAP);           
        }

        private void OK_Click_1(object sender, EventArgs e)
        {
            if (cb_bstdm.Text.Trim() == "")
            {
                MessageBox.Show("Tên bộ sưu tập không được để trống!", "", MessageBoxButtons.OK);
                cb_bstdm.Focus();
                return;
            }
            if (NGAYMUONDM.Text.Trim() == "")
            {
                MessageBox.Show("Ngày mượn không được để trống!", "", MessageBoxButtons.OK);
                NGAYMUONDM.Focus();
                return;
            }

            if (NGAYTRADM.Text.Trim() == "")
            {
                MessageBox.Show("Ngày trả không được để trống!", "", MessageBoxButtons.OK);
                NGAYTRADM.Focus();
                return;
            }
            if (DateTime.Parse(NGAYTRADM.Text.ToString()) < DateTime.Parse(NGAYMUONDM.Text.ToString()))
            {
                MessageBox.Show("Thời gian sau phải lớn hơn thời gian trước!", "", MessageBoxButtons.OK);
                return;
            }
            this.Close();
        }

        private void cb_bstdm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormDiMuon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.check_them_gl == true)
            {
                matpnt = Program.maso;
                Console.WriteLine(MASO.Text + "ma so di muon");
            } else
            {
                matpnt = int.Parse(MASO.Text.ToString());

            }
            tenbst = cb_bstdm.Text.ToString();
            ngaymuon = DateTime.Parse(NGAYMUONDM.Text.ToString());
            ngaytra = DateTime.Parse(NGAYTRADM.Text.ToString());
        }
    }
}
