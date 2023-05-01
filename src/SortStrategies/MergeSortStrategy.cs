namespace StrategyPattern.SortStrategies;
public class MergeSortStrategy : ISortStrategy
{
    private void merge(int[] array, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;

        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i)
            L[i] = array[l + i];
        for (j = 0; j < n2; ++j)
            R[j] = array[m + 1 + j];


        i = 0;
        j = 0;

        int k = l;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                array[k] = L[i];
                i++;
            }
            else
            {
                array[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            array[k] = L[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            array[k] = R[j];
            j++;
            k++;
        }
    }

    private void mergeSort(int[] array, int l, int r)
    {
        if (l >= r) return;

        int m = (l + r) / 2;

        mergeSort(array, l, m);
        mergeSort(array, m + 1, r);

        merge(array, l, m, r);

    }

    public void SortArray(int[] array)
    {
        if (array == null)
        {
            return;
        }
        mergeSort(array, 0, array.Length - 1);
    }
}
