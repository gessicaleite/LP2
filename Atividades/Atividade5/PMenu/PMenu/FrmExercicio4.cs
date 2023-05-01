using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rchTxtBox.Clear();
            txtResultado.Clear();
        }

        private void btnTotalNumericos_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (var i = 0; i < rchTxtBox.Text.Length; i++)
            {
                if (char.IsNumber(rchTxtBox.Text[i]))
                {
                    total++;
                }

            }

            txtResultado.Text = total.ToString();
        }

        private void btnPrimeiroCharBranco_Click(object sender, EventArgs e)
        {
            int posicao = 0;
            while (posicao < rchTxtBox.Text.Length)
            {
                if (char.IsWhiteSpace(rchTxtBox.Text[posicao]))
                {
                    txtResultado.Text = posicao.ToString();
                    break;
                }
                else
                {
                    txtResultado.Text = "Não possui espaços em branco";
                }
                posicao++;
            }
        }

        private void btnTotalAlfabetico_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (var item in rchTxtBox.Text)
            {
                if (char.IsLetter(item))
                    total++;
            }
            txtResultado.Text = total.ToString();
        }
    }
}
