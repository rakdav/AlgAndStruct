using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Graph
    {
        public List<GraphVertex> Vertices { get; }
        public Graph()
        {
            Vertices = new List<GraphVertex>();
        }
        public void AddVertex(string name)
        {
            Vertices.Add(new GraphVertex(name));
        }
        public GraphVertex FindVertex(string name)
        {
            foreach (var v in Vertices) {
                if (v.Name.Equals(name)) return v;
            }
            return null;
        }
        public void AddEdge(string firstName,string secondName,int weight)
        {
            var v1 = FindVertex(firstName);
            var v2 = FindVertex(secondName);
            if (v2 != null && v1 != null)
            {
                v1.AddEdge(v2, weight);
                v2.AddEdge(v1, weight);
            }
        }
    }
}
