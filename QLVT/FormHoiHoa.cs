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
    public partial class FormHoiHoa : Form
    {
        public FormHoiHoa()
        {
            InitializeComponent();
        }
        public int maso = 0;
        public String vatlieu = "";
        public String chatlieu = "";
        public String truongphai = "";
       

        private void FormHoiHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BAOTANGDS.TPNT' table. You can move, or remove it, as needed.
            this.tPNTTableAdapter.Fill(this.BAOTANGDS.TPNT);
            //BAOTANGDS.EnforceConstraints = false;
            //this.hOIHOATableAdapter.Connection.ConnectionString = Program.connstr; this.hOIHOATableAdapter.Fill(this.BAOTANGDS.HOIHOA);
            //this.hOIHOATableAdapter.Connection.ConnectionString = Program.connstr; this.hOIHOATableAdapter.Fill(this.BAOTANGDS.HOIHOA);
        }

        private void FormHoiHoa_FormClosing(object sender, FormClosingEventArgs e)
        {
    //        if (MASOHH.Text.ToString().Trim() != "") maso = int.Parse(MASOHH.Text.ToString().Trim());
            vatlieu = VATLIEUHH.Text.ToString().Trim();
            chatlieu = CHATLIEUHH.Text.ToString().Trim();
            truongphai = TRUONGPHAIHH.Text.ToString().Trim();
        }

        private void OK_Click_1(object sender, EventArgs e)
        {
            if (VATLIEUHH.Text.Trim() == "")
            {
                MessageBox.Show("Vật liệu không được để trống!", "", MessageBoxButtons.OK);
                VATLIEUHH.Focus();
                return;
            }
            if (Regex.IsMatch(VATLIEUHH.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Vật liệu chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                VATLIEUHH.Focus();
                return;
            }

            if (CHATLIEUHH.Text.Trim() == "")
            {
                MessageBox.Show("Chất liệu không được để trống!", "", MessageBoxButtons.OK);
                CHATLIEUHH.Focus();
                return;
            }
            if (Regex.IsMatch(CHATLIEUHH.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Chất liệu chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                CHATLIEUHH.Focus();
                return;
            }
            if (TRUONGPHAIHH.Text.Trim() == "")
            {
                MessageBox.Show("Trường phái không được để trống!", "", MessageBoxButtons.OK);
                TRUONGPHAIHH.Focus();
                return;
            }
            if (Regex.IsMatch(TRUONGPHAIHH.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Trường phái chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                TRUONGPHAIHH.Focus();
                return;
            }
            this.Close();
        }


    }
}
