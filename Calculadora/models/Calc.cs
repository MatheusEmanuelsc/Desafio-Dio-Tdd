using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.models
{
    public class Calc
    {
        
        public int Soma (int valor1 , int valor2){
            return valor1 + valor2;
        }

        public int Sub (int valor1 , int valor2){
            return valor1 - valor2;
        }

        public int Mult (int valor1 , int valor2){
            return valor1 * valor2;
        }

        public int Div (int valor1 , int valor2){
            return valor1 / valor2;
        }
    }
}