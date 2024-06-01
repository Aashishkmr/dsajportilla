using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace DSAlgo.Graphs
{
    public class Node
    {
        public int Id { get; set; }

        public string VisitState { get; set; }
        public Dictionary<Node, int> Adj { get; set; }

        public Node(int id)
        {
            Id = id;
            VisitState = "Unvisited";
            Adj = new Dictionary<Node, int>();
        }

        public Dictionary<Node, int> GetConnections()
        {
            return Adj;
        }
    }

    public class Graph
    {
        public Dictionary<int, Node> Nodes { get; set; } = new();
        public int NumOfVertices { get; set; }

        public void AddNode(int value)
        {
            var node = new Node(value);
            Nodes[value]= node;
        }

        public void AddEdge(int source, int destination, int weight = 0)
        {
            if (!Nodes.ContainsKey(source))
            {
                AddNode(source);
            }

            if (!Nodes.ContainsKey(destination))
            {
                AddNode(destination);
            }

            Nodes[source].Adj[Nodes[destination]] = weight;
        }

        public static void DFS(Graph graph, int start)
        {
            var visited = new HashSet<int>();
            var stack = new List<int> { start };
            while (stack.Count() > 0)
            {
                //Get the current node
                var currentVertex = stack[stack.Count - 1];
                //Remove it from stack 
                stack.RemoveAt(stack.Count - 1);
                if (!visited.Contains(currentVertex))
                {
                    //Add it to visited
                    visited.Add(currentVertex);
                    //Add current nodes neighbours to stack
                    var neighbours = graph.Nodes[currentVertex].Adj;
                    stack.AddRange(neighbours.Values);
                    foreach (var nbr in neighbours)
                    {
                        stack.Add(nbr.Key.Id);
                    }
                }
            }
            foreach(var node in visited)
            {
                Console.WriteLine(node);
            }
        }
    }

    
}
