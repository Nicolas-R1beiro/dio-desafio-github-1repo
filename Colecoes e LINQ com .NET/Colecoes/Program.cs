using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilhaLivros = new Stack<string>();

            pilhaLivros.Push(".NET");
            pilhaLivros.Push("DDD");
            pilhaLivros.Push("Codigo Limpo");

            System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count} ");

            while(pilhaLivros.Count > 0)
            {
                System.Console.WriteLine($"Proximo livro para a leitura: {pilhaLivros.Peek()}");
                System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            }

            System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count} ");

//======================================================================== 
            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Nicolas");
            // fila.Enqueue("Vitoria");
            // fila.Enqueue("Gabriel");
    
            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // while(fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

//======================================================================== 
            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>{"SP", "MG", "BA"};
            // string[] estadosArray = new string[2] {"SC", "MT"};

            // System.Console.WriteLine("Quantidade de elementos na lista: {0}", estados.Count);
            
            // opLista.ImprimirListarString(estados);

            // // System.Console.WriteLine("Removendo o elemento...");
            // // estados.Remove("MG");

            // //estados.AddRange(estadosArray);
            // estados.Insert(1, "RJ");

            // opLista.ImprimirListarString(estados);

//======================================================================== 
            // OperacoesArray op = new OperacoesArray();

            // int[] array = new int[5] { 6, 3, 8, 1, 9};
            // int[] arrayCopia = new int [10];
            // string[] arrayString = op.ConverterParaArrayString(array);

            // //int valorProcurado = 10;

            // System.Console.WriteLine($"Capacidade atual do Array: {array.Length}");

            // op.RedimensionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade atual do Array apos redimensionar: {array.Length}");

//======================================================================== 
            // int indice = op.ObterIndice(array, valorProcurado);

            // if(indice >-1)
            // {
            //     System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor nao existente no array");
            // }

//======================================================================== 
            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Nao encontrei o valor");
            // }

//======================================================================== 
            // bool todosMaiorQue = op.TodosMaiorQue(array,valorProcurado);

            // if(todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores sao maiores que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existe valores que nao sao maiores do que {0}", valorProcurado);
            // }

//========================================================================  
            // bool existe = op.Existe(array, valorProcurado);

            // if(existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Nao encontrei o valor: {0}", valorProcurado);
            // }

//========================================================================  
            //System.Console.WriteLine("Array Original:");
            //op.ImprimirArray(array);

            //op.OrdernarBubbleSort(ref array);
            //System.Console.WriteLine("Array Ordenado:");
            //op.ImprimirArray(array);

//========================================================================  
            // System.Console.WriteLine("Array antes da copia:");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array apos a copia:");
            // op.ImprimirArray(arrayCopia);

//========================================================================            
            // int[,] matriz = new int[4,2]
            // {
            //     { 8, 8 },
            //     { 10, 20 },
            //     { 50, 100 },
            //     { 90, 200}
            // };
            
            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }
            // }

//========================================================================
            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30");

            // System.Console.WriteLine("Percorrendo pelo for");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo pelo foreach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}