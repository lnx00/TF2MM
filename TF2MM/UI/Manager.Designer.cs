namespace TF2MM
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.theTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tpManager = new System.Windows.Forms.TabPage();
            this.btnOpenFolder = new MaterialSkin.Controls.MaterialButton();
            this.btnDownload = new MaterialSkin.Controls.MaterialButton();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.btnInstall = new MaterialSkin.Controls.MaterialButton();
            this.btnReload = new MaterialSkin.Controls.MaterialButton();
            this.modList = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.modContextMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpOptions = new System.Windows.Forms.TabPage();
            this.btnConfig = new MaterialSkin.Controls.MaterialButton();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox6 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox7 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox8 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox9 = new MaterialSkin.Controls.MaterialCheckbox();
            this.modInstallDialog = new System.Windows.Forms.OpenFileDialog();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theTabControl.SuspendLayout();
            this.tpManager.SuspendLayout();
            this.modContextMenu.SuspendLayout();
            this.tpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // theTabControl
            // 
            this.theTabControl.Controls.Add(this.tpManager);
            this.theTabControl.Controls.Add(this.tpOptions);
            this.theTabControl.Depth = 0;
            this.theTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theTabControl.Location = new System.Drawing.Point(0, 0);
            this.theTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.theTabControl.Name = "theTabControl";
            this.theTabControl.SelectedIndex = 0;
            this.theTabControl.Size = new System.Drawing.Size(927, 609);
            this.theTabControl.TabIndex = 0;
            // 
            // tpManager
            // 
            this.tpManager.BackColor = System.Drawing.SystemColors.Control;
            this.tpManager.Controls.Add(this.btnOpenFolder);
            this.tpManager.Controls.Add(this.btnDownload);
            this.tpManager.Controls.Add(this.lblStatus);
            this.tpManager.Controls.Add(this.btnInstall);
            this.tpManager.Controls.Add(this.btnReload);
            this.tpManager.Controls.Add(this.modList);
            this.tpManager.Location = new System.Drawing.Point(4, 22);
            this.tpManager.Name = "tpManager";
            this.tpManager.Padding = new System.Windows.Forms.Padding(3);
            this.tpManager.Size = new System.Drawing.Size(919, 583);
            this.tpManager.TabIndex = 0;
            this.tpManager.Text = "Mods";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenFolder.Depth = 0;
            this.btnOpenFolder.DrawShadows = true;
            this.btnOpenFolder.HighEmphasis = false;
            this.btnOpenFolder.Icon = null;
            this.btnOpenFolder.Location = new System.Drawing.Point(708, 9);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(117, 36);
            this.btnOpenFolder.TabIndex = 5;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenFolder.UseAccentColor = false;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownload.Depth = 0;
            this.btnDownload.DrawShadows = true;
            this.btnDownload.HighEmphasis = true;
            this.btnDownload.Icon = null;
            this.btnDownload.Location = new System.Drawing.Point(96, 9);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(102, 36);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDownload.UseAccentColor = false;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblStatus.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblStatus.Location = new System.Drawing.Point(8, 543);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(902, 35);
            this.lblStatus.TabIndex = 3;
            // 
            // btnInstall
            // 
            this.btnInstall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInstall.Depth = 0;
            this.btnInstall.DrawShadows = true;
            this.btnInstall.HighEmphasis = true;
            this.btnInstall.Icon = null;
            this.btnInstall.Location = new System.Drawing.Point(9, 9);
            this.btnInstall.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInstall.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(79, 36);
            this.btnInstall.TabIndex = 2;
            this.btnInstall.Text = "Install";
            this.btnInstall.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInstall.UseAccentColor = false;
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReload.Depth = 0;
            this.btnReload.DrawShadows = true;
            this.btnReload.HighEmphasis = false;
            this.btnReload.Icon = null;
            this.btnReload.Location = new System.Drawing.Point(833, 9);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(77, 36);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReload.UseAccentColor = false;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // modList
            // 
            this.modList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modList.AutoScroll = true;
            this.modList.BackColor = System.Drawing.SystemColors.Control;
            this.modList.ContextMenuStrip = this.modContextMenu;
            this.modList.Depth = 0;
            this.modList.Location = new System.Drawing.Point(8, 54);
            this.modList.MouseState = MaterialSkin.MouseState.HOVER;
            this.modList.Name = "modList";
            this.modList.Size = new System.Drawing.Size(903, 483);
            this.modList.Striped = false;
            this.modList.StripeDarkColor = System.Drawing.Color.Empty;
            this.modList.TabIndex = 0;
            // 
            // modContextMenu
            // 
            this.modContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.modContextMenu.Depth = 0;
            this.modContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.installToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.modContextMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.modContextMenu.Name = "modContextMenu";
            this.modContextMenu.Size = new System.Drawing.Size(181, 142);
            // 
            // installToolStripMenuItem
            // 
            this.installToolStripMenuItem.Name = "installToolStripMenuItem";
            this.installToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.installToolStripMenuItem.Text = "Install...";
            this.installToolStripMenuItem.Click += new System.EventHandler(this.installToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renameToolStripMenuItem.Text = "Rename...";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // tpOptions
            // 
            this.tpOptions.BackColor = System.Drawing.SystemColors.Control;
            this.tpOptions.Controls.Add(this.btnConfig);
            this.tpOptions.Location = new System.Drawing.Point(4, 22);
            this.tpOptions.Name = "tpOptions";
            this.tpOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tpOptions.Size = new System.Drawing.Size(919, 583);
            this.tpOptions.TabIndex = 1;
            this.tpOptions.Text = "Options";
            // 
            // btnConfig
            // 
            this.btnConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfig.Depth = 0;
            this.btnConfig.DrawShadows = true;
            this.btnConfig.HighEmphasis = true;
            this.btnConfig.Icon = null;
            this.btnConfig.Location = new System.Drawing.Point(9, 9);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(173, 36);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.Text = "Open Configurator";
            this.btnConfig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfig.UseAccentColor = false;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "This is a Mod";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox3.TabIndex = 0;
            this.materialCheckbox3.Text = "materialCheckbox3";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox4.TabIndex = 0;
            this.materialCheckbox4.Text = "materialCheckbox4";
            this.materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox5
            // 
            this.materialCheckbox5.Depth = 0;
            this.materialCheckbox5.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox5.Name = "materialCheckbox5";
            this.materialCheckbox5.Ripple = true;
            this.materialCheckbox5.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox5.TabIndex = 0;
            this.materialCheckbox5.Text = "materialCheckbox5";
            this.materialCheckbox5.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox6
            // 
            this.materialCheckbox6.Depth = 0;
            this.materialCheckbox6.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox6.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox6.Name = "materialCheckbox6";
            this.materialCheckbox6.Ripple = true;
            this.materialCheckbox6.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox6.TabIndex = 0;
            this.materialCheckbox6.Text = "materialCheckbox6";
            this.materialCheckbox6.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox7
            // 
            this.materialCheckbox7.Depth = 0;
            this.materialCheckbox7.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox7.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox7.Name = "materialCheckbox7";
            this.materialCheckbox7.Ripple = true;
            this.materialCheckbox7.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox7.TabIndex = 0;
            this.materialCheckbox7.Text = "materialCheckbox7";
            this.materialCheckbox7.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox8
            // 
            this.materialCheckbox8.Depth = 0;
            this.materialCheckbox8.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox8.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox8.Name = "materialCheckbox8";
            this.materialCheckbox8.Ripple = true;
            this.materialCheckbox8.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox8.TabIndex = 0;
            this.materialCheckbox8.Text = "materialCheckbox8";
            this.materialCheckbox8.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox9
            // 
            this.materialCheckbox9.Depth = 0;
            this.materialCheckbox9.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox9.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox9.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox9.Name = "materialCheckbox9";
            this.materialCheckbox9.Ripple = true;
            this.materialCheckbox9.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox9.TabIndex = 0;
            this.materialCheckbox9.Text = "materialCheckbox9";
            this.materialCheckbox9.UseVisualStyleBackColor = true;
            // 
            // modInstallDialog
            // 
            this.modInstallDialog.FileName = "file.vpk";
            this.modInstallDialog.Filter = "VPK-Files|*.vpk|Archive|*.zip;*.rar;*.7z";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 609);
            this.Controls.Add(this.theTabControl);
            this.DrawerTabControl = this.theTabControl;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TF2 Mod Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.theTabControl.ResumeLayout(false);
            this.tpManager.ResumeLayout(false);
            this.tpManager.PerformLayout();
            this.modContextMenu.ResumeLayout(false);
            this.tpOptions.ResumeLayout(false);
            this.tpOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl theTabControl;
        private System.Windows.Forms.TabPage tpManager;
        private System.Windows.Forms.TabPage tpOptions;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialButton btnConfig;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox5;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox6;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox7;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox8;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox9;
        private MaterialSkin.Controls.MaterialCheckedListBox modList;
        private MaterialSkin.Controls.MaterialButton btnReload;
        private MaterialSkin.Controls.MaterialButton btnInstall;
        private MaterialSkin.Controls.MaterialContextMenuStrip modContextMenu;
        private System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog modInstallDialog;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialButton btnDownload;
        private MaterialSkin.Controls.MaterialButton btnOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}