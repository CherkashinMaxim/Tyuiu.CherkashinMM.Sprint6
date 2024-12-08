using System.IO;
using Tyuiu.CherkashinMM.Sprint6.Task5.V15.Lib;

namespace Tyuiu.CherkashinMM.Sprint6.Task5.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V15.txt");

        private void Form1_Load(object sender, EventArgs e)
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
            buttonHelp_CMM.BackColor = SystemColors.HotTrack;
        }

        private void buttonHelp_CMM_MouseLeave(object sender, EventArgs e)
        {
            buttonHelp_CMM.BackColor = SystemColors.MenuHighlight;
        }

        private void buttonOpen_CMM_MouseEnter(object sender, EventArgs e)
        {
            buttonOpen_CMM.BackColor = Color.RoyalBlue;
        }

        private void buttonOpen_CMM_MouseLeave(object sender, EventArgs e)
        {
            buttonOpen_CMM.BackColor = Color.CornflowerBlue;
        }

        private void buttonOpen_CMM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_CMM_Click(object sender, EventArgs e)
        {
            try
            {
                double[] res = ds.LoadFromDataFile(path);

                dataGridViewFunction_CMM.ColumnCount = 2;
                chartFunction_CMM.Titles.Clear();
                chartFunction_CMM.Series[0].Points.Clear();

                chartFunction_CMM.Titles.Add("График функции");

                chartFunction_CMM.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_CMM.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int x = 0; x < res.Length; x++)
                {
                    dataGridViewFunction_CMM.Rows.Add(Convert.ToString(x + 1), Convert.ToString(res[x]));

                    chartFunction_CMM.Series[0].Points.AddXY(x + 1, res[x]);
                }

                buttonOpen_CMM.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_CMM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-24-1 Черкашин Максим Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
