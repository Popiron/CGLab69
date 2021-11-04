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
            AddEdges(a, new List<Point3D> { b, d, c });
            AddEdges(b, new List<Point3D> { d });
            AddEdges(c, new List<Point3D> { b, d });
        }
    }
}
