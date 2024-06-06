using System.Diagnostics;
using OrdenationWithDesignPattern.interfaces;
using OrdenationWithDesignPattern.utils;

namespace OrdenationWithDesignPattern.concretesClasses
{
    public class QuickSort : ISortStrategy
    {
        public int[] Sort(int[] array) {
            if (array == null || array.Length == 0) {
                return [];
            }
            Stopwatch stopwatch = Stopwatch.StartNew();
            InternSort(array, 0, array.Length - 1);

            TimeSpan tempoDecorrido = stopwatch.Elapsed;
            stopwatch.Stop();
            Console.WriteLine("Esse método levou " + tempoDecorrido + " milésimos de segundos para ser executado!");
            return array;
        }

        private void InternSort(int[] array, int leftIndex, int rightIndex) {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j) {
                while (array[i] < pivot) {
                    i++;
                }

                while (array[j] > pivot) {
                    j--;
                }
                if (i <= j) {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                InternSort(array, leftIndex, j);
            if (i < rightIndex)
                InternSort(array, i, rightIndex);
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