using System;

namespace AlgorithmsAndDataStructures
{
    public class Queue
    {
        private Node _head;
        private Node _tail;

        private class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
            public Node Previus { get; set; }
        }

        public void Enqueue(int value)
        {
            var node = new Node {Value = value};

            if (_head == null)
            {
                _head = node;
                _tail = node;
                return;
            }

            node.Next = _head;
            _head.Previus = node;
            _head = node;
        }

        public int Dequeue()
        {
            if (_tail == null)
            {
                throw new InvalidOperationException();
            }

            int value = _tail.Value;
            _tail = _tail.Previus;
            return value;
        }
    }
}
