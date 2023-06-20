using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson26
{
    internal class MyNode<T>
    {
        T Value;
        MyNode<T> Next;
        MyNode<T> Previous;
    }
}
