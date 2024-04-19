using Graphs;

//Graph graph = new Graph();
//graph.AddVertex("Калининград");
//graph.AddVertex("Гурьевск");
//graph.AddEdge("Калининград", "Гурьевск", 20);
//foreach(var v in graph.Vertices)
//{
//    Console.WriteLine(v+" "+v.Edges.Count);
//}

var g = new Graph();
g.AddVertex("1");
g.AddVertex("2");
g.AddVertex("3");
g.AddVertex("4");
g.AddVertex("5");
g.AddVertex("6");

g.AddEdge("1", "2", 7);
g.AddEdge("1", "6", 14);
g.AddEdge("1", "3", 9);
g.AddEdge("2", "4", 15);
g.AddEdge("2", "3", 10);
g.AddEdge("3", "6", 2);
g.AddEdge("3", "4", 11);
g.AddEdge("4", "5", 6);
g.AddEdge("5", "6", 9);

var diestra = new Dijkstra(g);
var path = diestra.FindShortestPath("1", "5");
Console.WriteLine(path);
