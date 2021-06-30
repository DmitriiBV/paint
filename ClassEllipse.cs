using System.Drawing;

namespace DZ_24_01_2021
{
    public class ClassEllipse: BaseClassFigure
    {       
        public ClassEllipse(Point pointStart, Point pointEnd, Pen pen, SolidBrush brushFill, bool selectFill) : base(pointStart, pointEnd, pen, brushFill, selectFill)
        {            
        }
        public override void Show(Graphics temp)
        {
            temp.DrawEllipse(pen, pointStart.X, pointStart.Y, width, height);
            if (selectFill == true)
            {
                temp.FillEllipse(brushFill, new Rectangle(pointStart.X, pointStart.Y, width, height));
            }            
        }
    }
}
