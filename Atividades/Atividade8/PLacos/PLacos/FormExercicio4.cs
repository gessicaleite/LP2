using System;
using System.Globalization;
using System.Windows.Forms;

namespace PLacos
{
    public partial class FormExercicio4 : Form
    {
        public FormExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salarioBruto;
            int b = 0, c = 0, d = 0;
            double.TryParse(txtBoxSalario.Text, out double salario);
            int.TryParse(txtBoxProducao.Text, out int producao);
            double.TryParse(txtBoxGratificacao.Text, out double gratificacao); 

            if (producao >= 150)
            {
                b = 1; c = 1; d = 1;
            }
            else
            {
                if(producao >= 120)
                {
                    b = 1; c = 1;
                }
                else
                {
                    if(producao >= 100)
                    {
                        b = 1;
                    }
                }
            }

            salarioBruto = CalcularSalarioBruto(salario, b, c, d, gratificacao);
            if(salarioBruto > 7000)
            {
                if(producao < 150)
                {
                    salarioBruto = 7000;
                }
                else
                {
                    if(gratificacao <= 0)
                    {
                        salarioBruto = 7000;
                    }
                }
            }
            txtResultado.Text = salarioBruto.ToString("C2", CultureInfo.CurrentCulture);
        }

        private double CalcularSalarioBruto(double salario, int b, int c, int d, double gratificacao)
        {
            return salario + (salario * (0.05 * b + 0.1 * c + 0.1 * d)) + gratificacao;         
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxCargo.Clear();
            txtBoxGratificacao.Clear();
            txtBoxMatricula.Clear();
            txtBoxNome.Clear();
            txtBoxProducao.Clear();
            txtBoxSalario.Clear();
            txtResultado.Clear();
        }
    }
}
