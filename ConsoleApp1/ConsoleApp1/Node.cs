using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node<T>
    {
        private T info;
        private Node<T> seguent;

        public Node(T info)
        {
            this.info = info;
            this.seguent = null;
        }
        public Node()
        {
            this.info = default;
            this.seguent = null;
        }
        public T Info { get => info; set => info = value; }
        public Node<T> Seguent { get => seguent; set => seguent = value; }
    }
}
