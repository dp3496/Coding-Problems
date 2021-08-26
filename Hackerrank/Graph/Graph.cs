using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.Graph
{
    public class Graph
    {
        private readonly IDictionary<int, Node> _nodes = new Dictionary<int, Node>();

        public void Add(int item1, int item2, int cost)
        {
            var node1 = TryGetNode(item1);
            var node2 = TryGetNode(item2);

            var edge = new Edge(node1, node2, cost);
            node1.Edges.Add(edge);
        }

        public IList<Node> GetAllConnectedNodes(int item)
        {
            var node = TryGetNode(item);

            return node.Edges.Select(x => x.Item2).ToList();
        }

        public IList<Edge> GetAllConnectedEdges(int item)
        {
            var node = TryGetNode(item);

            return node.Edges;
        }

        private Node TryGetNode(int item)
        {
            if(_nodes.TryGetValue(item, out var node))
            {
               return node; 
            }

            var newNode = new Node(item);
            _nodes.Add(item, newNode);
            return newNode;
        }
    }

    public class Node
    {
        public Node(int item)
        {
            Current = item;    
        }

        public int Current { get; }

        public IList<Edge> Edges { get; set; } = new List<Edge>();


    }

    public class Edge
    {
        public Edge(Node item1, Node item2, int cost)
        {
            Cost = cost;
            Item1 = item1;
            Item2 = item2;
        }

        public int Cost { get; }

        public Node Item1 { get; }

        public Node Item2 { get; }
    }
}