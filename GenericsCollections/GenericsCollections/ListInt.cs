namespace GenericsCollections;
class ListAzTU
{
    object[] _arr = [];
    Type _type;
    public ListAzTU(Type type)
    {
        _type = type;
    }
    public void Add(object item)
    {
        if (item.GetType() == _type)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[^1] = item;
        }
        else
        {
            throw new TypeAccessException();
        }
    }
    public void PrintArr()
    {
        foreach (var item in _arr)
        {
            Console.WriteLine(item);
        }
    }
}
