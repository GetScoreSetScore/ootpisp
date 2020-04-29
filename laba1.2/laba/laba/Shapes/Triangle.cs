using System.Drawing;
namespace Shapes
{
    class Triangle : Polygon
    {
        public Triangle(int startPointX, int startPointY, int endPointX, int endPointY)
        {
            int width = endPointX - startPointX;
            int height = endPointY - startPointY;
            Vertices = new Point[3];
            Vertices[0].X = (int)(startPointX + width * 0.5);
            Vertices[0].Y = startPointY;

            Vertices[1].X = endPointX;
            Vertices[1].Y = endPointY;

            Vertices[2].X = startPointX;
            Vertices[2].Y = endPointY;

        }
    }
}