using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBank
{
    public class Calculate
    {
        public int Calc(int period, double percent, bool month)
        {
	    double sum = 1;
            percent = percent/100 + 1;
            if (!month)
            {
                period = period/12;
            }
            sum = sum*Math.Pow(percent,period);
            return (sum);
        }
    }
    static class Program
    {
        /// <summary>
        /// Ãëàâíàÿ òî÷êà âõîäà äëÿ ïðèëîæåíèÿ.
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
