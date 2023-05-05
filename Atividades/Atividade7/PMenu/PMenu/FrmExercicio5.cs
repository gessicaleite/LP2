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
    public partial class FrmExercicio5 : Form
    {
        public FrmExercicio5()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if(!int.TryParse(txtNumero1.Text, out int number1))
            {
                MessageBox.Show("Favor digitar um número válido!");
            }
            if (!int.TryParse(txtNumero2.Text, out int number2))
            {
                MessageBox.Show("Favor digitar um número válido!");
            }
            else
            {
                if(number2<number1)
                {
                    MessageBox.Show("O número 2 precisa ser maior que o 1");
                }
                else
                {
                    txtResultado.Text = random.Next(number1, number2).ToString();
                }
            }
        }
    }
}
