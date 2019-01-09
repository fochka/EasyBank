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
    public partial class AdminForm : Form
    {
        private int numName = 0;
        private int numDeps = 0;
        private bool admin = false;
        private List<Label> names = new List<Label>();
        private List<string> logins = new List<string>();
        private List<string> passwords = new List<string>();
        private List<bool> admins = new List<bool>();

        private List<Label> deps = new List<Label>();
        private List<string> perc = new List<string>();
        private List<string> period = new List<string>();
        private List<string> minT = new List<string>();
        private List<string> minSum = new List<string>();
        private List<string> maxSum = new List<string>();


        private int changingMan = 0;
        private int changingDep = 0;
        public AdminForm(bool isAdmin)
        {
            InitializeComponent();
            admin = isAdmin;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(admin);
            mainForm.Show();
            this.Close();
        }

        private void Loading()
        {
            numName = 0;
            numDeps = 0;
            names.Clear();
            logins.Clear();
            passwords.Clear();
            admins.Clear();

            deps.Clear();
            perc.Clear();
            period.Clear();
            minT.Clear();
            minSum.Clear();
            maxSum.Clear();

            //Сотрудники
            string path = Properties.Settings.Default.dir + @"EB\Workers.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        logins.Add(sr.ReadLine());
                        passwords.Add(sr.ReadLine());
                        admins.Add(Convert.ToBoolean(sr.ReadLine()));
                        names.Add(new Label());
                        names[numName].Click += ClickEvent;
                        names[numName].Location = new Point(16, 55 + numName * 24);
                        names[numName].Font = new Font(names[numName].Font.Name, 14, names[numName].Font.Style);
                        names[numName].Size = new Size(300, 24);
                        names[numName].Text = line.Replace('_', ' ');
                        tabPage2.Controls.Add(names[numName]);
                        numName++;
                    }
                    sr.Close();
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }

            //Депозиты
            string path2 = Properties.Settings.Default.dir + @"EB\Deposits.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path2, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        perc.Add(sr.ReadLine());
                        period.Add(sr.ReadLine());
                        minT.Add(sr.ReadLine());
                        minSum.Add(sr.ReadLine());
                        maxSum.Add(sr.ReadLine());
                        deps.Add(new Label());
                        deps[numDeps].Click += ClickEvent2;
                        deps[numDeps].Location = new Point(16, 55 + numDeps * 24);
                        deps[numDeps].Font = new Font(deps[numDeps].Font.Name, 14, deps[numDeps].Font.Style);
                        deps[numDeps].Size = new Size(300, 24);
                        deps[numDeps].Text = line.Replace('_', ' ');
                        tabPage1.Controls.Add(deps[numDeps]);
                        numDeps++;
                    }
                    sr.Close();
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel1.Visible = true;
            panel2.Enabled = false;
            panel2.Visible = false;
            for (int i = 0; i < numName; i++)
            {
                if (sender.Equals(names[i]))
                {
                    changingMan = i;
                    tbFIO.Text = names[i].Text;
                    tbLogin.Text = logins[i];
                    tbPassword.Text = passwords[i];
                    cbAdmin.Checked = admins[i];
                }
            }
        }

        private void ClickEvent2(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel2.Visible = true;
            panel1.Enabled = false;
            panel1.Visible = false;
            for (int i = 0; i < numDeps; i++)
            {
                if (sender.Equals(deps[i]))
                {
                    changingDep = i;
                    tbName.Text = deps[i].Text;
                    tbPerc.Text = perc[i];
                    if (period[i]=="m")
                    {
                        cbMonth.Checked = true;
                        cbYear.Checked = false;
                    }
                    else
                    {
                        cbMonth.Checked = false;
                        cbYear.Checked = true;
                    }
                    tbMinT.Text = minT[i];
                    tbMinSum.Text = minSum[i];
                    tbMaxSum.Text = maxSum[i];
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((tbFIO.Text != "") && (tbLogin.Text != "") && (tbPassword.Text != ""))
            {
                names[changingMan].Text = tbFIO.Text;
                logins[changingMan] = tbLogin.Text;
                passwords[changingMan] = tbPassword.Text;
                admins[changingMan] = cbAdmin.Checked;

                string path = Properties.Settings.Default.dir + @"EB\Workers.txt";
                try
                {
                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                    {
                        for (int i = 0; i < numName; i++)
                        {
                            sw.WriteLine(names[i].Text.Replace(' ', '_'));
                            sw.WriteLine(logins[i].Replace(' ', '_'));
                            sw.WriteLine(passwords[i].Replace(' ', '_'));
                            sw.WriteLine(Convert.ToString(admins[i]));
                        }
                        sw.Close();
                    }
                }
                catch
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            if ((tbName.Text != "") && (tbPerc.Text != "") && (tbMinT.Text != "") && (tbMinSum.Text != "") && (tbMaxSum.Text != ""))
            {
                deps[changingDep].Text = tbName.Text;
                perc[changingDep] = tbPerc.Text;
                if (cbMonth.Checked)
                {
                    period[changingDep] = "m";
                }
                else
                {
                    period[changingDep] = "g";
                }
                minT[changingDep] = tbMinT.Text;
                minSum[changingDep] = tbMinSum.Text;
                maxSum[changingDep] = tbMaxSum.Text;

                string path = Properties.Settings.Default.dir + @"EB\Deposits.txt";
                try
                {
                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                    {
                        for (int i = 0; i < numDeps; i++)
                        {
                            sw.WriteLine(deps[i].Text.Replace(' ', '_'));
                            sw.WriteLine(perc[i].Replace(' ', '_'));
                            sw.WriteLine(period[i].Replace(' ', '_'));
                            sw.WriteLine(minT[i].Replace(' ', '_'));
                            sw.WriteLine(minSum[i].Replace(' ', '_'));
                            sw.WriteLine(maxSum[i].Replace(' ', '_'));
                        }
                        sw.Close();
                    }
                }
                catch
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count < 3)
            {
                Application.Exit();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void tbPerc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void tbMinT_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void tbMinSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void tbMaxSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }


        private void cbMonth_Click(object sender, EventArgs e)
        {
            if (cbMonth.Checked)
            {
                cbYear.Checked = false;
            }
            else
            {
                cbYear.Checked = true;
            }
        }

        private void cbYear_Click(object sender, EventArgs e)
        {
            if (cbYear.Checked)
            {
                cbMonth.Checked = false;
            }
            else
            {
                cbMonth.Checked = true;
            }
        }

        private void btnAddMan_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel1.Visible = true;
            panel2.Enabled = false;
            panel2.Visible = false;
            changingMan = numName;
            logins.Add("");
            passwords.Add("");
            admins.Add(false);
            names.Add(new Label());
            names[numName].Click += ClickEvent;
            names[numName].Location = new Point(16, 55 + numName * 24);
            names[numName].Font = new Font(names[numName].Font.Name, 14, names[numName].Font.Style);
            names[numName].Size = new Size(300, 24);
            names[numName].Text = "";
            tabPage2.Controls.Add(names[numName]);
            numName++;
        }

        private void btnAddDep_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel2.Visible = true;
            panel1.Enabled = false;
            panel1.Visible = false;
            changingDep = numDeps;
            perc.Add("");
            period.Add("");
            minT.Add("");
            minSum.Add("");
            maxSum.Add("");
            deps.Add(new Label());
            deps[numDeps].Click += ClickEvent2;
            deps[numDeps].Location = new Point(16, 55 + numDeps * 24);
            deps[numDeps].Font = new Font(deps[numDeps].Font.Name, 14, deps[numDeps].Font.Style);
            deps[numDeps].Size = new Size(300, 24);
            deps[numDeps].Text = "";
            tabPage1.Controls.Add(deps[numDeps]);
            numDeps++;
        }

        private void buttonRemove2_Click(object sender, EventArgs e)
        {
            tabPage1.Controls.Remove(deps[changingDep]);
            numDeps--;
            tbName.Text = "";
            tbPerc.Text = "";
            tbMinT.Text = "";
            tbMinSum.Text = "";
            tbMaxSum.Text = "";
            deps.RemoveAt(changingDep);
            perc.RemoveAt(changingDep);
            period.RemoveAt(changingDep);
            minT.RemoveAt(changingDep);
            minSum.RemoveAt(changingDep);
            maxSum.RemoveAt(changingDep);

            string path = Properties.Settings.Default.dir + @"EB\Deposits.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < numDeps; i++)
                    {
                        sw.WriteLine(deps[i].Text.Replace(' ', '_'));
                        sw.WriteLine(perc[i].Replace(' ', '_'));
                        sw.WriteLine(period[i].Replace(' ', '_'));
                        sw.WriteLine(minT[i].Replace(' ', '_'));
                        sw.WriteLine(minSum[i].Replace(' ', '_'));
                        sw.WriteLine(maxSum[i].Replace(' ', '_'));
                    }
                    sw.Close();
                }
            }
            catch
            {
                Console.WriteLine(e);
            }
            Loading();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            tabPage2.Controls.Remove(names[changingMan]);
            numName--;
            tbFIO.Text = "";
            tbLogin.Text = "";
            tbPassword.Text = "";
            names.RemoveAt(changingMan);
            logins.RemoveAt(changingMan);
            passwords.RemoveAt(changingMan);
            admins.RemoveAt(changingMan);

            string path = Properties.Settings.Default.dir + @"EB\Workers.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < numName; i++)
                    {
                        sw.WriteLine(names[i].Text.Replace(' ', '_'));
                        sw.WriteLine(logins[i].Replace(' ', '_'));
                        sw.WriteLine(passwords[i].Replace(' ', '_'));
                        sw.WriteLine(Convert.ToString(admins[i]));
                    }
                    sw.Close();
                }
            }
            catch
            {
                Console.WriteLine(e);
            }
            Loading();
        }

        private void labelHelp_Click(object sender, EventArgs e)
        {
            Spravka spravka = new Spravka();
            spravka.Show();
        }
    }
}
