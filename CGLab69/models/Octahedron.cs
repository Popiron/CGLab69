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
        Point3D a = new Point3D(0, 0, 300);
        Point3D b = new Point3D(300, 300, 0);
        Point3D c = new Point3D(-300, 300, 0);
        Point3D d = new Point3D(-300, 300, 600);
        Point3D e = new Point3D(300, 300, 600);
        Point3D f = new Point3D(0, 600, 300);

        public Octahedron() : base()
        {
            AddEdges(a, new List<Point3D> { b, c, d, e });
            AddEdges(b, new List<Point3D> { c });
            AddEdges(c, new List<Point3D> { d });
            AddEdges(d, new List<Point3D> { e });
            AddEdges(e, new List<Point3D> { b });
            AddEdges(f, new List<Point3D> { b, c, d, e });



            AddFace(new List<Point3D> { a, b, c });
            AddFace(new List<Point3D> { a, c, d });
            AddFace(new List<Point3D> { a, d, e });
            AddFace(new List<Point3D> { a, e, b });

            AddFace(new List<Point3D> { f, c, b });
            AddFace(new List<Point3D> { f, d, c });
            AddFace(new List<Point3D> { f, e, d });
            AddFace(new List<Point3D> { f, b, e });
        }

        public Octahedron(List<Point3D> points) : base()
        {
            a = points[0];
            b = points[1];
            c = points[2];
            d = points[3];
            e = points[4];
            f = points[5];

            AddEdges(a, new List<Point3D> { b, c, d, e });
            AddEdges(b, new List<Point3D> { c });
            AddEdges(c, new List<Point3D> { d });
            AddEdges(d, new List<Point3D> { e });
            AddEdges(e, new List<Point3D> { b });
            AddEdges(f, new List<Point3D> { b, c, d, e });



            AddFace(new List<Point3D> { a, b, c });
            AddFace(new List<Point3D> { a, c, d });
            AddFace(new List<Point3D> { a, d, e });
            AddFace(new List<Point3D> { a, e, b });

            AddFace(new List<Point3D> { f, c, b });
            AddFace(new List<Point3D> { f, d, c });
            AddFace(new List<Point3D> { f, e, d });
            AddFace(new List<Point3D> { f, b, e });
        }
    }
}
