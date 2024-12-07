using Tyuiu.CherkashinMM.Sprint6.Task1.V6.Lib;

namespace Tyuiu.CherkashinMM.Sprint6.Task1.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_CMM_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            int startValue = Convert.ToInt32(textBoxStartValue_CMM.Text);
            int endValue = Convert.ToInt32(textBoxEndValue_CMM.Text);

            double[] res = ds.GetMassFunction(startValue, endValue);
            int i = 0;

            textBoxResult_CMM.Text = "";
            textBoxResult_CMM.AppendText("+----------+----------+" + Environment.NewLine);
            textBoxResult_CMM.AppendText("+    X     +   f(x)   +" + Environment.NewLine);
            textBoxResult_CMM.AppendText("+----------+----------+" + Environment.NewLine);
            for (int x = startValue; x <= endValue; x++, i++)
            { 
                textBoxResult_CMM.AppendText(String.Format("|{0,5:d}     | {1,6:f2}   |", x, res[i]) + Environment.NewLine);
            }
            textBoxResult_CMM.AppendText("+----------+----------+");
        }

        private void buttonHelp_CMM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-24-1 Черкашин Максим Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            
            if(e.KeyChar == '-')
            {
                if (textBox.Text.Contains("-") || textBox.SelectionStart != 0)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
