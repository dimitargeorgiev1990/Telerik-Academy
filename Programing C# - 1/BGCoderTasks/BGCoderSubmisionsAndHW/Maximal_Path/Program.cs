using System;
using System.Collections.Generic;

namespace Maximal_Path
{
    public class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> childrens;
        public bool HasParrent { get; set; }

        public Node(T value)
            : this()
        {
            Value = value;
        }
        public Node()
        {
            childrens = new List<Node<T>>();
        }

        public void AddChildren(Node<T> children)
        {
            this.childrens.Add(children);
        }

        public Node<T> GetChildren(int index)
        {
            return childrens[index];
        }
    }

    class Program
    {
        private static long maxSum = 0;
        static HashSet<int> usedNodes = new HashSet<int>();
        static Dictionary<int, Node<int>> nodes = new Dictionary<int, Node<int>>();

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N-1; i++)
            {
                string[] connection = Console.ReadLine().Trim().Split(new char[] { ' ', '<', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                int parrentValue = int.Parse(connection[0]);
                int childValue = int.Parse(connection[1]);
                
                if (!nodes.ContainsKey(parrentValue))
                    nodes.Add(parrentValue, new Node<int>(parrentValue));
                if (!nodes.ContainsKey(childValue))
                    nodes.Add(childValue, new Node<int>(childValue));

                nodes[parrentValue].AddChildren(nodes[childValue]);
                nodes[childValue].AddChildren(nodes[parrentValue]);
            }

            foreach (var node in nodes.Values)
            {
                if (node.childrens.Count == 1) 
                {
                    usedNodes = new HashSet<int>();
                    DFS(node, 0);
                }
            }

            Console.WriteLine(maxSum);
        }

        private static void DFS(Node<int> node, long currSum) 
        {
            currSum += node.Value;
            usedNodes.Add(node.Value);

            foreach (var child in node.childrens)
            {
                if (!usedNodes.Contains(child.Value))
                    DFS(child, currSum);          
            }

            if (node.childrens.Count <= 1)
            {
                if (currSum > maxSum)
                    maxSum = currSum;
                return;
            }
        }
    }
}
