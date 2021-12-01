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
            var hex = new Hexahedron();
            var faces = hex.Faces;
            var a = faces[0].SideCenter();
            var b = faces[1].SideCenter();
            var c = faces[2].SideCenter();
            var d = faces[3].SideCenter();
            var e = faces[4].SideCenter();
            var f = faces[5].SideCenter();
            AddFace(new[] { a, f, b });
            AddFace(new[] { b, c, f });
            AddFace(new[] { c, d, f });
            AddFace(new[] { d, a, f });
            AddFace(new[] { a, e, b });
            AddFace(new[] { b, e, c });
            AddFace(new[] { c, e, d });
            AddFace(new[] { d, e, a });
        }

        public Octahedron(List<Point3D> points) : base()
        {
            a = points[0];
            b = points[1];
            c = points[3];
            d = points[2];
            e = points[4];
            f = points[5];

            //AddEdges(a, new List<Point3D> { b, d, c, e });
            //AddEdges(b, new List<Point3D> { d });
            //AddEdges(c, new List<Point3D> { e });
            //AddEdges(d, new List<Point3D> { c });
            //AddEdges(e, new List<Point3D> { b });
            //AddEdges(f, new List<Point3D> { b, d, c, e });
        }
    }
}
