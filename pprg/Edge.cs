using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pprg
{
    public class Edge
    {
        public Node neighbour;
        public int weight;

        public Edge(ref Node neighbour, int weight)
        {
            this.neighbour = neighbour;
            this.weight = weight;
        }
    }
}
