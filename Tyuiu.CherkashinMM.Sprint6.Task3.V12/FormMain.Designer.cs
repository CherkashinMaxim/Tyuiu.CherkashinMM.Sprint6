namespace Tyuiu.CherkashinMM.Sprint6.Task3.V12
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
            groupBoxOutput_CMM = new GroupBox();
            dataGridViewResult_CMM = new DataGridView();
            labelResult_CMM = new Label();
            groupBoxCondition_CMM = new GroupBox();
            labelCondition_CMM = new Label();
            buttonDone_CMM = new Button();
            buttonHelp_CMM = new Button();
            dataGridViewCondition_CMM = new DataGridView();
            groupBoxOutput_CMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CMM).BeginInit();
            groupBoxCondition_CMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCondition_CMM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOutput_CMM
            // 
            groupBoxOutput_CMM.Controls.Add(dataGridViewResult_CMM);
            groupBoxOutput_CMM.Controls.Add(labelResult_CMM);
            groupBoxOutput_CMM.Location = new Point(773, 12);
            groupBoxOutput_CMM.Name = "groupBoxOutput_CMM";
            groupBoxOutput_CMM.Size = new Size(236, 272);
            groupBoxOutput_CMM.TabIndex = 11;
            groupBoxOutput_CMM.TabStop = false;
            groupBoxOutput_CMM.Text = "Вывод данных";
            // 
            // dataGridViewResult_CMM
            // 
            dataGridViewResult_CMM.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewResult_CMM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_CMM.ColumnHeadersVisible = false;
            dataGridViewResult_CMM.Location = new Point(6, 64);
            dataGridViewResult_CMM.Name = "dataGridViewResult_CMM";
            dataGridViewResult_CMM.ReadOnly = true;
            dataGridViewResult_CMM.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewResult_CMM.RowHeadersVisible = false;
            dataGridViewResult_CMM.Size = new Size(224, 202);
            dataGridViewResult_CMM.TabIndex = 1;
            // 
            // labelResult_CMM
            // 
            labelResult_CMM.AutoSize = true;
            labelResult_CMM.Font = new Font("Segoe UI", 12F);
            labelResult_CMM.Location = new Point(6, 28);
            labelResult_CMM.Name = "labelResult_CMM";
            labelResult_CMM.Size = new Size(83, 21);
            labelResult_CMM.TabIndex = 0;
            labelResult_CMM.Text = "Результат:";
            // 
            // groupBoxCondition_CMM
            // 
            groupBoxCondition_CMM.Controls.Add(labelCondition_CMM);
            groupBoxCondition_CMM.Location = new Point(12, 12);
            groupBoxCondition_CMM.Name = "groupBoxCondition_CMM";
            groupBoxCondition_CMM.Size = new Size(380, 306);
            groupBoxCondition_CMM.TabIndex = 10;
            groupBoxCondition_CMM.TabStop = false;
            groupBoxCondition_CMM.Text = "Условие";
            // 
            // labelCondition_CMM
            // 
            labelCondition_CMM.AutoSize = true;
            labelCondition_CMM.Font = new Font("Segoe UI", 12F);
            labelCondition_CMM.Location = new Point(6, 28);
            labelCondition_CMM.Name = "labelCondition_CMM";
            labelCondition_CMM.Size = new Size(363, 147);
            labelCondition_CMM.TabIndex = 0;
            labelCondition_CMM.Text = "Дан массив 5 на 5 элементов.\r\n-6 -13  -1  -7  10\r\n14 -18  18   1  11\r\n-2 -17 -15 -10  -8\r\n19  -4  -6 -11   8\r\n-17  17  14  13  19\r\nЗаменить четные значения в первой строке на 0.";
            // 
            // buttonDone_CMM
            // 
            buttonDone_CMM.Location = new Point(813, 290);
            buttonDone_CMM.Name = "buttonDone_CMM";
            buttonDone_CMM.Size = new Size(196, 34);
            buttonDone_CMM.TabIndex = 12;
            buttonDone_CMM.Text = "Выполнить";
            buttonDone_CMM.UseVisualStyleBackColor = true;
            buttonDone_CMM.Click += buttonDone_CMM_Click;
            // 
            // buttonHelp_CMM
            // 
            buttonHelp_CMM.Location = new Point(773, 290);
            buttonHelp_CMM.Name = "buttonHelp_CMM";
            buttonHelp_CMM.Size = new Size(34, 34);
            buttonHelp_CMM.TabIndex = 13;
            buttonHelp_CMM.Text = "?";
            buttonHelp_CMM.UseVisualStyleBackColor = true;
            buttonHelp_CMM.Click += buttonHelp_CMM_Click;
            // 
            // dataGridViewCondition_CMM
            // 
            dataGridViewCondition_CMM.Anchor = AnchorStyles.None;
            dataGridViewCondition_CMM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCondition_CMM.ColumnHeadersVisible = false;
            dataGridViewCondition_CMM.Location = new Point(398, 19);
            dataGridViewCondition_CMM.Name = "dataGridViewCondition_CMM";
            dataGridViewCondition_CMM.ReadOnly = true;
            dataGridViewCondition_CMM.RowHeadersVisible = false;
            dataGridViewCondition_CMM.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCondition_CMM.Size = new Size(369, 298);
            dataGridViewCondition_CMM.TabIndex = 14;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 330);
            Controls.Add(dataGridViewCondition_CMM);
            Controls.Add(buttonHelp_CMM);
            Controls.Add(buttonDone_CMM);
            Controls.Add(groupBoxOutput_CMM);
            Controls.Add(groupBoxCondition_CMM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 6 | Черкашин М. М.";
            Load += FormMain_Load;
            groupBoxOutput_CMM.ResumeLayout(false);
            groupBoxOutput_CMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CMM).EndInit();
            groupBoxCondition_CMM.ResumeLayout(false);
            groupBoxCondition_CMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCondition_CMM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOutput_CMM;
        internal DataGridView dataGridViewResult_CMM;
        private Label labelResult_CMM;
        private GroupBox groupBoxCondition_CMM;
        private Label labelCondition_CMM;
        private Button buttonDone_CMM;
        private Button buttonHelp_CMM;
        private DataGridView dataGridViewCondition_CMM;
    }
}
