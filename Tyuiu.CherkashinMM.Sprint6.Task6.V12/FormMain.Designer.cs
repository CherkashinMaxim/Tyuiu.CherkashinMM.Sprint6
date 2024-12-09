namespace Tyuiu.CherkashinMM.Sprint6.Task6.V12
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons = new Panel();
            buttonAbout = new Button();
            buttonDone = new Button();
            buttonLoad = new Button();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            splitContainerInOutPut = new SplitContainer();
            groupBoxInput = new GroupBox();
            textBoxInput = new TextBox();
            groupBoxOutput = new GroupBox();
            textBoxOutput = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            panelButtons.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerInOutPut).BeginInit();
            splitContainerInOutPut.Panel1.SuspendLayout();
            splitContainerInOutPut.Panel2.SuspendLayout();
            splitContainerInOutPut.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonAbout);
            panelButtons.Controls.Add(buttonDone);
            panelButtons.Controls.Add(buttonLoad);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(804, 68);
            panelButtons.TabIndex = 2;
            // 
            // buttonAbout
            // 
            buttonAbout.Dock = DockStyle.Right;
            buttonAbout.Location = new Point(736, 0);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(68, 68);
            buttonAbout.TabIndex = 2;
            toolTip.SetToolTip(buttonAbout, "Информация о приложении");
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_click;
            // 
            // buttonDone
            // 
            buttonDone.BackgroundImage = Properties.Resources.send_file_1380;
            buttonDone.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone.Dock = DockStyle.Left;
            buttonDone.Location = new Point(73, 0);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(73, 68);
            buttonDone.TabIndex = 1;
            toolTip.SetToolTip(buttonDone, "Производит поиск слов, в которых встречается w и выводит их в результирующую строку");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = SystemColors.Control;
            buttonLoad.BackgroundImage = Properties.Resources.upload_file_icon;
            buttonLoad.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLoad.Dock = DockStyle.Left;
            buttonLoad.ForeColor = SystemColors.ControlText;
            buttonLoad.Location = new Point(0, 0);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(73, 68);
            buttonLoad.TabIndex = 0;
            toolTip.SetToolTip(buttonLoad, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_click;
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 68);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(804, 91);
            panelTask.TabIndex = 3;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Dock = DockStyle.Fill;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(804, 91);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.Dock = DockStyle.Fill;
            labelTask.Location = new Point(3, 19);
            labelTask.MinimumSize = new Size(500, 15);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(798, 69);
            labelTask.TabIndex = 0;
            labelTask.Text = resources.GetString("labelTask.Text");
            // 
            // splitContainerInOutPut
            // 
            splitContainerInOutPut.Dock = DockStyle.Fill;
            splitContainerInOutPut.Location = new Point(0, 159);
            splitContainerInOutPut.Name = "splitContainerInOutPut";
            // 
            // splitContainerInOutPut.Panel1
            // 
            splitContainerInOutPut.Panel1.Controls.Add(groupBoxInput);
            // 
            // splitContainerInOutPut.Panel2
            // 
            splitContainerInOutPut.Panel2.Controls.Add(groupBoxOutput);
            splitContainerInOutPut.Size = new Size(804, 362);
            splitContainerInOutPut.SplitterDistance = 327;
            splitContainerInOutPut.TabIndex = 4;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxInput);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(0, 0);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(327, 362);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод:";
            // 
            // textBoxInput
            // 
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Location = new Point(3, 19);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ReadOnly = true;
            textBoxInput.ScrollBars = ScrollBars.Both;
            textBoxInput.Size = new Size(321, 340);
            textBoxInput.TabIndex = 0;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxOutput);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(473, 362);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод:";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Dock = DockStyle.Fill;
            textBoxOutput.Location = new Point(3, 19);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.ScrollBars = ScrollBars.Both;
            textBoxOutput.Size = new Size(467, 340);
            textBoxOutput.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(804, 521);
            Controls.Add(splitContainerInOutPut);
            Controls.Add(panelTask);
            Controls.Add(panelButtons);
            MinimumSize = new Size(820, 560);
            Name = "FormMain";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 6 | Черкашин М. М.";
            Load += Form1_Load;
            panelButtons.ResumeLayout(false);
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            splitContainerInOutPut.Panel1.ResumeLayout(false);
            splitContainerInOutPut.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerInOutPut).EndInit();
            splitContainerInOutPut.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelButtons;
        private Panel panelTask;
        private GroupBox groupBoxTask;
        private SplitContainer splitContainerInOutPut;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxOutput;
        private Button buttonAbout;
        private Button buttonDone;
        private Button buttonLoad;
        private Label labelTask;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
    }
}
