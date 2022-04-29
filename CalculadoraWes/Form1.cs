using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWes
{
    public partial class Form1 : Form
    {
        decimal valorUm = 0m;
        decimal valorDois = 0m;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            // estava dando erro quando o BIOS digitava apenas o operador matematico
            // essa verificação ajudou a tirar esse erro
            if (txtResultado.Text != "")
            {
                valorUm = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma");
            }

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valorDois = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            // Verificação para saber qual operação o BIOS escolheu pra ser feita
            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valorUm + valorDois);
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valorUm - valorDois);
            }
            else if (operacao == "MULTI")
            {
                txtResultado.Text = Convert.ToString(valorUm * valorDois);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valorUm / valorDois);
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valorUm = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração");
            }

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valorUm = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTI";
                lblOperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação");
            }

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valorUm = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valorUm = 0;
            valorDois = 0;
            lblOperacao.Text = "";
        }
    }
}
