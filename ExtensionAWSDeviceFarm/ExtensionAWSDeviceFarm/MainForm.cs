using Amazon.DeviceFarm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionAWSDeviceFarm
{
    public partial class MainForm : Form
    {
        private MainMenu mainMenu;
        private ContextMenu popUpMenu;
        AmazonDeviceFarmClient _client;
        public MainForm(AmazonDeviceFarmClient client)
        {
            InitializeComponent();
            if (client == null)
            {
                MessageBox.Show("You are not Authorized");

            }
            else
            {
                _client = client;

                mainMenu = new MainMenu();
                //popUpMenu = new ContextMenu();
                //popUpMenu.MenuItems.Add("Hello", new EventHandler(pop_Clicked));
                //this.ContextMenu = popUpMenu;
                MenuItem File = mainMenu.MenuItems.Add("&File");
                File.MenuItems.Add(new MenuItem("&New Project", new EventHandler(this.FileNew_clicked), Shortcut.CtrlN));
                File.MenuItems.Add(new MenuItem("&New Upload", new EventHandler(this.FileUpload_clicked), Shortcut.CtrlN));
                File.MenuItems.Add(new MenuItem("-"));
                File.MenuItems.Add(new MenuItem("&Exit", new EventHandler(this.FileExit_clicked), Shortcut.CtrlX));
                this.Menu = mainMenu;
                MenuItem View = mainMenu.MenuItems.Add("&View");
                View.MenuItems.Add(new MenuItem("&View Project & Run", new EventHandler(this.ViewProject_clicked), Shortcut.CtrlO));
                View.MenuItems.Add(new MenuItem("&View Device", new EventHandler(this.ViewDevices_clicked), Shortcut.CtrlShiftD));
                this.Menu = mainMenu;
                mainMenu.GetForm().BackColor = Color.Indigo;
            }

        }

        private void FileUpload_clicked(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            UploadAPK vw = new UploadAPK();
            vw.MdiParent = this;
            // HideForms();
            vw.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FileExit_clicked(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FileNew_clicked(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ProjectMaster vw = new ProjectMaster();
            vw.MdiParent = this;
            // HideForms();
            vw.Show();
            // MessageBox.Show("New", "MENU_CREATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ViewProject_clicked(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ViewRuns vw = new ViewRuns();
            vw.MdiParent = this;
            // HideForms();
            vw.Show();
            //.Show("Open", "MENU_CREATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void pop_Clicked(object sender, EventArgs e)
        {

            MessageBox.Show("Popupmenu", "MENU_CREATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ViewDevices_clicked(object sender, EventArgs e)
        {
            
            this.IsMdiContainer = true;
            ViewDevices vw = new ViewDevices();
            vw.MdiParent = this;
            vw.Show();
            // HideForms();
            
            // MessageBox.Show("GT", "GT@rediffmail.com");
        }

        public void HideForms()
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "Menu")
                    f.Close();
            }
        }

    }
}
