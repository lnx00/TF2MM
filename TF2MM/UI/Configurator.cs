using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF2MM.Core;

namespace TF2MM
{
    public partial class Configurator : MaterialSkin.Controls.MaterialForm
    {
        bool isReconfig = false;

        public Configurator()
        {
            InitializeComponent();
        }

        public Configurator(string tfDir)
        {
            InitializeComponent();

            txtFolderPath.Text = tfDir;
            isReconfig = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string dir = txtFolderPath.Text;
            if (FileSystem.IsGameDir(dir))
            {
                Properties.Settings.Default.tfPath = dir;
                Properties.Settings.Default.Save();

                this.Close();
            } else
            {
                MessageBox.Show("This directory is no Team Fortress 2 directory!", "Invalid Directory");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (tfBrowser.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = tfBrowser.SelectedPath;
            }
        }

        private void Configurator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FileSystem.IsGameDir(txtFolderPath.Text) && !isReconfig)
            {
                Application.Exit();
            }
        }
    }
}
