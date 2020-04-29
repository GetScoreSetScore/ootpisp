using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shapes;
using Drawer;

namespace laba
{
    public partial class Form1 : Form
    {
        public void DrawShape(Figure shape,Graphics graph)
        {
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Pen pen = new Pen(shape.ShapeColor);
            if (shape is Polygon)
            {
                graph.DrawPolygon(pen, shape.GetBasePoints());
            }
            else
            {
                Point[] vert = shape.GetBasePoints();
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(
                vert[0].X,
                vert[0].Y,
                vert[2].X - vert[0].X,
                vert[2].Y - vert[0].Y);
                graph.DrawEllipse(pen, rect);
            }
        }
        ShapesList list = new ShapesList();   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.list.Add(new Circle(0,0,100,100));
            list.list.Add(new Shapes.Square(100, 100, 200, 200));
            list.list.Add(new Shapes.Pentagon(200, 200, 300, 300));
            list.list.Add(new Shapes.Arrow(0, 100, 100, 200));
            list.list.Add(new Shapes.Romb(100, 0, 200, 100));
            list.list.Add(new Shapes.Ellipse(300, 0, 500, 100));
            list.list.Add(new Shapes.Rectangle(500, 0, 700, 100));
            list.list.Add(new Shapes.Line(500, 100, 700, 200));
            list.list.Add(new Shapes.Triangle(500, 250, 600, 350));
            panel1.Invalidate(); 

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure fig in list.list)
            {

                DrawShape(fig, e.Graphics);
            }
        }
    }
}
