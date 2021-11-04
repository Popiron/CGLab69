using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;

namespace CGLab69.models
{
    /// <summary>
    /// Многогранник
    /// </summary>
    public class Polyhedron
    {
        /// <summary>
        /// Прямые (ребра)
        /// </summary>
        public List<Edge> Edges { get; }
        /// <summary>
        /// Вершины
        /// </summary>
        public List<Point3D> Vertices { get; set; }
        /// <summary>
        /// Матрица смежности
        /// </summary>
        public Dictionary<Point3D, List<Point3D>> AdjacencyMatrix { get; }

        public Polyhedron()
        {
            Edges = new List<Edge>();
            Vertices = new List<Point3D>();
            AdjacencyMatrix = new Dictionary<Point3D, List<Point3D>>();
        }

        public Polyhedron(List<Point3D> points) : this()
        {
            Vertices = points;
            foreach (var p in points)
                AdjacencyMatrix.Add(p, new List<Point3D>());
        }

        public void AddEdge(Point3D p1, Point3D p2)
        {
            if (!Vertices.Contains(p1))
                Vertices.Add(p1);
            if (!Vertices.Contains(p2))
                Vertices.Add(p2);
            if (!Edges.Contains(new Edge(p1, p2)))
                Edges.Add(new Edge(p1, p2));
            if (!AdjacencyMatrix.ContainsKey(p1))
                AdjacencyMatrix.Add(p1, new List<Point3D> { p2 });
            else
                AdjacencyMatrix[p1].Add(p2);

        }

        public void AddEdges(Point3D startPoint, List<Point3D> pointsList)
        {
            foreach (var point in pointsList)
                AddEdge(startPoint, point);
        }

        public Point3D Center()
        {
            var x = Vertices.Average(point => point.X);
            var y = Vertices.Average(point => point.Y);
            var z = Vertices.Average(point => point.Z);
            return new Point3D(x, y, z);
        }

    }
}
