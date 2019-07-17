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

        public static string AwsAccessKey = "AKIAI3JSPTK2NTZ7CNHA";
        ////{
        ////    get
        ////    {
        ////        return Convert.ToString(ConfigurationManager.AppSettings["awsAccessKey"]);
        ////    }
        ////}

        public static string AwsSecretKey = "YKnmgTvduMq3Fvx7k0nm6d2X+za+x9ZlTEoN6yFS";
        //{
        //    get
        //    {
        //        return Convert.ToString(ConfigurationManager.AppSettings["awsSecretKey"]);
        //    }
        //}


        //public static string BucketName
        //{
        //    get
        //    {
        //        return Convert.ToString(ConfigurationManager.AppSettings["bucketName"]);
        //    }
        //}
        private static AmazonS3Client GetAmazonS3Client()
        {
            var bucketRegion = RegionEndpoint.USWest1;
            var s3Client = new AmazonS3Client(bucketRegion);
#if DEBUG
            s3Client = new AmazonS3Client(AwsAccessKey, AwsSecretKey, bucketRegion);
#endif

            return s3Client;
        }
        private static AmazonDeviceFarmClient GetAmazonDeviceFarmClient()
        {
            try
            {
                var bucketRegion = RegionEndpoint.USWest2;
                var deviceclient = new AmazonDeviceFarmClient(bucketRegion);
#if DEBUG
                deviceclient = new AmazonDeviceFarmClient(AwsAccessKey, AwsSecretKey, bucketRegion);
#endif
                return deviceclient;
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
                var client = GetAmazonDeviceFarmClient();
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
                var client = GetAmazonDeviceFarmClient();
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
                var client = GetAmazonDeviceFarmClient();
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
        public static List<Device> GetDevices()
        {
            List<Device> devices = new List<Device>();
            var client = GetAmazonDeviceFarmClient();
            var response = client.ListDevices(new ListDevicesRequest { });
            if (response != null)
            {
                devices = response.Devices;
            }
            return devices;
        }
    }
}
