using System;

namespace PClasses
{
    public class Mensalista : Empregado
    {
        public double SalarioMensal { get; set; }

        public Mensalista()
        {

        }

        public Mensalista(int matricula, string nome, DateTime dataEntrada, double salarioMensal)
        {
            Matricula = matricula;
            NomeEmpregado = nome;
            DataEntradaEmpresa = dataEntrada;
            SalarioMensal = salarioMensal;
        }
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
    }
}
