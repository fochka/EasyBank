﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBank
{//mhvd
    static class Calculate
    {
        static double Calc(int time, double percent, bool month)
        {
            double sum = 1;
            percent = percent / 100;
            if (!month)
            {
                time = time / 12;
            }
            sum = sum * Math.Pow(percent, time);
            return (sum);
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
