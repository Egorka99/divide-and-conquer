namespace WindowsFormsApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.chartSort = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1Time4 = new System.Windows.Forms.Label();
            this.labelTime3 = new System.Windows.Forms.Label();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBoxGraphic = new System.Windows.Forms.GroupBox();
            this.panelG = new System.Windows.Forms.Panel();
            this.panelF = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxF1point = new System.Windows.Forms.TextBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.textBoxFDist = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxF2point = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxG1point = new System.Windows.Forms.TextBox();
            this.textBoxGDist = new System.Windows.Forms.TextBox();
            this.textBoxG2point = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.chartPoints = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSort)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBoxGraphic.SuspendLayout();
            this.panelG.SuspendLayout();
            this.panelF.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(845, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonCalculate);
            this.tabPage3.Controls.Add(this.chartSort);
            this.tabPage3.Controls.Add(this.label1Time4);
            this.tabPage3.Controls.Add(this.labelTime3);
            this.tabPage3.Controls.Add(this.labelTime2);
            this.tabPage3.Controls.Add(this.labelTime1);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(837, 446);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Сортировка слиянием";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(252, 131);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(103, 32);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // chartSort
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSort.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSort.Legends.Add(legend4);
            this.chartSort.Location = new System.Drawing.Point(399, 115);
            this.chartSort.Name = "chartSort";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.LegendText = "График времени сортировки от количества элементов";
            series6.Name = "Graphic";
            this.chartSort.Series.Add(series6);
            this.chartSort.Size = new System.Drawing.Size(419, 251);
            this.chartSort.TabIndex = 12;
            this.chartSort.Text = "chart1";
            // 
            // label1Time4
            // 
            this.label1Time4.AutoSize = true;
            this.label1Time4.Location = new System.Drawing.Point(132, 301);
            this.label1Time4.Name = "label1Time4";
            this.label1Time4.Size = new System.Drawing.Size(15, 16);
            this.label1Time4.TabIndex = 11;
            this.label1Time4.Text = "0";
            // 
            // labelTime3
            // 
            this.labelTime3.AutoSize = true;
            this.labelTime3.Location = new System.Drawing.Point(132, 260);
            this.labelTime3.Name = "labelTime3";
            this.labelTime3.Size = new System.Drawing.Size(15, 16);
            this.labelTime3.TabIndex = 10;
            this.labelTime3.Text = "0";
            // 
            // labelTime2
            // 
            this.labelTime2.AutoSize = true;
            this.labelTime2.Location = new System.Drawing.Point(132, 221);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(15, 16);
            this.labelTime2.TabIndex = 9;
            this.labelTime2.Text = "0";
            // 
            // labelTime1
            // 
            this.labelTime1.AutoSize = true;
            this.labelTime1.Location = new System.Drawing.Point(132, 181);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(15, 16);
            this.labelTime1.TabIndex = 8;
            this.labelTime1.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(115, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Время";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "25 000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "20 000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "15 000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "10 000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "N ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "N - количество чисел для сортировки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(641, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " \tO(n log2 n)";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBoxGraphic);
            this.tabPage4.Controls.Add(this.radioButton2);
            this.tabPage4.Controls.Add(this.radioButton1);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(837, 446);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Алгоритм выбора ближайших пар точек ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBoxGraphic
            // 
            this.groupBoxGraphic.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGraphic.Controls.Add(this.panelF);
            this.groupBoxGraphic.Controls.Add(this.panelG);
            this.groupBoxGraphic.Location = new System.Drawing.Point(3, 82);
            this.groupBoxGraphic.Name = "groupBoxGraphic";
            this.groupBoxGraphic.Size = new System.Drawing.Size(819, 329);
            this.groupBoxGraphic.TabIndex = 16;
            this.groupBoxGraphic.TabStop = false;
            // 
            // panelG
            // 
            this.panelG.Controls.Add(this.groupBox1);
            this.panelG.Controls.Add(this.chartPoints);
            this.panelG.Location = new System.Drawing.Point(0, 3);
            this.panelG.Name = "panelG";
            this.panelG.Size = new System.Drawing.Size(819, 356);
            this.panelG.TabIndex = 17;
            // 
            // panelF
            // 
            this.panelF.BackColor = System.Drawing.Color.DimGray;
            this.panelF.Controls.Add(this.groupBox2);
            this.panelF.Location = new System.Drawing.Point(3, 0);
            this.panelF.Name = "panelF";
            this.panelF.Size = new System.Drawing.Size(816, 320);
            this.panelF.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxF1point);
            this.groupBox2.Controls.Add(this.buttonFile);
            this.groupBox2.Controls.Add(this.textBoxFDist);
            this.groupBox2.Controls.Add(this.labelError);
            this.groupBox2.Controls.Add(this.textBoxF2point);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(219, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 178);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные из файла";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Выбрать файл:";
            // 
            // textBoxF1point
            // 
            this.textBoxF1point.Location = new System.Drawing.Point(193, 134);
            this.textBoxF1point.Name = "textBoxF1point";
            this.textBoxF1point.ReadOnly = true;
            this.textBoxF1point.Size = new System.Drawing.Size(53, 22);
            this.textBoxF1point.TabIndex = 10;
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(118, 64);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(75, 23);
            this.buttonFile.TabIndex = 2;
            this.buttonFile.Text = "Файл ";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // textBoxFDist
            // 
            this.textBoxFDist.Location = new System.Drawing.Point(131, 178);
            this.textBoxFDist.Name = "textBoxFDist";
            this.textBoxFDist.ReadOnly = true;
            this.textBoxFDist.Size = new System.Drawing.Size(82, 22);
            this.textBoxFDist.TabIndex = 9;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(24, 103);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(80, 16);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "Имя файла";
            // 
            // textBoxF2point
            // 
            this.textBoxF2point.Location = new System.Drawing.Point(271, 134);
            this.textBoxF2point.Name = "textBoxF2point";
            this.textBoxF2point.ReadOnly = true;
            this.textBoxF2point.Size = new System.Drawing.Size(53, 22);
            this.textBoxF2point.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Пара ближайших точек:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Расстояние:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxG1point);
            this.groupBox1.Controls.Add(this.textBoxGDist);
            this.groupBox1.Controls.Add(this.textBoxG2point);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.buttonGenerate);
            this.groupBox1.Location = new System.Drawing.Point(6, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Представление на графике";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Пара ближайших точек:";
            // 
            // textBoxG1point
            // 
            this.textBoxG1point.Location = new System.Drawing.Point(173, 94);
            this.textBoxG1point.Name = "textBoxG1point";
            this.textBoxG1point.ReadOnly = true;
            this.textBoxG1point.Size = new System.Drawing.Size(53, 22);
            this.textBoxG1point.TabIndex = 5;
            // 
            // textBoxGDist
            // 
            this.textBoxGDist.Location = new System.Drawing.Point(111, 138);
            this.textBoxGDist.Name = "textBoxGDist";
            this.textBoxGDist.ReadOnly = true;
            this.textBoxGDist.Size = new System.Drawing.Size(82, 22);
            this.textBoxGDist.TabIndex = 4;
            // 
            // textBoxG2point
            // 
            this.textBoxG2point.Location = new System.Drawing.Point(256, 94);
            this.textBoxG2point.Name = "textBoxG2point";
            this.textBoxG2point.ReadOnly = true;
            this.textBoxG2point.Size = new System.Drawing.Size(53, 22);
            this.textBoxG2point.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Расстояние:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 6;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(44, 34);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(174, 38);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Сгенерировать точки";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // chartPoints
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPoints.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPoints.Legends.Add(legend3);
            this.chartPoints.Location = new System.Drawing.Point(358, 60);
            this.chartPoints.Name = "chartPoints";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.LegendText = "Остальные точки";
            series4.Name = "Points";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.LegendText = "Точки с наименьшим расстоянием";
            series5.Name = "Points2";
            this.chartPoints.Series.Add(series4);
            this.chartPoints.Series.Add(series5);
            this.chartPoints.Size = new System.Drawing.Size(444, 204);
            this.chartPoints.TabIndex = 12;
            this.chartPoints.Text = "chart2";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(275, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(141, 20);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "Данные из файла";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(49, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(208, 20);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Представление на графике";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(699, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = " \tO(n log2 n)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 487);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Разделяй и властвуй";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSort)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBoxGraphic.ResumeLayout(false);
            this.panelG.ResumeLayout(false);
            this.panelF.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSort;
        private System.Windows.Forms.Label label1Time4;
        private System.Windows.Forms.Label labelTime3;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPoints;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxF1point;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.TextBox textBoxFDist;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxF2point;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxG1point;
        private System.Windows.Forms.TextBox textBoxGDist;
        private System.Windows.Forms.TextBox textBoxG2point;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBoxGraphic;
        private System.Windows.Forms.Panel panelG;
        private System.Windows.Forms.Panel panelF;
    }
}

