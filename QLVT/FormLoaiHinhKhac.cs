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
    public partial class FormLoaiHinhKhac : Form
    {
        public FormLoaiHinhKhac()
        {
            InitializeComponent();
        }
        public int maso = 0;
        public String theloai = "";
        public String phongcach = "";


        private void lOAIHINHKHACBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOAIHINHKHACBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.BAOTANGDS);

        }

        private void FormLoaiHinhKhac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BAOTANGDS.TPNT' table. You can move, or remove it, as needed.
            this.tPNTTableAdapter.Fill(this.BAOTANGDS.TPNT);
            // TODO: This line of code loads data into the 'bAOTANGDataSet.LOAIHINHKHAC' table. You can move, or remove it, as needed.
            //BAOTANGDS.EnforceConstraints = false;
            //this.lOAIHINHKHACTableAdapter.Connection.ConnectionString = Program.connstr; 
            //// TODO: This line of code loads data into the 'bAOTANGDataSet.LOAIHINHKHAC' table. You can move, or remove it, as needed.
            //this.lOAIHINHKHACTableAdapter.Fill(this.BAOTANGDS.LOAIHINHKHAC);

        }

        private void FormLoaiHinhKhac_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MASOLHK.Text.ToString().Trim() != "") maso = int.Parse(MASOLHK.Text.ToString().Trim());
            theloai = THELOAILHK.Text.ToString().Trim();
            phongcach = PHONGCACHLHK.Text.ToString().Trim();
        }


        private void OK_Click_1(object sender, EventArgs e)
        {
            if (THELOAILHK.Text.Trim() == "")
            {
                MessageBox.Show("Vật liệu không được để trống!", "", MessageBoxButtons.OK);
                THELOAILHK.Focus();
                return;
            }
            if (Regex.IsMatch(THELOAILHK.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Vật liệu chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                THELOAILHK.Focus();
                return;
            }

            if (PHONGCACHLHK.Text.Trim() == "")
            {
                MessageBox.Show("Chất liệu không được để trống!", "", MessageBoxButtons.OK);
                PHONGCACHLHK.Focus();
                return;
            }
            if (Regex.IsMatch(PHONGCACHLHK.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Chất liệu chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                PHONGCACHLHK.Focus();
                return;
            }
           
            this.Close();
        }
    }
}
