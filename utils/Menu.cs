using OrdenationWithDesignPattern.concretesClasses;
using OrdenationWithDesignPattern.interfaces;

namespace OrdenationWithDesignPattern.utils
{
    public class Menu
    {
        public void ShowMenu()
        {
            int option;
            do
            {
                Console.Clear();
                
                Console.WriteLine("1 - Quick sort");
                Console.WriteLine("2 - Bubble sorte");
                Console.WriteLine("3 - Selection sort");
                Console.WriteLine("4 - insertion sort ");
                Console.WriteLine("5 - Shell sort");
                Console.WriteLine("0 - Sair do programa");
                Console.Write("Opção: ");
                option = int.Parse(Console.ReadLine()!);
                
                switch (option)
                {
                    case 1:
                        ISortStrategy quickSort = new QuickSort();
                        quickSort.GenerateRandomArrayAndSort();
                        break;
                    case 2:
                        ISortStrategy boubleSort = new BubbleSort();
                        boubleSort.GenerateRandomArrayAndSort();
                        break;
                    case 3:
                        ISortStrategy selectionSort = new SelectionSort();
                        selectionSort.GenerateRandomArrayAndSort();
                        break;
                    case 4:
                        ISortStrategy insertionSort = new InsertionSort();
                        insertionSort.GenerateRandomArrayAndSort();
                        break;
                    case 5:
                        ISortStrategy shellSort = new ShellSort();
                        shellSort.GenerateRandomArrayAndSort();
                        break;
                    default:
                        return;
                }

            } while (option != 0);
        }
    }
}