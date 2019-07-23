using Amazon;
using Amazon.DeviceFarm;
using Amazon.DeviceFarm.Model;
using Amazon.S3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionAWSDeviceFarm.Helpers
{
    public static class AWSHelper
    {
        public static string AwsAccessKey { get; set; }
        public static string AwsSecretKey { get; set; }
        public static AmazonDeviceFarmClient client { get; set; }
        public static AmazonDeviceFarmClient GetAmazonDeviceFarmClient()
        {
            try
            {
                var bucketRegion = RegionEndpoint.USWest2;
                client = new AmazonDeviceFarmClient(bucketRegion);
#if DEBUG
                client = new AmazonDeviceFarmClient(AwsAccessKey, AwsSecretKey, bucketRegion);
#endif
                return client;
            }
            catch (Exception ee)
            {
                throw;
            }


        }
        public static GetAccountSettingsResponse GetAccountSettingsResponse()
        {
            try
            {
                
                var response = client.GetAccountSettings(new GetAccountSettingsRequest
                {
                });

                AccountSettings accountSettings = response.AccountSettings;

                var req = new GetDeviceRequest
                {

                };
                var result = client.GetAccountSettings();
                return result;
            }
            catch (Exception ee)
            {
                throw;
            }
        }
        public static List<Project> GetProjectList()
        {
            try
            {

                var response = client.ListProjects(new ListProjectsRequest
                {
                    //Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:7ad300ed-8183-41a7-bf94-12345EXAMPLE",
                    //NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE" // A dynamically generated value, used for paginating results.
                });

                List<Project> projects = response.Projects;
                return projects;
            }
            catch (Exception ee)
            {
                throw;
            }
        }
        public static List<Run> GetRuns(string ProjectId)
        {
            var runs = new List<Run>();
            try
            {
                
                var response = client.ListRuns(new ListRunsRequest
                {
                    Arn = ProjectId,
                    //NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE" // A dynamically generated value, used for paginating results.
                });
                if (response != null)
                {
                    runs = response.Runs;
                }
                return runs;
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        //public static Run CreateRun(string ProjectId)
        //{
        //    var runs = new List<Run>();
        //    try
        //    {

        //        var response = client.CreateUpload(new CreateUploadRequest
        //        {
                    
        //            Name = "MyAppiumPythonUpload",
        //            Type = "APPIUM_PYTHON_TEST_PACKAGE",
        //            ProjectArn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456" // You can get the project ARN by using the list-projects CLI command.
        //        });

        //        Upload upload = response.Upload;


        //        if (response != null)
        //        {
        //            runs = response.Runs;
        //        }
        //        return runs;
        //    }
        //    catch (Exception ee)
        //    {
        //        throw;
        //    }
        //}
        public static List<Device> GetDevices(string ProjectId)
        {
            var devices = new List<Device>();
            try
            {

                var response = client.ListDevices(new ListDevicesRequest
                {
                    Arn = ProjectId,
                    //NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE" // A dynamically generated value, used for paginating results.
                });
                if (response != null)
                {
                    devices = response.Devices;
                }
                return devices;
            }
            catch (Exception ee)
            {
                throw;
            }
        }
        public static List<Device> GetDevices( )
        {
            List<Device> devices = new List<Device>();           
            var response = client.ListDevices(new ListDevicesRequest { });
            if (response != null)
            {
                devices = response.Devices;
            }
            return devices;
        }

        public static Project CreateProject(string Name)
        {
            try
            {
                var response = client.CreateProject(new CreateProjectRequest
                {
                    Name = Name // A project in Device Farm is a workspace that contains test runs. A run is a test of a single app against one or more devices.
                });

                Project project = response.Project;
                return project;
            }
            catch(Exception ee)
            {
                return null;
            }
        }
    }
}
