using System;
using System.Windows.Forms;

namespace PLacos
{
    public partial class FormExercicio1 : Form
    {
        int total = 0;
        public FormExercicio1()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            rchTxt.Clear();
        }

        private void BtnEspacoBranco_Click(object sender, EventArgs e)
        {
            total = 0;
            int i = 0;
            while (i < rchTxt.TextLength)
            {
                if (char.IsWhiteSpace(rchTxt.Text[i]))
                {
                    total++;
                }
                i++;
            }
            txtResultado.Text = total.ToString();
        }

        private void BtnLetrasR_Click(object sender, EventArgs e)
        {
            total = 0;
            for (int i = 0; i < rchTxt.TextLength; i++)
            {
                if(char.ToUpper(rchTxt.Text[i]) == 'R')
                {
                    total++;
                }
            }
            txtResultado.Text = total.ToString();
        }

        private void BtnParLetra_Click(object sender, EventArgs e)
        {
            total = 0;
            for (int i = 0; i < rchTxt.TextLength -1; i++)
            { 
                if (rchTxt.Text[i] == rchTxt.Text[i+1])
                {
                    total++;
                    i++;
                }
            }
            txtResultado.Text = total.ToString();
        }
    }
}
