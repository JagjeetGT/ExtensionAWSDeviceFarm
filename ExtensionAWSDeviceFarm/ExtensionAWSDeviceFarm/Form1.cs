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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            drpproject.DataSource = AWSHelper.GetProjectList();
            drpproject.DisplayMember = "Name";
            drpproject.ValueMember = "Arn";                     

        }
        public void BindList(string projectid)
        {            
            var projectlist = AWSHelper.GetRuns(projectid);
            dgRuns.DataSource = projectlist;           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BindList(drpproject.SelectedValue.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
