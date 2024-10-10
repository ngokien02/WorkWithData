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
using System.Data.SqlClient;

namespace KetNoiCSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcc2003_Click(object sender, EventArgs e)
        {
            string strcon = @"provider = Microsoft.ACE.oledb.12.0; data source=..\..\..\data\QLSINHVIEN.mdb";
            OleDbConnection cnn = new OleDbConnection(strcon);
            cnn.Open();
            if(cnn.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối với QLSV.mdb thành công!","Thông báo",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            cnn.Close();
        }

        private void btnAcc2019_Click(object sender, EventArgs e)
        {
            string strcon = @"provider = Microsoft.ACE.oledb.12.0; data source=..\..\..\data\QLSINHVIEN.accdb";
            OleDbConnection cnn = new OleDbConnection(strcon);
            cnn.Open();
            if (cnn.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối với QLSV.accdb thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cnn.Close();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            string strcon = @"Server=KIENVIP\KIENNGO; Database=QLSV_Kien; Integrated Security = True";
            SqlConnection cnn = new SqlConnection(strcon);
            cnn.Open();
            if(cnn.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối với SQL server thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cnn.Close();
        }

        private void btnsa_Click(object sender, EventArgs e)
        {
            string strcon = @"Server=KIENVIP\KIENNGO; Database=QLSV_Kien; uid=sa; pwd=c23";
            SqlConnection cnn = new SqlConnection(strcon);
            cnn.Open();
            if (cnn.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối với SQL sa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cnn.Close();
        }
    }
}
