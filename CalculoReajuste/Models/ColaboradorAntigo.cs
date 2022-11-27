using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoReajuste
{
    public class ColaboradorAntigo : Colaborador
    {
        public ColaboradorAntigo(DateTime dataAdmissao) : base(dataAdmissao)
        {
        }

        public ColaboradorAntigo(string nome, string cargo, DateTime dataAdmissao, double salario) : base(nome, cargo, dataAdmissao, salario)
        {
        }

        public void SelecionarColaborador()
        {
            if (base.salario >= 7000)
            {
                double reajuste = salario + (salario * .10);
            }
            else if (base.salario >= 1200 && base.salario <= 3000)
            {
                double reajuste = salario + (salario * .035);
            }
            else if (base.salario > 3000 && base.salario <= 5000)
            {
                double reajuste = salario + (salario * .06);
            }
            else if (base.salario > 5000 && base.salario < 7000)
            {
                double reajuste = salario + (salario * .08);
            }
        }
    }
}
