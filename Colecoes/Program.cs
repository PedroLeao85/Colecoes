using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] { 6, 3, 8, 1, 9 };
            int[] arrayCopia = new int[10];

            int valorProcurado = 0;
            bool todosMaiorQue = op.todosMaiorQue(array, valorProcurado);

            if(todosMaiorQue)
            {
                System.Console.WriteLine("Todos os valores são maiores que: {0} ", valorProcurado);
            }
            else
            {
                System.Console.WriteLine("Existe valores que não são maiores que {0}", valorProcurado);
            }
            
            
            // int valorProcurado = 10;
            // bool Existe = op.Existe(array, valorProcurado);

            // if(Existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            // }
            
            //System.Console.WriteLine("Array original: ");
            //op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);  

            //System.Console.WriteLine("Array Ordenado");
            //op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia");
            // op.ImprimirArray(arrayCopia);
            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a cópia");
            // op.ImprimirArray(arrayCopia);
            
            // int [,] matriz = new int [4,2]
            // {
            //     { 8, 8 },
            //     { 10, 2 },
            //     { 3, 4 },
            //     { 50 , 100}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j< matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i,j]);
            //     }
            // }

            
            
            
            // int[] arrayInteiros = new int [3];

            // arrayInteiros[0] = 15;
            // arrayInteiros[1] = 10;
            // arrayInteiros[2] = int.Parse("30");
            // arrayInteiros[3] = 30;

            // System.Console.WriteLine("Percorrendo o array pelo For");
            // for (int i = 0 ; i < arrayInteiros.Length ; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }
            // System.Console.WriteLine("Percorrendo o array pelo ForEach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}

