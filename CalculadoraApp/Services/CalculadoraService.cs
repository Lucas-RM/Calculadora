namespace CalculadoraApp.Services
{
    public class CalculadoraService
    {
        public int Somar(int num1, int num2)        
        {
            return num1 + num2;
        }

        public bool EhPar(int num)
        {
            return num % 2 == 0;
        }
    }
}