using DevExpress.DataAccess.Wizard.Model;
using DevExpress.XtraEditors;
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
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
        }
        int vitri = 0;

        bool check_them = true;

        int user = 0;
        String login = "";
        int manv;
        String pass = "";
        String group = "";

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            tAIKHOANDataSet1.EnforceConstraints = false;
            this.nhanvienTA.Connection.ConnectionString = Program.connstr;
            this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
            this.userTA.Connection.ConnectionString = Program.connstr;
            this.userTA.Fill(this.tAIKHOANDataSet1.USER);
            this.groupTA.Connection.ConnectionString = Program.connstr;
            this.groupTA.Fill(this.tAIKHOANDataSet1.GROUP);
            this.loginTA.Connection.ConnectionString = Program.connstr;
            this.loginTA.Fill(this.tAIKHOANDataSet1.LOGIN);
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            GROUPP.Items.Add("ADMIN");
            GROUPP.Items.Add("USER");

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (LOGINNAME.Text.ToString() != "")
            {
                MessageBox.Show("Nhân viên này đã có tài khoản", "", MessageBoxButtons.OK);
                return;
            }
            //GROUPP.Items.Add("ADMIN");
            //GROUPP.Items.Add("USER");
            vitri = nhanvienBS.Position;
            panel3.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = GROUPP.Enabled = LOGINNAME.Enabled = PASSWORD.Visible = passLabel.Visible = true;
            comboBox1.Visible = false;
            nHANVIENGridControl.Enabled = false;
            check_them = true;
        }

        private void loginnameTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (LOGINNAME.Text.ToString() == "")
            {
                MessageBox.Show("Nhân viên này chưa có tài khoản !", "", MessageBoxButtons.OK);
                return;
            }

            if (LOGINNAME.Text.ToString().Trim().ToUpper() == Program.mloginDN.ToUpper())
            {
                MessageBox.Show("Không thể xóa tài khoản đang hoạt động !", "", MessageBoxButtons.OK);
                return;
            }

         
            login = LOGINNAME.Text.ToString().Trim();
            group = GROUPP.Text.ToString().Trim();

            if (MessageBox.Show("Bạn có thực sự muốn xóa tài khoản nhân viên này!", "Xác nhận", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                try
                {

                    String query = String.Format("exec sp_Drop_Account '{0}', '{1}', {2}", LOGINNAME.Text.ToString().Trim(), GROUPP.Text.ToString().Trim(), MANV.Text.ToString());

                    Console.WriteLine(query);

                    Program.ExecSqlNonQuery(query);
                    this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
                    this.userTA.Fill(this.tAIKHOANDataSet1.USER);
                    this.groupTA.Fill(this.tAIKHOANDataSet1.GROUP);
                    this.loginTA.Fill(this.tAIKHOANDataSet1.LOGIN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa tài khoản nhân viên. Bạn hãy xóa lại \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
                    nhanvienBS.Position = nhanvienBS.Find("MANV", manv);
                    return;
                }
            }

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GROUPP.Text.Trim() == "")
            {
                MessageBox.Show("Quyền không được bỏ trống!", "", MessageBoxButtons.OK);
                GROUPP.Focus();
                return;
            }
            if (LOGINNAME.Text.Trim() == "")
            {
                MessageBox.Show("Login name không được để trống!", "", MessageBoxButtons.OK);
                LOGINNAME.Focus();
                return;
            }

            if (Regex.IsMatch(LOGINNAME.Text, @"^[a-zA-Z ]+$") == false)
            {
                MessageBox.Show("Login name chỉ có chữ cái tiếng anh và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                LOGINNAME.Focus();
                return;
            }

            if (PASSWORD.Text.Trim() == "")
            {
                MessageBox.Show("Password không được để trống!", "", MessageBoxButtons.OK);
                PASSWORD.Focus();
                return;
            }
              
            

            if (check_them == true)
            {
                String checklogin =
                  "DECLARE	@result int " +
                  "EXEC @result = [dbo].[sp_Check_Exists_Login] " +
                  LOGINNAME.Text.Trim().ToUpper() +
                  "  SELECT 'result' = @result";
                Console.WriteLine(checklogin);
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(checklogin);
                    if (Program.myReader == null) { return; }
                    Program.myReader.Read();
                    if (Program.myReader.GetInt32(0) == 1)
                    {
                        MessageBox.Show("Login name đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                        LOGINNAME.Focus();
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

                Console.WriteLine(Program.mloginDN);
                try
                {

                    String query = String.Format("exec sp_Create_Account '{0}', '{1}', '{2}', {3}",
                        LOGINNAME.Text.ToString().Trim(), PASSWORD.Text.ToString(), GROUPP.Text.ToString().Trim(), MANV.Text.ToString());

                    Console.WriteLine(query);
                    Program.ExecSqlNonQuery(query);

                    this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
                    this.userTA.Fill(this.tAIKHOANDataSet1.USER);
                    this.groupTA.Fill(this.tAIKHOANDataSet1.GROUP);
                    this.loginTA.Fill(this.tAIKHOANDataSet1.LOGIN);

                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                    btnGhi.Enabled = btnHuy.Enabled = GROUPP.Enabled = LOGINNAME.Enabled = PASSWORD.Visible = passLabel.Visible = false;
                    nHANVIENGridControl.Enabled = true;
                    loginnameOld.Visible = false;
                    comboBox1.Visible = true;
                    nhanvienBS.Position = vitri;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tạo tài khoản nhân viên. Bạn hãy tạo lại \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
                    nhanvienBS.Position = nhanvienBS.Find("MANV", manv);
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                    btnGhi.Enabled = btnHuy.Enabled = GROUPP.Enabled = LOGINNAME.Enabled = PASSWORD.Visible = passLabel.Visible = false;
                    nHANVIENGridControl.Enabled = true;
                    loginnameOld.Visible = false;
                    comboBox1.Visible = true;
                    nhanvienBS.Position = vitri;
                    return;
                }

            }

            else
            {
                Console.WriteLine(Program.mloginDN);
                try
                {

                    String query = String.Format("exec sp_Alter_Account '{0}', '{1}', '{2}'",
                        loginnameOld.Text.ToString().Trim(), LOGINNAME.Text.ToString().Trim(), PASSWORD.Text.ToString());

                    Console.WriteLine(query);
                    Program.ExecSqlNonQuery(query);

                    this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
                    this.userTA.Fill(this.tAIKHOANDataSet1.USER);
                    this.groupTA.Fill(this.tAIKHOANDataSet1.GROUP);
                    this.loginTA.Fill(this.tAIKHOANDataSet1.LOGIN);

                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                    btnGhi.Enabled = btnHuy.Enabled = GROUPP.Enabled = LOGINNAME.Enabled = PASSWORD.Visible = passLabel.Visible = false;
                    nHANVIENGridControl.Enabled = true;
                    loginnameOld.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa tài khoản nhân viên. Bạn hãy tạo lại \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
                    nhanvienBS.Position = nhanvienBS.Find("MANV", manv);
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                    btnGhi.Enabled = btnHuy.Enabled = GROUPP.Enabled = LOGINNAME.Enabled = PASSWORD.Visible = passLabel.Visible = false;
                    nHANVIENGridControl.Enabled = true;
                    loginnameOld.Visible = false;
                    comboBox1.Visible = true;
                    return;
                }
            }

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (LOGINNAME.Text.ToString() == "")
            {
                MessageBox.Show("Nhân viên này chưa có tài khoản !", "", MessageBoxButtons.OK);
                return;
            }
            vitri = nhanvienBS.Position;
            panel3.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = GROUPP.Enabled = LOGINNAME.Enabled = PASSWORD.Visible = passLabel.Visible = true;
            nHANVIENGridControl.Enabled = GROUPP.Enabled = false;
            comboBox1.Visible = false;
            loginnameOld.Visible = true;
            check_them = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBS.CancelEdit();
            loginBS.CancelEdit();
            nhanvienBS.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = GROUPP.Enabled = LOGINNAME.Enabled = PASSWORD.Visible = passLabel.Visible = false;
            nHANVIENGridControl.Enabled = true;
            loginnameOld.Visible = false;
            comboBox1.Visible = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            try
            {
                this.nhanvienTA.Fill(this.tAIKHOANDataSet1.NHANVIEN);
                this.userTA.Fill(this.tAIKHOANDataSet1.USER);
                this.groupTA.Fill(this.tAIKHOANDataSet1.GROUP);
                this.loginTA.Fill(this.tAIKHOANDataSet1.LOGIN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload !" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
