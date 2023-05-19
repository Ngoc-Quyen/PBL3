namespace PBL3.View
{
    partial class ThanhToan
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btTT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel39 = new System.Windows.Forms.Panel();
            this.dtBill = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.panel40 = new System.Windows.Forms.Panel();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel38 = new System.Windows.Forms.Panel();
            this.txtIdStaff = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel41 = new System.Windows.Forms.Panel();
            this.txtIdCar = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel42 = new System.Windows.Forms.Panel();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.lbSDTKhach = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel40.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel41.SuspendLayout();
            this.panel42.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btTT);
            this.panel5.Location = new System.Drawing.Point(181, 375);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(294, 58);
            this.panel5.TabIndex = 60;
            // 
            // btTT
            // 
            this.btTT.BackColor = System.Drawing.Color.White;
            this.btTT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTT.Image = global::PBL3.Properties.Resources.bill1;
            this.btTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTT.Location = new System.Drawing.Point(131, 2);
            this.btTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTT.Name = "btTT";
            this.btTT.Size = new System.Drawing.Size(150, 50);
            this.btTT.TabIndex = 53;
            this.btTT.Text = "Thanh toán";
            this.btTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTT.UseVisualStyleBackColor = false;
            this.btTT.Click += new System.EventHandler(this.btTT_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Location = new System.Drawing.Point(38, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 55);
            this.panel1.TabIndex = 61;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(100, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(238, 32);
            this.lblHeader.TabIndex = 21;
            this.lblHeader.Text = "Thông tin hóa đơn";
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.dtBill);
            this.panel39.Controls.Add(this.label21);
            this.panel39.Location = new System.Drawing.Point(38, 311);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(437, 46);
            this.panel39.TabIndex = 56;
            // 
            // dtBill
            // 
            this.dtBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtBill.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBill.Location = new System.Drawing.Point(224, 9);
            this.dtBill.Name = "dtBill";
            this.dtBill.Size = new System.Drawing.Size(204, 27);
            this.dtBill.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(5, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(208, 24);
            this.label21.TabIndex = 0;
            this.label21.Text = "Thời gian thanh toán:";
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.txtMoney);
            this.panel40.Controls.Add(this.label22);
            this.panel40.Location = new System.Drawing.Point(38, 259);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(437, 46);
            this.panel40.TabIndex = 55;
            // 
            // txtMoney
            // 
            this.txtMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(224, 9);
            this.txtMoney.Multiline = true;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(204, 25);
            this.txtMoney.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(5, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(151, 24);
            this.label22.TabIndex = 0;
            this.label22.Text = "Giá thanh toán:";
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.txtIdStaff);
            this.panel38.Controls.Add(this.label20);
            this.panel38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel38.Location = new System.Drawing.Point(38, 207);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(437, 46);
            this.panel38.TabIndex = 64;
            // 
            // txtIdStaff
            // 
            this.txtIdStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdStaff.Location = new System.Drawing.Point(224, 8);
            this.txtIdStaff.Multiline = true;
            this.txtIdStaff.Name = "txtIdStaff";
            this.txtIdStaff.ReadOnly = true;
            this.txtIdStaff.Size = new System.Drawing.Size(204, 25);
            this.txtIdStaff.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(5, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "ID Tài xế:";
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.txtIdCar);
            this.panel41.Controls.Add(this.label23);
            this.panel41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel41.Location = new System.Drawing.Point(38, 155);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(437, 46);
            this.panel41.TabIndex = 63;
            // 
            // txtIdCar
            // 
            this.txtIdCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCar.Location = new System.Drawing.Point(224, 9);
            this.txtIdCar.Multiline = true;
            this.txtIdCar.Name = "txtIdCar";
            this.txtIdCar.ReadOnly = true;
            this.txtIdCar.Size = new System.Drawing.Size(204, 25);
            this.txtIdCar.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(5, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(119, 24);
            this.label23.TabIndex = 0;
            this.label23.Text = "Biển số Xe:";
            // 
            // panel42
            // 
            this.panel42.Controls.Add(this.txtIdCustomer);
            this.panel42.Controls.Add(this.lbSDTKhach);
            this.panel42.Location = new System.Drawing.Point(38, 103);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(437, 46);
            this.panel42.TabIndex = 62;
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCustomer.Location = new System.Drawing.Point(224, 9);
            this.txtIdCustomer.Multiline = true;
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.ReadOnly = true;
            this.txtIdCustomer.Size = new System.Drawing.Size(204, 25);
            this.txtIdCustomer.TabIndex = 2;
            // 
            // lbSDTKhach
            // 
            this.lbSDTKhach.AutoSize = true;
            this.lbSDTKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDTKhach.Location = new System.Drawing.Point(5, 9);
            this.lbSDTKhach.Name = "lbSDTKhach";
            this.lbSDTKhach.Size = new System.Drawing.Size(174, 24);
            this.lbSDTKhach.TabIndex = 0;
            this.lbSDTKhach.Text = "SĐT Khách hàng:";
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 491);
            this.Controls.Add(this.panel38);
            this.Controls.Add(this.panel41);
            this.Controls.Add(this.panel42);
            this.Controls.Add(this.panel39);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel40);
            this.Controls.Add(this.panel1);
            this.Name = "ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThanhToan";
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            this.panel40.ResumeLayout(false);
            this.panel40.PerformLayout();
            this.panel38.ResumeLayout(false);
            this.panel38.PerformLayout();
            this.panel41.ResumeLayout(false);
            this.panel41.PerformLayout();
            this.panel42.ResumeLayout(false);
            this.panel42.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btTT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.DateTimePicker dtBill;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel41;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel42;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Label lbSDTKhach;
        private System.Windows.Forms.TextBox txtIdStaff;
        private System.Windows.Forms.TextBox txtIdCar;
    }
}