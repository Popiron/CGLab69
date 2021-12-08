using CGLab69.helpers;
using CGLab69.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace CGLab69.Lab6
{
    enum Figures { Tetrahedron, Hexahedron, Octahedron, Graph};

    public partial class DimaForm : Form
    {
        Graphics g;
        Polyhedron polyhedron;
        Figures currentFigure;
        Projections currentProjection;
        int midX;
        int midY;
        Pen globalPen = Pens.Black;
        
        Point3D center;
        Point3D shift = new Point3D(0,0,0);

        public DimaForm()
        {
            InitializeComponent();
            g = CreateGraphics();
            center = new Point3D(this.Width / 4, this.Height / 2, 0);
        }


        private void DimaForm_Shown(object sender, EventArgs e)
        {
            midX = Size.Width / 2;
            midY = Size.Height / 2 - 300;
            tetraRadioButton.Checked = true;
            perspectiveRadioButton.Checked = true;
            loadFigure();
        }

        private void loadFigure()
        {
            g.Clear(Color.White);
            switch (currentFigure)
            {
                case Figures.Tetrahedron:
                    polyhedron = new Tetrahedron();
                    break;
                case Figures.Hexahedron:
                    polyhedron = new Hexahedron();
                    break;
                case Figures.Octahedron:
                    polyhedron = new Octahedron();
                    break;
                default:
                    polyhedron = new Tetrahedron();
                    break;
            }
            foreach (var r in polyhedron.useProjection(currentProjection).Edges)
            {
                g.DrawLine(globalPen, (int)(r.First.X + midX), (int)(r.First.Y + midY), (int)(r.Second.X + midX), (int)(r.Second.Y + midY));
            }
        }

        

        private void tetraRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentFigure = Figures.Tetrahedron;
            loadFigure();
        }

        private void hexaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentFigure = Figures.Hexahedron;
            loadFigure();
        }

        private void octaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentFigure = Figures.Octahedron;
            loadFigure();
        }

        private void perspectiveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentProjection = Projections.Perspective;
            loadFigure();
        }

        private void isometricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentProjection = Projections.Isometric;
            loadFigure();
        }

        private void trimetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentProjection = Projections.Trimetric;
            loadFigure();
        }

        private void dimetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentProjection = Projections.Dimetric;
            loadFigure();
        }

        private void Transform(Polyhedron t, double[,] m)
        {
            for (int i = 0; i < t.Vertices.Count; i++)
            {
                double[,] vector = {
                    { t.Vertices[i].X },
                    { t.Vertices[i].Y },
                    { t.Vertices[i].Z },
                    { 1 }
                };
                var res = MatrixHelpers.multiply(m, vector);

                Point3D newV = new Point3D(res[0, 0], res[1, 0], res[2, 0]);

                t.Vertices[i] = newV;
            }
            switch (currentFigure)
            {
                case Figures.Tetrahedron:
                    polyhedron = new Tetrahedron(t.Vertices);
                    break;
                case Figures.Hexahedron:
                    polyhedron = new Hexahedron(t.Vertices);
                    break;
                case Figures.Octahedron:
                    polyhedron = new Octahedron(t.Vertices);
                    break;
                case Figures.Graph:
                    polyhedron = new Graph(t.Vertices);
                    break;
                default:
                    polyhedron = new Polyhedron(t.Vertices);
                    break;
            }
        }

        private void Translate()
        {
            double[,] tM =
            {
                {1, 0, 0, (double)numericUpDown1.Value},
                {0, 1, 0, (double)numericUpDown2.Value},
                {0, 0, 1, (double)numericUpDown3.Value},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure();
        }

        private void RotateX()
        {
            double[,] tM =
            {
                {1, 0, 0, 0},
                {0, Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), -Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), 0},
                {0, Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure();
        }

        private void RotateY()
        {
            double[,] tM =
            {
                {Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), 0, Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), 0 },
                {0, 1, 0, 0 },
                {-Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), 0, Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), 0 },
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure();
        }

        private void RotateZ()
        {
            double[,] tM =
            {
                {Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), -Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), 0, 0},
                {Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), 0, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure();
        }
        private void Scale()
        {
            double[,] tM =
            {
                {double.Parse(textBox1.Text), 0, 0, 0},
                {0, double.Parse(textBox1.Text), 0, 0},
                {0, 0, double.Parse(textBox1.Text), 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure();
        }
        private void YZ()
        {
            double [,] tM =
                {
                {-1, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure();
        }
        private void XZ()
        {
            double[,] tM =
                {
                {1, 0, 0, 0},
                {0, -1, 0, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure();
        }
        private void XY()
        {
            double[,] tM =
                {
                {1, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 0, -1, 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure();
        }
        private Point3D Center(Polyhedron t) 
        {
            Point3D newV = new Point3D();
            for (int i = 0; i < t.Vertices.Count; i++)
            {
                newV.X += t.Vertices[i].X;
                newV.Y += t.Vertices[i].Y;
                newV.Z += t.Vertices[i].Z;

            }
            newV.X /= t.Vertices.Count;
            newV.Y /= t.Vertices.Count;
            newV.Z /= t.Vertices.Count;
            return newV;
        }

        public void ScaleCenter(Polyhedron t)
        {   
           
              List<Point3D> p = new List<Point3D>(); 
            double lengthX, lengthY, lengthZ = 0;
            for (int i = 0; i < t.Vertices.Count; i++)
            {
                lengthX = (t.Vertices[i].X - Center(polyhedron).X) * double.Parse(textBoxScale.Text)+ Center(polyhedron).X;
                lengthY = (t.Vertices[i].Y - Center(polyhedron).Y) * double.Parse(textBoxScale.Text) + Center(polyhedron).Y;
                lengthZ = (t.Vertices[i].Z - Center(polyhedron).Z) * double.Parse(textBoxScale.Text)+ Center(polyhedron).Z;
                p.Add(new Point3D(lengthX, lengthY, lengthZ));
            }

            polyhedron = new Polyhedron(p);
            double[,] tM =
                {
                {1, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure();
        }
        public void RotateLine()
        {
            var x1 = double.Parse(textBoxX1.Text);
            var x2 = double.Parse(textBoxX2.Text);

            var y1 = double.Parse(textBoxY1.Text);
            var y2 = double.Parse(textBoxY2.Text);

            var z1 = double.Parse(textBoxZ1.Text);
            var z2 = double.Parse(textBoxZ2.Text);

            var length = Math.Sqrt(Math.Pow(x2 - x1, 2)+ Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
            var l = (x2 - x1) / length;
            var m = (y2 - y1) / length;
            var n = (z2 - z1) / length;
            double[,] tM =
                {
                {l*l+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-l*l), l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*m+ n*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n- m*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), 0},
                {l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*m- n*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)),m*m+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-m*m), m*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n+ l*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), 0},
                {l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n+ m*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), m*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n- l*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), n*n+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-n*n), 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure();
        }
        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            Translate();
        }

        private void buttonRotateX_Click(object sender, EventArgs e)
        {
            RotateX();
        }

        private void buttonRotateY_Click(object sender, EventArgs e)
        {
            RotateY();
        }

        private void buttonRotateZ_Click(object sender, EventArgs e)
        {
            RotateZ();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                buttonScale.Enabled = false;
            }
            else {
                buttonScale.Enabled = true;
            }
        }

        private void buttonScale_Click(object sender, EventArgs e)
        {
            Scale();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            if(radioButtonX.Checked)
            {
                XZ();
            } 
            if(radioButtonY.Checked)
            {
                XY();
            }
            if (radioButtonZ.Checked)
            { 
                YZ();
            }
        }

        private void buttonScaleC_Click(object sender, EventArgs e)
        {
            ScaleCenter(polyhedron);
        }

        private void textBoxScale_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            DrawL();
            RotateLine();

        }

        public void DrawL()
        {
            Point3D p1 = new Point3D(double.Parse(textBoxX1.Text), double.Parse(textBoxY1.Text), double.Parse(textBoxZ1.Text));
            Point3D p2 = new Point3D(double.Parse(textBoxX2.Text), double.Parse(textBoxY2.Text), double.Parse(textBoxZ2.Text));
            Polyhedron line = new Polyhedron(new List<Point3D> { p1, p2 });
            line.AddEdge(p1, p2);

            foreach (var r in line.useProjection(currentProjection).Edges)
            {
                g.DrawLine(Pens.Red, (int)(r.First.X + midX), (int)(r.First.Y + midY), (int)(r.Second.X + midX), (int)(r.Second.Y + midY));
            }
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            DrawL();
        }

        private void ClearGraph() {
            foreach (var r in polyhedron.useProjection(currentProjection).Edges)
            {
                g.DrawLine(Pens.White, (int)(r.First.X + midX), (int)(r.First.Y + midY), (int)(r.Second.X + midX), (int)(r.Second.Y + midY));
            }
            polyhedron = new Polyhedron();
        }

        private void buttonGraph_Click(object sender, EventArgs e)//test function z = x + y
        {
            globalPen = Pens.Blue;
            currentFigure = Figures.Graph;
            float X0 = (float)double.Parse(textBoxRangeX0.Text);
            float X1 = (float)double.Parse(textBoxRangeX1.Text);
            float Y0 = (float)double.Parse(textBoxRangeY0.Text);
            float Y1 = (float)double.Parse(textBoxRangeY1.Text);

            float step = (float)double.Parse(textBoxGraphStep.Text);

            polyhedron = new Polyhedron();

            Func<double, double, float> f = (x,y) => (float)(x + y);
            switch (comboBox1.SelectedIndex) {
                case 1:
                    f = (x, y) => (float)((x*x + y));
                    break;
            }

            for (double x = X0; x < X1; x+=step){
                for (double y = Y0; y < Y1; y+=step){
                    polyhedron.AddEdge(new Point3D(x, y, f(x,y) ), new Point3D(x, y + step, f(x, y)));
                }
            }

            for  (double y = Y0; y < Y1; y += step)
            {
                for (double x = X0; x < X1; x += step)
                {
                    polyhedron.AddEdge(new Point3D(x, y, f(x, y)), new Point3D(x + step, y, f(x, y)));
                }
            }

            refreshFigure();
        }

        private void button2_Click(object sender, EventArgs e){
            ClearGraph();
            globalPen = Pens.Black;
        }

        private void refreshFigure()
        {
            g.Clear(Color.White);

            foreach (var r in polyhedron.useProjection(currentProjection).Edges)
            {
                g.DrawLine(globalPen, (int)(r.First.X + midX), (int)(r.First.Y + midY), (int)(r.Second.X + midX), (int)(r.Second.Y + midY));
            }
        }

        Point[] Position2d(Edge e)
        {
            List<Point> p2D = new List<Point> { };
            foreach (var p3 in e.points)
            {
                p2D.Add(new Point((int)p3.X + (int)center.X, (int)p3.Y + (int)center.Y));
            }
            return p2D.ToArray();
        }
        Point Position2d(Point3D p)
        {
            return new Point((int)p.X + (int)center.X, (int)p.Y + (int)center.Y);
        }

        public void DrawFunc()
        {
            g.Clear(Color.White);
            Dictionary<double, double> UpBound = new Dictionary<double, double>();
            Dictionary<double, double> DownBound = new Dictionary<double, double>();
            polyhedron.Edges.Sort((Edge first, Edge second) =>
            {
                return first.points[0].Z > second.points[0].Z ? 1 : -1;
            });

            foreach (var point in polyhedron.Edges[0].points)
            {
                UpBound[Math.Round(point.X, 0)] = point.Y;
                DownBound[Math.Round(point.X, 0)] = point.Y;
            }

            foreach (var edge in polyhedron.Edges)
            {
                bool is_last_visible = true;
                Point3D last_point = edge.points[0];
                foreach (var point in edge.points)
                {
                    double x = Math.Round(point.X, 0);
                    if (!UpBound.ContainsKey(x))
                    {
                        UpBound[x] = point.Y;
                        DownBound[x] = point.Y;
                        if (is_last_visible)
                            g.DrawLine(Pens.Blue, Position2d(last_point), Position2d(point));
                        last_point = point;
                        is_last_visible = true;
                    }
                    else
                    if (point.Y >= UpBound[x])
                    {
                        if (is_last_visible)
                            g.DrawLine(Pens.Blue, Position2d(last_point), Position2d(point));
                        UpBound[x] = point.Y;
                        last_point = point;
                        is_last_visible = true;
                    }
                    else
                    if (point.Y <= DownBound[x])
                    {
                        if (is_last_visible)
                            g.DrawLine(Pens.Blue, Position2d(last_point), Position2d(point));
                        DownBound[x] = point.Y;
                        last_point = point;
                        is_last_visible = true;
                    }
                    else
                        is_last_visible = false;
                }
            }
        }

        private void button_ShowGraph_Click(object sender, EventArgs e)
        {
            polyhedron = new Polyhedron();
            currentFigure = Figures.Graph;
            int scale = 60;
            //y = (1 / 5)sin x cos z – (3 / 2) cos(7α / 4) e^(-α), где α = (x - p)^2 + (z - p)^2
            Func<double, double, double> funcc = (double x, double z) =>
            {
                double alpha = Math.Pow((x / scale - Math.PI), 2) + Math.Pow((z / scale - Math.PI), 2);
                return scale * ((1 / 5.0) * Math.Sin(x / scale) * Math.Cos(z / scale) - (3 / 2.0) * Math.Cos(7 * alpha / 4) * Math.Pow(Math.E, -alpha));
            };

            if (comboBox1.Text == "sin(x)*cos(y)")
                funcc = (double x, double y) => { return scale * (Math.Sin(x / scale) * Math.Cos(y / scale)); };
            if (comboBox1.Text == "sin(x)^2*cos(y)^2")
                funcc = (double x, double y) => { return scale * (Math.Sin(x / scale) * Math.Sin(x / scale) * Math.Cos(y / scale) * Math.Cos(y / scale)); };
            if (comboBox1.Text == "sin(x)^2+cos(y)^2")
                funcc = (double x, double y) => { return scale * (Math.Sin(x / scale) * Math.Sin(x / scale) + Math.Cos(y / scale) * Math.Cos(y / scale)); };

            int index = 0;

            for (int z = int.Parse(textBoxZ0.Text); z <= int.Parse(textBoxZ1.Text); z += 5)
            {
                polyhedron.Edges.Add(new Edge(new List<Point3D>()));
                for (int x = int.Parse(textBoxX0.Text); x <= int.Parse(textBoxX1.Text); x++)
                {
                    polyhedron.Edges[index].points.Add(new Point3D(x, funcc(x, z), z));
                }
                index++;
            }
            DrawFunc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            List<Edge> newEdges = new List<Edge>();
            foreach (var edge in polyhedron.Edges)
            {
                Edge newPoints = new Edge();
                foreach (var point in edge.points)
                {
                    double[,] m = new double[1, 4];
                    m[0, 0] = point.X - shift.X;
                    m[0, 1] = point.Y - shift.Y;
                    m[0, 2] = point.Z - shift.Z;
                    m[0, 3] = 1;

                    var angle = double.Parse(numericUpDownX.Text) * Math.PI / 180;
                    double[,] matrx = new double[4, 4]
                    {
                    { Math.Cos(angle), 0, Math.Sin(angle), 0},
                    { 0, 1, 0, 0 },
                    {-Math.Sin(angle), 0, Math.Cos(angle), 0 },
                    { 0, 0, 0, 1 }
                    };

                    angle = double.Parse(numericUpDownY.Text) * Math.PI / 180;
                    double[,] matry = new double[4, 4]
                    {  
                    { 1, 0, 0, 0 },
                    { 0, Math.Cos(angle), -Math.Sin(angle), 0},
                    {0, Math.Sin(angle), Math.Cos(angle), 0 },
                    { 0, 0, 0, 1 } 
                    };

                    angle = double.Parse(numericUpDownZ.Text) * Math.PI / 180;
                    double[,] matrz = new double[4, 4]
                    {
                    { Math.Cos(angle), -Math.Sin(angle), 0, 0},
                    { Math.Sin(angle), Math.Cos(angle), 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 }
                    };

                    var final_matrix = MatrixHelpers.multiply(m, matrx);
                    final_matrix = MatrixHelpers.multiply(final_matrix, matry);
                    final_matrix = MatrixHelpers.multiply(final_matrix, matrz);

                    newPoints.points.Add(new Point3D(final_matrix[0, 0] + shift.X, final_matrix[0, 1] + shift.Y, final_matrix[0, 2] + shift.Z));
                }
                newEdges.Add(newPoints);
            }
            polyhedron.Edges = newEdges;
            DrawFunc();
        }
    }
}
