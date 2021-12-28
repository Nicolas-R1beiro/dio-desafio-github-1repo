using System;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using System.IO;
namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "E:\\PC\\Documentos\\Curso git\\dio\\dio-desafio-github-1repo\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
            
            var listaString = new List<string> {"linha 1", "linha 2", "linha 3"};
            var listaStringContinuacao = new List<string> {"linha 4", "linha 5", "linha 6"};

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Ola! Teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo,novoCaminhoArquivo);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

//===========================================================================
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.somar(10,20));

//===========================================================================
            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString()); 

//===========================================================================
            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();

//===========================================================================
            // Calculadora cal = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " +cal.Somar(10,10));
            // System.Console.WriteLine("Resultado da segunda soma: " +cal.Somar(10,10,10));

//===========================================================================
            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Documento = "123456";
            // p1.Nota = 10;
            // p1.Apresentar();
            
            // Professor p2 = new Professor();
            // p2.Nome = "Leo";
            // p2.Idade = 20;
            // p2.Documento = "123456";
            // p2.Salario = 1000;
            // p2.Apresentar();

//===========================================================================
            // Valores Validos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);
            
            // System.Console.WriteLine($"Area: {r.ObterArea()}");

            // // Valores Invalidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,0);
            
            // System.Console.WriteLine($"Area: {r2.ObterArea()}");

//===========================================================================

            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            
            // p1.Apresentar();
        }
    }
}
