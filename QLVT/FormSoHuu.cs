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
    public partial class FormSoHuu : Form
    {
        public FormSoHuu()
        {
            InitializeComponent();
        }

        public int maso = 0;
        public DateTime ngaysohuu;
        public String tinhtrang = "";
        public int trigia = 0;

        private void FormSoHuu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BAOTANGDS.TPNT' table. You can move, or remove it, as needed.
            this.tPNTTableAdapter.Fill(this.BAOTANGDS.TPNT);
            // TODO: This line of code loads data into the 'bAOTANGDataSet.SOHUU' table. You can move, or remove it, as needed.
            BAOTANGDS.EnforceConstraints = false;
        }

        private void FormSoHuu_FormClosing(object sender, FormClosingEventArgs e)
        {
           //if (MASOSH.Text.ToString().Trim() != "")  maso = int.Parse(MASOSH.Text.ToString().Trim());
            tinhtrang = TINHTRANGSH.Text.ToString().Trim();
            Console.WriteLine(TRIGIASH.EditValue);
            trigia = (int)Double.Parse(TRIGIASH.EditValue.ToString());
            ngaysohuu = DateTime.Parse(NGAYSH.Text.ToString().Trim());
    }

        private void OK_Click_1(object sender, EventArgs e)
        {
            if (TINHTRANGSH.Text.Trim() == "")
            {
                MessageBox.Show("Tình trạng không được để trống!", "", MessageBoxButtons.OK);
                TINHTRANGSH.Focus();
                return;
            }
            if (Regex.IsMatch(TINHTRANGSH.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Thời đại chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                TINHTRANGSH.Focus();
                return;
            }
            if (NGAYSH.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sở hữu không được để trống!", "", MessageBoxButtons.OK);
                TINHTRANGSH.Focus();
                return;
            }
            if (TRIGIASH.Text.Trim() == "")
            {
                MessageBox.Show("Trị giá không được để trống!", "", MessageBoxButtons.OK);
                TRIGIASH.Focus();
                return;
            }
            if (Regex.IsMatch(TRIGIASH.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Trị giá chỉ có chữ số", "Thông báo", MessageBoxButtons.OK);
                TINHTRANGSH.Focus();
                return;
            }
            this.Close();
        }
    }
}
