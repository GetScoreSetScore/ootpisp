using System.Drawing;
namespace Shapes{
    class Square:Shapes.Rectangle{
        public Square(int startPointX, int startPointY, int endPointX, int endPointY)
        {
            Vertices = new Point[4];
            int width = endPointX - startPointX;
            int height = endPointY - startPointY;
            int side = System.Math.Min(System.Math.Abs(height), System.Math.Abs(width));
            if (System.Math.Abs(height) >= System.Math.Abs(width))
            {
                height = System.Math.Sign(height) * System.Math.Abs(width);
            }
            else
            {
                width = System.Math.Sign(width) * System.Math.Abs(height);
            }
            Vertices[0].X=startPointX;
            Vertices[0].Y=startPointY;
            Vertices[1].X=startPointX+width;
            Vertices[1].Y=startPointY;
            Vertices[2].X=startPointX+width;
            Vertices[2].Y=startPointY+height;
            Vertices[3].X=startPointX;
            Vertices[3].Y=startPointY+height;
        }
    }
}