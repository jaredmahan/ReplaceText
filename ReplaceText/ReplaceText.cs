using System.Windows.Forms;

namespace ReplaceText
{
    public partial class ReplaceText : Form
    {
        public ReplaceText()
        {
            InitializeComponent();
        }

        private void btn_SourceDirectory_Click(object sender, System.EventArgs e)
        {
            var fd = new FolderBrowserDialog();
            fd.ShowNewFolderButton = true;
            fd.ShowDialog();
            txt_SourceDirectory.Text = fd.SelectedPath;
        }

        private void btn_TargetDirectory_Click(object sender, System.EventArgs e)
        {
            var fd = new FolderBrowserDialog();
            fd.ShowNewFolderButton = true;
            fd.ShowDialog();
            txt_TargetDirectory.Text = fd.SelectedPath;
        }

        private void ReplaceText_Load(object sender, System.EventArgs e)
        {
            lst_Logger.Items.Clear();
            lst_Logger.Items.Add("Title: Replace Text Program");
            lst_Logger.Items.Add("Author: Jared Mahan");
            lst_Logger.Items.Add(string.Empty);
            lst_Logger.Items.Add("Description:");
            lst_Logger.Items.Add(string.Empty);
            lst_Logger.Items.Add("Copies and Replaces text based on input added to dictionaries found in the code below.");
            lst_Logger.Items.Add(string.Empty);
            lst_Logger.Items.Add("***************************************************************************************************");
        }
    }
}
