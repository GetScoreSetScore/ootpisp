using System.Drawing;
namespace Shapes{
    class Rectangle:Polygon{
        public Rectangle() { }
        public Rectangle(int startPointX,int startPointY, int endPointX, int endPointY){
            Vertices=new Point[4];
            Vertices[0].X=startPointX;
            Vertices[0].Y=startPointY;
            Vertices[1].X=endPointX;
            Vertices[1].Y=startPointY;
            Vertices[2].X=endPointX;
            Vertices[2].Y=endPointY;
            Vertices[3].X=startPointX;
            Vertices[3].Y=endPointY;
        }
    }
}