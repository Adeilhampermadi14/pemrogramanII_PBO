﻿namespace P6_4_1194001_
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbAgama = new System.Windows.Forms.ComboBox();
            this.tbNoTelp = new System.Windows.Forms.TextBox();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PENDAFTARAN SISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "No. Telp Ortu / Wali :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jenis Kelamin :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Agama";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(131, 50);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(212, 20);
            this.tbName.TabIndex = 7;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_Leave);
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(131, 105);
            this.tbAlamat.Margin = new System.Windows.Forms.Padding(2);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(212, 20);
            this.tbAlamat.TabIndex = 8;
            this.tbAlamat.TextChanged += new System.EventHandler(this.tbAlamat_Leave);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(131, 77);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.Value = new System.DateTime(2023, 8, 27, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // cbAgama
            // 
            this.cbAgama.FormattingEnabled = true;
            this.cbAgama.Items.AddRange(new object[] {
            "Islam",
            "Kristen",
            "Khatolik",
            "Hindu",
            "Buddha",
            "Konghucu"});
            this.cbAgama.Location = new System.Drawing.Point(131, 158);
            this.cbAgama.Margin = new System.Windows.Forms.Padding(2);
            this.cbAgama.Name = "cbAgama";
            this.cbAgama.Size = new System.Drawing.Size(212, 21);
            this.cbAgama.TabIndex = 11;
            // 
            // tbNoTelp
            // 
            this.tbNoTelp.Location = new System.Drawing.Point(131, 185);
            this.tbNoTelp.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoTelp.Name = "tbNoTelp";
            this.tbNoTelp.Size = new System.Drawing.Size(212, 20);
            this.tbNoTelp.TabIndex = 12;
            this.tbNoTelp.TextChanged += new System.EventHandler(this.tbNoTelp_TextChanged);
            // 
            // btnDaftar
            // 
            this.btnDaftar.Location = new System.Drawing.Point(25, 274);
            this.btnDaftar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(87, 34);
            this.btnDaftar.TabIndex = 13;
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.UseVisualStyleBackColor = true;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(360, 274);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(88, 34);
            this.btnSelesai.TabIndex = 14;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(131, 130);
            this.rb1.Margin = new System.Windows.Forms.Padding(2);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(79, 17);
            this.rb1.TabIndex = 15;
            this.rb1.TabStop = true;
            this.rb1.Text = "Perempuan";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(242, 130);
            this.rb2.Margin = new System.Windows.Forms.Padding(2);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(64, 17);
            this.rb2.TabIndex = 16;
            this.rb2.TabStop = true;
            this.rb2.Text = "Laki-laki";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            this.epError.Icon = ((System.Drawing.Icon)(resources.GetObject("epError.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(477, 330);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.tbNoTelp);
            this.Controls.Add(this.cbAgama);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form Pendaftaran Siswa Baru";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cbAgama;
        private System.Windows.Forms.TextBox tbNoTelp;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

