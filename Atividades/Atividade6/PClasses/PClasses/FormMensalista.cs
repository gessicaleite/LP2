using System;
using System.Windows.Forms;

namespace PClasses
{
    public partial class FormMensalista : Form
    {
        public FormMensalista()
        {
            InitializeComponent();
        }

        private void BtnInstanciarMensalista_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            objMensalista.Matricula = Convert.ToInt32(txtBoxMatriculaMensalista.Text);
            objMensalista.NomeEmpregado = txtBoxNomeMensalista.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntradaMensalista.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtBoxSalarioMensalista.Text);

            if (rdBtnSimMensalista.Checked)
            {
                objMensalista.HomeOffice = 'S';
            }
            else
            {
                objMensalista.HomeOffice = 'N';
            }

            MessageBox.Show($"Matrícula: {objMensalista.Matricula}. \n " +
                $"Nome: {objMensalista.NomeEmpregado}. \n " +
                $"Data Entrada: {objMensalista.DataEntradaEmpresa} \n " +
                $"Salário Bruto: {objMensalista.SalarioBruto().ToString("N2")} \n " +
                $"Tempo de Empresa: {objMensalista.TempoTrabalho()} \n" +
                $"{objMensalista.VerificaHome()}");
        }

        private void BtnInstanciarMensalistaParams_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(txtBoxMatriculaMensalista.Text), 
                                                        txtBoxNomeMensalista.Text, 
                                                        Convert.ToDateTime(txtDataEntradaMensalista.Text), 
                                                        Convert.ToDouble(txtBoxSalarioMensalista.Text));

            MessageBox.Show($"Matrícula: {objMensalista.Matricula}. \n " +
                $"Nome: {objMensalista.NomeEmpregado}. \n " +
                $"Data Entrada: {objMensalista.DataEntradaEmpresa} \n " +
                $"Salário Bruto: {objMensalista.SalarioBruto().ToString("N2")} \n " +
                $"Tempo de Empresa: {objMensalista.TempoTrabalho()} \n" +
                $"{objMensalista.VerificaHome()}");
        }
    }
}
