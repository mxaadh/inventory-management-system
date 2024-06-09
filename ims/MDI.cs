namespace ims
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string connectPath = path + "\\connect";

            if (File.Exists(connectPath))
            {
                Login login = new Login();
                Main.showWindow(login, this);
            }
            else
            {
                Settings settings = new Settings();
                Main.showWindow(settings, this);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            Login login = new Login();
            Main.showWindow(settings, login, MDI.ActiveForm);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.logoutToolStripMenuItem.Enabled = false;
            Login login = new Login();
            Main.showWindow(login, this);
        }
    }
}
