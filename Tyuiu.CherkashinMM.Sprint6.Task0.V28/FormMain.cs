using Tyuiu.CherkashinMM.Sprint6.Task0.V28.Lib;

namespace Tyuiu.CherkashinMM.Sprint6.Task0.V28
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

        private void buttonHelp_CMM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-24-1 Черкашин Максим Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonDone_CMM_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_CMM.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxX_CMM.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
