using System.Diagnostics;
using OrdenationWithDesignPattern.interfaces;
using OrdenationWithDesignPattern.utils;

namespace OrdenationWithDesignPattern.concretesClasses
{

    public class InsertionSort : ISortStrategy
    {
        public int[] Sort(int[] array)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var n = array.Length;
            for (int i = 1; i < n; i++)
            {
                var key = array[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = key;
                    }
                    else flag = 1;
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