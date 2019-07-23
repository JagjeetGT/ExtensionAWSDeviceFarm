using Amazon.DeviceFarm.Model;
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
using System.Xml;

namespace ExtensionAWSDeviceFarm
{
    public partial class keysConfiguration : Form
    {

        public keysConfiguration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtkey.Text.Trim().Length > 0 && txtsecret.Text.Trim().Length > 0)
            {
                AWSHelper.AwsAccessKey = txtkey.Text.Trim();
                AWSHelper.AwsSecretKey = txtsecret.Text.Trim();
                var client = AWSHelper.GetAmazonDeviceFarmClient();
                if (client != null)
                {
                    try
                    {
                        var response = client.GetAccountSettings(new GetAccountSettingsRequest { });

                        AccountSettings accountSettings = response.AccountSettings;
                        var result = client.GetAccountSettings();
                        MainForm form = new MainForm(client);
                        form.Show();
                        this.Hide();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Invalid Credentials. " + ee.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Please Enter the Required Data");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
