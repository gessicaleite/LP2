using System;

namespace PClasses
{
    public abstract class Empregado
    {
        private int _matricula;
        private string _nomeEmpregado;
        private DateTime _dataEntradaEmpresa;
        private char _homeOffice;

        public int Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        public string NomeEmpregado
        {
            get { return _nomeEmpregado; }
            set { _nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return _dataEntradaEmpresa; }
            set { _dataEntradaEmpresa = value; }
        }

        public char HomeOffice
        {
            get { return _homeOffice; }
            set { _homeOffice = value; }
        }

        public string VerificaHome()
        {
            if (_homeOffice == 'S')
                return "Empregado trabalha em home office";
            else
                return "Empregado NÃO trabalha em home office";
        }

        public virtual int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(_dataEntradaEmpresa);
            return (span.Days);
        }

        public abstract double SalarioBruto();
    }
}
