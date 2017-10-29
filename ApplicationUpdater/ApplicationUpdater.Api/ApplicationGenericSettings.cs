using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationUpdater.Api
{
    public class ApplicationGenericSettings
    {
        private string _downloadUrl = string.Empty;
        private string _tempPath = Path.GetTempPath();


        public ApplicationGenericSettings SetUrl(string url)
        {
            _downloadUrl = url;
            return this;
        }

        public ApplicationGenericSettings SetTempPath(string path)
        {
            _tempPath = path;
            return this;
        }
    }

    public class ApplicationUpdater
    {
        private readonly ApplicationGenericSettings _settings;

        public ApplicationUpdater(ApplicationGenericSettings settings)
        {
            _settings = settings;
        }

        public void Start()
        {

        }

        public event DownloadProgressChangedEventHandler DownloadProgressChangeEvent;
    }
}
