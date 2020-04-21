using SharpCompress.Archives.Rar;
using SharpCompress.Common;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2MM.Core
{
    public enum FileType
    {
        VPK, ARCHIVE
    }

    class Installer
    {

        public Installer()
        {

        }

        public void InstallFile(string tfDir, FileType type, string filePath)
        {
            ModHelper modHelper = new ModHelper();
            switch (type)
            {
                case FileType.VPK:
                    modHelper.InstallMod(tfDir, filePath);
                    break;

                case FileType.ARCHIVE:
                    string modFile = AutoDecompress(tfDir, filePath);
                    modHelper.InstallMod(tfDir, modFile);
                    break;

                default:
                    throw new NotImplementedException("File Type missing");
            }

            CleanUp(tfDir);
        }

        public string AutoDecompress(string tfDir, string filePath)
        {
            if (!File.Exists(filePath)) { throw new Exception("Temporary file not found"); }

            using (Stream stream = File.OpenRead(filePath))
            using (var reader = ReaderFactory.Open(stream))
            {
                while (reader.MoveToNextEntry())
                {
                    Console.WriteLine(reader.Entry.Key);
                    reader.WriteEntryToDirectory(FileSystem.GetTempDir(tfDir) + @"\decompressed\", new ExtractionOptions()
                    {
                        ExtractFullPath = true,
                        Overwrite = true
                    });
                }
            }

            string modFile = FindModFile(FileSystem.GetTempDir(tfDir) + @"\decompressed\");
            return modFile;
        }

        public string FindModFile(string searchDir)
        {
            if (!Directory.Exists(searchDir)) { throw new Exception("Decompressed file not found"); }
            string[] files = Directory.GetFiles(searchDir, "*.vpk", SearchOption.AllDirectories);
            return files.First();
        }

        public void CleanUp(string tfDir)
        {
            Directory.Delete(FileSystem.GetTempDir(tfDir), true);
        }

    }
}
