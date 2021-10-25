using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int age;
        private string name;

        private List<Node> children = new List<Node>();

        public int Age {
            get
            {
                return this.age;
            }
        }

        public string Name {
            get
            {
                return this.name;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
    }
}
