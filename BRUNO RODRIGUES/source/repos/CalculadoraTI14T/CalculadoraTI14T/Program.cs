using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI14T
{
    class Program
    {
        static void Main(string[] args)
        {
            //conectamos a control a programa
            ControlCalculadora control = new ControlCalculadora();
            //chamar o metodo que vai ser ultilizado
            control.Operacao();
            Console.ReadLine();

        }//fim do metodo main
    }//fim da classe
}//fim do projeto
