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
            //Act
            //Assert
        }
    }
}