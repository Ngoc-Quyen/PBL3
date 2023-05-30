namespace PBL3.View
{
    partial class Thongke
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSoluongKhach = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTongDoanhthu = new System.Windows.Forms.Label();
            this.chartTongDoanhthu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLoaixe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btToday = new System.Windows.Forms.Button();
            this.btThisMonth = new System.Windows.Forms.Button();
            this.btLast30day = new System.Windows.Forms.Button();
            this.btLast7day = new System.Windows.Forms.Button();
            this.btCustom = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTongDoanhthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoaixe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSoluongKhach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số lượng khách";
            // 
            // lbSoluongKhach
            // 
            this.lbSoluongKhach.AutoSize = true;
            this.lbSoluongKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluongKhach.Location = new System.Drawing.Point(16, 32);
            this.lbSoluongKhach.Name = "lbSoluongKhach";
            this.lbSoluongKhach.Size = new System.Drawing.Size(77, 26);
            this.lbSoluongKhach.TabIndex = 0;
            this.lbSoluongKhach.Text = "10000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTongDoanhthu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(226, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng doanh thu";
            // 
            // lbTongDoanhthu
            // 
            this.lbTongDoanhthu.AutoSize = true;
            this.lbTongDoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongDoanhthu.Location = new System.Drawing.Point(16, 32);
            this.lbTongDoanhthu.Name = "lbTongDoanhthu";
            this.lbTongDoanhthu.Size = new System.Drawing.Size(134, 26);
            this.lbTongDoanhthu.TabIndex = 0;
            this.lbTongDoanhthu.Text = "10000 VND";
            // 
            // chartTongDoanhthu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTongDoanhthu.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartTongDoanhthu.Legends.Add(legend1);
            this.chartTongDoanhthu.Location = new System.Drawing.Point(13, 185);
            this.chartTongDoanhthu.Name = "chartTongDoanhthu";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartTongDoanhthu.Series.Add(series1);
            this.chartTongDoanhthu.Size = new System.Drawing.Size(599, 263);
            this.chartTongDoanhthu.TabIndex = 3;
            this.chartTongDoanhthu.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.Name = "Title1";
            title1.Text = "Tổng doanh thu";
            this.chartTongDoanhthu.Titles.Add(title1);
            // 
            // chartLoaixe
            // 
            chartArea2.Name = "ChartArea1";
            this.chartLoaixe.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartLoaixe.Legends.Add(legend2);
            this.chartLoaixe.Location = new System.Drawing.Point(618, 113);
            this.chartLoaixe.Name = "chartLoaixe";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series2.IsXValueIndexed = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartLoaixe.Series.Add(series2);
            this.chartLoaixe.Size = new System.Drawing.Size(287, 335);
            this.chartLoaixe.TabIndex = 4;
            this.chartLoaixe.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.Name = "Title1";
            title2.Text = "Loại xe";
            this.chartLoaixe.Titles.Add(title2);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btToday);
            this.panel1.Controls.Add(this.btThisMonth);
            this.panel1.Controls.Add(this.btLast30day);
            this.panel1.Controls.Add(this.btLast7day);
            this.panel1.Controls.Add(this.btCustom);
            this.panel1.Controls.Add(this.btShow);
            this.panel1.Controls.Add(this.dtEnd);
            this.panel1.Controls.Add(this.dtStart);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 95);
            this.panel1.TabIndex = 0;
            // 
            // btToday
            // 
            this.btToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btToday.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btToday.Location = new System.Drawing.Point(758, 8);
            this.btToday.Name = "btToday";
            this.btToday.Size = new System.Drawing.Size(136, 30);
            this.btToday.TabIndex = 31;
            this.btToday.Text = "Hôm nay";
            this.btToday.UseVisualStyleBackColor = true;
            this.btToday.Click += new System.EventHandler(this.btToday_Click);
            // 
            // btThisMonth
            // 
            this.btThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThisMonth.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btThisMonth.Location = new System.Drawing.Point(758, 53);
            this.btThisMonth.Name = "btThisMonth";
            this.btThisMonth.Size = new System.Drawing.Size(136, 30);
            this.btThisMonth.TabIndex = 30;
            this.btThisMonth.Text = "Tháng này";
            this.btThisMonth.UseVisualStyleBackColor = true;
            this.btThisMonth.Click += new System.EventHandler(this.btThisMonth_Click);
            // 
            // btLast30day
            // 
            this.btLast30day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLast30day.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btLast30day.Location = new System.Drawing.Point(616, 53);
            this.btLast30day.Name = "btLast30day";
            this.btLast30day.Size = new System.Drawing.Size(136, 30);
            this.btLast30day.TabIndex = 29;
            this.btLast30day.Text = "30 ngày trước";
            this.btLast30day.UseVisualStyleBackColor = true;
            this.btLast30day.Click += new System.EventHandler(this.btLast30day_Click);
            // 
            // btLast7day
            // 
            this.btLast7day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLast7day.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btLast7day.Location = new System.Drawing.Point(475, 53);
            this.btLast7day.Name = "btLast7day";
            this.btLast7day.Size = new System.Drawing.Size(136, 30);
            this.btLast7day.TabIndex = 28;
            this.btLast7day.Text = "7 ngày trước";
            this.btLast7day.UseVisualStyleBackColor = true;
            this.btLast7day.Click += new System.EventHandler(this.btLast7day_Click);
            // 
            // btCustom
            // 
            this.btCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustom.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btCustom.Location = new System.Drawing.Point(616, 8);
            this.btCustom.Name = "btCustom";
            this.btCustom.Size = new System.Drawing.Size(136, 30);
            this.btCustom.TabIndex = 27;
            this.btCustom.Text = "Tùy chỉnh";
            this.btCustom.UseVisualStyleBackColor = true;
            this.btCustom.Click += new System.EventHandler(this.btCustom_Click);
            // 
            // btShow
            // 
            this.btShow.Enabled = false;
            this.btShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btShow.Location = new System.Drawing.Point(541, 8);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(70, 30);
            this.btShow.TabIndex = 26;
            this.btShow.Text = "Xem";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.Enabled = false;
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(383, 8);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(152, 28);
            this.dtEnd.TabIndex = 25;
            // 
            // dtStart
            // 
            this.dtStart.Enabled = false;
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(225, 8);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(152, 28);
            this.dtStart.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(201, 29);
            this.label18.TabIndex = 23;
            this.label18.Text = "Bảng điều khiển";
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(917, 482);
            this.Controls.Add(this.chartLoaixe);
            this.Controls.Add(this.chartTongDoanhthu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Thongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thongke";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTongDoanhthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoaixe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSoluongKhach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTongDoanhthu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTongDoanhthu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoaixe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThisMonth;
        private System.Windows.Forms.Button btLast30day;
        private System.Windows.Forms.Button btLast7day;
        private System.Windows.Forms.Button btCustom;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btToday;
    }
}