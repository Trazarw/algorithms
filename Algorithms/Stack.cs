using System;

namespace Algorithms
{
    public class Stack
    {
        private class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
        }

        private Node _head;

        public int Peek()
        {
            if (_head == null)
            {
                throw new InvalidOperationException();
            }
            return _head.Value;
        }

        public int Pop()
        {
            if (_head == null)
            {
                throw new InvalidOperationException();
            }

            int value = _head.Value;
            _head = _head.Next;
            return value;
        }

        public void Push(int value)
        {
            var node = new Node { Value = value };
            node.Next = _head;
            _head = node;
        }
    }
}
