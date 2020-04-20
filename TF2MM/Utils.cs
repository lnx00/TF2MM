using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2MM
{
    class Utils
    {

        public List<ModFile> GetModList(string dir)
        {
            List<ModFile> modList = new List<ModFile>();
            string[] files = Directory.GetFiles(dir, "*.vpk*");

            foreach (string file in files)
            {
                string ext = Path.GetExtension(file);
                string fileName = Path.GetFileNameWithoutExtension(file);

                string modName = fileName;
                bool modActive = false;

                if (ext == ".vpk") { modActive = true; } else if (ext == ".disabled") { modActive = false; } else { continue; }
                modName = modName.Replace('_', ' ');
                modName = modName.Replace('-', ' ');
                modName = modName.Replace(".vpk", "");
                modName = modName.Trim();

                ModFile mod = new ModFile(modName, file, modActive);
                modList.Add(mod);
            }

            return modList;
        }

        public bool ToggleMod(ModFile mod, bool state)
        {
            bool preActive = mod.Active;

            try
            {
                if (state)
                {
                    if (mod.File.EndsWith(".disabled"))
                    {
                        string modFile = mod.File.Replace(".disabled", "");
                        File.Move(mod.File, modFile);
                        mod.File = modFile;
                    }

                    mod.Active = true;
                }
                else
                {
                    if (mod.File.EndsWith(".vpk"))
                    {
                        string modFile = mod.File + ".disabled";
                        File.Move(mod.File, modFile);
                        mod.File = modFile;
                    }

                    mod.Active = false;
                }

                return true;
            } catch (Exception)
            {
                mod.Active = preActive;
                return false;
            }
        }

        public bool IsGameDir(string dir)
        {
            if (!Directory.Exists(dir)) { return false; }
            if (!Directory.Exists(dir + @"\tf\")) { return false; }
            if (!Directory.Exists(dir + @"\tf\custom")) { return false; }

            return true;
        }

        public string GetCustomDir(string tfDir)
        {
            string customDir = "";
            if (Directory.Exists(tfDir + @"\tf\custom")) { customDir = tfDir + @"\tf\custom"; }
            return customDir;
        }

        public string GetTempDir(string tfDir)
        {
            Directory.CreateDirectory(tfDir + @"\tf\custom_temp");
            return tfDir + @"\tf\custom_temp";
        }

    }
}
