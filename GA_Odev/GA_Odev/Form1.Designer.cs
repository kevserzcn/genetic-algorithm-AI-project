namespace GA_Odev
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtPopulationSize = new System.Windows.Forms.TextBox();
            this.txtCrossoverRate = new System.Windows.Forms.TextBox();
            this.txtMutationRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtElitismCount = new System.Windows.Forms.TextBox();
            this.txtGenerationCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRunGA = new System.Windows.Forms.Button();
            this.chartConvergence = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartConvergence)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPopulationSize
            // 
            this.txtPopulationSize.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopulationSize.Location = new System.Drawing.Point(245, 76);
            this.txtPopulationSize.Name = "txtPopulationSize";
            this.txtPopulationSize.Size = new System.Drawing.Size(111, 32);
            this.txtPopulationSize.TabIndex = 0;
            // 
            // txtCrossoverRate
            // 
            this.txtCrossoverRate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtCrossoverRate.Location = new System.Drawing.Point(614, 74);
            this.txtCrossoverRate.Name = "txtCrossoverRate";
            this.txtCrossoverRate.Size = new System.Drawing.Size(117, 32);
            this.txtCrossoverRate.TabIndex = 1;
            // 
            // txtMutationRate
            // 
            this.txtMutationRate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtMutationRate.Location = new System.Drawing.Point(245, 141);
            this.txtMutationRate.Name = "txtMutationRate";
            this.txtMutationRate.Size = new System.Drawing.Size(111, 32);
            this.txtMutationRate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Plum;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Popülasyon Boyutu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Plum;
            this.label2.Location = new System.Drawing.Point(414, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Çaprazlama Oranı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Plum;
            this.label3.Location = new System.Drawing.Point(38, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mutasyon Oranı:";
            // 
            // txtElitismCount
            // 
            this.txtElitismCount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtElitismCount.Location = new System.Drawing.Point(245, 217);
            this.txtElitismCount.Name = "txtElitismCount";
            this.txtElitismCount.Size = new System.Drawing.Size(111, 32);
            this.txtElitismCount.TabIndex = 6;
            // 
            // txtGenerationCount
            // 
            this.txtGenerationCount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtGenerationCount.Location = new System.Drawing.Point(614, 141);
            this.txtGenerationCount.Name = "txtGenerationCount";
            this.txtGenerationCount.Size = new System.Drawing.Size(117, 32);
            this.txtGenerationCount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Plum;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seçkinlik Birey Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Plum;
            this.label5.Location = new System.Drawing.Point(414, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jenerasyon Sayısı:";
            // 
            // btnRunGA
            // 
            this.btnRunGA.BackColor = System.Drawing.Color.Violet;
            this.btnRunGA.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunGA.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnRunGA.Location = new System.Drawing.Point(582, 217);
            this.btnRunGA.Name = "btnRunGA";
            this.btnRunGA.Size = new System.Drawing.Size(149, 39);
            this.btnRunGA.TabIndex = 11;
            this.btnRunGA.Text = "Başlat";
            this.btnRunGA.UseVisualStyleBackColor = false;
            this.btnRunGA.Click += new System.EventHandler(this.btnRunGA_Click);
            // 
            // chartConvergence
            // 
            this.chartConvergence.BackColor = System.Drawing.Color.DarkViolet;
            this.chartConvergence.BorderlineColor = System.Drawing.Color.IndianRed;
            chartArea1.Name = "ChartArea1";
            this.chartConvergence.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartConvergence.Legends.Add(legend1);
            this.chartConvergence.Location = new System.Drawing.Point(93, 296);
            this.chartConvergence.Name = "chartConvergence";
            this.chartConvergence.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartConvergence.Series.Add(series1);
            this.chartConvergence.Size = new System.Drawing.Size(603, 378);
            this.chartConvergence.TabIndex = 12;
            this.chartConvergence.Text = "chart1";
            this.chartConvergence.Click += new System.EventHandler(this.chartConvergence_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(209, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 41);
            this.label6.TabIndex = 13;
            this.label6.Text = "GENETİK ALGORİTMA";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(801, 711);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chartConvergence);
            this.Controls.Add(this.btnRunGA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGenerationCount);
            this.Controls.Add(this.txtElitismCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMutationRate);
            this.Controls.Add(this.txtCrossoverRate);
            this.Controls.Add(this.txtPopulationSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartConvergence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPopulationSize;
        private System.Windows.Forms.TextBox txtCrossoverRate;
        private System.Windows.Forms.TextBox txtMutationRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtElitismCount;
        private System.Windows.Forms.TextBox txtGenerationCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRunGA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartConvergence;
        private System.Windows.Forms.Label label6;
    }
}

