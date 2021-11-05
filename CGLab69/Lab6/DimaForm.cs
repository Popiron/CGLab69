using CGLab69.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CGLab69.Lab6
{
    enum Figures { Tetrahedron, Hexahedron, Octahedron,};

    public partial class DimaForm : Form
    {
        Graphics g;
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
            midX = Size.Width / 2;
            midY = Size.Height / 2 - 300;
            tetraRadioButton.Checked = true;
            perspectiveRadioButton.Checked = true;
            loadFigure();
        }

        private void loadFigure()
        {
            g.Clear(Color.White);
            Polyhedron polyhedron;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxX.Text != "") { 
                double x = Convert.ToDouble(textBoxX);
            }
            if (textBoxY.Text != "")
            {
                double y = Convert.ToDouble(textBoxY);
            }
            if (textBoxZ.Text != "")
            {
                double z = Convert.ToDouble(textBoxZ);
            }
            if (radioButtonOffset.Checked)
            {
               
            }
            else
             if (radioButtonRotation.Checked)
            {

            }    
            else
                if(radioButtonScale.Checked)
            {

            }
        }
    }
}
