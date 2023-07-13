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
    public partial class FormXuatXu : Form
    {
        public FormXuatXu()
        {
            InitializeComponent();
        }

        int vitri = 0;
        bool check_them = false;
        int id = 0;
        String tenquocgia = "";
        String thoidai = "";

        Stack<string> stack = new Stack<string>();
        private void xUATXUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.xuatXuBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.BAOTANGDS);

        }

        private void FormXuatXu_Load(object sender, EventArgs e)
        {
            BAOTANGDS.EnforceConstraints = false;
            this.xuatXuTA.Connection.ConnectionString = Program.connstr;
            this.xuatXuTA.Fill(this.BAOTANGDS.XUATXU);
            this.tpntTA.Connection.ConnectionString = Program.connstr;
            this.tpntTA.Fill(this.BAOTANGDS.TPNT);
            if (Program.mGroup == "USER")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnHuy.Enabled = btnGhi.Enabled = false;

            }
            else
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnHuy.Enabled = btnGhi.Enabled = false;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = xuatXuBS.Position;
            panelControl4.Enabled = true;
            xuatXuBS.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled =
            btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            xuatxuGridControl.Enabled = false;
            check_them = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tPNTBindingSource.Count > 0)

            {
                MessageBox.Show("Không thể xóa xuất xứ này vì tồn tại trong tác phẩm nghệ thuật!", "", MessageBoxButtons.OK);
                return;

            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa xuất xứ này!", "Xác nhận", MessageBoxButtons.OKCancel)
               == DialogResult.OK)
            {
                try
                {
                    DataRowView dt = ((DataRowView)xuatXuBS[xuatXuBS.Position]);
                    id = int.Parse(dt["ID"].ToString());
                    tenquocgia = dt["TENQUOCGIA"].ToString();
                    thoidai = dt["THOIDAI"].ToString();

                    xuatXuBS.RemoveCurrent();
                    this.xuatXuTA.Connection.ConnectionString = Program.connstr;
                    this.xuatXuTA.Update(this.BAOTANGDS.XUATXU);
                    String query = String.Format("INSERT INTO DBO.XUATXU(TENQUOCGIA,THOIDAI) " +
                                                " VALUES(N'{0}',N'{1}')", tenquocgia, thoidai);
                    Console.WriteLine(query);
                    stack.Push(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa xuất xứ. Bạn hãy xóa lại \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.xuatXuTA.Fill(this.BAOTANGDS.XUATXU);
                    xuatXuBS.Position = xuatXuBS.Find("ID", id);
                    return;
                }
            }
            if (xuatXuBS.Count == 0)
            {
                btnXoa.Enabled = false;
            }
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = xuatXuBS.Position;
            DataRowView dt = ((DataRowView)xuatXuBS[xuatXuBS.Position]);
            id =  int.Parse(dt["ID"].ToString());
            tenquocgia = dt["TENQUOCGIA"].ToString();
            thoidai = dt["THOIDAI"].ToString();
            panelControl4.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            xuatxuGridControl.Enabled = false;
            check_them = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (TENQUOCGIA.Text.Trim() == "")
            {
                MessageBox.Show("Tên quốc gia không được để trống!", "", MessageBoxButtons.OK);
                TENQUOCGIA.Focus();
                return;
            }
            if (Regex.IsMatch(TENQUOCGIA.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Tên quốc gia chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                TENQUOCGIA.Focus();
                return;
            }
            if (THOIDAI.Text.Trim() == "")
            {
                MessageBox.Show("Thời đại không được để trống!", "", MessageBoxButtons.OK);
                THOIDAI.Focus();
                return;
            }
            if (Regex.IsMatch(THOIDAI.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Thời đại chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                THOIDAI.Focus();
                return;
            }
         


            try
            {
                xuatXuBS.EndEdit();
                xuatXuBS.ResetCurrentItem();
                this.xuatXuTA.Update(this.BAOTANGDS.XUATXU);
                this.xuatXuTA.Fill(this.BAOTANGDS.XUATXU);
                String query = "";

                if (check_them)
                {
                    DataRowView dt = ((DataRowView)xuatXuBS[xuatXuBS.Count - 1]);
                    int Id= int.Parse(dt["ID"].ToString());
                    query = "DELETE DBO.XUATXU WHERE ID = " + Id + "";

                }
                else
                {
                    query = "UPDATE DBO.XUATXU " +
                            "SET " +
                            "THOIDAI = N'" + thoidai + "'," +
                            "TENQUOCGIA = N'" + tenquocgia + "' " + 
                            "WHERE ID = " + id ;

                }
                Console.WriteLine(query);
                stack.Push(query);
                xuatXuBS.Position = vitri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi xuất xứ\n" + ex.Message, "", MessageBoxButtons.OK);
           
                return;
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            panelControl4.Enabled = false;
            xuatxuGridControl.Enabled = true;
            xuatXuBS.Position = vitri;

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            xuatXuBS.CancelEdit();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            xuatxuGridControl.Enabled = true;
            this.xuatXuTA.Fill(this.BAOTANGDS.XUATXU);
            xuatXuBS.Position = vitri;
            panelControl4.Enabled = false;

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stack.Count == 0)
            {
                MessageBox.Show("Không có gì để phục hồi!", "", MessageBoxButtons.OK);
                ; return;
            }
            String query = stack.Pop();
            Program.ExecSqlNonQuery(query);
            Console.WriteLine(query);
            this.xuatXuTA.Fill(this.BAOTANGDS.XUATXU);
            xuatxuGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            xuatXuBS.Position = vitri;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tpntTA.Fill(this.BAOTANGDS.TPNT);
                this.xuatXuTA.Fill(this.BAOTANGDS.XUATXU);
                xuatXuBS.Position = vitri;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload !" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
