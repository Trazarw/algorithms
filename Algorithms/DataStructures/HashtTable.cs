using System;
using System.Linq;

namespace AlgorithmsAndDataStructures.DataStructures
{
    public class HashTable
    {
        private class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
        }

        private readonly int[] _arr;

        public HashTable(int n)
        {
            _arr = new int[n];
        }

        public int Get(string key)
        {
            int copy = _arr[GetHashCode(key)];
            _arr[GetHashCode(key)] = 0;
            return copy;
        }

        public int Peek(string key)
        {
            return _arr[GetHashCode(key)];
        }

        public void Insert(string key, int value)
        {
            _arr[GetHashCode(key)] = value;
        }

        private static int GetHashCode(string key)
        {
            return key.Select(x => (int) x).Sum() + key.Length;
        }
    }
}
