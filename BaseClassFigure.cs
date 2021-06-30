using System.Drawing;

namespace DZ_24_01_2021
{
    public abstract class BaseClassFigure 
    {
        protected Point pointStart;
        protected Point pointEnd;
        protected int width;
        protected int height;      
        protected Pen pen;       
        protected SolidBrush brushFill;
        protected bool selectFill;
        protected BaseClassFigure(Point pointStart, Point pointEnd, Pen pen, SolidBrush brushFill, bool selectFill)
        {
            this.pointStart = pointStart;
            this.pointEnd = pointEnd;
            width = -pointStart.X + pointEnd.X;
            height = -pointStart.Y + pointEnd.Y;
            this.pen = pen;
            this.brushFill = brushFill;
            this.selectFill = selectFill;
        }        
        public virtual void Show(Graphics temp) { }
    }
}
