using System.Collections;

namespace lesson26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(3, "qwe");
            list.Add(1, "asd");
            list.Add(2, "zxc");
            foreach (var i in list.Keys)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            SortedDictionary<int, string> d = new SortedDictionary<int, string>();
            d.Add(3, "qwe");
            d.Add(1, "asd");
            d.Add(2, "zxc");
            foreach(var i in d.Keys)
            {
                Console.WriteLine(i);
            }
            LinkedListNode<int> n;
            LinkedList<int> i = new LinkedList<int>();
        }
    }
}