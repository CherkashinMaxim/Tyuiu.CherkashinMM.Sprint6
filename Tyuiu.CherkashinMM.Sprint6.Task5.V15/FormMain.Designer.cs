namespace Tyuiu.CherkashinMM.Sprint6.Task5.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonDone_CMM = new Button();
            buttonOpen_CMM = new Button();
            groupBoxCondition_CMM = new GroupBox();
            labelCondition_CMM = new Label();
            labelResult_CMM = new Label();
            groupBoxOutput_CMM = new GroupBox();
            dataGridViewFunction_CMM = new DataGridView();
            buttonHelp_CMM = new Button();
            chartFunction_CMM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCondition_CMM.SuspendLayout();
            groupBoxOutput_CMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_CMM).BeginInit();
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
            buttonDone_CMM.TabIndex = 20;
            buttonDone_CMM.Text = "Выполнить";
            buttonDone_CMM.UseVisualStyleBackColor = false;
            buttonDone_CMM.Click += buttonDone_CMM_Click;
            buttonDone_CMM.MouseEnter += buttonDone_CMM_MouseEnter;
            buttonDone_CMM.MouseLeave += buttonDone_CMM_MouseLeave;
            // 
            // buttonOpen_CMM
            // 
            buttonOpen_CMM.BackColor = Color.CornflowerBlue;
            buttonOpen_CMM.Enabled = false;
            buttonOpen_CMM.Font = new Font("Segoe UI", 12F);
            buttonOpen_CMM.ForeColor = SystemColors.ActiveCaptionText;
            buttonOpen_CMM.Location = new Point(934, 19);
            buttonOpen_CMM.Name = "buttonOpen_CMM";
            buttonOpen_CMM.Size = new Size(150, 109);
            buttonOpen_CMM.TabIndex = 19;
            buttonOpen_CMM.Text = "Открыть";
            buttonOpen_CMM.UseVisualStyleBackColor = false;
            buttonOpen_CMM.Click += buttonOpen_CMM_Click;
            buttonOpen_CMM.MouseEnter += buttonOpen_CMM_MouseEnter;
            buttonOpen_CMM.MouseLeave += buttonOpen_CMM_MouseLeave;
            // 
            // groupBoxCondition_CMM
            // 
            groupBoxCondition_CMM.Controls.Add(labelCondition_CMM);
            groupBoxCondition_CMM.Location = new Point(12, 12);
            groupBoxCondition_CMM.Name = "groupBoxCondition_CMM";
            groupBoxCondition_CMM.Size = new Size(760, 118);
            groupBoxCondition_CMM.TabIndex = 17;
            groupBoxCondition_CMM.TabStop = false;
            groupBoxCondition_CMM.Text = "Условие";
            // 
            // labelCondition_CMM
            // 
            labelCondition_CMM.AutoSize = true;
            labelCondition_CMM.Font = new Font("Segoe UI", 9F);
            labelCondition_CMM.Location = new Point(6, 28);
            labelCondition_CMM.Name = "labelCondition_CMM";
            labelCondition_CMM.Size = new Size(651, 45);
            labelCondition_CMM.TabIndex = 0;
            labelCondition_CMM.Text = resources.GetString("labelCondition_CMM.Text");
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
            groupBoxOutput_CMM.Controls.Add(dataGridViewFunction_CMM);
            groupBoxOutput_CMM.Controls.Add(labelResult_CMM);
            groupBoxOutput_CMM.Location = new Point(12, 136);
            groupBoxOutput_CMM.Name = "groupBoxOutput_CMM";
            groupBoxOutput_CMM.Size = new Size(216, 474);
            groupBoxOutput_CMM.TabIndex = 21;
            groupBoxOutput_CMM.TabStop = false;
            groupBoxOutput_CMM.Text = "Вывод данных";
            // 
            // dataGridViewFunction_CMM
            // 
            dataGridViewFunction_CMM.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewFunction_CMM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_CMM.ColumnHeadersVisible = false;
            dataGridViewFunction_CMM.Location = new Point(6, 56);
            dataGridViewFunction_CMM.Name = "dataGridViewFunction_CMM";
            dataGridViewFunction_CMM.ReadOnly = true;
            dataGridViewFunction_CMM.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewFunction_CMM.RowHeadersVisible = false;
            dataGridViewFunction_CMM.Size = new Size(204, 412);
            dataGridViewFunction_CMM.TabIndex = 2;
            // 
            // buttonHelp_CMM
            // 
            buttonHelp_CMM.BackColor = SystemColors.MenuHighlight;
            buttonHelp_CMM.Font = new Font("Segoe UI", 12F);
            buttonHelp_CMM.ForeColor = SystemColors.ActiveCaptionText;
            buttonHelp_CMM.Location = new Point(1140, 19);
            buttonHelp_CMM.Name = "buttonHelp_CMM";
            buttonHelp_CMM.Size = new Size(109, 109);
            buttonHelp_CMM.TabIndex = 22;
            buttonHelp_CMM.Text = "Справка";
            buttonHelp_CMM.UseVisualStyleBackColor = false;
            buttonHelp_CMM.Click += buttonHelp_CMM_Click;
            buttonHelp_CMM.MouseEnter += buttonHelp_CMM_MouseEnter;
            buttonHelp_CMM.MouseLeave += buttonHelp_CMM_MouseLeave;
            // 
            // chartFunction_CMM
            // 
            chartArea6.Name = "ChartArea1";
            chartFunction_CMM.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            chartFunction_CMM.Legends.Add(legend6);
            chartFunction_CMM.Location = new Point(234, 136);
            chartFunction_CMM.Name = "chartFunction_CMM";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chartFunction_CMM.Series.Add(series6);
            chartFunction_CMM.Size = new Size(1015, 474);
            chartFunction_CMM.TabIndex = 23;
            chartFunction_CMM.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 622);
            Controls.Add(chartFunction_CMM);
            Controls.Add(buttonDone_CMM);
            Controls.Add(buttonOpen_CMM);
            Controls.Add(groupBoxCondition_CMM);
            Controls.Add(groupBoxOutput_CMM);
            Controls.Add(buttonHelp_CMM);
            Name = "FormMain";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxCondition_CMM.ResumeLayout(false);
            groupBoxCondition_CMM.PerformLayout();
            groupBoxOutput_CMM.ResumeLayout(false);
            groupBoxOutput_CMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_CMM).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CMM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_CMM;
        private Button buttonOpen_CMM;
        private GroupBox groupBoxCondition_CMM;
        private Label labelCondition_CMM;
        private Label labelResult_CMM;
        private GroupBox groupBoxOutput_CMM;
        private Button buttonHelp_CMM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CMM;
        internal DataGridView dataGridViewFunction_CMM;
    }
}
