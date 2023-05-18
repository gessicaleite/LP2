using System;
using System.Windows.Forms;

namespace PLacos
{
    public partial class FormExercicio2 : Form
    {
        public FormExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor = 1;
            if (!int.TryParse(txtBoxNumero.Text, out int numero))
            {
                MessageBox.Show("Favor digitar somente números inteiros"); 
            }
            else
            {
                if (numero <= 0)
                {
                    MessageBox.Show("Favor digitar números maiores que 0!");
                }
                else
                {
                    for (int i = 2; i <= numero; i++)
                    {
                        valor += 1.0 / i;
                    }
                    txtResultado.Text = valor.ToString("N2");
                }
            }
            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxNumero.Clear();
            txtResultado.Clear();
        }
    }
}
