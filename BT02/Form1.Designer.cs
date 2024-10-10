namespace BT02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.txtHocBong = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.chkPhai = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSau
            // 
            this.btnSau.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSau.ForeColor = System.Drawing.Color.Red;
            this.btnSau.Location = new System.Drawing.Point(324, 454);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(106, 41);
            this.btnSau.TabIndex = 36;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = false;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTruoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTruoc.ForeColor = System.Drawing.Color.Red;
            this.btnTruoc.Location = new System.Drawing.Point(134, 454);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(106, 41);
            this.btnTruoc.TabIndex = 34;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = false;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhong.ForeColor = System.Drawing.Color.Red;
            this.btnKhong.Location = new System.Drawing.Point(418, 507);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(126, 41);
            this.btnKhong.TabIndex = 41;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = false;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGhi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGhi.ForeColor = System.Drawing.Color.Red;
            this.btnGhi.Location = new System.Drawing.Point(286, 507);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(126, 41);
            this.btnGhi.TabIndex = 40;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = false;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.Red;
            this.btnHuy.Location = new System.Drawing.Point(154, 507);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(126, 41);
            this.btnHuy.TabIndex = 39;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(22, 507);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 41);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(152, 296);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(390, 27);
            this.cbbKhoa.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarForeColor = System.Drawing.Color.Blue;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(152, 190);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(390, 27);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // txtSTT
            // 
            this.txtSTT.BackColor = System.Drawing.Color.White;
            this.txtSTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSTT.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSTT.Location = new System.Drawing.Point(246, 456);
            this.txtSTT.Margin = new System.Windows.Forms.Padding(5);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.ReadOnly = true;
            this.txtSTT.Size = new System.Drawing.Size(72, 34);
            this.txtSTT.TabIndex = 35;
            this.txtSTT.Text = "00/00";
            this.txtSTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTen
            // 
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTen.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Location = new System.Drawing.Point(384, 75);
            this.txtTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(158, 34);
            this.txtTen.TabIndex = 2;
            // 
            // txtHo
            // 
            this.txtHo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHo.Location = new System.Drawing.Point(152, 75);
            this.txtHo.Margin = new System.Windows.Forms.Padding(5);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(222, 34);
            this.txtHo.TabIndex = 1;
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongDiem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongDiem.Location = new System.Drawing.Point(152, 398);
            this.txtTongDiem.Margin = new System.Windows.Forms.Padding(5);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(390, 34);
            this.txtTongDiem.TabIndex = 8;
            // 
            // txtHocBong
            // 
            this.txtHocBong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHocBong.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHocBong.Location = new System.Drawing.Point(152, 345);
            this.txtHocBong.Margin = new System.Windows.Forms.Padding(5);
            this.txtHocBong.Name = "txtHocBong";
            this.txtHocBong.Size = new System.Drawing.Size(390, 34);
            this.txtHocBong.TabIndex = 7;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiSinh.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNoiSinh.Location = new System.Drawing.Point(152, 239);
            this.txtNoiSinh.Margin = new System.Windows.Forms.Padding(5);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(390, 34);
            this.txtNoiSinh.TabIndex = 5;
            // 
            // txtMaSV
            // 
            this.txtMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSV.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSV.Location = new System.Drawing.Point(152, 22);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(390, 34);
            this.txtMaSV.TabIndex = 0;
            // 
            // chkPhai
            // 
            this.chkPhai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chkPhai.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPhai.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkPhai.ForeColor = System.Drawing.Color.Blue;
            this.chkPhai.Location = new System.Drawing.Point(23, 126);
            this.chkPhai.Margin = new System.Windows.Forms.Padding(5);
            this.chkPhai.Name = "chkPhai";
            this.chkPhai.Size = new System.Drawing.Size(147, 48);
            this.chkPhai.TabIndex = 3;
            this.chkPhai.Text = "Phái";
            this.chkPhai.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(24, 402);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tổng điểm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(24, 349);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 26);
            this.label7.TabIndex = 21;
            this.label7.Text = "Học bổng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(24, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(24, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nơi sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(24, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Họ tên SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã SV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(567, 570);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.txtHocBong);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.chkPhai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "Form1";
            this.Text = "QLSV Access";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.TextBox txtHocBong;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.CheckBox chkPhai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

