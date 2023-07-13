using DevExpress.Utils.Extensions;
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
    public partial class FormTacPhamNgheThuat : Form
    {
        public FormTacPhamNgheThuat()
        {
            InitializeComponent();
        }

        FormDieuKhacTacTuong formDieuKhacTacTuong = new FormDieuKhacTacTuong();
        FormHoiHoa formHoiHoa = new FormHoiHoa();
        FormLoaiHinhKhac formLoaiHinhKhac = new FormLoaiHinhKhac();
        FormSoHuu formSoHuu = new FormSoHuu();
        FormDiMuon formDiMuon = new FormDiMuon();

        int vitri = 0;
        bool check_them = false;
        int maso = 0;
        int idxx = 0;
        String chude = "";
        String loidiengiai = "";
        String tentg = "";
        DateTime namst;

        String query_them = "";
        Stack<string> stack = new Stack<string>();

        private string ToString(DateTime? dt, string format)
        {
            return dt == null ? "NULL" : "'" + ((DateTime)dt).ToString(format) + "'";
        }
        private void FormTacPhamNgheThuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BAOTANGDS.CT_TRIENLAM' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'BAOTANGDS.CTTPNT' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'BAOTANGDS.DIMUON' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'BAOTANGDS.TTXUATXU' table. You can move, or remove it, as needed.

            BAOTANGDS.EnforceConstraints = false;
            this.tpntTA.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'bAOTANGDataSet.TPNT' table. You can move, or remove it, as needed.
            this.tpntTA.Fill(this.BAOTANGDS.TPNT);
            this.dimuonTA.Connection.ConnectionString = Program.connstr;
            this.dimuonTA.Fill(this.BAOTANGDS.DIMUON);
            this.tacgiaTA.Connection.ConnectionString = Program.connstr;
            this.xuatxuTA.Fill(this.BAOTANGDS.TTXUATXU);
            // TODO: This line of code loads data into the 'BAOTANGDS.TTTACGIA' table. You can move, or remove it, as needed.
            this.tacgiaTA.Connection.ConnectionString = Program.connstr;
            this.tacgiaTA.Fill(this.BAOTANGDS.TTTACGIA);
            this.cttpntTA.Connection.ConnectionString = Program.connstr;
            this.cttpntTA.Fill(this.BAOTANGDS.CTTPNT);
            this.cT_TRIENLAMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_TRIENLAMTableAdapter.Fill(this.BAOTANGDS.CT_TRIENLAM);

            CBLH.Items.Add("Điêu khắc - Tạc tượng");
            CBLH.Items.Add("Hội hoại");
            CBLH.Items.Add("Loại hình khác");
            CBLSH.Items.Add("Sở hữu");
            CBLSH.Items.Add("Đi mượn");
            if (Program.mGroup == "USER")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnHuy.Enabled = btnGhi.Enabled = false;

            }
            else
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    =  true;
                btnHuy.Enabled = btnGhi.Enabled = false;
            }
        }

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{
        //    if (CBLH.SelectedIndex == 0)
        //    {
        //        formDieuKhacTacTuong.ShowDialog();
        //    }
        //    if (CBLH.SelectedIndex == 1)
        //    {
        //        formHoiHoa.ShowDialog();
        //    }
        //    if (CBLH.SelectedIndex == 2)
        //    {
        //        formLoaiHinhKhac.ShowDialog();
        //    }
        //}

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CBLSH.SelectedIndex == 0)
            {
                formSoHuu.ShowDialog();
            }
            if (CBLSH.SelectedIndex == 1)
            {
                formDiMuon.ShowDialog();
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CBLH.SelectedIndex == 0)
            {
                formDieuKhacTacTuong.ShowDialog();
            }
            if (CBLH.SelectedIndex == 1)
            {
                formHoiHoa.ShowDialog();
            }
            if (CBLH.SelectedIndex == 2)
            {
                formLoaiHinhKhac.ShowDialog();
            }
        }

       

        //private void simpleButton1_Click_2(object sender, EventArgs e)
        //{
        //    if (CBLH.SelectedIndex == 0)
        //    {
        //        formDieuKhacTacTuong.ShowDialog();
        //    }
        //    if (CBLH.SelectedIndex == 1)
        //    {
        //        formHoiHoa.ShowDialog();
        //    }
        //    if (CBLH.SelectedIndex == 2)
        //    {
        //        formLoaiHinhKhac.ShowDialog();
        //    }
        //}

        //private void simpleButton2_Click_1(object sender, EventArgs e)
        //{

        //    if (CBLSH.SelectedIndex == 0)
        //    {
        //        formSoHuu.ShowDialog();
        //    }
        //    if (CBLSH.SelectedIndex == 1)
        //    {
        //        formDiMuon.ShowDialog();
        //    }
        //}

        

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = tpntBS.Position;
            panel3.Enabled = true;
            tpntBS.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled =
            btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            tpntGridControl.Enabled = false;
            check_them = true;
            Program.check_them_gl = true;
            Program.maso = int.Parse(MASO.Text.ToString());
            //String laymaso = "Select [dbo].LayMaSo()";
            //Console.WriteLine(laymaso);
            CBLH.SelectedItem = null;
            CBLSH.SelectedItem = null;
            //try
            //{
            //    Program.myReader = Program.ExecSqlDataReader(laymaso);
            //    if (Program.myReader == null) { return; }
            //    Program.myReader.Read();
            //    Program.maso = Program.myReader.GetInt32(0);
            //    Program.myReader.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi kết nối! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            //    return;
            //}


        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (cttlBS.Count > 0)

            {
                MessageBox.Show("Không thể xóa tác phẩm này vì tồn tại trong triển lãm!", "", MessageBoxButtons.OK);
                return;

            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa tác phẩm này!", "Xác nhận", MessageBoxButtons.OKCancel)
               == DialogResult.OK)
            {
                try
                {

                    Program.myReader.Close();
                    String queryLoaiHinh = "Select dbo.LayChuoiInsertLoaiHinh(" + MASO.Text.ToString() + ")";
                    Program.myReader = Program.ExecSqlDataReader(queryLoaiHinh);
                    if (Program.myReader == null) { return; }
                    Program.myReader.Read();
                    string chuoiLoaiHinh = Program.myReader.GetString(0);

                    Program.myReader.Close();
                    String querySohuu = "Select dbo.LayChuoiInsertLoaiSoHuu(" + MASO.Text.ToString() + ")";
                    Program.myReader = Program.ExecSqlDataReader(querySohuu);
                    if (Program.myReader == null) { return; }
                    Program.myReader.Read();
                    string chuoiSohuu = Program.myReader.GetString(0);
                    Program.myReader.Close();

                    if (chuoiLoaiHinh == "NULL" || chuoiSohuu == "NULL")
                    {
                        MessageBox.Show("Lỗi lưu lịch sử loại hình và loại sở hữu!", "", MessageBoxButtons.OK);
                        return;
                    }

                    DataRowView dt = ((DataRowView)tpntBS[tpntBS.Position]);
                    maso = int.Parse(dt["MASO"].ToString());
                    chude = dt["CHUDE"].ToString();
                    loidiengiai = dt["LOIDIENGIAI"].ToString();
                    tentg = dt["TENTG"].ToString();
                    idxx =int.Parse(dt["IDXX"].ToString());
                    namst = (DateTime)dt["NAMST"];
                    
                 
                    tpntBS.RemoveCurrent();
                    this.tpntTA.Connection.ConnectionString = Program.connstr;
                    this.tpntTA.Update(this.BAOTANGDS.TPNT);
                    String query = String.Format("INSERT INTO DBO.TPNT(MASO,NAMST,LOIDIENGIAI,TENTG,CHUDE,IDXX) " +
                                                " VALUES({0},{1},N'{2}',N'{3}', N'{4}' ,{5})", maso, ToString(namst, "yyyy-MM-dd"), loidiengiai, tentg, chude, idxx)
                                            + "   " + chuoiLoaiHinh + "   " + chuoiSohuu;
                    Console.WriteLine(query);
                    stack.Push(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa tác phẩm nghệ thuật. Bạn hãy xóa lại \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tpntTA.Fill(this.BAOTANGDS.TPNT);
                    tpntBS.Position = tpntBS.Find("MASO", maso);
                    return;
                }
            }
            if (tpntBS.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn sửa tác phẩm này!", "Xác nhận", MessageBoxButtons.OKCancel)
               == DialogResult.OK)
            {
                Program.myReader.Close();
                String queryLoaiHinh = "Select dbo.LayChuoiInsertLoaiHinh(" + MASO.Text.ToString() + ")";
                Program.myReader = Program.ExecSqlDataReader(queryLoaiHinh);
                if (Program.myReader == null) { return; }
                Program.myReader.Read();
                string chuoiLoaiHinh = Program.myReader.GetString(0);

                Program.myReader.Close();
                String querySohuu = "Select dbo.LayChuoiInsertLoaiSoHuu(" + MASO.Text.ToString() + ")";
                Program.myReader = Program.ExecSqlDataReader(querySohuu);
                if (Program.myReader == null) { return; }
                Program.myReader.Read();
                string chuoiSohuu = Program.myReader.GetString(0);
                Program.myReader.Close();

                if (chuoiLoaiHinh == "NULL" || chuoiSohuu == "NULL") {
                    MessageBox.Show("Lỗi lưu lịch sử loại hình và loại sở hữu!", "", MessageBoxButtons.OK);
                    return; 
                }
                CBLH.SelectedItem = null;
                CBLSH.SelectedItem = null;
                query_them = "   " + chuoiLoaiHinh + "   " + chuoiSohuu;
                Console.WriteLine(query_them);
                vitri = tpntBS.Position;
                DataRowView dt = ((DataRowView)tpntBS[tpntBS.Position]);
                maso = int.Parse(dt["MASO"].ToString());
                chude = dt["CHUDE"].ToString();
                loidiengiai = dt["LOIDIENGIAI"].ToString();
                tentg = dt["TENTG"].ToString();
                idxx = int.Parse(dt["IDXX"].ToString());
                namst = (DateTime)dt["NAMST"];
                panel3.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                tpntGridControl.Enabled = false;
                check_them = false;
                
            }
            
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (LOIDIENGIAI.Text.Trim() == "")
            {
                MessageBox.Show("Lời diễn giải không được để trống!", "", MessageBoxButtons.OK);
                LOIDIENGIAI.Focus();
                return;
            }
            if (Regex.IsMatch(LOIDIENGIAI.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Lời diễn giải chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                LOIDIENGIAI.Focus();
                return;
            }

            if (CBLH.Text.Trim() == "")
            {
                MessageBox.Show("Loại hình không được để trống!", "", MessageBoxButtons.OK);
                CBLH.Focus();
                return;
            }
            if (CBLSH.Text.Trim() == "")
            {
                MessageBox.Show("Loại sở hữu không được để trống!", "", MessageBoxButtons.OK);
                CBLH.Focus();
                return;
            }
            if (NAMSANGTAC.Text.Trim() == "")
            {
                MessageBox.Show("Năm sáng tác không được để trống!", "", MessageBoxButtons.OK);
                CBLH.Focus();
                return;
            }
            if (XUATXU.Text.Trim() == "")
            {
                MessageBox.Show("Xuất xứ không được để trống!", "", MessageBoxButtons.OK);
                CBLH.Focus();
                return;
            }
            if (TENTACGIA.Text.Trim() == "")
            {
                MessageBox.Show("Tên tác giả không được để trống!", "", MessageBoxButtons.OK);
                TENTACGIA.Focus();
                return;
            }
         
            if (Regex.IsMatch(CHUDE.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Chủ đề chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                CHUDE.Focus();
                return;
            }
            if (CHUDE.Text.Trim() == "")
            {
                MessageBox.Show("Chủ đề không được để trống!", "", MessageBoxButtons.OK);
                CHUDE.Focus();
                return;
            }
            
            try
            {

                tpntBS.EndEdit();
                tpntBS.ResetCurrentItem();
                this.tpntTA.Update(this.BAOTANGDS.TPNT);
                Program.myReader.Close();
                String query = "";
                if (check_them)
                {
                    query = "DELETE DBO.TPNT WHERE MASO = " + MASO.Text.Trim();

                }
                else
                {
                    query = "UPDATE DBO.TPNT " +
                            "SET " +
                            "NAMST = " + ToString(namst, "yyyy-MM-dd") + "," +
                            "CHUDE = N'" + chude + "'," +
                            "LOIDIENGIAI = N'" + loidiengiai + "'," +
                            "TENTG = N'" + tentg + "'," +
                            "IDXX = " + idxx + " " +
                            " WHERE MASO = N'" + MASO.Text.ToString() + "'"  +
                            "  exec XoaLienQuanTPNT " + MASO.Text.ToString() + "   " +
                            query_them;

                }
                Console.WriteLine(query);
                String queryXoa = "exec XoaLienQuanTPNT " + MASO.Text.ToString();
                Program.ExecSqlNonQuery(queryXoa);
                Program.myReader.Close();

                if (CBLH.SelectedIndex == 0)
                {
                    String queryInsert = String.Format("INSERT INTO DBO.DIEUKHAC_TACTUONG(MASO,VATLIEU,CHIEUCAO,KHOILUONG,PHONGCACH) " +
                                                                    " VALUES({0},N'{1}',{2},{3}, N'{4}')",
                                                              MASO.Text.ToString(), formDieuKhacTacTuong.vatlieu, formDieuKhacTacTuong.chieucao, formDieuKhacTacTuong.khoiluong, formDieuKhacTacTuong.phongcach);
                    Program.ExecSqlNonQuery(queryInsert);
                    Console.WriteLine(queryInsert);

                }
                if (CBLH.SelectedIndex == 1)
                {
                    String queryInsert = String.Format("INSERT INTO DBO.HOIHOA(MASO,VATLIEU,CHATLIEU,TRUONGPHAI) " +
                                                                    " VALUES({0},N'{1}',N'{2}',N'{3}')",
                                                                   MASO.Text.ToString(), formHoiHoa.vatlieu, formHoiHoa.chatlieu, formHoiHoa.truongphai);
                    Program.ExecSqlNonQuery(queryInsert);
                    Console.WriteLine(queryInsert);

                }
                if (CBLH.SelectedIndex == 2)
                {
                    String queryInsert = String.Format("INSERT INTO DBO.LOAIHINHKHAC(MASO,THELOAI,PHONGCACH) " +
                                                                    " VALUES({0},N'{1}',N'{2}')",
                                                                   MASO.Text.ToString(), formLoaiHinhKhac.theloai, formLoaiHinhKhac.phongcach);
                    Program.ExecSqlNonQuery(queryInsert);
                    Console.WriteLine(queryInsert);

                }
                if (CBLSH.SelectedIndex == 0)
                {
                    String queryInsert = String.Format("INSERT INTO DBO.SOHUU(MASO,NGAYSOHUU,TINHTRANG,TRIGIA) " +
                                                                    " VALUES({0},{1},N'{2}',{3})",
                                                          MASO.Text.ToString(), ToString(formSoHuu.ngaysohuu, "yyyy-MM-dd"),formSoHuu.tinhtrang, formSoHuu.trigia);
                    Program.ExecSqlNonQuery(queryInsert);
                    Console.WriteLine(queryInsert);

                }
                if (CBLSH.SelectedIndex == 1)
                {
                    String queryInsert = String.Format("INSERT INTO DBO.DIMUON(MATPNT,TENBST,NGAYMUON,NGAYTRA) " +
                                                                    " VALUES({0},N'{1}',{2},{3})",
                                                          MASO.Text.ToString(), formDiMuon.tenbst, ToString(formDiMuon.ngaymuon, "yyyy-MM-dd"), ToString(formDiMuon.ngaytra, "yyyy-MM-dd"));
                    Program.ExecSqlNonQuery(queryInsert);
                    Console.WriteLine(queryInsert);

                }
                
                stack.Push(query);
                tpntBS.Position = vitri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi tác phẩm nghệ thuật\n" + ex.Message, "", MessageBoxButtons.OK);
                tpntBS.Position = vitri;
                return;
            }
            this.cttpntTA.Fill(this.BAOTANGDS.CTTPNT);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            panel3.Enabled = false;
            tpntGridControl.Enabled = true;
            tpntBS.Position = vitri;
            CBLH.SelectedItem = null;
            CBLSH.SelectedItem = null;
        }

        private void CBTAGGIA_SelectedIndexChanged(object sender, EventArgs e)
        {
            TENTACGIA.Text = CBTAGGIA.Text.Trim();
        }

        private void CBXUATXU_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CBXUATXU.SelectedItem != null)
                    XUATXU.Text = CBXUATXU.SelectedValue.ToString();
            }
           catch (Exception) { }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tpntBS.CancelEdit();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            tpntGridControl.Enabled = true;
            this.tpntTA.Fill(this.BAOTANGDS.TPNT);
            tpntBS.Position = vitri;
            panel3.Enabled = false;
            CBLH.SelectedItem = null;
            CBLSH.SelectedItem = null;

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
            this.tpntTA.Fill(this.BAOTANGDS.TPNT);
            this.cttpntTA.Fill(this.BAOTANGDS.CTTPNT);
            tpntGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            tpntBS.Position = vitri;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tpntTA.Fill(this.BAOTANGDS.TPNT);
                this.tacgiaTA.Fill(this.BAOTANGDS.TTTACGIA);
                this.xuatxuTA.Fill(this.BAOTANGDS.TTXUATXU);
                this.cttpntTA.Fill(this.BAOTANGDS.CTTPNT);
                tpntBS.Position = vitri;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
