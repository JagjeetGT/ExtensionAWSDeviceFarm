using Amazon.DeviceFarm;
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
    public partial class ViewDevices : Form
    {
       
        public ViewDevices()
        {           
            InitializeComponent();
            drpproject.DataSource = AWSHelper.GetProjectList();
            drpproject.DisplayMember = "Name";
            drpproject.ValueMember = "Arn";
            //var devices = AWSHelper.GetDevices();
            //dgdevice.DataSource = devices;
        }

        private void ViewDevices_Load(object sender, EventArgs e)
        {


        }
        public void BindDevices(string projectid)
        {
            var projectlist = AWSHelper.GetDevices(projectid);
            dgdevice.DataSource = projectlist;
            dgdevice.Columns["Cpu"].Visible = false;
            dgdevice.Columns["Resolution"].Visible = false;
            dgdevice.Columns["Carrier"].Visible = false;
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            BindDevices(drpproject.SelectedValue.ToString());
        }
    }
}
