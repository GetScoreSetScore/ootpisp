using System.Drawing;
namespace Shapes{
    class Square:Shapes.Rectangle{
        public Square(int startPointX, int startPointY, int endPointX, int endPointY)
        {
            Vertices = new Point[4];
            int width = endPointX - startPointX;
            int height = endPointY - startPointY;
            int side = (height >= width) ? width : height;
            Vertices[0].X=startPointX;
            Vertices[0].Y=startPointY;
            Vertices[1].X=startPointX+side;
            Vertices[1].Y=startPointY;
            Vertices[2].X=startPointX+side;
            Vertices[2].Y=startPointY+side;
            Vertices[3].X=startPointX;
            Vertices[3].Y=startPointY+side;
        }
    }
}