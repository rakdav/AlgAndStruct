using Graphs;

Graph graph = new Graph();
graph.AddVertex("Калининград");
graph.AddVertex("Гурьевск");
graph.AddEdge("Калининград", "Гурьевск", 20);
foreach(var v in graph.Vertices)
{
    Console.WriteLine(v+" "+v.Edges.Count);
}
