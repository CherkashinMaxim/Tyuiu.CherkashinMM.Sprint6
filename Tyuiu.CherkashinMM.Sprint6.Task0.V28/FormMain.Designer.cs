namespace Tyuiu.CherkashinMM.Sprint6.Task0.V28
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
            groupBoxCondition_CMM = new GroupBox();
            pictureBoxFormula_CMM = new PictureBox();
            textCondition_CMM = new Label();
            groupBoxInput_CMM = new GroupBox();
            labelWriteX_CMM = new Label();
            textBoxX_CMM = new TextBox();
            groupBoxOutput_CMM = new GroupBox();
            textBoxResult_CMM = new TextBox();
            labelResult_CMM = new Label();
            buttonDone_CMM = new Button();
            buttonHelp_CMM = new Button();
            groupBoxCondition_CMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_CMM).BeginInit();
            groupBoxInput_CMM.SuspendLayout();
            groupBoxOutput_CMM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_CMM
            // 
            groupBoxCondition_CMM.Controls.Add(pictureBoxFormula_CMM);
            groupBoxCondition_CMM.Controls.Add(textCondition_CMM);
            groupBoxCondition_CMM.Location = new Point(12, 12);
            groupBoxCondition_CMM.Name = "groupBoxCondition_CMM";
            groupBoxCondition_CMM.Size = new Size(798, 255);
            groupBoxCondition_CMM.TabIndex = 0;
            groupBoxCondition_CMM.TabStop = false;
            groupBoxCondition_CMM.Text = "Условие";
            groupBoxCondition_CMM.Enter += groupBoxCondition_CMM_Enter;
            // 
            // pictureBoxFormula_CMM
            // 
            pictureBoxFormula_CMM.Image = Properties.Resources.Screenshot_4;
            pictureBoxFormula_CMM.Location = new Point(6, 78);
            pictureBoxFormula_CMM.Name = "pictureBoxFormula_CMM";
            pictureBoxFormula_CMM.Size = new Size(537, 64);
            pictureBoxFormula_CMM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula_CMM.TabIndex = 1;
            pictureBoxFormula_CMM.TabStop = false;
            // 
            // textCondition_CMM
            // 
            textCondition_CMM.AutoSize = true;
            textCondition_CMM.Font = new Font("Segoe UI", 12F);
            textCondition_CMM.Location = new Point(6, 28);
            textCondition_CMM.Name = "textCondition_CMM";
            textCondition_CMM.Size = new Size(263, 21);
            textCondition_CMM.TabIndex = 0;
            textCondition_CMM.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_CMM
            // 
            groupBoxInput_CMM.Controls.Add(labelWriteX_CMM);
            groupBoxInput_CMM.Controls.Add(textBoxX_CMM);
            groupBoxInput_CMM.Location = new Point(12, 273);
            groupBoxInput_CMM.Name = "groupBoxInput_CMM";
            groupBoxInput_CMM.Size = new Size(543, 113);
            groupBoxInput_CMM.TabIndex = 1;
            groupBoxInput_CMM.TabStop = false;
            groupBoxInput_CMM.Text = "Ввод данных";
            // 
            // labelWriteX_CMM
            // 
            labelWriteX_CMM.AutoSize = true;
            labelWriteX_CMM.Font = new Font("Segoe UI", 12F);
            labelWriteX_CMM.Location = new Point(6, 50);
            labelWriteX_CMM.Name = "labelWriteX_CMM";
            labelWriteX_CMM.Size = new Size(180, 21);
            labelWriteX_CMM.TabIndex = 1;
            labelWriteX_CMM.Text = "Введите переменную X:";
            // 
            // textBoxX_CMM
            // 
            textBoxX_CMM.Font = new Font("Segoe UI", 12F);
            textBoxX_CMM.HideSelection = false;
            textBoxX_CMM.Location = new Point(192, 47);
            textBoxX_CMM.Name = "textBoxX_CMM";
            textBoxX_CMM.Size = new Size(100, 29);
            textBoxX_CMM.TabIndex = 0;
            textBoxX_CMM.KeyPress += textBoxX_KeyPress;
            // 
            // groupBoxOutput_CMM
            // 
            groupBoxOutput_CMM.Controls.Add(textBoxResult_CMM);
            groupBoxOutput_CMM.Controls.Add(labelResult_CMM);
            groupBoxOutput_CMM.Location = new Point(561, 273);
            groupBoxOutput_CMM.Name = "groupBoxOutput_CMM";
            groupBoxOutput_CMM.Size = new Size(249, 113);
            groupBoxOutput_CMM.TabIndex = 2;
            groupBoxOutput_CMM.TabStop = false;
            groupBoxOutput_CMM.Text = "Вывод данных";
            // 
            // textBoxResult_CMM
            // 
            textBoxResult_CMM.Font = new Font("Segoe UI", 12F);
            textBoxResult_CMM.Location = new Point(6, 59);
            textBoxResult_CMM.Name = "textBoxResult_CMM";
            textBoxResult_CMM.ReadOnly = true;
            textBoxResult_CMM.Size = new Size(204, 29);
            textBoxResult_CMM.TabIndex = 1;
            // 
            // labelResult_CMM
            // 
            labelResult_CMM.AutoSize = true;
            labelResult_CMM.Font = new Font("Segoe UI", 12F);
            labelResult_CMM.Location = new Point(6, 35);
            labelResult_CMM.Name = "labelResult_CMM";
            labelResult_CMM.Size = new Size(83, 21);
            labelResult_CMM.TabIndex = 0;
            labelResult_CMM.Text = "Результат:";
            // 
            // buttonDone_CMM
            // 
            buttonDone_CMM.Location = new Point(615, 392);
            buttonDone_CMM.Name = "buttonDone_CMM";
            buttonDone_CMM.Size = new Size(195, 46);
            buttonDone_CMM.TabIndex = 3;
            buttonDone_CMM.Text = "Выполнить";
            buttonDone_CMM.UseVisualStyleBackColor = true;
            buttonDone_CMM.Click += buttonDone_CMM_Click;
            // 
            // buttonHelp_CMM
            // 
            buttonHelp_CMM.Font = new Font("Segoe UI", 16F);
            buttonHelp_CMM.Location = new Point(561, 392);
            buttonHelp_CMM.Name = "buttonHelp_CMM";
            buttonHelp_CMM.Size = new Size(48, 46);
            buttonHelp_CMM.TabIndex = 4;
            buttonHelp_CMM.Text = "?";
            buttonHelp_CMM.UseVisualStyleBackColor = true;
            buttonHelp_CMM.Click += buttonHelp_CMM_Click;
            // 
            // FormMain
            // 
            AccessibleDescription = "";
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(822, 450);
            Controls.Add(buttonHelp_CMM);
            Controls.Add(buttonDone_CMM);
            Controls.Add(groupBoxOutput_CMM);
            Controls.Add(groupBoxInput_CMM);
            Controls.Add(groupBoxCondition_CMM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 28 | Черкашин М. М.";
            Load += FormMain_Load;
            groupBoxCondition_CMM.ResumeLayout(false);
            groupBoxCondition_CMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_CMM).EndInit();
            groupBoxInput_CMM.ResumeLayout(false);
            groupBoxInput_CMM.PerformLayout();
            groupBoxOutput_CMM.ResumeLayout(false);
            groupBoxOutput_CMM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_CMM;
        private Label textCondition_CMM;
        private PictureBox pictureBoxFormula_CMM;
        private GroupBox groupBoxInput_CMM;
        private GroupBox groupBoxOutput_CMM;
        private Button buttonDone_CMM;
        private Label labelWriteX_CMM;
        private TextBox textBoxX_CMM;
        private TextBox textBoxResult_CMM;
        private Label labelResult_CMM;
        private Button buttonHelp_CMM;
    }
}
