using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TF2MM.Core
{
    static class FileSystem
    {

        public static bool IsGameDir(string dir)
        {
            if (!Directory.Exists(dir)) { return false; }
            if (!Directory.Exists(dir + @"\tf\")) { return false; }

            return true;
        }

        public static string GetCustomDir(string tfDir)
        {
            string customDir = tfDir + @"\tf\custom";
            Directory.CreateDirectory(customDir);
            return customDir;
        }

        public static string GetDisabledDir(string tfDir)
        {
            string disabledDir = tfDir + @"\tf\custom_disabled";
            Directory.CreateDirectory(disabledDir);
            return disabledDir;
        }

        public static string GetTempDir(string tfDir)
        {
            string tempDir = tfDir + @"\tf\custom_temp";
            Directory.CreateDirectory(tempDir);
            return tempDir;
        }

        public static string GetBackupDir(string tfDir)
        {
            string backupDir = tfDir + @"\tf\custom_backup";
            Directory.CreateDirectory(backupDir);
            return backupDir;
        }

    }
}
