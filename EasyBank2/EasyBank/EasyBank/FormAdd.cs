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
    public partial class FormAdd : Form
    {
        private bool admin = true;
        private int min = 0;
        private int max = 0;
        private string percent = "";
        private string period = "";
        private string minTime = "";
        public FormAdd(int numDep, bool isAdmin)
        {
            admin = isAdmin;
            numDep = numDep*6;
            InitializeComponent();
            string path = Properties.Settings.Default.dir + @"EB\Deposits.txt";
            int dnum = 1;
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    for (dnum = 1; dnum < numDep+1; dnum++)
                    {
                        line = sr.ReadLine();
                    }
                    dnum = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        dnum++;
                        switch (dnum)
                        {
                            case 1:
                                labelDepositInfo.Text = line.Replace('_', ' ')+ "\n";
                                break;
                            case 2:
                                labelDepositInfo.Text = labelDepositInfo.Text + "Процентная ставка: " + line + "%\n";
                                percent = line;
                                break;
                            case 3:
                                period = line;
                                if (line == "g")
                                {
                                    labelDepositInfo.Text = labelDepositInfo.Text + "Процент начисляется каждый ГОД\n";
                                }
                                else
                                {
                                    labelDepositInfo.Text = labelDepositInfo.Text + "Процент начисляется каждый МЕСЯЦ\n";
                                }
                                break;
                            case 4:
                                labelDepositInfo.Text = labelDepositInfo.Text + "Минимальный срок вклада: " + line + " дней\n";
                                minTime = line;
                                break;
                            case 5:
                                labelDepositInfo.Text = labelDepositInfo.Text + "Минимальная сумма: " + line + " рублей\n";
                                min = Convert.ToInt32(line);
                                break;
                            case 6:
                                labelDepositInfo.Text = labelDepositInfo.Text + "Максимальная сумма: " + line + " рублей";
                                max = Convert.ToInt32(line);
                                break;
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void FormAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count < 3)
            {
                Application.Exit();
            }
        }

        private void buttonAddInvest_Click(object sender, EventArgs e)
        {
            if((Convert.ToInt32(textBox3.Text) >= min)&& (Convert.ToInt32(textBox3.Text) <= max))
            {
                if ((textBox1.Text != null) && (textBox1.Text != ""))
                { 
                    labelErr.Text = "";
                    string path = Properties.Settings.Default.dir + @"EB\Clients\DepositFile.txt";
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                        {
                            sw.WriteLine();
                            sw.Write(textBox1.Text.Replace(' ', '_'));
                            sw.Close();
                        }
                    }
                    catch (Exception e1)
                    {
                        Console.WriteLine(e1.Message);
                    }
                    path = Properties.Settings.Default.dir + @"EB\Clients\" + textBox1.Text.Replace(' ', '_') + ".txt";
                    string path2 = Properties.Settings.Default.dir + @"EB\Clients\DepositFile.txt";
                    try
                    {
                        //Сделать проверку, чтобы не создавать одинаковые вклады!
                        using (StreamWriter sw2 = new StreamWriter(path, false, System.Text.Encoding.Default))
                        {
                            sw2.WriteLine(textBox1.Text.Replace(' ', '_'));
                            if (DateTime.Today.Day < 11)
                            {
                                sw2.WriteLine("0" + Convert.ToString(DateTime.Today.ToShortDateString()));
                            }
                            else
                            {
                                sw2.WriteLine(Convert.ToString(DateTime.Today.ToShortDateString()));
                            }
                            sw2.WriteLine(textBox3.Text);
                            sw2.WriteLine(percent);
                            sw2.WriteLine(period);
                            sw2.WriteLine(minTime);
                            sw2.Close();
                        }
                    }
                    catch (Exception e1)
                    {
                        Console.WriteLine(e1.Message);
                    }
                    try
                    {
                        using (StreamWriter sw3 = new StreamWriter(path2, true, System.Text.Encoding.Default))
                        {
                            sw3.WriteLine(textBox1.Text.Replace(' ', '_'));
                            sw3.Close();
                            MessageBox.Show("Депозит добавлен", "", MessageBoxButtons.OK);
                        }
                    }
                    catch
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    labelErr.Text = "Введите ФИО!";
                }
            }
            else
            {
                labelErr.Text = "Неверная сумма попробуйте еще раз!";
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox3.Text != null) && (textBox3.Text != ""))
                {
                    int money = 0;
                    Calculate calculate = new Calculate();
                    int time = Convert.ToInt32(nUpDown2.Value + nUpDown1.Value * 12);
                    int perc = Convert.ToInt32(textBox3.Text);
                    if (period == "m")
                    {
                        money = calculate.Calc(Convert.ToInt32(textBox3.Text), time, Convert.ToDouble(percent), true);
                    }
                    else
                    {
                        money = calculate.Calc(Convert.ToInt32(textBox3.Text), time, Convert.ToDouble(percent), false);
                    }
                    labelSum.Text = "Итоговая сумма: " + Convert.ToString(money) + "руб.";
                }
                else
                {
                    labelSum.Text = "Введите сумму вклада";
                }
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
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