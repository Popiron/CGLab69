//грань фигуры 
using CGLab69.models;
using System;
using System.Collections.Generic;
using System.Windows.Media.Media3D;

[Serializable]
public class Face
{
    public Point3D SideCenter()
    {
        double x = 0;
        double y = 0;
        double z = 0;
        foreach (var e in Edges)
        {
            x += e.First.X;
            y += e.First.Y;
            z += e.First.Z;
        }
        return new Point3D(x / Edges.Count, y / Edges.Count, z / Edges.Count);
    }
    public List<Edge> Edges { get; }

    public Face()
    {
        Edges = new List<Edge>();
    }

    public Face(IEnumerable<Edge> edges) : this()
    {
        this.Edges.AddRange(edges);
    }
    public void AddEdge(Edge edge)
    {
        if (edge.First == edge.Second)
            return;
        Edges.Add(edge);
    }

    public bool ContainsPoint(Point3D point)
    {
        foreach (var e in Edges)
        {
            if (e.First == point || e.Second == point)
                return true;
        }
        return false;
    }
    /*
    public List<double> SideEquation()
    {
        var p1 = edges[0].begin;
        var p2 = edges[0].end;
        var p3 = edges[1].end;
        var p3p1 = p2 - p1;
        var p3p2 = p3 - p1;
        var x = p3p1.Y * p3p2.Z - p3p1.Z * p3p2.Y;
        var y = -(p3p1.X * p3p2.Z - p3p1.Z * p3p2.X);
        var z = p3p1.X * p3p2.Y - p3p1.Y * p3p2.X;
        var d = -x * p1.X + -y * p1.Y + -z * p1.Z;
        return new List<double>{ x, y, z, d };
    }
    */
    public Vector3D NormalVec()
    {
        var p1 = Edges[0].First;
        var p2 = Edges[0].Second;
        var p3 = Edges[1].Second;

        return Vector3D.CrossProduct(p2 - p1, p3 - p2);
    }
}