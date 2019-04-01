using System;

namespace AlgorithmsAndDataStructures.DataStructures
{
    public class BinarySearchTreeNode
    {
        public int Value { get; set; }
        private BinarySearchTreeNode Left { get; set; }
        private BinarySearchTreeNode Right { get; set; }

        public void Insert(int value)
        {
            if (value < Value)
            {
                if (Left == null)
                {
                    Left = new BinarySearchTreeNode { Value = value };
                    return;
                }
                Left.Insert(value);
            }
            else
            {
                if (Right == null)
                {
                    Right = new BinarySearchTreeNode { Value = value };
                    return;
                }
                Right.Insert(value);
            }
        }

        public bool Contains(int value)
        {
            if (Value == value) return true;
            if (Left == null) return false;
            if (value < Value) return Left.Contains(value);
            if (Right == null) return false;
            return Right.Contains(value);
        }

        public void PrintInOrder()
        {
            if (Left != null) Left.PrintInOrder();
            Console.WriteLine(Value);
            if(Right != null) Right.PrintInOrder();
        }

        public void PrintPreOrder()
        {
            Console.WriteLine(Value);
            if (Left != null) Left.PrintInOrder();
            if (Right != null) Right.PrintInOrder();
        }

        public void PrintPostOrder()
        {
            if (Left != null) Left.PrintInOrder();
            if (Right != null) Right.PrintInOrder();
            Console.WriteLine(Value);
        }
    }
}
