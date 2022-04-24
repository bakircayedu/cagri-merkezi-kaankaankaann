using System;
using System.Collections.Generic;
using System.Text;

namespace Ödev3
{
    public interface ILinkedList<T>
    {
        Node<T> First();
        void InsertLast(T item);
        Node<T> RemoveFirst();
        void RemoveAt(int position);
        Node<T> Get(int position);
    }
}
