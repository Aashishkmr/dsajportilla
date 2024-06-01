// See https://aka.ms/new-console-template for more information
using DSAlgo.Arrays;
using DSAlgo.Graphs;
using DSAlgo.SQD;

//Console.WriteLine("Arrays");
//ArrayRunner.StartArrayRunner();

//Console.WriteLine("Stacks, Queues and Deques");
//SQDRunner.RunStacks();

//SQDRunner.RunQueue();

//SQDRunner.RunDeQueue();

Graph graph = new();
graph.AddNode(1);
graph.AddNode(2);
graph.AddEdge(1, 4, 5);
graph.AddEdge(1, 2, 5);
graph.AddEdge(2, 3, 6);
graph.AddEdge(2, 5, 6);

Graph.DFS(graph, 1);