using System;
using System.Collections;
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
    public partial class FormTG : Form
    {
        public FormTG()
        {
            InitializeComponent();
        }

        int vitri = 0;
        bool check_them = false;
        String ten = "";
        String quoctich = "";
        String thoidai = "";
        String phongcachchinh = "";
        String diengiai = "";
        DateTime ngaysinh;
        DateTime? ngaymat;

        Stack<string> stack = new Stack<string>();
        private string ToString(DateTime? dt, string format)
        {
            return dt == null ? "NULL" : "'" + ((DateTime)dt).ToString(format) + "'";
        }


        private void FormTG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAOTANGDataSet.TPNT' table. You can move, or remove it, as needed.
            BAOTANGDS.EnforceConstraints = false;
            this.tacGiaTA.Connection.ConnectionString = Program.connstr;
            this.tacGiaTA.Fill(this.BAOTANGDS.TACGIA);
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

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tacGiaBS.CancelEdit();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            tACGIAGridControl.Enabled = true;
            this.tacGiaTA.Fill(this.BAOTANGDS.TACGIA);
            tacGiaBS.Position = vitri;
            panel3.Enabled = false;

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tpntTA.Fill(this.BAOTANGDS.TPNT);
                this.tacGiaTA.Fill(this.BAOTANGDS.TACGIA);
                tacGiaBS.Position = vitri;

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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tpntBS.Count > 0)

            {
                MessageBox.Show("Không thể xóa tác giả này vì tồn tại trong tác phẩm nghệ thuật!", "", MessageBoxButtons.OK);

                return;

            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa tác giả này!", "Xác nhận", MessageBoxButtons.OKCancel)
               == DialogResult.OK)
            {
                try
                {
                    DataRowView dt = ((DataRowView)tacGiaBS[tacGiaBS.Position]);
                    ten = dt["TEN"].ToString();
                    quoctich = dt["QUOCTICH"].ToString();
                    ten = dt["TEN"].ToString();
                    thoidai = dt["THOIDAI"].ToString();
                    phongcachchinh = dt["PHONGCACHCHINH"].ToString();
                    ngaysinh = (DateTime)dt["NGAYSINH"];
                    ngaymat = dt["NGAYMAT"].ToString() == "" ? null : (DateTime?)dt["NGAYMAT"];
                    diengiai = dt["DIENGIAI"].ToString();

                    tacGiaBS.RemoveCurrent();
                    this.tacGiaTA.Connection.ConnectionString = Program.connstr;
                    this.tacGiaTA.Update(this.BAOTANGDS.TACGIA);
                    String query = String.Format("INSERT INTO DBO.TACGIA(TEN,NGAYSINH,NGAYMAT,QUOCTICH,THOIDAI,PHONGCACHCHINH,DIENGIAI) " +
                                                " VALUES(N'{0}',{1},{2},N'{3}', N'{4}' ,N'{5}', N'{6}')", ten, ToString(ngaysinh, "yyyy-MM-dd"), ToString(ngaymat, "yyyy-MM-dd"), quoctich, thoidai, phongcachchinh, diengiai);
                    Console.WriteLine(query);
                    stack.Push(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tacGiaTA.Fill(this.BAOTANGDS.TACGIA);
                    tacGiaBS.Position = tacGiaBS.Find("TEN", ten);
                    return;
                }
            }
            if (tacGiaBS.Count == 0)
            {
                btnXoa.Enabled = false;
            }
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            vitri = tacGiaBS.Position;
            panel3.Enabled = true;
            tacGiaBS.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled =
            btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            tACGIAGridControl.Enabled = false;
            check_them = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = tacGiaBS.Position;
            DataRowView dt = ((DataRowView)tacGiaBS[tacGiaBS.Position]);
            ten = dt["TEN"].ToString();
            quoctich = dt["QUOCTICH"].ToString();
            ten = dt["TEN"].ToString();
            thoidai = dt["THOIDAI"].ToString();
            phongcachchinh = dt["PHONGCACHCHINH"].ToString();
            ngaysinh = (DateTime)dt["NGAYSINH"];
            ngaymat = dt["NGAYMAT"].ToString() == "" ? null : (DateTime?)dt["NGAYMAT"];
            diengiai = dt["DIENGIAI"].ToString();
            panel3.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            tACGIAGridControl.Enabled = false;
            check_them = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (TENN.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống!", "", MessageBoxButtons.OK);
                TENN.Focus();
                return;
            }
            if (Regex.IsMatch(TENN.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Tên chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                TENN.Focus();
                return;
            }

            if (QUOCTICHH.Text.Trim() == "")
            {
                MessageBox.Show("Quốc tịch không được để trống!", "", MessageBoxButtons.OK);
                QUOCTICHH.Focus();
                return;
            }
            if (Regex.IsMatch(QUOCTICHH.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Quốc tịch chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                QUOCTICHH.Focus();
                return;
            }
            if (THOIDAII.Text.Trim() == "")
            {
               MessageBox.Show("Thời đại không được để trống!", "", MessageBoxButtons.OK);
                THOIDAII.Focus();
                return;
            }
            if (Regex.IsMatch(THOIDAII.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Thời đại chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                THOIDAII.Focus();
                return;
            }

            if (NGAYSINHH.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống!", "", MessageBoxButtons.OK);
                NGAYSINHH.Focus();
                return;
            }

            if (NGAYMATT.Text.Trim() != "")
            {
               if (DateTime.Parse(NGAYSINHH.Text.ToString()) >= DateTime.Parse(NGAYMATT.Text.ToString()))
                {
                    MessageBox.Show("Ngày sinh không lớn hơn ngày mất!", "", MessageBoxButtons.OK);
                    NGAYMATT.Focus();
                    return;
                }    
            }

            if (PHONGCACHCHINHH.Text.Trim() == "")
            {
                MessageBox.Show("Phong cách chính không được để trống!", "", MessageBoxButtons.OK);
                PHONGCACHCHINHH.Focus();
                return;
            }
            if (Regex.IsMatch(PHONGCACHCHINHH.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Phong cách chính chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                PHONGCACHCHINHH.Focus();
                return;
            }
            if (DIENGIAII.Text.Trim() == "")
            {
                MessageBox.Show("Diễn giải không được để trống!", "", MessageBoxButtons.OK);
                DIENGIAII.Focus();
                return;
            }
            if (Regex.IsMatch(DIENGIAII.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Diễn giải chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                DIENGIAII.Focus();
                return;
            }

        

            if (check_them == true || ten != TENN.Text.ToString().Trim())
            {
                String checkID = "EXEC [dbo].[sp_Check_Exists_TenTG_Char] 'TACGIA', 'TEN' ,N'"
                    + TENN.Text.ToString().Trim() + "'";
                Console.WriteLine(TENN);
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(checkID);
                    if (Program.myReader == null) { return; }
                    Program.myReader.Read();
                    if (Program.myReader.GetInt32(0) == 1)
                    {
                        MessageBox.Show("Tên bị trùng với với tác giả khác!", "Thông báo", MessageBoxButtons.OK);
                        TENN.Focus();
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
                tacGiaBS.EndEdit();
                tacGiaBS.ResetCurrentItem();
                this.tacGiaTA.Update(this.BAOTANGDS.TACGIA);
                String query = "";
                if (check_them)
                {

                    query = "DELETE DBO.TACGIA WHERE TEN = N'" + TENN.Text.Trim() + "'";

                }
                else
                {
                    query = "UPDATE DBO.TACGIA " +
                            "SET " +
                            "TEN = N'" + ten + "'," +
                            "NGAYSINH = " + ToString(ngaysinh, "yyyy-MM-dd") + "," +
                            "NGAYMAT = " + ToString(ngaymat, "yyyy-MM-dd") + "," +
                            "QUOCTICH = N'" + quoctich + "'," +
                            "THOIDAI = N'" + thoidai + "'," +
                            "PHONGCACHCHINH = N'" + phongcachchinh + "'," +
                            "DIENGIAI = N'" + diengiai + "' " +
                            "WHERE TEN = N'" + TENN.Text.ToString() + "'";

                }
                Console.WriteLine(query);
                stack.Push(query);
                tacGiaBS.Position = vitri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi tác gia\n" + ex.Message, "", MessageBoxButtons.OK);
                tacGiaBS.Position = vitri;
                return;
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            panel3.Enabled = false;
            tACGIAGridControl.Enabled = true;
            tacGiaBS.Position = vitri;

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
            this.tacGiaTA.Fill(this.BAOTANGDS.TACGIA);
            tACGIAGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            tACGIAGridControl.Enabled = true;
            tacGiaBS.Position = vitri;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
