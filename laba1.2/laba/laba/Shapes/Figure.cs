using System.Drawing;
namespace Shapes{
    public abstract class Figure{
        private int rotaion;
        protected Color color=Color.Red;
        public Color ShapeColor
        {
            get  
            {
                return color;  
            }  
            set  
            {
                color = value;  
            }  
        }
        public int Rotation{
            get  
            {  
                return rotaion;  
            }  
            set  
            {  
                rotaion = value;  
            }  
        }
        public abstract Point[] GetBasePoints();
    }
}