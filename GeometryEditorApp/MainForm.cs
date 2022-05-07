using System;
using System.ComponentModel;
using System.Windows.Forms;
using math = MathLibrary;
using GeometryLibrary;

namespace GeometryEditorApp
{

    public partial class MainForm : Form
    {

        private Drawing _drawing = new Drawing(new Curve[0]);
        public MainForm()
        { 
          InitializeComponent();    
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e) // Line button 
        {
            math.Point p1 = new math.Point(100, 100);
            math.Point p2 = new math.Point(50, 100);
            Line l1 = new Line(p1, p2);
            l1.Draw(pictureBox1.CreateGraphics());
        }
        private void toolStripButton2_Click_1(object sender, EventArgs e) // Circle button
        {
            math.Point normalVector = new math.Point(200, 200);
            math.Point centerPoint = new math.Point(200, 200);
            double radius = 100;

            GeometryLibrary.Circle c1 = new Circle(centerPoint, normalVector.AsVector().Normalize(), radius);
            c1.Draw(pictureBox1.CreateGraphics());
        }

        private void toolStripButton3_Click(object sender, EventArgs e) // Polyline button 
        {
           List<math.Point> points = new List<math.Point>();

            for (int i = 0; i <= 10; i++)
            {
                Random val = new Random();
                int randX = val.Next(-300, 500);
                int randY = val.Next(-300, 500);
                math.Point point = new math.Point(randX, randY);
                points.Add(point);
            }
            Polyline poly = new Polyline(points.ToArray());
            poly.Draw(pictureBox1.CreateGraphics());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
