using System;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;

            if(!double.TryParse(txtLadoA.Text, out ladoA) || ladoA <= 0)
            {
                MessageBox.Show("Inserir valor válido para o Lado A");
                txtLadoA.Focus();
            }
            else if (!double.TryParse(txtLadoB.Text, out ladoB) || ladoB <= 0)
            {
                MessageBox.Show("Inserir valor válido para o Lado B");
                txtLadoB.Focus();
            }
            else if (!double.TryParse(txtLadoC.Text, out ladoC) || ladoC <= 0)
            {
                MessageBox.Show("Inserir valor válido para o Lado C");
                txtLadoC.Focus();
            }
            else
            {
                if(ladoA<(ladoB+ladoC) && ladoA > Math.Abs(ladoB-ladoC) &&
                    ladoB < (ladoA + ladoC) && ladoB > Math.Abs(ladoA - ladoC) &&
                    ladoC < (ladoA + ladoB) && ladoC > Math.Abs(ladoA - ladoB))
                {
                    if(ladoA == ladoB && ladoB == ladoC)
                    {
                        MessageBox.Show("Triângulo Equilátero");
                    }
                    else if(ladoA != ladoB && ladoB != ladoC && ladoA != ladoC)
                    {
                        MessageBox.Show("Triângulo Escaleno");
                    }
                    else
                    {
                        MessageBox.Show("Triângulo Isósceles");
                    }
                }
                else
                {
                    MessageBox.Show("Não forma um triângulo");
                }
            }
        }
    }
}
