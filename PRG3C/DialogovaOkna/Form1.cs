using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DialogovaOkna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Nacist_Click(object sender, EventArgs e)
        {
            //chci zobrazit okno a dále pracovat pouze, pokud uživatel klikne na OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //z dialogu dostanu cestu, kterou uživatel vybral
                string path = openFileDialog1.FileName;

                //dále pracuji stejně jako když ukládám text v konzoli
                string loadedText = File.ReadAllText(path);
                textBox1.Text = loadedText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chci zobrazit okno a dále pracovat pouze, pokud uživatel klikne na OK
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //z dialogového okna získám cestu + název souboru a do souboru uložím, co je v textboxu
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }
    }
}
