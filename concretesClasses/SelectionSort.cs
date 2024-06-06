using System.Diagnostics;
using OrdenationWithDesignPattern.interfaces;
using OrdenationWithDesignPattern.utils;

namespace OrdenationWithDesignPattern.concretesClasses
{
    public class SelectionSort : ISortStrategy
    {
        public int[] Sort(int[] array)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var arrayLength = array.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (array[j] < array[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                var tempVar = array[smallestVal];
                array[smallestVal] = array[i];
                array[i] = tempVar;
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