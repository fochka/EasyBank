using System;
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
    public partial class Spravka : Form
    {
        public Spravka()
        {
            InitializeComponent();
        }

        private void Spravka_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count < 3)
            {
                Application.Exit();
            }
        }
    }
}
