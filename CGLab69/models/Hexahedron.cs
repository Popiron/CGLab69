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
            AddFace(new[] { a, b, f, e });
            AddFace(new[] { b, c, g, f });
            AddFace(new[] { d, c, g, h });
            AddFace(new[] { a, d, h, e });
            AddFace(new[] { a, b, c, d });
            AddFace(new[] { e, f, g, h });

        }

        public Hexahedron(List<Point3D> points) : base()
        {
            a = points[2];//0
            b = points[0];//2
            c = points[1];//1
            d = points[3];//3
            
            e = points[4];//4
            f = points[6];//6
            g = points[7];//5
            h = points[5];//7

            AddFace(new[] { a, b, f, e });
            AddFace(new[] { b, c, g, f });
            AddFace(new[] { d, c, g, h });
            AddFace(new[] { a, d, h, e });
            AddFace(new[] { a, b, c, d });
            AddFace(new[] { e, f, g, h });
        }
    }
}
