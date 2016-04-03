using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pprg
{
    public class Node
    {
        public string name;
        public bool discovered;
        public List<Edge> neighbours;

        public Node(string name)
        {
            this.name = name;
            this.neighbours = new List<Edge>();
        }

        public void AddNeighbourReverse(Edge e)
        {
            neighbours.Add(e);
            // also add reverse neighbour
            var self = this;
            e.neighbour.AddNeighbour(new Edge(ref self, e.weight));
        }

        public void AddNeighbour(Edge e)
        {
            neighbours.Add(e);
        }

    }
}
