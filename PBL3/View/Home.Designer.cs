namespace PBL3.View
{
    partial class Home
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
            this.tabDnDky = new System.Windows.Forms.TabControl();
            this.tabDangnhap = new System.Windows.Forms.TabPage();
            this.cbHienthimk = new System.Windows.Forms.CheckBox();
            this.lbDangky = new System.Windows.Forms.Label();
            this.lbHoi = new System.Windows.Forms.Label();
            this.btDangnhap = new System.Windows.Forms.Button();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.lbMatkhau = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.lbSdt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDangky = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimeNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.lbMatkhaumoi = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.lbHoten = new System.Windows.Forms.Label();
            this.lbDangnhap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btDangky = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbSdtDky = new System.Windows.Forms.Label();
            this.lbDangkytv = new System.Windows.Forms.Label();
            this.btTaoLT = new System.Windows.Forms.Button();
            this.btTheodoiLT = new System.Windows.Forms.Button();
            this.btThuexe = new System.Windows.Forms.Button();
            this.tabDnDky.SuspendLayout();
            this.tabDangnhap.SuspendLayout();
            this.tabDangky.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDnDky
            // 
            this.tabDnDky.Controls.Add(this.tabDangnhap);
            this.tabDnDky.Controls.Add(this.tabDangky);
            this.tabDnDky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDnDky.Location = new System.Drawing.Point(365, 34);
            this.tabDnDky.Name = "tabDnDky";
            this.tabDnDky.SelectedIndex = 0;
            this.tabDnDky.Size = new System.Drawing.Size(389, 490);
            this.tabDnDky.TabIndex = 1;
            // 
            // tabDangnhap
            // 
            this.tabDangnhap.Controls.Add(this.cbHienthimk);
            this.tabDangnhap.Controls.Add(this.lbDangky);
            this.tabDangnhap.Controls.Add(this.lbHoi);
            this.tabDangnhap.Controls.Add(this.btDangnhap);
            this.tabDangnhap.Controls.Add(this.txtMatkhau);
            this.tabDangnhap.Controls.Add(this.lbMatkhau);
            this.tabDangnhap.Controls.Add(this.txtSdt);
            this.tabDangnhap.Controls.Add(this.lbSdt);
            this.tabDangnhap.Controls.Add(this.label1);
            this.tabDangnhap.Location = new System.Drawing.Point(4, 29);
            this.tabDangnhap.Name = "tabDangnhap";
            this.tabDangnhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabDangnhap.Size = new System.Drawing.Size(381, 457);
            this.tabDangnhap.TabIndex = 0;
            this.tabDangnhap.Text = "Đăng Nhập";
            this.tabDangnhap.UseVisualStyleBackColor = true;
            // 
            // cbHienthimk
            // 
            this.cbHienthimk.AutoSize = true;
            this.cbHienthimk.Location = new System.Drawing.Point(26, 253);
            this.cbHienthimk.Name = "cbHienthimk";
            this.cbHienthimk.Size = new System.Drawing.Size(162, 24);
            this.cbHienthimk.TabIndex = 8;
            this.cbHienthimk.Text = "Hiển thị mật khẩu";
            this.cbHienthimk.UseVisualStyleBackColor = true;
            // 
            // lbDangky
            // 
            this.lbDangky.AutoSize = true;
            this.lbDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangky.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbDangky.Location = new System.Drawing.Point(170, 340);
            this.lbDangky.Name = "lbDangky";
            this.lbDangky.Size = new System.Drawing.Size(76, 20);
            this.lbDangky.TabIndex = 7;
            this.lbDangky.Text = "Đăng ký";
            this.lbDangky.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbHoi
            // 
            this.lbHoi.AutoSize = true;
            this.lbHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoi.Location = new System.Drawing.Point(170, 310);
            this.lbHoi.Name = "lbHoi";
            this.lbHoi.Size = new System.Drawing.Size(184, 20);
            this.lbHoi.TabIndex = 6;
            this.lbHoi.Text = "Bạn chưa có tài khoản?";
            // 
            // btDangnhap
            // 
            this.btDangnhap.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangnhap.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btDangnhap.Location = new System.Drawing.Point(12, 310);
            this.btDangnhap.Name = "btDangnhap";
            this.btDangnhap.Size = new System.Drawing.Size(152, 50);
            this.btDangnhap.TabIndex = 5;
            this.btDangnhap.Text = "Đăng Nhập";
            this.btDangnhap.UseVisualStyleBackColor = false;
            this.btDangnhap.Click += new System.EventHandler(this.btDangnhap_Click);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(26, 202);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(322, 40);
            this.txtMatkhau.TabIndex = 4;
            // 
            // lbMatkhau
            // 
            this.lbMatkhau.AutoSize = true;
            this.lbMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatkhau.Location = new System.Drawing.Point(22, 169);
            this.lbMatkhau.Name = "lbMatkhau";
            this.lbMatkhau.Size = new System.Drawing.Size(85, 20);
            this.lbMatkhau.TabIndex = 3;
            this.lbMatkhau.Text = "Mật khẩu";
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(26, 109);
            this.txtSdt.Multiline = true;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(322, 40);
            this.txtSdt.TabIndex = 2;
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.Location = new System.Drawing.Point(22, 76);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(119, 20);
            this.lbSdt.TabIndex = 1;
            this.lbSdt.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập Tài khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabDangky
            // 
            this.tabDangky.BackColor = System.Drawing.Color.Transparent;
            this.tabDangky.Controls.Add(this.checkBox1);
            this.tabDangky.Controls.Add(this.dateTimeNgaysinh);
            this.tabDangky.Controls.Add(this.lbNgaysinh);
            this.tabDangky.Controls.Add(this.txtMatkhaumoi);
            this.tabDangky.Controls.Add(this.lbMatkhaumoi);
            this.tabDangky.Controls.Add(this.txtHoten);
            this.tabDangky.Controls.Add(this.lbHoten);
            this.tabDangky.Controls.Add(this.lbDangnhap);
            this.tabDangky.Controls.Add(this.label3);
            this.tabDangky.Controls.Add(this.btDangky);
            this.tabDangky.Controls.Add(this.textBox1);
            this.tabDangky.Controls.Add(this.lbSdtDky);
            this.tabDangky.Controls.Add(this.lbDangkytv);
            this.tabDangky.Location = new System.Drawing.Point(4, 29);
            this.tabDangky.Name = "tabDangky";
            this.tabDangky.Padding = new System.Windows.Forms.Padding(3);
            this.tabDangky.Size = new System.Drawing.Size(381, 457);
            this.tabDangky.TabIndex = 1;
            this.tabDangky.Text = "Đăng Ký";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 349);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(300, 24);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Đồng ý với chính sách của chúng tôi";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimeNgaysinh
            // 
            this.dateTimeNgaysinh.Location = new System.Drawing.Point(26, 302);
            this.dateTimeNgaysinh.Name = "dateTimeNgaysinh";
            this.dateTimeNgaysinh.Size = new System.Drawing.Size(289, 26);
            this.dateTimeNgaysinh.TabIndex = 16;
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaysinh.Location = new System.Drawing.Point(22, 270);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(92, 20);
            this.lbNgaysinh.TabIndex = 14;
            this.lbNgaysinh.Text = "Ngày sinh";
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhaumoi.Location = new System.Drawing.Point(26, 226);
            this.txtMatkhaumoi.Multiline = true;
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.Size = new System.Drawing.Size(297, 31);
            this.txtMatkhaumoi.TabIndex = 13;
            // 
            // lbMatkhaumoi
            // 
            this.lbMatkhaumoi.AutoSize = true;
            this.lbMatkhaumoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatkhaumoi.Location = new System.Drawing.Point(22, 198);
            this.lbMatkhaumoi.Name = "lbMatkhaumoi";
            this.lbMatkhaumoi.Size = new System.Drawing.Size(121, 20);
            this.lbMatkhaumoi.TabIndex = 12;
            this.lbMatkhaumoi.Text = "Mật khẩu mới";
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(26, 153);
            this.txtHoten.Multiline = true;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(297, 31);
            this.txtHoten.TabIndex = 11;
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoten.Location = new System.Drawing.Point(22, 128);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(95, 20);
            this.lbHoten.TabIndex = 10;
            this.lbHoten.Text = "Họ và Tên";
            // 
            // lbDangnhap
            // 
            this.lbDangnhap.AutoSize = true;
            this.lbDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangnhap.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbDangnhap.Location = new System.Drawing.Point(30, 424);
            this.lbDangnhap.Name = "lbDangnhap";
            this.lbDangnhap.Size = new System.Drawing.Size(98, 20);
            this.lbDangnhap.TabIndex = 9;
            this.lbDangnhap.Text = "Đăng nhập";
            this.lbDangnhap.Click += new System.EventHandler(this.lbDangnhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bạn đã đăng ký?";
            // 
            // btDangky
            // 
            this.btDangky.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangky.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btDangky.Location = new System.Drawing.Point(220, 385);
            this.btDangky.Name = "btDangky";
            this.btDangky.Size = new System.Drawing.Size(124, 49);
            this.btDangky.TabIndex = 6;
            this.btDangky.Text = "Đăng Ký";
            this.btDangky.UseVisualStyleBackColor = false;
            this.btDangky.Click += new System.EventHandler(this.btDangky_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(26, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 31);
            this.textBox1.TabIndex = 4;
            // 
            // lbSdtDky
            // 
            this.lbSdtDky.AutoSize = true;
            this.lbSdtDky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdtDky.Location = new System.Drawing.Point(22, 56);
            this.lbSdtDky.Name = "lbSdtDky";
            this.lbSdtDky.Size = new System.Drawing.Size(119, 20);
            this.lbSdtDky.TabIndex = 3;
            this.lbSdtDky.Text = "Số điện thoại";
            // 
            // lbDangkytv
            // 
            this.lbDangkytv.AutoSize = true;
            this.lbDangkytv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangkytv.Location = new System.Drawing.Point(21, 12);
            this.lbDangkytv.Name = "lbDangkytv";
            this.lbDangkytv.Size = new System.Drawing.Size(205, 25);
            this.lbDangkytv.TabIndex = 1;
            this.lbDangkytv.Text = "Đăng ký Thành viên";
            // 
            // btTaoLT
            // 
            this.btTaoLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoLT.Location = new System.Drawing.Point(74, 139);
            this.btTaoLT.Name = "btTaoLT";
            this.btTaoLT.Size = new System.Drawing.Size(174, 31);
            this.btTaoLT.TabIndex = 2;
            this.btTaoLT.Text = "Tạo Lịch trình";
            this.btTaoLT.UseVisualStyleBackColor = true;
            // 
            // btTheodoiLT
            // 
            this.btTheodoiLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTheodoiLT.Location = new System.Drawing.Point(74, 219);
            this.btTheodoiLT.Name = "btTheodoiLT";
            this.btTheodoiLT.Size = new System.Drawing.Size(174, 31);
            this.btTheodoiLT.TabIndex = 3;
            this.btTheodoiLT.Text = "Theo dõi Lịch trình";
            this.btTheodoiLT.UseVisualStyleBackColor = true;
            // 
            // btThuexe
            // 
            this.btThuexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThuexe.Location = new System.Drawing.Point(74, 298);
            this.btThuexe.Name = "btThuexe";
            this.btThuexe.Size = new System.Drawing.Size(174, 31);
            this.btThuexe.TabIndex = 4;
            this.btThuexe.Text = "Thuê Xe";
            this.btThuexe.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 536);
            this.Controls.Add(this.btThuexe);
            this.Controls.Add(this.btTheodoiLT);
            this.Controls.Add(this.btTaoLT);
            this.Controls.Add(this.tabDnDky);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.tabDnDky.ResumeLayout(false);
            this.tabDangnhap.ResumeLayout(false);
            this.tabDangnhap.PerformLayout();
            this.tabDangky.ResumeLayout(false);
            this.tabDangky.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDnDky;
        private System.Windows.Forms.TabPage tabDangnhap;
        private System.Windows.Forms.TabPage tabDangky;
        private System.Windows.Forms.Button btTaoLT;
        private System.Windows.Forms.Button btTheodoiLT;
        private System.Windows.Forms.Button btThuexe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDangnhap;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label lbMatkhau;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.Label lbDangky;
        private System.Windows.Forms.Label lbHoi;
        private System.Windows.Forms.Button btDangky;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbSdtDky;
        private System.Windows.Forms.Label lbDangkytv;
        private System.Windows.Forms.Label lbDangnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatkhaumoi;
        private System.Windows.Forms.Label lbMatkhaumoi;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.CheckBox cbHienthimk;
        private System.Windows.Forms.DateTimePicker dateTimeNgaysinh;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}