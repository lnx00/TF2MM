using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TF2MM.Core
{
    class DownloadHelper
    {

        public DownloadHelper()
        {
            
        }

        public async Task DownloadFile(string tfDir, string url)
        {
            Uri downloadUri = new Uri(url);
            using (WebClient client = new WebClient())
            {
                File.Delete(FileSystem.GetTempDir(tfDir) + @"\tempFile.dat");

                client.DownloadFileCompleted += ModDownloadCompleted;
                client.QueryString.Add("url", downloadUri.AbsoluteUri);
                client.QueryString.Add("tfDir", tfDir);
                await client.DownloadFileTaskAsync(downloadUri, FileSystem.GetTempDir(tfDir) + @"\tempFile.dat");
            }
        }

        private async void ModDownloadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            WebClient client = sender as WebClient;
            if (client == null) { return; }
            Uri dlUri = new Uri(client.QueryString["url"]);
            string tfDir = client.QueryString["tfDir"];
            string modPath = FileSystem.GetTempDir(tfDir) + @"\tempFile.dat";

            string fileType = await GetFileType(dlUri);
            Installer modInstaller = new Installer();
            switch (fileType)
            {
                case "application/x-rar-compressed":
                case "application/rar":
                case "application/x-7z-compressed":
                case "application/x-zip-compressed":
                case "application/zip":
                    modInstaller.InstallFile(tfDir, FileType.ARCHIVE, modPath);
                    break;

                case "application/octet-stream":
                    modInstaller.InstallFile(tfDir, FileType.VPK, modPath);
                    break;

                default:
                    throw new Exception("Unknown file type: " + fileType);
            }
        }

        private async Task<string> GetFileType(Uri pUri)
        {
            HttpClient hClient = new HttpClient();
            HttpResponseMessage response = await hClient.GetAsync(pUri);
            HttpContent res = response.Content;
            string contentType = res.Headers.ContentType.ToString();
            return contentType;
        }

        private bool IsGamebanana()
        {
            return false;
        }

    }
}
