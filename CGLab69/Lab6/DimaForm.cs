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
                {0, Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), 0},
                {0, -Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), 0},
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

            double[,] move1 =
                        {
                { 1, 0, 0, -x1},
                { 0, 1, 0, -y1},
                { 0, 0, 1, -z1},
                { 0, 0, 0, 1}
            };
            double[,] move2 =
                        {
                { 1, 0, 0, x1},
                { 0, 1, 0, y1},
                { 0, 0, 1, z1},
                { 0, 0, 0, 1}
            };

            double[,] tM =
                {
                {l*l+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-l*l), l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*m+ n*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n- m*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), 0},
                {l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*m- n*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)),m*m+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-m*m), m*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n+ l*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), 0},
                {l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n+ m*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), m*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n- l*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), n*n+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-n*n), 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, move1);
            Transform(polyhedron, tM);
            Transform(polyhedron, move2);
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


        public void RotateCenter()
        {
            Point3D p1 = new Point3D(0,0,0);
            Point3D p2 = new Point3D(0,0,0);
            switch (currentFigure)
            {
                case Figures.Tetrahedron:
                    p1 = polyhedron.Vertices[0];
                    p2 = new Point3D(((polyhedron.Vertices[1].X + polyhedron.Vertices[2].X + polyhedron.Vertices[3].X) / 3), ((polyhedron.Vertices[1].Y + polyhedron.Vertices[2].Y + polyhedron.Vertices[3].Y) / 3), ((polyhedron.Vertices[1].Z + polyhedron.Vertices[2].Z + polyhedron.Vertices[3].Z) / 3));
                    line = new Polyhedron(new List<Point3D> { p1, p2 });
                    line.AddEdge(p1, p2);
                    break;
                case Figures.Hexahedron:
                    //p1 = new Point3D(((polyhedron.Vertices[0].X + polyhedron.Vertices[1].X + polyhedron.Vertices[2].X + polyhedron.Vertices[3].X) / 4), ((polyhedron.Vertices[0].Y + polyhedron.Vertices[1].Y + polyhedron.Vertices[2].Y + polyhedron.Vertices[3].Y) / 4), ((polyhedron.Vertices[0].Z + polyhedron.Vertices[1].Z + polyhedron.Vertices[2].Z + polyhedron.Vertices[3].Z) / 4));
                    //p2 = new Point3D(((polyhedron.Vertices[4].X + polyhedron.Vertices[5].X + polyhedron.Vertices[6].X + polyhedron.Vertices[7].X) / 4), ((polyhedron.Vertices[4].Y + polyhedron.Vertices[5].Y + polyhedron.Vertices[6].Y + polyhedron.Vertices[7].Y) / 4), ((polyhedron.Vertices[4].Z + polyhedron.Vertices[5].Z + polyhedron.Vertices[6].Z + polyhedron.Vertices[7].Z) / 4));

                    p1 = new Point3D(150,0,150);// polyhedron.Vertices[8];
                    p2 = new Point3D(150,300,150);// polyhedron.Vertices[9];

                    line = new Polyhedron(new List<Point3D> { p1, p2 });
                    line.AddEdge(p1, p2);
                    break;
                case Figures.Octahedron:

                    p1 = polyhedron.Vertices[0];
                    p2 = polyhedron.Vertices[5];
                    line = new Polyhedron(new List<Point3D> { p1, p2 });
                    line.AddEdge(p1, p2);
                    break;
            }
            foreach (var r in line.useProjection(currentProjection).Edges)
            {
                g.DrawLine(Pens.Red, (int)(r.First.X + midX), (int)(r.First.Y + midY), (int)(r.Second.X + midX), (int)(r.Second.Y + midY));
            }

            var x1 = p1.X;
            var x2 = p2.X;

            var y1 = p1.Y;
            var y2 = p2.Y;

            var z1 = p1.Z;
            var z2 = p2.Z;

            var length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            var l = (x2 - x1) / length;
            var m = (y2 - y1) / length;
            var n = (z2 - z1) / length;
            double[,] move1 =
                        {
                { 1, 0, 0, -x1},
                { 0, 1, 0, -y1},
                { 0, 0, 1, -z1},
                { 0, 0, 0, 1}
            };
            double[,] move2 =
                        {
                { 1, 0, 0, x1},
                { 0, 1, 0, y1},
                { 0, 0, 1, z1},
                { 0, 0, 0, 1}
            };

            double[,] tM =
                {
                {l*l+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-l*l), l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*m+ n*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n- m*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), 0},
                {l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*m- n*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)),m*m+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-m*m), m*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n+ l*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), 0},
                {l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n+ m*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), m*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n- l*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), n*n+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-n*n), 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, move1);
            Transform(polyhedron, tM);
            Transform(polyhedron, move2);
            refreshFigure();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            points = new List<Point3D>();
        }
        List<Point3D> points = new List<Point3D>();
        
        private void DimaForm_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
           
           if (radioButtonDP.Checked)
            {
                g.Clear(Color.White);
                var p = new Point3D(e.X, e.Y, 10);
                points.Add(p);
                g.DrawEllipse(globalPen, e.X, e.Y, 5, 5);
                
                for (int i = 1; i < points.Count; i++)
               
                {
                    
                    g.DrawLine(globalPen,new Point((int)points[i - 1].X, (int)points[i - 1].Y), new Point((int)points[i].X, (int)points[i].Y));
                    
                 }
                g.DrawLine(globalPen, new Point((int)points[points.Count - 1].X, (int)points[points.Count - 1].Y), new Point((int)points[0].X, (int)points[0].Y));
            }
           
        }

        private void buttonRotation_Click(object sender, EventArgs e)
        {
           
        }

        private List<Point3D> rotateP(double angle)
        {
            polyhedron = new Polyhedron(points);
            double[,] tM;
            if (comboBox1.SelectedIndex == 0) // x
            {
                tM = new double[,]
            {
                {1, 0, 0, 0},
                {0, Math.Cos(angle * (Math.PI / 180)), -Math.Sin(angle * (Math.PI / 180)), 0},
                {0, Math.Sin(angle * (Math.PI / 180)), Math.Cos(angle * (Math.PI / 180)), 0},
                {0, 0, 0, 1}
            };
               
            }
            else
                if (comboBox1.SelectedIndex == 1) //y
            {
                tM = new double[,]
             {
                {Math.Cos(angle * (Math.PI / 180)), 0, Math.Sin(angle * (Math.PI / 180)), 0 },
                {0, 1, 0, 0 },
                {-Math.Sin(angle * (Math.PI / 180)), 0, Math.Cos(angle * (Math.PI / 180)), 0 },
                {0, 0, 0, 1}
            };
               
            }
            else
                  if (comboBox1.SelectedIndex == 2) //z
            {
                tM = new double[,]
                {
                {Math.Cos(angle * (Math.PI / 180)), -Math.Sin(angle * (Math.PI / 180)), 0, 0},
                {Math.Sin(angle * (Math.PI / 180)), Math.Cos(angle * (Math.PI / 180)), 0, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
                };
                

            }
            else
            {
                tM = new double[,]
              {
                {1, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
                };
                
            }
            double[,] move1 =
                       {
                { 1, 0, 0, -Center(polyhedron).X},
                { 0, 1, 0, -Center(polyhedron).Y},
                { 0, 0, 1, -Center(polyhedron).Z},
                { 0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            Transform(polyhedron, move1);
            refreshFigure();
            List<Point3D> result = new List<Point3D>();
            foreach (var x in polyhedron.Vertices)
            {
                result.Add(x);
            }
            return result;
        }
        /*
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            
            int cnt = points.Count;
            double angle = 360.0d / ((int)numericUpDown5.Value);
            List<Point3D> fig = new List<Point3D>();
            fig.AddRange(points);
            for (int i = 1; i < ((int)numericUpDown5.Value); i++)
            {
                fig.AddRange(rotateP(angle * i));
            }

            Polyhedron p = new Polyhedron(fig);

            for (int i = 0; i < ((int)numericUpDown5.Value); i++)
            {
                for (int j = 0; j < cnt; j++)
                {
                    var current = j + i * cnt;
                    if ((current + 1) % cnt == 0)
                    { p.AddEdges(current, new List<int> { (current + cnt) % fig.Count });
                    }
                    else
                    {
                        p.add
                    } 
                        
                }
            }
        }
        */

        private void button2_Click(object sender, EventArgs e)
        {
            RotateCenter();
        }
    }
}
