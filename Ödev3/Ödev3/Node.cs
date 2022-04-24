using System;
using System.Collections.Generic;
using System.Text;

namespace Ödev3
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Value { get; set; }
    }
}
