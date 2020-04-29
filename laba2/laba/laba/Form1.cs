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
        private bool IsPainting = false;                
        private Point LastPos = new Point(0, 0);   
        private Point StartPos = new Point(0, 0);   
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
        Figure shapetodraw = null;
        delegate Figure selectedShapeTypeDelegate(int startPointX, int startPointY, int endPointX, int endPointY);
        selectedShapeTypeDelegate currentShape= delegate(int startPointX, int startPointY, int endPointX, int endPointY) {
                return new Line(startPointX, startPointY, endPointX, endPointY); 
            };
        public Form1()
        {
            InitializeComponent();
            panel1.GetType().GetMethod("SetStyle",
              System.Reflection.BindingFlags.Instance |
              System.Reflection.BindingFlags.NonPublic).Invoke(panel1,
              new object[]{ System.Windows.Forms.ControlStyles.UserPaint | 
	          System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | 
	          System.Windows.Forms.ControlStyles.DoubleBuffer, true });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            foreach (Figure fig in list.list)
            {

                DrawShape(fig, e.Graphics);
            }
            if (shapetodraw != null )DrawShape(shapetodraw, e.Graphics);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsPainting)
            {
                IsPainting = false;
                list.list.Add(shapetodraw);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsPainting)
            {
                if (LastPos != e.Location)
                {
                    LastPos = e.Location;
                    shapetodraw = currentShape(StartPos.X, StartPos.Y, e.Location.X, e.Location.Y); 
                }

            }
            panel1.Refresh();
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            currentShape = delegate(int startPointX, int startPointY, int endPointX, int endPointY) {
                return new Line(startPointX, startPointY, endPointX, endPointY); 
            };
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            currentShape = delegate(int startPointX, int startPointY, int endPointX, int endPointY)
            {
                return new Shapes.Rectangle(startPointX, startPointY, endPointX, endPointY);
            };
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            currentShape = delegate(int startPointX, int startPointY, int endPointX, int endPointY)
            {
                return new Shapes.Square(startPointX, startPointY, endPointX, endPointY);
            };
        }

        private void buttonRomb_Click(object sender, EventArgs e)
        {
            currentShape = delegate(int startPointX, int startPointY, int endPointX, int endPointY)
            {
                return new Shapes.Romb(startPointX, startPointY, endPointX, endPointY);
            };
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            currentShape = delegate(int startPointX, int startPointY, int endPointX, int endPointY)
            {
                return new Shapes.Triangle(startPointX, startPointY, endPointX, endPointY);
            };
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            currentShape = delegate(int startPointX, int startPointY, int endPointX, int endPointY)
            {
                return new Shapes.Ellipse(startPointX, startPointY, endPointX, endPointY);
            };
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            currentShape = delegate(int startPointX, int startPointY, int endPointX, int endPointY)
            {
                return new Shapes.Circle(startPointX, startPointY, endPointX, endPointY);
            };
        }

        private void buttonPentagon_Click(object sender, EventArgs e)
        {
            currentShape = delegate(int startPointX, int startPointY, int endPointX, int endPointY)
            {
                return new Shapes.Pentagon(startPointX, startPointY, endPointX, endPointY);
            };
        }

        private void buttonArrow_Click(object sender, EventArgs e)
        {
            currentShape = delegate(int startPointX, int startPointY, int endPointX, int endPointY)
            {
                return new Shapes.Arrow(startPointX, startPointY, endPointX, endPointY);
            };
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            IsPainting = true;
            LastPos = new Point(0, 0);
            StartPos = e.Location;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            list.list.Clear();
            shapetodraw = null;
            panel1.Refresh();
        }
    }
}
