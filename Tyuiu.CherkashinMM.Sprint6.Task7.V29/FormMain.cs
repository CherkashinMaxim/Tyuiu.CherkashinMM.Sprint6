using Tyuiu.CherkashinMM.Sprint6.Task7.V29.Lib;

namespace Tyuiu.CherkashinMM.Sprint6.Task7.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        static int rows;
        static int cols;
        static string openFilePath;

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput.ColumnCount = 50;
            dataGridViewInput.RowCount = 50;

            dataGridViewOutput.ColumnCount = 50;
            dataGridViewOutput.RowCount = 50;

            buttonDone.Enabled = false;
            buttonSave.Enabled = false;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput.Columns[i].Width = 25;
                dataGridViewOutput.Columns[i].Width = 25;
            }
        }

        private void buttonLoad_click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask.ShowDialog();
                openFilePath = openFileDialogTask.FileName;
                string[] file = File.ReadAllLines(openFilePath);

                rows = dataGridViewInput.ColumnCount = dataGridViewOutput.ColumnCount = file[0].Count(f => f == ';') + 1;
                cols = dataGridViewInput.RowCount = dataGridViewOutput.RowCount = file.Length;

                for (int i = 0; i < cols; i++)
                {
                    string[] line = file[i].Split(';');

                    for (int j = 0; j < rows; j++)
                        dataGridViewInput.Rows[i].Cells[j].Value = line[j];
                }

                buttonDone.Enabled = true;
            }
            catch { }
        }

        private void buttonDone_click(object sender, EventArgs e)
        {
            int[,] res = ds.GetMatrix(openFilePath);

            for (int i = 0; i < res.GetLength(0); i++) 
                for(int j = 0; j < res.GetLength(1); j++)
                    dataGridViewOutput.Rows[i].Cells[j].Value = res[i, j];

            buttonSave.Enabled = true;
        }

        private void buttonSave_click(object sender, EventArgs e)
        {
            saveFileDialogTask.FileName = "OutPutDataFileTask7V29.csv";
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask.ShowDialog();

            string path = saveFileDialogTask.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if(fileExists)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < cols; i++)
            {
                string temp = "";
                for (int j = 0; j < rows; j++)
                {
                    temp += dataGridViewOutput.Rows[i].Cells[j].Value + ";";
                }
                str += temp.Substring(0, temp.Length-1) + "\n";
            }

            File.WriteAllText(path, str);
        }

        private void buttonAbout_click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

    }
}
