using CalculadoraApp.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTeste
    {
        private ValidacoesString _validacoesString;

        public ValidacoesStringTeste()
        {
            _validacoesString = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            // Arrange
            string texto = "Ola";

            // Act
            int resultado = _validacoesString.ContarCaracteres(texto);

            // Assert
            Assert.Equal(3, resultado);
        }
    }
}