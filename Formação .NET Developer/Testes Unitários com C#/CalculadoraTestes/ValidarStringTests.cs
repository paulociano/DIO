using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;
using Xunit;

namespace CalculadoraTestes
{
    public class ValidarStringTests
    {
        private ValidarString _valida;

        public ValidarStringTests()
        {
            _valida = new ValidarString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            //Arrange
            string texto = "Olá";

            //Act
            int resultado = _valida.ContarCaracteres(texto);

            //Assert
            Assert.Equal(3, resultado);

        }

        [Theory]
        [InlineData("Campanha")]
        [InlineData("Obra")]
        [InlineData("Adversário")]
        public void DeveContarCaracteresERetornar(string texto)
        {
            //Arrange

            //Act
            int resultado = _valida.ContarCaracteres(texto);

            //Assert
            Assert.Equal(texto.Length, resultado);

        }
    }
}