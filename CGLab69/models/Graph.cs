using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Media3D;

namespace CGLab69.models
{
    class Graph : Polyhedron
    {
        public Graph() : base()
        {
            for (int i = 0; i < this.Vertices.Count-1; i+=2)
            {
                AddEdge(Vertices[i], Vertices[i+1]);
            }
        }

        public Graph(List<Point3D> points) : base()
        {
            for (int i = 0; i < points.Count - 1; i += 2)
            {
                AddEdge(points[i], points[i + 1]);
            }
        }
    }
}
