using System;
using System.Collections.Generic;

namespace LargeDataCollectionDemo
{
    public class LargeDataCollection : IDisposable
    {
        private List<object> data;

        public LargeDataCollection(IEnumerable<object> initialData)
        {
            data = new List<object>(initialData);
        }

        public void Add(object item)
        {
            data.Add(item);
        }

        public void Remove(object item)
        {
            data.Remove(item);
        }

        public object GetAt(int index)
        {
            return data[index];
        }

        public void Dispose()
        {
            data.Clear();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new LargeDataCollection instance and populate it with some data.
            LargeDataCollection collection = new LargeDataCollection(new List<object>() { 1, 2, 3, "Hello, world!", new object() });

            // Add an element to the collection.
            collection.Add(4);

            // Remove an element from the collection.
            collection.Remove(2);

            // Get an element from the collection.
            object element = collection.GetAt(2);

            // Dispose of the collection to release any unmanaged resources.
            collection.Dispose();
        }
    }
}