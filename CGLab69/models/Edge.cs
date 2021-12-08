using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media.Media3D;

namespace CGLab69.models
{
    /// <summary>
    /// Прямая (ребро)
    /// </summary>
    public class Edge
    {
        public Point3D First { get; set; }
        public Point3D Second { get; set; }

        public List<Point3D> points;

        public Edge(Point3D first, Point3D second)
        {
            First = first;
            Second = second;
        }
        public Edge(List<Point3D> p)
        {
            this.points = p;
        }
        public Edge()
        {
            this.points = new List<Point3D> { };
        }
    }
}
