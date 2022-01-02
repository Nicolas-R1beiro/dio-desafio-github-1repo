namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public static void Somar(int x, int y)
        {
            System.Console.WriteLine($"Adicao: {x + y}");
        }
        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtracao: {x - y}");
        }
    }
}