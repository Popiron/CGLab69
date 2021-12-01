using CGLab69.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;

namespace CGLab69.models
{

    public enum Projections { Perspective, Isometric, Trimetric, Dimetric,}

    /// <summary>
    /// Многогранник
    /// </summary>
    /// 
    public class Polyhedron
    {
        /// <summary>
        /// Грани
        /// </summary>
        public List<Face> Faces { get; set; }

        /// <summary>
        /// Прямые (ребра)
        /// </summary>
        public virtual IEnumerable<Edge> Edges
        {
            get
            {
                foreach (var f in Faces)
                {
                    foreach (var e in f.Edges)
                    {
                        yield return e;
                    }
                }
            }
        }


        /// <summary>
        /// Вершины
        /// </summary>
        public virtual IEnumerable<Tuple<Point3D, Vector3D>> Vertices
        {
            get
            {
                foreach (var f in Faces)
                {
                    foreach (var e in f.Edges)
                    {
                        var adjacentFaces = Faces.Where(face => face.ContainsPoint(e.First)).ToList();
                        var sumVect = new Vector3D(0, 0, 0);
                        foreach (var face in adjacentFaces)
                            sumVect += face.NormalVec();
                        yield return new Tuple<Point3D, Vector3D>(e.First, sumVect / adjacentFaces.Count);
                    }
                }
            }
        }

        public Polyhedron()
        {
            Faces = new List<Face>();
        }

        public Polyhedron(List<Face> faces)
        {
            Faces = faces;
        }

        public void AddFace(Point3D[] points)
        {
            var side = new Face();
            for (int i = 0; i < points.Length - 1; i++)
            {

                side.AddEdge(new Edge(points[i], points[i + 1]));
            }
            side.AddEdge(new Edge(points.Last(), points.First()));
            Faces.Add(side);
        }

        public Point3D FigureCenter()
        {
            var x = Vertices.Average(point => point.Item1.X);
            var y = Vertices.Average(point => point.Item1.Y);
            var z = Vertices.Average(point => point.Item1.Z);
            return new Point3D(x, y, z);
        }

        public Polyhedron UseProjection(Projections projection)
        {
            Matrix3D projMatrix;
            switch (projection)
            {
                case Projections.Perspective:
                    projMatrix = new Matrix3D(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0.001, 0, 0, 0, 1);
                    break;
                case Projections.Isometric:
                    projMatrix = new Matrix3D(0.707,-0.408,0,0,0,0.816,0,0,-0.707,-0.408,0,0,0,0,0,1);
                    break;
                case Projections.Dimetric:
                    projMatrix = new Matrix3D(0.935,-0.118,0,0,0,0.943,0,0,-0.354,-0.312,0,0,0,0,0,1);
                    break;
                case Projections.Trimetric:
                    projMatrix = new Matrix3D(-Math.Sqrt(2) / 2, (-Math.Sqrt(2) / 2) * (1 / 2), 0, 0, 0, Math.Sqrt(3) / 2, 0, 0, -Math.Sqrt(2) / 2, -(-Math.Sqrt(2) / 2) * (Math.Sqrt(3) / 2), 0, 0, 0, 0, 0, 1);
                    break;
                default:
                    projMatrix = new Matrix3D(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0.001, 0, 0, 0, 1);
                    break;
            }

            return UseCustomProjection(projMatrix);

        }

        private Polyhedron UseCustomProjection(Matrix3D projMatrix)
        {
            Polyhedron newPoly = new Polyhedron(Faces.ConvertAll(face=>new Face(face.Edges.ConvertAll(edge=>new Edge(edge.First,edge.Second)).ToList())).ToList());
            foreach (var face in newPoly.Faces)
            {
                var edges = face.Edges;
                foreach (var edge in edges)
                {
                    edge.First = Transform(edge.First, projMatrix);
                    edge.Second = Transform(edge.Second, projMatrix);
                }
            }

            return newPoly;
        }
        private Point3D Transform(Point3D point, Matrix3D projMatrix)
        {
            var matr = new Matrix3D(point.X, point.Y, point.Z, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
            var mult = Matrix3D.Multiply(matr, projMatrix);
            var newPoint = new Point3D(mult.M11 / mult.M14, mult.M12 / mult.M14, 0);

            return newPoint;
        }

        public void Transform(Matrix3D projMatrix)
        {
            foreach (var face in Faces)
            {
                var edges = face.Edges;
                foreach (var edge in face.Edges)
                {
                    edge.First = MyTransform(edge.First, projMatrix);
                    edge.Second = MyTransform(edge.Second, projMatrix);
                }
            }
        }

        private Point3D MyTransform(Point3D point, Matrix3D projMatrix)
        {
            var matr = new Vector3D(point.X, point.Y, point.Z);
            var mult = Vector3D.Multiply(matr, projMatrix);
            var newPoint = new Point3D(mult.X, mult.Y, mult.Z);

            return newPoint;


        }

    }
}
