using System;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        double altura, peso, resultado;
        string classificacao;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(mskBxAltura.Text, out altura) && double.TryParse(mskBxPeso.Text, out peso))
            {
                if(altura > 1 && peso > 5)
                {
                    resultado = Math.Round(peso / Math.Pow(altura, 2), 1);
                    txtImc.Text = resultado.ToString();
                    txtClassificacao.Text = ExibirClassificacao(resultado);
                }
            }
            else
            {
                MessageBox.Show("Valores inválidos!");
            }
        }

        private void MskBxAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskBxAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválida!");
            }
            else
            {
                if (altura < 1.0)
                {
                    MessageBox.Show("Altura não pode ser menor que 1.0m");
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            mskBxAltura.Clear();
            mskBxPeso.Clear();
            txtClassificacao.Clear();
            txtImc.Clear();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MskBxPeso_Validated(object sender, EventArgs e)
        {
            if(!double.TryParse(mskBxPeso.Text, out peso))
            {
                MessageBox.Show("Peso inválida!");
            }
            else
            {
                if(peso < 5)
                {
                    MessageBox.Show("Peso não pode ser menor que 5");
                }
            }
        }

        private string ExibirClassificacao(double valor)
        {
            if(valor < 18.5)
            {
                classificacao = "Magreza";
            }
            else if(valor >= 18.5 && valor <= 24.9)
            {
                classificacao = "Normal";
            }
            else if (valor >= 25 && valor <= 29.9)
            {
                classificacao = "Sobrepeso";
            }
            else if (valor >= 30 && valor < 39.9)
            {
                classificacao = "Obesidade";
            }
            else
            {
                classificacao = "Obesidade Grave";
            }

            return classificacao;

        }
    }
}
