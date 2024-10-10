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
using System.Diagnostics;
using System.Data.SqlClient;

namespace BindingPhai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bs.CurrentChanged += Bs_CurrentChanged;
        }

        private void Bs_CurrentChanged(object sender, EventArgs e)
        {
            txtSTT.Text = (bs.Position + 1) + "/" + bs.Count;
            txtTongDiem.Text = tongDiem(txtMaSV.Text).ToString();
        }

        private object tongDiem(string maSV)
        {
            double kq = 0;
            object td = ds.Tables["KETQUA"].Compute("sum(Diem)", "MaSV = '" + maSV + "'");
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

        string strcon = @"provider = Microsoft.ACE.oledb.12.0; data source=..\..\..\data\QLSINHVIEN.mdb";
        DataSet ds = new DataSet();
        OleDbDataAdapter adpSinhvien, adpKhoa, adpKetQua;
        OleDbCommandBuilder cmbSinhVien;
        BindingSource bs = new BindingSource();
        int stt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            khoiTaoDoiTuong();
            docDuLieu();
            mocNoiQuanHe();
            khoiTaoBindingSource();
            khoiTaoCombobox();
            lienKetDieuKhien();
            txtTongDiem.Text = tongDiem(txtMaSV.Text).ToString();
        }

        private void lienKetDieuKhien()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox && ctr.Name != "txtPhai" && ctr.Name != "txtTongDiem" && ctr.Name != "txtSTT")
                    ctr.DataBindings.Add("text", bs, ctr.Name.Substring(3), true);
                else if (ctr is ComboBox)
                    ctr.DataBindings.Add("SelectedValue", bs, ctr.Name.Substring(3), true);
                else if (ctr is DateTimePicker)
                    ctr.DataBindings.Add("Value", bs, ctr.Name.Substring(3), true);
            }
            Binding bdPhai = new Binding("text", bs, "Phai", true);
            bdPhai.Parse += BdPhai_Parse;
            bdPhai.Format += BdPhai_Format;
            txtPhai.DataBindings.Add(bdPhai);
        }

        private void BdPhai_Format(object sender, ConvertEventArgs e)
        {
            if (e.Value == DBNull.Value || e.Value == null) return;
            e.Value = (Boolean)e.Value ? "Nam" : "Nữ";
        }

        private void BdPhai_Parse(object sender, ConvertEventArgs e)
        {
            if (e.Value == null) return;
            e.Value = e.Value.ToString().ToUpper() == "NAM" ? true : false;
        }

        private void khoiTaoCombobox()
        {
            cboMaKH.DisplayMember = "TenKH";
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.DataSource = ds.Tables["KHOA"];
        }

        private void khoiTaoBindingSource()
        {
            bs.DataSource = ds;
            bs.DataMember = "SINHVIEN";
        }

        private void mocNoiQuanHe()
        {
            ds.Relations.Add("FK_KH_SV", ds.Tables["KHOA"].Columns["MaKH"], ds.Tables["SINHVIEN"].Columns["MaKH"]);
            ds.Relations.Add("FK_SV_KQ", ds.Tables["SINHVIEN"].Columns["MaSV"], ds.Tables["KETQUA"].Columns["MaSV"]);

            ds.Relations["FK_KH_SV"].ChildKeyConstraint.DeleteRule = Rule.None;
            ds.Relations["FK_SV_KQ"].ChildKeyConstraint.DeleteRule = Rule.None;
        }

        private void docDuLieu()
        {
            adpKhoa.FillSchema(ds, SchemaType.Source, "KHOA");
            adpKhoa.Fill(ds, "KHOA");

            adpSinhvien.FillSchema(ds, SchemaType.Source, "SINHVIEN");
            adpSinhvien.Fill(ds, "SINHVIEN");

            adpKetQua.FillSchema(ds, SchemaType.Source, "KETQUA");
            adpKetQua.Fill(ds, "KETQUA");
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSV.ReadOnly = false;
            stt = bs.Position;  
            bs.AddNew();
            cboMaKH.SelectedIndex = 0;
            txtMaSV.Focus();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            txtMaSV.ReadOnly = true;
            bs.Position = stt;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!txtMaSV.ReadOnly)
            {
                DataRow rsv = ds.Tables["SINHVIEN"].Rows.Find(txtMaSV.Text);
                if (rsv != null)
                {
                    MessageBox.Show("Mã SV bị trùng", "Lỗi");
                    txtMaSV.Focus();
                    return;
                }
            }
            txtMaSV.ReadOnly = true;
            bs.EndEdit();
            int n = adpSinhvien.Update(ds, "SINHVIEN");
            if (n > 0)
                MessageBox.Show("Ghi sinh viên thành công.");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DataRow rsv = (bs.Current as DataRowView).Row;
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
                    bs.RemoveCurrent();
                    int n = adpSinhvien.Update(ds, "SINHVIEN");
                    if (n > 0)
                        MessageBox.Show("Xoá sinh viên thành công.");
                }
            }
        }

        private void khoiTaoDoiTuong()
        {
            adpKhoa = new OleDbDataAdapter("Select * from KHOA", strcon);
            adpSinhvien = new OleDbDataAdapter("Select * from SINHVIEN", strcon);
            adpKetQua = new OleDbDataAdapter("Select * from KETQUA", strcon);

            cmbSinhVien = new OleDbCommandBuilder(adpSinhvien);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
