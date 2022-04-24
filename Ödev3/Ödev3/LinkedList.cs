using System;
using System.Collections.Generic;
using System.Text;

namespace Ödev3
{
    public class LinkedList<T>
    {
        // Başlangıç düğümü.
        private Node<T> Head = null;

        // Listedeki toplam boğum sayısıdır. Dışarıdan sadece değerine ulaşılabilir, değiştirilemez.
        private int count = 0;
        public int Count
        {
            get { return count; }
        }

        // İlk boğumu gönderir.
        public Node<T> First()
        {
            return Head;
        }

        // Listeye eklenecek değer, parametre olarak alınarak listenin sonuna eklenir.
        public void InsertLast(T item)
        {
            Node<T> oldLast = Head;
            Node<T> newLast = new Node<T>();
            newLast.Value = item;
            if (Head == null)
            {
                Head = newLast;
            }
            else
            {
                while (oldLast != null)
                {
                    if (oldLast.Next != null)
                        oldLast = oldLast.Next;
                    else
                        break;
                }
                oldLast.Next = newLast;
            }
            count++;
        }

        // İlk boğumu listeden siler.
        public Node<T> RemoveFirst()
        {
            Node<T> item;
            item = Head;
            if (Head.Next == null)
            {
                Head = null;
            }
            else
            {
                Head = Head.Next;
            }
            count--;
            return item;
        }
        // İstenilen pozisyondaki boğumu listeden siler.
        public void RemoveAt(int position)
        {
            Node<T> item = Head;
            for (int i = 0; i < Count; i++)
            {
                if (position == 0)
                {
                    RemoveFirst();
                    break;
                }
                else if (i == position - 1)
                {
                    item.Next = item.Next.Next;
                    count--;
                    break;
                }
                item = item.Next;
            }
        }

        // İstenilen pozisyondaki boğumu gönderir.
        public Node<T> Get(int position)
        {
            Node<T> item = Head;
            for (int i = 0; i < position; i++)
            {
                item = item.Next;
            }
            return item;
        }
    }
}
