using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2MM.Core
{
    class ModHelper
    {

        public ModHelper()
        {

        }

        public bool IsInstalled(string tfPath, string modPath)
        {
            CheckRequest(tfPath, modPath);

            return File.Exists(FileSystem.GetCustomDir(tfPath) + @"\" + Path.GetFileName(modPath));
        }

        public void InstallMod(string tfPath, string modPath)
        {
            CheckRequest(tfPath, modPath);

            File.Copy(modPath, FileSystem.GetCustomDir(tfPath) + @"\" + Path.GetFileNameWithoutExtension(modPath) + ".vpk");
        }

        public void UpdateMod(string tfPath, string modPath)
        {
            CheckRequest(tfPath, modPath);

            string installPath = FileSystem.GetCustomDir(tfPath) + @"\" + Path.GetFileName(modPath);
            if (!File.Exists(installPath)) { return; }

            File.Copy(installPath, FileSystem.GetBackupDir(tfPath) + @"\" + Path.GetFileName(modPath), true);
            File.Copy(modPath, FileSystem.GetCustomDir(tfPath) + @"\" + Path.GetFileName(modPath), true);
        }

        public void DeleteMod(ModFile mod, bool deleteCache = true)
        {
            File.Delete(mod.Path);
            if (!deleteCache) { return; }

            string cachePath = FileSystem.GetCustomDir(mod.TFDir) + @"\" + Path.GetFileName(mod.Path) + ".sound.cache";
            if (File.Exists(cachePath)) {
                File.Delete(cachePath);
            }
        }

        public bool BackupMod(ModFile mod)
        {
            File.Copy(FileSystem.GetCustomDir(mod.TFDir) + @"\" + Path.GetFileName(mod.Path), FileSystem.GetBackupDir(mod.TFDir) + @"\" + Path.GetFileName(mod.Path), true);

            return true;
        }

        public bool SetActive(ModFile mod, bool state)
        {
            if (state)
            {
                // Enable Mod
                string modPath = FileSystem.GetDisabledDir(mod.TFDir) + @"\" + Path.GetFileName(mod.Path);
                if (File.Exists(modPath))
                {
                    string newPath = FileSystem.GetCustomDir(mod.TFDir) + @"\" + Path.GetFileName(mod.Path);
                    File.Move(modPath, newPath);
                    mod.Path = newPath;
                }

                mod.Active = true;
            } else
            {
                // Disable Mod
                string modPath = FileSystem.GetCustomDir(mod.TFDir) + @"\" + Path.GetFileName(mod.Path);
                if (File.Exists(modPath))
                {
                    string newPath = FileSystem.GetDisabledDir(mod.TFDir) + @"\" + Path.GetFileName(mod.Path);
                    File.Move(modPath, newPath);
                    mod.Path = newPath;
                }

                mod.Active = false;
            }

            return true;
        }

        private void CheckRequest(string tfPath, string modPath)
        {
            if (!Directory.Exists(tfPath))
            {
                throw new Exception("Invalid TF2 Path");
            }
            if (!File.Exists(modPath))
            {
                throw new Exception("Invalid Mod Path");
            }
        }

        private void CheckRequest(ModFile mod)
        {
            if (!Directory.Exists(mod.TFDir))
            {
                throw new Exception("Invalid TF2 Path");
            }
            if (!File.Exists(mod.Path))
            {
                throw new Exception("Invalid Mod Path");
            }
        }

    }
}
