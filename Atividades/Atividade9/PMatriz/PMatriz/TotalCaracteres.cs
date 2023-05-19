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
            string[] nomes = new string[2];
            
            for (int i = 0; i < 2; i++)
            {
                nomes[i] = Interaction.InputBox($"Digite seu nome completo:", "ENTRADA"); ;
            }

            foreach (var item in nomes)
            {
                var nomeSemEspaco = item.Replace(" ", "");
                lstBoxNomes.Items.Add($"O nome: {item} tem {nomeSemEspaco.Length} caracteres");
            }
        }
    }
}
