using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT01
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();

        DataTable tblKhoa = new DataTable("KHOA");
        DataTable tblSinhVien = new DataTable("SINHVIEN");
        DataTable tblKetQua = new DataTable("KETQUA");

        int stt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private double tongDiem(string maSV)
        {
            double kq = 0;
            object td = tblKetQua.Compute("sum(Diem)", "MaSV = '" + maSV + "'");
            if(td == DBNull.Value)
            {
                kq = 0;
            }
            else
            {
                kq = Convert.ToDouble(td);
            }
            return kq;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaoCauTrucBang();
            MocNoiQuanHe();
            NhapLieuCacBang();
            KhoiTaoComboKhoa();
        }

        private void KhoiTaoComboKhoa()
        {
            cbbKhoa.DisplayMember = "TenKH";
            cbbKhoa.ValueMember = "MaKH";
            cbbKhoa.DataSource = tblKhoa;
        }

        private void NhapLieuCacBang()
        {
            NhapLieuTblKhoa();
            NhapLieuTblSinhVien();
            NhapLieuTblKetQua();
            btnDau.PerformClick();
        }

        private void NhapLieuTblKetQua()
        {
            String[] mangKQ = File.ReadAllLines(@"..\..\..\DATA\KETQUA.txt");
            foreach(String chuoiKQ in mangKQ)
            {
                string[] mangTP = chuoiKQ.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                DataRow rkq = tblKetQua.NewRow();

                for(int i = 0; i < mangTP.Length; i++)
                {
                    rkq[i] = mangTP[i];
                }

                tblKetQua.Rows.Add(rkq);
            }
        }

        private void NhapLieuTblSinhVien()
        {
            String[] mangSV = File.ReadAllLines(@"..\..\..\DATA\SINHVIEN.txt");     
            foreach(String chuoiSV in mangSV)
            {
                string[] mangThanhPhan = chuoiSV.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                DataRow rsinhvien = tblSinhVien.NewRow();

                for(int i = 0; i < mangThanhPhan.Length; i++)
                {
                    rsinhvien[i] = mangThanhPhan[i];
                }
                tblSinhVien.Rows.Add(rsinhvien);
            }
        }

        private void NhapLieuTblKhoa()
        {
            String[] mangKhoa = File.ReadAllLines(@"..\..\..\DATA\KHOA.txt");
            foreach (String chuoiKhoa in mangKhoa)
            {
                string[] mangThanhPhan = chuoiKhoa.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                DataRow rkhoa = tblKhoa.NewRow();

                rkhoa[0] = mangThanhPhan[0];
                rkhoa[1] = mangThanhPhan[1];

                tblKhoa.Rows.Add(rkhoa);
            }
        }

        private void MocNoiQuanHe()
        {
            ds.Relations.Add("FK_KH_SV", ds.Tables["KHOA"].Columns["MaKH"], ds.Tables["SINHVIEN"].Columns["MaKH"]);
            ds.Relations.Add("FK_SV_KQ", ds.Tables["SINHVIEN"].Columns["MaSV"], ds.Tables["KETQUA"].Columns["MaSV"]);

            ds.Relations["FK_KH_SV"].ChildKeyConstraint.DeleteRule = Rule.None;
            ds.Relations["FK_SV_KQ"].ChildKeyConstraint.DeleteRule = Rule.None;
        }

        private void TaoCauTrucBang()
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
            ds.Tables.AddRange(new DataTable[] { tblSinhVien, tblKhoa, tblKetQua });

        }

        public void GanDuLieu(int stt)
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

        private void btnDau_Click(object sender, EventArgs e)
        {
            stt = 0;
            GanDuLieu(stt);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            stt = tblSinhVien.Rows.Count-1;
            GanDuLieu(stt);
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (stt == 0) return;
            stt--;
            GanDuLieu(stt);
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (stt == tblSinhVien.Rows.Count -1) return;
            stt++;
            GanDuLieu(stt);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSV.ReadOnly = false;
            foreach(Control ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    (ctr as TextBox).Clear();
                }
                else if(ctr is CheckBox)
                {
                    (ctr as CheckBox).Checked = true;
                }
                else if(ctr is ComboBox)
                {
                    (ctr as ComboBox).SelectedIndex = 0;
                }
                else if(ctr is DateTimePicker)
                {
                    (ctr as DateTimePicker).Value = new DateTime(2006, 1, 1);
                }
            }
            txtMaSV.Focus();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            txtMaSV.ReadOnly = true;
            GanDuLieu(stt);
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if(!txtMaSV.ReadOnly)
            {
                DataRow rsv = tblSinhVien.Rows.Find(txtMaSV.Text);
                if(rsv != null)
                {
                    MessageBox.Show("Mã sv bị trùng, vui lòng nhập mã sv khác");
                    txtMaSV.Focus();
                    return;
                }
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
                txtMaSV.ReadOnly = true;
            }
            else
            {
                DataRow rsv = tblSinhVien.Rows.Find(txtMaSV.Text);
                rsv["HoSV"] = txtHo.Text;
                rsv["TenSV"] = txtTen.Text;
                rsv["Phai"] = chkPhai.Checked;
                rsv["NgaySinh"] = dtpNgaySinh.Text;
                rsv["NoiSinh"] = txtNoiSinh.Text;
                rsv["MaKH"] = cbbKhoa.SelectedValue.ToString();
                rsv["HocBong"] = txtHocBong.Text;
            }
            MessageBox.Show("Ghi thành công!");
            GanDuLieu(stt + 1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> mangChuoiSV = new List<string>();
            foreach(DataRow rsv in tblSinhVien.Rows)
            {
                string chuoiDongSV = string.Join("|", rsv.ItemArray);
                mangChuoiSV.Add(chuoiDongSV);
            }
            File.WriteAllLines(@"..\..\..\DATA\SINHVIEN.txt", mangChuoiSV);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DataRow rsv = tblSinhVien.Rows.Find(txtMaSV.Text);
            DataRow[] mangDongLienQuan = rsv.GetChildRows("FK_SV_KQ");
            if(mangDongLienQuan.Length > 0)
            {
                MessageBox.Show("Sinh viên này đã thi, không được xóa!");
            }
            else
            {
                DialogResult tl;
                tl = MessageBox.Show("Bạn có chắc chắn xóa sinh viên này không?(y/n)","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(tl == DialogResult.Yes)
                {
                    rsv.Delete();
                    btnDau.PerformClick();
                }
            }
        }
    }
}
