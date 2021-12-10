using CGLab69.helpers;
using CGLab69.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        Point3D lightPosition = new Point3D(0,0,0);
        Color polyhedronColor = Color.Aqua;

        public DimaForm()
        {
            InitializeComponent();
            mainPictureBox.Image = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            ClearPicture();
        }


        private void DimaForm_Shown(object sender, EventArgs e)
        {
            //line = new Polyhedron(new List<Point3D> { new Point3D(0, 0, 0), new Point3D(0, 0, 0) });
            midX = Size.Width / 2;
            midY = Size.Height / 2 - 300;
            tetraRadioButton.Checked = true;
            perspectiveRadioButton.Checked = true;
            colorPictureBox.BackColor = polyhedronColor;
            guroXTextBox.Text = lightPosition.X.ToString();
            guroYYTextBox.Text = lightPosition.Y.ToString();
            guroZTextBox.Text = lightPosition.Z.ToString();

            loadFigure();
        }

        private void ClearPicture()
        {
            g = Graphics.FromImage(mainPictureBox.Image);
            g.Clear(mainPictureBox.BackColor);
            mainPictureBox.Image = mainPictureBox.Image;
        }

        private void loadFigure()
        {
            ClearPicture();
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
            ;

            var bmp = Lighting.lighting(mainPictureBox.Width, mainPictureBox.Height, polyhedron, lightPosition, polyhedronColor);
            mainPictureBox.Image = bmp;
        }

        private void refreshFigure()
        {
            ClearPicture();
            var bmp = Lighting.lighting(mainPictureBox.Width, mainPictureBox.Height, polyhedron, lightPosition, polyhedronColor);
            mainPictureBox.Image = bmp;
            if (pictureBox1.Image!= null)
            { 

            Texturing(polyhedron);
            }
        }

        private void eraseLine()
        {
            foreach (var r in polyhedron.UseProjection(currentProjection).Edges)
            {
                g.DrawLine(Pens.White, (int)(r.First.X + midX), (int)(r.First.Y + midY), (int)(r.Second.X + midX), (int)(r.Second.Y + midY));
            }
        }

        private void refreshLine() {
            foreach (var r in line.UseProjection(currentProjection).Edges)
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

        private void Translate()
        {
            Matrix3D tM = new Matrix3D(1, 0, 0, (double)numericUpDown1.Value, 0, 1, 0, (double)numericUpDown2.Value, 0, 0, 1, (double)numericUpDown3.Value, 0, 0, 0, 1);
            polyhedron.Transform(tM);
            refreshFigure();
        }

        private void RotateX()
        {
            Matrix3D tM = new Matrix3D(
                1, 0, 0, 0,
                 0, Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), 0,
                 0, -Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), 0,
                 0, 0, 0, 1
                );
            polyhedron.Transform(tM);
            refreshFigure();
        }

        private void RotateY()
        {
            Matrix3D tM = new Matrix3D
            (
                Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), 0, Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), 0 ,
                0, 1, 0, 0 ,
                -Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), 0, Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), 0 ,
                0, 0, 0, 1
            );
            polyhedron.Transform(tM);
            refreshFigure();
        }

        private void RotateZ()
        {
            Matrix3D tM = new Matrix3D
            (
                Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), -Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), 0, 0,
                Math.Sin((double)numericUpDown4.Value * (Math.PI / 180)), Math.Cos((double)numericUpDown4.Value * (Math.PI / 180)), 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            );
            polyhedron.Transform(tM);
            refreshFigure();
        }
        private void Scale()
        {
            Matrix3D tM = new Matrix3D
            (
                double.Parse(textBox1.Text), 0, 0, 0,
                0, double.Parse(textBox1.Text), 0, 0,
                0, 0, double.Parse(textBox1.Text), 0,
                0, 0, 0, 1
            );
            polyhedron.Transform(tM);
            refreshFigure();
        }
        private void YZ()
        {
            Matrix3D tM = new Matrix3D
                (
                -1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            );
            polyhedron.Transform(tM);
            refreshFigure();
        }
        private void XZ()
        {
            Matrix3D tM = new Matrix3D
                (
                1, 0, 0, 0,
                0, -1, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            );
            polyhedron.Transform(tM);
            refreshFigure();
        }
        private void XY()
        {
            Matrix3D tM = new Matrix3D
                (
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, -1, 0,
                0, 0, 0, 1
            );
            polyhedron.Transform(tM);
            refreshFigure();
        }

        public void ScaleCenter(Polyhedron t)
        {   
           
            //List<Point3D> p = new List<Point3D>(); 
            //double lengthX, lengthY, lengthZ = 0;
            //var verts = t.Vertices.ToList();
            //for (int i = 0; i < verts.Count; i++)
            //{
            //    lengthX = (verts[i].X - polyhedron.FigureCenter().X) * double.Parse(textBoxScale.Text)+ polyhedron.FigureCenter().X;
            //    lengthY = (verts[i].Y - polyhedron.FigureCenter().Y) * double.Parse(textBoxScale.Text) + polyhedron.FigureCenter().Y;
            //    lengthZ = (verts[i].Z - polyhedron.FigureCenter().Z) * double.Parse(textBoxScale.Text)+ polyhedron.FigureCenter().Z;
            //    p.Add(new Point3D(lengthX, lengthY, lengthZ));
            //}
            //
            //polyhedron = new Polyhedron(p);
            //double[,] tM =
            //    {
            //    {1, 0, 0, 0},
            //    {0, 1, 0, 0},
            //    {0, 0, 1, 0},
            //    {0, 0, 0, 1}
            //};
            //Transform(polyhedron, tM);
            //refreshFigure();
        }
        public void RotateLine()
        {
            //var x1 = double.Parse(textBoxX1.Text);
            //var x2 = double.Parse(textBoxX2.Text);
            //
            //var y1 = double.Parse(textBoxY1.Text);
            //var y2 = double.Parse(textBoxY2.Text);
            //
            //var z1 = double.Parse(textBoxZ1.Text);
            //var z2 = double.Parse(textBoxZ2.Text);
            //
            //var length = Math.Sqrt(Math.Pow(x2 - x1, 2)+ Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
            //var l = (x2 - x1) / length;
            //var m = (y2 - y1) / length;
            //var n = (z2 - z1) / length;
            //
            //double[,] move1 =
            //            {
            //    { 1, 0, 0, -x1},
            //    { 0, 1, 0, -y1},
            //    { 0, 0, 1, -z1},
            //    { 0, 0, 0, 1}
            //};
            //double[,] move2 =
            //            {
            //    { 1, 0, 0, x1},
            //    { 0, 1, 0, y1},
            //    { 0, 0, 1, z1},
            //    { 0, 0, 0, 1}
            //};
            //
            //double[,] tM =
            //    {
            //    {l*l+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-l*l), l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*m+ n*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n- m*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), 0},
            //    {l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*m- n*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)),m*m+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-m*m), m*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n+ l*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), 0},
            //    {l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n+ m*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), m*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n- l*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), n*n+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-n*n), 0},
            //    {0, 0, 0, 1}
            //};
            //Transform(polyhedron, move1);
            //Transform(polyhedron, tM);
            //Transform(polyhedron, move2);
            //refreshFigure();
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
            //Point3D p1 = new Point3D(double.Parse(textBoxX1.Text), double.Parse(textBoxY1.Text), double.Parse(textBoxZ1.Text));
            //Point3D p2 = new Point3D(double.Parse(textBoxX2.Text), double.Parse(textBoxY2.Text), double.Parse(textBoxZ2.Text));
            //line = new Polyhedron(new List<Point3D> { p1, p2 });
            //line.AddEdge(p1, p2);
            //
            //foreach (var r in line.useProjection(currentProjection).Edges)
            //{
            //    g.DrawLine(Pens.Red, (int)(r.First.X + midX), (int)(r.First.Y + midY), (int)(r.Second.X + midX), (int)(r.Second.Y + midY));
            //}
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            DrawL();
        }


        public void RotateCenter()
        {
            //Point3D p1 = new Point3D(0,0,0);
            //Point3D p2 = new Point3D(0,0,0);
            //switch (currentFigure)
            //{
            //    case Figures.Tetrahedron:
            //        p1 = polyhedron.Vertices[0];
            //        p2 = new Point3D(((polyhedron.Vertices[1].X + polyhedron.Vertices[2].X + polyhedron.Vertices[3].X) / 3), ((polyhedron.Vertices[1].Y + polyhedron.Vertices[2].Y + polyhedron.Vertices[3].Y) / 3), ((polyhedron.Vertices[1].Z + polyhedron.Vertices[2].Z + polyhedron.Vertices[3].Z) / 3));
            //        line = new Polyhedron(new List<Point3D> { p1, p2 });
            //        line.AddEdge(p1, p2);
            //        break;
            //    case Figures.Hexahedron:
            //        //p1 = new Point3D(((polyhedron.Vertices[0].X + polyhedron.Vertices[1].X + polyhedron.Vertices[2].X + polyhedron.Vertices[3].X) / 4), ((polyhedron.Vertices[0].Y + polyhedron.Vertices[1].Y + polyhedron.Vertices[2].Y + polyhedron.Vertices[3].Y) / 4), ((polyhedron.Vertices[0].Z + polyhedron.Vertices[1].Z + polyhedron.Vertices[2].Z + polyhedron.Vertices[3].Z) / 4));
            //        //p2 = new Point3D(((polyhedron.Vertices[4].X + polyhedron.Vertices[5].X + polyhedron.Vertices[6].X + polyhedron.Vertices[7].X) / 4), ((polyhedron.Vertices[4].Y + polyhedron.Vertices[5].Y + polyhedron.Vertices[6].Y + polyhedron.Vertices[7].Y) / 4), ((polyhedron.Vertices[4].Z + polyhedron.Vertices[5].Z + polyhedron.Vertices[6].Z + polyhedron.Vertices[7].Z) / 4));
            //
            //        p1 = new Point3D(150,0,150);// polyhedron.Vertices[8];
            //        p2 = new Point3D(150,300,150);// polyhedron.Vertices[9];
            //
            //        line = new Polyhedron(new List<Point3D> { p1, p2 });
            //        line.AddEdge(p1, p2);
            //        break;
            //    case Figures.Octahedron:
            //
            //        p1 = polyhedron.Vertices[0];
            //        p2 = polyhedron.Vertices[5];
            //        line = new Polyhedron(new List<Point3D> { p1, p2 });
            //        line.AddEdge(p1, p2);
            //        break;
            //}
            //foreach (var r in line.useProjection(currentProjection).Edges)
            //{
            //    g.DrawLine(Pens.Red, (int)(r.First.X + midX), (int)(r.First.Y + midY), (int)(r.Second.X + midX), (int)(r.Second.Y + midY));
            //}
            //
            //var x1 = p1.X;
            //var x2 = p2.X;
            //
            //var y1 = p1.Y;
            //var y2 = p2.Y;
            //
            //var z1 = p1.Z;
            //var z2 = p2.Z;
            //
            //var length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            //var l = (x2 - x1) / length;
            //var m = (y2 - y1) / length;
            //var n = (z2 - z1) / length;
            //double[,] move1 =
            //            {
            //    { 1, 0, 0, -x1},
            //    { 0, 1, 0, -y1},
            //    { 0, 0, 1, -z1},
            //    { 0, 0, 0, 1}
            //};
            //double[,] move2 =
            //            {
            //    { 1, 0, 0, x1},
            //    { 0, 1, 0, y1},
            //    { 0, 0, 1, z1},
            //    { 0, 0, 0, 1}
            //};
            //
            //double[,] tM =
            //    {
            //    {l*l+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-l*l), l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*m+ n*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n- m*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), 0},
            //    {l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*m- n*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)),m*m+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-m*m), m*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n+ l*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), 0},
            //    {l*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n+ m*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), m*(1 - Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180)))*n- l*Math.Sin(double.Parse(textBoxRotate.Text)*(Math.PI / 180)), n*n+Math.Cos(double.Parse(textBoxRotate.Text)*(Math.PI / 180))*(1-n*n), 0},
            //    {0, 0, 0, 1}
            //};
            //Transform(polyhedron, move1);
            //Transform(polyhedron, tM);
            //Transform(polyhedron, move2);
            //refreshFigure();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearPicture();
            points = new List<Point3D>();
        }
        List<Point3D> points = new List<Point3D>();
        
        private void DimaForm_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            


        }

        private void RotateCenterX(double angle)
        {
            //Point3D p1 = Center(polyhedron);
            //Point3D p2 = new Point3D(p1.X+100, p1.Y, p1.Z);
            //var x1 = p1.X;
            //var x2 = p2.X;
            //
            //var y1 = p1.Y;
            //var y2 = p2.Y;
            //
            //var z1 = p1.Z;
            //var z2 = p2.Z;
            //
            //var length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            //var l = (x2 - x1) / length;
            //var m = (y2 - y1) / length;
            //var n = (z2 - z1) / length;
            //double[,] move1 =
            //            {
            //    { 1, 0, 0, -x1},
            //    { 0, 1, 0, -y1},
            //    { 0, 0, 1, -z1},
            //    { 0, 0, 0, 1}
            //};
            //double[,] move2 =
            //            {
            //    { 1, 0, 0, x1},
            //    { 0, 1, 0, y1},
            //    { 0, 0, 1, z1},
            //    { 0, 0, 0, 1}
            //};
            //
            //double[,] tM =
            //    {
            //    {l*l+Math.Cos(angle*(Math.PI / 180))*(1-l*l), l*(1 - Math.Cos(angle*(Math.PI / 180)))*m+ n*Math.Sin(angle*(Math.PI / 180)), l*(1 - Math.Cos(angle*(Math.PI / 180)))*n- m*Math.Sin(angle*(Math.PI / 180)), 0},
            //    {l*(1 - Math.Cos(angle*(Math.PI / 180)))*m- n*Math.Sin(angle*(Math.PI / 180)),m*m+Math.Cos(angle*(Math.PI / 180))*(1-m*m), m*(1 - Math.Cos(angle*(Math.PI / 180)))*n+ l*Math.Sin(angle*(Math.PI / 180)), 0},
            //    {l*(1 - Math.Cos(angle*(Math.PI / 180)))*n+ m*Math.Sin(angle*(Math.PI / 180)), m*(1 - Math.Cos(angle*(Math.PI / 180)))*n- l*Math.Sin(angle*(Math.PI / 180)), n*n+Math.Cos(angle*(Math.PI / 180))*(1-n*n), 0},
            //    {0, 0, 0, 1}
            //};
            //Transform(polyhedron, move1);
            //Transform(polyhedron, tM);
            //Transform(polyhedron, move2);
            //refreshFigure();
        }
        private void RotateCenterY(double angle)
        {
           //Point3D p1 = Center(polyhedron);
           //Point3D p2 = new Point3D(p1.X, p1.Y + 100, p1.Z);
           //var x1 = p1.X;
           //var x2 = p2.X;
           //
           //var y1 = p1.Y;
           //var y2 = p2.Y;
           //
           //var z1 = p1.Z;
           //var z2 = p2.Z;
           //
           //var length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
           //var l = (x2 - x1) / length;
           //var m = (y2 - y1) / length;
           //var n = (z2 - z1) / length;
           //double[,] move1 =
           //            {
           //    { 1, 0, 0, -x1},
           //    { 0, 1, 0, -y1},
           //    { 0, 0, 1, -z1},
           //    { 0, 0, 0, 1}
           //};
           //double[,] move2 =
           //            {
           //    { 1, 0, 0, x1},
           //    { 0, 1, 0, y1},
           //    { 0, 0, 1, z1},
           //    { 0, 0, 0, 1}
           //};
           //
           //double[,] tM =
           //    {
           //    {l*l+Math.Cos(angle*(Math.PI / 180))*(1-l*l), l*(1 - Math.Cos(angle*(Math.PI / 180)))*m+ n*Math.Sin(angle*(Math.PI / 180)), l*(1 - Math.Cos(angle*(Math.PI / 180)))*n- m*Math.Sin(angle*(Math.PI / 180)), 0},
           //    {l*(1 - Math.Cos(angle*(Math.PI / 180)))*m- n*Math.Sin(angle*(Math.PI / 180)),m*m+Math.Cos(angle*(Math.PI / 180))*(1-m*m), m*(1 - Math.Cos(angle*(Math.PI / 180)))*n+ l*Math.Sin(angle*(Math.PI / 180)), 0},
           //    {l*(1 - Math.Cos(angle*(Math.PI / 180)))*n+ m*Math.Sin(angle*(Math.PI / 180)), m*(1 - Math.Cos(angle*(Math.PI / 180)))*n- l*Math.Sin(angle*(Math.PI / 180)), n*n+Math.Cos(angle*(Math.PI / 180))*(1-n*n), 0},
           //    {0, 0, 0, 1}
           //};
           //Transform(polyhedron, move1);
           //Transform(polyhedron, tM);
           //Transform(polyhedron, move2);
           //refreshFigure();
        }
        private void buttonRotation_Click(object sender, EventArgs e)
        {
           
        }

        private List<Point3D> rotateP(double angle)
        {
            return new List<Point3D>();
            //polyhedron = new Polyhedron(points);
            //double[,] tM;
            //if (comboBox1.SelectedIndex == 0) // x
            //{
            //    tM = new double[,]
            //{
            //    {1, 0, 0, 0},
            //    {0, Math.Cos(angle * (Math.PI / 180)), -Math.Sin(angle * (Math.PI / 180)), 0},
            //    {0, Math.Sin(angle * (Math.PI / 180)), Math.Cos(angle * (Math.PI / 180)), 0},
            //    {0, 0, 0, 1}
            //};
            //   
            //}
            //else
            //    if (comboBox1.SelectedIndex == 1) //y
            //{
            //    tM = new double[,]
            // {
            //    {Math.Cos(angle * (Math.PI / 180)), 0, Math.Sin(angle * (Math.PI / 180)), 0 },
            //    {0, 1, 0, 0 },
            //    {-Math.Sin(angle * (Math.PI / 180)), 0, Math.Cos(angle * (Math.PI / 180)), 0 },
            //    {0, 0, 0, 1}
            //};
            //   
            //}
            //else
            //      if (comboBox1.SelectedIndex == 2) //z
            //{
            //    tM = new double[,]
            //    {
            //    {Math.Cos(angle * (Math.PI / 180)), -Math.Sin(angle * (Math.PI / 180)), 0, 0},
            //    {Math.Sin(angle * (Math.PI / 180)), Math.Cos(angle * (Math.PI / 180)), 0, 0},
            //    {0, 0, 1, 0},
            //    {0, 0, 0, 1}
            //    };
            //    
            //
            //}
            //else
            //{
            //    tM = new double[,]
            //  {
            //    {1, 0, 0, 0},
            //    {0, 1, 0, 0},
            //    {0, 0, 1, 0},
            //    {0, 0, 0, 1}
            //    };
            //    
            //}
            //double[,] move1 =
            //           {
            //    { 1, 0, 0, -Center(polyhedron).X},
            //    { 0, 1, 0, -Center(polyhedron).Y},
            //    { 0, 0, 1, -Center(polyhedron).Z},
            //    { 0, 0, 0, 1}
            //};
            //Transform(polyhedron, tM);
            //Transform(polyhedron, move1);
            //refreshFigure();
            //List<Point3D> result = new List<Point3D>();
            //foreach (var x in polyhedron.Vertices)
            //{
            //    result.Add(x);
            //}
            //return result;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {

           //  int cnt = points.Count;
           // double angle = 360.0d / ((int)numericUpDown5.Value);
           //
           // polyhedron = new Polyhedron(points);
           // for (int i = 1; i < ((int)numericUpDown5.Value); i++)
           // {
           //     foreach (var p in points)
           //     polyhedron.AdjacencyMatrix.Add(p,   rotateP(angle * i));
           // }

            
            /*
                        for (int i = 0; i < ((int)numericUpDown5.Value); i++)
                        {
                            for (int j = 0; j < cnt; j++)
                            {
                                var current = j + i * cnt;
            foreach (r in point) 
            {
            
            }

            if ((current + 1) % cnt == 0)
                                {
                                    p.AddEdges(fig[current], new List<Point3D> { fig[(current + cnt) % fig.Count] });
                                }
                                else
                                {
                                    p.AddEdges(fig[current], new List<Point3D> { fig[current + 1], fig[(current + cnt) % fig.Count] });
                                }

                            }
                        }
                        polyhedron = p;
                        foreach (var r in polyhedron.useProjection(currentProjection).Edges)
                        {
                            g.DrawLine(globalPen, (int)(r.First.X + midX), (int)(r.First.Y + midY), (int)(r.Second.X + midX), (int)(r.Second.Y + midY));
                        } */

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RotateCenter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                double z = double.Parse(textBox2.Text);
                double y = double.Parse(textBox3.Text);
                double x = double.Parse(textBox4.Text);
                ClearPicture();
                var p = new Point3D(x, y, z);
                points.Add(p);
                g.DrawEllipse(globalPen,(int)x,(int)y,5,5);

                for (int i = 1; i < points.Count; i++)

                {

                    g.DrawLine(globalPen, new Point((int)points[i - 1].X, (int)points[i - 1].Y), new Point((int)points[i].X, (int)points[i].Y));

                }
                g.DrawLine(globalPen, new Point((int)points[points.Count - 1].X, (int)points[points.Count - 1].Y), new Point((int)points[0].X, (int)points[0].Y));


            }
        }

       

        private void DimaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.W)
                buttonW.PerformClick();
            else
                if (e.KeyValue == (char)Keys.A)
                buttonA.PerformClick();
            else
                if (e.KeyValue == (char)Keys.S)
                buttonS.PerformClick();
            else
                if (e.KeyValue == (char)Keys.D)
                buttonD.PerformClick();

            if (e.KeyValue == (char)Keys.Left)
                buttonLeft.PerformClick();
            else if (e.KeyValue == (char)Keys.Right)
                buttonRight.PerformClick();
            else if (e.KeyValue == (char)Keys.Up)
                buttonUp.PerformClick();
            else if (e.KeyValue == (char)Keys.Down)
                buttonDown.PerformClick();
            
        }



        private void buttonRight_Click(object sender, EventArgs e)
        {
            RotateCenterY(-10);
            /*RotateCenterY(-0.7);
            double[,] tM =
            {
                {1, 0, 0, -20},
                {0, 1, 0, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure();*/
        }
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            RotateCenterY(10);
           /* RotateCenterY(0.7);
            double[,] tM =
            {
                {1, 0, 0, 20},
                {0, 1, 0, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure();*/

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
           
            RotateCenterX(-10);
           /* double[,] tM =
            {
                {1, 0, 0, 0},
                {0, 1, 0, 14},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure(); */
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            RotateCenterX(10);
            /*double[,] tM =
            {
                {1, 0, 0, 0},
                {0, 1, 0, -14},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
            };
            Transform(polyhedron, tM);
            refreshFigure(); */
        }

        //private void Transform(Polyhedron t, double[,] m)
        //{
        //    var vert = t.Vertices.ToList();
        //    for (int i = 0; i < vert.Count; i++)
        //    {
        //        double[,] vector = {
        //            { vert[i].Item1.X },
        //            { vert[i].Item1.Y },
        //            { vert[i].Item1.Z },
        //            { 1 }
        //        };
        //        var res = MatrixHelpers.multiply(m, vector);
        //        Point3D newV = new Point3D(res[0, 0], res[1, 0], res[2, 0]);
        //        vert[i] = newV;
        //    }
        //    
        //}



        private void buttonW_Click(object sender, EventArgs e)
        {
            Matrix3D tM = new Matrix3D
                (
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, -20,
                0, 0, 0, 1
            );
            double[,] tM2 =
            {
                {1, 0, 0, 0, },
                {0, 1, 0, 0, },
                {0, 0, 1, -20, },
                {0, 0, 0, 1}
            };
            polyhedron.Transform(tM);
            refreshFigure();
        }
        private void buttonA_Click(object sender, EventArgs e)
        {            

            Matrix3D tM = new Matrix3D
                (
                1, 0, 0, 20,
                0, 1, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            );
            polyhedron.Transform(tM);
            refreshFigure();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {

            Matrix3D tM = new Matrix3D
                (
                1, 0, 0, -20,
                0, 1, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            );
            polyhedron.Transform(tM);
            refreshFigure();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            Matrix3D tM = new Matrix3D
                (
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, 20,
                0, 0, 0, 1
            );
            polyhedron.Transform(tM);
            refreshFigure();
        }
        
        bool InPolygon(Point3D point, Face x)
        {
            List<Point3D> p = new List<Point3D>();
            foreach (var i in x.Edges)
            {
                p.Add(i.First);
                p.Add(i.Second);
            }

            bool result = false;
            int j = p.Count - 1;
            for (int i = 0; i < p.Count; i++)
            {
                if ((p[i].Y < point.Y && p[j].Y >= point.Y || p[j].Y < point.Y && p[i].Y >= point.Y) &&
                     (p[i].X + (point.Y - p[i].Y) / (p[j].Y - p[i].Y) * (p[j].X - p[i].X) < point.X))
                    result = !result;
                j = i;
            }
            return result;
        }
        private void Texturing(Polyhedron p)
        {

            
            Bitmap mp = new Bitmap(mainPictureBox.Image);
            Bitmap image = new Bitmap(pictureBox1.Image, new Size(300,300));
            
            foreach (var x in p.Faces)
            {
                float xMax = int.MinValue;
                float yMax = int.MinValue;
                float yMin = int.MaxValue;
                float xMin = int.MaxValue;
                for (int i = 0; i < x.Edges.Count; i++)
                {
                   if( xMax < Math.Max(x.Edges[i].First.X, x.Edges[i].Second.X))
                     {
                        xMax = (float)Math.Max(x.Edges[i].First.X, x.Edges[i].Second.X);
                    }
                    if (yMax < Math.Max(x.Edges[i].First.Y, x.Edges[i].Second.Y))
                    {
                        yMax = (float)Math.Max(x.Edges[i].First.Y, x.Edges[i].Second.Y);
                    }
                    if (xMin > Math.Min(x.Edges[i].First.X, x.Edges[i].Second.X))
                    {
                        xMin = (float)Math.Min(x.Edges[i].First.X, x.Edges[i].Second.X);
                    }
                    if (yMin > Math.Min(x.Edges[i].First.Y, x.Edges[i].Second.Y))
                    {
                        yMin = (float)Math.Min(x.Edges[i].First.Y,x.Edges[i].Second.Y);
                    }
                    
                }
               
                for (var i = xMin; i < xMax; i++)
                {
                    for (var j = yMin; j < yMax; j++)

                    {
                        if ((mainPictureBox.Width / 2 + i) < mainPictureBox.Width && (mainPictureBox.Height / 2 + j) < mainPictureBox.Height)
                        {
                            Point3D pnt = new Point3D(i,j,0);
                            Point3D pnt2 = new Point3D(i,j, 300);
                            Point3D pnt3 = new Point3D(i,j, - 300);
                            if (InPolygon(pnt,x) || InPolygon(pnt2, x) || InPolygon(pnt3, x)) { 

                             var yd = (yMax - yMin) != 0 ? (yMax - yMin) : 1;
                             var xd = (xMax - xMin) != 0 ? (xMax - xMin) : 1;
                             var u = (i - xMin) / yd;
                             var v = (j - yMin) / xd;
                             u = u > 0  ? u : 0;
                             v = v > 0 ? v : 0;

                            if (u*xMax < 300 && v*yMax < 300)
                            {
                            Color c = image.GetPixel(Math.Abs((int)(u*xMax )), Math.Abs((int)(v*yMax )));
                            

                            mp.SetPixel(Math.Abs(mainPictureBox.Width/2 + (int)i), Math.Abs((int)j + mainPictureBox.Height/ 2), c);
                            }
                            }

                        }
                    }

                }
            }
            mainPictureBox.Image = mp;
            mainPictureBox.Refresh();
            
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                var dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.LoadAsync(dialog.FileName);
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void pickColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            colorPictureBox.BackColor = colorDialog.Color;
            polyhedronColor = colorDialog.Color;
            refreshFigure();
        }

        private void guroXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lightPosition.X = int.Parse(guroXTextBox.Text);
                refreshFigure();
            }
            catch (Exception)
            {

            }
        }

        private void guroYYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lightPosition.Y = int.Parse(guroYYTextBox.Text);
                refreshFigure();
            }
            catch (Exception)
            {

            }
        }

        private void guroZTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lightPosition.Z = int.Parse(guroZTextBox.Text);
                refreshFigure();
            }
            catch (Exception)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Texturing(polyhedron);
            refreshFigure();


        }
    }
}
