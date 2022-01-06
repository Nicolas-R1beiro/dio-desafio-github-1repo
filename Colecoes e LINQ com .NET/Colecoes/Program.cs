using Colecoes.Helper;

namespace Colecoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5] { 6, 3, 8, 1, 9};
            int[] arrayCopia = new int [10];
            string[] arrayString = op.ConverterParaArrayString(array);

            //int valorProcurado = 10;

            System.Console.WriteLine($"Capacidade atual do Array: {array.Length}");

            op.RedimensionarArray(ref array, array.Length * 2);

            System.Console.WriteLine($"Capacidade atual do Array apos redimensionar: {array.Length}");

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