using System;
using System.Collections.Generic;
using System.Text;

namespace CGLab69.models
{
    /// <summary>
    /// Многоугольник (грань)
    /// </summary>
    public class Face
    {
        /// <summary>
        /// Прямые (ребра)
        /// </summary>
        public List<Edge> Edges { get; }

        public Face()
        {
            Edges = new List<Edge>();
        }

        public Face(IEnumerable<Edge> edges)
        {
            Edges = new List<Edge>();
            Edges.AddRange(edges);
        }

        public void AddEdge(Edge edge)
        {
            Edges.Add(edge);
        }
    }
}
