using OrdenationWithDesignPattern.interfaces;

namespace OrdenationWithDesignPattern.utils
{
    public class SortUtils
    {
        private ISortStrategy? _iSortStrategy;

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _iSortStrategy = sortStrategy;
        }

        public int[] RunOrdenation(int[] array)
        {
            if (_iSortStrategy == null)
            {
                throw new InvalidOperationException("Sort strategy undefined.");
            }

            return _iSortStrategy.Sort(array);
        }

        public int[] GenerateRandomArray(int arraySize)
        {
            Random random = new Random();
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(arraySize);
            }

            Console.Write($"Array de tamanho {arraySize}: ");
            return array;
        }

        public void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Aperte ENTER para continuar...");
            Console.ReadLine();
        }
    }
}