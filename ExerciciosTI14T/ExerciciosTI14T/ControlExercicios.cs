using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ControlExercicios
    {
        //Ligar as duas classes
        ModelExercicios model;
        private int opcao;
        private double num1;
        private double num2;
        public ControlExercicios()
        {
            model = new ModelExercicios();//Chamando o construtor da classe Model Exercicios
        }//fim do construtor

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }
        public void Menu()
        {
            Console.WriteLine("---- Menu ----" +
                             "\n1. Exercício 01" +
                             "\n2. Exercício 02" +
                             "\n3. Exercício 03");
            Console.WriteLine("Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Executar()
        {
            Menu();
            //Executar a ação
            switch (ConsultarOpcao)
            {
                case 1:
                    Console.WriteLine(model.Exercicio01());
                    break;

                case 2: Console.WriteLine("informe um número");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("O Antecessor de" + num + "é" + model.Exercicio02(num));
                    break;

                    case 3:
                    do
                    {
                        Console.WriteLine("informe a Base");
                        num1 = Convert.ToDouble(Console.ReadLine());
                           if  (num1 <= 0)
                        {
                            Console.WriteLine("Altura digitada não é valida,digite novamente!");
                         }//fim do if



                    }while (num1 <= 0 );
                    do
                    {
                        Console.WriteLine("informe A Altura");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        if (num2 <= 0)
                            {
                            Console.WriteLine("altura digitada não é valida, digite novamente");
                        }
                    }while (num2 <= 0);

                    Console.WriteLine("a area do retangulo é: " + model.Exercicio03(num1, num2));
                    
                          break;

                case 4:
                    Console.WriteLine("informe Quantos Anos voce tem :");
                    int ano = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("informe Quantos Meses voce tem");


            }//fim do switch
        }//fim do executar
    }//fim da classe
}//fim do projeto
