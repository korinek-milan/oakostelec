using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1f1_Click(object sender, EventArgs e)
        {
            //vytvářím drujhý formulář a do konstruktoru pošlu hodnotu z mého textboxu a odkaz na sebe pro pozdější možnost návratu
            Form2 form2 = new Form2(txt1f1.Text, this);
            
            // Zobrazení nového formuláře
            form2.Show();
            
            //tento formulář pouze skryji, protože běží v hlavním vlákně a nemohu ho ukončit
            this.Hide();
        }
    }
}
