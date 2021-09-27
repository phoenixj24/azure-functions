using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDanielTorres
{
    public class MinStack
    {
        private Node root;

        public MinStack()
        {
            this.root = null;
        }

        public void Push(int value)
        {
            var node = new Node(value);
            if (this.root != null)
            {
                node.Min = Math.Min(this.root.Min, value);
            }
            else
            {
                node.Min = value;
            }
            node.Next = this.root;
            this.root = node;
        }

        public void Pop()
        {
            this.root = root.Next;
        }

        public int Top()
        {
            return this.root.Value;
        }

        public int GetMin()
        {
            return this.root.Min;
        }

        public class Node
        {
            public int Value { get; set; }
            public int Min { get; set; }
            public Node Next { get; set; }

            public Node(int value)
            {
                this.Value = value;
            }
        }
    }
}
