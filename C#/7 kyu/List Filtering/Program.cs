public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> list = new List<int>();
        foreach (var item in listOfItems)
        {
            if (item is int) list.Add((int)item);
        }
        return list;
    }
}
