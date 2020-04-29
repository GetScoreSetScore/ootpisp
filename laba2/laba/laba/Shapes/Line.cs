using System.Drawing;
namespace Shapes
{
    class Line : Polygon
    {
        public Line(int startPointX, int startPointY, int endPointX, int endPointY)
        {
            Vertices = new Point[2];
            Vertices[0].X = startPointX;
            Vertices[0].Y = startPointY;

            Vertices[1].X = endPointX;
            Vertices[1].Y = endPointY;
        }
    }
}