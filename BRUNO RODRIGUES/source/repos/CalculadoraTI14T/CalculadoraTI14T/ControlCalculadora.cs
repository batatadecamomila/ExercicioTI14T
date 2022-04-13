using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI14T
{
    class ControlCalculadora
    {
        ModelCalculadora modelo; //conectando a outra classe
        private int opcao;
        private double num1;
        private double num2;
        public ControlCalculadora()
        {

            modelo = new ModelCalculadora();
            consultarOpcao = 0;//instanciando o metodo
            ConsultarNum1 = 0;
            ConsultarNum2 = 0;


        }//fim do controleCalculadora

        public int consultarOpcao {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }



         }//fim do ConsultarOpcao
        public double ConsultarNum1
        {
            get
            {
                return num1;
            }
            set
            {
                this.num1 = value;
            }
        }
        public double ConsultarNum2
        {
            get
            {
                return num2;
            }
            set
            {
                this.num2 = value;
            }
        }//fim do consultaropcao



        public void menu()
        {

            Console.WriteLine("----Menu----\n\n" + "1.Somar\n" +
                                                  "2.Subtrair\n" +
                                                  "3.Multiplicar\n" +
                                                   "4.Dividir\n" +
                                                   "5.Potencia\n" +
                                                   "6.Raiz\n" +
                                                   "0.sair");
            Console.WriteLine("\n\nEscolha uma das opções acima");
            consultarOpcao = Convert.ToInt32(Console.ReadLine());






        }//fim do metodo menu                     
        public void Operacao()
            
        {
            do
            {
                menu();//chamar o metodo menu


                switch (consultarOpcao)
                {


                    case 1:
                        Coletar();//coletar num 1 e 2
                        Console.WriteLine("O Resultado da operação é: " + modelo.Soma(ConsultarNum1, ConsultarNum2));
                        break;

                    case 2:
                        Coletar();//coletar num 1 e 2
                        Console.WriteLine("O Resultado da operação é: " + modelo.Subtrair(ConsultarNum1, ConsultarNum2));
                        break;


                    case 3:
                        Coletar();//coletar num 1 e 2
                        Console.WriteLine("O Resultado da operação é: " + modelo.Multiplicar(ConsultarNum1, ConsultarNum2));
                        break;


                    case 4:
                        Coletar();//coletar num 1 e 2
                        if(modelo.Dividir(ConsultarNum1, ConsultarNum2) == -1)
                        {
                            Console.WriteLine("Impossivel dividir por Zero");
                        }

                        else
                        {
                            Console.WriteLine("O Resultado da Operação é: " + modelo.Dividir(ConsultarNum1, ConsultarNum2));
                        }
                        
                        Console.WriteLine("O Resultado da operação é: " + modelo.Dividir(ConsultarNum1, ConsultarNum2));
                        break;

                    case 5:
                        Coletar();//coletar num 1 e 2
                        Console.WriteLine("O Resultado da operação é: " + modelo.Potencia(ConsultarNum1, ConsultarNum2));
                        break;

                    case 6:

                        Console.WriteLine("informe um Numero para calcular a raiz: ");
                        ConsultarNum1 = Convert.ToInt32(Console.ReadLine());
                        
                        if (ConsultarNum1 < 0)
                        {
                            Console.WriteLine("Impossivel calcular raiz de numero negativo");
                        }

                        else
                        {
                            Console.WriteLine("O Resultado da Operaçao é: " + modelo.Raiz(ConsultarNum1));
                        }

                        break;

                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    default:
                        Console.WriteLine("Opção escolhida não é Valida, tente novamente!");
                        break;

                }//fim switch

            } while (consultarOpcao != 0);

        }  //fim do metodo operacao
        public void Coletar()
        {
            Console.WriteLine("informe o primeiro múmero");
            ConsultarNum1   = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe o segundo Numero");
            ConsultarNum2  = Convert.ToDouble(Console.ReadLine());
            
        }//fim do coletar
      

    }//fim da classe
}//fim do projeto
