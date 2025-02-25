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
    public partial class Form2 : Form
    {
        public string prenesenyText;
        Form prenesenaReference;
        public Form2(string textZForm1, Form OdkazNaPrvniFormular)
        {
            
            InitializeComponent();

            //po inicializaci komponent mohu textbox na form2 naplnit získaným textem z form 1
            prenesenyText = textZForm1;
            txt1f2.Text = textZForm1;
            prenesenaReference = OdkazNaPrvniFormular;
        }

        //pokud skyrji první okno a nemám na něj referenci, musím zajistit ukončení aplikace po zavření druhého formuláře
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //pokud mám referenci, mohu se vrátit zpět k prvnímu oknu, ale pozor na this.close() -> vyvolá událost Form2_FormClosed a ukončí celou aplikaci
        private void button1_Click(object sender, EventArgs e)
        {
            //znovuzobrazím první formulář, protože na něj mám referenci
            prenesenaReference.Show();
            
            //this.Close();
        }
    }
}
