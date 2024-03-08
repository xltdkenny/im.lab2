namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Predict = new System.Windows.Forms.Button();
            this.zxcEuro = new System.Windows.Forms.NumericUpDown();
            this.zxcDollar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zxcEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button_Predict);
            this.panel1.Controls.Add(this.zxcEuro);
            this.panel1.Controls.Add(this.zxcDollar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 280);
            this.panel1.TabIndex = 0;
            // 
            // button_Predict
            // 
            this.button_Predict.Location = new System.Drawing.Point(40, 195);
            this.button_Predict.Name = "button_Predict";
            this.button_Predict.Size = new System.Drawing.Size(120, 23);
            this.button_Predict.TabIndex = 6;
            this.button_Predict.Text = "Старт/Стоп";
            this.button_Predict.UseVisualStyleBackColor = true;
            this.button_Predict.Click += new System.EventHandler(this.btPredict_Click);
            // 
            // zxcEuro
            // 
            this.zxcEuro.DecimalPlaces = 2;
            this.zxcEuro.Location = new System.Drawing.Point(40, 138);
            this.zxcEuro.Name = "zxcEuro";
            this.zxcEuro.Size = new System.Drawing.Size(120, 20);
            this.zxcEuro.TabIndex = 3;
            this.zxcEuro.Value = new decimal(new int[] {
            9947,
            0,
            0,
            131072});
            // 
            // zxcDollar
            // 
            this.zxcDollar.DecimalPlaces = 2;
            this.zxcDollar.Location = new System.Drawing.Point(40, 60);
            this.zxcDollar.Name = "zxcDollar";
            this.zxcDollar.Size = new System.Drawing.Size(120, 20);
            this.zxcDollar.TabIndex = 2;
            this.zxcDollar.Value = new decimal(new int[] {
            9164,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Текущий курс € Евро";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий курс $ Доллара";
            // 
            // graphic
            // 
            this.graphic.BackColor = System.Drawing.Color.AliceBlue;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Minimum = 60D;
            chartArea2.Name = "ChartArea1";
            this.graphic.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Валюта";
            this.graphic.Legends.Add(legend2);
            this.graphic.Location = new System.Drawing.Point(208, 1);
            this.graphic.Name = "graphic";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "C";
            series3.Legend = "Legend1";
            series3.Name = "Доллар";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "C";
            series4.Legend = "Legend1";
            series4.Name = "Евро";
            this.graphic.Series.Add(series3);
            this.graphic.Series.Add(series4);
            this.graphic.Size = new System.Drawing.Size(580, 342);
            this.graphic.TabIndex = 1;
            this.graphic.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Прогнозы котировок валют,\r\nдвижение доллара и евро,\r\nвлияние на них\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.graphic);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Прогнозирование курса валют";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zxcEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Predict;
        private System.Windows.Forms.NumericUpDown zxcEuro;
        private System.Windows.Forms.NumericUpDown zxcDollar;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

