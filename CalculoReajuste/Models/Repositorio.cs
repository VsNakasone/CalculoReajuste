using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoReajuste
{
    public class Repositorio : IRepositorio
    {

        private List<Colaborador> listaColab = new List<Colaborador>();

        private List<ColaboradorAntigo> listaColabAntigo = new List<ColaboradorAntigo>();

        public Repositorio()
        {
        }

        public void Atualiza(int id, Colaborador objeto)
        {
            listaColab[id] = objeto;
        }

        public void Cadastra(Colaborador objeto)
        {
            listaColab.Add(objeto);
        }

        public void Exclui(int id)
        {
            listaColab[id].Excluir();
        }
        public void Atualiza(int id, ColaboradorAntigo objeto)
        {
            listaColabAntigo[id] = objeto;
        }

        public void Cadastra(ColaboradorAntigo objeto)
        {
            listaColabAntigo.Add(objeto);
        }

        public void Exclui(int id, ColaboradorAntigo objeto)
        {
            listaColab[id].Excluir();
        }

        public List<T> Lista()
        {
            throw new NotImplementedException();
        }

        public void Cadastra()
        {
            throw new NotImplementedException();
        }

        public void Exclui()
        {
            throw new NotImplementedException();
        }

        public void Atualiza()
        {
            throw new NotImplementedException();
        }
    }
}
