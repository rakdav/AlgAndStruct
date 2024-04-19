using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class GraphEdge
    {
        public GraphVertex ConnectedVertex { get; }
        public int EdgeWeight { get; }

        public GraphEdge(GraphVertex connectedVertex, int edgeWeight)
        {
            ConnectedVertex = connectedVertex;
            EdgeWeight = edgeWeight;
        }
    }
}
