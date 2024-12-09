using Tyuiu.CherkashinMM.Sprint6.Task6.V12.Lib;

namespace Tyuiu.CherkashinMM.Sprint6.Task6.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonAbout.Image = SystemIcons.Information.ToBitmap();
            buttonDone.Enabled = false;
        }

        private void buttonLoad_click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInput.Text = File.ReadAllText(openFilePath);
            groupBoxInput.Text = groupBoxInput.Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }

        private void buttonDone_click(object sender, EventArgs e)
        {
            string str = "w";
            textBoxOutput.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonAbout_click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
