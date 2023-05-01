namespace StrategyPattern.SortStrategies;
public class InsertionSortStrategy : ISortStrategy
{
    public void SortArray(int[] array)
    {
        if (array == null)
        {
            return;
        }
        for (int i = 1; i < array.Length; i++)
        {
            int j = i - 1;
            int key = array[i];
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }
}
