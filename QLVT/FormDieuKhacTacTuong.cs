using DevExpress.XtraEditors.Mask.Design;
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
    public partial class FormDieuKhacTacTuong : Form
    {
        public int maso = 0;
        public String vatlieu = "";
        public int chieucao = 0;
        public int khoiluong = 0;
        public String phongcach = "";
        public FormDieuKhacTacTuong()
        {
            InitializeComponent();
        }

        private void FormDieuKhacTacTuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BAOTANGDS.TPNT' table. You can move, or remove it, as needed.
            this.tPNTTableAdapter.Fill(this.BAOTANGDS.TPNT);
            // TODO: This line of code loads data into the 'bAOTANGDataSet.DIEUKHAC_TACTUONG' table. You can move, or remove it, as needed.
            BAOTANGDS.EnforceConstraints = false;
            this.dkttTA.Connection.ConnectionString = Program.connstr;
            this.dkttTA.Fill(this.BAOTANGDS.DIEUKHAC_TACTUONG);
           
        }


        private void FormDieuKhacTacTuong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.check_them_gl == true)
            {
                maso = Program.maso;
                Console.WriteLine(MASODKTT.Text + "ma so di muon");
            }
            else
            {
                maso = int.Parse(MASODKTT.Text.ToString());

            }
            vatlieu = VATLIEUDKTT.Text.ToString().Trim();
            chieucao = int.Parse(CHIEUCAODKTT.Text.ToString().Trim());
            khoiluong = int.Parse(KHOILUONGDKTT.Text.ToString().Trim());
            phongcach = PHONGCACHDKTT.Text.ToString().Trim();
        }

        private void OK_Click_1(object sender, EventArgs e)
        {
            if (VATLIEUDKTT.Text.Trim() == "")
            {
                MessageBox.Show("Vật liệu không được để trống!", "", MessageBoxButtons.OK);
                VATLIEUDKTT.Focus();
                return;
            }
            if (Regex.IsMatch(VATLIEUDKTT.Text, @"^[a-zA-Z 0-9ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Vật liệu chỉ có chữ cái và khoảng trắng và chữ số", "Thông báo", MessageBoxButtons.OK);
                VATLIEUDKTT.Focus();
                return;
            }
            if (CHIEUCAODKTT.Text.Trim() == "")
            {
                MessageBox.Show("Chiều cao không được để trống!", "", MessageBoxButtons.OK);
                CHIEUCAODKTT.Focus();
                return;
            }
            if (KHOILUONGDKTT.Text.Trim() == "")
            {
                MessageBox.Show("Khối lượng không được để trống!", "", MessageBoxButtons.OK);
                KHOILUONGDKTT.Focus();
                return;
            }
            if (PHONGCACHDKTT.Text.Trim() == "")
            {
                MessageBox.Show("Phong cách không được để trống!", "", MessageBoxButtons.OK);
                PHONGCACHDKTT.Focus();
                return;
            }
            if (Regex.IsMatch(PHONGCACHDKTT.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Phong cách chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                PHONGCACHDKTT.Focus();
                return;
            }
            if (Regex.IsMatch(KHOILUONGDKTT.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Khối lượng chỉ bao gồm chữ số", "Thông báo", MessageBoxButtons.OK);
                KHOILUONGDKTT.Focus();
                return;
            }
            if (Regex.IsMatch(CHIEUCAODKTT.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Chiều cao chỉ bao gồm chữ số", "Thông báo", MessageBoxButtons.OK);
                CHIEUCAODKTT.Focus();
                return;
            }

            this.Close();
        }

        private void dIEUKHAC_TACTUONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dkttBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.BAOTANGDS);

        }
    }
}
