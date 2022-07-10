using System.Globalization;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        decimal num1 = 0;
        decimal num2 = 0;
        string operacao = "soma";
        public Calculadora()
        {
            InitializeComponent();

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            lbl_opera.Text += "0";
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            lbl_opera.Text += "1";
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            lbl_opera.Text += "2";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            lbl_opera.Text += "3";
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            lbl_opera.Text += "4";
        }
        private void btn_cinco_Click(object sender, EventArgs e)
        {
            lbl_opera.Text += "5";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            lbl_opera.Text += "6";
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            lbl_opera.Text += "7";
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            lbl_opera.Text += "8";
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            lbl_opera.Text += "9";
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            lbl_opera.Text = decimal.Parse(lbl_opera.Text) + ",";
        }

        private void adic_Click(object sender, EventArgs e)
        {
            operacao = "soma";
            num1 = decimal.Parse(lbl_opera.Text, CultureInfo.InvariantCulture);
            conta.Text = lbl_opera.Text; 
            conta.Text += " + ";
            lbl_opera.Text = " ";


        }

        private void subt_Click(object sender, EventArgs e)
        {
            operacao = "subt";
            num1 = decimal.Parse(lbl_opera.Text, CultureInfo.InvariantCulture);
            conta.Text = lbl_opera.Text;
            conta.Text += " - ";
            lbl_opera.Text = " ";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            operacao = "mult";
            num1 = decimal.Parse(lbl_opera.Text, CultureInfo.InvariantCulture);
            conta.Text = lbl_opera.Text;
            conta.Text += " x ";
            lbl_opera.Text = " ";
        }

        private void divi_Click(object sender, EventArgs e)
        {
            operacao = "divi";
            num1 = decimal.Parse(lbl_opera.Text, CultureInfo.InvariantCulture);
            conta.Text = lbl_opera.Text;
            conta.Text += " / ";
            lbl_opera.Text = " ";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(lbl_opera.Text, CultureInfo.InvariantCulture);

            if (operacao == "soma")
            {
                lbl_opera.Text = Convert.ToString(num1 + num2);
                conta.Text += num2 + " = " + lbl_opera.Text;
            }else if(operacao == "subt")
            {
                lbl_opera.Text = Convert.ToString(num1 - num2);
                conta.Text += num2 + " = " + lbl_opera.Text;
            }
            else if (operacao == "mult")
            {
                lbl_opera.Text = Convert.ToString(num1 * num2);
                conta.Text += num2 + " = " + lbl_opera.Text;
            }
            else if (operacao == "divi")
            {
                lbl_opera.Text = Convert.ToString(num1 / num2);
                conta.Text += num2 + " = " + lbl_opera.Text;
            }
        }
    }
}