﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI14T
{
    class ModelCalculadora
    {
        //public - todo o projeto enxerga essa variavel
        //private - apenas a classe que ela foi criada enxega a variavel
        //protected - somente a familia enxerga a variavel
        private double num1;
        private double num2;

        public ModelCalculadora()
        {
            //instanciando as variaveis

            ModificarNum1 = 0;
            ModificarNum2 = 0;


        }//fim do metodo construtor

        //Metodos de acesso - GET (consultar) e SET (modificar)
        public double ModificarNum1
        {
            get
            {
                return num1;

            }
            set
            {
                this.num1 = value;
            }

        }//fim do metodo ModificarNum1

        public double ModificarNum2
        {
            get
            {
                return num2;
               }
            set
            {
                this.num2 = value;


            }//fim do metodo ModificarNum2

        }//fim do Metodo de Acesso

        //operações
        public double Soma(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            return ModificarNum1 + ModificarNum2;
        }//fim do metodo Soma

        public double Subtrair(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            return ModificarNum1 - ModificarNum2;

        }//fim do metodo Subtrair


        public double Multiplicar(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            return ModificarNum1 * ModificarNum2;

        }//fim do metodo Multiplicar



        public double Dividir(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            //Validação
            if (ModificarNum2 == 0)
            {
                return -1;
            }
            return ModificarNum1 / ModificarNum2;
        }//fim do metodo Dividir

        public double Potencia(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            return Math.Pow(ModificarNum1, ModificarNum2);
        }//fim do metodo Potencia


        public double Raiz (double num1, double num2)
        {
            ModificarNum1 = num1;
            if (ModificarNum1 < 0)
            {
                return -1;

            }

           return Math.Sqrt(ModificarNum1);


        }//fim do metodo Raiz

        internal double Raiz(double consultarNum1)
        {
            throw new NotImplementedException();
        }
    }//fim da classe
}//fim do projeto      
              
    
           



