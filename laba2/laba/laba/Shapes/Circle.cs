namespace Shapes{
    class Circle:Ellipse{
        public Circle(int startPointX,int startPointY, int endPointX, int endPointY){
            BaseRectangle = new Square(startPointX, startPointY, endPointX, endPointY);
        }
    }
}