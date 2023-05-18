using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PLacos
{
    public partial class FormExercicio3 : Form
    {
        public FormExercicio3()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rchTxt.Clear();
            txtResultado.Clear();
        }

        private void btnPalindrono_Click(object sender, EventArgs e)
        {
            bool palindrono = false;
            var texto = rchTxt.Text;
            var textoSemEspacos = Regex.Replace(texto, @" ", "");
            int i, j = textoSemEspacos.Length - 1;

            for (i = 0; i < j; i++)
            {
                if (textoSemEspacos.ToLower()[i] == textoSemEspacos.ToLower()[j-i])
                {
                    palindrono = true;
                }
                else
                {
                    palindrono = false;
                }
            }

            txtResultado.Text = palindrono ? "Sim" : "Não";
        }
    }
}
