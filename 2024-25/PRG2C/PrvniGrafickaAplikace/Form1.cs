using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrvniGrafickaAplikace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txt_vystup.Text = randomValue();

        }

        private string randomValue()
        {
            Random rnd = new Random();
            return rnd.Next(0, 100).ToString();
        }
    }
}
