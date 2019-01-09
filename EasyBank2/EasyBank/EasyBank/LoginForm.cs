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
    public partial class LoginForm : Form
    {
        List<string> logins = new List<string>();
        List<string> passwords = new List<string>();
        List<Boolean> isAdmins = new List<Boolean>();
        int wnum = 0;
        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = tbLogin;
            if (Properties.Settings.Default.isFirstStart)//true
            {
                StartForm startForm = new StartForm();
                this.Hide();
                startForm.Show();
            }
        }

        private void btnEntrance_Click(object sender, EventArgs e)
        {
            bool isTrue = true;
            for (int i=0; i<wnum/4; i++) {
                if ((tbLogin.Text == logins[i]) && (tbPassword.Text==passwords[i]))
                {
                    MainForm mainForm = new MainForm(isAdmins[i]);
                    mainForm.Show();
                    Properties.Settings.Default.isFirstStart = false;
                    Properties.Settings.Default.Save();
                    this.Hide();
                    isTrue = false;
                }
            }
            if (isTrue)
            {
                lblTryAgain.Text = "Неверный логин или пароль!";
                tbLogin.Text = "";
                tbPassword.Text = "";
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }
        

        private void tbLogin_Leave(object sender, EventArgs e)
        {
            string path = @Properties.Settings.Default.dir + @"EB\Workers.txt";
            //string path = @"E:\"+@"EB\Workers.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        wnum++;
                        if (wnum % 4 == 2)
                        {
                            logins.Add(line);
                        }
                        else
                        {
                            if (wnum % 4 == 3)
                            {
                                passwords.Add(line);
                            }
                            else
                            {
                                if (wnum % 4 == 0)
                                {
                                    isAdmins.Add(Convert.ToBoolean(line));
                                }
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
        }
    }
}
