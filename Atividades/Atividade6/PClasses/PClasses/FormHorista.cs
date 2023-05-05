using System;
using System.Windows.Forms;

namespace PClasses
{
    public partial class FormHorista : Form
    {
        public FormHorista()
        {
            InitializeComponent();
        }

        private void BtnInstanciarHorista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();
            objHorista.Matricula = Convert.ToInt32(txtBoxMatriculaHorista.Text);
            objHorista.NomeEmpregado = txtBoxNomeHorista.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntradaHorista.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtBoxSalarioHoraHorista.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumeroHorasHorista.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFaltaHorista.Text);

            if (rdBtnSimHorista.Checked)
            {
                objHorista.HomeOffice = 'S';
            }
            else
            {
                objHorista.HomeOffice = 'N';
            }

            MessageBox.Show($"Matrícula: {objHorista.Matricula}. \n " +
                $"Nome: {objHorista.NomeEmpregado}. \n " +
                $"Data Entrada: {objHorista.DataEntradaEmpresa} \n " +
                $"Salário Bruto: {objHorista.SalarioBruto().ToString("N2")} \n " +
                $"Tempo de Empresa: {objHorista.TempoTrabalho()} \n" +
                $"{objHorista.VerificaHome()}");
        }
    }
}
