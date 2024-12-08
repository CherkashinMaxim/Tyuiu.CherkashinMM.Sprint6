namespace Tyuiu.CherkashinMM.Sprint6.Task4.V5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonDone_CMM = new Button();
            buttonSave_CMM = new Button();
            groupBoxInput_CMM = new GroupBox();
            textBoxEndValue_CMM = new TextBox();
            textBoxStartValue_CMM = new TextBox();
            labelStopValue_CMM = new Label();
            labelStartValue_CMM = new Label();
            groupBoxCondition_CMM = new GroupBox();
            pictureBoxFormula_CMM = new PictureBox();
            labelCondition_CMM = new Label();
            labelResult_CMM = new Label();
            groupBoxOutput_CMM = new GroupBox();
            textBoxResult_CMM = new TextBox();
            chartFunction_CMM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new Button();
            groupBoxInput_CMM.SuspendLayout();
            groupBoxCondition_CMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_CMM).BeginInit();
            groupBoxOutput_CMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CMM).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_CMM
            // 
            buttonDone_CMM.BackColor = Color.Green;
            buttonDone_CMM.Font = new Font("Segoe UI", 12F);
            buttonDone_CMM.ForeColor = SystemColors.ControlText;
            buttonDone_CMM.Location = new Point(778, 19);
            buttonDone_CMM.Name = "buttonDone_CMM";
            buttonDone_CMM.Size = new Size(150, 109);
            buttonDone_CMM.TabIndex = 13;
            buttonDone_CMM.Text = "Выполнить";
            buttonDone_CMM.UseVisualStyleBackColor = false;
            buttonDone_CMM.Click += buttonDone_CMM_Click;
            buttonDone_CMM.MouseEnter += buttonDone_CMM_MouseEnter;
            buttonDone_CMM.MouseLeave += buttonDone_CMM_MouseLeave;
            // 
            // buttonSave_CMM
            // 
            buttonSave_CMM.BackColor = Color.CornflowerBlue;
            buttonSave_CMM.Enabled = false;
            buttonSave_CMM.Font = new Font("Segoe UI", 12F);
            buttonSave_CMM.ForeColor = SystemColors.ActiveCaptionText;
            buttonSave_CMM.Location = new Point(934, 21);
            buttonSave_CMM.Name = "buttonSave_CMM";
            buttonSave_CMM.Size = new Size(150, 109);
            buttonSave_CMM.TabIndex = 12;
            buttonSave_CMM.Text = "Сохранить";
            buttonSave_CMM.UseVisualStyleBackColor = false;
            buttonSave_CMM.Click += buttonSave_CMM_Click;
            buttonSave_CMM.MouseEnter += buttonSave_CMM_MouseEnter;
            buttonSave_CMM.MouseLeave += buttonSave_CMM_MouseLeave;
            // 
            // groupBoxInput_CMM
            // 
            groupBoxInput_CMM.Controls.Add(textBoxEndValue_CMM);
            groupBoxInput_CMM.Controls.Add(textBoxStartValue_CMM);
            groupBoxInput_CMM.Controls.Add(labelStopValue_CMM);
            groupBoxInput_CMM.Controls.Add(labelStartValue_CMM);
            groupBoxInput_CMM.Location = new Point(428, 12);
            groupBoxInput_CMM.Name = "groupBoxInput_CMM";
            groupBoxInput_CMM.Size = new Size(344, 118);
            groupBoxInput_CMM.TabIndex = 11;
            groupBoxInput_CMM.TabStop = false;
            groupBoxInput_CMM.Text = "Ввод данных";
            // 
            // textBoxEndValue_CMM
            // 
            textBoxEndValue_CMM.Location = new Point(175, 67);
            textBoxEndValue_CMM.Name = "textBoxEndValue_CMM";
            textBoxEndValue_CMM.Size = new Size(163, 23);
            textBoxEndValue_CMM.TabIndex = 3;
            textBoxEndValue_CMM.KeyPress += textBoxValue_KeyPress;
            // 
            // textBoxStartValue_CMM
            // 
            textBoxStartValue_CMM.Location = new Point(6, 67);
            textBoxStartValue_CMM.Name = "textBoxStartValue_CMM";
            textBoxStartValue_CMM.Size = new Size(163, 23);
            textBoxStartValue_CMM.TabIndex = 2;
            textBoxStartValue_CMM.KeyPress += textBoxValue_KeyPress;
            // 
            // labelStopValue_CMM
            // 
            labelStopValue_CMM.AutoSize = true;
            labelStopValue_CMM.Font = new Font("Segoe UI", 9F);
            labelStopValue_CMM.Location = new Point(175, 32);
            labelStopValue_CMM.Name = "labelStopValue_CMM";
            labelStopValue_CMM.Size = new Size(75, 15);
            labelStopValue_CMM.TabIndex = 1;
            labelStopValue_CMM.Text = "Конец шага:";
            // 
            // labelStartValue_CMM
            // 
            labelStartValue_CMM.AutoSize = true;
            labelStartValue_CMM.Font = new Font("Segoe UI", 9F);
            labelStartValue_CMM.Location = new Point(6, 32);
            labelStartValue_CMM.Name = "labelStartValue_CMM";
            labelStartValue_CMM.Size = new Size(72, 15);
            labelStartValue_CMM.TabIndex = 0;
            labelStartValue_CMM.Text = "Старт шага:";
            // 
            // groupBoxCondition_CMM
            // 
            groupBoxCondition_CMM.Controls.Add(pictureBoxFormula_CMM);
            groupBoxCondition_CMM.Controls.Add(labelCondition_CMM);
            groupBoxCondition_CMM.Location = new Point(12, 12);
            groupBoxCondition_CMM.Name = "groupBoxCondition_CMM";
            groupBoxCondition_CMM.Size = new Size(410, 118);
            groupBoxCondition_CMM.TabIndex = 10;
            groupBoxCondition_CMM.TabStop = false;
            groupBoxCondition_CMM.Text = "Условие";
            // 
            // pictureBoxFormula_CMM
            // 
            pictureBoxFormula_CMM.Image = (Image)resources.GetObject("pictureBoxFormula_CMM.Image");
            pictureBoxFormula_CMM.Location = new Point(6, 67);
            pictureBoxFormula_CMM.Name = "pictureBoxFormula_CMM";
            pictureBoxFormula_CMM.Size = new Size(394, 44);
            pictureBoxFormula_CMM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula_CMM.TabIndex = 1;
            pictureBoxFormula_CMM.TabStop = false;
            // 
            // labelCondition_CMM
            // 
            labelCondition_CMM.AutoSize = true;
            labelCondition_CMM.Font = new Font("Segoe UI", 9F);
            labelCondition_CMM.Location = new Point(6, 19);
            labelCondition_CMM.Name = "labelCondition_CMM";
            labelCondition_CMM.Size = new Size(388, 45);
            labelCondition_CMM.TabIndex = 0;
            labelCondition_CMM.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в textBox, построить график функции и сохранить\r\nрезультат в файл OutPutFileTask4.txt по нажатию кнопки.";
            // 
            // labelResult_CMM
            // 
            labelResult_CMM.AutoSize = true;
            labelResult_CMM.Font = new Font("Segoe UI", 9F);
            labelResult_CMM.Location = new Point(6, 28);
            labelResult_CMM.Name = "labelResult_CMM";
            labelResult_CMM.Size = new Size(63, 15);
            labelResult_CMM.TabIndex = 0;
            labelResult_CMM.Text = "Результат:";
            // 
            // groupBoxOutput_CMM
            // 
            groupBoxOutput_CMM.Controls.Add(textBoxResult_CMM);
            groupBoxOutput_CMM.Controls.Add(labelResult_CMM);
            groupBoxOutput_CMM.Location = new Point(12, 136);
            groupBoxOutput_CMM.Name = "groupBoxOutput_CMM";
            groupBoxOutput_CMM.Size = new Size(216, 476);
            groupBoxOutput_CMM.TabIndex = 14;
            groupBoxOutput_CMM.TabStop = false;
            groupBoxOutput_CMM.Text = "Вывод данных";
            // 
            // textBoxResult_CMM
            // 
            textBoxResult_CMM.Location = new Point(6, 53);
            textBoxResult_CMM.Multiline = true;
            textBoxResult_CMM.Name = "textBoxResult_CMM";
            textBoxResult_CMM.ReadOnly = true;
            textBoxResult_CMM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_CMM.Size = new Size(204, 417);
            textBoxResult_CMM.TabIndex = 1;
            // 
            // chartFunction_CMM
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_CMM.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_CMM.Legends.Add(legend1);
            chartFunction_CMM.Location = new Point(234, 136);
            chartFunction_CMM.Name = "chartFunction_CMM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_CMM.Series.Add(series1);
            chartFunction_CMM.Size = new Size(1022, 476);
            chartFunction_CMM.TabIndex = 15;
            chartFunction_CMM.Text = "chart1";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1147, 19);
            button1.Name = "button1";
            button1.Size = new Size(109, 109);
            button1.TabIndex = 16;
            button1.Text = "Справка";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonHelp_CMM_Click;
            button1.MouseEnter += buttonHelp_CMM_MouseEnter;
            button1.MouseLeave += buttonHelp_CMM_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 624);
            Controls.Add(button1);
            Controls.Add(chartFunction_CMM);
            Controls.Add(buttonDone_CMM);
            Controls.Add(buttonSave_CMM);
            Controls.Add(groupBoxInput_CMM);
            Controls.Add(groupBoxCondition_CMM);
            Controls.Add(groupBoxOutput_CMM);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxInput_CMM.ResumeLayout(false);
            groupBoxInput_CMM.PerformLayout();
            groupBoxCondition_CMM.ResumeLayout(false);
            groupBoxCondition_CMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_CMM).EndInit();
            groupBoxOutput_CMM.ResumeLayout(false);
            groupBoxOutput_CMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CMM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_CMM;
        private Button buttonSave_CMM;
        private GroupBox groupBoxInput_CMM;
        private TextBox textBoxEndValue_CMM;
        private TextBox textBoxStartValue_CMM;
        private Label labelStopValue_CMM;
        private Label labelStartValue_CMM;
        private GroupBox groupBoxCondition_CMM;
        private PictureBox pictureBoxFormula_CMM;
        private Label labelCondition_CMM;
        private Label labelResult_CMM;
        private GroupBox groupBoxOutput_CMM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CMM;
        private Button button1;
        private TextBox textBoxResult_CMM;
    }
}
