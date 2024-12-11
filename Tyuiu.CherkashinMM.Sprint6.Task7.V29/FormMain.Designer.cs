namespace Tyuiu.CherkashinMM.Sprint6.Task7.V29
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
            buttonSave = new Button();
            buttonAbout = new Button();
            buttonDone = new Button();
            buttonLoad = new Button();
            groupBoxTask = new GroupBox();
            splitContainerInOutPut = new SplitContainer();
            groupBoxInput = new GroupBox();
            dataGridViewInput = new DataGridView();
            groupBoxOutput = new GroupBox();
            dataGridViewOutput = new DataGridView();
            labelTask = new Label();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            saveFileDialogTask = new SaveFileDialog();
            panelButtons.SuspendLayout();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerInOutPut).BeginInit();
            splitContainerInOutPut.Panel1.SuspendLayout();
            splitContainerInOutPut.Panel2.SuspendLayout();
            splitContainerInOutPut.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).BeginInit();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonSave);
            panelButtons.Controls.Add(buttonAbout);
            panelButtons.Controls.Add(buttonDone);
            panelButtons.Controls.Add(buttonLoad);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(804, 68);
            panelButtons.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.BackgroundImage = Properties.Resources.folder_download;
            buttonSave.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSave.Dock = DockStyle.Left;
            buttonSave.Location = new Point(146, 0);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(73, 68);
            buttonSave.TabIndex = 3;
            toolTip.SetToolTip(buttonSave, "Сохранить файл");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_click;
            // 
            // buttonAbout
            // 
            buttonAbout.BackgroundImage = Properties.Resources.info;
            buttonAbout.BackgroundImageLayout = ImageLayout.Zoom;
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
            buttonDone.BackgroundImage = Properties.Resources.play;
            buttonDone.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone.Dock = DockStyle.Left;
            buttonDone.Location = new Point(73, 0);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(73, 68);
            buttonDone.TabIndex = 1;
            toolTip.SetToolTip(buttonDone, "Заменяет значения в пятой строке от -5 до 10 на 99 и выводит в dataGridViewOutput");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = SystemColors.Control;
            buttonLoad.BackgroundImage = Properties.Resources.folder_open;
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
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(splitContainerInOutPut);
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Dock = DockStyle.Fill;
            groupBoxTask.Location = new Point(0, 68);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(804, 453);
            groupBoxTask.TabIndex = 4;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // splitContainerInOutPut
            // 
            splitContainerInOutPut.Dock = DockStyle.Fill;
            splitContainerInOutPut.Location = new Point(3, 88);
            splitContainerInOutPut.Name = "splitContainerInOutPut";
            // 
            // splitContainerInOutPut.Panel1
            // 
            splitContainerInOutPut.Panel1.Controls.Add(groupBoxInput);
            // 
            // splitContainerInOutPut.Panel2
            // 
            splitContainerInOutPut.Panel2.Controls.Add(groupBoxOutput);
            splitContainerInOutPut.Size = new Size(798, 362);
            splitContainerInOutPut.SplitterDistance = 324;
            splitContainerInOutPut.TabIndex = 5;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridViewInput);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(0, 0);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(324, 362);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод:";
            // 
            // dataGridViewInput
            // 
            dataGridViewInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput.ColumnHeadersVisible = false;
            dataGridViewInput.Dock = DockStyle.Fill;
            dataGridViewInput.Location = new Point(3, 19);
            dataGridViewInput.Name = "dataGridViewInput";
            dataGridViewInput.ReadOnly = true;
            dataGridViewInput.RowHeadersVisible = false;
            dataGridViewInput.Size = new Size(318, 340);
            dataGridViewInput.TabIndex = 0;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewOutput);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(470, 362);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод:";
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.ColumnHeadersVisible = false;
            dataGridViewOutput.Dock = DockStyle.Fill;
            dataGridViewOutput.Location = new Point(3, 19);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.ReadOnly = true;
            dataGridViewOutput.RowHeadersVisible = false;
            dataGridViewOutput.Size = new Size(464, 340);
            dataGridViewOutput.TabIndex = 0;
            // 
            // labelTask
            // 
            labelTask.Dock = DockStyle.Top;
            labelTask.Location = new Point(3, 19);
            labelTask.MinimumSize = new Size(500, 15);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(798, 69);
            labelTask.TabIndex = 0;
            labelTask.Text = resources.GetString("labelTask.Text");
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
            Controls.Add(groupBoxTask);
            Controls.Add(panelButtons);
            MinimumSize = new Size(820, 560);
            Name = "FormMain";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 29 | Черкашин М. М.";
            Load += FormMain_Load;
            panelButtons.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            splitContainerInOutPut.Panel1.ResumeLayout(false);
            splitContainerInOutPut.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerInOutPut).EndInit();
            splitContainerInOutPut.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).EndInit();
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Button buttonSave;
        private Button buttonAbout;
        private Button buttonDone;
        private Button buttonLoad;
        private GroupBox groupBoxTask;
        private Label labelTask;
        private SplitContainer splitContainerInOutPut;
        private GroupBox groupBoxInput;
        private DataGridView dataGridViewInput;
        private GroupBox groupBoxOutput;
        private DataGridView dataGridViewOutput;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
        private SaveFileDialog saveFileDialogTask;
    }
}
