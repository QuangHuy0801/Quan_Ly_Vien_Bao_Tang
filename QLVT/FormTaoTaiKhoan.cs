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
    public partial class FormTaoTaiKhoan : Form
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("USER");
            comboBox.Items.Add("ADMIN");
        }

        private void buttonTao_Click(object sender, EventArgs e)
        {
            if (username.Text.Trim() == "")
            {
                MessageBox.Show("Username không được để trống!", "", MessageBoxButtons.OK);
                username.Focus();
                return;
            }
            if (Regex.IsMatch(username.Text, @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("Username chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                username.Focus();
                return;
            }

            if (password.Text.Trim() == "")
            {
                MessageBox.Show("Password không được để trống!", "", MessageBoxButtons.OK);
                username.Focus();
                return;
            }

            if (comboBox.Text.Trim() == "")
            {
                MessageBox.Show("Quyền không được để trống!", "", MessageBoxButtons.OK);
                username.Focus();
                return;
            }

            if (username.Text.ToUpper() == Program.mloginDN.ToUpper())
            {
                MessageBox.Show("Không thể tạo username trùng với username hiện tại !", "", MessageBoxButtons.OK);
                username.Focus();
                return;
            }


            try
            {
                Program.myReader.Close();
                String queryCheckLogin = "exec CheckLogin '" + username.Text.ToString() + "'";
                Console.WriteLine(queryCheckLogin);

                Program.myReader = Program.ExecSqlDataReader(queryCheckLogin);
                if (Program.myReader == null) { return; }
                Program.myReader.Read();
                int check = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (check == 1)
                {
                    MessageBox.Show("Username bị trùng !", "", MessageBoxButtons.OK);
                    username.Focus();
                    return;
                }

                String query = "exec [sp_Create_Account] '" + username.Text.ToString()  + "' , '" + password.Text.ToString() + "' , '" + comboBox.Text.ToString() + "'";
                Console.WriteLine(query);
                Program.ExecSqlNonQuery(query);
                

                MessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);
                return;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo tài khoản. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

        }
    }
}
