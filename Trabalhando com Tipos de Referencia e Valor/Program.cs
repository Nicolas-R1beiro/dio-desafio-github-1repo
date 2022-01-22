using System;

public class Program
{
    static int Adicionar20(int num)
    {
        return num + 20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
        public static void Main()
    {
        // int a = 2;
        // a = Adicionar20(a);

        // System.Console.WriteLine($"O valor da variavel a é: {a} ");

        Pessoa p1 = new Pessoa();
        
        p1.Nome = "Nicolas";
        p1.Idade = 18;
        p1.Documento = "1234";

        TrocarNome(p1,"José");

        System.Console.WriteLine($"O novo nome é: {p1.Nome}");
    }
}
