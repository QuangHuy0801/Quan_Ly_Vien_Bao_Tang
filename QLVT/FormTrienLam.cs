using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
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
using static DevExpress.Data.Helpers.FindSearchRichParser;

namespace QLVT
{
    public partial class FormTrienLam : Form
    {
        public FormTrienLam()
        {
            InitializeComponent();
        }

        int vitri = 0;

        bool check_them = true;

        DateTime ngaybatdau;
        DateTime ngayketthuc;
        int id;
        String ten;
        int matpnt;

        Stack<String> stack = new Stack<String>();
        Stack<String> stack2 = new Stack<String>();

        private void FormTrienLam_Load(object sender, EventArgs e)
        {
            BAOTANGDS.EnforceConstraints = false;
            this.trienlamTA.Connection.ConnectionString = Program.connstr;
            this.trienlamTA.Fill(this.BAOTANGDS.TRIENLAM);
            this.tpntTA.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'BAOTANGDS.TTTPNT' table. You can move, or remove it, as needed.
            this.tpntTA.Fill(this.BAOTANGDS.TTTPNT);
            // TODO: This line of code loads data into the 'BAOTANGDS.CT_TRIENLAM' table. You can move, or remove it, as needed.
            this.cttrienlamTA.Connection.ConnectionString = Program.connstr;
            this.cttrienlamTA.Fill(this.BAOTANGDS.CT_TRIENLAM);
            if (Program.mGroup == "USER")
            {
                btnThemTL.Enabled = btnXoaTL.Enabled = btnSuaTL.Enabled
                    = btnHuyTL.Enabled = btnGhiTL.Enabled = false;

            }
            else
            {
                btnThemTL.Enabled = btnXoaTL.Enabled = btnSuaTL.Enabled
                     = true;
                btnHuy.Enabled = btnGhi.Enabled = false;
            }

        }



        private void trienlam_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trienlam_btn.Caption.ToString().Trim() == "Chi tiết triển lãm")
            {
                trienlam_btn.Caption = "Triển lãm";
                trienlam_btn.ItemAppearance.Normal.BackColor = Color.LightGreen;
                panelCT1.Enabled = true;
                panelCT2.Visible = true;
                trienlamGridControl.Enabled = false;
                panelHCTL.Enabled = true;
                panel4.Enabled = true;
                panelHieuChinh.Enabled = false;
            }
            else 
            {
                trienlam_btn.Caption = "Chi tiết triển lãm";
                trienlam_btn.ItemAppearance.Normal.BackColor = Color.LightYellow;
                panelCT1.Enabled = false;
                panelCT2.Visible = false;
                trienlamGridControl.Enabled = true;
                panel4.Enabled = true;
                panelHCTL.Enabled = false;
                panelHieuChinh.Enabled = false;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trienlam_btn.Caption.ToString().Trim() == "Chi tiết triển lãm")
            {
                btnThemTL.Enabled = btnXoaTL.Enabled = btnSuaTL.Enabled = btnReloadTL.Enabled = btnThoatTL.Enabled 
                    = btnPhucHoiTL.Enabled = false;
                btnGhiTL.Enabled = btnHuyTL.Enabled = true;
                trienlamGridControl.Enabled = false;
                check_them = true;
                panelHieuChinh.Enabled = true;
                trienlam_btn.Enabled = false;
                panelCT2.Enabled = false;
                panelHCTL.Enabled = true;
                vitri = trienlamBS.Position;
                trienlamBS.AddNew();
            }
            else
            {
                btnThemTL.Enabled = btnXoaTL.Enabled = btnSuaTL.Enabled = btnReloadTL.Enabled = btnThoatTL.Enabled = btnPhucHoiTL.Enabled  = false;
                btnGhiTL.Enabled = btnHuyTL.Enabled = true;
                check_them = true;
                vitri = cttrienlamBS.Position;
                panelHieuChinh.Enabled = true;
                ct_trienlamGridControl.Enabled = false;
                trienlam_btn.Enabled = false;
                panelCT2.Enabled = true;
                panelHCTL.Enabled = false;
                cttrienlamBS.AddNew();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.trienlamTA.Fill(this.BAOTANGDS.TRIENLAM);
                this.cttrienlamTA.Fill(this.BAOTANGDS.CT_TRIENLAM);
                this.tpntTA.Fill(this.BAOTANGDS.TTTPNT);
                trienlamBS.Position = vitri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload !" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trienlam_btn.Caption.ToString() == "Chi tiết triển lãm")
            {
                if (trienlamBS.Count == 0)
                {
                    MessageBox.Show("Không có gì để xóa!", "", MessageBoxButtons.OK);
                    return;
                }
                if (cttrienlamBS.Count > 0)

                {
                    MessageBox.Show("Không thể xóa triển lãm này vì đã có chi tiết triển lãm!", "", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Bạn có thực sự muốn xóa triển lãm này!", "Xác nhận", MessageBoxButtons.OKCancel)
                   == DialogResult.OK)
                {
                    try
                    {
                        DataRowView dt = ((DataRowView)trienlamBS[trienlamBS.Position]);
                        id = int.Parse(dt["ID"].ToString());
                        ngaybatdau = (DateTime)dt["NGAYBATDAU"];
                        ngayketthuc = (DateTime)dt["NGAYKETTHUC"];
                        ten = dt["TEN"].ToString();

                        trienlamBS.RemoveCurrent();
                        this.trienlamTA.Connection.ConnectionString = Program.connstr;
                        this.trienlamTA.Update(this.BAOTANGDS.TRIENLAM);
                        String query = string.Format("INSERT INTO DBO.TRIENLAM(NGAYBATDAU,NGAYKETTHUC,TEN) " +
                                                    " VALUES('{1}','{2}',N'{3}')",id, ngaybatdau, ngayketthuc, ten);
                        Console.WriteLine(query);
                        stack.Push(query);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa triển lãm. Bạn hãy xóa lại \n" + ex.Message, "", MessageBoxButtons.OK);
                        this.trienlamTA.Fill(this.BAOTANGDS.TRIENLAM);
                        trienlamBS.Position = trienlamBS.Find("ID", id);
                        return;
                    }
                }
                if (trienlamBS.Count == 0)
                {
                    btnXoa.Enabled = false;
                }
                btnGhiTL.Enabled = btnHuyTL.Enabled = false;
            }
            else
            {

                if (MessageBox.Show("Bạn có thực sự muốn xóa chi tiết triển lãm này!", "Xác nhận", MessageBoxButtons.OKCancel)
                   == DialogResult.OK)
                {
                    if (cttrienlamBS.Count == 0)
                    {
                        MessageBox.Show("Không có gì để xóa!", "", MessageBoxButtons.OK);
                        return;
                    }
                    try
                    {
                        DataRowView dt = ((DataRowView)cttrienlamBS[cttrienlamBS.Position]);
                        id = int.Parse(dt["ID_TL"].ToString());
                        matpnt = int.Parse(dt["MATPNT"].ToString());

                        cttrienlamBS.RemoveCurrent();
                        this.cttrienlamTA.Connection.ConnectionString = Program.connstr;
                        this.cttrienlamTA.Update(this.BAOTANGDS.CT_TRIENLAM);
                        String query = string.Format("INSERT INTO DBO.CT_TRIENLAM(ID_TL,MATPNT) " +
                                                    " VALUES({0},{1})", id, matpnt);
                        Console.WriteLine(query);
                        stack2.Push(query);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa chi tiết triển lãm. Bạn hãy xóa lại \n" + ex.Message, "", MessageBoxButtons.OK);
                        this.cttrienlamTA.Fill(this.BAOTANGDS.CT_TRIENLAM);
                        return;
                    }
                }
                if (cttrienlamBS.Count == 0)
                {
                    btnXoa.Enabled = false;
                }
                btnGhiTL.Enabled = btnHuyTL.Enabled = false;
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trienlam_btn.Caption.ToString().Trim() == "Chi tiết triển lãm")
            {
                trienlamBS.CancelEdit();
                this.trienlamTA.Fill(this.BAOTANGDS.TRIENLAM);
                trienlamBS.Position = vitri;
                btnThemTL.Enabled = btnXoaTL.Enabled = btnSuaTL.Enabled =
                    btnReloadTL.Enabled = btnThoatTL.Enabled = true;
                btnGhiTL.Enabled = btnHuyTL.Enabled = false;
                trienlamGridControl.Enabled = true;
                panelHieuChinh.Enabled = false;
                trienlam_btn.Enabled = true;

            }
            else
            {
                cttrienlamBS.CancelEdit();
                this.cttrienlamTA.Fill(this.BAOTANGDS.CT_TRIENLAM);
                cttrienlamBS.Position = vitri;
                btnThemTL.Enabled = btnXoaTL.Enabled = btnSuaTL.Enabled
                    = btnReloadTL.Enabled = btnThoatTL.Enabled = true;
                btnGhiTL.Enabled = btnHuyTL.Enabled = false;
                ct_trienlamGridControl.Enabled = true;
                panelHieuChinh.Enabled = false;
                trienlam_btn.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb.SelectedValue != null) MATPNT.Text = cb.SelectedValue.ToString();
            }
            catch(Exception ex) { }
        }

        private void btnGhiTL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trienlam_btn.Caption.ToString().Trim() == "Chi tiết triển lãm")
            {
                if (NGAYBATDAU.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày bắt đầu không được để trống!", "Thông báo", MessageBoxButtons.OK);
                    NGAYBATDAU.Focus();
                    return;
                }
                if (NGAYKETTHUC.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày kết thúc không được để trống!", "Thông báo", MessageBoxButtons.OK);
                    NGAYKETTHUC.Focus();
                    return;
                }
                if (DateTime.Parse(NGAYKETTHUC.Text.ToString()) < DateTime.Parse(NGAYBATDAU.Text.ToString()))

                {
                    MessageBox.Show("Thời gian sau phải lớn hơn thời gian trước!", "", MessageBoxButtons.OK);
                    return;
                }
                if (TEN.Text.Trim() == "")
                {
                    MessageBox.Show("Tên triển lãm không được để trống!", "Thông báo", MessageBoxButtons.OK);
                    TEN.Focus();
                    return;
                }

                if (Regex.IsMatch(TEN.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
                {
                    MessageBox.Show("Tên triễn lãm chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                    TEN.Focus();
                    return;
                }
                if (ID.Text.Trim() == "")
                {
                    MessageBox.Show("ID không được để trống!", "Thông báo", MessageBoxButtons.OK);
                    ID.Focus();
                    return;
                }
   

                try
                {
                    String query = "";
                    trienlamBS.EndEdit();
                    trienlamBS.ResetCurrentItem();
                    this.trienlamTA.Update(this.BAOTANGDS.TRIENLAM);

                    if (check_them)
                    {
                        query = "DELETE DBO.TRIENLAM WHERE ID = " + ID.Text.ToString().Trim();

                    }
                    else
                    {
                        query = "UPDATE DBO.TRIENLAM " +
                               "SET " +
                               "NGAYBATDAU = '" + ngaybatdau.ToString() + "'," +
                               "NGAYKETTHUC = '" + ngayketthuc.ToString() + "'," +
                               "TEN = N'" + ten + "' " +
                               "WHERE ID = " + id ;

                    }
                    Console.WriteLine(query);
                    stack.Push(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi triển lãm \n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                btnThemTL.Enabled = btnSuaTL.Enabled = btnXoaTL.Enabled = btnThoatTL.Enabled 
                    = btnReloadTL.Enabled = btnPhucHoiTL.Enabled = true;
                btnGhiTL.Enabled = btnHuyTL.Enabled = false;
                panelHieuChinh.Enabled = false;
                panelHCTL.Enabled = false;
                trienlamGridControl.Enabled = true;
                trienlam_btn.Enabled = true;
            }
            else
            {
                if (MATPNT.Text.Trim() == "")
                {
                    MessageBox.Show("Mã tác phẩm nghệ thuật không được để trống!", "Thông báo", MessageBoxButtons.OK);
                    MATPNT.Focus();
                    return;
                }
                String checkcttt =
                      "SELECT [dbo].KiemtraTonTaiCTTrienLam(" + ID.Text.ToString() + "," + MATPNT.Text.ToString() + ")";

                Console.WriteLine(checkcttt);
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(checkcttt);
                    if (Program.myReader == null) { return; }
                    Program.myReader.Read();
                    if (Program.myReader.GetInt32(0) == 1)
                    {

                        MessageBox.Show("Chi tiết triển lãm đã tồn tại ", "Thông báo", MessageBoxButtons.OK);
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


            try
                {
                    String query = "";
                    cttrienlamBS.EndEdit();
                    cttrienlamBS.ResetCurrentItem();
                    this.cttrienlamTA.Update(this.BAOTANGDS.CT_TRIENLAM);

                    if (check_them)
                    {

                        query = "DELETE DBO.CT_TRIENLAM WHERE ID_TL = " + ID.Text.ToString().Trim() + " AND MATPNT = " + MATPNT.Text.ToString();

                    }
                    else
                    {
                        query = "UPDATE DBO.CT_TRIENLAM " +
                               "SET " +
                               "ID_TL = " + id + "," +
                               "MATPNT = " + matpnt + " " +
                               "WHERE ID_TL = '" + ID.Text.ToString().Trim() + "' AND MATPNT = " + MATPNT.Text.ToString();

                    }
                    Console.WriteLine(query);
                    stack2.Push(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi chi tiết triển lãm \n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                btnThemTL.Enabled = btnSuaTL.Enabled = btnXoaTL.Enabled = btnThoatTL.Enabled = 
                    btnReloadTL.Enabled = btnPhucHoiTL.Enabled = true;
                btnGhiTL.Enabled = btnHuyTL.Enabled = false;
                panelHieuChinh.Enabled = false;
                ct_trienlamGridControl.Enabled = true;
                trienlam_btn.Enabled = true;
            }
        }

        private void btnSuaTL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trienlam_btn.Caption.ToString() == "Chi tiết triển lãm")
            {
                if (trienlamBS.Count == 0)
                {
                    MessageBox.Show("Không có gì để sửa!", "", MessageBoxButtons.OK);
                    return;
                }    
                vitri = trienlamBS.Position;
                DataRowView dt = ((DataRowView)trienlamBS[trienlamBS.Position]);
                id = int.Parse(dt["ID"].ToString());
                ngaybatdau = (DateTime)dt["NGAYBATDAU"];
                ngayketthuc = (DateTime)dt["NGAYKETTHUC"];
                ten = dt["TEN"].ToString();
                panelHieuChinh.Enabled = true;
                panelCT2.Enabled = false;
                panelHCTL.Enabled = true;
                btnThemTL.Enabled = btnXoaTL.Enabled = btnSuaTL.Enabled = btnReloadTL.Enabled 
                    = btnThoatTL.Enabled = btnPhucHoiTL.Enabled = false;
                btnGhiTL.Enabled = btnHuyTL.Enabled = true;
                trienlamGridControl.Enabled = false;
                trienlam_btn.Enabled = false;
                check_them = false;
            }
            else
            {
                if (cttrienlamBS.Count == 0)
                {
                    MessageBox.Show("Không có gì để sửa!", "", MessageBoxButtons.OK);
                    return;
                }
                vitri = cttrienlamBS.Position;
                DataRowView dt = ((DataRowView)cttrienlamBS[cttrienlamBS.Position]);
                matpnt = int.Parse(dt["MATPNT"].ToString());
                id = int.Parse(dt["ID_TL"].ToString());
                panelHieuChinh.Enabled = true;
                panelCT2.Enabled = true;
                panelHCTL.Enabled = false;
                btnThemTL.Enabled = btnXoaTL.Enabled = btnSuaTL.Enabled = btnReloadTL.Enabled = btnThoatTL.Enabled
                    = btnPhucHoiTL.Enabled = false;
                btnGhiTL.Enabled = btnHuyTL.Enabled = true;
                ct_trienlamGridControl.Enabled = false;
                trienlam_btn.Enabled = false;
                check_them = false;
            }
        }

        private void btnPhucHoiTL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trienlam_btn.Caption.ToString() == "Chi tiết triển lãm")
            {
                if (stack.Count == 0)
                {
                    MessageBox.Show("Không có gì để phục hồi!", "", MessageBoxButtons.OK);
                    ; return;
                }


                string query = stack.Pop();
                Program.ExecSqlNonQuery(query);

                this.trienlamTA.Fill(this.BAOTANGDS.TRIENLAM);

                trienlamGridControl.Enabled = true;
                btnThemTL.Enabled = btnXoaTL.Enabled = btnSuaTL.Enabled = btnReloadTL.Enabled = btnThoatTL.Enabled 
                    = btnPhucHoiTL.Enabled = true;
                btnGhiTL.Enabled = btnHuyTL.Enabled = false;
            }
            else
            {
                if (stack2.Count == 0)
                {
                    MessageBox.Show("Không có gì để phục hồi!", "", MessageBoxButtons.OK);
                    ; return;
                }


                string query = stack2.Pop();
                Program.ExecSqlNonQuery(query);
                 
                this.cttrienlamTA.Fill(this.BAOTANGDS.CT_TRIENLAM);

                btnThemTL.Enabled = btnXoaTL.Enabled = btnSuaTL.Enabled = btnReloadTL.Enabled 
                    = btnThoatTL.Enabled = btnPhucHoiTL.Enabled = true;
                btnGhiTL.Enabled = btnHuyTL.Enabled = false;
                ct_trienlamGridControl.Enabled = true;
            }
        }
    }
}
