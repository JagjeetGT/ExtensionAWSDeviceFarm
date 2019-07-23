using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExtensionAWSDeviceFarm.Helpers
{
      public static  class CommonHelper
    {
        public static bool IsValidLogin(string AwsAccessKey, string AwsSecretKey)
        {
            XDocument doc = XDocument.Load("Login.xml");

            return doc.Descendants("id")
                      .Where(id => id.Attribute("AwsAccessKey").Value == AwsAccessKey
                             && id.Attribute("AwsSecretKey").Value == AwsSecretKey)
                      .Any();
        }
    }
}
