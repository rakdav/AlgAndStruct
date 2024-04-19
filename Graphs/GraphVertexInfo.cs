using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class GraphVertexInfo
    {
        public GraphVertex Vertex { get; set; }
        public bool IsUnvisited { get; set; }
        public int EdgesWeightSum { get; set; }
        public GraphVertex PreviusVertex { get; set; }
        public GraphVertexInfo(GraphVertex vertex)
        {
            Vertex = vertex;
            IsUnvisited = true;
            EdgesWeightSum = int.MaxValue;
            PreviusVertex = null;
        }
    }
}
