namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    {
        private bool somar = false;
        private bool dividir = false;
        private bool multiplicar = false;
        private bool subtrair = false;

        public Form1()
        {
            InitializeComponent();
        }
        private bool ExisteOperacao()
        {
            if(dividir || somar || multiplicar || subtrair)
                return true;
            return false;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (txtOperacao.Text.Trim() == string.Empty || ExisteOperacao())
                return;
            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = true;

            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '-'
                || txtOperacao.Text[txtOperacao.Text.Length - 1] == '*'
                || txtOperacao.Text[txtOperacao.Text.Length - 1] == '/')
            {
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }
            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '+')
                return;
            txtOperacao.Text += "+";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (txtOperacao.Text.Trim() == string.Empty || ExisteOperacao())
                return;

            dividir = false;
            subtrair = true;
            multiplicar = false;
            somar = false;

            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '+'
                || txtOperacao.Text[txtOperacao.Text.Length - 1] == '*'
                || txtOperacao.Text[txtOperacao.Text.Length - 1] == '/')
            {
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }
            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '-')
                return;
            txtOperacao.Text += "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtOperacao.Text.Trim() == string.Empty || ExisteOperacao())
                return;
            dividir = false;
            subtrair = false;
            multiplicar = true;
            somar = false;

            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '+'
                || txtOperacao.Text[txtOperacao.Text.Length - 1] == '-'
                || txtOperacao.Text[txtOperacao.Text.Length - 1] == '/')
            {
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }
            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '*')
                return;
            txtOperacao.Text += "*";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtOperacao.Text.Trim() == string.Empty || ExisteOperacao())
                return;

            dividir = true;
            subtrair = false;
            multiplicar = false;
            somar = false;

            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '+'
                || txtOperacao.Text[txtOperacao.Text.Length - 1] == '-'
                || txtOperacao.Text[txtOperacao.Text.Length - 1] == '*')
            {
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }
            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '/')
                return;
            txtOperacao.Text += "/";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (!somar && !subtrair && !dividir && !multiplicar)
                return;
            if (somar)
            {
                List<string> aSomar = txtOperacao.Text.Split("+").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero + segundoNumero;
                txtOperacao.Text = resultado.ToString();
            }
            else if (subtrair)
            {
                List<string> aSomar = txtOperacao.Text.Split("-").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero - segundoNumero;
                txtOperacao.Text = resultado.ToString();
            }
            else if (dividir)
            {
                List<string> aSomar = txtOperacao.Text.Split("/").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero / segundoNumero;
                txtOperacao.Text = resultado.ToString();
            }
            else if (multiplicar)
            {
                List<string> aSomar = txtOperacao.Text.Split("*").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero * segundoNumero;
                txtOperacao.Text = resultado.ToString();
            }
            somar = dividir = multiplicar = subtrair = false;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "0";
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = string.Empty;
        }

        
    }
}
