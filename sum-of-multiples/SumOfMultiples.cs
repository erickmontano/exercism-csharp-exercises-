public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> items, int level)
    {
        HashSet<int> uniqueItemValues = [];
        
        foreach (int item in items)
        {
            if(item > 0)
                uniqueItemValues.UnionWith(GetItemMultiples(item, level));
        }
        return uniqueItemValues.Sum();
    }

    private static IEnumerable<int> GetItemMultiples(int item, int level)
    {
        for (int i = 1; i * item < level; i++)
        {
            yield return i * item;
        }
    }
}