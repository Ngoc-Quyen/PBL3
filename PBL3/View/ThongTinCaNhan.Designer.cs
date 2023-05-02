namespace PBL3.View
{
    partial class ThongTinCaNhan
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
            this.btSaveTT = new System.Windows.Forms.Button();
            this.btExitTT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassWordOld = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPassWordNew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSaveTT
            // 
            this.btSaveTT.BackColor = System.Drawing.Color.White;
            this.btSaveTT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveTT.Image = global::PBL3.Properties.Resources.diskette__1_;
            this.btSaveTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSaveTT.Location = new System.Drawing.Point(7, 7);
            this.btSaveTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSaveTT.Name = "btSaveTT";
            this.btSaveTT.Size = new System.Drawing.Size(144, 40);
            this.btSaveTT.TabIndex = 53;
            this.btSaveTT.Text = "    Cập nhật";
            this.btSaveTT.UseVisualStyleBackColor = false;
            this.btSaveTT.Click += new System.EventHandler(this.btSaveTT_Click);
            // 
            // btExitTT
            // 
            this.btExitTT.BackColor = System.Drawing.Color.White;
            this.btExitTT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExitTT.Image = global::PBL3.Properties.Resources.logout__1_;
            this.btExitTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExitTT.Location = new System.Drawing.Point(191, 7);
            this.btExitTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExitTT.Name = "btExitTT";
            this.btExitTT.Size = new System.Drawing.Size(144, 40);
            this.btExitTT.TabIndex = 54;
            this.btExitTT.Text = "Thoát";
            this.btExitTT.UseVisualStyleBackColor = false;
            this.btExitTT.Click += new System.EventHandler(this.btExitTT_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 54);
            this.panel1.TabIndex = 55;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(168, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(253, 32);
            this.lblHeader.TabIndex = 21;
            this.lblHeader.Text = "Thông Tin Cá Nhân";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.txtUserName);
            this.panel23.Controls.Add(this.label8);
            this.panel23.Location = new System.Drawing.Point(12, 97);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(573, 60);
            this.panel23.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(271, 15);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(260, 30);
            this.txtUserName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên tài khoản:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDisplayName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 60);
            this.panel2.TabIndex = 2;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.Location = new System.Drawing.Point(271, 15);
            this.txtDisplayName.Multiline = true;
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(260, 30);
            this.txtDisplayName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPassWordOld);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 60);
            this.panel3.TabIndex = 3;
            // 
            // txtPassWordOld
            // 
            this.txtPassWordOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassWordOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWordOld.Location = new System.Drawing.Point(271, 15);
            this.txtPassWordOld.Multiline = true;
            this.txtPassWordOld.Name = "txtPassWordOld";
            this.txtPassWordOld.Size = new System.Drawing.Size(260, 30);
            this.txtPassWordOld.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtPassWordNew);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 343);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(573, 60);
            this.panel4.TabIndex = 4;
            // 
            // txtPassWordNew
            // 
            this.txtPassWordNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassWordNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWordNew.Location = new System.Drawing.Point(271, 15);
            this.txtPassWordNew.Multiline = true;
            this.txtPassWordNew.Name = "txtPassWordNew";
            this.txtPassWordNew.Size = new System.Drawing.Size(260, 30);
            this.txtPassWordNew.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btExitTT);
            this.panel5.Controls.Add(this.btSaveTT);
            this.panel5.Location = new System.Drawing.Point(247, 439);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 56);
            this.panel5.TabIndex = 6;
            // 
            // ThongTinCaNhan
            // 
            this.AcceptButton = this.btSaveTT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 527);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.panel1);
            this.Name = "ThongTinCaNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinCaNhan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSaveTT;
        private System.Windows.Forms.Button btExitTT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPassWordOld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPassWordNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
    }
}