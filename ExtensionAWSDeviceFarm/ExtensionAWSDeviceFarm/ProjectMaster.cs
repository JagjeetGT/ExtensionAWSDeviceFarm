using ExtensionAWSDeviceFarm.Helpers;
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
    public partial class ProjectMaster : Form
    {
        public ProjectMaster()
        {
            InitializeComponent();
        }

        private void ProjectMaster_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim().Length>0)
            {
                var project = AWSHelper.CreateProject(txtName.Text.Trim());
                if(project!=null)
                {
                    MessageBox.Show("Project Created Successfully");
                }
                else
                {
                    MessageBox.Show("Issue In Creating Project");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Project Name");
            }
        }
    }
}
