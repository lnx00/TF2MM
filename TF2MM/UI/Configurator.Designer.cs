namespace TF2MM
{
    partial class Configurator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurator));
            this.lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.lblSelectPls = new MaterialSkin.Controls.MaterialLabel();
            this.txtFolderPath = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBrowse = new MaterialSkin.Controls.MaterialButton();
            this.btnContinue = new MaterialSkin.Controls.MaterialButton();
            this.tfBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox6 = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblWelcome.Location = new System.Drawing.Point(151, 80);
            this.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(197, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "TF2MM Configuration";
            // 
            // lblSelectPls
            // 
            this.lblSelectPls.AutoSize = true;
            this.lblSelectPls.Depth = 0;
            this.lblSelectPls.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSelectPls.Location = new System.Drawing.Point(14, 121);
            this.lblSelectPls.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelectPls.Name = "lblSelectPls";
            this.lblSelectPls.Size = new System.Drawing.Size(283, 19);
            this.lblSelectPls.TabIndex = 1;
            this.lblSelectPls.Text = "Please select your Team Fortress folder:";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFolderPath.Depth = 0;
            this.txtFolderPath.DetectUrls = false;
            this.txtFolderPath.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtFolderPath.Hint = "Select a folder...";
            this.txtFolderPath.Location = new System.Drawing.Point(17, 143);
            this.txtFolderPath.MaxLength = 50;
            this.txtFolderPath.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFolderPath.Multiline = false;
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(369, 50);
            this.txtFolderPath.TabIndex = 2;
            this.txtFolderPath.TabStop = false;
            this.txtFolderPath.Text = "";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Depth = 0;
            this.btnBrowse.DrawShadows = true;
            this.btnBrowse.HighEmphasis = true;
            this.btnBrowse.Icon = null;
            this.btnBrowse.Location = new System.Drawing.Point(393, 150);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(92, 36);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowse.UseAccentColor = false;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.AutoSize = false;
            this.btnContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContinue.Depth = 0;
            this.btnContinue.DrawShadows = true;
            this.btnContinue.HighEmphasis = true;
            this.btnContinue.Icon = null;
            this.btnContinue.Location = new System.Drawing.Point(17, 204);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnContinue.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(468, 37);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Save";
            this.btnContinue.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnContinue.UseAccentColor = false;
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // tfBrowser
            // 
            this.tfBrowser.Description = "Select your TF2 folder...";
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
            this.materialCheckbox1.Text = "tst 123";
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
            // Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 256);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.lblSelectPls);
            this.Controls.Add(this.lblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Configurator";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TF2 Mod Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configurator_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblWelcome;
        private MaterialSkin.Controls.MaterialLabel lblSelectPls;
        private MaterialSkin.Controls.MaterialTextBox txtFolderPath;
        private MaterialSkin.Controls.MaterialButton btnBrowse;
        private MaterialSkin.Controls.MaterialButton btnContinue;
        private System.Windows.Forms.FolderBrowserDialog tfBrowser;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox5;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox6;
    }
}

