using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace TF2MM
{
    public partial class InputDialog : MaterialForm
    {
        public string InputText { get; set; }

        public InputDialog(string msg, string title, string text = "")
        {
            InitializeComponent();

            this.Text = title;
            this.lblMessage.Text = msg;
            this.txtInput.Text = text;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.InputText = txtInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
