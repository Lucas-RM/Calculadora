using CalculadoraApp.Services;

namespace CalculadoraTestes
{
    public class CalculadoraTeste
    {
        private CalculadoraService _calculadora;

        public CalculadoraTeste()
        {   
            _calculadora = new CalculadoraService();
        }

        [Fact]
        public void DeveSomar5Com10ERetornar15()
        {
            //Arrange
            int num1 = 5;
            int num2 = 10;

            //Act
            int resultado = _calculadora.Somar(num1, num2);

            //Assert
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void DeveSomar10Com10ERetornar20()
        {
            //Arrange
            int num1 = 10;
            int num2 = 10;

            //Act
            int resultado = _calculadora.Somar(num1, num2);

            //Assert
            Assert.Equal(20, resultado);
        }

        [Fact]
        public void DeveVerificarSe4EhParERetornarVerdadeiro()
        {
            // Arrange
            int numero = 4;

            // Act
            bool resultado = _calculadora.EhPar(numero);

            // Assert
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(new int[] { 2, 4 })]
        [InlineData(new int[] { 6, 8, 10 })]
        public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
        {
            // Act / Assert
            Assert.All(numeros, num => Assert.True(_calculadora.EhPar(num)));
        }
    }
}