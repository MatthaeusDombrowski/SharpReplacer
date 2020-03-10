using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Replacer
{
    public partial class Main : Form
    {
        public bool cancelTrigger;

        public Main()
        {
            InitializeComponent();
            AddLine();

        }


        // Methods //
        void BrowseDirectory()
        {
            var f = new FolderBrowserDialog();

            var dialog = f.ShowDialog();

            if (dialog == DialogResult.OK)
                pathText.Text = f.SelectedPath;
        }

        void AddLine()
        {
            var item = new ReplaceItem() { Parent = listContainer, Dock = DockStyle.Top };
            item.BringToFront();
            listContainer.ScrollControlIntoView(item);
        }

        void RemoveLine()
        {
            if (listContainer.Controls.Count > 1)
                listContainer.Controls.RemoveAt(0);
        }

        async void ReplaceText(bool searchAll)
        {
            var p = pathText.Text;
            var files = new string[] { };


            if(searchAll)
                files = Directory.GetFiles(p, filterText.Text, SearchOption.AllDirectories);
            else
                files = Directory.GetFiles(p, filterText.Text, SearchOption.TopDirectoryOnly);


            var rWindow = new ReplaceWindow(files.Length, this);
            
            Visible = false;
            rWindow.Show();

            foreach (var file in files)
            {
                if (cancelTrigger) break;
                var fText = File.ReadAllText(file);

                foreach (Control i in listContainer.Controls)
                {
                    if (cancelTrigger) break;

                    var old_ = i.Controls.Find("original", false)[0].Text;
                    var new_ = i.Controls.Find("replaced", false)[0].Text;

                    var case_sense = (CheckBox)(i.Controls.Find("case_sense", false)[0]);

                    try
                    {
                        if (case_sense.Checked)
                            fText = Regex.Replace(fText, old_, new_);
                        else
                            fText = Regex.Replace(fText, old_, new_, RegexOptions.IgnoreCase);
                    }
                    catch
                    {
                        MessageBox.Show("Regex Error. Please, check your strings again.", "Error");
                    }
                }


                File.WriteAllText(file, fText);
                await Task.Delay(1);
                rWindow.UpdateProgress(Path.GetFileName(file));
            }

            rWindow.Dispose();

            if (cancelTrigger)
                MessageBox.Show("Operation cancelled. Not all files are updated. ", "Cancelled");
            else
                MessageBox.Show("Files updated. ", "Completed");

            Visible = true;
            cancelTrigger = false;
        }



        // Event Triggers //
        private void AddLineEvent(object sender, EventArgs e)
        {
            AddLine();
        }

        private void RemoveLineEvent(object sender, EventArgs e)
        {
            RemoveLine();
        }

        private void ReplaceButtonEvent(object sender, EventArgs e)
        {
            ReplaceText(false);
        }

        private void ReplaceAllEvent(object sender, EventArgs e)
        {
            ReplaceText(true);
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            BrowseDirectory();
        }
    }
}
