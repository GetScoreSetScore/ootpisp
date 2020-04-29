using System.Drawing;
namespace Shapes{
    class Ellipse:ClosedFigure{
        protected Rectangle BaseRectangle;
        public Ellipse() { }
        public Ellipse(int startPointX,int startPointY, int endPointX, int endPointY){
            BaseRectangle=new Rectangle(startPointX,startPointY,endPointX,endPointY);

        }
        override public Point[] GetBasePoints(){
            return BaseRectangle.Vertices;
        } 
    }
}