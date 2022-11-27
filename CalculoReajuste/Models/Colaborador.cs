using System;
using System.Data;

namespace CalculoReajuste
{
    public class Colaborador
    {
        public string nome;
        public string cargo;
        public DateTime dataAdmissao;
        public double salario;
       
        public Colaborador(string nome, string cargo, DateTime dataAdmissao, double salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.dataAdmissao = dataAdmissao;
            this.salario = salario;
        }

        public Colaborador(DateTime dataAdmissao) => 
            this.dataAdmissao = dataAdmissao;

        public void calculaData()
        {
            var dataAdmissao = new DateTime(1982, 1, 7);
            var today = DateTime.Today;
            var age = today.Year - dataAdmissao.Year;
            if (age < 1)
            {
                object value = CadastrarColaborador();
            } else
            {
                object value = CadastrarColaboradorAntigo();
            }

        }

        private object CadastrarColaboradorAntigo()
        {
            throw new NotImplementedException();
        }

        private object CadastrarColaborador()
        {
            throw new NotImplementedException();
        }

        internal void Excluir()
        {
            throw new NotImplementedException();
        }
    }
}
