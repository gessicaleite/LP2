using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace PMatriz
{
    public partial class TotalCaracteres : Form
    {
        public TotalCaracteres()
        {
            InitializeComponent();
        }

        private void BtnCalcularCaracteres_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[8];
            int[] tamanhos = new int[8];
            
            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = Interaction.InputBox($"Digite seu nome completo:", "ENTRADA");
                tamanhos[i] = nomes[i].Replace(" ", "").Length;
            }

            for (int i = 0; i < nomes.Length; i++)
            {
                lstBoxNomes.Items.Add($"O nome: {nomes[i]} tem {tamanhos[i]} caracteres");
            }
        }
    }
}
