using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDescontos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularDescontos_Click(object sender, EventArgs e)
        {
            #region Validações
            if (string.IsNullOrEmpty(txtBoxNomeFuncionario.Text) || txtBoxNomeFuncionario.TextLength < 5)
            {
                MessageBox.Show($"Digite um nome válido {txtBoxNomeFuncionario.Text}");
                txtBoxNomeFuncionario.Clear();
                txtBoxNomeFuncionario.Focus();
            }
            else if (!double.TryParse(mkdTxtBoxSalarioBruto.Text, out double val))
            {
                MessageBox.Show("Digite um valor válido!");
                mkdTxtBoxSalarioBruto.Clear();
                mkdTxtBoxSalarioBruto.Focus();
            }
            #endregion
            else
            {
                string sexo = rdBtnFeminino.Checked ? "Sra" : "Sr";
                string estadoCivil = chckBoxCasado.Checked ? "Casado" : "Solteiro";
                lblResposta.Text = $"Olá {sexo} {txtBoxNomeFuncionario.Text}. Estado Civil: {estadoCivil}. Filhos: {numUpDownFilhos.Text}. " +
                    $"Aqui vão seus descontos  e seu salário líquido a receber: ";
                
                double aliquotaINSS = CalcularAliquotaINSS(val);
                double aliquotaIR = CalcularAliquotaIR(val);
                double salarioFamilia = CalcularSalarioFamilia(val, (int)numUpDownFilhos.Value);

                double descontoINSS = aliquotaINSS == 0 ? 308.17 : val * (aliquotaINSS / 100);
                double descontoIR = val * (aliquotaIR / 100);

                double salarioLiquido = CalcularSalarioLiquido(val, descontoINSS, descontoIR, salarioFamilia);

                txtBoxINSS.Text = aliquotaINSS == 0 ? "Máximo" : $"{aliquotaINSS}%";
                txtBoxIR.Text = aliquotaIR == 0 ? "Isento" : $"{aliquotaIR}%";
                txtBoxSalarioFamilia.Text = String.Format("{0:C}", salarioFamilia);

                txtBoxDescontoINSS.Text = String.Format("{0:C}", descontoINSS);
                txtBoxDescontoIR.Text = String.Format("{0:C}", descontoIR);

                txtBoxSalarioLiquido.Text = String.Format("{0:C}", salarioLiquido);

            }
        }

        private double CalcularAliquotaINSS(double salarioBruto)
        {
            double aliquota = 0;

            switch (salarioBruto)
            {
                case double i when i < 800.48:
                    aliquota = 7.65;
                    break;
                case double i when i < 1050.01:
                    aliquota = 8.65;
                    break;
                case double i when i < 1400.78:
                    aliquota = 9;
                    break;
                case double i when i < 2801.57:
                    aliquota = 11;
                    break;
                default:
                    break;
            }

            return aliquota;
        }

        private double CalcularAliquotaIR(double salarioBruto)
        {
            double aliquota = 27.5;

            switch (salarioBruto)
            {
                case double i when i < 1257.13:
                    aliquota = 0;
                    break;
                case double i when i < 2512.08:
                    aliquota = 15;
                    break;
                default:
                    break;
            }
            return aliquota;
        }

        private double CalcularSalarioFamilia(double salarioBruto, int numFilhos)
        {
            double adicional = 0;

            switch (salarioBruto)
            {
                case double i when i < 435.53:
                    adicional = 22.33;
                    break;
                case double i when i < 654.62:
                    adicional = 15.74;
                    break;
                default:
                    break;
            }
            return adicional*numFilhos;
        }

        private double CalcularSalarioLiquido(double salarioBruto, double INSS, double IR, double salarioFamilia)
        {
            return salarioBruto - INSS - IR + salarioFamilia;
        }

    }
}
