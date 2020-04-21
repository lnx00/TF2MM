using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF2MM.Core;

namespace TF2MM
{
    static class Utils
    {

        public static List<ModFile> GetModList(string tfDir)
        {
            List<ModFile> modList = new List<ModFile>();
            string[] enabledFiles = Directory.GetFiles(FileSystem.GetCustomDir(tfDir), "*.vpk");
            string[] disabledFiles = Directory.GetFiles(FileSystem.GetDisabledDir(tfDir), "*.vpk");

            foreach (string file in enabledFiles)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                string modName = fileName;

                modName = modName.Replace('_', ' ');
                modName = modName.Replace('-', ' ');
                modName = modName.Replace(".vpk", "");
                modName = modName.Trim();

                ModFile mod = new ModFile(modName, file, tfDir, true);
                modList.Add(mod);
            }

            foreach (string file in disabledFiles)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                string modName = fileName;

                modName = modName.Replace('_', ' ');
                modName = modName.Replace('-', ' ');
                modName = modName.Replace(".vpk", "");
                modName = modName.Trim();

                ModFile mod = new ModFile(modName, file, tfDir, false);
                modList.Add(mod);
            }

            return modList;
        }

    }
}
