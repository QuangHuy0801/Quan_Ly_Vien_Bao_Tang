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
    public partial class FormBoSuuTam : Form
    {
        public FormBoSuuTam()
        {
            InitializeComponent();
        }

        int vitri = 0;
        bool check_them = false;
        String ten = "";
        String hinhthuc = "";
        String diachi = "";
        String sdt = "";
        String nguoigiaodich = "";
        String mota = "";

        Stack<string> stack = new Stack<string>();

 

        private void FormBoSuuTam_Load(object sender, EventArgs e)
        {
            BAOTANGDS.EnforceConstraints = false;
            this.bstTA.Connection.ConnectionString = Program.connstr;
            this.bstTA.Fill(this.BAOTANGDS.BOSUUTAP);
            this.diMuonTA.Connection.ConnectionString = Program.connstr;
            this.diMuonTA.Fill(this.BAOTANGDS.DIMUON);

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

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.bstTA.Fill(this.BAOTANGDS.BOSUUTAP);
                this.diMuonTA.Fill(this.BAOTANGDS.DIMUON);
                bstDB.Position = vitri;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload !" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bstDB.Position;
            panelControl4.Enabled = true;
            bstDB.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled =
                btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            bstGridControl.Enabled = false;
            check_them = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bstDB.Position;
            DataRowView dt = ((DataRowView)bstDB[bstDB.Position]);
            ten = dt["TEN"].ToString();
            hinhthuc = dt["HINHTHUC"].ToString();
            mota = dt["MOTA"].ToString();
            diachi = dt["DIACHI"].ToString();
            sdt = dt["SODT"].ToString();
            nguoigiaodich = dt["NGUOIGIAODICH"].ToString();
            panelControl4.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            bstGridControl.Enabled = false;
            check_them = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (diMuonDB.Count > 0)

            {
                MessageBox.Show("Không thể xóa bộ sưu tập này vì tồn tại trong tác phẩm nghệ thuật!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa bộ sưu tập này này!", "Xác nhận", MessageBoxButtons.OKCancel)
               == DialogResult.OK)
            {
                try
                {
                    DataRowView dt = ((DataRowView)bstDB[bstDB.Position]);
                    ten = dt["TEN"].ToString();
                    hinhthuc = dt["HINHTHUC"].ToString();
                    mota = dt["MOTA"].ToString();
                    diachi = dt["DIACHI"].ToString();
                    sdt = dt["SODT"].ToString();
                    nguoigiaodich = dt["NGUOIGIAODICH"].ToString();
                    bstDB.RemoveCurrent();
                    this.bstTA.Connection.ConnectionString = Program.connstr;
                    this.bstTA.Update(this.BAOTANGDS.BOSUUTAP);
                    String query = String.Format("INSERT INTO DBO.BOSUUTAP(TEN,HINHTHUC,MOTA,DIACHI,SODT,NGUOIGIAODICH) " +
                                                " VALUES(N'{0}',N'{1}',N'{2}',N'{3}', '{4}' ,N'{5}')", ten, hinhthuc, mota, diachi, sdt, nguoigiaodich);
                    Console.WriteLine(query);
                    stack.Push(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa bộ sưu tập. Bạn hãy xóa lại \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.bstTA.Fill(this.BAOTANGDS.BOSUUTAP);
                    bstDB.Position = bstDB.Find("TEN", ten);
                    return;
                }
            }
            if (bstDB.Count == 0)
            {
                btnXoa.Enabled = false;
            }
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống!", "", MessageBoxButtons.OK);
                TEN.Focus();
                return;
            }
            if (Regex.IsMatch(TEN.Text, @"^[0-9a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Tên chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                TEN.Focus();
                return;
            }

            if (HINHTHUC.Text.Trim() == "")
            {
                MessageBox.Show("Hình thức không được để trống!", "", MessageBoxButtons.OK);
                HINHTHUC.Focus();
                return;
            }
            if (Regex.IsMatch(HINHTHUC.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Hình thức chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                MOTA.Focus();
                return;
            }
            if (MOTA.Text.Trim() == "")
            {
                MessageBox.Show("Mô tả không được để trống!", "", MessageBoxButtons.OK);
                MOTA.Focus();
                return;
            }
            if (Regex.IsMatch(MOTA.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Mô tả chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                MOTA.Focus();
                return;
            }
            if (DIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!", "", MessageBoxButtons.OK);
                DIACHI.Focus();
                return;
            }
            if (Regex.IsMatch(DIACHI.Text, @"^[a-zA-Z0-9 \-/,.ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ có chữ cái chữ số khoảng trắng và các kí tự ,\\-.,/", "Thông báo", MessageBoxButtons.OK);
                DIACHI.Focus();
                return;
            }

            if (SDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được để trống!", "", MessageBoxButtons.OK);
                SDT.Focus();
                return;
            }
            if (Regex.IsMatch(SDT.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số điện thoại chỉ bao gồm chữ số", "Thông báo", MessageBoxButtons.OK);
                SDT.Focus();
                return;
            }

            if (NGUOIGIAODICH.Text.Trim() == "")
            {
                MessageBox.Show("Người giao dịchkhông được để trống!", "", MessageBoxButtons.OK);
                NGUOIGIAODICH.Focus();
                return;
            }
            if (Regex.IsMatch(NGUOIGIAODICH.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Người giao dịch chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                NGUOIGIAODICH.Focus();
                return;
            }
           

            if (check_them == true || ten != TEN.Text.ToString().Trim())
            {
                String checkID = "EXEC [dbo].[sp_Check_Exists_Id_Char] 'BOSUUTAP', 'TEN' ,'"
                    + TEN.Text.ToString().Trim() + "'";
                Console.WriteLine(TEN);
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(checkID);
                    if (Program.myReader == null) { return; }
                    Program.myReader.Read();
                    if (Program.myReader.GetInt32(0) == 1)
                    {
                        MessageBox.Show("Tên bị trùng với với bộ sưu tầm khác!", "Thông báo", MessageBoxButtons.OK);
                        TEN.Focus();
                        Program.myReader.Close();
                        return;
                    }
                    else
                    {
                        Program.myReader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }



            try
            {
                bstDB.EndEdit();
                bstDB.ResetCurrentItem();
                this.bstTA.Update(this.BAOTANGDS.BOSUUTAP);
                String query = "";
                if (check_them)
                {

                    query = "DELETE DBO.BOSUUTAP WHERE TEN = N'" + TEN.Text.Trim() + "'";

                }
                else
                {
                    query = "UPDATE DBO.BOSUUTAP " +
                            "SET " +
                            "TEN = N'" + ten + "'," +
                            "HINHTHUC = N'" + hinhthuc + "'," +
                            "MOTA = N'" + mota + "'," +
                            "DIACHI = N'" + diachi + "'," +
                            "SODT = N'" + sdt + "', " +
                            "NGUOIGIAODICH = N'" + nguoigiaodich + "' " +
                            "WHERE TEN = N'" + TEN.Text.ToString() + "'";

                }
                Console.WriteLine(query);
                stack.Push(query);
                bstDB.Position = vitri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi bộ sưu tập\n" + ex.Message, "", MessageBoxButtons.OK);
                bstDB.Position = vitri;
                return;
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            panelControl4.Enabled = false;
            bstGridControl.Enabled = true;
            bstDB.Position = vitri;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bstDB.CancelEdit();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            bstGridControl.Enabled = true;
            this.bstTA.Fill(this.BAOTANGDS.BOSUUTAP);
            bstDB.Position = vitri;
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
            this.bstTA.Fill(this.BAOTANGDS.BOSUUTAP);
            bstGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            bstGridControl.Enabled = true;
            bstDB.Position = vitri;
        }
    }
}
