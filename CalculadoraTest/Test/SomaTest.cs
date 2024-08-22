using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.models;

namespace CalculadoraTest.Test
{
    public class SomaTest
    {
        private Calc _calculadora;

        public SomaTest()
        {
            _calculadora = new Calc();
        }

        [Fact]
        public void DeveRetornaSoma()
        {
            // Given
            int num1 =2;
            int num2 = 2;
        
            // When
            var resultado = _calculadora.Soma(num1,num2);
            // Then
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void DeveRetornaSubtrair()
        {
            // Given
            int num1 =2;
            int num2 = 2;
        
            // When
            var resultado = _calculadora.Sub(num1,num2);
            // Then
            Assert.Equal(0, resultado);
        }

        [Fact]
        public void DeveRetornaMultiplicar()
        {
            // Given
            int num1 =2;
            int num2 = 2;
        
            // When
            var resultado = _calculadora.Mult(num1,num2);
            // Then
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void DeveRetornaDividir()
        {
            // Given
            int num1 =2;
            int num2 = 2;
        
            // When
            var resultado = _calculadora.Div(num1,num2);
            // Then
            Assert.Equal(1, resultado);
        }
    }
}