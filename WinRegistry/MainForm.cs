namespace WinRegistry
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TestThings()
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
            {
                Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void colourPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveInRegistry saveInRegistry = new SaveInRegistry();
            saveInRegistry.ShowDialog();
        }
    }
}