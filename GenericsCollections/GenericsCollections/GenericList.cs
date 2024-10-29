namespace GenericsCollections;
class GenericList<T>
{
    T[] _arr = [];
    public void Add(T item)
    {
        Array.Resize(ref _arr, _arr.Length + 1);
        _arr[^1] = item;
    }
    public void PrintArr()
    {
        foreach (var item in _arr)
        {
            Console.WriteLine(item);
        }
    }
    public string GetName()
    {
        return "";
    }
}
class GenericList<T, U> 
    where T : class, new()
    where U : class
{
    T[] _arr = [];
    public void Add(T item)
    {
        T t1 = new T();
        //Array.Resize(ref _arr, _arr.Length + 1);
        //_arr[^1] = item;
    }
    public void PrintArr()
    {
        foreach (var item in _arr)
        {
            Console.WriteLine(item);
        }
    }
}

class GenericList<T, u, z>
{
    T[] _arr = [];
    public void Add(T item)
    {
        Array.Resize(ref _arr, _arr.Length + 1);
        _arr[^1] = item;
    }
    public void PrintArr()
    {
        foreach (var item in _arr)
        {
            Console.WriteLine(item);
        }
    }
}
