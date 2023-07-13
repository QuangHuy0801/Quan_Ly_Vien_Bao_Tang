using DevExpress.CodeParser.Diagnostics;
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
    public partial class FormNhanVien : Form
    {
        int vitri = 0;
        bool check_them = false;
        int manv;
        String ho = "";
        String ten = "";
        String diachi = "";
        String socmnd = "";
        DateTime ngaysinh;
   
        Stack<string> stack = new Stack<string>();

        public FormNhanVien()
        {
            InitializeComponent();
        }

        

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tAIKHOANDataSet1.NHANVIEN' table. You can move, or remove it, as needed.
          
            tAIKHOANDataSet1.EnforceConstraints = false;
            this.nhanvienTA.Connection.ConnectionString = Program.connstr;
            this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
            this.userTA.Connection.ConnectionString = Program.connstr;
            this.userTA.Fill(this.tAIKHOANDataSet1.USER);
            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nhanvienBS.Position;
            panel3.Enabled = true;
            nhanvienBS.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled =
            btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            nHANVIENGridControl.Enabled = false;
            check_them = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nhanvienBS.Count == 0)
            {
                MessageBox.Show("Không thể xóa nhân viên vì danh sách rỗng!", "", MessageBoxButtons.OK);
                return;

            }
            if (userBS.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên vì nhân viên đã có tài khoản!", "", MessageBoxButtons.OK);
                return;

            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này!", "Xác nhận", MessageBoxButtons.OKCancel)
               == DialogResult.OK)
            {
                try
                {
                    DataRowView dt = ((DataRowView)nhanvienBS[nhanvienBS.Position]);
                    ten = dt["TEN"].ToString();
                    ho = dt["HO"].ToString();
                    socmnd = dt["SOCMND"].ToString();
                    manv = int.Parse(dt["MANV"].ToString());
                    ngaysinh = (DateTime)dt["NGAYSINH"];
                    diachi = dt["DIACHI"].ToString();
                    nhanvienBS.RemoveCurrent();
                    this.nhanvienTA.Connection.ConnectionString = Program.connstr;
                    this.nhanvienTA.Update(this.tAIKHOANDataSet1.NHANVIEN);
                    String query = String.Format("INSERT INTO DBO.NHANVIEN(HO,TEN,SOCMND,DIACHI,NGAYSINH) " +
                                                 " VALUES(N'{1}',N'{2}','{3}', N'{4}' ,'{5}')", manv, ho, ten, socmnd, diachi, ngaysinh);
                    Console.WriteLine(query);
                    stack.Push(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
                    nhanvienBS.Position = nhanvienBS.Find("MANV", manv);
                    return;
                }
            }
            if (nhanvienBS.Count == 0)
            {
                btnXoa.Enabled = false;
            }
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nhanvienBS.Position;
            DataRowView dt = ((DataRowView)nhanvienBS[nhanvienBS.Position]);
            ten = dt["TEN"].ToString();
            ho = dt["HO"].ToString();
            socmnd = dt["SOCMND"].ToString();
            manv = int.Parse(dt["MANV"].ToString());
            ngaysinh = (DateTime)dt["NGAYSINH"];
            diachi = dt["DIACHI"].ToString();
            panel3.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            nHANVIENGridControl.Enabled = false;
            check_them = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhanvienBS.CancelEdit();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            nHANVIENGridControl.Enabled = true;
            this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
            nhanvienBS.Position = vitri;
            panel3.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
                this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
                nhanvienBS.Position = vitri;

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
            this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
            nHANVIENGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            nHANVIENGridControl.Enabled = true;
            nhanvienBS.Position = vitri;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TEN1.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống!", "", MessageBoxButtons.OK);
                TEN1.Focus();
                return;
            }
            if (Regex.IsMatch(TEN1.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Tên chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                TEN1.Focus();
                return;
            }
            if (HO1.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống!", "", MessageBoxButtons.OK);
                HO1.Focus();
                return;
            }
            if (Regex.IsMatch(HO1.Text.Trim(), @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Họ chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                HO1.Focus();
                return;
            }
            if (DIACHI1.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!", "", MessageBoxButtons.OK);
                DIACHI1.Focus();
                return;
            }
            if (Regex.IsMatch(DIACHI1.Text.Trim(), @"^[a-zA-Z0-9,.ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ có chữ số, chữ cái, khoảng trắng và dấu phẩy", "Thông báo", MessageBoxButtons.OK);
                DIACHI1.Focus();
                return;
            }
            if (SOCMND1.Text.Trim() == "")
            {
                MessageBox.Show("Số cmnd không được để trống!", "", MessageBoxButtons.OK);
                SOCMND1.Focus();
                return;
            }
            if (Regex.IsMatch(SOCMND1.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số cmdn chỉ có chữ số", "Thông báo", MessageBoxButtons.OK);
                SOCMND1.Focus();
                return;
            }

            if (NGAYSINH1.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh không được để trống!", "", MessageBoxButtons.OK);
                NGAYSINH1.Focus();
                return;
            }
          



            try
            {
                nhanvienBS.EndEdit();
                nhanvienBS.ResetCurrentItem();
                this.nhanvienTA.Update(this.tAIKHOANDataSet1.NHANVIEN);
                String query = "";
                if (check_them)
                {

                    query = "DELETE DBO.NHANVIEN WHERE MANV = " + MANV1.Text.Trim();

                }
                else
                {
                    query = "UPDATE DBO.NhanVien " +
                            "SET " +
                            "HO = N'" + ho + "'," +
                            "TEN = N'" + ten + "'," +
                            "SOCMND = '" + socmnd + "'," +
                            "DIACHI = N'" + diachi + "'," +
                            "NGAYSINH = '" + ngaysinh+ "' " +
                            "WHERE MANV = " + manv + "";

                }
                Console.WriteLine(query);
                stack.Push(query);
                nhanvienBS.Position = vitri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên\n" + ex.Message, "", MessageBoxButtons.OK);
                nhanvienBS.Position = vitri;
                return;
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            panel3.Enabled = false;
            nHANVIENGridControl.Enabled = true;
            nhanvienBS.Position = vitri;
        }
    }
}
