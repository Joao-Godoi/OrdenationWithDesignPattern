using System.Diagnostics;
using OrdenationWithDesignPattern.interfaces;
using OrdenationWithDesignPattern.utils;

namespace OrdenationWithDesignPattern.concretesClasses
{
    public class ShellSort : ISortStrategy
    {
        public int[] Sort(int[] array)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int n = array.Length;
            
            for (int intervalo = n / 2; intervalo > 0; intervalo /= 2)
            {
                for (int i = intervalo; i < n; i += 1)
                {
                    int temp = array[i];
                    
                    int j;
                    for (j = i; j >= intervalo && array[j - intervalo] > temp; j -= intervalo)
                    {
                        array[j] = array[j - intervalo];
                    }
                    
                    array[j] = temp;
                }
            }
            TimeSpan tempoDecorrido = stopwatch.Elapsed;
            stopwatch.Stop();
            Console.WriteLine("Esse método levou " + tempoDecorrido + " milésimos de segundos para ser executado!");
            return array;
        }

        public void GenerateRandomArrayAndSort()
        {
            SortUtils arraySortUtils = new();

            Console.Write("Digite o tamanho da array: ");
            int arraySize = int.Parse(Console.ReadLine()!);
            
            int[] array = arraySortUtils.GenerateRandomArray(arraySize);
            int[] arrayOrdenado = Sort(array);

            arraySortUtils.PrintArray(arrayOrdenado);
        }
    }
}