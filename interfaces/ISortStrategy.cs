namespace OrdenationWithDesignPattern.interfaces
{
    public interface ISortStrategy
    {
        public int[] Sort(int[] array);

        public void GenerateRandomArrayAndSort();
    }
}