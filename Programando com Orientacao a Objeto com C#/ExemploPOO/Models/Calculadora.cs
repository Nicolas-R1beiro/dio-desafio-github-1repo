using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
        public int somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int subtrair(int num1, int num2)
        {
            return num1-num2;
        }
    }
}