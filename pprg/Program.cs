using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pprg
{
    public class Program
    {
        public static IList<Edge> edges = new List<Edge>();

        static void Main(string[] args)
        {
            // https://msdn.microsoft.com/en-us/library/aa289152(v=vs.71).aspx

            // Define cities
            Node wien = new Node("Wien");
            Node linz = new Node("Linz");
            Node stpoelten = new Node("St. Pölten");
            Node graz = new Node("Graz");
            Node villach = new Node("Villach");
            Node innsbruck = new Node("Innsbruck");
            Node bregenz = new Node("Bregenz");
            Node salzbrug = new Node("Salzbrug");

            // Define Edges
            /*wien.AddNeighbourReverse(new Edge(ref stpoelten, 3));
            wien.AddNeighbourReverse(new Edge(ref graz, 9));
            stpoelten.AddNeighbourReverse(new Edge(ref graz, 9));
            stpoelten.AddNeighbourReverse(new Edge(ref linz, 3));
            linz.AddNeighbourReverse(new Edge(ref graz, 10));
            linz.AddNeighbourReverse(new Edge(ref salzbrug, 5));
            salzbrug.AddNeighbourReverse(new Edge(ref villach, 6));
            salzbrug.AddNeighbourReverse(new Edge(ref innsbruck, 6));
            graz.AddNeighbourReverse(new Edge(ref villach, 4));
            innsbruck.AddNeighbourReverse(new Edge(ref bregenz, 6));*/

            wien.AddNeighbour(new Edge(ref stpoelten, 3));
            wien.AddNeighbour(new Edge(ref graz, 9));
            stpoelten.AddNeighbour(new Edge(ref graz, 9));
            stpoelten.AddNeighbour(new Edge(ref linz, 3));
            linz.AddNeighbour(new Edge(ref graz, 10));
            linz.AddNeighbour(new Edge(ref salzbrug, 5));
            salzbrug.AddNeighbour(new Edge(ref villach, 6));
            salzbrug.AddNeighbour(new Edge(ref innsbruck, 6));
            graz.AddNeighbour(new Edge(ref villach, 4));
            innsbruck.AddNeighbour(new Edge(ref bregenz, 6));

             NodeList list = new NodeList();
            list.Add(wien);
            list.Add(linz);
            list.Add(stpoelten);
            list.Add(graz);
            list.Add(villach);
            list.Add(innsbruck);
            list.Add(bregenz);
            list.Add(salzbrug);

            //Console.WriteLine("NodeList created");

            var startNode = list.Find("Wien");
            var destinationNode = list.Find("Bregenz");

            var sw = new Stopwatch();

            sw.Start();
            list.DepthFirstSearch(startNode, destinationNode);
            sw.Start();
            Console.WriteLine("DFS took {0}ms to find the destination", sw.ElapsedMilliseconds);

            list.clearVisited();
            sw.Reset();

            sw.Start();
            list.DepthFirstSearchRecursive(startNode, destinationNode);
            sw.Stop();
            Console.WriteLine("DFS-Recursive took {0}ms to find the destination", sw.ElapsedMilliseconds);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
}
}
