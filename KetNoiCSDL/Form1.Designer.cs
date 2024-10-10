namespace KetNoiCSDL
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
            this.btnAcc2003 = new System.Windows.Forms.Button();
            this.btnAcc2019 = new System.Windows.Forms.Button();
            this.btnSQL = new System.Windows.Forms.Button();
            this.btnsa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAcc2003
            // 
            this.btnAcc2003.Location = new System.Drawing.Point(29, 26);
            this.btnAcc2003.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcc2003.Name = "btnAcc2003";
            this.btnAcc2003.Size = new System.Drawing.Size(154, 66);
            this.btnAcc2003.TabIndex = 0;
            this.btnAcc2003.Text = "Access 2003";
            this.btnAcc2003.UseVisualStyleBackColor = true;
            this.btnAcc2003.Click += new System.EventHandler(this.btnAcc2003_Click);
            // 
            // btnAcc2019
            // 
            this.btnAcc2019.Location = new System.Drawing.Point(215, 26);
            this.btnAcc2019.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcc2019.Name = "btnAcc2019";
            this.btnAcc2019.Size = new System.Drawing.Size(154, 66);
            this.btnAcc2019.TabIndex = 1;
            this.btnAcc2019.Text = "Access 2019";
            this.btnAcc2019.UseVisualStyleBackColor = true;
            this.btnAcc2019.Click += new System.EventHandler(this.btnAcc2019_Click);
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(401, 26);
            this.btnSQL.Margin = new System.Windows.Forms.Padding(4);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(154, 66);
            this.btnSQL.TabIndex = 2;
            this.btnSQL.Text = "SQL Windows";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // btnsa
            // 
            this.btnsa.Location = new System.Drawing.Point(588, 26);
            this.btnsa.Margin = new System.Windows.Forms.Padding(4);
            this.btnsa.Name = "btnsa";
            this.btnsa.Size = new System.Drawing.Size(154, 66);
            this.btnsa.TabIndex = 3;
            this.btnsa.Text = "SQL sa";
            this.btnsa.UseVisualStyleBackColor = true;
            this.btnsa.Click += new System.EventHandler(this.btnsa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 119);
            this.Controls.Add(this.btnsa);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.btnAcc2019);
            this.Controls.Add(this.btnAcc2003);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối CSDL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAcc2003;
        private System.Windows.Forms.Button btnAcc2019;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.Button btnsa;
    }
}

