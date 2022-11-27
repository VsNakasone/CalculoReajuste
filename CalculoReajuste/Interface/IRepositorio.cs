using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoReajuste
{
    public interface IRepositorio
    {
        List<T> Lista();
       
        void Cadastra();

        void Exclui();

        void Atualiza();
        
    }
    public class T
    {

    }
}
