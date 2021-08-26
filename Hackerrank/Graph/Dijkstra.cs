using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.Graph
{
    public class Dijkstra
    {
        private readonly Graph _graph;
        private readonly IList<Data> _path = new List<Data>();
        private readonly IList<Data> _pathOrder = new List<Data>();

        public Dijkstra(Graph graph)
        {
            _graph = graph;
        }

        // public IList<Node> GetShortestPath(int item1, int item2)
        // {
        //     var edges = _graph.GetAllConnectedEdges(item1).OrderBy(x => x.Cost);
        // }

        // private BuildPathOrder()
        // {
        //     foreach (var edge in edges)
        //     {
        //         _pathOrder.Add(new Data{ ReachedNode = edge.Item2, FromNode = edge.Item1});
        //     }
        // }

        public class Data
        {
            public Node ReachedNode { get; set; }

            public Node FromNode { get; set; }
        }
    }
}