using System.Drawing;
namespace Shapes
{
    class Arrow : Polygon
    {
        public Arrow(int startPointX, int startPointY, int endPointX, int endPointY)
        {
            int width = endPointX - startPointX;
            int height = endPointY - startPointY;
            Vertices = new Point[7];
            Vertices[0].X = (int)(startPointX + width * 0.5);
            Vertices[0].Y = startPointY;

            Vertices[1].X = endPointX;
            Vertices[1].Y = (int)(startPointY + height * 0.5);

            Vertices[2].X = (int)(startPointX + width * 0.5);
            Vertices[2].Y = endPointY;

            Vertices[3].X = (int)(startPointX + width * 0.5);
            Vertices[3].Y = (int)(startPointY + height * 0.75);

            Vertices[4].X = startPointX;
            Vertices[4].Y = (int)(startPointY + height * 0.75);

            Vertices[5].X = startPointX;
            Vertices[5].Y = (int)(startPointY + height * 0.25);

            Vertices[6].X = (int)(startPointX + width * 0.5);
            Vertices[6].Y = (int)(startPointY + height * 0.25);
        }
    }
}