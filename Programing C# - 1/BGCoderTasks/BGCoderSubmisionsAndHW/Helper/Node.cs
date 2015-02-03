using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> childrens;
        public bool HasParrent { get; set; }

        public Node(T value):this()
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
}
