using System.Drawing;
namespace Shapes
{
    class Pentagon : Polygon
    {
        public Pentagon(int startPointX, int startPointY, int endPointX, int endPointY)
        {
            int width = endPointX - startPointX;
            int height = endPointY - startPointY;
            Vertices = new Point[5];
            Vertices[0].X = (int)(startPointX+width*0.5);
            Vertices[0].Y = startPointY;

            Vertices[1].X = endPointX;
            Vertices[1].Y = (int)(startPointY+height*2/5);
            
            Vertices[2].X = (int)(startPointX+width*0.8);
            Vertices[2].Y = endPointY;

            Vertices[3].X = (int)(startPointX + width * 0.2);
            Vertices[3].Y = endPointY;

            Vertices[4].X = startPointX;
            Vertices[4].Y = (int)(startPointY + height * 2 / 5);
        }
    }
}