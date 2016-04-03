using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pprg
{
    public class NodeList
    {
        private IList<Node> nodes;
        private IList<String> visited;

        public NodeList()
        {
            this.nodes = new List<Node>();
            this.visited = new List<String>();
        }

        public void Add(Node n)
        {
            this.nodes.Add(n);
        }

        public Node Find(string name)
        {
            return this.nodes.SingleOrDefault(x => x.name == name);
        }

        public void DepthFirstSearch(Node startNode, Node destinationNode)
        {
            Console.WriteLine("starting at : {0}", startNode.name);
            Console.WriteLine("looking for: {0}", destinationNode.name);

            Stack<Node> stack = new Stack<Node>();
            stack.Push(startNode);
            while(stack.Count > 0)
            {
                Node item = stack.Pop();
                var discoverd = visited.SingleOrDefault(x => x == item.name);
                if(discoverd == null)
                {
                    visited.Add(item.name);
                    Console.WriteLine("VISITED: {0}", item.name);

                    foreach (Edge e in item.neighbours)
                    {
                        //Console.WriteLine("STACK: add {0}", e.neighbour.name);
                        stack.Push(e.neighbour);

                        if (e.neighbour.name == destinationNode.name)
                        {
                            Console.WriteLine("found destination");
                            return;
                        }
                    }
                }
                
            }

            Console.WriteLine("done");
        }
    }
}
