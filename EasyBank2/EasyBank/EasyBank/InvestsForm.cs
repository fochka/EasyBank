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
    public partial class InvestsForm : Form
    {
        private List<Label> deposits = new List<Label>();
        private List<ToolTip> toolTips = new List<ToolTip>();
        private List<string> texts = new List<string>();
        private int numDep = 0;
        bool admin = false;
        public InvestsForm(bool isAdmin)
        {
            InitializeComponent();
            this.panel1.Focus();
            admin = isAdmin;
            //Создание списка вкладчиков
            string path = Properties.Settings.Default.dir + @"EB\Clients\DepositFile.txt";
            string path2 = Properties.Settings.Default.dir + @"EB\Clients\";
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        deposits.Add(new Label());
                        deposits[numDep].Click += ClickEvent;
                        deposits[numDep].Location = new Point(16, 10 + numDep * 24);
                        deposits[numDep].Font = new Font(deposits[numDep].Font.Name, 14, deposits[numDep].Font.Style);
                        deposits[numDep].Size = new Size(300, 24);
                        deposits[numDep].Text = line.Replace('_', ' ');
                        panel1.Controls.Add(deposits[numDep]);
                        numDep++;
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            //Формирование подсказок
            using (StreamReader sr1 = new StreamReader(path, System.Text.Encoding.Default))
            {
                string l = "Эрик_Картман";
                string str;
                int day;
                int month;
                int year;
                int sum;
                double perc;
                numDep = 0;
                while ((l = sr1.ReadLine()) != null)
                {
                    try
                    {
                        using (StreamReader sr2 = new StreamReader(path2 + l + ".txt", System.Text.Encoding.Default))
                        {
                            str = sr2.ReadLine();
                            str = sr2.ReadLine();
                            day = Convert.ToInt32(str.Substring(0, 2));
                            month = Convert.ToInt32(str.Substring(3, 2));
                            year = Convert.ToInt32(str.Substring(6, 4));
                            sum = Convert.ToInt32(sr2.ReadLine());
                            perc = Convert.ToDouble(sr2.ReadLine());
                            str = sr2.ReadLine();
                            sr2.Close();
                        }
                        month = (DateTime.Today.Year - year) * 12 + DateTime.Today.Month - month;
                        if (DateTime.Today.Day < day)
                        {
                            month--;
                        }
                        Calculate c1 = new Calculate();
                        if (str == "m")
                        {
                            texts.Add(Convert.ToString(c1.Calc(sum, month, perc, true)));
                        }
                        else
                        {
                            texts.Add(Convert.ToString(c1.Calc(sum, month, perc, false)));
                        }
                        toolTips.Add(new ToolTip());
                        toolTips[numDep].AutoPopDelay = 5000;
                        toolTips[numDep].InitialDelay = 100;
                        toolTips[numDep].ReshowDelay = 10;
                        toolTips[numDep].SetToolTip(this.deposits[numDep],"На счету: "+ c1.Readable(texts[numDep])+"руб.");
                        toolTips[numDep].ShowAlways = true;
                        ToolTip toolTip1 = new ToolTip();
                        numDep++;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                sr1.Close();
            }
   
        }
        //Выбор вкладчика(нажатие)
        private void ClickEvent(object sender, EventArgs e)
        {
            for (int i = 0; i < numDep; i++)
            {
                if (sender.Equals(deposits[i]))
                {
                    ChangingForm changingForm = new ChangingForm(deposits[i].Text.Replace(' ', '_'), admin);
                    changingForm.Show();
                    this.Close();
                }
            }
        }

        private void InvestsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count < 3)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(admin);
            mainForm.Show();
            this.Close();
        }

        private void labelHelp_Click(object sender, EventArgs e)
        {
            Spravka spravka = new Spravka();
            spravka.Show();
        }
    }
}
