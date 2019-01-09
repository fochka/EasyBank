using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBank
{
    public class Calculate
    {
        public int Calc(int money, int time, double percent, bool month)
        {
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
                for(int i = 0; i < time; i++)
                {
                    money = money + Convert.ToInt32(Math.Round(money * percent * 0.01));
                }
            }
            return (money);
        }
        public string Readable(string vvod)
        {
            int j = vvod.Length % 3;
            if (j == 0) { j = 3; }
            for (int i = j; i < vvod.Length; i+=4)
            {
               vvod = vvod.Insert(i, " ");
            }
            return vvod;
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
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
