using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BT02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strcon = @"Provider = Microsoft.ACE.oledb.12.0; data source=..\..\..\DATA\QLSINHVIEN.mdb";
        OleDbConnection cnn;
        DataSet dts = new DataSet();
        DataTable tblKhoa = new DataTable("KHOA");
        DataTable tblSinhVien = new DataTable("SINHVIEN");
        DataTable tblKetQua = new DataTable("KETQUA");

        OleDbCommand cmdKhoa, cmdSinhVien, cmdKetQua;

        int stt = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn = new OleDbConnection(strcon);
            taoCauTrucBang();
            mocNoiQuanHe();
            nhapLieuTuCSDL();
            khoiTaoComboKhoa();
            stt = 0;
            GanDuLieu(stt);
        }

        private void taoCauTrucBang()
        {
            //Cau truc datatable tuong ung bang KHOA
            tblKhoa.Columns.Add("MaKH", typeof(string));
            tblKhoa.Columns.Add("TenKH", typeof(string));

            tblKhoa.PrimaryKey = new DataColumn[] { tblKhoa.Columns["MaKH"] };

            //Cau truc datatable tuong ung bang SINHVIEN
            tblSinhVien.Columns.Add("MaSV", typeof(string));
            tblSinhVien.Columns.Add("HoSV", typeof(string));
            tblSinhVien.Columns.Add("TenSV", typeof(string));
            tblSinhVien.Columns.Add("Phai", typeof(Boolean));
            tblSinhVien.Columns.Add("NgaySinh", typeof(DateTime));
            tblSinhVien.Columns.Add("NoiSinh", typeof(string));
            tblSinhVien.Columns.Add("MaKH", typeof(string));
            tblSinhVien.Columns.Add("HocBong", typeof(double));

            tblSinhVien.PrimaryKey = new DataColumn[] { tblSinhVien.Columns["MaSV"] };

            //Cau truc datatable tuong ung bang KETQUA
            tblKetQua.Columns.Add("MaSV", typeof(string));
            tblKetQua.Columns.Add("MaMH", typeof(string));
            tblKetQua.Columns.Add("Diem", typeof(double));

            tblKetQua.PrimaryKey = new DataColumn[] { tblKetQua.Columns["MaSV"], tblKetQua.Columns["MaMH"] };

            //Them dong thoi nhieu datatable vao dataset
            dts.Tables.AddRange(new DataTable[] { tblSinhVien, tblKhoa, tblKetQua });
        }

        private void mocNoiQuanHe()
        {
            dts.Relations.Add("FK_KH_SV", dts.Tables["KHOA"].Columns["MaKH"], dts.Tables["SINHVIEN"].Columns["MaKH"]);
            dts.Relations.Add("FK_SV_KQ", dts.Tables["SINHVIEN"].Columns["MaSV"], dts.Tables["KETQUA"].Columns["MaSV"]);

            dts.Relations["FK_KH_SV"].ChildKeyConstraint.DeleteRule = Rule.None;
            dts.Relations["FK_SV_KQ"].ChildKeyConstraint.DeleteRule = Rule.None;
        }

        private void nhapLieuTuCSDL()
        {
            nhapLieuTblKhoa();
            nhapLieuTblSinhVien();
            nhapLieuTblKetQua();
        }

        private void nhapLieuTblKhoa()
        {
            cnn.Open();
            cmdKhoa = new OleDbCommand("Select * from KHOA", cnn);
            OleDbDataReader rkh = cmdKhoa.ExecuteReader();
            while (rkh.Read())
            {
                DataRow r = tblKhoa.NewRow();
                for (int i = 0; i < rkh.FieldCount; i++)
                    r[i] = rkh[i];
                tblKhoa.Rows.Add(r);
            }
            rkh.Close();
            cnn.Close();
        }

        private void nhapLieuTblSinhVien()
        {
            cnn.Open();
            cmdSinhVien = new OleDbCommand("Select * from SINHVIEN", cnn);
            OleDbDataReader rsv = cmdSinhVien.ExecuteReader();
            while (rsv.Read())
            {
                DataRow r = tblSinhVien.NewRow();
                for (int i = 0; i < rsv.FieldCount; i++)
                    r[i] = rsv[i];
                tblSinhVien.Rows.Add(r);
            }
            rsv.Close();
            cnn.Close();
        }

        private void nhapLieuTblKetQua()
        {
            cnn.Open();
            cmdKetQua = new OleDbCommand("Select * from KETQUA", cnn);
            OleDbDataReader rkq = cmdKetQua.ExecuteReader();
            while (rkq.Read())
            {
                DataRow r = tblKetQua.NewRow();
                for (int i = 0; i < rkq.FieldCount; i++)
                    r[i] = rkq[i];
                tblKetQua.Rows.Add(r);
            }
            rkq.Close();
            cnn.Close();
        }

        private void khoiTaoComboKhoa()
        {
            cbbKhoa.DisplayMember = "TenKH";
            cbbKhoa.ValueMember = "MaKH";
            cbbKhoa.DataSource = tblKhoa;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (stt == 0) return;
            stt--;
            GanDuLieu(stt);
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (stt == tblSinhVien.Rows.Count - 1) return;
            stt++;
            GanDuLieu(stt);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSV.ReadOnly = false;
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    (ctr as TextBox).Clear();
                }
                else if (ctr is CheckBox)
                {
                    (ctr as CheckBox).Checked = true;
                }
                else if (ctr is ComboBox)
                {
                    (ctr as ComboBox).SelectedIndex = 0;
                }
                else if (ctr is DateTimePicker)
                {
                    (ctr as DateTimePicker).Value = new DateTime(2006, 1, 1);
                }
            }
            txtMaSV.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DataRow rsv = tblSinhVien.Rows.Find(txtMaSV.Text);
            DataRow[] mangDongLienQuan = rsv.GetChildRows("FK_SV_KQ");
            if (mangDongLienQuan.Length > 0)
            {
                MessageBox.Show("Sinh viên này đã thi, không được xóa!");
            }
            else
            {
                DialogResult tl;
                tl = MessageBox.Show("Bạn có chắc chắn xóa sinh viên này không?(y/n)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    rsv.Delete();
                    cnn.Open();
                    string chuoiXoa = "Delete from SINHVIEN where MaSV = '" + txtMaSV.Text + "'";
                    cmdSinhVien = new OleDbCommand(chuoiXoa, cnn);
                    int n = cmdSinhVien.ExecuteNonQuery();
                    if (n > 0)
                    {
                        MessageBox.Show("Xóa sinh viên thành công!");
                    }
                    cnn.Close();
                    btnTruoc.PerformClick();
                }
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            cnn.Open();
            if(txtMaSV.ReadOnly == true)
            {
                DataRow rsv = tblSinhVien.Rows.Find(txtMaSV.Text);
                rsv["HoSV"] = txtHo.Text;
                rsv["TenSV"] = txtTen.Text;
                rsv["Phai"] = chkPhai.Checked;
                rsv["NgaySinh"] = dtpNgaySinh.Text;
                rsv["NoiSinh"] = txtNoiSinh.Text;
                rsv["MaKH"] = cbbKhoa.SelectedValue.ToString();
                rsv["HocBong"] = txtHocBong.Text;

                string chuoiSua = "UPDATE SINHVIEN set ";
                chuoiSua += " HoSV = '" + txtHo.Text + "', ";
                chuoiSua += " TenSV = '" + txtTen.Text + "', ";
                chuoiSua += " Phai = " + chkPhai.Checked + ",";
                chuoiSua += " NgaySinh =#" + dtpNgaySinh.Value + "#,";
                chuoiSua += " NoiSinh = '" + txtNoiSinh.Text + "', ";
                chuoiSua += " MaKH = '" + cbbKhoa.SelectedValue.ToString() + "', ";
                chuoiSua += " HocBong = " + txtHocBong.Text;
                chuoiSua += " where Masv = '" + txtMaSV.Text + "'";

                cmdSinhVien = new OleDbCommand(chuoiSua, cnn);

                int n = cmdSinhVien.ExecuteNonQuery();
                if(n > 0)
                {
                    MessageBox.Show("Sửa sinh viên thành công!");
                }
            }
            if(!txtMaSV.ReadOnly)
            {
                DataRow rsv = tblSinhVien.Rows.Find(txtMaSV.Text); 
                if(rsv != null)
                {
                    MessageBox.Show("Mã SV bị trùng","Lỗi");
                    txtMaSV.Focus();
                    return;
                }
                else
                {
                    rsv = tblSinhVien.NewRow();
                    rsv["MaSV"] = txtMaSV.Text;
                    rsv["HoSV"] = txtHo.Text;
                    rsv["TenSV"] = txtTen.Text;
                    rsv["Phai"] = chkPhai.Checked;
                    rsv["NgaySinh"] = dtpNgaySinh.Text;
                    rsv["NoiSinh"] = txtNoiSinh.Text;
                    rsv["MaKH"] = cbbKhoa.SelectedValue.ToString();
                    rsv["HocBong"] = txtHocBong.Text;
                    tblSinhVien.Rows.Add(rsv);

                    //string chuoiThem = "Insert into SINHVIEN values(";
                    //chuoiThem += "'" + txtMaSV.Text + "',";
                    //chuoiThem += " '" + txtHo.Text + "', ";
                    //chuoiThem += " '" + txtTen.Text + "', ";
                    //chuoiThem += " " + chkPhai.Checked + ",";
                    //chuoiThem += " #" + dtpNgaySinh.Value + "#,";
                    //chuoiThem += " '" + txtNoiSinh.Text + "', ";
                    //chuoiThem += " '" + cbbKhoa.SelectedValue.ToString() + "', ";
                    //chuoiThem += " " + txtHocBong.Text + ")";

                    //cmdSinhVien = new OleDbCommand(chuoiThem, cnn);

                    //c2: dùng parameters
                    string chuoiGhi = "Insert into SINHVIEN values (@msv, @hsv, @tsv, @gt, @ngs, @ns, @mk, @hb)";
                    cmdSinhVien = new OleDbCommand(chuoiGhi, cnn);
                    cmdSinhVien.Parameters.Add("@msv", OleDbType.Char).Value = txtMaSV.Text;
                    cmdSinhVien.Parameters.Add("@hsv", OleDbType.VarWChar).Value = txtHo.Text;
                    cmdSinhVien.Parameters.Add("@tsv", OleDbType.VarWChar).Value = txtTen.Text;
                    cmdSinhVien.Parameters.Add("@gt", OleDbType.Boolean).Value = chkPhai.Text;
                    cmdSinhVien.Parameters.Add("@ngs", OleDbType.Date).Value = dtpNgaySinh.Value;
                    cmdSinhVien.Parameters.Add("@mk", OleDbType.Char).Value = cbbKhoa.SelectedValue.ToString();
                    cmdSinhVien.Parameters.Add("@hb", OleDbType.Double).Value = txtHocBong.Text;


                    int n = cmdSinhVien.ExecuteNonQuery();
                    if(n > 0)
                    {
                        MessageBox.Show("Thêm sinh viên thành công!");
                        txtMaSV.ReadOnly = true;
                    }
                }
            }
            cnn.Close();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            txtMaSV.ReadOnly = true;
            GanDuLieu(stt);
        }

        private void GanDuLieu(int stt)
        {
            DataRow rsv = tblSinhVien.Rows[stt];
            txtMaSV.Text = rsv["MaSV"].ToString();
            txtHo.Text = rsv["HoSV"].ToString();
            txtTen.Text = rsv["TenSV"].ToString();
            chkPhai.Checked = (Boolean)rsv["Phai"];
            dtpNgaySinh.Text = rsv["NgaySinh"].ToString();
            txtNoiSinh.Text = rsv["NoiSinh"].ToString();
            cbbKhoa.SelectedValue = rsv["MaKH"].ToString();
            txtHocBong.Text = rsv["HocBong"].ToString();

            txtTongDiem.Text = tongDiem(txtMaSV.Text).ToString();

            txtSTT.Text = (stt + 1) + "/" + tblSinhVien.Rows.Count;
        }

        private object tongDiem(string maSV)
        {
            double kq = 0;
            object td = tblKetQua.Compute("sum(Diem)", "MaSV = '" + maSV + "'");
            if (td == DBNull.Value)
            {
                kq = 0;
            }
            else
            {
                kq = Convert.ToDouble(td);
            }
            return kq;
        }
    }
}
