using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrevodJednotek
{
    public partial class Form1 : Form
    {

        List<String> Jednotky = new List<String>();

        public Form1()
        {
            InitializeComponent();
            
            Jednotky.Add("km");
            Jednotky.Add("m");
            Jednotky.Add("cm");
            
            //Auto a;
            //Auto a = new Auto();

            foreach (String jednotka in Jednotky)
            {
                comboBoxVstup.Items.Add(jednotka);
            }
            
        }

        private void btn_vypocet_Click(object sender, EventArgs e)
        {
            double vstupOdUzivatele = Double.Parse(txtVstup.Text);
            double vystup = 0;

            switch (comboBoxVstup.SelectedItem)
            {
                case "m":
                    vystup = vstupOdUzivatele / 1000;
                    break;
                case "cm":
                    vystup = vstupOdUzivatele / 10000;
                    break;
            }

            labelKM.Text = vystup.ToString() + " km";


        }
    }
}
