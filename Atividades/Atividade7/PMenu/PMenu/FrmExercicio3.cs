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
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtPalavra1.Clear();
            txtPalavra2.Clear();
            txtResultado.Clear();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            txtResultado.Text = txtPalavra2.Text;

            while (posicao >= 0)
            {
                txtResultado.Text = $"{txtResultado.Text.Substring(0, posicao)}{txtResultado.Text.Substring(txtPalavra1.Text.Length + posicao, txtResultado.Text.Length - posicao - txtPalavra1.Text.Length)}";
                posicao = txtResultado.Text.IndexOf(txtPalavra1.Text);
            }
        }
        private void BtnRemoverReplace_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void BtnInverter_Click(object sender, EventArgs e)
        {
            char[] meuArray = txtPalavra1.Text.ToCharArray();
            Array.Reverse(meuArray);
            foreach (var c in meuArray)
            {
                txtResultado.Text += c;
            }
        }

    }
}
