using System;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace GoogleApi.Test
{
    // TODO: Implement: New Forward Geocoder FAQ (https://developers.google.com/maps/documentation/geocoding/faq)
    // TODO: Implement: Search response (opensearch spec, Search Request Fields (https://developers.google.com/custom-search/json-api/v1/performance))

    [TestFixture]
    public abstract class BaseTest
    {
        protected virtual string ApiKey { get; set; }
        protected virtual string KeyFile { get; set; } = "keyfile.txt";

        [OneTimeSetUp]
        public virtual void Setup()
        {
            this.ApiKey = this.GetFileInfo(this.KeyFile).ToString();
        }

        protected virtual object GetFileInfo(string filename)
        {
            try
            {
                var directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent?.Parent?.Parent;
                var fileInfo = directoryInfo?.GetFiles().FirstOrDefault(x => x.Name == filename);

                if (fileInfo == null)
                    throw new NullReferenceException("fileinfo");

                using (var streamReader = new StreamReader(fileInfo.FullName))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}