using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Media3D;

namespace CGLab69.models
{
    /// <summary>
    /// Октаэдр
    /// </summary>
    class Octahedron : Polyhedron
    {
        Point3D a = new Point3D(0, 0, 0);
        Point3D b = new Point3D(300, 300, 0);
        Point3D c = new Point3D(-300, 300, 0);
        Point3D d = new Point3D(0, 300, -300);
        Point3D e = new Point3D(0, 300, 300);
        Point3D f = new Point3D(0, 600, 0);

        public Octahedron() : base()
        {
            AddEdges(a, new List<Point3D> { b, d, c, e });
            AddEdges(b, new List<Point3D> { d });
            AddEdges(c, new List<Point3D> { e });
            AddEdges(d, new List<Point3D> { c });
            AddEdges(e, new List<Point3D> { b });
            AddEdges(f, new List<Point3D> { b, d, c, e });



            AddFace(new List<Point3D> { a, b, d });
            AddFace(new List<Point3D> { a, d, c });
            AddFace(new List<Point3D> { a, c, e });
            AddFace(new List<Point3D> { a, b, e });

            AddFace(new List<Point3D> { f, b, d });
            AddFace(new List<Point3D> { f, d, c });
            AddFace(new List<Point3D> { f, c, e });
            AddFace(new List<Point3D> { f, b, e });
        }

        public Octahedron(List<Point3D> points) : base()
        {
            a = points[0];
            b = points[1];
            c = points[3];
            d = points[2];
            e = points[4];
            f = points[5];

            AddEdges(a, new List<Point3D> { b, d, c, e });
            AddEdges(b, new List<Point3D> { d });
            AddEdges(c, new List<Point3D> { e });
            AddEdges(d, new List<Point3D> { c });
            AddEdges(e, new List<Point3D> { b });
            AddEdges(f, new List<Point3D> { b, d, c, e });



            AddFace(new List<Point3D> { a, b, d });
            AddFace(new List<Point3D> { a, d, c });
            AddFace(new List<Point3D> { a, c, e });
            AddFace(new List<Point3D> { a, b, e });

            AddFace(new List<Point3D> { f, b, d });
            AddFace(new List<Point3D> { f, d, c });
            AddFace(new List<Point3D> { f, c, e });
            AddFace(new List<Point3D> { f, b, e });
        }
    }
}
