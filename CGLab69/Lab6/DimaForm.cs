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
    enum Figures { Tetrahedron, Hexahedron, Octahedron, };

    public partial class DimaForm : Form
    {
        Graphics g;
        Polyhedron polyhedron;
        Polyhedron line;
        Figures currentFigure;
        Projections currentProjection;
        int midX;
        int midY;
        Pen globalPen = Pens.Black;

        public DimaForm()
        {
            InitializeComponent();
            g = CreateGraphics();
        }


        private void DimaForm_Shown(object sender, EventArgs e)
        {
            //line = new Polyhedron(new List<Point3D> { new Point3D(0, 0, 0), new Point3D(0, 0, 0) });
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

        private void refreshFigure()
        {
            g.Clear(Color.White);

            foreach (var r in polyhedron.useProjection(currentProjection).Edges)
            {
                g.DrawLine(globalPen, (int)(r.First.X + midX), (int)(r.First.Y + midY), (int)(r.Second.X + midX), (int)(r.Second.Y + midY));
            }
        }

        private void eraseLine()
        {
            foreach (var r in line.useProjection(currentProjection).Edges)
            {
                g.DrawLine(Pens.White, (int)(r.First.X + midX), (int)(r.First.Y + midY), (int)(r.Second.X + midX), (int)(r.Second.Y + midY));
            }
        }

        private void refreshLine() {
            foreach (var r in line.useProjection(currentProjection).Edges)
            {
                g.DrawLine(Pens.Red, (int)(r.First.X + midX), (int)(r.First.Y + midY), (int)(r.Second.X + midX), (int)(r.Second.Y + midY));
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
            if (line != null)
            {
                refreshLine();
            }
        }

        private void isometricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentProjection = Projections.Isometric;
            loadFigure();

            if (line != null)
            {
                refreshLine();
            }
        }

        private void trimetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentProjection = Projections.Trimetric;
            loadFigure();

            if (line != null)
            {
                refreshLine();
            }
        }

        private void dimetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            eraseLine();
            currentProjection = Projections.Dimetric;
            loadFigure();

            if (line != null)
            {
                refreshLine();
            }
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
                default:
                    polyhedron = new Tetrahedron(t.Vertices);
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
            line = new Polyhedron(new List<Point3D> { p1, p2 });
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
    }
}
