using System.Diagnostics;
using OrdenationWithDesignPattern.interfaces;
using OrdenationWithDesignPattern.utils;

namespace OrdenationWithDesignPattern.concretesClasses
{
    public class BubbleSort : ISortStrategy
    {
        public int[] Sort(int[] array)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var n = array.Length;
            for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (array[j] > array[j + 1])
                {
                    var tempVar = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tempVar;
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