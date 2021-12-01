using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace CGLab69.models
{
    /// <summary>
    /// Тетраэдр
    /// </summary>
    class Tetrahedron : Polyhedron
    {
        Point3D a = new Point3D(0, 0, 0);
        Point3D b = new Point3D(300, 0, 300);
        Point3D c = new Point3D(300, 300, 0);
        Point3D d = new Point3D(0, 300, 300);
        public Tetrahedron() : base() {
            AddFace(new[] { a, d, c });
            AddFace(new[] { a, d, b });
            AddFace(new[] { c, d, b });
            AddFace(new[] { a, c, b });
        }

        public Tetrahedron(List<Point3D> points) : base()
        {
            a = points[0];
            b = points[1];
            c = points[2];
            d = points[3];

            AddFace(new[] { a, d, c });
            AddFace(new[] { a, d, b });
            AddFace(new[] { c, d, b });
            AddFace(new[] { a, c, b });
        }
    }
}
