using System.Collections;

namespace GenericsCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region NonGeneric
            //ListAzTU list = new ListAzTU(typeof(int));
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add("Salam");
            ////list.Add(true);
            ////list.Add(typeof(Program));
            ////list.Add(new
            ////{
            ////    Name = "Salam"
            ////});
            //list.PrintArr();
            #endregion
            #region Generic
            //GenericList<Dog> list = new();
            //Animal a1 = new Animal();
            #endregion
            #region Collections
            //List<int> list = new List<int>();
            //LinkedList<int> l = new LinkedList<int>();
            //var node = l.AddLast(1);
            //l.AddLast(2);
            //l.AddLast(3);
            //l.AddAfter(node, 20);
            //Console.WriteLine(node.Previous.Value);
            //Stack<int> stack = new Stack<int>();
            //stack.Push(42);
            //stack.Push(22);
            //stack.Push(21);
            //stack.Push(19);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Queue<string> queue = new Queue<string>();
            ////queue.Enqueue("asdasd");
            //Console.WriteLine(queue[0]);
            //HashSet<string> set = new HashSet<string>();
            //Dictionary<string, string> di = new Dictionary<string, string>();
            //Dictionary<int, string> di2 = new Dictionary<int, string>();
            //di.Add("1", "Salam");
            //di.Add("2", "Aleykum");
            //foreach (var item in di.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
