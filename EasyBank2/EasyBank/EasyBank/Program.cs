using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBank
{
    static class Calculate
    {
        static double Calc(int vrem, double procent, bool mesac)
        {
            double dengi = 1;
            if (mesac)
            {
                for (int k = 0; k < vrem; k++)
                {
                    dengi = dengi * procent * 0.01;
                }
            }
            else
            {
                for(int k = 0; k < vrem; k+=12)
                {
                    dengi = dengi * procent * 0.01;
                }
            }
            return (dengi);
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
