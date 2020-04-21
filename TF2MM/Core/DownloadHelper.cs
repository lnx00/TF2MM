using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TF2MM.Core
{
    class DownloadHelper
    {

        public DownloadHelper()
        {

        }

        public bool DownloadFile(string tfDir, string url)
        {
            Uri downloadUri = new Uri(url);
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(url, FileSystem.GetTempDir(tfDir) + @"\file.dat");
            }

            return true;
        }

        private bool IsGamebanana()
        {
            return false;
        }

    }
}
