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
    }
}
