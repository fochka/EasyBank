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
    public partial class ChangingForm : Form
    {
        private bool admin = false;
        private string way;
        private string str;
        private int day;
        private int month;
        private int year;
        private int sum;
        private int minT;
        private int numDays;
        private double perc;
        public ChangingForm(string text, bool isAdmin)
        {
            InitializeComponent();
            admin = isAdmin;
            way = Properties.Settings.Default.dir + @"EB\Clients\" + text + ".txt";
            try
            {
                using (StreamReader sr = new StreamReader(way, System.Text.Encoding.Default))
                {
                    labelSetInfo1.Text = sr.ReadLine().Replace('_',' ');
                    str = sr.ReadLine();
                    day = Convert.ToInt32(str.Substring(0, 2));
                    month = Convert.ToInt32(str.Substring(3, 2));
                    year = Convert.ToInt32(str.Substring(6, 4));
                    sum = Convert.ToInt32(sr.ReadLine());
                    perc = Convert.ToDouble(sr.ReadLine());
                    str = sr.ReadLine();
                    minT = Convert.ToInt32(sr.ReadLine());
                    DateTime now = new DateTime(year, month, day);
                    numDays = DateTime.Today.Subtract(now).Days;
                    sr.Close();
                }
                month = (DateTime.Today.Year - year) * 12 + DateTime.Today.Month - month;
                if (DateTime.Today.Day < day)
                {
                    month--;
                }
                Calculate c1 = new Calculate();

                if (str == "m")
                {
                    labelSetInfo3.Text = c1.Readable(Convert.ToString(c1.Calc(sum, month, perc, true)));
                }
                else
                {
                    labelSetInfo3.Text = c1.Readable(Convert.ToString(c1.Calc(sum, month, perc, false)));
                }
                if (str == "m")
                {
                    labelSetInfo2.Text = "Сумма увелиивается на " + Convert.ToString(perc) + "% \nкаждое " + Convert.ToString(day) + "-ое число месяца";
                }
                else
                {
                    labelSetInfo2.Text = "Сумма увелиивается на " + Convert.ToString(perc) + "% \nкаждый год ( " + Convert.ToString(day) + "." + Convert.ToString(month) + ")";
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }

        }

        private void ChangingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Application.OpenForms.Count < 3)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InvestsForm investsForm = new InvestsForm(admin);
            investsForm.Show();
            this.Close();
        }

        private void tbVvod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void tbVyvod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
               e.Handled = true;
            }
        }

        private void btnVvod_Click(object sender, EventArgs e)
        {
            //ввод
            if (numDays >= minT)
            {
                numDays = 0;
                string[] txt = new string[6];
                Calculate c2 = new Calculate();
                try
                {
                    using (StreamReader sr = new StreamReader(way, System.Text.Encoding.Default))
                    {
                        txt[0] = sr.ReadLine();
                        sr.ReadLine();
                        if (DateTime.Today.Day < 11)
                        {
                            txt[1] = "0" + Convert.ToString(DateTime.Today.ToShortDateString());
                        }
                        else
                        {
                            txt[1] = Convert.ToString(DateTime.Today.ToShortDateString());
                        }
                        sr.ReadLine();
                        if (str == "m")
                        {
                            txt[2] = Convert.ToString(c2.Calc(sum, month, perc, true) + Convert.ToInt32(tbVvod.Text));
                        }
                        else
                        {
                            txt[2] = Convert.ToString(c2.Calc(sum, month, perc, false) + Convert.ToInt32(tbVvod.Text));
                        }
                        txt[3] = sr.ReadLine();
                        txt[4] = sr.ReadLine();
                        txt[5] = sr.ReadLine();
                        sr.Close();
                    }
                    using (StreamWriter writer = new StreamWriter(way, false, System.Text.Encoding.Default))
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            writer.WriteLine(txt[i]);
                        }
                        writer.Close();
                    }
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                }

                try
                {
                    using (StreamReader sr3 = new StreamReader(way, System.Text.Encoding.Default))
                    {
                        sr3.ReadLine();
                        sr3.ReadLine();
                        labelSetInfo3.Text = sr3.ReadLine();
                        sr3.Close();
                    }
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                }
            }
            else
            {
                labelErr1.Text = "Вклад еще не доступен для изменения!";
            }

            try
            {
                using (StreamReader sr = new StreamReader(way, System.Text.Encoding.Default))
                {
                    sr.ReadLine();
                    str = sr.ReadLine();
                    day = Convert.ToInt32(str.Substring(0, 2));
                    month = Convert.ToInt32(str.Substring(3, 2));
                    year = Convert.ToInt32(str.Substring(6, 4));
                    sum = Convert.ToInt32(sr.ReadLine());
                    perc = Convert.ToDouble(sr.ReadLine());
                    str = sr.ReadLine();
                    minT = Convert.ToInt32(sr.ReadLine());
                    DateTime now = new DateTime(year, month, day);
                    numDays = DateTime.Today.Subtract(now).Days;
                    sr.Close();
                }
                month = (DateTime.Today.Year - year) * 12 + DateTime.Today.Month - month;
                if (DateTime.Today.Day < day)
                {
                    month--;
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }
        
        private void btnVyvod_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbVyvod.Text) <= sum)
            {
                if (numDays >= minT)
                {
                        numDays = 0;
                        //вывод
                        string[] txt = new string[6];
                        Calculate c2 = new Calculate();
                        try
                        {
                            using (StreamReader sr = new StreamReader(way, System.Text.Encoding.Default))
                            {
                                txt[0] = sr.ReadLine();
                                sr.ReadLine();
                                if (DateTime.Today.Day < 11)
                                {
                                    txt[1] = "0" + Convert.ToString(DateTime.Today.ToShortDateString());
                                }
                                else
                                {
                                    txt[1] = Convert.ToString(DateTime.Today.ToShortDateString());
                                }
                                sr.ReadLine();
                                if (str == "m")
                                {
                                    txt[2] = Convert.ToString(c2.Calc(sum, month, perc, true) - Convert.ToInt32(tbVyvod.Text));
                                }
                                else
                                {
                                    txt[2] = Convert.ToString(c2.Calc(sum, month, perc, false) - Convert.ToInt32(tbVyvod.Text));
                                }
                                txt[3] = sr.ReadLine();
                                txt[4] = sr.ReadLine();
                                txt[5] = sr.ReadLine();
                                sr.Close();
                            }
                            using (StreamWriter writer = new StreamWriter(way, false, System.Text.Encoding.Default))
                            {
                                for (int i = 0; i < 6; i++)
                                {
                                    writer.WriteLine(txt[i]);
                                }
                                writer.Close();
                        }
                        }
                        catch (Exception e1)
                        {
                            Console.WriteLine(e1);
                        }

                        try
                        {
                            using (StreamReader sr3 = new StreamReader(way, System.Text.Encoding.Default))
                            {
                                sr3.ReadLine();
                                sr3.ReadLine();
                                labelSetInfo3.Text = sr3.ReadLine();
                                sr3.Close();
                            }
                        }
                        catch (Exception e1)
                        {
                            Console.WriteLine(e1);
                        }
                    
                }
                else
                {
                    labelErr2.Text = "Вклад еще не доступен для изменения!";
                }
            }
            else
            {
                labelErr2.Text = "Сумма вывода слишком большая!";
            }

            try
            {
                using (StreamReader sr = new StreamReader(way, System.Text.Encoding.Default))
                {
                    sr.ReadLine();
                    str = sr.ReadLine();
                    day = Convert.ToInt32(str.Substring(0, 2));
                    month = Convert.ToInt32(str.Substring(3, 2));
                    year = Convert.ToInt32(str.Substring(6, 4));
                    sum = Convert.ToInt32(sr.ReadLine());
                    perc = Convert.ToDouble(sr.ReadLine());
                    str = sr.ReadLine();
                    minT = Convert.ToInt32(sr.ReadLine());
                    DateTime now = new DateTime(year, month, day);
                    numDays = DateTime.Today.Subtract(now).Days;
                    sr.Close();
                }
                month = (DateTime.Today.Year - year) * 12 + DateTime.Today.Month - month;
                if (DateTime.Today.Day < day)
                {
                    month--;
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }

        private void labelHelp_Click(object sender, EventArgs e)
        {
            Spravka spravka = new Spravka();
            spravka.Show();
        }
    }
}
