using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBank
{
//hjkl
    static class Calculate
    {
        //kxchj
        private static double Calc(int time, double percent, bool month)
        {
            double money = 1;
            if (month)
            {
                for (int i = 0; i < time; i++)
                {
                    money = money + Convert.ToInt32(Math.Round(money * percent * 0.01));
                }
            }
            else
            {
                time = time / 12;
                for (int j = 0; j < time; j++)
                {
                    money = money + Convert.ToInt32(Math.Round(money * percent * 0.01));
                }
            }
            return (money);
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.43
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
