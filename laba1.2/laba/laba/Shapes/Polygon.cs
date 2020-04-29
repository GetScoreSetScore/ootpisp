using System.Drawing;
namespace Shapes{
    class Polygon:ClosedFigure{
        protected Point[] vertices;

        public Point[] Vertices { get { return vertices; } set { vertices = value; } }
    
        override public Point[] GetBasePoints(){
            return Vertices;
        } 
    }
}