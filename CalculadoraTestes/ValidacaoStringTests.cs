using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacaoStringTests
    {
        private ValidacaoString _validaString;
        public ValidacaoStringTests()
        {
            _validaString = new ValidacaoString();
        }

        [Fact]
        public void DeveContarTamanhodaString_DeveRetornarTamanhoDaString()
        {
            //Arrange
            string texto = "Ola";

            //Act
            var resultado = _validaString.ContarCaracteres(texto);
            
            //Assert

            Assert.Equal(texto.Length, resultado);
        }
    }
}