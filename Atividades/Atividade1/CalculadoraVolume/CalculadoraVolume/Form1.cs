using System;
using System.Windows.Forms;

namespace CalculadoraVolume
{
    public partial class Form1 : Form
    {
        double raio, altura, volume;
        const string mensagem = "Digite um valor válido!";

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChangeEnterToTab(e);
        }

        private void TxtAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtRaio.Text, out altura))
            {
                MessageBox.Show(mensagem);
            }
            if (altura <= 0)
            {
                MessageBox.Show("Altura não pode ser menor que 1");
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(txtAltura.Text, out altura) ||
                !double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("Digite valores válidos!");
            }
            else
            {
                if(altura<=0 || raio <= 0)
                {
                    MessageBox.Show("Valores precisam ser maior que 0");
                }
                else
                {
                    volume = Math.PI * Math.Pow(raio, 2) * altura;
                    txtResultado.Text = volume.ToString("N2");
                }
            }
        }


        private void TxtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChangeEnterToTab(e);
        }

        private void TxtRaio_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show(mensagem);
            }
        }

        private void ChangeEnterToTab(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
