namespace SesAnalizi
{
    partial class SesAnalizi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, "10,0");
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBox_bytecevir = new System.Windows.Forms.ListBox();
            this.btn_bytecevir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_erkek_merkez = new System.Windows.Forms.Button();
            this.btn_kadın_merkez = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_veri_erkek = new System.Windows.Forms.Button();
            this.btn_veri_kadın = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sec = new System.Windows.Forms.Button();
            this.btn_dosyasil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox_mindistanceerkek = new System.Windows.Forms.ListBox();
            this.listBox_mindistancekadın = new System.Windows.Forms.ListBox();
            this.btn_Vq = new System.Windows.Forms.Button();
            this.btn_zeroc = new System.Windows.Forms.Button();
            this.listBox_zeroc = new System.Windows.Forms.ListBox();
            this.listBox_MFCC = new System.Windows.Forms.ListBox();
            this.btn_MFCC = new System.Windows.Forms.Button();
            this.listBox_FFFark = new System.Windows.Forms.ListBox();
            this.btn_melfilter = new System.Windows.Forms.Button();
            this.listBox_filterfrekans = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gra = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_fftdonustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_hamming = new System.Windows.Forms.Button();
            this.btn_preemphasis = new System.Windows.Forms.Button();
            this.listBox_fftdonustur = new System.Windows.Forms.ListBox();
            this.listBox_hamming = new System.Windows.Forms.ListBox();
            this.listBox_preemphasis = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gra)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_bytecevir
            // 
            this.listBox_bytecevir.FormattingEnabled = true;
            this.listBox_bytecevir.Items.AddRange(new object[] {
            " "});
            this.listBox_bytecevir.Location = new System.Drawing.Point(12, 40);
            this.listBox_bytecevir.Name = "listBox_bytecevir";
            this.listBox_bytecevir.Size = new System.Drawing.Size(77, 186);
            this.listBox_bytecevir.TabIndex = 1;
            // 
            // btn_bytecevir
            // 
            this.btn_bytecevir.Location = new System.Drawing.Point(12, 6);
            this.btn_bytecevir.Name = "btn_bytecevir";
            this.btn_bytecevir.Size = new System.Drawing.Size(77, 23);
            this.btn_bytecevir.TabIndex = 2;
            this.btn_bytecevir.Text = "Byte Çevir";
            this.btn_bytecevir.UseVisualStyleBackColor = true;
            this.btn_bytecevir.Click += new System.EventHandler(this.btn_bytecevir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.btn_erkek_merkez);
            this.panel1.Controls.Add(this.btn_kadın_merkez);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_veri_erkek);
            this.panel1.Controls.Add(this.btn_veri_kadın);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Sec);
            this.panel1.Controls.Add(this.btn_dosyasil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 37);
            this.panel1.TabIndex = 3;
            // 
            // btn_erkek_merkez
            // 
            this.btn_erkek_merkez.Location = new System.Drawing.Point(738, 8);
            this.btn_erkek_merkez.Name = "btn_erkek_merkez";
            this.btn_erkek_merkez.Size = new System.Drawing.Size(65, 23);
            this.btn_erkek_merkez.TabIndex = 18;
            this.btn_erkek_merkez.Text = "Merkez E";
            this.btn_erkek_merkez.UseVisualStyleBackColor = true;
            this.btn_erkek_merkez.Click += new System.EventHandler(this.btn_erkek_merkez_Click);
            // 
            // btn_kadın_merkez
            // 
            this.btn_kadın_merkez.Location = new System.Drawing.Point(809, 8);
            this.btn_kadın_merkez.Name = "btn_kadın_merkez";
            this.btn_kadın_merkez.Size = new System.Drawing.Size(63, 23);
            this.btn_kadın_merkez.TabIndex = 19;
            this.btn_kadın_merkez.Text = "Merkez K";
            this.btn_kadın_merkez.UseVisualStyleBackColor = true;
            this.btn_kadın_merkez.Click += new System.EventHandler(this.btn_kadın_merkez_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Veritabanına Veri Ekle:";
            this.label4.Visible = false;
            // 
            // btn_veri_erkek
            // 
            this.btn_veri_erkek.Location = new System.Drawing.Point(563, 8);
            this.btn_veri_erkek.Name = "btn_veri_erkek";
            this.btn_veri_erkek.Size = new System.Drawing.Size(48, 23);
            this.btn_veri_erkek.TabIndex = 16;
            this.btn_veri_erkek.Text = "Erkek ";
            this.btn_veri_erkek.UseVisualStyleBackColor = true;
            this.btn_veri_erkek.Visible = false;
            this.btn_veri_erkek.Click += new System.EventHandler(this.btn_veri_erkek_Click);
            // 
            // btn_veri_kadın
            // 
            this.btn_veri_kadın.Location = new System.Drawing.Point(617, 8);
            this.btn_veri_kadın.Name = "btn_veri_kadın";
            this.btn_veri_kadın.Size = new System.Drawing.Size(49, 23);
            this.btn_veri_kadın.TabIndex = 15;
            this.btn_veri_kadın.Text = "Kadın ";
            this.btn_veri_kadın.UseVisualStyleBackColor = true;
            this.btn_veri_kadın.Visible = false;
            this.btn_veri_kadın.Click += new System.EventHandler(this.btn_veri_kadın_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Analizi Yapılacak Ses Dosyasını Seçiniz:";
            // 
            // btn_Sec
            // 
            this.btn_Sec.Location = new System.Drawing.Point(211, 4);
            this.btn_Sec.Name = "btn_Sec";
            this.btn_Sec.Size = new System.Drawing.Size(23, 23);
            this.btn_Sec.TabIndex = 5;
            this.btn_Sec.Text = "..";
            this.btn_Sec.UseVisualStyleBackColor = true;
            this.btn_Sec.Click += new System.EventHandler(this.btn_Sec_Click);
            // 
            // btn_dosyasil
            // 
            this.btn_dosyasil.Location = new System.Drawing.Point(254, 4);
            this.btn_dosyasil.Name = "btn_dosyasil";
            this.btn_dosyasil.Size = new System.Drawing.Size(75, 23);
            this.btn_dosyasil.TabIndex = 6;
            this.btn_dosyasil.Text = "Dosyayı Sil";
            this.btn_dosyasil.UseVisualStyleBackColor = true;
            this.btn_dosyasil.Click += new System.EventHandler(this.btn_dosyasil_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.listBox_mindistanceerkek);
            this.panel2.Controls.Add(this.listBox_mindistancekadın);
            this.panel2.Controls.Add(this.btn_Vq);
            this.panel2.Controls.Add(this.btn_zeroc);
            this.panel2.Controls.Add(this.listBox_zeroc);
            this.panel2.Controls.Add(this.listBox_MFCC);
            this.panel2.Controls.Add(this.btn_MFCC);
            this.panel2.Controls.Add(this.listBox_FFFark);
            this.panel2.Controls.Add(this.btn_melfilter);
            this.panel2.Controls.Add(this.listBox_filterfrekans);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_fftdonustur);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_hamming);
            this.panel2.Controls.Add(this.btn_preemphasis);
            this.panel2.Controls.Add(this.btn_bytecevir);
            this.panel2.Controls.Add(this.listBox_fftdonustur);
            this.panel2.Controls.Add(this.listBox_hamming);
            this.panel2.Controls.Add(this.listBox_preemphasis);
            this.panel2.Controls.Add(this.listBox_bytecevir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 637);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // listBox_mindistanceerkek
            // 
            this.listBox_mindistanceerkek.FormattingEnabled = true;
            this.listBox_mindistanceerkek.Items.AddRange(new object[] {
            " "});
            this.listBox_mindistanceerkek.Location = new System.Drawing.Point(828, 61);
            this.listBox_mindistanceerkek.Name = "listBox_mindistanceerkek";
            this.listBox_mindistanceerkek.Size = new System.Drawing.Size(60, 95);
            this.listBox_mindistanceerkek.TabIndex = 16;
            // 
            // listBox_mindistancekadın
            // 
            this.listBox_mindistancekadın.FormattingEnabled = true;
            this.listBox_mindistancekadın.Items.AddRange(new object[] {
            " "});
            this.listBox_mindistancekadın.Location = new System.Drawing.Point(745, 61);
            this.listBox_mindistancekadın.Name = "listBox_mindistancekadın";
            this.listBox_mindistancekadın.Size = new System.Drawing.Size(60, 95);
            this.listBox_mindistancekadın.TabIndex = 16;
            // 
            // btn_Vq
            // 
            this.btn_Vq.Location = new System.Drawing.Point(788, 6);
            this.btn_Vq.Name = "btn_Vq";
            this.btn_Vq.Size = new System.Drawing.Size(60, 23);
            this.btn_Vq.TabIndex = 15;
            this.btn_Vq.Text = "VQ";
            this.btn_Vq.UseVisualStyleBackColor = true;
            this.btn_Vq.Click += new System.EventHandler(this.btn_Vq_Click);
            // 
            // btn_zeroc
            // 
            this.btn_zeroc.Location = new System.Drawing.Point(371, 6);
            this.btn_zeroc.Name = "btn_zeroc";
            this.btn_zeroc.Size = new System.Drawing.Size(50, 23);
            this.btn_zeroc.TabIndex = 14;
            this.btn_zeroc.Text = "Zero";
            this.btn_zeroc.UseVisualStyleBackColor = true;
            this.btn_zeroc.Click += new System.EventHandler(this.btn_zeroc_Click);
            // 
            // listBox_zeroc
            // 
            this.listBox_zeroc.FormattingEnabled = true;
            this.listBox_zeroc.Items.AddRange(new object[] {
            " "});
            this.listBox_zeroc.Location = new System.Drawing.Point(280, 40);
            this.listBox_zeroc.Name = "listBox_zeroc";
            this.listBox_zeroc.Size = new System.Drawing.Size(129, 186);
            this.listBox_zeroc.TabIndex = 13;
            this.listBox_zeroc.Visible = false;
            // 
            // listBox_MFCC
            // 
            this.listBox_MFCC.FormattingEnabled = true;
            this.listBox_MFCC.Items.AddRange(new object[] {
            " "});
            this.listBox_MFCC.Location = new System.Drawing.Point(627, 40);
            this.listBox_MFCC.Name = "listBox_MFCC";
            this.listBox_MFCC.Size = new System.Drawing.Size(75, 186);
            this.listBox_MFCC.TabIndex = 11;
            // 
            // btn_MFCC
            // 
            this.btn_MFCC.Location = new System.Drawing.Point(627, 6);
            this.btn_MFCC.Name = "btn_MFCC";
            this.btn_MFCC.Size = new System.Drawing.Size(75, 23);
            this.btn_MFCC.TabIndex = 10;
            this.btn_MFCC.Text = "MFCC";
            this.btn_MFCC.UseVisualStyleBackColor = true;
            this.btn_MFCC.Click += new System.EventHandler(this.btn_MFCC_Click);
            // 
            // listBox_FFFark
            // 
            this.listBox_FFFark.FormattingEnabled = true;
            this.listBox_FFFark.Items.AddRange(new object[] {
            " "});
            this.listBox_FFFark.Location = new System.Drawing.Point(533, 40);
            this.listBox_FFFark.Name = "listBox_FFFark";
            this.listBox_FFFark.Size = new System.Drawing.Size(88, 186);
            this.listBox_FFFark.TabIndex = 9;
            // 
            // btn_melfilter
            // 
            this.btn_melfilter.Location = new System.Drawing.Point(482, 6);
            this.btn_melfilter.Name = "btn_melfilter";
            this.btn_melfilter.Size = new System.Drawing.Size(75, 23);
            this.btn_melfilter.TabIndex = 8;
            this.btn_melfilter.Text = "Mel Filter";
            this.btn_melfilter.UseVisualStyleBackColor = true;
            this.btn_melfilter.Click += new System.EventHandler(this.btn_melfilter_Click);
            // 
            // listBox_filterfrekans
            // 
            this.listBox_filterfrekans.FormattingEnabled = true;
            this.listBox_filterfrekans.Items.AddRange(new object[] {
            " "});
            this.listBox_filterfrekans.Location = new System.Drawing.Point(429, 40);
            this.listBox_filterfrekans.Name = "listBox_filterfrekans";
            this.listBox_filterfrekans.Size = new System.Drawing.Size(98, 186);
            this.listBox_filterfrekans.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gra);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 380);
            this.panel3.TabIndex = 4;
            // 
            // gra
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea3.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea3.AxisX.ScaleView.Size = 25D;
            chartArea3.Name = "ChartArea1";
            this.gra.ChartAreas.Add(chartArea3);
            this.gra.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.gra.Legends.Add(legend3);
            this.gra.Location = new System.Drawing.Point(0, 0);
            this.gra.Name = "gra";
            this.gra.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.BorderColor = System.Drawing.Color.White;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series5.Legend = "Legend1";
            series5.MarkerBorderWidth = 50;
            series5.Name = "deger";
            series5.Points.Add(dataPoint3);
            series5.YValuesPerPoint = 2;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series6.Legend = "Legend1";
            series6.Name = "nokta";
            this.gra.Series.Add(series5);
            this.gra.Series.Add(series6);
            this.gra.Size = new System.Drawing.Size(910, 380);
            this.gra.TabIndex = 3;
            this.gra.Text = "chart1";
            this.gra.Visible = false;
            this.gra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gra_MouseMove);
            // 
            // btn_fftdonustur
            // 
            this.btn_fftdonustur.Location = new System.Drawing.Point(280, 6);
            this.btn_fftdonustur.Name = "btn_fftdonustur";
            this.btn_fftdonustur.Size = new System.Drawing.Size(85, 23);
            this.btn_fftdonustur.TabIndex = 2;
            this.btn_fftdonustur.Text = "FFT Dönüştür";
            this.btn_fftdonustur.UseVisualStyleBackColor = true;
            this.btn_fftdonustur.Click += new System.EventHandler(this.btn_fftdonustur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // btn_hamming
            // 
            this.btn_hamming.Location = new System.Drawing.Point(182, 6);
            this.btn_hamming.Name = "btn_hamming";
            this.btn_hamming.Size = new System.Drawing.Size(80, 23);
            this.btn_hamming.TabIndex = 2;
            this.btn_hamming.Text = "Hamming";
            this.btn_hamming.UseVisualStyleBackColor = true;
            this.btn_hamming.Click += new System.EventHandler(this.btn_hamming_Click);
            // 
            // btn_preemphasis
            // 
            this.btn_preemphasis.Location = new System.Drawing.Point(95, 6);
            this.btn_preemphasis.Name = "btn_preemphasis";
            this.btn_preemphasis.Size = new System.Drawing.Size(81, 23);
            this.btn_preemphasis.TabIndex = 2;
            this.btn_preemphasis.Text = "Pre-Emphasis";
            this.btn_preemphasis.UseVisualStyleBackColor = true;
            this.btn_preemphasis.Click += new System.EventHandler(this.btn_preemphasis_Click);
            // 
            // listBox_fftdonustur
            // 
            this.listBox_fftdonustur.FormattingEnabled = true;
            this.listBox_fftdonustur.Items.AddRange(new object[] {
            " "});
            this.listBox_fftdonustur.Location = new System.Drawing.Point(268, 40);
            this.listBox_fftdonustur.Name = "listBox_fftdonustur";
            this.listBox_fftdonustur.Size = new System.Drawing.Size(155, 186);
            this.listBox_fftdonustur.TabIndex = 1;
            // 
            // listBox_hamming
            // 
            this.listBox_hamming.FormattingEnabled = true;
            this.listBox_hamming.Items.AddRange(new object[] {
            " "});
            this.listBox_hamming.Location = new System.Drawing.Point(182, 39);
            this.listBox_hamming.Name = "listBox_hamming";
            this.listBox_hamming.Size = new System.Drawing.Size(80, 186);
            this.listBox_hamming.TabIndex = 1;
            // 
            // listBox_preemphasis
            // 
            this.listBox_preemphasis.FormattingEnabled = true;
            this.listBox_preemphasis.Items.AddRange(new object[] {
            " "});
            this.listBox_preemphasis.Location = new System.Drawing.Point(95, 40);
            this.listBox_preemphasis.Name = "listBox_preemphasis";
            this.listBox_preemphasis.Size = new System.Drawing.Size(81, 186);
            this.listBox_preemphasis.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(762, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "KADIN LVSTN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(817, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "ERKEK LVSTN";
            // 
            // SesAnalizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 674);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SesAnalizi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ses Analizi v.12.1.2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SesAnalizi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_bytecevir;
        private System.Windows.Forms.Button btn_bytecevir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sec;
        private System.Windows.Forms.Button btn_dosyasil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_fftdonustur;
        private System.Windows.Forms.Button btn_hamming;
        private System.Windows.Forms.Button btn_preemphasis;
        private System.Windows.Forms.ListBox listBox_fftdonustur;
        private System.Windows.Forms.ListBox listBox_hamming;
        private System.Windows.Forms.ListBox listBox_preemphasis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart gra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_filterfrekans;
        private System.Windows.Forms.Button btn_melfilter;
        private System.Windows.Forms.ListBox listBox_FFFark;
        private System.Windows.Forms.ListBox listBox_MFCC;
        private System.Windows.Forms.Button btn_MFCC;
        private System.Windows.Forms.Button btn_zeroc;
        private System.Windows.Forms.ListBox listBox_zeroc;
        private System.Windows.Forms.Button btn_veri_kadın;
        private System.Windows.Forms.Button btn_veri_erkek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_erkek_merkez;
        private System.Windows.Forms.Button btn_kadın_merkez;
        private System.Windows.Forms.Button btn_Vq;
        private System.Windows.Forms.ListBox listBox_mindistancekadın;
        private System.Windows.Forms.ListBox listBox_mindistanceerkek;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

