using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TF2MM
{
    public partial class Manager : MaterialForm
    {
        private Utils utils = new Utils();

        public string tfDirectory = "";

        public Manager()
        {
            InitializeComponent();

            CheckConfig();
        }

        private void CheckConfig()
        {
            if (!LoadConfig())
            {
                Configurator config = new Configurator();
                config.ShowDialog();
                LoadConfig();
            }
        }

        private bool LoadConfig()
        {
            string dir = Properties.Settings.Default.tfPath;
            if (!String.IsNullOrEmpty(dir) && Directory.Exists(dir))
            {
                tfDirectory = dir;
            }
            else
            {
                return false;
            }

            return true;
        }

        public void ReloadModlist()
        {
            modList.Items.Clear();
            List<ModFile> mods = utils.GetModList(utils.GetCustomDir(tfDirectory));
            foreach (ModFile mod in mods)
            {
                MaterialCheckbox checkbox = new MaterialCheckbox
                {
                    Text = mod.Name,
                    Checked = mod.Active,
                    Tag = mod,
                    ContextMenuStrip = modContextMenu,
                };
                checkbox.CheckStateChanged += Checkbox_CheckStateChanged;

                modList.Items.Add(checkbox);
            }
        }

        private void Checkbox_CheckStateChanged(object sender, EventArgs e)
        {
            MaterialCheckbox checkbox = sender as MaterialCheckbox;
            if (checkbox == null) { return; }

            ModFile mod = checkbox.Tag as ModFile;
            if (mod == null) { return; }

            if (!utils.ToggleMod(mod, checkbox.Checked))
            {
                MessageBox.Show("The mod couldn't be " + ((checkbox.Checked) ? "enabled" : "disabled") + ". Please close the game first!");
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Configurator config = new Configurator();
            config.ShowDialog();
            LoadConfig();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadModlist();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            if (utils.IsGameDir(tfDirectory))
            {
                ReloadModlist();
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            InstallMod();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem contextItem = sender as ToolStripMenuItem;
            if (contextItem == null) { return; }
            MaterialContextMenuStrip contextMenu = contextItem.Owner as MaterialContextMenuStrip;
            if (contextMenu == null) { return; }
            MaterialCheckbox parentCheckbox = contextMenu.SourceControl as MaterialCheckbox;
            if (parentCheckbox == null) { return; }
            ModFile mod = parentCheckbox.Tag as ModFile;
            if (mod == null) { return; }

            DeleteMod(mod);
        }

        private void InstallMod()
        {
            if (modInstallDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(utils.GetCustomDir(tfDirectory) + @"\" + modInstallDialog.SafeFileName))
                    {
                        if (MessageBox.Show("This mod already exists! Do you want to update it?", "Overwrite Mod", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                        {
                            File.Copy(modInstallDialog.FileName, utils.GetCustomDir(tfDirectory) + @"\" + modInstallDialog.SafeFileName, true);
                            SetStatus("Mod updated");
                            ReloadModlist();
                        }
                    }
                    else
                    {
                        File.Copy(modInstallDialog.FileName, utils.GetCustomDir(tfDirectory) + @"\" + modInstallDialog.SafeFileName);
                        SetStatus("Mod installed");
                        ReloadModlist();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("The mod couln't be installed!", "Installation failed");
                }
            }
        }

        private void DeleteMod(ModFile mod)
        {
            if (MessageBox.Show("Do you really want to delete '" + mod.Name + "'?", "Delete Mod", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                try
                {
                    File.Delete(mod.File);
                    SetStatus("Deleted " + mod.Name);
                    ReloadModlist();
                }
                catch (Exception)
                {
                    MessageBox.Show("The mod couln't be deleted. Please close the game first!");
                }
            }
        }

        private void RenameMod(ModFile mod)
        {
            InputDialog dialog = new InputDialog("Enter the new Name for '" + mod.Name + "':", "Rename Mod");
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                string fileName = dialog.InputText;
                File.Move(mod.File, Path.GetDirectoryName(mod.File) + @"\" + fileName + ((mod.Active) ? ".vpk" : ".vpk.disabled"));
                ReloadModlist();
            }
        }

        public void SetStatus(string status)
        {
            lblStatus.Text = "Status: " + status;
        }

        private void installToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstallMod();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadModlist();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            InputDialog dialog = new InputDialog("Enter the direct URL to the mod:", "Download URL");
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                string url = dialog.InputText;

                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(url, utils.GetTempDir(tfDirectory) + @"\file.dat");
                    }
                } catch (Exception)
                {
                    MessageBox.Show("The mod couldn't be downloaded.", "Download failed");
                }
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(utils.GetCustomDir(tfDirectory));
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem contextItem = sender as ToolStripMenuItem;
            if (contextItem == null) { return; }
            MaterialContextMenuStrip contextMenu = contextItem.Owner as MaterialContextMenuStrip;
            if (contextMenu == null) { return; }
            MaterialCheckbox parentCheckbox = contextMenu.SourceControl as MaterialCheckbox;
            if (parentCheckbox == null) { return; }
            ModFile mod = parentCheckbox.Tag as ModFile;
            if (mod == null) { return; }

            RenameMod(mod);
        }
    }
}
