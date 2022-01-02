using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    public class Program
    {
        static void Main(string [] args)
        {
            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste Instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            Aluno p1 = new Aluno("Nicolas", "Ribeiro", "Teste");
            p1.Apresentar();
        } 
    }
}