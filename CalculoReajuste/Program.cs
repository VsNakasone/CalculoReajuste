using System;

namespace CalculoReajuste
{
    public class Program
    {
        static void Main(string[] args)
        {
            int saida;

            do
            {
                Console.WriteLine("Informe os dados do colaborador");

                Console.WriteLine("Digite o nome:");

                string nome = Console.ReadLine();

                Console.WriteLine("Digite o cargo:");

                string cargo = Console.ReadLine();

                Console.WriteLine("Digite o salário:");

                double salario = Double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a data de admissão (mm/dd/aaaa):");

                DateTime dataAdmissao = DateTime.Parse(Console.ReadLine());

                var today = DateTime.Today;

                var age = today.Year - dataAdmissao.Year;
                if (age < 1)
                {
                    //criando colaborador novo
                    Colaborador colaboradorNovo = new Colaborador(nome, cargo, dataAdmissao, salario);

                    Console.WriteLine("O colaborador {0} é {1}, foi admitido em {2} e portanto não é elegível ao reajuste, seu salário será de R${3:N2}.", colaboradorNovo.nome, colaboradorNovo.cargo, colaboradorNovo.dataAdmissao, colaboradorNovo.salario);

                }
                else
                {
                    //criando colaborador antigo com salário maior que 7 mil e reajuste de 10%
                    if (salario > 7000)
                    {
                        salario = salario + salario * 0.10;


                        ColaboradorAntigo colaboradorAntigo = new ColaboradorAntigo(nome, cargo, dataAdmissao, salario);

                        Console.WriteLine("O colaborador {0} é {1}, admitido em {2}, passa a ganhar R${3:N2}.", colaboradorAntigo.nome, colaboradorAntigo.cargo, colaboradorAntigo.dataAdmissao, colaboradorAntigo.salario);

                    }
                    else
                    {
                        //criando colaborador antigo com salário menor que 7 mil e reajuste a definir
                        double porcentagem;

                        do
                        {
                            Console.WriteLine("Defina a porcentagem do reajuste entre 0% e 10%:");

                            porcentagem = double.Parse(Console.ReadLine());

                        } while (porcentagem <= 0 && porcentagem >= 10);

                        salario = salario + salario * porcentagem / 100;

                        ColaboradorAntigo colaboradorAntigo = new ColaboradorAntigo(nome, cargo, dataAdmissao, salario);

                        Console.WriteLine("O colaborador {0} é {1}, admitido em {2}, passa a ganhar R${3:N2}.", colaboradorAntigo.nome, colaboradorAntigo.cargo, colaboradorAntigo.dataAdmissao, colaboradorAntigo.salario);

                    }
                }

                Console.WriteLine("Cadastrar outro colaborador?\n1-Sim\n2-Não e sair!\nDigite sua opção(1 ou 2):");

                saida = int.Parse(Console.ReadLine());

            } while (saida == 1);
            
        }
    }
}
    

