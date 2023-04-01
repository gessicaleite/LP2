using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado;
        string mensagemErroBotao = "Digite valores válidos!";
        string mensagemErroEntrada = "Valor inválido";

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtNum1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out numero1))
            {
                MessageBox.Show(mensagemErroEntrada);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) && double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString("F2");
            }
            else
            {
                MessageBox.Show(mensagemErroEntrada);
            }
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) && double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString("F2");
            }
            else
            {
                MessageBox.Show(mensagemErroBotao);
            }
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) && double.TryParse(txtNum2.Text, out numero2))
            {
                if (numero2 == 0)
                {
                    MessageBox.Show("Impossível dividir por 0");
                }
                else
                {
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString("F2");
                }
            }
            else
            {
                MessageBox.Show(mensagemErroBotao);
            }
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) && double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString("F2");
            }
            else
            {
                MessageBox.Show(mensagemErroBotao);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtNum2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum2.Text, out numero2))
            {
                MessageBox.Show(mensagemErroEntrada);
            }
        }
    }
}
