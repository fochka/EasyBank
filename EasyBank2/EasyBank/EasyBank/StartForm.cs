using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBank
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.ActiveControl = tbDir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@tbDir.Text+@"\EB"))
            {
                Properties.Settings.Default.dir = @tbDir.Text+@"\";
                Properties.Settings.Default.isFirstStart = false;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                labelErr.Text = "В выбранной папке должна содержаться папка EB!";
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                tbDir.Text = FBD.SelectedPath;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cloud.mail.ru/public/3fjk/4XwhnD4Vp");
        }
    }
}
