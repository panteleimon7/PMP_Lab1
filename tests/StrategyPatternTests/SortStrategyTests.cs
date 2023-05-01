namespace StrategyPatternTests;

[TestFixture]
internal class SortStrategyTests
{
    ISortStrategy[] sortStrategies;
    const int ARR_SIZE = 100;
    int[] testArr;

    [SetUp]
    public void SetUp()
    {
        sortStrategies = new ISortStrategy[2]
        {
            new InsertionSortStrategy(),
            new MergeSortStrategy()
        };
        testArr = new int[ARR_SIZE];
    }

    [TestCase(0)]
    [TestCase(1)]
    public void EmptyArrayTest(int sortStrategyID)
    {
        ISortStrategy cut = sortStrategies[sortStrategyID];

        int[] _emptyArr = Array.Empty<int>();

        cut.SortArray(_emptyArr);

        Assert.That(Array.Empty<int>(), Is.EqualTo(_emptyArr));

    }

    [TestCase(0)]
    [TestCase(1)]
    public void OneElementArrayTest(int sortStrategyID)
    {
        ISortStrategy cut = sortStrategies[sortStrategyID];
        int[] _oneElementArr = { int.MaxValue };

        cut.SortArray(_oneElementArr);

        Assert.That(_oneElementArr, Is.EqualTo(new int[] { int.MaxValue }));
    }

    [TestCase(0)]
    [TestCase(1)]
    public void NullArrayTest(int sortStrategyID)
    {
        ISortStrategy cut = sortStrategies[sortStrategyID];

        cut.SortArray(null);
        Assert.Pass();
    }

    [TestCase(0)]
    [TestCase(1)]
    public void DescendArrayTest(int sortStrategyID)
    {
        ISortStrategy cut = sortStrategies[sortStrategyID];

        for (int i = 0, j = ARR_SIZE; i < ARR_SIZE; i++)
        {
            testArr[i] = j--;
        }

        cut.SortArray(testArr);

        Assert.That(testArr, Is.Ordered);

    }

    [TestCase(0)]
    [TestCase(1)]
    public void SortedArrayTest(int sortStrategyID)
    {
        ISortStrategy cut = sortStrategies[sortStrategyID];

        for (int i = 0; i < ARR_SIZE; i++)
        {
            testArr[i] = i + 1;
        }

        cut.SortArray(testArr);

        Assert.That(testArr, Is.Ordered);

    }

    [TestCase(0)]
    [TestCase(1)]
    public void RandomArrayTest(int sortStrategyID)
    {
        ISortStrategy cut = sortStrategies[sortStrategyID];

        Random randomizer = new();
        for (int i = 0; i < ARR_SIZE; i++)
        {
            testArr[i] = randomizer.Next();
        }

        cut.SortArray(testArr);

        Assert.That(testArr, Is.Ordered);
    }

}

