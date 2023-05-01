namespace StrategyPattern;
public class ArraySorter
{
    private ISortStrategy _strategy;

    public ISortStrategy Strategy
    {
        get => _strategy;
        set => _strategy = value;
    }

    public ArraySorter(ISortStrategy strategy) => _strategy = strategy;

    public void Sort(int[] arr)
    {
        _strategy.SortArray(arr);
    }
}