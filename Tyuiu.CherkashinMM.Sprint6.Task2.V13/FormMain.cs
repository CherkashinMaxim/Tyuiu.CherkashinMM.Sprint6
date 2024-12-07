using Tyuiu.CherkashinMM.Sprint6.Task2.V13.Lib;

namespace Tyuiu.CherkashinMM.Sprint6.Task2.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

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
            buttonHelp_CMM.BackColor = SystemColors.HotTrack;
        }

        private void buttonHelp_CMM_MouseLeave(object sender, EventArgs e)
        {
            buttonHelp_CMM.BackColor = SystemColors.MenuHighlight;
        }

        private void buttonDone_CMM_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_CMM.Text);
                int endValue = Convert.ToInt32(textBoxEndValue_CMM.Text);

                double[] res = ds.GetMassFunction(startValue, endValue);
                int i = 0;

                this.chartFunction_CMM.Titles.Add("График функции");

                this.chartFunction_CMM.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_CMM.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int x = startValue; x <= endValue; x++, i++)
                {
                    this.dataGridViewFunction_CMM.Rows.Add(Convert.ToString(x), Convert.ToString(res[i]));

                    this.chartFunction_CMM.Series[0].Points.AddXY(x, res[i]);
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_CMM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-24-1 Черкашин Максим Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
