using Tyuiu.CherkashinMM.Sprint6.Task3.V12.Lib;

namespace Tyuiu.CherkashinMM.Sprint6.Task3.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = { { -6, -13, -1, -7, 10 }, 
                        { 14, -18, 18, 1, 11, }, 
                        { -2, -17, -15, -10, -8 }, 
                        { 19, -4, -6, -11, 8 }, 
                        { -17, 17, 14, 13, 19 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);

            dataGridViewCondition_CMM.ColumnCount = cols;
            dataGridViewCondition_CMM.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewCondition_CMM.Columns[i].Width = 50;
                dataGridViewCondition_CMM.Rows[i].Height = 50;
            }

            for (int i = 0; (i < mtrx.GetLength(0)); i++)
                for (int j = 0; (j < mtrx.GetLength(1)); j++)
                    dataGridViewCondition_CMM.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
        }

        private void buttonDone_CMM_Click(object sender, EventArgs e)
        {
            int[,] matrixx = ds.Calculate(mtrx);

            int rows = matrixx.GetLength(0);
            int cols = matrixx.GetLength(1);

            dataGridViewResult_CMM.ColumnCount = cols;
            dataGridViewResult_CMM.RowCount = rows;

            for (int i = 0; i < matrixx.GetLength(0); i++)
            {
                dataGridViewResult_CMM.Columns[i].Width = 35;
                dataGridViewResult_CMM.Rows[i].Height = 35;
            }

            for (int i = 0; (i < rows); i++)
                for (int j = 0; (j < cols); j++)
                    dataGridViewResult_CMM.Rows[i].Cells[j].Value = Convert.ToString(matrixx[i, j]);
        }

        private void buttonHelp_CMM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-24-1 Черкашин Максим Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
