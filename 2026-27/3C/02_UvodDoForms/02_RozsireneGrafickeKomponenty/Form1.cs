namespace RozsireneGrafickeKomponenty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new string[] { "a", "b", "c" });

            //string[] poleStringu = new string[10];
            //comboBox1.Items.AddRange(poleStringu);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_vypis.Text = comboBox1.SelectedItem.ToString();
            comboBox1.Items.Add("x");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //lbl_vypis.Text = checkBox1.Checked.ToString();

            if (checkBox1.Checked == true)
            {
                lbl_vypis.Text = "Bylo zaškrtnuto";
            }
            else
            {
                lbl_vypis.Text = "Bylo vypnuto";
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lbl_vypis.Text = radioButton1.Text;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                lbl_vypis.Text = radioButton2.Text;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lbl_vypis.Text = trackBar1.Value.ToString();
        }
    }
}
