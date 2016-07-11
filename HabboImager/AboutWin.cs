using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arav_Imager
{
    public partial class AboutWin : Form
    {
        internal static AboutWin objAbout = new AboutWin();

        public AboutWin()
        {
            InitializeComponent();
        }

        private void AboutWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void j9eikf9wkogk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://darkbox.nl");
            MessageBox.Show("Darkbox.nl has been opened in your browser.", "Arav Imager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
