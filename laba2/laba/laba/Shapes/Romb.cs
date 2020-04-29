using System.Drawing;
namespace Shapes
{
    class Romb : Polygon
    {
        public Romb(int startPointX, int startPointY, int endPointX, int endPointY)
        {
            int width = endPointX - startPointX;
            int height = endPointY - startPointY;
            Vertices = new Point[4];
            Vertices[0].X = (int)(startPointX + width * 0.5);
            Vertices[0].Y = startPointY;

            Vertices[1].X = endPointX;
            Vertices[1].Y = (int)(startPointY + height * 0.5);

            Vertices[2].X = (int)(startPointX + width * 0.5);
            Vertices[2].Y = endPointY;

            Vertices[3].X = startPointX;
            Vertices[3].Y = (int)(startPointY + height * 0.5);
        }
    }
}