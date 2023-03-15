using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtEndereco_Validated(object sender, EventArgs e)
        {
            if(txtEndereco.Text == "" || txtEndereco.Text.Length < 20)
            {
                MessageBox.Show("Digite um endereço válido");
                txtEndereco.Focus();
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(txtEmail.Text == "")
            {
                MessageBox.Show("Email vazio!");
                e.Cancel = true;
            }
        }

        private void mskBxCpf_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Digite seu CPF:");
        }

        private void mskBxCelular_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Perdendo o foco do celular");
        }
    }
}
