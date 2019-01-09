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
    public partial class MainForm : Form
    {
        private List<Label> deps = new List<Label>();
        private List<ToolTip> toolTips = new List<ToolTip>();
        private List<string> texts = new List<string>();
        private List<string> names = new List<string>();
        int dnum = 0;
        private bool admin = true;
        public MainForm(Boolean isAdmin)
        {
            InitializeComponent();
            admin = isAdmin;
            if (isAdmin)
            {
                label1.Visible = true;
            }
            string path = Properties.Settings.Default.dir + @"EB\Deposits.txt";
            string text1 = "";
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        dnum++;
                        switch (dnum%6)
                        {
                            case 1:
                                names.Add(line.Replace('_', ' '));
                                break;
                            case 2:
                                text1 = "Процентная ставка: " + line + "%\n";
                                break;
                            case 3:
                                if (line == "g")
                                {
                                    text1 = text1 + "Процент начисляется каждый ГОД\n";
                                }
                                else
                                {
                                    text1 = text1 + "Процент начисляется каждый МЕСЯЦ\n";
                                }
                                break;
                            case 4:
                                text1 = text1+"Минимальный срок вклада: " + line + " дней\n";
                                break;
                            case 5:
                                text1 = text1 + "Минимальная сумма: " + line + " рублей\n";
                                break;
                            case 0:
                                text1 = text1 + "Максимальная сумма: " + line + " рублей\n";
                                texts.Add(text1);
                                break;

                        }
                    }
                    for(int i = 0; i < dnum / 6; i++)
                    {
                        toolTips.Add(new ToolTip());
                        deps.Add(new Label());
                        deps[i].BackColor = System.Drawing.Color.Transparent;
                        deps[i].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        deps[i].Font = new Font("Comic Sans MS", 18);
                        deps[i].Location = new Point(3, 10 + 112 * i);
                        deps[i].AutoSize = false;
                        deps[i].Size = new System.Drawing.Size(297, 91);
                        deps[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        deps[i].Text = names[i];
                        deps[i].Click += Deposit_Click;
                        toolTips[i].SetToolTip(deps[i], texts[i]);
                        panel1.Controls.Add(deps[i]);
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void labelShowInvestors_Click(object sender, EventArgs e)
        {
            InvestsForm investsForm = new InvestsForm(admin);
            investsForm.Show();
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count < 3)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(admin);
            adminForm.Show();
            this.Close();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dnum / 6; i++)
            {
                if (sender.Equals(deps[i]))
                {
                    FormAdd formAdd = new FormAdd(i, admin);
                    formAdd.Show();
                    this.Close();
                }
            }
        }

        private void labelHelp_Click(object sender, EventArgs e)
        {
            Spravka spravka = new Spravka();
            spravka.Show();
        }
    }
}
