using CGLab69.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;

namespace CGLab69.models
{

    public enum Projections { Perspective, Isometric, Trimetric, Dimetric }

    /// <summary>
    /// Многогранник
    /// </summary>
    /// 
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

        public void AddEdges(Point3D point, List<Point3D> other)
        {
            foreach (var p in other)
                AddEdge(point, p);
        }

        public Polyhedron useProjection(Projections projection)
        {
            double[,] projMatrix;
            switch (projection)
            {
                case Projections.Perspective:
                    double[,] pers = {
                    { 1, 0, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 0, 0, 0.001},
                    { 0, 0, 0, 1 }
                    };
                    projMatrix = pers;
                    break;
                case Projections.Isometric:
                    double[,] isom = {
                    { 0.707, -0.408, 0, 0 },
                    { 0, 0.816, 0, 0 },
                    { -0.707, -0.408, 0, 0 },
                    { 0, 0, 0, 1 }};
                    projMatrix = isom;
                    break;
                case Projections.Dimetric:
                    double[,] dim = {
                    { 0.935, -0.118, 0, 0 },
                    { 0, 0.943, 0, 0 },
                    { -0.354, -0.312, 0, 0 },
                    { 0, 0, 0, 1 }
                    };
                    projMatrix = dim;
                    break;
                case Projections.Trimetric:
                    double[,] trim = {
                    { -Math.Sqrt(2)/2, (-Math.Sqrt(2)/2)*(1/2), 0, 0 },
                    { 0, Math.Sqrt(3)/2, 0, 0 },
                    { -Math.Sqrt(2)/2, -(-Math.Sqrt(2)/2)*(Math.Sqrt(3)/2), 0, 0 },
                    { 0, 0, 0, 1 }
                    };
                    projMatrix = trim;
                    break;
                default:
                    double[,] pers1 = {
                    { 1, 0, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 0, 0, 0.001},
                    { 0, 0, 0, 1 }
                    };
                    projMatrix = pers1;
                    break;
            }
            Polyhedron result = new Polyhedron();
            foreach (var val in AdjacencyMatrix)
            {
                var matr = new double[,] { { val.Key.X, val.Key.Y, val.Key.Z, 1 } };
                var mult = MatrixHelpers.multiply(matr, projMatrix);
                var startPoint = new Point3D(mult[0, 0] / mult[0, 3], mult[0, 1] / mult[0, 3], 0);

                foreach (var v in val.Value)
                {
                    matr = new double[,] { { v.X, v.Y, v.Z, 1 } };
                    mult = MatrixHelpers.multiply(matr, projMatrix);
                    var endPoint = new Point3D(mult[0, 0] / mult[0, 3], mult[0, 1] / mult[0, 3], 0);
                    result.AddEdge(startPoint, endPoint);
                }
            }
            return result;
        }
    }
}
