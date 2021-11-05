using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Media3D;

namespace CGLab69.models
{
    /// <summary>
    /// Гексаэдр
    /// </summary>
    class Hexahedron : Polyhedron
    {
        Point3D a = new Point3D(0, 0, 0);
        Point3D b = new Point3D(300, 0, 0);
        Point3D c = new Point3D(300, 0, 300);
        Point3D d = new Point3D(0, 0, 300);
        Point3D e = new Point3D(0, 300, 0);
        Point3D f = new Point3D(300, 300, 0);
        Point3D g = new Point3D(300, 300, 300);
        Point3D h = new Point3D(0, 300, 300);

        public Hexahedron() : base()
        {
            AddEdges(a, new List<Point3D> { e, b });
            AddEdges(b, new List<Point3D> { f, c });
            AddEdges(c, new List<Point3D> { g, d });
            AddEdges(d, new List<Point3D> { a, h });
            AddEdges(e, new List<Point3D> { f });
            AddEdges(f, new List<Point3D> { g });
            AddEdges(g, new List<Point3D> { h });
            AddEdges(h, new List<Point3D> { e });
        }

        public Hexahedron(List<Point3D> points) : base()
        {
            a = points[0];
            b = points[1];
            c = points[2];
            d = points[3];
            e = points[4];
            f = points[5];
            g = points[6];
            h = points[7];

            AddEdges(a, new List<Point3D> { e, b });
            AddEdges(b, new List<Point3D> { f, c });
            AddEdges(c, new List<Point3D> { g, d });
            AddEdges(d, new List<Point3D> { a, h });
            AddEdges(e, new List<Point3D> { f });
            AddEdges(f, new List<Point3D> { g });
            AddEdges(g, new List<Point3D> { h });
            AddEdges(h, new List<Point3D> { e });
        }
    }
}
