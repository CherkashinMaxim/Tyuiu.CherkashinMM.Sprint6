using Tyuiu.CherkashinMM.Sprint6.Task4.V5.Lib;

namespace Tyuiu.CherkashinMM.Sprint6.Task4.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_CMM_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_CMM.BackColor = Color.DarkGreen;
        }

        private void buttonDone_CMM_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_CMM.BackColor = Color.Green;
        }

        private void buttonHelp_CMM_MouseEnter(object sender, EventArgs e)
        {
            buttonSave_CMM.BackColor = SystemColors.HotTrack;
        }

        private void buttonHelp_CMM_MouseLeave(object sender, EventArgs e)
        {
            buttonSave_CMM.BackColor = SystemColors.MenuHighlight;
        }

        private void buttonSave_CMM_MouseEnter(object sender, EventArgs e)
        {
            buttonSave_CMM.BackColor = Color.RoyalBlue;
        }

        private void buttonSave_CMM_MouseLeave(object sender, EventArgs e)
        {
            buttonSave_CMM.BackColor = Color.CornflowerBlue;
        }

        private void buttonSave_CMM_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4.txt");
            File.WriteAllText(path, textBoxResult_CMM.Text);
             
            DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }

        private void buttonDone_CMM_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_CMM.Text);
                int endValue = Convert.ToInt32(textBoxEndValue_CMM.Text);

                double[] res = ds.GetMassFunction(startValue, endValue);
                int i = 0;

                this.chartFunction_CMM.Titles.Clear();
                this.chartFunction_CMM.Series[0].Points.Clear();

                this.chartFunction_CMM.Titles.Add("График функции");

                this.chartFunction_CMM.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_CMM.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_CMM.Text = "";

                for (int x = startValue; x <= endValue; x++, i++)
                {
                    textBoxResult_CMM.AppendText($"{res[i]}" + Environment.NewLine);

                    this.chartFunction_CMM.Series[0].Points.AddXY(x, res[i]);
                }

                buttonSave_CMM.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_CMM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-24-1 Черкашин Максим Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-')
            {
                if (textBox.Text.Contains("-") || textBox.SelectionStart != 0)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
