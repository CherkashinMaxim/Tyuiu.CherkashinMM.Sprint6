namespace Tyuiu.CherkashinMM.Sprint6.Task1.V6
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
            groupBoxCondition_CMM = new GroupBox();
            pictureBoxFormula_CMM = new PictureBox();
            labelCondition_CMM = new Label();
            groupBoxOutput_CMM = new GroupBox();
            textBoxResult_CMM = new TextBox();
            labelResult_CMM = new Label();
            groupBoxInput_CMM = new GroupBox();
            textBoxEndValue_CMM = new TextBox();
            textBoxStartValue_CMM = new TextBox();
            labelStopValue_CMM = new Label();
            labelStartValue_CMM = new Label();
            buttonHelp_CMM = new Button();
            buttonDone_CMM = new Button();
            groupBoxCondition_CMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_CMM).BeginInit();
            groupBoxOutput_CMM.SuspendLayout();
            groupBoxInput_CMM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_CMM
            // 
            groupBoxCondition_CMM.Controls.Add(pictureBoxFormula_CMM);
            groupBoxCondition_CMM.Controls.Add(labelCondition_CMM);
            groupBoxCondition_CMM.Location = new Point(12, 12);
            groupBoxCondition_CMM.Name = "groupBoxCondition_CMM";
            groupBoxCondition_CMM.Size = new Size(640, 389);
            groupBoxCondition_CMM.TabIndex = 0;
            groupBoxCondition_CMM.TabStop = false;
            groupBoxCondition_CMM.Text = "Условие";
            // 
            // pictureBoxFormula_CMM
            // 
            pictureBoxFormula_CMM.Image = (Image)resources.GetObject("pictureBoxFormula_CMM.Image");
            pictureBoxFormula_CMM.Location = new Point(6, 98);
            pictureBoxFormula_CMM.Name = "pictureBoxFormula_CMM";
            pictureBoxFormula_CMM.Size = new Size(492, 66);
            pictureBoxFormula_CMM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula_CMM.TabIndex = 1;
            pictureBoxFormula_CMM.TabStop = false;
            // 
            // labelCondition_CMM
            // 
            labelCondition_CMM.AutoSize = true;
            labelCondition_CMM.Font = new Font("Segoe UI", 12F);
            labelCondition_CMM.Location = new Point(6, 36);
            labelCondition_CMM.Name = "labelCondition_CMM";
            labelCondition_CMM.Size = new Size(387, 42);
            labelCondition_CMM.TabIndex = 0;
            labelCondition_CMM.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxOutput_CMM
            // 
            groupBoxOutput_CMM.Controls.Add(textBoxResult_CMM);
            groupBoxOutput_CMM.Controls.Add(labelResult_CMM);
            groupBoxOutput_CMM.Location = new Point(658, 12);
            groupBoxOutput_CMM.Name = "groupBoxOutput_CMM";
            groupBoxOutput_CMM.Size = new Size(372, 500);
            groupBoxOutput_CMM.TabIndex = 1;
            groupBoxOutput_CMM.TabStop = false;
            groupBoxOutput_CMM.Text = "Вывод данных";
            // 
            // textBoxResult_CMM
            // 
            textBoxResult_CMM.Font = new Font("Consolas", 10F);
            textBoxResult_CMM.Location = new Point(6, 62);
            textBoxResult_CMM.Multiline = true;
            textBoxResult_CMM.Name = "textBoxResult_CMM";
            textBoxResult_CMM.ReadOnly = true;
            textBoxResult_CMM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_CMM.Size = new Size(360, 432);
            textBoxResult_CMM.TabIndex = 1;
            // 
            // labelResult_CMM
            // 
            labelResult_CMM.AutoSize = true;
            labelResult_CMM.Font = new Font("Segoe UI", 12F);
            labelResult_CMM.Location = new Point(6, 26);
            labelResult_CMM.Name = "labelResult_CMM";
            labelResult_CMM.Size = new Size(83, 21);
            labelResult_CMM.TabIndex = 0;
            labelResult_CMM.Text = "Результат:";
            // 
            // groupBoxInput_CMM
            // 
            groupBoxInput_CMM.Controls.Add(textBoxEndValue_CMM);
            groupBoxInput_CMM.Controls.Add(textBoxStartValue_CMM);
            groupBoxInput_CMM.Controls.Add(labelStopValue_CMM);
            groupBoxInput_CMM.Controls.Add(labelStartValue_CMM);
            groupBoxInput_CMM.Location = new Point(12, 407);
            groupBoxInput_CMM.Name = "groupBoxInput_CMM";
            groupBoxInput_CMM.Size = new Size(344, 105);
            groupBoxInput_CMM.TabIndex = 2;
            groupBoxInput_CMM.TabStop = false;
            groupBoxInput_CMM.Text = "Ввод данных";
            // 
            // textBoxEndValue_CMM
            // 
            textBoxEndValue_CMM.Location = new Point(175, 64);
            textBoxEndValue_CMM.Name = "textBoxEndValue_CMM";
            textBoxEndValue_CMM.Size = new Size(163, 23);
            textBoxEndValue_CMM.TabIndex = 3;
            textBoxEndValue_CMM.KeyPress += textBoxValue_KeyPress;
            // 
            // textBoxStartValue_CMM
            // 
            textBoxStartValue_CMM.Location = new Point(6, 64);
            textBoxStartValue_CMM.Name = "textBoxStartValue_CMM";
            textBoxStartValue_CMM.Size = new Size(163, 23);
            textBoxStartValue_CMM.TabIndex = 2;
            textBoxStartValue_CMM.KeyPress += textBoxValue_KeyPress;
            // 
            // labelStopValue_CMM
            // 
            labelStopValue_CMM.AutoSize = true;
            labelStopValue_CMM.Font = new Font("Segoe UI", 12F);
            labelStopValue_CMM.Location = new Point(175, 26);
            labelStopValue_CMM.Name = "labelStopValue_CMM";
            labelStopValue_CMM.Size = new Size(94, 21);
            labelStopValue_CMM.TabIndex = 1;
            labelStopValue_CMM.Text = "Конец шага";
            // 
            // labelStartValue_CMM
            // 
            labelStartValue_CMM.AutoSize = true;
            labelStartValue_CMM.Font = new Font("Segoe UI", 12F);
            labelStartValue_CMM.Location = new Point(6, 26);
            labelStartValue_CMM.Name = "labelStartValue_CMM";
            labelStartValue_CMM.Size = new Size(93, 21);
            labelStartValue_CMM.TabIndex = 0;
            labelStartValue_CMM.Text = "Старт шага:";
            // 
            // buttonHelp_CMM
            // 
            buttonHelp_CMM.BackColor = SystemColors.MenuHighlight;
            buttonHelp_CMM.Font = new Font("Segoe UI", 12F);
            buttonHelp_CMM.ForeColor = SystemColors.ActiveCaptionText;
            buttonHelp_CMM.Location = new Point(362, 416);
            buttonHelp_CMM.Name = "buttonHelp_CMM";
            buttonHelp_CMM.Size = new Size(117, 93);
            buttonHelp_CMM.TabIndex = 3;
            buttonHelp_CMM.Text = "Справка";
            buttonHelp_CMM.UseVisualStyleBackColor = false;
            buttonHelp_CMM.Click += buttonHelp_CMM_Click;
            // 
            // buttonDone_CMM
            // 
            buttonDone_CMM.BackColor = Color.Green;
            buttonDone_CMM.Font = new Font("Segoe UI", 12F);
            buttonDone_CMM.ForeColor = SystemColors.ControlText;
            buttonDone_CMM.Location = new Point(485, 416);
            buttonDone_CMM.Name = "buttonDone_CMM";
            buttonDone_CMM.Size = new Size(167, 93);
            buttonDone_CMM.TabIndex = 4;
            buttonDone_CMM.Text = "Выполнить";
            buttonDone_CMM.UseVisualStyleBackColor = false;
            buttonDone_CMM.Click += buttonDone_CMM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 524);
            Controls.Add(buttonDone_CMM);
            Controls.Add(buttonHelp_CMM);
            Controls.Add(groupBoxInput_CMM);
            Controls.Add(groupBoxOutput_CMM);
            Controls.Add(groupBoxCondition_CMM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 6 | Черкашин М. М.";
            Load += FormMain_Load;
            groupBoxCondition_CMM.ResumeLayout(false);
            groupBoxCondition_CMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_CMM).EndInit();
            groupBoxOutput_CMM.ResumeLayout(false);
            groupBoxOutput_CMM.PerformLayout();
            groupBoxInput_CMM.ResumeLayout(false);
            groupBoxInput_CMM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_CMM;
        private GroupBox groupBoxOutput_CMM;
        private GroupBox groupBoxInput_CMM;
        private Button buttonHelp_CMM;
        private Label labelCondition_CMM;
        private TextBox textBoxResult_CMM;
        private Label labelResult_CMM;
        private TextBox textBoxStartValue_CMM;
        private Label labelStopValue_CMM;
        private Label labelStartValue_CMM;
        private Button buttonDone_CMM;
        private PictureBox pictureBoxFormula_CMM;
        private TextBox textBoxEndValue_CMM;
    }
}
