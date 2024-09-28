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
    }
}