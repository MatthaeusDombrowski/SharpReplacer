using System.Windows.Forms;

namespace Replacer
{
    public partial class ReplaceWindow : Form
    {
        Main MainForm;

        public ReplaceWindow(int length, Main main)
        {
            InitializeComponent();

            progressBar.Maximum = length;
            MainForm = main;
        }

        public void UpdateProgress(string file)
        {
            progressBar.Value++;
            replaceLabel.Text = "Replacing in <" + file + ">";
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            MainForm.cancelTrigger = true;
        }
    }
}
