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
    public partial class ViewRuns : Form
    {
        
        public ViewRuns()
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
    }
}
