using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Collections
{
    public class Library<T>: IEnumerable<T>
    {
        private int count = 0;
        private T[] books = new T[5];
        public int Count => count;
        public void Add(T book)
        {
            if (count >= books.Length)
            {
                Array.Resize(ref books, books.Length * 2);
            }
            books[count] = book;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
