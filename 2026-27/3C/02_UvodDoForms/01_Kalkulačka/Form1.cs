namespace _01_Kalkulačka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_soucet_Click(object sender, EventArgs e)
        {
            double prvniCislo = Convert.ToDouble(txt_prvniCislo.Text);
            double druheCislo = Convert.ToDouble(txt_druheCislo.Text);

            vysledek.Text = Convert.ToString(soucet(prvniCislo, druheCislo));
        }

        private double soucet(double x, double y)
        {
            return x + y;
        }

    }
}
